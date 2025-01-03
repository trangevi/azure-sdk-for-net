// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Threading;
using Autorest.CSharp.Core;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.ResourceManager.HealthDataAIServices.Mocking
{
    /// <summary> A class to add extension methods to SubscriptionResource. </summary>
    public partial class MockableHealthDataAIServicesSubscriptionResource : ArmResource
    {
        private ClientDiagnostics _deidServiceClientDiagnostics;
        private DeidServicesRestOperations _deidServiceRestClient;

        /// <summary> Initializes a new instance of the <see cref="MockableHealthDataAIServicesSubscriptionResource"/> class for mocking. </summary>
        protected MockableHealthDataAIServicesSubscriptionResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableHealthDataAIServicesSubscriptionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableHealthDataAIServicesSubscriptionResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private ClientDiagnostics DeidServiceClientDiagnostics => _deidServiceClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.HealthDataAIServices", DeidServiceResource.ResourceType.Namespace, Diagnostics);
        private DeidServicesRestOperations DeidServiceRestClient => _deidServiceRestClient ??= new DeidServicesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(DeidServiceResource.ResourceType));

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// List DeidService resources by subscription ID
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.HealthDataAIServices/deidServices</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DeidService_ListBySubscription</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-09-20</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DeidServiceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DeidServiceResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DeidServiceResource> GetDeidServicesAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => DeidServiceRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => DeidServiceRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new DeidServiceResource(Client, DeidServiceData.DeserializeDeidServiceData(e)), DeidServiceClientDiagnostics, Pipeline, "MockableHealthDataAIServicesSubscriptionResource.GetDeidServices", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List DeidService resources by subscription ID
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.HealthDataAIServices/deidServices</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DeidService_ListBySubscription</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-09-20</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DeidServiceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DeidServiceResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DeidServiceResource> GetDeidServices(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => DeidServiceRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => DeidServiceRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new DeidServiceResource(Client, DeidServiceData.DeserializeDeidServiceData(e)), DeidServiceClientDiagnostics, Pipeline, "MockableHealthDataAIServicesSubscriptionResource.GetDeidServices", "value", "nextLink", cancellationToken);
        }
    }
}
