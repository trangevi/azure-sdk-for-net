// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using Azure.Provisioning;
using Azure.Provisioning.Primitives;

namespace Azure.Provisioning.SignalR;

/// <summary>
/// Network ACL.
/// </summary>
public partial class SignalRNetworkAcl : ProvisionableConstruct
{
    /// <summary>
    /// Allowed request types. The value can be one or more of:
    /// ClientConnection, ServerConnection, RESTAPI.
    /// </summary>
    public BicepList<SignalRRequestType> Allow { get => _allow; set => _allow.Assign(value); }
    private readonly BicepList<SignalRRequestType> _allow;

    /// <summary>
    /// Denied request types. The value can be one or more of:
    /// ClientConnection, ServerConnection, RESTAPI.
    /// </summary>
    public BicepList<SignalRRequestType> Deny { get => _deny; set => _deny.Assign(value); }
    private readonly BicepList<SignalRRequestType> _deny;

    /// <summary>
    /// Creates a new SignalRNetworkAcl.
    /// </summary>
    public SignalRNetworkAcl()
    {
        _allow = BicepList<SignalRRequestType>.DefineProperty(this, "Allow", ["allow"]);
        _deny = BicepList<SignalRRequestType>.DefineProperty(this, "Deny", ["deny"]);
    }
}
