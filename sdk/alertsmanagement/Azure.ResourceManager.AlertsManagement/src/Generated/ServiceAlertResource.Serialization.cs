// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.AlertsManagement
{
    public partial class ServiceAlertResource : IJsonModel<ServiceAlertData>
    {
        void IJsonModel<ServiceAlertData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<ServiceAlertData>)Data).Write(writer, options);

        ServiceAlertData IJsonModel<ServiceAlertData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<ServiceAlertData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<ServiceAlertData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write<ServiceAlertData>(Data, options, AzureResourceManagerAlertsManagementContext.Default);

        ServiceAlertData IPersistableModel<ServiceAlertData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<ServiceAlertData>(data, options, AzureResourceManagerAlertsManagementContext.Default);

        string IPersistableModel<ServiceAlertData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<ServiceAlertData>)Data).GetFormatFromOptions(options);
    }
}
