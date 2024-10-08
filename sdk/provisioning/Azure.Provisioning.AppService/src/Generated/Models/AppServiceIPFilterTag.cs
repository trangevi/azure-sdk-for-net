// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

namespace Azure.Provisioning.AppService;

/// <summary>
/// Defines what this IP filter will be used for. This is to support IP
/// filtering on proxies.
/// </summary>
public enum AppServiceIPFilterTag
{
    /// <summary>
    /// Default.
    /// </summary>
    Default,

    /// <summary>
    /// XffProxy.
    /// </summary>
    XffProxy,

    /// <summary>
    /// ServiceTag.
    /// </summary>
    ServiceTag,
}
