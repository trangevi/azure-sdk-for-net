// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.CosmosDB.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.CosmosDB.Samples
{
    public partial class Sample_CosmosDBSqlStoredProcedureCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_CosmosDBSqlStoredProcedureCreateUpdate()
        {
            // Generated from example definition: specification/cosmos-db/resource-manager/Microsoft.DocumentDB/preview/2024-12-01-preview/examples/CosmosDBSqlStoredProcedureCreateUpdate.json
            // this example is just showing the usage of "SqlResources_CreateUpdateSqlStoredProcedure" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CosmosDBSqlContainerResource created on azure
            // for more information of creating CosmosDBSqlContainerResource, please refer to the document of CosmosDBSqlContainerResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string accountName = "ddb1";
            string databaseName = "databaseName";
            string containerName = "containerName";
            ResourceIdentifier cosmosDBSqlContainerResourceId = CosmosDBSqlContainerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, databaseName, containerName);
            CosmosDBSqlContainerResource cosmosDBSqlContainer = client.GetCosmosDBSqlContainerResource(cosmosDBSqlContainerResourceId);

            // get the collection of this CosmosDBSqlStoredProcedureResource
            CosmosDBSqlStoredProcedureCollection collection = cosmosDBSqlContainer.GetCosmosDBSqlStoredProcedures();

            // invoke the operation
            string storedProcedureName = "storedProcedureName";
            CosmosDBSqlStoredProcedureCreateOrUpdateContent content = new CosmosDBSqlStoredProcedureCreateOrUpdateContent(default, new CosmosDBSqlStoredProcedureResourceInfo("storedProcedureName")
            {
                Body = "body",
            })
            {
                Options = new CosmosDBCreateUpdateConfig(),
            };
            ArmOperation<CosmosDBSqlStoredProcedureResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, storedProcedureName, content);
            CosmosDBSqlStoredProcedureResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            CosmosDBSqlStoredProcedureData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_CosmosDBSqlStoredProcedureGet()
        {
            // Generated from example definition: specification/cosmos-db/resource-manager/Microsoft.DocumentDB/preview/2024-12-01-preview/examples/CosmosDBSqlStoredProcedureGet.json
            // this example is just showing the usage of "SqlResources_GetSqlStoredProcedure" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CosmosDBSqlContainerResource created on azure
            // for more information of creating CosmosDBSqlContainerResource, please refer to the document of CosmosDBSqlContainerResource
            string subscriptionId = "subid";
            string resourceGroupName = "rgName";
            string accountName = "ddb1";
            string databaseName = "databaseName";
            string containerName = "containerName";
            ResourceIdentifier cosmosDBSqlContainerResourceId = CosmosDBSqlContainerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, databaseName, containerName);
            CosmosDBSqlContainerResource cosmosDBSqlContainer = client.GetCosmosDBSqlContainerResource(cosmosDBSqlContainerResourceId);

            // get the collection of this CosmosDBSqlStoredProcedureResource
            CosmosDBSqlStoredProcedureCollection collection = cosmosDBSqlContainer.GetCosmosDBSqlStoredProcedures();

            // invoke the operation
            string storedProcedureName = "storedProcedureName";
            CosmosDBSqlStoredProcedureResource result = await collection.GetAsync(storedProcedureName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            CosmosDBSqlStoredProcedureData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_CosmosDBSqlStoredProcedureList()
        {
            // Generated from example definition: specification/cosmos-db/resource-manager/Microsoft.DocumentDB/preview/2024-12-01-preview/examples/CosmosDBSqlStoredProcedureList.json
            // this example is just showing the usage of "SqlResources_ListSqlStoredProcedures" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CosmosDBSqlContainerResource created on azure
            // for more information of creating CosmosDBSqlContainerResource, please refer to the document of CosmosDBSqlContainerResource
            string subscriptionId = "subid";
            string resourceGroupName = "rgName";
            string accountName = "ddb1";
            string databaseName = "databaseName";
            string containerName = "containerName";
            ResourceIdentifier cosmosDBSqlContainerResourceId = CosmosDBSqlContainerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, databaseName, containerName);
            CosmosDBSqlContainerResource cosmosDBSqlContainer = client.GetCosmosDBSqlContainerResource(cosmosDBSqlContainerResourceId);

            // get the collection of this CosmosDBSqlStoredProcedureResource
            CosmosDBSqlStoredProcedureCollection collection = cosmosDBSqlContainer.GetCosmosDBSqlStoredProcedures();

            // invoke the operation and iterate over the result
            await foreach (CosmosDBSqlStoredProcedureResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                CosmosDBSqlStoredProcedureData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_CosmosDBSqlStoredProcedureGet()
        {
            // Generated from example definition: specification/cosmos-db/resource-manager/Microsoft.DocumentDB/preview/2024-12-01-preview/examples/CosmosDBSqlStoredProcedureGet.json
            // this example is just showing the usage of "SqlResources_GetSqlStoredProcedure" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CosmosDBSqlContainerResource created on azure
            // for more information of creating CosmosDBSqlContainerResource, please refer to the document of CosmosDBSqlContainerResource
            string subscriptionId = "subid";
            string resourceGroupName = "rgName";
            string accountName = "ddb1";
            string databaseName = "databaseName";
            string containerName = "containerName";
            ResourceIdentifier cosmosDBSqlContainerResourceId = CosmosDBSqlContainerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, databaseName, containerName);
            CosmosDBSqlContainerResource cosmosDBSqlContainer = client.GetCosmosDBSqlContainerResource(cosmosDBSqlContainerResourceId);

            // get the collection of this CosmosDBSqlStoredProcedureResource
            CosmosDBSqlStoredProcedureCollection collection = cosmosDBSqlContainer.GetCosmosDBSqlStoredProcedures();

            // invoke the operation
            string storedProcedureName = "storedProcedureName";
            bool result = await collection.ExistsAsync(storedProcedureName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_CosmosDBSqlStoredProcedureGet()
        {
            // Generated from example definition: specification/cosmos-db/resource-manager/Microsoft.DocumentDB/preview/2024-12-01-preview/examples/CosmosDBSqlStoredProcedureGet.json
            // this example is just showing the usage of "SqlResources_GetSqlStoredProcedure" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CosmosDBSqlContainerResource created on azure
            // for more information of creating CosmosDBSqlContainerResource, please refer to the document of CosmosDBSqlContainerResource
            string subscriptionId = "subid";
            string resourceGroupName = "rgName";
            string accountName = "ddb1";
            string databaseName = "databaseName";
            string containerName = "containerName";
            ResourceIdentifier cosmosDBSqlContainerResourceId = CosmosDBSqlContainerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, databaseName, containerName);
            CosmosDBSqlContainerResource cosmosDBSqlContainer = client.GetCosmosDBSqlContainerResource(cosmosDBSqlContainerResourceId);

            // get the collection of this CosmosDBSqlStoredProcedureResource
            CosmosDBSqlStoredProcedureCollection collection = cosmosDBSqlContainer.GetCosmosDBSqlStoredProcedures();

            // invoke the operation
            string storedProcedureName = "storedProcedureName";
            NullableResponse<CosmosDBSqlStoredProcedureResource> response = await collection.GetIfExistsAsync(storedProcedureName);
            CosmosDBSqlStoredProcedureResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                CosmosDBSqlStoredProcedureData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}
