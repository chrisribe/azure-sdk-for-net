// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Compute.Models;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.Compute
{
    /// <summary> A class representing collection of GalleryApplication and their operations over its parent. </summary>
    public partial class GalleryApplicationCollection : ArmCollection, IEnumerable<GalleryApplication>, IAsyncEnumerable<GalleryApplication>

    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly GalleryApplicationsRestOperations _galleryApplicationsRestClient;

        /// <summary> Initializes a new instance of the <see cref="GalleryApplicationCollection"/> class for mocking. </summary>
        protected GalleryApplicationCollection()
        {
        }

        /// <summary> Initializes a new instance of GalleryApplicationCollection class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal GalleryApplicationCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _galleryApplicationsRestClient = new GalleryApplicationsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, Id.SubscriptionId, BaseUri);
        }

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => Gallery.ResourceType;

        // Collection level operations.

        /// <summary> Create or update a gallery Application Definition. </summary>
        /// <param name="galleryApplicationName"> The name of the gallery Application Definition to be created or updated. The allowed characters are alphabets and numbers with dots, dashes, and periods allowed in the middle. The maximum length is 80 characters. </param>
        /// <param name="galleryApplication"> Parameters supplied to the create or update gallery Application operation. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="galleryApplicationName"/> or <paramref name="galleryApplication"/> is null. </exception>
        public virtual GalleryApplicationCreateOrUpdateOperation CreateOrUpdate(string galleryApplicationName, GalleryApplicationData galleryApplication, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (galleryApplicationName == null)
            {
                throw new ArgumentNullException(nameof(galleryApplicationName));
            }
            if (galleryApplication == null)
            {
                throw new ArgumentNullException(nameof(galleryApplication));
            }

            using var scope = _clientDiagnostics.CreateScope("GalleryApplicationCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _galleryApplicationsRestClient.CreateOrUpdate(Id.ResourceGroupName, Id.Name, galleryApplicationName, galleryApplication, cancellationToken);
                var operation = new GalleryApplicationCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _galleryApplicationsRestClient.CreateCreateOrUpdateRequest(Id.ResourceGroupName, Id.Name, galleryApplicationName, galleryApplication).Request, response);
                if (waitForCompletion)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Create or update a gallery Application Definition. </summary>
        /// <param name="galleryApplicationName"> The name of the gallery Application Definition to be created or updated. The allowed characters are alphabets and numbers with dots, dashes, and periods allowed in the middle. The maximum length is 80 characters. </param>
        /// <param name="galleryApplication"> Parameters supplied to the create or update gallery Application operation. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="galleryApplicationName"/> or <paramref name="galleryApplication"/> is null. </exception>
        public async virtual Task<GalleryApplicationCreateOrUpdateOperation> CreateOrUpdateAsync(string galleryApplicationName, GalleryApplicationData galleryApplication, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (galleryApplicationName == null)
            {
                throw new ArgumentNullException(nameof(galleryApplicationName));
            }
            if (galleryApplication == null)
            {
                throw new ArgumentNullException(nameof(galleryApplication));
            }

            using var scope = _clientDiagnostics.CreateScope("GalleryApplicationCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _galleryApplicationsRestClient.CreateOrUpdateAsync(Id.ResourceGroupName, Id.Name, galleryApplicationName, galleryApplication, cancellationToken).ConfigureAwait(false);
                var operation = new GalleryApplicationCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _galleryApplicationsRestClient.CreateCreateOrUpdateRequest(Id.ResourceGroupName, Id.Name, galleryApplicationName, galleryApplication).Request, response);
                if (waitForCompletion)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Retrieves information about a gallery Application Definition. </summary>
        /// <param name="galleryApplicationName"> The name of the gallery Application Definition to be retrieved. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="galleryApplicationName"/> is null. </exception>
        public virtual Response<GalleryApplication> Get(string galleryApplicationName, CancellationToken cancellationToken = default)
        {
            if (galleryApplicationName == null)
            {
                throw new ArgumentNullException(nameof(galleryApplicationName));
            }

            using var scope = _clientDiagnostics.CreateScope("GalleryApplicationCollection.Get");
            scope.Start();
            try
            {
                var response = _galleryApplicationsRestClient.Get(Id.ResourceGroupName, Id.Name, galleryApplicationName, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new GalleryApplication(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Retrieves information about a gallery Application Definition. </summary>
        /// <param name="galleryApplicationName"> The name of the gallery Application Definition to be retrieved. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="galleryApplicationName"/> is null. </exception>
        public async virtual Task<Response<GalleryApplication>> GetAsync(string galleryApplicationName, CancellationToken cancellationToken = default)
        {
            if (galleryApplicationName == null)
            {
                throw new ArgumentNullException(nameof(galleryApplicationName));
            }

            using var scope = _clientDiagnostics.CreateScope("GalleryApplicationCollection.Get");
            scope.Start();
            try
            {
                var response = await _galleryApplicationsRestClient.GetAsync(Id.ResourceGroupName, Id.Name, galleryApplicationName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new GalleryApplication(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="galleryApplicationName"> The name of the gallery Application Definition to be retrieved. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="galleryApplicationName"/> is null. </exception>
        public virtual Response<GalleryApplication> GetIfExists(string galleryApplicationName, CancellationToken cancellationToken = default)
        {
            if (galleryApplicationName == null)
            {
                throw new ArgumentNullException(nameof(galleryApplicationName));
            }

            using var scope = _clientDiagnostics.CreateScope("GalleryApplicationCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _galleryApplicationsRestClient.Get(Id.ResourceGroupName, Id.Name, galleryApplicationName, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<GalleryApplication>(null, response.GetRawResponse())
                    : Response.FromValue(new GalleryApplication(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="galleryApplicationName"> The name of the gallery Application Definition to be retrieved. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="galleryApplicationName"/> is null. </exception>
        public async virtual Task<Response<GalleryApplication>> GetIfExistsAsync(string galleryApplicationName, CancellationToken cancellationToken = default)
        {
            if (galleryApplicationName == null)
            {
                throw new ArgumentNullException(nameof(galleryApplicationName));
            }

            using var scope = _clientDiagnostics.CreateScope("GalleryApplicationCollection.GetIfExistsAsync");
            scope.Start();
            try
            {
                var response = await _galleryApplicationsRestClient.GetAsync(Id.ResourceGroupName, Id.Name, galleryApplicationName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<GalleryApplication>(null, response.GetRawResponse())
                    : Response.FromValue(new GalleryApplication(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="galleryApplicationName"> The name of the gallery Application Definition to be retrieved. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="galleryApplicationName"/> is null. </exception>
        public virtual Response<bool> CheckIfExists(string galleryApplicationName, CancellationToken cancellationToken = default)
        {
            if (galleryApplicationName == null)
            {
                throw new ArgumentNullException(nameof(galleryApplicationName));
            }

            using var scope = _clientDiagnostics.CreateScope("GalleryApplicationCollection.CheckIfExists");
            scope.Start();
            try
            {
                var response = GetIfExists(galleryApplicationName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="galleryApplicationName"> The name of the gallery Application Definition to be retrieved. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="galleryApplicationName"/> is null. </exception>
        public async virtual Task<Response<bool>> CheckIfExistsAsync(string galleryApplicationName, CancellationToken cancellationToken = default)
        {
            if (galleryApplicationName == null)
            {
                throw new ArgumentNullException(nameof(galleryApplicationName));
            }

            using var scope = _clientDiagnostics.CreateScope("GalleryApplicationCollection.CheckIfExistsAsync");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(galleryApplicationName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> List gallery Application Definitions in a gallery. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="GalleryApplication" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<GalleryApplication> GetAll(CancellationToken cancellationToken = default)
        {
            Page<GalleryApplication> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("GalleryApplicationCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _galleryApplicationsRestClient.ListByGallery(Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new GalleryApplication(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<GalleryApplication> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("GalleryApplicationCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _galleryApplicationsRestClient.ListByGalleryNextPage(nextLink, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new GalleryApplication(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> List gallery Application Definitions in a gallery. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="GalleryApplication" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<GalleryApplication> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<GalleryApplication>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("GalleryApplicationCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _galleryApplicationsRestClient.ListByGalleryAsync(Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new GalleryApplication(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<GalleryApplication>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("GalleryApplicationCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _galleryApplicationsRestClient.ListByGalleryNextPageAsync(nextLink, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new GalleryApplication(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        IEnumerator<GalleryApplication> IEnumerable<GalleryApplication>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<GalleryApplication> IAsyncEnumerable<GalleryApplication>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.ResourceManager.ResourceIdentifier, GalleryApplication, GalleryApplicationData> Construct() { }
    }
}
