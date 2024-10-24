// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.Sql;

/// <summary>
/// Read-write endpoint of the failover group instance.
/// </summary>
public partial class InstanceFailoverGroupReadWriteEndpoint : ProvisionableConstruct
{
    /// <summary>
    /// Failover policy of the read-write endpoint for the failover group. If
    /// failoverPolicy is Automatic then
    /// failoverWithDataLossGracePeriodMinutes is required.
    /// </summary>
    public BicepValue<ReadWriteEndpointFailoverPolicy> FailoverPolicy { get => _failoverPolicy; set => _failoverPolicy.Assign(value); }
    private readonly BicepValue<ReadWriteEndpointFailoverPolicy> _failoverPolicy;

    /// <summary>
    /// Grace period before failover with data loss is attempted for the
    /// read-write endpoint. If failoverPolicy is Automatic then
    /// failoverWithDataLossGracePeriodMinutes is required.
    /// </summary>
    public BicepValue<int> FailoverWithDataLossGracePeriodMinutes { get => _failoverWithDataLossGracePeriodMinutes; set => _failoverWithDataLossGracePeriodMinutes.Assign(value); }
    private readonly BicepValue<int> _failoverWithDataLossGracePeriodMinutes;

    /// <summary>
    /// Creates a new InstanceFailoverGroupReadWriteEndpoint.
    /// </summary>
    public InstanceFailoverGroupReadWriteEndpoint()
    {
        _failoverPolicy = BicepValue<ReadWriteEndpointFailoverPolicy>.DefineProperty(this, "FailoverPolicy", ["failoverPolicy"]);
        _failoverWithDataLossGracePeriodMinutes = BicepValue<int>.DefineProperty(this, "FailoverWithDataLossGracePeriodMinutes", ["failoverWithDataLossGracePeriodMinutes"]);
    }
}
