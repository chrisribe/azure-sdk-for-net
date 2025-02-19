// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Communication.Models
{
    /// <summary> Model factory for models. </summary>
    public static partial class ArmCommunicationModelFactory
    {
        /// <summary> Initializes a new instance of <see cref="Models.CommunicationNameAvailabilityResult"/>. </summary>
        /// <param name="isNameAvailable"> Indicates if the resource name is available. </param>
        /// <param name="reason"> The reason why the given name is not available. </param>
        /// <param name="message"> Detailed reason why the given name is available. </param>
        /// <returns> A new <see cref="Models.CommunicationNameAvailabilityResult"/> instance for mocking. </returns>
        public static CommunicationNameAvailabilityResult CommunicationNameAvailabilityResult(bool? isNameAvailable = null, CommunicationNameAvailabilityReason? reason = null, string message = null)
        {
            return new CommunicationNameAvailabilityResult(isNameAvailable, reason, message, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.LinkedNotificationHub"/>. </summary>
        /// <param name="resourceId"> The resource ID of the notification hub. </param>
        /// <returns> A new <see cref="Models.LinkedNotificationHub"/> instance for mocking. </returns>
        public static LinkedNotificationHub LinkedNotificationHub(ResourceIdentifier resourceId = null)
        {
            return new LinkedNotificationHub(resourceId, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Communication.CommunicationServiceResourceData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="identity"> Managed service identity (system assigned and/or user assigned identities). </param>
        /// <param name="provisioningState"> Provisioning state of the resource. </param>
        /// <param name="hostName"> FQDN of the CommunicationService instance. </param>
        /// <param name="dataLocation"> The location where the communication service stores its data at rest. </param>
        /// <param name="notificationHubId"> Resource ID of an Azure Notification Hub linked to this resource. </param>
        /// <param name="version"> Version of the CommunicationService resource. Probably you need the same or higher version of client SDKs. </param>
        /// <param name="immutableResourceId"> The immutable resource Id of the communication service. </param>
        /// <param name="linkedDomains"> List of email Domain resource Ids. </param>
        /// <returns> A new <see cref="Communication.CommunicationServiceResourceData"/> instance for mocking. </returns>
        public static CommunicationServiceResourceData CommunicationServiceResourceData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, IDictionary<string, string> tags = null, AzureLocation location = default, ManagedServiceIdentity identity = null, CommunicationServicesProvisioningState? provisioningState = null, string hostName = null, string dataLocation = null, ResourceIdentifier notificationHubId = null, string version = null, Guid? immutableResourceId = null, IEnumerable<string> linkedDomains = null)
        {
            tags ??= new Dictionary<string, string>();
            linkedDomains ??= new List<string>();

            return new CommunicationServiceResourceData(
                id,
                name,
                resourceType,
                systemData,
                tags,
                location,
                identity,
                provisioningState,
                hostName,
                dataLocation,
                notificationHubId,
                version,
                immutableResourceId,
                linkedDomains?.ToList(),
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.CommunicationServiceKeys"/>. </summary>
        /// <param name="primaryKey"> The primary access key. </param>
        /// <param name="secondaryKey"> The secondary access key. </param>
        /// <param name="primaryConnectionString"> CommunicationService connection string constructed via the primaryKey. </param>
        /// <param name="secondaryConnectionString"> CommunicationService connection string constructed via the secondaryKey. </param>
        /// <returns> A new <see cref="Models.CommunicationServiceKeys"/> instance for mocking. </returns>
        public static CommunicationServiceKeys CommunicationServiceKeys(string primaryKey = null, string secondaryKey = null, string primaryConnectionString = null, string secondaryConnectionString = null)
        {
            return new CommunicationServiceKeys(primaryKey, secondaryKey, primaryConnectionString, secondaryConnectionString, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Communication.CommunicationDomainResourceData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="provisioningState"> Provisioning state of the resource. </param>
        /// <param name="dataLocation"> The location where the Domains resource data is stored at rest. </param>
        /// <param name="fromSenderDomain"> P2 sender domain that is displayed to the email recipients [RFC 5322]. </param>
        /// <param name="mailFromSenderDomain"> P1 sender domain that is present on the email envelope [RFC 5321]. </param>
        /// <param name="domainManagement"> Describes how a Domains resource is being managed. </param>
        /// <param name="verificationStates"> List of VerificationStatusRecord. </param>
        /// <param name="verificationRecords"> List of DnsRecord. </param>
        /// <param name="userEngagementTracking"> Describes whether user engagement tracking is enabled or disabled. </param>
        /// <returns> A new <see cref="Communication.CommunicationDomainResourceData"/> instance for mocking. </returns>
        public static CommunicationDomainResourceData CommunicationDomainResourceData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, IDictionary<string, string> tags = null, AzureLocation location = default, DomainProvisioningState? provisioningState = null, string dataLocation = null, string fromSenderDomain = null, string mailFromSenderDomain = null, DomainManagement? domainManagement = null, DomainPropertiesVerificationStates verificationStates = null, DomainPropertiesVerificationRecords verificationRecords = null, UserEngagementTracking? userEngagementTracking = null)
        {
            tags ??= new Dictionary<string, string>();

            return new CommunicationDomainResourceData(
                id,
                name,
                resourceType,
                systemData,
                tags,
                location,
                provisioningState,
                dataLocation,
                fromSenderDomain,
                mailFromSenderDomain,
                domainManagement,
                verificationStates,
                verificationRecords,
                userEngagementTracking,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.DomainPropertiesVerificationStates"/>. </summary>
        /// <param name="domain"> A class that represents a VerificationStatus record. </param>
        /// <param name="spf"> A class that represents a VerificationStatus record. </param>
        /// <param name="dkim"> A class that represents a VerificationStatus record. </param>
        /// <param name="dkim2"> A class that represents a VerificationStatus record. </param>
        /// <param name="dmarc"> A class that represents a VerificationStatus record. </param>
        /// <returns> A new <see cref="Models.DomainPropertiesVerificationStates"/> instance for mocking. </returns>
        public static DomainPropertiesVerificationStates DomainPropertiesVerificationStates(DomainVerificationStatusRecord domain = null, DomainVerificationStatusRecord spf = null, DomainVerificationStatusRecord dkim = null, DomainVerificationStatusRecord dkim2 = null, DomainVerificationStatusRecord dmarc = null)
        {
            return new DomainPropertiesVerificationStates(
                domain,
                spf,
                dkim,
                dkim2,
                dmarc,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.DomainVerificationStatusRecord"/>. </summary>
        /// <param name="status"> Status of the verification operation. </param>
        /// <param name="errorCode"> Error code. This property will only be present if the status is UnableToVerify. </param>
        /// <returns> A new <see cref="Models.DomainVerificationStatusRecord"/> instance for mocking. </returns>
        public static DomainVerificationStatusRecord DomainVerificationStatusRecord(DomainRecordVerificationStatus? status = null, string errorCode = null)
        {
            return new DomainVerificationStatusRecord(status, errorCode, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.DomainPropertiesVerificationRecords"/>. </summary>
        /// <param name="domain"> A class that represents a VerificationStatus record. </param>
        /// <param name="spf"> A class that represents a VerificationStatus record. </param>
        /// <param name="dkim"> A class that represents a VerificationStatus record. </param>
        /// <param name="dkim2"> A class that represents a VerificationStatus record. </param>
        /// <param name="dmarc"> A class that represents a VerificationStatus record. </param>
        /// <returns> A new <see cref="Models.DomainPropertiesVerificationRecords"/> instance for mocking. </returns>
        public static DomainPropertiesVerificationRecords DomainPropertiesVerificationRecords(VerificationDnsRecord domain = null, VerificationDnsRecord spf = null, VerificationDnsRecord dkim = null, VerificationDnsRecord dkim2 = null, VerificationDnsRecord dmarc = null)
        {
            return new DomainPropertiesVerificationRecords(
                domain,
                spf,
                dkim,
                dkim2,
                dmarc,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.VerificationDnsRecord"/>. </summary>
        /// <param name="dnsRecordType"> Type of the DNS record. Example: TXT. </param>
        /// <param name="name"> Name of the DNS record. </param>
        /// <param name="value"> Value of the DNS record. </param>
        /// <param name="timeToLiveInSeconds"> Represents an expiry time in seconds to represent how long this entry can be cached by the resolver, default = 3600sec. </param>
        /// <returns> A new <see cref="Models.VerificationDnsRecord"/> instance for mocking. </returns>
        public static VerificationDnsRecord VerificationDnsRecord(string dnsRecordType = null, string name = null, string value = null, int? timeToLiveInSeconds = null)
        {
            return new VerificationDnsRecord(dnsRecordType, name, value, timeToLiveInSeconds, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Communication.EmailServiceResourceData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="provisioningState"> Provisioning state of the resource. </param>
        /// <param name="dataLocation"> The location where the email service stores its data at rest. </param>
        /// <returns> A new <see cref="Communication.EmailServiceResourceData"/> instance for mocking. </returns>
        public static EmailServiceResourceData EmailServiceResourceData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, IDictionary<string, string> tags = null, AzureLocation location = default, EmailServicesProvisioningState? provisioningState = null, string dataLocation = null)
        {
            tags ??= new Dictionary<string, string>();

            return new EmailServiceResourceData(
                id,
                name,
                resourceType,
                systemData,
                tags,
                location,
                provisioningState,
                dataLocation,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Communication.SenderUsernameResourceData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="dataLocation"> The location where the SenderUsername resource data is stored at rest. </param>
        /// <param name="username"> A sender senderUsername to be used when sending emails. </param>
        /// <param name="displayName"> The display name for the senderUsername. </param>
        /// <param name="provisioningState"> Provisioning state of the resource. Unknown is the default state for Communication Services. </param>
        /// <returns> A new <see cref="Communication.SenderUsernameResourceData"/> instance for mocking. </returns>
        public static SenderUsernameResourceData SenderUsernameResourceData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, string dataLocation = null, string username = null, string displayName = null, CommunicationServiceProvisioningState? provisioningState = null)
        {
            return new SenderUsernameResourceData(
                id,
                name,
                resourceType,
                systemData,
                dataLocation,
                username,
                displayName,
                provisioningState,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of CommunicationServiceResourceData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="provisioningState"> Provisioning state of the resource. </param>
        /// <param name="hostName"> FQDN of the CommunicationService instance. </param>
        /// <param name="dataLocation"> The location where the communication service stores its data at rest. </param>
        /// <param name="notificationHubId"> Resource ID of an Azure Notification Hub linked to this resource. </param>
        /// <param name="version"> Version of the CommunicationService resource. Probably you need the same or higher version of client SDKs. </param>
        /// <param name="immutableResourceId"> The immutable resource Id of the communication service. </param>
        /// <param name="linkedDomains"> List of email Domain resource Ids. </param>
        /// <returns> A new <see cref="T:Azure.ResourceManager.Communication.CommunicationServiceResourceData" /> instance for mocking. </returns>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static CommunicationServiceResourceData CommunicationServiceResourceData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, CommunicationServicesProvisioningState? provisioningState, string hostName, string dataLocation, ResourceIdentifier notificationHubId, string version, Guid? immutableResourceId, IEnumerable<string> linkedDomains)
        {
            return CommunicationServiceResourceData(id: id, name: name, resourceType: resourceType, systemData: systemData, tags: tags, location: location, identity: default, provisioningState: provisioningState, hostName: hostName, dataLocation: dataLocation, notificationHubId: notificationHubId, version: version, immutableResourceId: immutableResourceId, linkedDomains: linkedDomains);
        }
    }
}
