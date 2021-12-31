using System;
using System.Text.Json.Serialization;
using BeeSharp.ApiComponents.ApiModels.JsonConverter.Annotations;
using BeeSharp.HiveEngine.ApiComponents.ApiModels.JsonConverter.Annotations;
using BeeSharp.HiveEngine.ApiComponents.ApiModels.JsonConverter.BroadcastOp.CustomJson.HiveEngine;

namespace BeeSharp.HiveEngine.ApiComponents.ApiModels.BroadcastOps.CustomJson.HiveEngine.Contracts.TokenFunds
{
    [HiveEngineContract("tokenfunds", "createProposal")]
    public class HiveEngineTokenFundsCreateProposalModel : HiveEngineOperation
    {
        [JsonPropertyName("fundId")] public string FundId { get; }
        [JsonPropertyName("title")] public string Title { get; }
        [JsonConverter(typeof(ThreeSecondDigitsPrecisionDateTimeJsonConverter))]
        [JsonPropertyName("startDate")] public DateTime StartDate { get; }
        [JsonConverter(typeof(ThreeSecondDigitsPrecisionDateTimeJsonConverter))]
        [JsonPropertyName("endDate")] public DateTime EndDate { get; }
        [JsonPropertyName("amountPerDay")] public string AmountPerDay { get; }
        [JsonPropertyName("authorPermlink")] public string AuthorPermlink { get; }
        [JsonPropertyName("payout")] public HiveEngineTokenFundsPayoutModel Payout { get; }

        public HiveEngineTokenFundsCreateProposalModel(string fundId, string title, DateTime startDate,
            DateTime endDate, string amountPerDay, string authorPermlink, HiveEngineTokenFundsPayoutModel payout)
        {
            FundId = fundId;
            Title = title;
            StartDate = startDate;
            EndDate = endDate;
            AmountPerDay = amountPerDay;
            AuthorPermlink = authorPermlink;
            Payout = payout;
        }
    }

    public class HiveEngineTokenFundsPayoutModel
    {
        [JsonPropertyName("type")] public string Type { get; }
        [JsonPropertyName("name")] public string Name { get; }
        [JsonPropertyName("contractPayload")] public object ContractPayload { get; }

        public HiveEngineTokenFundsPayoutModel(string type, string name, object contractPayload)
        {
            Type = type;
            Name = name;
            ContractPayload = contractPayload;
        }
    }
}