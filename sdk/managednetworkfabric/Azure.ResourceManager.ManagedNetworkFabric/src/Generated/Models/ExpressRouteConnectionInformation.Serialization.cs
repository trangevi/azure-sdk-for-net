// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ManagedNetworkFabric.Models
{
    public partial class ExpressRouteConnectionInformation : IUtf8JsonSerializable, IJsonModel<ExpressRouteConnectionInformation>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ExpressRouteConnectionInformation>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ExpressRouteConnectionInformation>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExpressRouteConnectionInformation>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ExpressRouteConnectionInformation)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("expressRouteCircuitId"u8);
            writer.WriteStringValue(ExpressRouteCircuitId);
            if (Optional.IsDefined(ExpressRouteAuthorizationKey))
            {
                writer.WritePropertyName("expressRouteAuthorizationKey"u8);
                writer.WriteStringValue(ExpressRouteAuthorizationKey);
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value, ModelSerializationExtensions.JsonDocumentOptions))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
        }

        ExpressRouteConnectionInformation IJsonModel<ExpressRouteConnectionInformation>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExpressRouteConnectionInformation>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ExpressRouteConnectionInformation)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeExpressRouteConnectionInformation(document.RootElement, options);
        }

        internal static ExpressRouteConnectionInformation DeserializeExpressRouteConnectionInformation(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier expressRouteCircuitId = default;
            string expressRouteAuthorizationKey = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("expressRouteCircuitId"u8))
                {
                    expressRouteCircuitId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("expressRouteAuthorizationKey"u8))
                {
                    expressRouteAuthorizationKey = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ExpressRouteConnectionInformation(expressRouteCircuitId, expressRouteAuthorizationKey, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ExpressRouteConnectionInformation>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExpressRouteConnectionInformation>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerManagedNetworkFabricContext.Default);
                default:
                    throw new FormatException($"The model {nameof(ExpressRouteConnectionInformation)} does not support writing '{options.Format}' format.");
            }
        }

        ExpressRouteConnectionInformation IPersistableModel<ExpressRouteConnectionInformation>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExpressRouteConnectionInformation>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeExpressRouteConnectionInformation(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ExpressRouteConnectionInformation)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ExpressRouteConnectionInformation>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
