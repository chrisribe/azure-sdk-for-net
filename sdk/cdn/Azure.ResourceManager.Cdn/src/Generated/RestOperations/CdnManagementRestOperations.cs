// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Cdn.Models;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.Cdn
{
    internal partial class CdnManagementRestOperations
    {
        private Uri endpoint;
        private string apiVersion;
        private ClientDiagnostics _clientDiagnostics;
        private HttpPipeline _pipeline;
        private readonly string _userAgent;

        /// <summary> Initializes a new instance of CdnManagementRestOperations. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="apiVersion"/> is null. </exception>
        public CdnManagementRestOperations(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            this.endpoint = endpoint ?? new Uri("https://management.azure.com");
            this.apiVersion = apiVersion ?? "2020-09-01";
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
            _userAgent = Core.HttpMessageUtilities.GetUserAgentName(this, applicationId);
        }

        internal HttpMessage CreateCheckNameAvailabilityRequest(CheckNameAvailabilityInput checkNameAvailabilityInput)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/providers/Microsoft.Cdn/checkNameAvailability", false);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(checkNameAvailabilityInput);
            request.Content = content;
            message.SetProperty("UserAgentOverride", _userAgent);
            return message;
        }

        /// <summary> Check the availability of a resource name. This is needed for resources where name is globally unique, such as a CDN endpoint. </summary>
        /// <param name="checkNameAvailabilityInput"> Input to check. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="checkNameAvailabilityInput"/> is null. </exception>
        public async Task<Response<CheckNameAvailabilityOutput>> CheckNameAvailabilityAsync(CheckNameAvailabilityInput checkNameAvailabilityInput, CancellationToken cancellationToken = default)
        {
            if (checkNameAvailabilityInput == null)
            {
                throw new ArgumentNullException(nameof(checkNameAvailabilityInput));
            }

            using var message = CreateCheckNameAvailabilityRequest(checkNameAvailabilityInput);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        CheckNameAvailabilityOutput value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = CheckNameAvailabilityOutput.DeserializeCheckNameAvailabilityOutput(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Check the availability of a resource name. This is needed for resources where name is globally unique, such as a CDN endpoint. </summary>
        /// <param name="checkNameAvailabilityInput"> Input to check. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="checkNameAvailabilityInput"/> is null. </exception>
        public Response<CheckNameAvailabilityOutput> CheckNameAvailability(CheckNameAvailabilityInput checkNameAvailabilityInput, CancellationToken cancellationToken = default)
        {
            if (checkNameAvailabilityInput == null)
            {
                throw new ArgumentNullException(nameof(checkNameAvailabilityInput));
            }

            using var message = CreateCheckNameAvailabilityRequest(checkNameAvailabilityInput);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        CheckNameAvailabilityOutput value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = CheckNameAvailabilityOutput.DeserializeCheckNameAvailabilityOutput(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateCheckNameAvailabilityWithSubscriptionRequest(string subscriptionId, CheckNameAvailabilityInput checkNameAvailabilityInput)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/providers/Microsoft.Cdn/checkNameAvailability", false);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(checkNameAvailabilityInput);
            request.Content = content;
            message.SetProperty("UserAgentOverride", _userAgent);
            return message;
        }

        /// <summary> Check the availability of a resource name. This is needed for resources where name is globally unique, such as a CDN endpoint. </summary>
        /// <param name="subscriptionId"> Azure Subscription ID. </param>
        /// <param name="checkNameAvailabilityInput"> Input to check. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/> or <paramref name="checkNameAvailabilityInput"/> is null. </exception>
        public async Task<Response<CheckNameAvailabilityOutput>> CheckNameAvailabilityWithSubscriptionAsync(string subscriptionId, CheckNameAvailabilityInput checkNameAvailabilityInput, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (checkNameAvailabilityInput == null)
            {
                throw new ArgumentNullException(nameof(checkNameAvailabilityInput));
            }

            using var message = CreateCheckNameAvailabilityWithSubscriptionRequest(subscriptionId, checkNameAvailabilityInput);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        CheckNameAvailabilityOutput value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = CheckNameAvailabilityOutput.DeserializeCheckNameAvailabilityOutput(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Check the availability of a resource name. This is needed for resources where name is globally unique, such as a CDN endpoint. </summary>
        /// <param name="subscriptionId"> Azure Subscription ID. </param>
        /// <param name="checkNameAvailabilityInput"> Input to check. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/> or <paramref name="checkNameAvailabilityInput"/> is null. </exception>
        public Response<CheckNameAvailabilityOutput> CheckNameAvailabilityWithSubscription(string subscriptionId, CheckNameAvailabilityInput checkNameAvailabilityInput, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (checkNameAvailabilityInput == null)
            {
                throw new ArgumentNullException(nameof(checkNameAvailabilityInput));
            }

            using var message = CreateCheckNameAvailabilityWithSubscriptionRequest(subscriptionId, checkNameAvailabilityInput);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        CheckNameAvailabilityOutput value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = CheckNameAvailabilityOutput.DeserializeCheckNameAvailabilityOutput(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateValidateProbeRequest(string subscriptionId, ValidateProbeInput validateProbeInput)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/providers/Microsoft.Cdn/validateProbe", false);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(validateProbeInput);
            request.Content = content;
            message.SetProperty("UserAgentOverride", _userAgent);
            return message;
        }

        /// <summary> Check if the probe path is a valid path and the file can be accessed. Probe path is the path to a file hosted on the origin server to help accelerate the delivery of dynamic content via the CDN endpoint. This path is relative to the origin path specified in the endpoint configuration. </summary>
        /// <param name="subscriptionId"> Azure Subscription ID. </param>
        /// <param name="validateProbeInput"> Input to check. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/> or <paramref name="validateProbeInput"/> is null. </exception>
        public async Task<Response<ValidateProbeOutput>> ValidateProbeAsync(string subscriptionId, ValidateProbeInput validateProbeInput, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (validateProbeInput == null)
            {
                throw new ArgumentNullException(nameof(validateProbeInput));
            }

            using var message = CreateValidateProbeRequest(subscriptionId, validateProbeInput);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ValidateProbeOutput value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ValidateProbeOutput.DeserializeValidateProbeOutput(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Check if the probe path is a valid path and the file can be accessed. Probe path is the path to a file hosted on the origin server to help accelerate the delivery of dynamic content via the CDN endpoint. This path is relative to the origin path specified in the endpoint configuration. </summary>
        /// <param name="subscriptionId"> Azure Subscription ID. </param>
        /// <param name="validateProbeInput"> Input to check. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/> or <paramref name="validateProbeInput"/> is null. </exception>
        public Response<ValidateProbeOutput> ValidateProbe(string subscriptionId, ValidateProbeInput validateProbeInput, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (validateProbeInput == null)
            {
                throw new ArgumentNullException(nameof(validateProbeInput));
            }

            using var message = CreateValidateProbeRequest(subscriptionId, validateProbeInput);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ValidateProbeOutput value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ValidateProbeOutput.DeserializeValidateProbeOutput(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }
    }
}
