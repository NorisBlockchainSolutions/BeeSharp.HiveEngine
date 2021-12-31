#nullable enable
using System;
using System.Collections.Generic;
using BeeSharp.ApiComponents.ApiModels.JsonConverter.Annotations;
using BeeSharp.ApiComponents.ApiModels.JsonConverter.DirectorComponents;
using BeeSharp.HiveEngine.ApiComponents.ApiModels.BroadcastOps.CustomJson.HiveEngine;
using BeeSharp.HiveEngine.ApiComponents.ApiModels.JsonConverter.Annotations;
using BeeSharp.root.DebugInfoProvider;

namespace BeeSharp.HiveEngine.ApiComponents.ApiModels.JsonConverter.BroadcastOp.CustomJson.HiveEngine
{
    public class HiveEngineContractDirector : JsonDirector
    {
        private readonly IDictionary<(string, string), Type> _hiveEngineContractRegister
            = new Dictionary<(string, string), Type>();

        public HiveEngineContractDirector(ITypeAssignedAttributeFetcher typeAssignedAttributeFetcher,
            string[] assemblies) : base(typeAssignedAttributeFetcher, assemblies, 
            new []{typeof(HiveEngineContractAttribute)}) {}

        public override void Register(Attribute attribute, Type structure)
        {
            if (attribute is not HiveEngineContractAttribute hiveEngineContractAttribute)
                throw new InvalidCastException($"Cannot process attribute of type {attribute.GetType()}!");

            var contractName = hiveEngineContractAttribute.ContractName;
            var contractAction = hiveEngineContractAttribute.ContractAction;
            if (!_hiveEngineContractRegister.TryAdd((contractName, 
                contractAction), structure))
                throw new ArgumentException($"Contract already registered: {contractName} {contractAction}!");
        }

        public override Type? GetStructure(params string[] identifiers)
        {
            if (identifiers.Length != 2)
                throw new ArgumentException("Invalid identifiers count, has to be 2!");
            
            if (_hiveEngineContractRegister.TryGetValue((identifiers[0], identifiers[1]), out var result))
                return result;

            DirectorInfoProvider.OnUnregisteredTypeRequested(typeof(HiveEngineContractDirector), 
                new UnregisteredTypeEventArgs(nameof(HiveEngineContractDirector),
            $"Missing contract: {identifiers[0]} {identifiers[1]}!"));

            return null;
        }
        
        // Event handling
        public event EventHandler<HiveEngineOperation>? HiveEngineOperationSerialized;

        internal void OnHiveEngineOperationSerialized(HiveEngineOperation operation)
        {
            HiveEngineOperationSerialized?.Invoke(this, operation);
        }
    }
}