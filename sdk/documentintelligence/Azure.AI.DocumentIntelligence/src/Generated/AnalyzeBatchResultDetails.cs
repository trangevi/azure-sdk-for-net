// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.DocumentIntelligence
{
    /// <summary> Operation detail for a document in a batch analysis. </summary>
    public partial class AnalyzeBatchResultDetails
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="AnalyzeBatchResultDetails"/>. </summary>
        /// <param name="status"> Analyze status.  succeeded, failed, or skipped. </param>
        /// <param name="sourceUri"> URL of the source document. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sourceUri"/> is null. </exception>
        internal AnalyzeBatchResultDetails(DocumentIntelligenceOperationStatus status, Uri sourceUri)
        {
            Argument.AssertNotNull(sourceUri, nameof(sourceUri));

            Status = status;
            SourceUri = sourceUri;
        }

        /// <summary> Initializes a new instance of <see cref="AnalyzeBatchResultDetails"/>. </summary>
        /// <param name="status"> Analyze status.  succeeded, failed, or skipped. </param>
        /// <param name="sourceUri"> URL of the source document. </param>
        /// <param name="resultUri"> URL of the analyze result JSON. </param>
        /// <param name="error"> Encountered error. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AnalyzeBatchResultDetails(DocumentIntelligenceOperationStatus status, Uri sourceUri, Uri resultUri, DocumentIntelligenceError error, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Status = status;
            SourceUri = sourceUri;
            ResultUri = resultUri;
            Error = error;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="AnalyzeBatchResultDetails"/> for deserialization. </summary>
        internal AnalyzeBatchResultDetails()
        {
        }

        /// <summary> Analyze status.  succeeded, failed, or skipped. </summary>
        public DocumentIntelligenceOperationStatus Status { get; }
        /// <summary> URL of the source document. </summary>
        public Uri SourceUri { get; }
        /// <summary> URL of the analyze result JSON. </summary>
        public Uri ResultUri { get; }
        /// <summary> Encountered error. </summary>
        public DocumentIntelligenceError Error { get; }
    }
}
