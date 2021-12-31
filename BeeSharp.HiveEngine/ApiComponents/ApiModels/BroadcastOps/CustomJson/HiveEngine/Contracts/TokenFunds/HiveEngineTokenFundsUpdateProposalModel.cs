using System;
using System.Text.Json.Serialization;
using BeeSharp.ApiComponents.ApiModels.JsonConverter.Annotations;
using BeeSharp.HiveEngine.ApiComponents.ApiModels.JsonConverter.Annotations;
using BeeSharp.HiveEngine.ApiComponents.ApiModels.JsonConverter.BroadcastOp.CustomJson.HiveEngine;

namespace BeeSharp.HiveEngine.ApiComponents.ApiModels.BroadcastOps.CustomJson.HiveEngine.Contracts.TokenFunds
{
    [HiveEngineContract("tokenfunds", "updateProposal")]
    public class HiveEngineTokenFundsUpdateProposalModel : HiveEngineOperation
    {
        [JsonPropertyName("id")] public string Id { get; }
        [JsonPropertyName("title")] public string Title { get; }

        [JsonConverter(typeof(ThreeSecondDigitsPrecisionDateTimeJsonConverter))]
        [JsonPropertyName("endDate")]
        public DateTime EndDate { get; }

        [JsonPropertyName("amountPerDay")] public string AmountPerDay { get; }
        [JsonPropertyName("authorPermlink")] public string AuthorPermlink { get; }

        public HiveEngineTokenFundsUpdateProposalModel(string id, string title, DateTime endDate, string amountPerDay,
            string authorPermlink)
        {
            Id = id;
            Title = title;
            EndDate = endDate;
            AmountPerDay = amountPerDay;
            AuthorPermlink = authorPermlink;
        }
    }
}