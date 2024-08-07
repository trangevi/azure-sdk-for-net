// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.HDInsight.Containers.Models
{
    /// <summary> Trino debug configuration. </summary>
    public partial class TrinoDebugConfig
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

        /// <summary> Initializes a new instance of <see cref="TrinoDebugConfig"/>. </summary>
        public TrinoDebugConfig()
        {
        }

        /// <summary> Initializes a new instance of <see cref="TrinoDebugConfig"/>. </summary>
        /// <param name="isEnabled"> The flag that if enable debug or not. </param>
        /// <param name="port"> The debug port. </param>
        /// <param name="isSuspendEnabled"> The flag that if suspend debug or not. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal TrinoDebugConfig(bool? isEnabled, int? port, bool? isSuspendEnabled, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            IsEnabled = isEnabled;
            Port = port;
            IsSuspendEnabled = isSuspendEnabled;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The flag that if enable debug or not. </summary>
        [WirePath("enable")]
        public bool? IsEnabled { get; set; }
        /// <summary> The debug port. </summary>
        [WirePath("port")]
        public int? Port { get; set; }
        /// <summary> The flag that if suspend debug or not. </summary>
        [WirePath("suspend")]
        public bool? IsSuspendEnabled { get; set; }
    }
}
