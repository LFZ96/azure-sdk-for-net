// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.TrafficManager.Models;

namespace Azure.ResourceManager.TrafficManager
{
    /// <summary> A class to add extension methods to Azure.ResourceManager.TrafficManager. </summary>
    public static partial class TrafficManagerExtensions
    {
        private static TenantResourceExtensionClient GetExtensionClient(TenantResource tenantResource)
        {
            return tenantResource.GetCachedClient((client) =>
            {
                return new TenantResourceExtensionClient(client, tenantResource.Id);
            }
            );
        }

        /// <summary> Gets an object representing a TrafficManagerGeographicHierarchyResource along with the instance operations that can be performed on it in the TenantResource. </summary>
        /// <param name="tenantResource"> The <see cref="TenantResource" /> instance the method will execute against. </param>
        /// <returns> Returns a <see cref="TrafficManagerGeographicHierarchyResource" /> object. </returns>
        public static TrafficManagerGeographicHierarchyResource GetTrafficManagerGeographicHierarchy(this TenantResource tenantResource)
        {
            return GetExtensionClient(tenantResource).GetTrafficManagerGeographicHierarchy();
        }

        /// <summary>
        /// Checks the availability of a Traffic Manager Relative DNS name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Network/checkTrafficManagerNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Profiles_CheckTrafficManagerRelativeDnsNameAvailability</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="tenantResource"> The <see cref="TenantResource" /> instance the method will execute against. </param>
        /// <param name="content"> The Traffic Manager name parameters supplied to the CheckTrafficManagerNameAvailability operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public static async Task<Response<TrafficManagerNameAvailabilityResult>> CheckTrafficManagerRelativeDnsNameAvailabilityAsync(this TenantResource tenantResource, TrafficManagerRelativeDnsNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            return await GetExtensionClient(tenantResource).CheckTrafficManagerRelativeDnsNameAvailabilityAsync(content, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Checks the availability of a Traffic Manager Relative DNS name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Network/checkTrafficManagerNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Profiles_CheckTrafficManagerRelativeDnsNameAvailability</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="tenantResource"> The <see cref="TenantResource" /> instance the method will execute against. </param>
        /// <param name="content"> The Traffic Manager name parameters supplied to the CheckTrafficManagerNameAvailability operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public static Response<TrafficManagerNameAvailabilityResult> CheckTrafficManagerRelativeDnsNameAvailability(this TenantResource tenantResource, TrafficManagerRelativeDnsNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            return GetExtensionClient(tenantResource).CheckTrafficManagerRelativeDnsNameAvailability(content, cancellationToken);
        }

        private static SubscriptionResourceExtensionClient GetExtensionClient(SubscriptionResource subscriptionResource)
        {
            return subscriptionResource.GetCachedClient((client) =>
            {
                return new SubscriptionResourceExtensionClient(client, subscriptionResource.Id);
            }
            );
        }

        /// <summary> Gets an object representing a TrafficManagerUserMetricsResource along with the instance operations that can be performed on it in the SubscriptionResource. </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <returns> Returns a <see cref="TrafficManagerUserMetricsResource" /> object. </returns>
        public static TrafficManagerUserMetricsResource GetTrafficManagerUserMetrics(this SubscriptionResource subscriptionResource)
        {
            return GetExtensionClient(subscriptionResource).GetTrafficManagerUserMetrics();
        }

        /// <summary>
        /// Lists all Traffic Manager profiles within a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Network/trafficmanagerprofiles</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Profiles_ListBySubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="TrafficManagerProfileResource" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<TrafficManagerProfileResource> GetTrafficManagerProfilesAsync(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscriptionResource).GetTrafficManagerProfilesAsync(cancellationToken);
        }

        /// <summary>
        /// Lists all Traffic Manager profiles within a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Network/trafficmanagerprofiles</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Profiles_ListBySubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="TrafficManagerProfileResource" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<TrafficManagerProfileResource> GetTrafficManagerProfiles(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscriptionResource).GetTrafficManagerProfiles(cancellationToken);
        }

        private static ResourceGroupResourceExtensionClient GetExtensionClient(ResourceGroupResource resourceGroupResource)
        {
            return resourceGroupResource.GetCachedClient((client) =>
            {
                return new ResourceGroupResourceExtensionClient(client, resourceGroupResource.Id);
            }
            );
        }

        /// <summary> Gets a collection of TrafficManagerProfileResources in the ResourceGroupResource. </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of TrafficManagerProfileResources and their operations over a TrafficManagerProfileResource. </returns>
        public static TrafficManagerProfileCollection GetTrafficManagerProfiles(this ResourceGroupResource resourceGroupResource)
        {
            return GetExtensionClient(resourceGroupResource).GetTrafficManagerProfiles();
        }

        /// <summary>
        /// Gets a Traffic Manager profile.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/trafficmanagerprofiles/{profileName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Profiles_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="profileName"> The name of the Traffic Manager profile. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="profileName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="profileName"/> is null. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<TrafficManagerProfileResource>> GetTrafficManagerProfileAsync(this ResourceGroupResource resourceGroupResource, string profileName, CancellationToken cancellationToken = default)
        {
            return await resourceGroupResource.GetTrafficManagerProfiles().GetAsync(profileName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets a Traffic Manager profile.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/trafficmanagerprofiles/{profileName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Profiles_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="profileName"> The name of the Traffic Manager profile. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="profileName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="profileName"/> is null. </exception>
        [ForwardsClientCalls]
        public static Response<TrafficManagerProfileResource> GetTrafficManagerProfile(this ResourceGroupResource resourceGroupResource, string profileName, CancellationToken cancellationToken = default)
        {
            return resourceGroupResource.GetTrafficManagerProfiles().Get(profileName, cancellationToken);
        }

        #region TrafficManagerEndpointResource
        /// <summary>
        /// Gets an object representing a <see cref="TrafficManagerEndpointResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="TrafficManagerEndpointResource.CreateResourceIdentifier" /> to create a <see cref="TrafficManagerEndpointResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="TrafficManagerEndpointResource" /> object. </returns>
        public static TrafficManagerEndpointResource GetTrafficManagerEndpointResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient<TrafficManagerEndpointResource>(() =>
            {
                TrafficManagerEndpointResource.ValidateResourceId(id);
                return new TrafficManagerEndpointResource(client, id);
            }
            );
        }
        #endregion

        #region TrafficManagerProfileResource
        /// <summary>
        /// Gets an object representing a <see cref="TrafficManagerProfileResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="TrafficManagerProfileResource.CreateResourceIdentifier" /> to create a <see cref="TrafficManagerProfileResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="TrafficManagerProfileResource" /> object. </returns>
        public static TrafficManagerProfileResource GetTrafficManagerProfileResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                TrafficManagerProfileResource.ValidateResourceId(id);
                return new TrafficManagerProfileResource(client, id);
            }
            );
        }
        #endregion

        #region TrafficManagerGeographicHierarchyResource
        /// <summary>
        /// Gets an object representing a <see cref="TrafficManagerGeographicHierarchyResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="TrafficManagerGeographicHierarchyResource.CreateResourceIdentifier" /> to create a <see cref="TrafficManagerGeographicHierarchyResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="TrafficManagerGeographicHierarchyResource" /> object. </returns>
        public static TrafficManagerGeographicHierarchyResource GetTrafficManagerGeographicHierarchyResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                TrafficManagerGeographicHierarchyResource.ValidateResourceId(id);
                return new TrafficManagerGeographicHierarchyResource(client, id);
            }
            );
        }
        #endregion

        #region TrafficManagerHeatMapResource
        /// <summary>
        /// Gets an object representing a <see cref="TrafficManagerHeatMapResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="TrafficManagerHeatMapResource.CreateResourceIdentifier" /> to create a <see cref="TrafficManagerHeatMapResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="TrafficManagerHeatMapResource" /> object. </returns>
        public static TrafficManagerHeatMapResource GetTrafficManagerHeatMapResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                TrafficManagerHeatMapResource.ValidateResourceId(id);
                return new TrafficManagerHeatMapResource(client, id);
            }
            );
        }
        #endregion

        #region TrafficManagerUserMetricsResource
        /// <summary>
        /// Gets an object representing a <see cref="TrafficManagerUserMetricsResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="TrafficManagerUserMetricsResource.CreateResourceIdentifier" /> to create a <see cref="TrafficManagerUserMetricsResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="TrafficManagerUserMetricsResource" /> object. </returns>
        public static TrafficManagerUserMetricsResource GetTrafficManagerUserMetricsResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                TrafficManagerUserMetricsResource.ValidateResourceId(id);
                return new TrafficManagerUserMetricsResource(client, id);
            }
            );
        }
        #endregion
    }
}
