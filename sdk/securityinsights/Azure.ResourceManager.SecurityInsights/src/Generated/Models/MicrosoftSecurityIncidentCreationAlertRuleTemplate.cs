// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary> Represents MicrosoftSecurityIncidentCreation rule template. </summary>
    public partial class MicrosoftSecurityIncidentCreationAlertRuleTemplate : SecurityInsightsAlertRuleTemplateData
    {
        /// <summary> Initializes a new instance of <see cref="MicrosoftSecurityIncidentCreationAlertRuleTemplate"/>. </summary>
        public MicrosoftSecurityIncidentCreationAlertRuleTemplate()
        {
            RequiredDataConnectors = new ChangeTrackingList<AlertRuleTemplateDataSource>();
            DisplayNamesFilter = new ChangeTrackingList<string>();
            DisplayNamesExcludeFilter = new ChangeTrackingList<string>();
            SeveritiesFilter = new ChangeTrackingList<SecurityInsightsAlertSeverity>();
            Kind = AlertRuleKind.MicrosoftSecurityIncidentCreation;
        }

        /// <summary> Initializes a new instance of <see cref="MicrosoftSecurityIncidentCreationAlertRuleTemplate"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="kind"> The kind of the alert rule. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="alertRulesCreatedByTemplateCount"> the number of alert rules that were created by this template. </param>
        /// <param name="lastUpdatedOn"> The last time that this alert rule template has been updated. </param>
        /// <param name="createdOn"> The time that this alert rule template has been added. </param>
        /// <param name="description"> The description of the alert rule template. </param>
        /// <param name="displayName"> The display name for alert rule template. </param>
        /// <param name="requiredDataConnectors"> The required data sources for this template. </param>
        /// <param name="status"> The alert rule template status. </param>
        /// <param name="displayNamesFilter"> the alerts' displayNames on which the cases will be generated. </param>
        /// <param name="displayNamesExcludeFilter"> the alerts' displayNames on which the cases will not be generated. </param>
        /// <param name="productFilter"> The alerts' productName on which the cases will be generated. </param>
        /// <param name="severitiesFilter"> the alerts' severities on which the cases will be generated. </param>
        internal MicrosoftSecurityIncidentCreationAlertRuleTemplate(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, AlertRuleKind kind, IDictionary<string, BinaryData> serializedAdditionalRawData, int? alertRulesCreatedByTemplateCount, DateTimeOffset? lastUpdatedOn, DateTimeOffset? createdOn, string description, string displayName, IList<AlertRuleTemplateDataSource> requiredDataConnectors, SecurityInsightsAlertRuleTemplateStatus? status, IList<string> displayNamesFilter, IList<string> displayNamesExcludeFilter, MicrosoftSecurityProductName? productFilter, IList<SecurityInsightsAlertSeverity> severitiesFilter) : base(id, name, resourceType, systemData, kind, serializedAdditionalRawData)
        {
            AlertRulesCreatedByTemplateCount = alertRulesCreatedByTemplateCount;
            LastUpdatedOn = lastUpdatedOn;
            CreatedOn = createdOn;
            Description = description;
            DisplayName = displayName;
            RequiredDataConnectors = requiredDataConnectors;
            Status = status;
            DisplayNamesFilter = displayNamesFilter;
            DisplayNamesExcludeFilter = displayNamesExcludeFilter;
            ProductFilter = productFilter;
            SeveritiesFilter = severitiesFilter;
            Kind = kind;
        }

        /// <summary> the number of alert rules that were created by this template. </summary>
        [WirePath("properties.alertRulesCreatedByTemplateCount")]
        public int? AlertRulesCreatedByTemplateCount { get; set; }
        /// <summary> The last time that this alert rule template has been updated. </summary>
        [WirePath("properties.lastUpdatedDateUTC")]
        public DateTimeOffset? LastUpdatedOn { get; }
        /// <summary> The time that this alert rule template has been added. </summary>
        [WirePath("properties.createdDateUTC")]
        public DateTimeOffset? CreatedOn { get; }
        /// <summary> The description of the alert rule template. </summary>
        [WirePath("properties.description")]
        public string Description { get; set; }
        /// <summary> The display name for alert rule template. </summary>
        [WirePath("properties.displayName")]
        public string DisplayName { get; set; }
        /// <summary> The required data sources for this template. </summary>
        [WirePath("properties.requiredDataConnectors")]
        public IList<AlertRuleTemplateDataSource> RequiredDataConnectors { get; }
        /// <summary> The alert rule template status. </summary>
        [WirePath("properties.status")]
        public SecurityInsightsAlertRuleTemplateStatus? Status { get; set; }
        /// <summary> the alerts' displayNames on which the cases will be generated. </summary>
        [WirePath("properties.displayNamesFilter")]
        public IList<string> DisplayNamesFilter { get; }
        /// <summary> the alerts' displayNames on which the cases will not be generated. </summary>
        [WirePath("properties.displayNamesExcludeFilter")]
        public IList<string> DisplayNamesExcludeFilter { get; }
        /// <summary> The alerts' productName on which the cases will be generated. </summary>
        [WirePath("properties.productFilter")]
        public MicrosoftSecurityProductName? ProductFilter { get; set; }
        /// <summary> the alerts' severities on which the cases will be generated. </summary>
        [WirePath("properties.severitiesFilter")]
        public IList<SecurityInsightsAlertSeverity> SeveritiesFilter { get; }
    }
}
