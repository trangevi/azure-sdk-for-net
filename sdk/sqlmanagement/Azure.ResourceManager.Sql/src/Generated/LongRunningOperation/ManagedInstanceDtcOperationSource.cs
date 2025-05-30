// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.ClientModel.Primitives;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.Sql
{
    internal class ManagedInstanceDtcOperationSource : IOperationSource<ManagedInstanceDtcResource>
    {
        private readonly ArmClient _client;

        internal ManagedInstanceDtcOperationSource(ArmClient client)
        {
            _client = client;
        }

        ManagedInstanceDtcResource IOperationSource<ManagedInstanceDtcResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<ManagedInstanceDtcData>(response.Content, ModelReaderWriterOptions.Json, AzureResourceManagerSqlContext.Default);
            return new ManagedInstanceDtcResource(_client, data);
        }

        async ValueTask<ManagedInstanceDtcResource> IOperationSource<ManagedInstanceDtcResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<ManagedInstanceDtcData>(response.Content, ModelReaderWriterOptions.Json, AzureResourceManagerSqlContext.Default);
            return await Task.FromResult(new ManagedInstanceDtcResource(_client, data)).ConfigureAwait(false);
        }
    }
}
