// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.AppPlatform
{
    /// <summary>
    /// A Class representing an ApiPortalCustomDomainResource along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct an <see cref="ApiPortalCustomDomainResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetApiPortalCustomDomainResource method.
    /// Otherwise you can get one from its parent resource <see cref="ApiPortalResource" /> using the GetApiPortalCustomDomainResource method.
    /// </summary>
    public partial class ApiPortalCustomDomainResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="ApiPortalCustomDomainResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string serviceName, string apiPortalName, string domainName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/apiPortals/{apiPortalName}/domains/{domainName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _apiPortalCustomDomainResourceApiPortalCustomDomainsClientDiagnostics;
        private readonly ApiPortalCustomDomainsRestOperations _apiPortalCustomDomainResourceApiPortalCustomDomainsRestClient;
        private readonly ApiPortalCustomDomainResourceData _data;

        /// <summary> Initializes a new instance of the <see cref="ApiPortalCustomDomainResource"/> class for mocking. </summary>
        protected ApiPortalCustomDomainResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "ApiPortalCustomDomainResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal ApiPortalCustomDomainResource(ArmClient client, ApiPortalCustomDomainResourceData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="ApiPortalCustomDomainResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ApiPortalCustomDomainResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _apiPortalCustomDomainResourceApiPortalCustomDomainsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppPlatform", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string apiPortalCustomDomainResourceApiPortalCustomDomainsApiVersion);
            _apiPortalCustomDomainResourceApiPortalCustomDomainsRestClient = new ApiPortalCustomDomainsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, apiPortalCustomDomainResourceApiPortalCustomDomainsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.AppPlatform/Spring/apiPortals/domains";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual ApiPortalCustomDomainResourceData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// Get the API portal custom domain.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/apiPortals/{apiPortalName}/domains/{domainName}
        /// Operation Id: ApiPortalCustomDomains_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ApiPortalCustomDomainResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _apiPortalCustomDomainResourceApiPortalCustomDomainsClientDiagnostics.CreateScope("ApiPortalCustomDomainResource.Get");
            scope.Start();
            try
            {
                var response = await _apiPortalCustomDomainResourceApiPortalCustomDomainsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ApiPortalCustomDomainResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the API portal custom domain.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/apiPortals/{apiPortalName}/domains/{domainName}
        /// Operation Id: ApiPortalCustomDomains_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ApiPortalCustomDomainResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _apiPortalCustomDomainResourceApiPortalCustomDomainsClientDiagnostics.CreateScope("ApiPortalCustomDomainResource.Get");
            scope.Start();
            try
            {
                var response = _apiPortalCustomDomainResourceApiPortalCustomDomainsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ApiPortalCustomDomainResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Delete the API portal custom domain.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/apiPortals/{apiPortalName}/domains/{domainName}
        /// Operation Id: ApiPortalCustomDomains_Delete
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _apiPortalCustomDomainResourceApiPortalCustomDomainsClientDiagnostics.CreateScope("ApiPortalCustomDomainResource.Delete");
            scope.Start();
            try
            {
                var response = await _apiPortalCustomDomainResourceApiPortalCustomDomainsRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new AppPlatformArmOperation(_apiPortalCustomDomainResourceApiPortalCustomDomainsClientDiagnostics, Pipeline, _apiPortalCustomDomainResourceApiPortalCustomDomainsRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.AzureAsyncOperation);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Delete the API portal custom domain.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/apiPortals/{apiPortalName}/domains/{domainName}
        /// Operation Id: ApiPortalCustomDomains_Delete
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _apiPortalCustomDomainResourceApiPortalCustomDomainsClientDiagnostics.CreateScope("ApiPortalCustomDomainResource.Delete");
            scope.Start();
            try
            {
                var response = _apiPortalCustomDomainResourceApiPortalCustomDomainsRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new AppPlatformArmOperation(_apiPortalCustomDomainResourceApiPortalCustomDomainsClientDiagnostics, Pipeline, _apiPortalCustomDomainResourceApiPortalCustomDomainsRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.AzureAsyncOperation);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletionResponse(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Create or update the API portal custom domain.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/apiPortals/{apiPortalName}/domains/{domainName}
        /// Operation Id: ApiPortalCustomDomains_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The API portal custom domain for the create or update operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ApiPortalCustomDomainResource>> UpdateAsync(WaitUntil waitUntil, ApiPortalCustomDomainResourceData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _apiPortalCustomDomainResourceApiPortalCustomDomainsClientDiagnostics.CreateScope("ApiPortalCustomDomainResource.Update");
            scope.Start();
            try
            {
                var response = await _apiPortalCustomDomainResourceApiPortalCustomDomainsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, data, cancellationToken).ConfigureAwait(false);
                var operation = new AppPlatformArmOperation<ApiPortalCustomDomainResource>(new ApiPortalCustomDomainResourceOperationSource(Client), _apiPortalCustomDomainResourceApiPortalCustomDomainsClientDiagnostics, Pipeline, _apiPortalCustomDomainResourceApiPortalCustomDomainsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Create or update the API portal custom domain.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/apiPortals/{apiPortalName}/domains/{domainName}
        /// Operation Id: ApiPortalCustomDomains_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The API portal custom domain for the create or update operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ApiPortalCustomDomainResource> Update(WaitUntil waitUntil, ApiPortalCustomDomainResourceData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _apiPortalCustomDomainResourceApiPortalCustomDomainsClientDiagnostics.CreateScope("ApiPortalCustomDomainResource.Update");
            scope.Start();
            try
            {
                var response = _apiPortalCustomDomainResourceApiPortalCustomDomainsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, data, cancellationToken);
                var operation = new AppPlatformArmOperation<ApiPortalCustomDomainResource>(new ApiPortalCustomDomainResourceOperationSource(Client), _apiPortalCustomDomainResourceApiPortalCustomDomainsClientDiagnostics, Pipeline, _apiPortalCustomDomainResourceApiPortalCustomDomainsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
