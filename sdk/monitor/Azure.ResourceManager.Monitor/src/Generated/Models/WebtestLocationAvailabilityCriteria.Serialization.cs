// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Monitor.Models
{
    public partial class WebtestLocationAvailabilityCriteria : IUtf8JsonSerializable, IJsonModel<WebtestLocationAvailabilityCriteria>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<WebtestLocationAvailabilityCriteria>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<WebtestLocationAvailabilityCriteria>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WebtestLocationAvailabilityCriteria>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(WebtestLocationAvailabilityCriteria)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            writer.WritePropertyName("webTestId"u8);
            writer.WriteStringValue(WebTestId);
            writer.WritePropertyName("componentId"u8);
            writer.WriteStringValue(ComponentId);
            writer.WritePropertyName("failedLocationCount"u8);
            writer.WriteNumberValue(FailedLocationCount);
            foreach (var item in AdditionalProperties)
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

        WebtestLocationAvailabilityCriteria IJsonModel<WebtestLocationAvailabilityCriteria>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WebtestLocationAvailabilityCriteria>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(WebtestLocationAvailabilityCriteria)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeWebtestLocationAvailabilityCriteria(document.RootElement, options);
        }

        internal static WebtestLocationAvailabilityCriteria DeserializeWebtestLocationAvailabilityCriteria(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier webTestId = default;
            ResourceIdentifier componentId = default;
            float failedLocationCount = default;
            MonitorOdataType odataType = default;
            IDictionary<string, BinaryData> additionalProperties = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("webTestId"u8))
                {
                    webTestId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("componentId"u8))
                {
                    componentId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("failedLocationCount"u8))
                {
                    failedLocationCount = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("odata.type"u8))
                {
                    odataType = new MonitorOdataType(property.Value.GetString());
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
            }
            additionalProperties = additionalPropertiesDictionary;
            return new WebtestLocationAvailabilityCriteria(odataType, additionalProperties, webTestId, componentId, failedLocationCount);
        }

        BinaryData IPersistableModel<WebtestLocationAvailabilityCriteria>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WebtestLocationAvailabilityCriteria>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerMonitorContext.Default);
                default:
                    throw new FormatException($"The model {nameof(WebtestLocationAvailabilityCriteria)} does not support writing '{options.Format}' format.");
            }
        }

        WebtestLocationAvailabilityCriteria IPersistableModel<WebtestLocationAvailabilityCriteria>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WebtestLocationAvailabilityCriteria>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeWebtestLocationAvailabilityCriteria(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(WebtestLocationAvailabilityCriteria)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<WebtestLocationAvailabilityCriteria>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
