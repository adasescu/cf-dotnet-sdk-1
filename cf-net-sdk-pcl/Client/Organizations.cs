using cf_net_sdk.Client.Data;
using cf_net_sdk.Interfaces;
using CloudFoundry.Common;
using CloudFoundry.Common.ServiceLocation;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace cf_net_sdk.Client
{
    public class OrganizationsEndpoint: BaseEndpoint
    {
        public OrganizationsEndpoint(CloudfoundryClient client)
        {
            this.CloudTarget = client.CloudTarget;
            this.CancellationToken = client.CancellationToken;
            this.ServiceLocator = client.ServiceLocator;
            this.auth = client.auth;
        }
    
        /// <summary>
        /// Retrieve a Particular Organization
        /// </summary>
    
        
    

    
        public async Task<RetrieveOrganizationResponse> RetrieveOrganization(Guid? guid)
    
        {
            string route = string.Format("/v2/organizations/{0}", guid);
        
            
            string endpoint = this.CloudTarget.ToString().TrimEnd('/') + route;
            
            var client = this.GetHttpClient();
            client.Uri = new Uri(endpoint);

            client.Method = HttpMethod.Get;
            client.Headers.Add(BuildAuthenticationHeader());
        
        
            // TODO: vladi: Implement serialization

            var response = await client.SendAsync();
        
            
            return Util.DeserializeJson<RetrieveOrganizationResponse>(await response.ReadContentAsStringAsync());
            
        
        }
    
        /// <summary>
        /// List all Organizations
        /// </summary>
    
        
        public async Task<PagedResponse<ListAllOrganizationsResponse>> ListAllOrganizations()
        {
            return await ListAllOrganizations(new RequestOptions());
        }
        
    

    
        public async Task<PagedResponse<ListAllOrganizationsResponse>> ListAllOrganizations(RequestOptions options)
    
        {
            string route = "/v2/organizations";
        
            
            string endpoint = this.CloudTarget.ToString().TrimEnd('/') + route + options.ToString();
            
            var client = this.GetHttpClient();
            client.Uri = new Uri(endpoint);

            client.Method = HttpMethod.Get;
            client.Headers.Add(BuildAuthenticationHeader());
        
        
            // TODO: vladi: Implement serialization

            var response = await client.SendAsync();
        
            
            return Util.DeserializePage<ListAllOrganizationsResponse>(await response.ReadContentAsStringAsync());
            
        
        }
    
        /// <summary>
        /// Remove User from the Organization
        /// </summary>
    

    
        public async Task<RemoveUserFromOrganizationResponse> RemoveUserFromOrganization(Guid? guid, Guid? user_guid)
    
        {
            string route = string.Format("/v2/organizations/{0}/users/{1}", guid, user_guid);
        
            
            string endpoint = this.CloudTarget.ToString().TrimEnd('/') + route;
            
            var client = this.GetHttpClient();
            client.Uri = new Uri(endpoint);

            client.Method = HttpMethod.Delete;
            client.Headers.Add(BuildAuthenticationHeader());
        
            client.ContentType = "application/x-www-form-urlencoded";
        
        
            // TODO: vladi: Implement serialization

            var response = await client.SendAsync();
        
            
            return Util.DeserializeJson<RemoveUserFromOrganizationResponse>(await response.ReadContentAsStringAsync());
            
        
        }
    
        /// <summary>
        /// Remove Billing Manager from the Organization
        /// </summary>
    

    
        public async Task<RemoveBillingManagerFromOrganizationResponse> RemoveBillingManagerFromOrganization(Guid? guid, Guid? billing_manager_guid)
    
        {
            string route = string.Format("/v2/organizations/{0}/billing_managers/{1}", guid, billing_manager_guid);
        
            
            string endpoint = this.CloudTarget.ToString().TrimEnd('/') + route;
            
            var client = this.GetHttpClient();
            client.Uri = new Uri(endpoint);

            client.Method = HttpMethod.Delete;
            client.Headers.Add(BuildAuthenticationHeader());
        
            client.ContentType = "application/x-www-form-urlencoded";
        
        
            // TODO: vladi: Implement serialization

            var response = await client.SendAsync();
        
            
            return Util.DeserializeJson<RemoveBillingManagerFromOrganizationResponse>(await response.ReadContentAsStringAsync());
            
        
        }
    
        /// <summary>
        /// Get Organization summary
        /// </summary>
    
        
    

    
        public async Task<GetOrganizationSummaryResponse> GetOrganizationSummary(Guid? guid)
    
        {
            string route = string.Format("/v2/organizations/{0}/summary", guid);
        
            
            string endpoint = this.CloudTarget.ToString().TrimEnd('/') + route;
            
            var client = this.GetHttpClient();
            client.Uri = new Uri(endpoint);

            client.Method = HttpMethod.Get;
            client.Headers.Add(BuildAuthenticationHeader());
        
        
            // TODO: vladi: Implement serialization

            var response = await client.SendAsync();
        
            
            return Util.DeserializeJson<GetOrganizationSummaryResponse>(await response.ReadContentAsStringAsync());
            
        
        }
    
        /// <summary>
        /// Delete a Particular Organization
        /// </summary>
    

    
        public async Task DeleteOrganization(Guid? guid)
    
        {
            string route = string.Format("/v2/organizations/{0}", guid);
        
            
            string endpoint = this.CloudTarget.ToString().TrimEnd('/') + route;
            
            var client = this.GetHttpClient();
            client.Uri = new Uri(endpoint);

            client.Method = HttpMethod.Delete;
            client.Headers.Add(BuildAuthenticationHeader());
        
            client.ContentType = "application/x-www-form-urlencoded";
        
        
            // TODO: vladi: Implement serialization

            var response = await client.SendAsync();
        
        }
    
        /// <summary>
        /// List all Spaces for the Organization
        /// </summary>
    
        
        public async Task<PagedResponse<ListAllSpacesForOrganizationResponse>> ListAllSpacesForOrganization(Guid? guid)
        {
            return await ListAllSpacesForOrganization(guid, new RequestOptions());
        }
        
    

    
        public async Task<PagedResponse<ListAllSpacesForOrganizationResponse>> ListAllSpacesForOrganization(Guid? guid, RequestOptions options)
    
        {
            string route = string.Format("/v2/organizations/{0}/spaces", guid);
        
            
            string endpoint = this.CloudTarget.ToString().TrimEnd('/') + route + options.ToString();
            
            var client = this.GetHttpClient();
            client.Uri = new Uri(endpoint);

            client.Method = HttpMethod.Get;
            client.Headers.Add(BuildAuthenticationHeader());
        
        
            // TODO: vladi: Implement serialization

            var response = await client.SendAsync();
        
            
            return Util.DeserializePage<ListAllSpacesForOrganizationResponse>(await response.ReadContentAsStringAsync());
            
        
        }
    
        /// <summary>
        /// List all Space Quota Definitions for the Organization
        /// </summary>
    
        
        public async Task<PagedResponse<ListAllSpaceQuotaDefinitionsForOrganizationResponse>> ListAllSpaceQuotaDefinitionsForOrganization(Guid? guid)
        {
            return await ListAllSpaceQuotaDefinitionsForOrganization(guid, new RequestOptions());
        }
        
    

    
        public async Task<PagedResponse<ListAllSpaceQuotaDefinitionsForOrganizationResponse>> ListAllSpaceQuotaDefinitionsForOrganization(Guid? guid, RequestOptions options)
    
        {
            string route = string.Format("/v2/organizations/{0}/space_quota_definitions", guid);
        
            
            string endpoint = this.CloudTarget.ToString().TrimEnd('/') + route + options.ToString();
            
            var client = this.GetHttpClient();
            client.Uri = new Uri(endpoint);

            client.Method = HttpMethod.Get;
            client.Headers.Add(BuildAuthenticationHeader());
        
        
            // TODO: vladi: Implement serialization

            var response = await client.SendAsync();
        
            
            return Util.DeserializePage<ListAllSpaceQuotaDefinitionsForOrganizationResponse>(await response.ReadContentAsStringAsync());
            
        
        }
    
        /// <summary>
        /// Associate Billing Manager with the Organization
        /// </summary>
    

    
        public async Task<AssociateBillingManagerWithOrganizationResponse> AssociateBillingManagerWithOrganization(Guid? guid, Guid? billing_manager_guid)
    
        {
            string route = string.Format("/v2/organizations/{0}/billing_managers/{1}", guid, billing_manager_guid);
        
            
            string endpoint = this.CloudTarget.ToString().TrimEnd('/') + route;
            
            var client = this.GetHttpClient();
            client.Uri = new Uri(endpoint);

            client.Method = HttpMethod.Put;
            client.Headers.Add(BuildAuthenticationHeader());
        
            client.ContentType = "application/x-www-form-urlencoded";
        
        
            // TODO: vladi: Implement serialization

            var response = await client.SendAsync();
        
            
            return Util.DeserializeJson<AssociateBillingManagerWithOrganizationResponse>(await response.ReadContentAsStringAsync());
            
        
        }
    
        /// <summary>
        /// List all Users for the Organization
        /// </summary>
    
        
        public async Task<PagedResponse<ListAllUsersForOrganizationResponse>> ListAllUsersForOrganization(Guid? guid)
        {
            return await ListAllUsersForOrganization(guid, new RequestOptions());
        }
        
    

    
        public async Task<PagedResponse<ListAllUsersForOrganizationResponse>> ListAllUsersForOrganization(Guid? guid, RequestOptions options)
    
        {
            string route = string.Format("/v2/organizations/{0}/users", guid);
        
            
            string endpoint = this.CloudTarget.ToString().TrimEnd('/') + route + options.ToString();
            
            var client = this.GetHttpClient();
            client.Uri = new Uri(endpoint);

            client.Method = HttpMethod.Get;
            client.Headers.Add(BuildAuthenticationHeader());
        
        
            // TODO: vladi: Implement serialization

            var response = await client.SendAsync();
        
            
            return Util.DeserializePage<ListAllUsersForOrganizationResponse>(await response.ReadContentAsStringAsync());
            
        
        }
    
        /// <summary>
        /// Associate User with the Organization
        /// </summary>
    

    
        public async Task<AssociateUserWithOrganizationResponse> AssociateUserWithOrganization(Guid? guid, Guid? user_guid)
    
        {
            string route = string.Format("/v2/organizations/{0}/users/{1}", guid, user_guid);
        
            
            string endpoint = this.CloudTarget.ToString().TrimEnd('/') + route;
            
            var client = this.GetHttpClient();
            client.Uri = new Uri(endpoint);

            client.Method = HttpMethod.Put;
            client.Headers.Add(BuildAuthenticationHeader());
        
            client.ContentType = "application/x-www-form-urlencoded";
        
        
            // TODO: vladi: Implement serialization

            var response = await client.SendAsync();
        
            
            return Util.DeserializeJson<AssociateUserWithOrganizationResponse>(await response.ReadContentAsStringAsync());
            
        
        }
    
        /// <summary>
        /// List all Services for the Organization
        /// </summary>
    
        
        public async Task<PagedResponse<ListAllServicesForOrganizationResponse>> ListAllServicesForOrganization(Guid? guid)
        {
            return await ListAllServicesForOrganization(guid, new RequestOptions());
        }
        
    

    
        public async Task<PagedResponse<ListAllServicesForOrganizationResponse>> ListAllServicesForOrganization(Guid? guid, RequestOptions options)
    
        {
            string route = string.Format("/v2/organizations/{0}/services", guid);
        
            
            string endpoint = this.CloudTarget.ToString().TrimEnd('/') + route + options.ToString();
            
            var client = this.GetHttpClient();
            client.Uri = new Uri(endpoint);

            client.Method = HttpMethod.Get;
            client.Headers.Add(BuildAuthenticationHeader());
        
        
            // TODO: vladi: Implement serialization

            var response = await client.SendAsync();
        
            
            return Util.DeserializePage<ListAllServicesForOrganizationResponse>(await response.ReadContentAsStringAsync());
            
        
        }
    
        /// <summary>
        /// Remove Auditor from the Organization
        /// </summary>
    

    
        public async Task<RemoveAuditorFromOrganizationResponse> RemoveAuditorFromOrganization(Guid? guid, Guid? auditor_guid)
    
        {
            string route = string.Format("/v2/organizations/{0}/auditors/{1}", guid, auditor_guid);
        
            
            string endpoint = this.CloudTarget.ToString().TrimEnd('/') + route;
            
            var client = this.GetHttpClient();
            client.Uri = new Uri(endpoint);

            client.Method = HttpMethod.Delete;
            client.Headers.Add(BuildAuthenticationHeader());
        
            client.ContentType = "application/x-www-form-urlencoded";
        
        
            // TODO: vladi: Implement serialization

            var response = await client.SendAsync();
        
            
            return Util.DeserializeJson<RemoveAuditorFromOrganizationResponse>(await response.ReadContentAsStringAsync());
            
        
        }
    
        /// <summary>
        /// List all Private Domains for the Organization
        /// </summary>
    
        
        public async Task<PagedResponse<ListAllPrivateDomainsForOrganizationResponse>> ListAllPrivateDomainsForOrganization(Guid? guid)
        {
            return await ListAllPrivateDomainsForOrganization(guid, new RequestOptions());
        }
        
    

    
        public async Task<PagedResponse<ListAllPrivateDomainsForOrganizationResponse>> ListAllPrivateDomainsForOrganization(Guid? guid, RequestOptions options)
    
        {
            string route = string.Format("/v2/organizations/{0}/private_domains", guid);
        
            
            string endpoint = this.CloudTarget.ToString().TrimEnd('/') + route + options.ToString();
            
            var client = this.GetHttpClient();
            client.Uri = new Uri(endpoint);

            client.Method = HttpMethod.Get;
            client.Headers.Add(BuildAuthenticationHeader());
        
        
            // TODO: vladi: Implement serialization

            var response = await client.SendAsync();
        
            
            return Util.DeserializePage<ListAllPrivateDomainsForOrganizationResponse>(await response.ReadContentAsStringAsync());
            
        
        }
    
        /// <summary>
        /// Associate Manager with the Organization
        /// </summary>
    

    
        public async Task<AssociateManagerWithOrganizationResponse> AssociateManagerWithOrganization(Guid? guid, Guid? manager_guid)
    
        {
            string route = string.Format("/v2/organizations/{0}/managers/{1}", guid, manager_guid);
        
            
            string endpoint = this.CloudTarget.ToString().TrimEnd('/') + route;
            
            var client = this.GetHttpClient();
            client.Uri = new Uri(endpoint);

            client.Method = HttpMethod.Put;
            client.Headers.Add(BuildAuthenticationHeader());
        
            client.ContentType = "application/x-www-form-urlencoded";
        
        
            // TODO: vladi: Implement serialization

            var response = await client.SendAsync();
        
            
            return Util.DeserializeJson<AssociateManagerWithOrganizationResponse>(await response.ReadContentAsStringAsync());
            
        
        }
    
        /// <summary>
        /// Update an Organization
        /// </summary>
    

    
        public async Task<UpdateOrganizationResponse> UpdateOrganization(Guid? guid, UpdateOrganizationRequest value)
    
        {
            string route = string.Format("/v2/organizations/{0}", guid);
        
            
            string endpoint = this.CloudTarget.ToString().TrimEnd('/') + route;
            
            var client = this.GetHttpClient();
            client.Uri = new Uri(endpoint);

            client.Method = HttpMethod.Put;
            client.Headers.Add(BuildAuthenticationHeader());
        
            client.ContentType = "application/x-www-form-urlencoded";
        
        
            client.Content = JsonConvert.SerializeObject(value).ConvertToStream();
        
            // TODO: vladi: Implement serialization

            var response = await client.SendAsync();
        
            
            return Util.DeserializeJson<UpdateOrganizationResponse>(await response.ReadContentAsStringAsync());
            
        
        }
    
        /// <summary>
        /// Creating an Organization
        /// </summary>
    

    
        public async Task<CreateOrganizationResponse> CreateOrganization(CreateOrganizationRequest value)
    
        {
            string route = "/v2/organizations/";
        
            
            string endpoint = this.CloudTarget.ToString().TrimEnd('/') + route;
            
            var client = this.GetHttpClient();
            client.Uri = new Uri(endpoint);

            client.Method = HttpMethod.Post;
            client.Headers.Add(BuildAuthenticationHeader());
        
            client.ContentType = "application/x-www-form-urlencoded";
        
        
            client.Content = JsonConvert.SerializeObject(value).ConvertToStream();
        
            // TODO: vladi: Implement serialization

            var response = await client.SendAsync();
        
            
            return Util.DeserializeJson<CreateOrganizationResponse>(await response.ReadContentAsStringAsync());
            
        
        }
    
        /// <summary>
        /// List all Domains for the Organization (deprecated)
        /// </summary>
    
        
        public async Task<PagedResponse<ListAllDomainsForOrganizationDeprecatedResponse>> ListAllDomainsForOrganizationDeprecated(Guid? guid)
        {
            return await ListAllDomainsForOrganizationDeprecated(guid, new RequestOptions());
        }
        
    

    
        public async Task<PagedResponse<ListAllDomainsForOrganizationDeprecatedResponse>> ListAllDomainsForOrganizationDeprecated(Guid? guid, RequestOptions options)
    
        {
            string route = string.Format("/v2/organizations/{0}/domains", guid);
        
            
            string endpoint = this.CloudTarget.ToString().TrimEnd('/') + route + options.ToString();
            
            var client = this.GetHttpClient();
            client.Uri = new Uri(endpoint);

            client.Method = HttpMethod.Get;
            client.Headers.Add(BuildAuthenticationHeader());
        
        
            // TODO: vladi: Implement serialization

            var response = await client.SendAsync();
        
            
            return Util.DeserializePage<ListAllDomainsForOrganizationDeprecatedResponse>(await response.ReadContentAsStringAsync());
            
        
        }
    
        /// <summary>
        /// List all Managers for the Organization
        /// </summary>
    
        
        public async Task<PagedResponse<ListAllManagersForOrganizationResponse>> ListAllManagersForOrganization(Guid? guid)
        {
            return await ListAllManagersForOrganization(guid, new RequestOptions());
        }
        
    

    
        public async Task<PagedResponse<ListAllManagersForOrganizationResponse>> ListAllManagersForOrganization(Guid? guid, RequestOptions options)
    
        {
            string route = string.Format("/v2/organizations/{0}/managers", guid);
        
            
            string endpoint = this.CloudTarget.ToString().TrimEnd('/') + route + options.ToString();
            
            var client = this.GetHttpClient();
            client.Uri = new Uri(endpoint);

            client.Method = HttpMethod.Get;
            client.Headers.Add(BuildAuthenticationHeader());
        
        
            // TODO: vladi: Implement serialization

            var response = await client.SendAsync();
        
            
            return Util.DeserializePage<ListAllManagersForOrganizationResponse>(await response.ReadContentAsStringAsync());
            
        
        }
    
        /// <summary>
        /// Remove Manager from the Organization
        /// </summary>
    

    
        public async Task<RemoveManagerFromOrganizationResponse> RemoveManagerFromOrganization(Guid? guid, Guid? manager_guid)
    
        {
            string route = string.Format("/v2/organizations/{0}/managers/{1}", guid, manager_guid);
        
            
            string endpoint = this.CloudTarget.ToString().TrimEnd('/') + route;
            
            var client = this.GetHttpClient();
            client.Uri = new Uri(endpoint);

            client.Method = HttpMethod.Delete;
            client.Headers.Add(BuildAuthenticationHeader());
        
            client.ContentType = "application/x-www-form-urlencoded";
        
        
            // TODO: vladi: Implement serialization

            var response = await client.SendAsync();
        
            
            return Util.DeserializeJson<RemoveManagerFromOrganizationResponse>(await response.ReadContentAsStringAsync());
            
        
        }
    
        /// <summary>
        /// List all Auditors for the Organization
        /// </summary>
    
        
        public async Task<PagedResponse<ListAllAuditorsForOrganizationResponse>> ListAllAuditorsForOrganization(Guid? guid)
        {
            return await ListAllAuditorsForOrganization(guid, new RequestOptions());
        }
        
    

    
        public async Task<PagedResponse<ListAllAuditorsForOrganizationResponse>> ListAllAuditorsForOrganization(Guid? guid, RequestOptions options)
    
        {
            string route = string.Format("/v2/organizations/{0}/auditors", guid);
        
            
            string endpoint = this.CloudTarget.ToString().TrimEnd('/') + route + options.ToString();
            
            var client = this.GetHttpClient();
            client.Uri = new Uri(endpoint);

            client.Method = HttpMethod.Get;
            client.Headers.Add(BuildAuthenticationHeader());
        
        
            // TODO: vladi: Implement serialization

            var response = await client.SendAsync();
        
            
            return Util.DeserializePage<ListAllAuditorsForOrganizationResponse>(await response.ReadContentAsStringAsync());
            
        
        }
    
        /// <summary>
        /// List all Billing Managers for the Organization
        /// </summary>
    
        
        public async Task<PagedResponse<ListAllBillingManagersForOrganizationResponse>> ListAllBillingManagersForOrganization(Guid? guid)
        {
            return await ListAllBillingManagersForOrganization(guid, new RequestOptions());
        }
        
    

    
        public async Task<PagedResponse<ListAllBillingManagersForOrganizationResponse>> ListAllBillingManagersForOrganization(Guid? guid, RequestOptions options)
    
        {
            string route = string.Format("/v2/organizations/{0}/billing_managers", guid);
        
            
            string endpoint = this.CloudTarget.ToString().TrimEnd('/') + route + options.ToString();
            
            var client = this.GetHttpClient();
            client.Uri = new Uri(endpoint);

            client.Method = HttpMethod.Get;
            client.Headers.Add(BuildAuthenticationHeader());
        
        
            // TODO: vladi: Implement serialization

            var response = await client.SendAsync();
        
            
            return Util.DeserializePage<ListAllBillingManagersForOrganizationResponse>(await response.ReadContentAsStringAsync());
            
        
        }
    
        /// <summary>
        /// Associate Auditor with the Organization
        /// </summary>
    

    
        public async Task<AssociateAuditorWithOrganizationResponse> AssociateAuditorWithOrganization(Guid? guid, Guid? auditor_guid)
    
        {
            string route = string.Format("/v2/organizations/{0}/auditors/{1}", guid, auditor_guid);
        
            
            string endpoint = this.CloudTarget.ToString().TrimEnd('/') + route;
            
            var client = this.GetHttpClient();
            client.Uri = new Uri(endpoint);

            client.Method = HttpMethod.Put;
            client.Headers.Add(BuildAuthenticationHeader());
        
            client.ContentType = "application/x-www-form-urlencoded";
        
        
            // TODO: vladi: Implement serialization

            var response = await client.SendAsync();
        
            
            return Util.DeserializeJson<AssociateAuditorWithOrganizationResponse>(await response.ReadContentAsStringAsync());
            
        
        }
    
    }
}