// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> The maximum limit range capability. </summary>
    public partial class MaxLimitRangeCapability
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

        /// <summary> Initializes a new instance of <see cref="MaxLimitRangeCapability"/>. </summary>
        internal MaxLimitRangeCapability()
        {
        }

        /// <summary> Initializes a new instance of <see cref="MaxLimitRangeCapability"/>. </summary>
        /// <param name="minValue"> Minimum value. </param>
        /// <param name="maxValue"> Maximum value. </param>
        /// <param name="scaleSize"> Scale/step size for discrete values between the minimum value and the maximum value. </param>
        /// <param name="status"> The status of the capability. </param>
        /// <param name="reason"> The reason for the capability not being available. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MaxLimitRangeCapability(long? minValue, long? maxValue, long? scaleSize, SqlCapabilityStatus? status, string reason, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            MinValue = minValue;
            MaxValue = maxValue;
            ScaleSize = scaleSize;
            Status = status;
            Reason = reason;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Minimum value. </summary>
        [WirePath("minValue")]
        public long? MinValue { get; }
        /// <summary> Maximum value. </summary>
        [WirePath("maxValue")]
        public long? MaxValue { get; }
        /// <summary> Scale/step size for discrete values between the minimum value and the maximum value. </summary>
        [WirePath("scaleSize")]
        public long? ScaleSize { get; }
        /// <summary> The status of the capability. </summary>
        [WirePath("status")]
        public SqlCapabilityStatus? Status { get; }
        /// <summary> The reason for the capability not being available. </summary>
        [WirePath("reason")]
        public string Reason { get; }
    }
}
