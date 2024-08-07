// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> A hostname and its assigned sites. </summary>
    public partial class CustomHostnameSites : ResourceData
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

        /// <summary> Initializes a new instance of <see cref="CustomHostnameSites"/>. </summary>
        public CustomHostnameSites()
        {
            SiteResourceIds = new ChangeTrackingList<AppServiceIdentifierData>();
        }

        /// <summary> Initializes a new instance of <see cref="CustomHostnameSites"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="customHostname"></param>
        /// <param name="region"></param>
        /// <param name="siteResourceIds"></param>
        /// <param name="kind"> Kind of resource. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal CustomHostnameSites(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string customHostname, string region, IList<AppServiceIdentifierData> siteResourceIds, string kind, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            CustomHostname = customHostname;
            Region = region;
            SiteResourceIds = siteResourceIds;
            Kind = kind;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets or sets the custom hostname. </summary>
        [WirePath("properties.customHostname")]
        public string CustomHostname { get; set; }
        /// <summary> Gets or sets the region. </summary>
        [WirePath("properties.region")]
        public string Region { get; set; }
        /// <summary> Gets the site resource ids. </summary>
        [WirePath("properties.siteResourceIds")]
        public IList<AppServiceIdentifierData> SiteResourceIds { get; }
        /// <summary> Kind of resource. </summary>
        [WirePath("kind")]
        public string Kind { get; set; }
    }
}
