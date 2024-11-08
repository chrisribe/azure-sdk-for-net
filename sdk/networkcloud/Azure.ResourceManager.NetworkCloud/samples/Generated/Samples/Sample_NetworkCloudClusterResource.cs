// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.NetworkCloud.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.NetworkCloud.Samples
{
    public partial class Sample_NetworkCloudClusterResource
    {
        // List clusters for subscription
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetNetworkCloudClusters_ListClustersForSubscription()
        {
            // Generated from example definition: specification/networkcloud/resource-manager/Microsoft.NetworkCloud/preview/2024-06-01-preview/examples/Clusters_ListBySubscription.json
            // this example is just showing the usage of "Clusters_ListBySubscription" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "123e4567-e89b-12d3-a456-426655440000";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation and iterate over the result
            await foreach (NetworkCloudClusterResource item in subscriptionResource.GetNetworkCloudClustersAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                NetworkCloudClusterData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // Get cluster
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetCluster()
        {
            // Generated from example definition: specification/networkcloud/resource-manager/Microsoft.NetworkCloud/preview/2024-06-01-preview/examples/Clusters_Get.json
            // this example is just showing the usage of "Clusters_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkCloudClusterResource created on azure
            // for more information of creating NetworkCloudClusterResource, please refer to the document of NetworkCloudClusterResource
            string subscriptionId = "123e4567-e89b-12d3-a456-426655440000";
            string resourceGroupName = "resourceGroupName";
            string clusterName = "clusterName";
            ResourceIdentifier networkCloudClusterResourceId = NetworkCloudClusterResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName);
            NetworkCloudClusterResource networkCloudCluster = client.GetNetworkCloudClusterResource(networkCloudClusterResourceId);

            // invoke the operation
            NetworkCloudClusterResource result = await networkCloudCluster.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            NetworkCloudClusterData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Patch cluster AggregatorOrSingleRackDefinition
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_PatchClusterAggregatorOrSingleRackDefinition()
        {
            // Generated from example definition: specification/networkcloud/resource-manager/Microsoft.NetworkCloud/preview/2024-06-01-preview/examples/Clusters_Patch_AggregatorOrSingleRackDefinition.json
            // this example is just showing the usage of "Clusters_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkCloudClusterResource created on azure
            // for more information of creating NetworkCloudClusterResource, please refer to the document of NetworkCloudClusterResource
            string subscriptionId = "123e4567-e89b-12d3-a456-426655440000";
            string resourceGroupName = "resourceGroupName";
            string clusterName = "clusterName";
            ResourceIdentifier networkCloudClusterResourceId = NetworkCloudClusterResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName);
            NetworkCloudClusterResource networkCloudCluster = client.GetNetworkCloudClusterResource(networkCloudClusterResourceId);

            // invoke the operation
            NetworkCloudClusterPatch patch = new NetworkCloudClusterPatch()
            {
                Tags =
{
["key1"] = "myvalue1",
["key2"] = "myvalue2",
},
                AggregatorOrSingleRackDefinition = new NetworkCloudRackDefinition(new ResourceIdentifier("/subscriptions/123e4567-e89b-12d3-a456-426655440000/resourceGroups/resourceGroupName/providers/Microsoft.ManagedNetworkFabric/networkRacks/networkRackName"), "newSerialNumber", new ResourceIdentifier("/subscriptions/123e4567-e89b-12d3-a456-426655440000/providers/Microsoft.NetworkCloud/rackSkus/rackSkuName"))
                {
                    BareMetalMachineConfigurationData =
{
new BareMetalMachineConfiguration(new AdministrativeCredentials("username")
{
Password = "{password}",
},"AA:BB:CC:DD:EE:FF","00:BB:CC:DD:EE:FF",1L,"BM1219XXX")
{
MachineDetails = "extraDetails",
MachineName = "bmmName1",
},new BareMetalMachineConfiguration(new AdministrativeCredentials("username")
{
Password = "{password}",
},"AA:BB:CC:DD:EE:00","00:BB:CC:DD:EE:00",2L,"BM1219YYY")
{
MachineDetails = "extraDetails",
MachineName = "bmmName2",
}
},
                    RackLocation = "Foo Datacenter, Floor 3, Aisle 9, Rack 2",
                    StorageApplianceConfigurationData =
{
new StorageApplianceConfiguration(new AdministrativeCredentials("username")
{
Password = "{password}",
},1L,"BM1219XXX")
{
StorageApplianceName = "vmName",
}
},
                },
                ComputeDeploymentThreshold = new ValidationThreshold(ValidationThresholdGrouping.PerCluster, ValidationThresholdType.PercentSuccess, 90L),
            };
            ArmOperation<NetworkCloudClusterResource> lro = await networkCloudCluster.UpdateAsync(WaitUntil.Completed, patch);
            NetworkCloudClusterResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            NetworkCloudClusterData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Patch cluster command output
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_PatchClusterCommandOutput()
        {
            // Generated from example definition: specification/networkcloud/resource-manager/Microsoft.NetworkCloud/preview/2024-06-01-preview/examples/Clusters_Patch_CommandOutput.json
            // this example is just showing the usage of "Clusters_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkCloudClusterResource created on azure
            // for more information of creating NetworkCloudClusterResource, please refer to the document of NetworkCloudClusterResource
            string subscriptionId = "123e4567-e89b-12d3-a456-426655440000";
            string resourceGroupName = "resourceGroupName";
            string clusterName = "clusterName";
            ResourceIdentifier networkCloudClusterResourceId = NetworkCloudClusterResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName);
            NetworkCloudClusterResource networkCloudCluster = client.GetNetworkCloudClusterResource(networkCloudClusterResourceId);

            // invoke the operation
            NetworkCloudClusterPatch patch = new NetworkCloudClusterPatch()
            {
                Identity = new ManagedServiceIdentity("UserAssigned")
                {
                    UserAssignedIdentities =
{
[new ResourceIdentifier("/subscriptions/123e4567-e89b-12d3-a456-426655440000/resourceGroups/resourceGroupName/providers/Microsoft.ManagedIdentity/userAssignedIdentities/userIdentity1")] = null,
[new ResourceIdentifier("/subscriptions/123e4567-e89b-12d3-a456-426655440000/resourceGroups/resourceGroupName/providers/Microsoft.ManagedIdentity/userAssignedIdentities/userIdentity2")] = new UserAssignedIdentity(),
},
                },
                Tags =
{
["key1"] = "myvalue1",
["key2"] = "myvalue2",
},
                CommandOutputSettings = new CommandOutputSettings()
                {
                    AssociatedIdentity = new IdentitySelector()
                    {
                        IdentityType = ManagedServiceIdentitySelectorType.UserAssignedIdentity,
                        UserAssignedIdentityResourceId = new ResourceIdentifier("/subscriptions/123e4567-e89b-12d3-a456-426655440000/resourceGroups/resourceGroupName/providers/Microsoft.ManagedIdentity/userAssignedIdentities/userIdentity2"),
                    },
                    ContainerUri = new Uri("https://myaccount.blob.core.windows.net/mycontainer?restype=container"),
                },
            };
            ArmOperation<NetworkCloudClusterResource> lro = await networkCloudCluster.UpdateAsync(WaitUntil.Completed, patch);
            NetworkCloudClusterResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            NetworkCloudClusterData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Patch cluster location
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_PatchClusterLocation()
        {
            // Generated from example definition: specification/networkcloud/resource-manager/Microsoft.NetworkCloud/preview/2024-06-01-preview/examples/Clusters_Patch_Location.json
            // this example is just showing the usage of "Clusters_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkCloudClusterResource created on azure
            // for more information of creating NetworkCloudClusterResource, please refer to the document of NetworkCloudClusterResource
            string subscriptionId = "123e4567-e89b-12d3-a456-426655440000";
            string resourceGroupName = "resourceGroupName";
            string clusterName = "clusterName";
            ResourceIdentifier networkCloudClusterResourceId = NetworkCloudClusterResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName);
            NetworkCloudClusterResource networkCloudCluster = client.GetNetworkCloudClusterResource(networkCloudClusterResourceId);

            // invoke the operation
            NetworkCloudClusterPatch patch = new NetworkCloudClusterPatch()
            {
                Tags =
{
["key1"] = "myvalue1",
["key2"] = "myvalue2",
},
                ClusterLocation = "Foo Street, 3rd Floor, row 9",
            };
            ArmOperation<NetworkCloudClusterResource> lro = await networkCloudCluster.UpdateAsync(WaitUntil.Completed, patch);
            NetworkCloudClusterResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            NetworkCloudClusterData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Patch runtime protection configuration
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_PatchRuntimeProtectionConfiguration()
        {
            // Generated from example definition: specification/networkcloud/resource-manager/Microsoft.NetworkCloud/preview/2024-06-01-preview/examples/Clusters_Patch_RuntimeProtectionConfiguration.json
            // this example is just showing the usage of "Clusters_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkCloudClusterResource created on azure
            // for more information of creating NetworkCloudClusterResource, please refer to the document of NetworkCloudClusterResource
            string subscriptionId = "123e4567-e89b-12d3-a456-426655440000";
            string resourceGroupName = "resourceGroupName";
            string clusterName = "clusterName";
            ResourceIdentifier networkCloudClusterResourceId = NetworkCloudClusterResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName);
            NetworkCloudClusterResource networkCloudCluster = client.GetNetworkCloudClusterResource(networkCloudClusterResourceId);

            // invoke the operation
            NetworkCloudClusterPatch patch = new NetworkCloudClusterPatch()
            {
                Tags =
{
["key1"] = "myvalue1",
["key2"] = "myvalue2",
},
                RuntimeProtectionEnforcementLevel = RuntimeProtectionEnforcementLevel.OnDemand,
            };
            ArmOperation<NetworkCloudClusterResource> lro = await networkCloudCluster.UpdateAsync(WaitUntil.Completed, patch);
            NetworkCloudClusterResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            NetworkCloudClusterData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Patch secret archive
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_PatchSecretArchive()
        {
            // Generated from example definition: specification/networkcloud/resource-manager/Microsoft.NetworkCloud/preview/2024-06-01-preview/examples/Clusters_Patch_SecretArchive.json
            // this example is just showing the usage of "Clusters_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkCloudClusterResource created on azure
            // for more information of creating NetworkCloudClusterResource, please refer to the document of NetworkCloudClusterResource
            string subscriptionId = "123e4567-e89b-12d3-a456-426655440000";
            string resourceGroupName = "resourceGroupName";
            string clusterName = "clusterName";
            ResourceIdentifier networkCloudClusterResourceId = NetworkCloudClusterResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName);
            NetworkCloudClusterResource networkCloudCluster = client.GetNetworkCloudClusterResource(networkCloudClusterResourceId);

            // invoke the operation
            NetworkCloudClusterPatch patch = new NetworkCloudClusterPatch()
            {
                Tags =
{
["key1"] = "myvalue1",
["key2"] = "myvalue2",
},
                SecretArchive = new ClusterSecretArchive(new ResourceIdentifier("/subscriptions/123e4567-e89b-12d3-a456-426655440000/resourceGroups/resourceGroupName/providers/Microsoft.KeyVault/vaults/keyVaultName"))
                {
                    UseKeyVault = ClusterSecretArchiveEnabled.True,
                },
            };
            ArmOperation<NetworkCloudClusterResource> lro = await networkCloudCluster.UpdateAsync(WaitUntil.Completed, patch);
            NetworkCloudClusterResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            NetworkCloudClusterData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Patch update strategy
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_PatchUpdateStrategy()
        {
            // Generated from example definition: specification/networkcloud/resource-manager/Microsoft.NetworkCloud/preview/2024-06-01-preview/examples/Clusters_Patch_UpdateStrategy.json
            // this example is just showing the usage of "Clusters_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkCloudClusterResource created on azure
            // for more information of creating NetworkCloudClusterResource, please refer to the document of NetworkCloudClusterResource
            string subscriptionId = "123e4567-e89b-12d3-a456-426655440000";
            string resourceGroupName = "resourceGroupName";
            string clusterName = "clusterName";
            ResourceIdentifier networkCloudClusterResourceId = NetworkCloudClusterResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName);
            NetworkCloudClusterResource networkCloudCluster = client.GetNetworkCloudClusterResource(networkCloudClusterResourceId);

            // invoke the operation
            NetworkCloudClusterPatch patch = new NetworkCloudClusterPatch()
            {
                Tags =
{
["key1"] = "myvalue1",
["key2"] = "myvalue2",
},
                UpdateStrategy = new ClusterUpdateStrategy(ClusterUpdateStrategyType.Rack, ValidationThresholdType.CountSuccess, 4L)
                {
                    MaxUnavailable = 4L,
                    WaitTimeMinutes = 10L,
                },
            };
            ArmOperation<NetworkCloudClusterResource> lro = await networkCloudCluster.UpdateAsync(WaitUntil.Completed, patch);
            NetworkCloudClusterResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            NetworkCloudClusterData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Continue update cluster version
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task ContinueUpdateVersion_ContinueUpdateClusterVersion()
        {
            // Generated from example definition: specification/networkcloud/resource-manager/Microsoft.NetworkCloud/preview/2024-06-01-preview/examples/Clusters_ContinueUpdateVersion.json
            // this example is just showing the usage of "Clusters_ContinueUpdateVersion" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkCloudClusterResource created on azure
            // for more information of creating NetworkCloudClusterResource, please refer to the document of NetworkCloudClusterResource
            string subscriptionId = "123e4567-e89b-12d3-a456-426655440000";
            string resourceGroupName = "resourceGroupName";
            string clusterName = "clusterName";
            ResourceIdentifier networkCloudClusterResourceId = NetworkCloudClusterResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName);
            NetworkCloudClusterResource networkCloudCluster = client.GetNetworkCloudClusterResource(networkCloudClusterResourceId);

            // invoke the operation
            ClusterContinueUpdateVersionContent content = new ClusterContinueUpdateVersionContent()
            {
                MachineGroupTargetingMode = ClusterContinueUpdateVersionMachineGroupTargetingMode.AlphaByRack,
            };
            ArmOperation<NetworkCloudOperationStatusResult> lro = await networkCloudCluster.ContinueUpdateVersionAsync(WaitUntil.Completed, content);
            NetworkCloudOperationStatusResult result = lro.Value;

            Console.WriteLine($"Succeeded: {result}");
        }

        // Deploy cluster
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Deploy_DeployCluster()
        {
            // Generated from example definition: specification/networkcloud/resource-manager/Microsoft.NetworkCloud/preview/2024-06-01-preview/examples/Clusters_Deploy.json
            // this example is just showing the usage of "Clusters_Deploy" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkCloudClusterResource created on azure
            // for more information of creating NetworkCloudClusterResource, please refer to the document of NetworkCloudClusterResource
            string subscriptionId = "123e4567-e89b-12d3-a456-426655440000";
            string resourceGroupName = "resourceGroupName";
            string clusterName = "clusterName";
            ResourceIdentifier networkCloudClusterResourceId = NetworkCloudClusterResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName);
            NetworkCloudClusterResource networkCloudCluster = client.GetNetworkCloudClusterResource(networkCloudClusterResourceId);

            // invoke the operation
            ClusterDeployContent content = new ClusterDeployContent();
            ArmOperation<NetworkCloudOperationStatusResult> lro = await networkCloudCluster.DeployAsync(WaitUntil.Completed, content: content);
            NetworkCloudOperationStatusResult result = lro.Value;

            Console.WriteLine($"Succeeded: {result}");
        }

        // Deploy cluster skipping validation
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Deploy_DeployClusterSkippingValidation()
        {
            // Generated from example definition: specification/networkcloud/resource-manager/Microsoft.NetworkCloud/preview/2024-06-01-preview/examples/Clusters_Deploy_SkipValidation.json
            // this example is just showing the usage of "Clusters_Deploy" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkCloudClusterResource created on azure
            // for more information of creating NetworkCloudClusterResource, please refer to the document of NetworkCloudClusterResource
            string subscriptionId = "123e4567-e89b-12d3-a456-426655440000";
            string resourceGroupName = "resourceGroupName";
            string clusterName = "clusterName";
            ResourceIdentifier networkCloudClusterResourceId = NetworkCloudClusterResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName);
            NetworkCloudClusterResource networkCloudCluster = client.GetNetworkCloudClusterResource(networkCloudClusterResourceId);

            // invoke the operation
            ClusterDeployContent content = new ClusterDeployContent()
            {
                SkipValidationsForMachines =
{
"bmmName1"
},
            };
            ArmOperation<NetworkCloudOperationStatusResult> lro = await networkCloudCluster.DeployAsync(WaitUntil.Completed, content: content);
            NetworkCloudOperationStatusResult result = lro.Value;

            Console.WriteLine($"Succeeded: {result}");
        }

        // Execute a runtime protection scan on the cluster
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task ScanRuntime_ExecuteARuntimeProtectionScanOnTheCluster()
        {
            // Generated from example definition: specification/networkcloud/resource-manager/Microsoft.NetworkCloud/preview/2024-06-01-preview/examples/Clusters_ScanRuntime.json
            // this example is just showing the usage of "Clusters_ScanRuntime" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkCloudClusterResource created on azure
            // for more information of creating NetworkCloudClusterResource, please refer to the document of NetworkCloudClusterResource
            string subscriptionId = "123e4567-e89b-12d3-a456-426655440000";
            string resourceGroupName = "resourceGroupName";
            string clusterName = "clusterName";
            ResourceIdentifier networkCloudClusterResourceId = NetworkCloudClusterResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName);
            NetworkCloudClusterResource networkCloudCluster = client.GetNetworkCloudClusterResource(networkCloudClusterResourceId);

            // invoke the operation
            ClusterScanRuntimeContent content = new ClusterScanRuntimeContent()
            {
                ScanActivity = ClusterScanRuntimeParametersScanActivity.Scan,
            };
            ArmOperation<NetworkCloudOperationStatusResult> lro = await networkCloudCluster.ScanRuntimeAsync(WaitUntil.Completed, content: content);
            NetworkCloudOperationStatusResult result = lro.Value;

            Console.WriteLine($"Succeeded: {result}");
        }

        // Update cluster version
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task UpdateVersion_UpdateClusterVersion()
        {
            // Generated from example definition: specification/networkcloud/resource-manager/Microsoft.NetworkCloud/preview/2024-06-01-preview/examples/Clusters_UpdateVersion.json
            // this example is just showing the usage of "Clusters_UpdateVersion" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkCloudClusterResource created on azure
            // for more information of creating NetworkCloudClusterResource, please refer to the document of NetworkCloudClusterResource
            string subscriptionId = "123e4567-e89b-12d3-a456-426655440000";
            string resourceGroupName = "resourceGroupName";
            string clusterName = "clusterName";
            ResourceIdentifier networkCloudClusterResourceId = NetworkCloudClusterResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName);
            NetworkCloudClusterResource networkCloudCluster = client.GetNetworkCloudClusterResource(networkCloudClusterResourceId);

            // invoke the operation
            ClusterUpdateVersionContent content = new ClusterUpdateVersionContent("2.0");
            ArmOperation<NetworkCloudOperationStatusResult> lro = await networkCloudCluster.UpdateVersionAsync(WaitUntil.Completed, content);
            NetworkCloudOperationStatusResult result = lro.Value;

            Console.WriteLine($"Succeeded: {result}");
        }
    }
}
