// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using Azure.Provisioning;
using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.CosmosDB;

/// <summary>
/// The unique key on that enforces uniqueness constraint on documents in the
/// collection in the Azure Cosmos DB service.
/// </summary>
public partial class CosmosDBUniqueKey : ProvisionableConstruct
{
    /// <summary>
    /// List of paths must be unique for each document in the Azure Cosmos DB
    /// service.
    /// </summary>
    public BicepList<string> Paths { get => _paths; set => _paths.Assign(value); }
    private readonly BicepList<string> _paths;

    /// <summary>
    /// Creates a new CosmosDBUniqueKey.
    /// </summary>
    public CosmosDBUniqueKey()
    {
        _paths = BicepList<string>.DefineProperty(this, "Paths", ["paths"]);
    }
}
