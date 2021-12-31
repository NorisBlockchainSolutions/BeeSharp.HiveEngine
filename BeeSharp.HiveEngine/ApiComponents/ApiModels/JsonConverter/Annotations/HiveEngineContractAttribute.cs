using System;

namespace BeeSharp.HiveEngine.ApiComponents.ApiModels.JsonConverter.Annotations
{
    [AttributeUsage(AttributeTargets.Class)]
    public class HiveEngineContractAttribute : Attribute
    {
        public string ContractName { get; }
        public string ContractAction { get; }

        public Type? OptionalModel { get; }

        public HiveEngineContractAttribute(string contractName, string contractAction, Type? optionalModel = null)
        {
            ContractName = contractName;
            ContractAction = contractAction;
            OptionalModel = optionalModel;
        }
    }
}