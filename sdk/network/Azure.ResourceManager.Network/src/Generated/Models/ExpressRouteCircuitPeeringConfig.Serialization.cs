// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class ExpressRouteCircuitPeeringConfig : IUtf8JsonSerializable, IJsonModel<ExpressRouteCircuitPeeringConfig>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ExpressRouteCircuitPeeringConfig>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ExpressRouteCircuitPeeringConfig>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExpressRouteCircuitPeeringConfig>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ExpressRouteCircuitPeeringConfig)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(AdvertisedPublicPrefixes))
            {
                writer.WritePropertyName("advertisedPublicPrefixes"u8);
                writer.WriteStartArray();
                foreach (var item in AdvertisedPublicPrefixes)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(AdvertisedCommunities))
            {
                writer.WritePropertyName("advertisedCommunities"u8);
                writer.WriteStartArray();
                foreach (var item in AdvertisedCommunities)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(AdvertisedPublicPrefixesState))
            {
                writer.WritePropertyName("advertisedPublicPrefixesState"u8);
                writer.WriteStringValue(AdvertisedPublicPrefixesState.Value.ToString());
            }
            if (Optional.IsDefined(LegacyMode))
            {
                writer.WritePropertyName("legacyMode"u8);
                writer.WriteNumberValue(LegacyMode.Value);
            }
            if (Optional.IsDefined(CustomerASN))
            {
                writer.WritePropertyName("customerASN"u8);
                writer.WriteNumberValue(CustomerASN.Value);
            }
            if (Optional.IsDefined(RoutingRegistryName))
            {
                writer.WritePropertyName("routingRegistryName"u8);
                writer.WriteStringValue(RoutingRegistryName);
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        ExpressRouteCircuitPeeringConfig IJsonModel<ExpressRouteCircuitPeeringConfig>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExpressRouteCircuitPeeringConfig>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ExpressRouteCircuitPeeringConfig)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeExpressRouteCircuitPeeringConfig(document.RootElement, options);
        }

        internal static ExpressRouteCircuitPeeringConfig DeserializeExpressRouteCircuitPeeringConfig(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IList<string>> advertisedPublicPrefixes = default;
            Optional<IList<string>> advertisedCommunities = default;
            Optional<ExpressRouteCircuitPeeringAdvertisedPublicPrefixState> advertisedPublicPrefixesState = default;
            Optional<int> legacyMode = default;
            Optional<int> customerASN = default;
            Optional<string> routingRegistryName = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("advertisedPublicPrefixes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    advertisedPublicPrefixes = array;
                    continue;
                }
                if (property.NameEquals("advertisedCommunities"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    advertisedCommunities = array;
                    continue;
                }
                if (property.NameEquals("advertisedPublicPrefixesState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    advertisedPublicPrefixesState = new ExpressRouteCircuitPeeringAdvertisedPublicPrefixState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("legacyMode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    legacyMode = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("customerASN"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    customerASN = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("routingRegistryName"u8))
                {
                    routingRegistryName = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ExpressRouteCircuitPeeringConfig(Optional.ToList(advertisedPublicPrefixes), Optional.ToList(advertisedCommunities), Optional.ToNullable(advertisedPublicPrefixesState), Optional.ToNullable(legacyMode), Optional.ToNullable(customerASN), routingRegistryName.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ExpressRouteCircuitPeeringConfig>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExpressRouteCircuitPeeringConfig>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ExpressRouteCircuitPeeringConfig)} does not support '{options.Format}' format.");
            }
        }

        ExpressRouteCircuitPeeringConfig IPersistableModel<ExpressRouteCircuitPeeringConfig>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExpressRouteCircuitPeeringConfig>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeExpressRouteCircuitPeeringConfig(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ExpressRouteCircuitPeeringConfig)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ExpressRouteCircuitPeeringConfig>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
