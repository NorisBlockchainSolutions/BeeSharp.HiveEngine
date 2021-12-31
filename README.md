# BeeSharp.HiveEngine - BeeSharp extension for HiveEngine
This project is an extension to BeeSharp that provides models
and serializers for adding HiveEngine support to BeeSharp.

## Configuration
To use this extension, load it into your project and add "BeeSharp.HiveEngine"
to the list of assemblies used by BeeSharp.

Additionally, modify your BeeSharpDefaultInitializer to add the new Director:
ContainerConfig > DirectorManager.cs > RegisterDirectors:

    var hiveEngineDirector = containerScope.Resolve<HiveEngineContractDirector>();
    ...
    DirectorRegistry.AddDirector(typeof(HiveEngineContractDirector), hiveEngineDirector);

ContainerConfig > DirectorContainerConfig.cs > RegisterDirectors:

    builder.RegisterType<HiveEngineContractDirector>()
        .WithParameter(new TypedParameter(typeof(string[]), assemblies))
        .SingleInstance();
## Reading block content
There are two different methods of extracting HiveEngine operations from block transactions: downcasting
and an event handler.

Downcasting requires to select transactions that match all along the hierarchy:
    
    var block = await condenser.GetCondenserApiCallResultAsync(
    new CondenserApiGetBlock(57286840));

    // Extract all token transfer elements using downcasting
    var results = block.Transactions.Where(
            t => t.Operation.Length == 1 &&
                 t.Operation[0].Operation is BroadcastOpCustomJsonModel)
        .Select(t => (BroadcastOpCustomJsonModel)t.Operation[0].Operation)
        .Where(t => 
            t.Json.JsonModel is ObjectListOrObjectWrapperModel<HiveEngineTransactionModel>)
        .Select(t => 
            (ObjectListOrObjectWrapperModel<HiveEngineTransactionModel>)t!.Json.JsonModel)
        .Where(t => t.Transactions.Length == 1 &&
            t.Transactions[0].HiveEngineContractPayloadModel is HiveEngineTokensTransferModel)
        .Select(t => 
            (HiveEngineTokensTransferModel)t.Transactions[0].HiveEngineContractPayloadModel)
        .ToArray();
    
    Console.WriteLine("How many results: " + results.Length);
    Console.WriteLine("Which token: " + results[0].Symbol);

Registering an event handler can be faster and more readable, depending on your scenario:

First we need to create our event handler:

    public static void HiveEngineTransactionSerializedHandler(object? sender, HiveEngineOperation operation)
    {
        if (operation is HiveEngineTokensTransferModel transferModel)
        {
            Console.WriteLine("Which token: " + transferModel.Symbol);
        }
    }

We then proceed to fetch the block:

    var director = condenserAdapter.ResolveContainerComponent<HiveEngineContractDirector>();
    director.HiveEngineOperationSerialized += HiveEngineTransactionSerializedHandler;

    await condenser.GetCondenserApiCallResultAsync(
        new CondenserApiGetBlock(57286840));

## Serialization
### Warning: Broadcasting transactions is still WIP! Use at your own risk!
This is an example using modified code from the GetStarted > BroadcastingToBlockchain wiki entry.

We transfer hive-engine tokens from one account to another (this requires an according privateKey
and an instance of broadcastTransaction, which were created earlier in the BeeSharp GetStarted tutorials).
We proceed sending one TESTTOKEN from alice to Bob:

    var response = await broadcastTransaction.CondenserApiBroadcastTransaction(
                new[]
                {
                    new BroadcastOpCustomJsonModel(new []{"alice"}, null,
                        "ssc-mainnet-hive", new CustomJsonWrapperModel(
                            new HiveEngineTransactionModel(
                                "tokens",
                                "transfer",
                                new HiveEngineTokensTransferModel(
                                    "TESTTOKEN",
                                    "bob",
                                    new DecimalOrStringModel("1")
                                )
                        )))