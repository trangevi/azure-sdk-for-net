// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net;

namespace Azure.ResourceManager.PrivateDns.Models
{
    /// <summary> An AAAA record. </summary>
    public partial class PrivateDnsAaaaRecordInfo
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

        /// <summary> Initializes a new instance of <see cref="PrivateDnsAaaaRecordInfo"/>. </summary>
        public PrivateDnsAaaaRecordInfo()
        {
        }

        /// <summary> Initializes a new instance of <see cref="PrivateDnsAaaaRecordInfo"/>. </summary>
        /// <param name="ipv6Address"> The IPv6 address of this AAAA record. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal PrivateDnsAaaaRecordInfo(IPAddress ipv6Address, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            IPv6Address = ipv6Address;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The IPv6 address of this AAAA record. </summary>
        [WirePath("ipv6Address")]
        public IPAddress IPv6Address { get; set; }
    }
}
