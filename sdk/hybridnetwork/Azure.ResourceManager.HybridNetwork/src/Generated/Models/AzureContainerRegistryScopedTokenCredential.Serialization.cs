// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HybridNetwork.Models
{
    public partial class AzureContainerRegistryScopedTokenCredential : IUtf8JsonSerializable, IJsonModel<AzureContainerRegistryScopedTokenCredential>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AzureContainerRegistryScopedTokenCredential>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<AzureContainerRegistryScopedTokenCredential>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureContainerRegistryScopedTokenCredential>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AzureContainerRegistryScopedTokenCredential)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            if (Optional.IsDefined(Username))
            {
                writer.WritePropertyName("username"u8);
                writer.WriteStringValue(Username);
            }
            if (Optional.IsDefined(AcrToken))
            {
                writer.WritePropertyName("acrToken"u8);
                writer.WriteStringValue(AcrToken);
            }
            if (Optional.IsDefined(AcrServerUri))
            {
                writer.WritePropertyName("acrServerUrl"u8);
                writer.WriteStringValue(AcrServerUri.AbsoluteUri);
            }
            if (Optional.IsCollectionDefined(Repositories))
            {
                writer.WritePropertyName("repositories"u8);
                writer.WriteStartArray();
                foreach (var item in Repositories)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Expiry))
            {
                writer.WritePropertyName("expiry"u8);
                writer.WriteStringValue(Expiry.Value, "O");
            }
        }

        AzureContainerRegistryScopedTokenCredential IJsonModel<AzureContainerRegistryScopedTokenCredential>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureContainerRegistryScopedTokenCredential>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AzureContainerRegistryScopedTokenCredential)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAzureContainerRegistryScopedTokenCredential(document.RootElement, options);
        }

        internal static AzureContainerRegistryScopedTokenCredential DeserializeAzureContainerRegistryScopedTokenCredential(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string username = default;
            string acrToken = default;
            Uri acrServerUrl = default;
            IReadOnlyList<string> repositories = default;
            DateTimeOffset? expiry = default;
            CredentialType credentialType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("username"u8))
                {
                    username = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("acrToken"u8))
                {
                    acrToken = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("acrServerUrl"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    acrServerUrl = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("repositories"u8))
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
                    repositories = array;
                    continue;
                }
                if (property.NameEquals("expiry"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    expiry = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("credentialType"u8))
                {
                    credentialType = new CredentialType(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new AzureContainerRegistryScopedTokenCredential(
                credentialType,
                serializedAdditionalRawData,
                username,
                acrToken,
                acrServerUrl,
                repositories ?? new ChangeTrackingList<string>(),
                expiry);
        }

        BinaryData IPersistableModel<AzureContainerRegistryScopedTokenCredential>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureContainerRegistryScopedTokenCredential>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerHybridNetworkContext.Default);
                default:
                    throw new FormatException($"The model {nameof(AzureContainerRegistryScopedTokenCredential)} does not support writing '{options.Format}' format.");
            }
        }

        AzureContainerRegistryScopedTokenCredential IPersistableModel<AzureContainerRegistryScopedTokenCredential>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureContainerRegistryScopedTokenCredential>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeAzureContainerRegistryScopedTokenCredential(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AzureContainerRegistryScopedTokenCredential)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<AzureContainerRegistryScopedTokenCredential>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
