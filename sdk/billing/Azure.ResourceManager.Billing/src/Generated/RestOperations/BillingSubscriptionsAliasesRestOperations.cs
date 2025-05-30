// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Billing.Models;

namespace Azure.ResourceManager.Billing
{
    internal partial class BillingSubscriptionsAliasesRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of BillingSubscriptionsAliasesRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public BillingSubscriptionsAliasesRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2024-04-01";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal RequestUriBuilder CreateGetRequestUri(string billingAccountName, string aliasName)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/providers/Microsoft.Billing/billingAccounts/", false);
            uri.AppendPath(billingAccountName, true);
            uri.AppendPath("/billingSubscriptionAliases/", false);
            uri.AppendPath(aliasName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateGetRequest(string billingAccountName, string aliasName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/providers/Microsoft.Billing/billingAccounts/", false);
            uri.AppendPath(billingAccountName, true);
            uri.AppendPath("/billingSubscriptionAliases/", false);
            uri.AppendPath(aliasName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Gets a subscription by its alias ID.  The operation is supported for seat based billing subscriptions. </summary>
        /// <param name="billingAccountName"> The ID that uniquely identifies a billing account. </param>
        /// <param name="aliasName"> The ID that uniquely identifies a subscription alias. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="billingAccountName"/> or <paramref name="aliasName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="billingAccountName"/> or <paramref name="aliasName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<BillingSubscriptionAliasData>> GetAsync(string billingAccountName, string aliasName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(billingAccountName, nameof(billingAccountName));
            Argument.AssertNotNullOrEmpty(aliasName, nameof(aliasName));

            using var message = CreateGetRequest(billingAccountName, aliasName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        BillingSubscriptionAliasData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions, cancellationToken).ConfigureAwait(false);
                        value = BillingSubscriptionAliasData.DeserializeBillingSubscriptionAliasData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((BillingSubscriptionAliasData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Gets a subscription by its alias ID.  The operation is supported for seat based billing subscriptions. </summary>
        /// <param name="billingAccountName"> The ID that uniquely identifies a billing account. </param>
        /// <param name="aliasName"> The ID that uniquely identifies a subscription alias. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="billingAccountName"/> or <paramref name="aliasName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="billingAccountName"/> or <paramref name="aliasName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<BillingSubscriptionAliasData> Get(string billingAccountName, string aliasName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(billingAccountName, nameof(billingAccountName));
            Argument.AssertNotNullOrEmpty(aliasName, nameof(aliasName));

            using var message = CreateGetRequest(billingAccountName, aliasName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        BillingSubscriptionAliasData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions);
                        value = BillingSubscriptionAliasData.DeserializeBillingSubscriptionAliasData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((BillingSubscriptionAliasData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateCreateOrUpdateRequestUri(string billingAccountName, string aliasName, BillingSubscriptionAliasData data)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/providers/Microsoft.Billing/billingAccounts/", false);
            uri.AppendPath(billingAccountName, true);
            uri.AppendPath("/billingSubscriptionAliases/", false);
            uri.AppendPath(aliasName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateCreateOrUpdateRequest(string billingAccountName, string aliasName, BillingSubscriptionAliasData data)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/providers/Microsoft.Billing/billingAccounts/", false);
            uri.AppendPath(billingAccountName, true);
            uri.AppendPath("/billingSubscriptionAliases/", false);
            uri.AppendPath(aliasName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(data, ModelSerializationExtensions.WireOptions);
            request.Content = content;
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Creates or updates a billing subscription by its alias ID.  The operation is supported for seat based billing subscriptions. </summary>
        /// <param name="billingAccountName"> The ID that uniquely identifies a billing account. </param>
        /// <param name="aliasName"> The ID that uniquely identifies a subscription alias. </param>
        /// <param name="data"> A billing subscription alias. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="billingAccountName"/>, <paramref name="aliasName"/> or <paramref name="data"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="billingAccountName"/> or <paramref name="aliasName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response> CreateOrUpdateAsync(string billingAccountName, string aliasName, BillingSubscriptionAliasData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(billingAccountName, nameof(billingAccountName));
            Argument.AssertNotNullOrEmpty(aliasName, nameof(aliasName));
            Argument.AssertNotNull(data, nameof(data));

            using var message = CreateCreateOrUpdateRequest(billingAccountName, aliasName, data);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                case 202:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Creates or updates a billing subscription by its alias ID.  The operation is supported for seat based billing subscriptions. </summary>
        /// <param name="billingAccountName"> The ID that uniquely identifies a billing account. </param>
        /// <param name="aliasName"> The ID that uniquely identifies a subscription alias. </param>
        /// <param name="data"> A billing subscription alias. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="billingAccountName"/>, <paramref name="aliasName"/> or <paramref name="data"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="billingAccountName"/> or <paramref name="aliasName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response CreateOrUpdate(string billingAccountName, string aliasName, BillingSubscriptionAliasData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(billingAccountName, nameof(billingAccountName));
            Argument.AssertNotNullOrEmpty(aliasName, nameof(aliasName));
            Argument.AssertNotNull(data, nameof(data));

            using var message = CreateCreateOrUpdateRequest(billingAccountName, aliasName, data);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                case 202:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateListByBillingAccountRequestUri(string billingAccountName, bool? includeDeleted, string filter, string orderBy, long? top, long? skip, bool? count, string search)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/providers/Microsoft.Billing/billingAccounts/", false);
            uri.AppendPath(billingAccountName, true);
            uri.AppendPath("/billingSubscriptionAliases", false);
            if (includeDeleted != null)
            {
                uri.AppendQuery("includeDeleted", includeDeleted.Value, true);
            }
            uri.AppendQuery("api-version", _apiVersion, true);
            if (filter != null)
            {
                uri.AppendQuery("filter", filter, true);
            }
            if (orderBy != null)
            {
                uri.AppendQuery("orderBy", orderBy, true);
            }
            if (top != null)
            {
                uri.AppendQuery("top", top.Value, true);
            }
            if (skip != null)
            {
                uri.AppendQuery("skip", skip.Value, true);
            }
            if (count != null)
            {
                uri.AppendQuery("count", count.Value, true);
            }
            if (search != null)
            {
                uri.AppendQuery("search", search, true);
            }
            return uri;
        }

        internal HttpMessage CreateListByBillingAccountRequest(string billingAccountName, bool? includeDeleted, string filter, string orderBy, long? top, long? skip, bool? count, string search)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/providers/Microsoft.Billing/billingAccounts/", false);
            uri.AppendPath(billingAccountName, true);
            uri.AppendPath("/billingSubscriptionAliases", false);
            if (includeDeleted != null)
            {
                uri.AppendQuery("includeDeleted", includeDeleted.Value, true);
            }
            uri.AppendQuery("api-version", _apiVersion, true);
            if (filter != null)
            {
                uri.AppendQuery("filter", filter, true);
            }
            if (orderBy != null)
            {
                uri.AppendQuery("orderBy", orderBy, true);
            }
            if (top != null)
            {
                uri.AppendQuery("top", top.Value, true);
            }
            if (skip != null)
            {
                uri.AppendQuery("skip", skip.Value, true);
            }
            if (count != null)
            {
                uri.AppendQuery("count", count.Value, true);
            }
            if (search != null)
            {
                uri.AppendQuery("search", search, true);
            }
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Lists the subscription aliases for a billing account. The operation is supported for seat based billing subscriptions. </summary>
        /// <param name="billingAccountName"> The ID that uniquely identifies a billing account. </param>
        /// <param name="includeDeleted"> Can be used to get deleted billing subscriptions. </param>
        /// <param name="filter"> The filter query option allows clients to filter a collection of resources that are addressed by a request URL. </param>
        /// <param name="orderBy"> The orderby query option allows clients to request resources in a particular order. </param>
        /// <param name="top"> The top query option requests the number of items in the queried collection to be included in the result. The maximum supported value for top is 50. </param>
        /// <param name="skip"> The skip query option requests the number of items in the queried collection that are to be skipped and not included in the result. </param>
        /// <param name="count"> The count query option allows clients to request a count of the matching resources included with the resources in the response. </param>
        /// <param name="search"> The search query option allows clients to request items within a collection matching a free-text search expression. search is only supported for string fields. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="billingAccountName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="billingAccountName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<BillingSubscriptionAliasListResult>> ListByBillingAccountAsync(string billingAccountName, bool? includeDeleted = null, string filter = null, string orderBy = null, long? top = null, long? skip = null, bool? count = null, string search = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(billingAccountName, nameof(billingAccountName));

            using var message = CreateListByBillingAccountRequest(billingAccountName, includeDeleted, filter, orderBy, top, skip, count, search);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        BillingSubscriptionAliasListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions, cancellationToken).ConfigureAwait(false);
                        value = BillingSubscriptionAliasListResult.DeserializeBillingSubscriptionAliasListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Lists the subscription aliases for a billing account. The operation is supported for seat based billing subscriptions. </summary>
        /// <param name="billingAccountName"> The ID that uniquely identifies a billing account. </param>
        /// <param name="includeDeleted"> Can be used to get deleted billing subscriptions. </param>
        /// <param name="filter"> The filter query option allows clients to filter a collection of resources that are addressed by a request URL. </param>
        /// <param name="orderBy"> The orderby query option allows clients to request resources in a particular order. </param>
        /// <param name="top"> The top query option requests the number of items in the queried collection to be included in the result. The maximum supported value for top is 50. </param>
        /// <param name="skip"> The skip query option requests the number of items in the queried collection that are to be skipped and not included in the result. </param>
        /// <param name="count"> The count query option allows clients to request a count of the matching resources included with the resources in the response. </param>
        /// <param name="search"> The search query option allows clients to request items within a collection matching a free-text search expression. search is only supported for string fields. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="billingAccountName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="billingAccountName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<BillingSubscriptionAliasListResult> ListByBillingAccount(string billingAccountName, bool? includeDeleted = null, string filter = null, string orderBy = null, long? top = null, long? skip = null, bool? count = null, string search = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(billingAccountName, nameof(billingAccountName));

            using var message = CreateListByBillingAccountRequest(billingAccountName, includeDeleted, filter, orderBy, top, skip, count, search);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        BillingSubscriptionAliasListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions);
                        value = BillingSubscriptionAliasListResult.DeserializeBillingSubscriptionAliasListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateListByBillingAccountNextPageRequestUri(string nextLink, string billingAccountName, bool? includeDeleted, string filter, string orderBy, long? top, long? skip, bool? count, string search)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRawNextLink(nextLink, false);
            return uri;
        }

        internal HttpMessage CreateListByBillingAccountNextPageRequest(string nextLink, string billingAccountName, bool? includeDeleted, string filter, string orderBy, long? top, long? skip, bool? count, string search)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRawNextLink(nextLink, false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Lists the subscription aliases for a billing account. The operation is supported for seat based billing subscriptions. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="billingAccountName"> The ID that uniquely identifies a billing account. </param>
        /// <param name="includeDeleted"> Can be used to get deleted billing subscriptions. </param>
        /// <param name="filter"> The filter query option allows clients to filter a collection of resources that are addressed by a request URL. </param>
        /// <param name="orderBy"> The orderby query option allows clients to request resources in a particular order. </param>
        /// <param name="top"> The top query option requests the number of items in the queried collection to be included in the result. The maximum supported value for top is 50. </param>
        /// <param name="skip"> The skip query option requests the number of items in the queried collection that are to be skipped and not included in the result. </param>
        /// <param name="count"> The count query option allows clients to request a count of the matching resources included with the resources in the response. </param>
        /// <param name="search"> The search query option allows clients to request items within a collection matching a free-text search expression. search is only supported for string fields. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> or <paramref name="billingAccountName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="billingAccountName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<BillingSubscriptionAliasListResult>> ListByBillingAccountNextPageAsync(string nextLink, string billingAccountName, bool? includeDeleted = null, string filter = null, string orderBy = null, long? top = null, long? skip = null, bool? count = null, string search = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(billingAccountName, nameof(billingAccountName));

            using var message = CreateListByBillingAccountNextPageRequest(nextLink, billingAccountName, includeDeleted, filter, orderBy, top, skip, count, search);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        BillingSubscriptionAliasListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions, cancellationToken).ConfigureAwait(false);
                        value = BillingSubscriptionAliasListResult.DeserializeBillingSubscriptionAliasListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Lists the subscription aliases for a billing account. The operation is supported for seat based billing subscriptions. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="billingAccountName"> The ID that uniquely identifies a billing account. </param>
        /// <param name="includeDeleted"> Can be used to get deleted billing subscriptions. </param>
        /// <param name="filter"> The filter query option allows clients to filter a collection of resources that are addressed by a request URL. </param>
        /// <param name="orderBy"> The orderby query option allows clients to request resources in a particular order. </param>
        /// <param name="top"> The top query option requests the number of items in the queried collection to be included in the result. The maximum supported value for top is 50. </param>
        /// <param name="skip"> The skip query option requests the number of items in the queried collection that are to be skipped and not included in the result. </param>
        /// <param name="count"> The count query option allows clients to request a count of the matching resources included with the resources in the response. </param>
        /// <param name="search"> The search query option allows clients to request items within a collection matching a free-text search expression. search is only supported for string fields. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> or <paramref name="billingAccountName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="billingAccountName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<BillingSubscriptionAliasListResult> ListByBillingAccountNextPage(string nextLink, string billingAccountName, bool? includeDeleted = null, string filter = null, string orderBy = null, long? top = null, long? skip = null, bool? count = null, string search = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(billingAccountName, nameof(billingAccountName));

            using var message = CreateListByBillingAccountNextPageRequest(nextLink, billingAccountName, includeDeleted, filter, orderBy, top, skip, count, search);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        BillingSubscriptionAliasListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions);
                        value = BillingSubscriptionAliasListResult.DeserializeBillingSubscriptionAliasListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
