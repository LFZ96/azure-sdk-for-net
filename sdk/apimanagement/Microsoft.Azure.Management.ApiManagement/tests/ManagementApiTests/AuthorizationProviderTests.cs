// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// using ApiManagement.Management.Tests;

using Microsoft.Azure.Management.ApiManagement.Models;
using Microsoft.Rest.ClientRuntime.Azure.TestFramework;
using System;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using Xunit;

namespace ApiManagement.Tests.ManagementApiTests
{
    public class AuthorizationProviderTests : TestBase
    {
        [Fact]
        [Trait("owner", "loganzipkes")]
        public async Task AuthorizationProviderCreateListUpdateDelete()
        {
            Environment.SetEnvironmentVariable("AZURE_TEST_MODE", "Playback");
            using (MockContext context = MockContext.Start(this.GetType()))
            {
                var testBase = new ApiManagementTestBase(context);
                testBase.TryCreateApiManagementService();

                // list all authorization provider
                var listResponse = await testBase.client.AuthorizationProvider.ListByServiceWithHttpMessagesAsync(
                    testBase.rgName,
                    testBase.serviceName,
                    null);

                Assert.NotNull(listResponse);
                Assert.Empty(listResponse.Body);

                // create authorization provider
                string authorizationProviderId = TestUtilities.GenerateName("authorizationProviderId");
                try
                {
                    var authorizationProviderContract = new AuthorizationProviderContract
                    {
                        DisplayName = TestUtilities.GenerateName("authorizationProviderDisplayName"),
                        IdentityProvider = TestUtilities.GenerateName("identityProvider"),
                        Oauth2 = new AuthorizationProviderOAuth2Settings { RedirectUrl = "https://contoso.com" }
                    };

                    var createResponse = await testBase.client.AuthorizationProvider.CreateOrUpdateWithHttpMessagesAsync(
                        testBase.rgName,
                        testBase.serviceName,
                        authorizationProviderId,
                        authorizationProviderContract);

                    Assert.NotNull(createResponse);

                    // get authorization provider to check if it was created
                    var getResponse = await testBase.client.AuthorizationProvider.GetWithHttpMessagesAsync(
                        testBase.rgName,
                        testBase.serviceName,
                        authorizationProviderId);

                    Assert.NotNull(getResponse);
                    Assert.NotNull(getResponse.Headers.ETag);
                    Assert.NotNull(getResponse.Body);

                    Assert.Equal(authorizationProviderId, getResponse.Body.Id);
                    Assert.Equal(authorizationProviderContract.DisplayName, getResponse.Body.DisplayName);
                    Assert.Equal(authorizationProviderContract.IdentityProvider, getResponse.Body.IdentityProvider);
                    Assert.Equal(authorizationProviderContract.Oauth2.RedirectUrl, getResponse.Body.Oauth2.RedirectUrl);

                    // list authorization providers again
                    listResponse = await testBase.client.AuthorizationProvider.ListByServiceWithHttpMessagesAsync(
                        testBase.rgName,
                        testBase.serviceName,
                        null);

                    Assert.NotNull(listResponse);
                    Assert.NotEmpty(listResponse.Body);

                    var updateParameters = new AuthorizationProviderContract
                    {
                        DisplayName = TestUtilities.GenerateName("newAuthorizationProviderDisplayName"),
                    };

                    // update authorization provider
                    await testBase.client.AuthorizationProvider.CreateOrUpdateWithHttpMessagesAsync(
                        testBase.rgName,
                        testBase.serviceName,
                        authorizationProviderId,
                        updateParameters,
                        getResponse.Headers.ETag);

                    // get authorization provider to validate that it was updated
                    getResponse = await testBase.client.AuthorizationProvider.GetWithHttpMessagesAsync(
                        testBase.rgName,
                        testBase.serviceName,
                        authorizationProviderId);

                    Assert.NotNull(getResponse);
                    Assert.NotNull(getResponse.Headers.ETag);
                    Assert.NotNull(getResponse.Body);

                    Assert.Equal(authorizationProviderId, getResponse.Body.Id);
                    Assert.Equal(updateParameters.DisplayName, getResponse.Body.DisplayName);
                    Assert.Equal(authorizationProviderContract.IdentityProvider, getResponse.Body.IdentityProvider);
                    Assert.Equal(authorizationProviderContract.Oauth2.RedirectUrl, getResponse.Body.Oauth2.RedirectUrl);

                    // delete authorization provider
                    await testBase.client.AuthorizationProvider.DeleteWithHttpMessagesAsync(
                        testBase.rgName,
                        testBase.serviceName,
                        authorizationProviderId,
                        getResponse.Headers.ETag);

                    // get authorization provider to check if it was deleted
                    try
                    {
                        await testBase.client.AuthorizationProvider.GetWithHttpMessagesAsync(
                            testBase.rgName,
                            testBase.serviceName,
                            authorizationProviderId);

                        throw new System.Exception("This code should not have been executed.");
                    }
                    catch (ErrorResponseException ex)
                    {
                        Assert.Equal((int)HttpStatusCode.NotFound, (int)ex.Response.StatusCode);
                    }
                }
                finally
                {
                    // delete authorization provider to ensure clean up
                    await testBase.client.AuthorizationProvider.DeleteWithHttpMessagesAsync(
                        testBase.rgName,
                        testBase.serviceName,
                        authorizationProviderId,
                        "*");
                }
            }
        }

        [Fact]
        [Trait("owner", "loganzipkes")]
        public async Task AuthorizationCreateListUpdateDelete()
        {
            Environment.SetEnvironmentVariable("AZURE_TEST_MODE", "Playback");
            using (MockContext context = MockContext.Start(this.GetType()))
            {
                var testBase = new ApiManagementTestBase(context);
                testBase.TryCreateApiManagementService();

                // create parent authorization provider
                string authorizationProviderId = TestUtilities.GenerateName("authorizationProviderId");
                try
                {
                    var createAuthorizationProviderResponse = await testBase.client.AuthorizationProvider.CreateOrUpdateWithHttpMessagesAsync(
                        testBase.rgName,
                        testBase.serviceName,
                        authorizationProviderId,
                        new AuthorizationProviderContract
                        {
                            DisplayName = TestUtilities.GenerateName("authorizationProviderDisplayName"),
                            IdentityProvider = TestUtilities.GenerateName("identityProvider"),
                            Oauth2 = new AuthorizationProviderOAuth2Settings { RedirectUrl = "https://contoso.com" }
                        });
                    
                    // list all authorizations
                    var listResponse = await testBase.client.Authorization.ListByAuthorizationProviderWithHttpMessagesAsync(
                        testBase.rgName,
                        testBase.serviceName,
                        authorizationProviderId,
                        null);

                    // create authorization
                    string authorizationId = TestUtilities.GenerateName("authorizationId");
                    var authorizationContract = new AuthorizationContract
                    {
                        AuthorizationType = AuthorizationType.OAuth2,
                        OAuth2GrantType = OAuth2GrantType.AuthorizationCode
                    };

                    var createAuthorizationResponse = await testBase.client.Authorization.CreateOrUpdateWithHttpMessagesAsync(
                        testBase.rgName,
                        testBase.serviceName,
                        authorizationProviderId,
                        authorizationId,
                        authorizationContract);

                    Assert.NotNull(createAuthorizationResponse);

                    // get authorization to validate that it was created
                    var getResponse = await testBase.client.Authorization.GetWithHttpMessagesAsync(
                        testBase.rgName,
                        testBase.serviceName,
                        authorizationProviderId,
                        authorizationId);

                    Assert.NotNull(getResponse);
                    Assert.NotNull(getResponse.Headers.ETag);
                    Assert.NotNull(getResponse.Body);

                    Assert.Equal(authorizationId, getResponse.Body.Id);
                    Assert.Equal(authorizationContract.AuthorizationType, getResponse.Body.AuthorizationType);
                    Assert.Equal(authorizationContract.OAuth2GrantType, getResponse.Body.OAuth2GrantType);

                    // list authorizations again
                    listResponse = await testBase.client.Authorization.ListByAuthorizationProviderWithHttpMessagesAsync(
                        testBase.rgName,
                        testBase.serviceName,
                        authorizationProviderId,
                        null);

                    Assert.NotNull(listResponse);
                    Assert.NotEmpty(listResponse.Body);

                    // update authorization
                    var updateParameters = new AuthorizationContract
                    {
                        AuthorizationType = AuthorizationType.OAuth2,
                        OAuth2GrantType = OAuth2GrantType.ClientCredentials
                    };

                    await testBase.client.Authorization.CreateOrUpdateWithHttpMessagesAsync(
                        testBase.rgName,
                        testBase.serviceName,
                        authorizationProviderId,
                        authorizationId,
                        updateParameters,
                        getResponse.Headers.ETag);

                    // get authorization to validate that it was updated
                    getResponse = await testBase.client.Authorization.GetWithHttpMessagesAsync(
                        testBase.rgName,
                        testBase.serviceName,
                        authorizationProviderId,
                        authorizationId);

                    Assert.NotNull(getResponse);
                    Assert.NotNull(getResponse.Headers.ETag);
                    Assert.NotNull(getResponse.Body);

                    Assert.Equal(authorizationId, getResponse.Body.Id);
                    Assert.Equal(updateParameters.AuthorizationType, getResponse.Body.AuthorizationType);
                    Assert.Equal(updateParameters.OAuth2GrantType, getResponse.Body.OAuth2GrantType);

                    // delete authorization
                    await testBase.client.Authorization.DeleteWithHttpMessagesAsync(
                        testBase.rgName,
                        testBase.serviceName,
                        authorizationProviderId,
                        authorizationId,
                        getResponse.Headers.ETag);

                    // get authorization to validate that it was deleted
                    try
                    {
                        await testBase.client.Authorization.GetWithHttpMessagesAsync(
                            testBase.rgName,
                            testBase.serviceName,
                            authorizationProviderId,
                            authorizationId);

                        throw new Exception("This code should not have been executed.");
                    }
                    catch (ErrorResponseException ex)
                    {
                        Assert.Equal((int)HttpStatusCode.NotFound, (int)ex.Response.StatusCode);
                    }
                }
                finally
                {
                    // delete authorization provider to ensure cascade clean up
                    await testBase.client.AuthorizationProvider.DeleteWithHttpMessagesAsync(
                        testBase.rgName,
                        testBase.serviceName,
                        authorizationProviderId,
                        "*");
                }
            }
        }

        [Fact]
        [Trait("owner", "loganzipkes")]
        public async Task AccessPolicyCreateListUpdateDelete()
        {
            Environment.SetEnvironmentVariable("AZURE_TEST_MODE", "Playback");
            using (MockContext context = MockContext.Start(this.GetType()))
            {
                var testBase = new ApiManagementTestBase(context);
                testBase.TryCreateApiManagementService();

                // create parent authorization provider
                string authorizationProviderId = TestUtilities.GenerateName("authorizationProviderId");

                try
                {
                    var createAuthorizationProviderResponse = await testBase.client.AuthorizationProvider.CreateOrUpdateWithHttpMessagesAsync(
                        testBase.rgName,
                        testBase.serviceName,
                        authorizationProviderId,
                        new AuthorizationProviderContract
                        {
                            DisplayName = TestUtilities.GenerateName("authorizationProviderDisplayName"),
                            IdentityProvider = TestUtilities.GenerateName("identityProvider"),
                            Oauth2 = new AuthorizationProviderOAuth2Settings { RedirectUrl = "https://contoso.com" }
                        });

                    var authorizationId = TestUtilities.GenerateName("authorizationId");
                    var createAuthorizationResponse = await testBase.client.Authorization.CreateOrUpdateWithHttpMessagesAsync(
                        testBase.rgName,
                        testBase.serviceName,
                        authorizationProviderId,
                        authorizationId,
                        new AuthorizationContract
                        {
                            AuthorizationType = AuthorizationType.OAuth2,
                            OAuth2GrantType = OAuth2GrantType.AuthorizationCode
                        });

                    // list all access policies
                    var listResponse = await testBase.client.AuthorizationAccessPolicy.ListByAuthorizationWithHttpMessagesAsync(
                        testBase.rgName,
                        testBase.serviceName,
                        authorizationProviderId,
                        authorizationId,
                        null);

                    Assert.NotNull(listResponse);
                    Assert.Empty(listResponse.Body);

                    // create access policy
                    var accessPolicyId = TestUtilities.GenerateName("accessPolicyId");
                    var accessPolicyContract = new AuthorizationAccessPolicyContract
                    {
                        TenantId = TestUtilities.GenerateName("tenantId"),
                        ObjectId = TestUtilities.GenerateName("objectId")
                    };

                    var createResponse = await testBase.client.AuthorizationAccessPolicy.CreateOrUpdateWithHttpMessagesAsync(
                        testBase.rgName,
                        testBase.serviceName,
                        authorizationProviderId,
                        authorizationId,
                        accessPolicyId,
                        accessPolicyContract);

                    Assert.NotNull(createResponse);

                    // get access policy to validate that it was created
                    var getResponse = await testBase.client.AuthorizationAccessPolicy.GetWithHttpMessagesAsync(
                        testBase.rgName,
                        testBase.serviceName,
                        authorizationProviderId,
                        authorizationId,
                        accessPolicyId);

                    Assert.NotNull(getResponse);
                    Assert.NotNull(getResponse.Headers.ETag);
                    Assert.NotNull(getResponse.Body);

                    Assert.Equal(accessPolicyId, getResponse.Body.Id);
                    Assert.Equal(accessPolicyContract.TenantId, getResponse.Body.TenantId);
                    Assert.Equal(accessPolicyContract.ObjectId, getResponse.Body.ObjectId);

                    // list access policies again
                    listResponse = await testBase.client.AuthorizationAccessPolicy.ListByAuthorizationWithHttpMessagesAsync(
                        testBase.rgName,
                        testBase.serviceName,
                        authorizationProviderId,
                        authorizationId,
                        null);

                    Assert.NotNull(listResponse);
                    Assert.NotEmpty(listResponse.Body);

                    // update access policies
                    var updateParameters = new AuthorizationAccessPolicyContract
                    {
                        TenantId = TestUtilities.GenerateName("newTenantId"),
                        ObjectId = TestUtilities.GenerateName("objectId")
                    };

                    await testBase.client.AuthorizationAccessPolicy.CreateOrUpdateWithHttpMessagesAsync(
                        testBase.rgName,
                        testBase.serviceName,
                        authorizationProviderId,
                        authorizationId,
                        accessPolicyId,
                        updateParameters,
                        getResponse.Headers.ETag);

                    // get access policy to validate that it was updated
                    getResponse = await testBase.client.AuthorizationAccessPolicy.GetWithHttpMessagesAsync(
                        testBase.rgName,
                        testBase.serviceName,
                        authorizationProviderId,
                        authorizationId,
                        accessPolicyId);

                    Assert.NotNull(getResponse);
                    Assert.NotNull(getResponse.Headers.ETag);
                    Assert.NotNull(getResponse.Body);

                    Assert.Equal(accessPolicyId, getResponse.Body.Id);
                    Assert.Equal(updateParameters.TenantId, getResponse.Body.TenantId);
                    Assert.Equal(updateParameters.ObjectId, getResponse.Body.ObjectId);

                    // delete access policy
                    await testBase.client.AuthorizationAccessPolicy.DeleteWithHttpMessagesAsync(
                        testBase.rgName,
                        testBase.serviceName,
                        authorizationProviderId,
                        authorizationId,
                        accessPolicyId,
                        getResponse.Headers.ETag);

                    // get access policy to validate that it was deleted
                    try
                    {
                        await testBase.client.AuthorizationAccessPolicy.GetWithHttpMessagesAsync(
                            testBase.rgName,
                            testBase.serviceName,
                            authorizationProviderId,
                            authorizationId,
                            accessPolicyId);

                        throw new Exception("This code should not have been executed.");
                    }
                    catch (ErrorResponseException ex)
                    {
                        Assert.Equal((int)HttpStatusCode.NotFound, (int)ex.Response.StatusCode);
                    }
                }
                finally
                {
                    // delete authorization provider to ensure cascade clean up
                    await testBase.client.AuthorizationProvider.DeleteWithHttpMessagesAsync(
                        testBase.rgName,
                        testBase.serviceName,
                        authorizationProviderId,
                        "*");
                }
            }
        }
    }
}