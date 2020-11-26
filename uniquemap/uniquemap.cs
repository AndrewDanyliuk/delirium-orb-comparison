﻿// <auto-generated />
//
// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using uniquemap;
//
//    var uniqueMap = UniqueMap.FromJson(jsonString);

namespace uniquemap
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class UniqueMap
    {
        [JsonProperty("lines")]
        public List<Line> Lines { get; set; }

        [JsonProperty("language")]
        public Language Language { get; set; }
    }

    public partial class Language
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("translations")]
        public Translations Translations { get; set; }
    }

    public partial class Translations
    {
    }

    public partial class Line
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("icon")]
        public Uri Icon { get; set; }

        [JsonProperty("mapTier")]
        public long MapTier { get; set; }

        [JsonProperty("levelRequired")]
        public long LevelRequired { get; set; }

        [JsonProperty("baseType")]
        public string BaseType { get; set; }

        [JsonProperty("stackSize")]
        public long StackSize { get; set; }

        [JsonProperty("variant")]
        public object Variant { get; set; }

        [JsonProperty("prophecyText")]
        public object ProphecyText { get; set; }

        [JsonProperty("artFilename")]
        public object ArtFilename { get; set; }

        [JsonProperty("links")]
        public long Links { get; set; }

        [JsonProperty("itemClass")]
        public long ItemClass { get; set; }

        [JsonProperty("sparkline")]
        public Sparkline Sparkline { get; set; }

        [JsonProperty("lowConfidenceSparkline")]
        public LowConfidenceSparkline LowConfidenceSparkline { get; set; }

        [JsonProperty("implicitModifiers")]
        public List<object> ImplicitModifiers { get; set; }

        [JsonProperty("explicitModifiers")]
        public List<ExplicitModifier> ExplicitModifiers { get; set; }

        [JsonProperty("flavourText")]
        public string FlavourText { get; set; }

        [JsonProperty("corrupted")]
        public bool Corrupted { get; set; }

        [JsonProperty("gemLevel")]
        public long GemLevel { get; set; }

        [JsonProperty("gemQuality")]
        public long GemQuality { get; set; }

        [JsonProperty("itemType")]
        public ItemType ItemType { get; set; }

        [JsonProperty("chaosValue")]
        public double ChaosValue { get; set; }

        [JsonProperty("exaltedValue")]
        public double ExaltedValue { get; set; }

        [JsonProperty("count")]
        public long Count { get; set; }

        [JsonProperty("detailsId")]
        public string DetailsId { get; set; }

        [JsonProperty("tradeInfo")]
        public object TradeInfo { get; set; }

        [JsonProperty("mapRegion")]
        public MapRegion? MapRegion { get; set; }
    }

    public partial class ExplicitModifier
    {
        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("optional")]
        public bool Optional { get; set; }
    }

    public partial class LowConfidenceSparkline
    {
        [JsonProperty("data")]
        public List<double?> Data { get; set; }

        [JsonProperty("totalChange")]
        public double TotalChange { get; set; }
    }

    public partial class Sparkline
    {
        [JsonProperty("data")]
        public List<double?> Data { get; set; }

        [JsonProperty("totalChange")]
        public double TotalChange { get; set; }
    }

    public enum ItemType { Unknown };

    public enum MapRegion { GlennachCairns, HaewarkHamlet, LexEjoris, LexProxima, NewVastir, TirnSEnd, ValdoSRest };

    public partial class UniqueMap
    {
        public static UniqueMap FromJson(string json) => JsonConvert.DeserializeObject<UniqueMap>(json, uniquemap.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this UniqueMap self) => JsonConvert.SerializeObject(self, uniquemap.Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                ItemTypeConverter.Singleton,
                MapRegionConverter.Singleton,
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }

    internal class ItemTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(ItemType) || t == typeof(ItemType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "Unknown")
            {
                return ItemType.Unknown;
            }
            throw new Exception("Cannot unmarshal type ItemType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (ItemType)untypedValue;
            if (value == ItemType.Unknown)
            {
                serializer.Serialize(writer, "Unknown");
                return;
            }
            throw new Exception("Cannot marshal type ItemType");
        }

        public static readonly ItemTypeConverter Singleton = new ItemTypeConverter();
    }

    internal class MapRegionConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(MapRegion) || t == typeof(MapRegion?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "Glennach Cairns":
                    return MapRegion.GlennachCairns;
                case "Haewark Hamlet":
                    return MapRegion.HaewarkHamlet;
                case "Lex Ejoris":
                    return MapRegion.LexEjoris;
                case "Lex Proxima":
                    return MapRegion.LexProxima;
                case "New Vastir":
                    return MapRegion.NewVastir;
                case "Tirn's End":
                    return MapRegion.TirnSEnd;
                case "Valdo's Rest":
                    return MapRegion.ValdoSRest;
            }
            throw new Exception("Cannot unmarshal type MapRegion");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (MapRegion)untypedValue;
            switch (value)
            {
                case MapRegion.GlennachCairns:
                    serializer.Serialize(writer, "Glennach Cairns");
                    return;
                case MapRegion.HaewarkHamlet:
                    serializer.Serialize(writer, "Haewark Hamlet");
                    return;
                case MapRegion.LexEjoris:
                    serializer.Serialize(writer, "Lex Ejoris");
                    return;
                case MapRegion.LexProxima:
                    serializer.Serialize(writer, "Lex Proxima");
                    return;
                case MapRegion.NewVastir:
                    serializer.Serialize(writer, "New Vastir");
                    return;
                case MapRegion.TirnSEnd:
                    serializer.Serialize(writer, "Tirn's End");
                    return;
                case MapRegion.ValdoSRest:
                    serializer.Serialize(writer, "Valdo's Rest");
                    return;
            }
            throw new Exception("Cannot marshal type MapRegion");
        }

        public static readonly MapRegionConverter Singleton = new MapRegionConverter();
    }
}
