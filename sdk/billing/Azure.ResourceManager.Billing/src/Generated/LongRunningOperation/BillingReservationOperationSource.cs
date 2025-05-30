// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.ClientModel.Primitives;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.Billing
{
    internal class BillingReservationOperationSource : IOperationSource<BillingReservationResource>
    {
        private readonly ArmClient _client;

        internal BillingReservationOperationSource(ArmClient client)
        {
            _client = client;
        }

        BillingReservationResource IOperationSource<BillingReservationResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<BillingReservationData>(response.Content, ModelReaderWriterOptions.Json, AzureResourceManagerBillingContext.Default);
            return new BillingReservationResource(_client, data);
        }

        async ValueTask<BillingReservationResource> IOperationSource<BillingReservationResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<BillingReservationData>(response.Content, ModelReaderWriterOptions.Json, AzureResourceManagerBillingContext.Default);
            return await Task.FromResult(new BillingReservationResource(_client, data)).ConfigureAwait(false);
        }
    }
}
