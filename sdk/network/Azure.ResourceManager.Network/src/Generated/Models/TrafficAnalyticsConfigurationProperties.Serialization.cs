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
    public partial class TrafficAnalyticsConfigurationProperties : IUtf8JsonSerializable, IJsonModel<TrafficAnalyticsConfigurationProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<TrafficAnalyticsConfigurationProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<TrafficAnalyticsConfigurationProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TrafficAnalyticsConfigurationProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(TrafficAnalyticsConfigurationProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Enabled))
            {
                writer.WritePropertyName("enabled"u8);
                writer.WriteBooleanValue(Enabled.Value);
            }
            if (Optional.IsDefined(WorkspaceId))
            {
                writer.WritePropertyName("workspaceId"u8);
                writer.WriteStringValue(WorkspaceId);
            }
            if (Optional.IsDefined(WorkspaceRegion))
            {
                writer.WritePropertyName("workspaceRegion"u8);
                writer.WriteStringValue(WorkspaceRegion);
            }
            if (Optional.IsDefined(WorkspaceResourceId))
            {
                writer.WritePropertyName("workspaceResourceId"u8);
                writer.WriteStringValue(WorkspaceResourceId);
            }
            if (Optional.IsDefined(TrafficAnalyticsIntervalInMinutes))
            {
                writer.WritePropertyName("trafficAnalyticsInterval"u8);
                writer.WriteNumberValue(TrafficAnalyticsIntervalInMinutes.Value);
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

        TrafficAnalyticsConfigurationProperties IJsonModel<TrafficAnalyticsConfigurationProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TrafficAnalyticsConfigurationProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(TrafficAnalyticsConfigurationProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeTrafficAnalyticsConfigurationProperties(document.RootElement, options);
        }

        internal static TrafficAnalyticsConfigurationProperties DeserializeTrafficAnalyticsConfigurationProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<bool> enabled = default;
            Optional<string> workspaceId = default;
            Optional<string> workspaceRegion = default;
            Optional<ResourceIdentifier> workspaceResourceId = default;
            Optional<int> trafficAnalyticsInterval = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("enabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("workspaceId"u8))
                {
                    workspaceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("workspaceRegion"u8))
                {
                    workspaceRegion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("workspaceResourceId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    workspaceResourceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("trafficAnalyticsInterval"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    trafficAnalyticsInterval = property.Value.GetInt32();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new TrafficAnalyticsConfigurationProperties(Optional.ToNullable(enabled), workspaceId.Value, workspaceRegion.Value, workspaceResourceId.Value, Optional.ToNullable(trafficAnalyticsInterval), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<TrafficAnalyticsConfigurationProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TrafficAnalyticsConfigurationProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(TrafficAnalyticsConfigurationProperties)} does not support '{options.Format}' format.");
            }
        }

        TrafficAnalyticsConfigurationProperties IPersistableModel<TrafficAnalyticsConfigurationProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TrafficAnalyticsConfigurationProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeTrafficAnalyticsConfigurationProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(TrafficAnalyticsConfigurationProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<TrafficAnalyticsConfigurationProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
