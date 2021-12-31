﻿using System.Text.Json.Serialization;
using BeeSharp.ApiComponents.ApiModels;
using BeeSharp.ApiComponents.ApiModels.JsonConverter.Annotations;
using BeeSharp.HiveEngine.ApiComponents.ApiModels.JsonConverter.Annotations;

namespace BeeSharp.HiveEngine.ApiComponents.ApiModels.BroadcastOps.CustomJson.HiveEngine.Contracts.Market
{
    [HiveEngineContract("market", "sell")]
    public class HiveEngineMarketSellModel : HiveEngineOperation
    {
        [JsonPropertyName("symbol")] public string Symbol { get; }
        [JsonPropertyName("quantity")] public DecimalOrStringModel Quantity { get; }
        [JsonPropertyName("price")] public DecimalOrStringModel Price { get; }
        
        public HiveEngineMarketSellModel(string symbol, DecimalOrStringModel quantity, DecimalOrStringModel price)
        {
            Symbol = symbol;
            Quantity = quantity;
            Price = price;
        }
    }
}