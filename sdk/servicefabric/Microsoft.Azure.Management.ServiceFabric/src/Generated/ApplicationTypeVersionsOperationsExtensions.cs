// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ServiceFabric
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for ApplicationTypeVersionsOperations.
    /// </summary>
    public static partial class ApplicationTypeVersionsOperationsExtensions
    {
            /// <summary>
            /// Gets a Service Fabric application type version resource.
            /// </summary>
            /// <remarks>
            /// Get a Service Fabric application type version resource created or in the
            /// process of being created in the Service Fabric application type name
            /// resource.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='clusterName'>
            /// The name of the cluster resource.
            /// </param>
            /// <param name='applicationTypeName'>
            /// The name of the application type name resource.
            /// </param>
            /// <param name='version'>
            /// The application type version.
            /// </param>
            public static ApplicationTypeVersionResource Get(this IApplicationTypeVersionsOperations operations, string resourceGroupName, string clusterName, string applicationTypeName, string version)
            {
                return operations.GetAsync(resourceGroupName, clusterName, applicationTypeName, version).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a Service Fabric application type version resource.
            /// </summary>
            /// <remarks>
            /// Get a Service Fabric application type version resource created or in the
            /// process of being created in the Service Fabric application type name
            /// resource.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='clusterName'>
            /// The name of the cluster resource.
            /// </param>
            /// <param name='applicationTypeName'>
            /// The name of the application type name resource.
            /// </param>
            /// <param name='version'>
            /// The application type version.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ApplicationTypeVersionResource> GetAsync(this IApplicationTypeVersionsOperations operations, string resourceGroupName, string clusterName, string applicationTypeName, string version, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, clusterName, applicationTypeName, version, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates or updates a Service Fabric application type version resource.
            /// </summary>
            /// <remarks>
            /// Create or update a Service Fabric application type version resource with
            /// the specified name.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='clusterName'>
            /// The name of the cluster resource.
            /// </param>
            /// <param name='applicationTypeName'>
            /// The name of the application type name resource.
            /// </param>
            /// <param name='version'>
            /// The application type version.
            /// </param>
            /// <param name='parameters'>
            /// The application type version resource.
            /// </param>
            public static ApplicationTypeVersionResource CreateOrUpdate(this IApplicationTypeVersionsOperations operations, string resourceGroupName, string clusterName, string applicationTypeName, string version, ApplicationTypeVersionResource parameters)
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, clusterName, applicationTypeName, version, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates a Service Fabric application type version resource.
            /// </summary>
            /// <remarks>
            /// Create or update a Service Fabric application type version resource with
            /// the specified name.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='clusterName'>
            /// The name of the cluster resource.
            /// </param>
            /// <param name='applicationTypeName'>
            /// The name of the application type name resource.
            /// </param>
            /// <param name='version'>
            /// The application type version.
            /// </param>
            /// <param name='parameters'>
            /// The application type version resource.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ApplicationTypeVersionResource> CreateOrUpdateAsync(this IApplicationTypeVersionsOperations operations, string resourceGroupName, string clusterName, string applicationTypeName, string version, ApplicationTypeVersionResource parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, clusterName, applicationTypeName, version, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes a Service Fabric application type version resource.
            /// </summary>
            /// <remarks>
            /// Delete a Service Fabric application type version resource with the
            /// specified name.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='clusterName'>
            /// The name of the cluster resource.
            /// </param>
            /// <param name='applicationTypeName'>
            /// The name of the application type name resource.
            /// </param>
            /// <param name='version'>
            /// The application type version.
            /// </param>
            public static void Delete(this IApplicationTypeVersionsOperations operations, string resourceGroupName, string clusterName, string applicationTypeName, string version)
            {
                operations.DeleteAsync(resourceGroupName, clusterName, applicationTypeName, version).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes a Service Fabric application type version resource.
            /// </summary>
            /// <remarks>
            /// Delete a Service Fabric application type version resource with the
            /// specified name.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='clusterName'>
            /// The name of the cluster resource.
            /// </param>
            /// <param name='applicationTypeName'>
            /// The name of the application type name resource.
            /// </param>
            /// <param name='version'>
            /// The application type version.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IApplicationTypeVersionsOperations operations, string resourceGroupName, string clusterName, string applicationTypeName, string version, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, clusterName, applicationTypeName, version, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Gets the list of application type version resources created in the
            /// specified Service Fabric application type name resource.
            /// </summary>
            /// <remarks>
            /// Gets all application type version resources created or in the process of
            /// being created in the Service Fabric application type name resource.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='clusterName'>
            /// The name of the cluster resource.
            /// </param>
            /// <param name='applicationTypeName'>
            /// The name of the application type name resource.
            /// </param>
            public static ApplicationTypeVersionResourceList List(this IApplicationTypeVersionsOperations operations, string resourceGroupName, string clusterName, string applicationTypeName)
            {
                return operations.ListAsync(resourceGroupName, clusterName, applicationTypeName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the list of application type version resources created in the
            /// specified Service Fabric application type name resource.
            /// </summary>
            /// <remarks>
            /// Gets all application type version resources created or in the process of
            /// being created in the Service Fabric application type name resource.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='clusterName'>
            /// The name of the cluster resource.
            /// </param>
            /// <param name='applicationTypeName'>
            /// The name of the application type name resource.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ApplicationTypeVersionResourceList> ListAsync(this IApplicationTypeVersionsOperations operations, string resourceGroupName, string clusterName, string applicationTypeName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(resourceGroupName, clusterName, applicationTypeName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates or updates a Service Fabric application type version resource.
            /// </summary>
            /// <remarks>
            /// Create or update a Service Fabric application type version resource with
            /// the specified name.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='clusterName'>
            /// The name of the cluster resource.
            /// </param>
            /// <param name='applicationTypeName'>
            /// The name of the application type name resource.
            /// </param>
            /// <param name='version'>
            /// The application type version.
            /// </param>
            /// <param name='parameters'>
            /// The application type version resource.
            /// </param>
            public static ApplicationTypeVersionResource BeginCreateOrUpdate(this IApplicationTypeVersionsOperations operations, string resourceGroupName, string clusterName, string applicationTypeName, string version, ApplicationTypeVersionResource parameters)
            {
                return operations.BeginCreateOrUpdateAsync(resourceGroupName, clusterName, applicationTypeName, version, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates a Service Fabric application type version resource.
            /// </summary>
            /// <remarks>
            /// Create or update a Service Fabric application type version resource with
            /// the specified name.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='clusterName'>
            /// The name of the cluster resource.
            /// </param>
            /// <param name='applicationTypeName'>
            /// The name of the application type name resource.
            /// </param>
            /// <param name='version'>
            /// The application type version.
            /// </param>
            /// <param name='parameters'>
            /// The application type version resource.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ApplicationTypeVersionResource> BeginCreateOrUpdateAsync(this IApplicationTypeVersionsOperations operations, string resourceGroupName, string clusterName, string applicationTypeName, string version, ApplicationTypeVersionResource parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateOrUpdateWithHttpMessagesAsync(resourceGroupName, clusterName, applicationTypeName, version, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes a Service Fabric application type version resource.
            /// </summary>
            /// <remarks>
            /// Delete a Service Fabric application type version resource with the
            /// specified name.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='clusterName'>
            /// The name of the cluster resource.
            /// </param>
            /// <param name='applicationTypeName'>
            /// The name of the application type name resource.
            /// </param>
            /// <param name='version'>
            /// The application type version.
            /// </param>
            public static void BeginDelete(this IApplicationTypeVersionsOperations operations, string resourceGroupName, string clusterName, string applicationTypeName, string version)
            {
                operations.BeginDeleteAsync(resourceGroupName, clusterName, applicationTypeName, version).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes a Service Fabric application type version resource.
            /// </summary>
            /// <remarks>
            /// Delete a Service Fabric application type version resource with the
            /// specified name.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='clusterName'>
            /// The name of the cluster resource.
            /// </param>
            /// <param name='applicationTypeName'>
            /// The name of the application type name resource.
            /// </param>
            /// <param name='version'>
            /// The application type version.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginDeleteAsync(this IApplicationTypeVersionsOperations operations, string resourceGroupName, string clusterName, string applicationTypeName, string version, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, clusterName, applicationTypeName, version, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

    }
}