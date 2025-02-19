// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.HDInsight.Containers.Models;
using Azure.ResourceManager.Resources;
using NUnit.Framework;

namespace Azure.ResourceManager.HDInsight.Containers.Samples
{
    public partial class Sample_HDInsightClusterPoolCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_ClusterPoolPut()
        {
            // Generated from example definition: specification/hdinsight/resource-manager/Microsoft.HDInsight/HDInsightOnAks/preview/2024-05-01-preview/examples/CreateClusterPool.json
            // this example is just showing the usage of "ClusterPools_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "10e32bab-26da-4cc4-a441-52b318f824e6";
            string resourceGroupName = "hiloResourcegroup";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this HDInsightClusterPoolResource
            HDInsightClusterPoolCollection collection = resourceGroupResource.GetHDInsightClusterPools();

            // invoke the operation
            string clusterPoolName = "clusterpool1";
            HDInsightClusterPoolData data = new HDInsightClusterPoolData(new AzureLocation("West US 2"))
            {
                Properties = new HDInsightClusterPoolProperties(new ClusterPoolComputeProfile("Standard_D3_v2")
                {
                    AvailabilityZones = { "1", "2", "3" },
                })
                {
                    ClusterPoolVersion = "1.2",
                },
            };
            ArmOperation<HDInsightClusterPoolResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, clusterPoolName, data);
            HDInsightClusterPoolResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            HDInsightClusterPoolData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_ClusterPoolPutWithPrivateAks()
        {
            // Generated from example definition: specification/hdinsight/resource-manager/Microsoft.HDInsight/HDInsightOnAks/preview/2024-05-01-preview/examples/CreateClusterPoolWithPrivateAks.json
            // this example is just showing the usage of "ClusterPools_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "10e32bab-26da-4cc4-a441-52b318f824e6";
            string resourceGroupName = "hiloResourcegroup";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this HDInsightClusterPoolResource
            HDInsightClusterPoolCollection collection = resourceGroupResource.GetHDInsightClusterPools();

            // invoke the operation
            string clusterPoolName = "clusterpool1";
            HDInsightClusterPoolData data = new HDInsightClusterPoolData(new AzureLocation("West US 2"))
            {
                Properties = new HDInsightClusterPoolProperties(new ClusterPoolComputeProfile("Standard_D3_v2")
                {
                    AvailabilityZones = { "1", "2", "3" },
                })
                {
                    ClusterPoolVersion = "1.2",
                    NetworkProfile = new ClusterPoolNetworkProfile(new ResourceIdentifier("/subscriptions/subid/resourceGroups/hiloResourcegroup/providers/Microsoft.Network/virtualNetworks/vnet1/subnets/subnet1"))
                    {
                        IsPrivateApiServerEnabled = true,
                    },
                },
            };
            ArmOperation<HDInsightClusterPoolResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, clusterPoolName, data);
            HDInsightClusterPoolResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            HDInsightClusterPoolData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_ClusterPoolPutWithUDRAks()
        {
            // Generated from example definition: specification/hdinsight/resource-manager/Microsoft.HDInsight/HDInsightOnAks/preview/2024-05-01-preview/examples/CreateClusterPoolWithUDRAks.json
            // this example is just showing the usage of "ClusterPools_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "10e32bab-26da-4cc4-a441-52b318f824e6";
            string resourceGroupName = "hiloResourcegroup";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this HDInsightClusterPoolResource
            HDInsightClusterPoolCollection collection = resourceGroupResource.GetHDInsightClusterPools();

            // invoke the operation
            string clusterPoolName = "clusterpool1";
            HDInsightClusterPoolData data = new HDInsightClusterPoolData(new AzureLocation("West US 2"))
            {
                Properties = new HDInsightClusterPoolProperties(new ClusterPoolComputeProfile("Standard_D3_v2")
                {
                    AvailabilityZones = { "1", "2", "3" },
                })
                {
                    ClusterPoolVersion = "1.2",
                    NetworkProfile = new ClusterPoolNetworkProfile(new ResourceIdentifier("/subscriptions/subid/resourceGroups/hiloResourcegroup/providers/Microsoft.Network/virtualNetworks/vnet1/subnets/subnet1"))
                    {
                        OutboundType = OutboundType.UserDefinedRouting,
                    },
                },
            };
            ArmOperation<HDInsightClusterPoolResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, clusterPoolName, data);
            HDInsightClusterPoolResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            HDInsightClusterPoolData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_ClusterPoolGet()
        {
            // Generated from example definition: specification/hdinsight/resource-manager/Microsoft.HDInsight/HDInsightOnAks/preview/2024-05-01-preview/examples/GetClusterPool.json
            // this example is just showing the usage of "ClusterPools_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "10e32bab-26da-4cc4-a441-52b318f824e6";
            string resourceGroupName = "hiloResourcegroup";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this HDInsightClusterPoolResource
            HDInsightClusterPoolCollection collection = resourceGroupResource.GetHDInsightClusterPools();

            // invoke the operation
            string clusterPoolName = "clusterpool1";
            HDInsightClusterPoolResource result = await collection.GetAsync(clusterPoolName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            HDInsightClusterPoolData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_ClusterPoolsListByResourceGroup()
        {
            // Generated from example definition: specification/hdinsight/resource-manager/Microsoft.HDInsight/HDInsightOnAks/preview/2024-05-01-preview/examples/ListClusterPools.json
            // this example is just showing the usage of "ClusterPools_ListByResourceGroup" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "10e32bab-26da-4cc4-a441-52b318f824e6";
            string resourceGroupName = "hiloResourcegroup";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this HDInsightClusterPoolResource
            HDInsightClusterPoolCollection collection = resourceGroupResource.GetHDInsightClusterPools();

            // invoke the operation and iterate over the result
            await foreach (HDInsightClusterPoolResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                HDInsightClusterPoolData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_ClusterPoolGet()
        {
            // Generated from example definition: specification/hdinsight/resource-manager/Microsoft.HDInsight/HDInsightOnAks/preview/2024-05-01-preview/examples/GetClusterPool.json
            // this example is just showing the usage of "ClusterPools_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "10e32bab-26da-4cc4-a441-52b318f824e6";
            string resourceGroupName = "hiloResourcegroup";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this HDInsightClusterPoolResource
            HDInsightClusterPoolCollection collection = resourceGroupResource.GetHDInsightClusterPools();

            // invoke the operation
            string clusterPoolName = "clusterpool1";
            bool result = await collection.ExistsAsync(clusterPoolName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_ClusterPoolGet()
        {
            // Generated from example definition: specification/hdinsight/resource-manager/Microsoft.HDInsight/HDInsightOnAks/preview/2024-05-01-preview/examples/GetClusterPool.json
            // this example is just showing the usage of "ClusterPools_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "10e32bab-26da-4cc4-a441-52b318f824e6";
            string resourceGroupName = "hiloResourcegroup";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this HDInsightClusterPoolResource
            HDInsightClusterPoolCollection collection = resourceGroupResource.GetHDInsightClusterPools();

            // invoke the operation
            string clusterPoolName = "clusterpool1";
            NullableResponse<HDInsightClusterPoolResource> response = await collection.GetIfExistsAsync(clusterPoolName);
            HDInsightClusterPoolResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                HDInsightClusterPoolData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}
