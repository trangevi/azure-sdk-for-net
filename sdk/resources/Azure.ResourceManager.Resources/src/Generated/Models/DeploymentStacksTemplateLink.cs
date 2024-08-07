// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Resources.Models
{
    /// <summary> Entity representing the reference to the template. </summary>
    public partial class DeploymentStacksTemplateLink
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

        /// <summary> Initializes a new instance of <see cref="DeploymentStacksTemplateLink"/>. </summary>
        public DeploymentStacksTemplateLink()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DeploymentStacksTemplateLink"/>. </summary>
        /// <param name="uri"> The URI of the template to deploy. Use either the uri or id property, but not both. </param>
        /// <param name="id"> The resourceId of a Template Spec. Use either the id or uri property, but not both. </param>
        /// <param name="relativePath"> The relativePath property can be used to deploy a linked template at a location relative to the parent. If the parent template was linked with a TemplateSpec, this will reference an artifact in the TemplateSpec.  If the parent was linked with a URI, the child deployment will be a combination of the parent and relativePath URIs. </param>
        /// <param name="queryString"> The query string (for example, a SAS token) to be used with the templateLink URI. </param>
        /// <param name="contentVersion"> If included, must match the ContentVersion in the template. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DeploymentStacksTemplateLink(Uri uri, string id, string relativePath, string queryString, string contentVersion, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Uri = uri;
            Id = id;
            RelativePath = relativePath;
            QueryString = queryString;
            ContentVersion = contentVersion;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The URI of the template to deploy. Use either the uri or id property, but not both. </summary>
        [WirePath("uri")]
        public Uri Uri { get; set; }
        /// <summary> The resourceId of a Template Spec. Use either the id or uri property, but not both. </summary>
        [WirePath("id")]
        public string Id { get; set; }
        /// <summary> The relativePath property can be used to deploy a linked template at a location relative to the parent. If the parent template was linked with a TemplateSpec, this will reference an artifact in the TemplateSpec.  If the parent was linked with a URI, the child deployment will be a combination of the parent and relativePath URIs. </summary>
        [WirePath("relativePath")]
        public string RelativePath { get; set; }
        /// <summary> The query string (for example, a SAS token) to be used with the templateLink URI. </summary>
        [WirePath("queryString")]
        public string QueryString { get; set; }
        /// <summary> If included, must match the ContentVersion in the template. </summary>
        [WirePath("contentVersion")]
        public string ContentVersion { get; set; }
    }
}
