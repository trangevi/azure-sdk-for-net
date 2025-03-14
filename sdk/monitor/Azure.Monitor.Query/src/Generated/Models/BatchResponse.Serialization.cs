// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;

namespace Azure.Monitor.Query.Models
{
    internal partial class BatchResponse
    {
        internal static BatchResponse DeserializeBatchResponse(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<BatchQueryResponse> responses = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("responses"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<BatchQueryResponse> array = new List<BatchQueryResponse>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(BatchQueryResponse.DeserializeBatchQueryResponse(item));
                    }
                    responses = array;
                    continue;
                }
            }
            return new BatchResponse(responses ?? new ChangeTrackingList<BatchQueryResponse>());
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static BatchResponse FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeBatchResponse(document.RootElement);
        }
    }
}
