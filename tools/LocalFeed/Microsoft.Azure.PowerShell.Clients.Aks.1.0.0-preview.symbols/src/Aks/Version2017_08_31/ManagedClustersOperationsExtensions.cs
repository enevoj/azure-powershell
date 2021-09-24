// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Commands.Aks.Generated.Version2017_08_31
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for ManagedClustersOperations.
    /// </summary>
    public static partial class ManagedClustersOperationsExtensions
    {
            /// <summary>
            /// Gets a list of managed clusters in the specified subscription.
            /// </summary>
            /// <remarks>
            /// Gets a list of managed clusters in the specified subscription. The
            /// operation returns properties of each managed cluster.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static IPage<ManagedCluster> List(this IManagedClustersOperations operations)
            {
                return operations.ListAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a list of managed clusters in the specified subscription.
            /// </summary>
            /// <remarks>
            /// Gets a list of managed clusters in the specified subscription. The
            /// operation returns properties of each managed cluster.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<ManagedCluster>> ListAsync(this IManagedClustersOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists managed clusters in the specified subscription and resource group.
            /// </summary>
            /// <remarks>
            /// Lists managed clusters in the specified subscription and resource group.
            /// The operation returns properties of each managed cluster.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            public static IPage<ManagedCluster> ListByResourceGroup(this IManagedClustersOperations operations, string resourceGroupName)
            {
                return operations.ListByResourceGroupAsync(resourceGroupName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists managed clusters in the specified subscription and resource group.
            /// </summary>
            /// <remarks>
            /// Lists managed clusters in the specified subscription and resource group.
            /// The operation returns properties of each managed cluster.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<ManagedCluster>> ListByResourceGroupAsync(this IManagedClustersOperations operations, string resourceGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByResourceGroupWithHttpMessagesAsync(resourceGroupName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets upgrade profile for a managed cluster.
            /// </summary>
            /// <remarks>
            /// Gets the details of the upgrade profile for a managed cluster with a
            /// specified resource group and name.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the managed cluster resource.
            /// </param>
            public static ManagedClusterUpgradeProfile GetUpgradeProfile(this IManagedClustersOperations operations, string resourceGroupName, string resourceName)
            {
                return operations.GetUpgradeProfileAsync(resourceGroupName, resourceName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets upgrade profile for a managed cluster.
            /// </summary>
            /// <remarks>
            /// Gets the details of the upgrade profile for a managed cluster with a
            /// specified resource group and name.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the managed cluster resource.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ManagedClusterUpgradeProfile> GetUpgradeProfileAsync(this IManagedClustersOperations operations, string resourceGroupName, string resourceName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetUpgradeProfileWithHttpMessagesAsync(resourceGroupName, resourceName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets access profile of a managed cluster.
            /// </summary>
            /// <remarks>
            /// Gets the accessProfile for the specified role name of the managed cluster
            /// with a specified resource group and name.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the managed cluster resource.
            /// </param>
            /// <param name='roleName'>
            /// The name of the role for managed cluster accessProfile resource.
            /// </param>
            public static ManagedClusterAccessProfile GetAccessProfiles(this IManagedClustersOperations operations, string resourceGroupName, string resourceName, string roleName)
            {
                return operations.GetAccessProfilesAsync(resourceGroupName, resourceName, roleName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets access profile of a managed cluster.
            /// </summary>
            /// <remarks>
            /// Gets the accessProfile for the specified role name of the managed cluster
            /// with a specified resource group and name.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the managed cluster resource.
            /// </param>
            /// <param name='roleName'>
            /// The name of the role for managed cluster accessProfile resource.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ManagedClusterAccessProfile> GetAccessProfilesAsync(this IManagedClustersOperations operations, string resourceGroupName, string resourceName, string roleName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetAccessProfilesWithHttpMessagesAsync(resourceGroupName, resourceName, roleName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets a managed cluster.
            /// </summary>
            /// <remarks>
            /// Gets the details of the managed cluster with a specified resource group and
            /// name.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the managed cluster resource.
            /// </param>
            public static ManagedCluster Get(this IManagedClustersOperations operations, string resourceGroupName, string resourceName)
            {
                return operations.GetAsync(resourceGroupName, resourceName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a managed cluster.
            /// </summary>
            /// <remarks>
            /// Gets the details of the managed cluster with a specified resource group and
            /// name.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the managed cluster resource.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ManagedCluster> GetAsync(this IManagedClustersOperations operations, string resourceGroupName, string resourceName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, resourceName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates or updates a managed cluster.
            /// </summary>
            /// <remarks>
            /// Creates or updates a managed cluster with the specified configuration for
            /// agents and Kubernetes version.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the managed cluster resource.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the Create or Update a Managed Cluster operation.
            /// </param>
            public static ManagedCluster CreateOrUpdate(this IManagedClustersOperations operations, string resourceGroupName, string resourceName, ManagedCluster parameters)
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, resourceName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates a managed cluster.
            /// </summary>
            /// <remarks>
            /// Creates or updates a managed cluster with the specified configuration for
            /// agents and Kubernetes version.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the managed cluster resource.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the Create or Update a Managed Cluster operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ManagedCluster> CreateOrUpdateAsync(this IManagedClustersOperations operations, string resourceGroupName, string resourceName, ManagedCluster parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, resourceName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes a managed cluster.
            /// </summary>
            /// <remarks>
            /// Deletes the managed cluster with a specified resource group and name.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the managed cluster resource.
            /// </param>
            public static void Delete(this IManagedClustersOperations operations, string resourceGroupName, string resourceName)
            {
                operations.DeleteAsync(resourceGroupName, resourceName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes a managed cluster.
            /// </summary>
            /// <remarks>
            /// Deletes the managed cluster with a specified resource group and name.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the managed cluster resource.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IManagedClustersOperations operations, string resourceGroupName, string resourceName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, resourceName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Creates or updates a managed cluster.
            /// </summary>
            /// <remarks>
            /// Creates or updates a managed cluster with the specified configuration for
            /// agents and Kubernetes version.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the managed cluster resource.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the Create or Update a Managed Cluster operation.
            /// </param>
            public static ManagedCluster BeginCreateOrUpdate(this IManagedClustersOperations operations, string resourceGroupName, string resourceName, ManagedCluster parameters)
            {
                return operations.BeginCreateOrUpdateAsync(resourceGroupName, resourceName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates a managed cluster.
            /// </summary>
            /// <remarks>
            /// Creates or updates a managed cluster with the specified configuration for
            /// agents and Kubernetes version.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the managed cluster resource.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the Create or Update a Managed Cluster operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ManagedCluster> BeginCreateOrUpdateAsync(this IManagedClustersOperations operations, string resourceGroupName, string resourceName, ManagedCluster parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateOrUpdateWithHttpMessagesAsync(resourceGroupName, resourceName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes a managed cluster.
            /// </summary>
            /// <remarks>
            /// Deletes the managed cluster with a specified resource group and name.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the managed cluster resource.
            /// </param>
            public static void BeginDelete(this IManagedClustersOperations operations, string resourceGroupName, string resourceName)
            {
                operations.BeginDeleteAsync(resourceGroupName, resourceName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes a managed cluster.
            /// </summary>
            /// <remarks>
            /// Deletes the managed cluster with a specified resource group and name.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the managed cluster resource.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginDeleteAsync(this IManagedClustersOperations operations, string resourceGroupName, string resourceName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, resourceName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Gets a list of managed clusters in the specified subscription.
            /// </summary>
            /// <remarks>
            /// Gets a list of managed clusters in the specified subscription. The
            /// operation returns properties of each managed cluster.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<ManagedCluster> ListNext(this IManagedClustersOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a list of managed clusters in the specified subscription.
            /// </summary>
            /// <remarks>
            /// Gets a list of managed clusters in the specified subscription. The
            /// operation returns properties of each managed cluster.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<ManagedCluster>> ListNextAsync(this IManagedClustersOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists managed clusters in the specified subscription and resource group.
            /// </summary>
            /// <remarks>
            /// Lists managed clusters in the specified subscription and resource group.
            /// The operation returns properties of each managed cluster.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<ManagedCluster> ListByResourceGroupNext(this IManagedClustersOperations operations, string nextPageLink)
            {
                return operations.ListByResourceGroupNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists managed clusters in the specified subscription and resource group.
            /// </summary>
            /// <remarks>
            /// Lists managed clusters in the specified subscription and resource group.
            /// The operation returns properties of each managed cluster.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<ManagedCluster>> ListByResourceGroupNextAsync(this IManagedClustersOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByResourceGroupNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
