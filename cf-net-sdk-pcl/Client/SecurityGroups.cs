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
    public class SecurityGroupsEndpoint: BaseEndpoint
    {
        public SecurityGroupsEndpoint(CloudfoundryClient client)
        {
            this.CloudTarget = client.CloudTarget;
            this.CancellationToken = client.CancellationToken;
            this.ServiceLocator = client.ServiceLocator;
            this.auth = client.auth;
        }
    
        /// <summary>
        /// List all Security Groups
        /// </summary>
    
        
        public async Task<PagedResponse<ListAllSecurityGroupsResponse>> ListAllSecurityGroups()
        {
            return await ListAllSecurityGroups(new RequestOptions());
        }
        
    

    
        public async Task<PagedResponse<ListAllSecurityGroupsResponse>> ListAllSecurityGroups(RequestOptions options)
    
        {
            string route = "/v2/security_groups";
        
            
            string endpoint = this.CloudTarget.ToString().TrimEnd('/') + route + options.ToString();
            
            var client = this.GetHttpClient();
            client.Uri = new Uri(endpoint);

            client.Method = HttpMethod.Get;
            client.Headers.Add(BuildAuthenticationHeader());
        
        
            // TODO: vladi: Implement serialization

            var response = await client.SendAsync();
        
            
            return Util.DeserializePage<ListAllSecurityGroupsResponse>(await response.ReadContentAsStringAsync());
            
        
        }
    
        /// <summary>
        /// Delete a Particular Security Group
        /// </summary>
    

    
        public async Task DeleteSecurityGroup(Guid? guid)
    
        {
            string route = string.Format("/v2/security_groups/{0}", guid);
        
            
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
        /// List all Spaces for the Security Group
        /// </summary>
    
        
        public async Task<PagedResponse<ListAllSpacesForSecurityGroupResponse>> ListAllSpacesForSecurityGroup(Guid? guid)
        {
            return await ListAllSpacesForSecurityGroup(guid, new RequestOptions());
        }
        
    

    
        public async Task<PagedResponse<ListAllSpacesForSecurityGroupResponse>> ListAllSpacesForSecurityGroup(Guid? guid, RequestOptions options)
    
        {
            string route = string.Format("/v2/security_groups/{0}/spaces", guid);
        
            
            string endpoint = this.CloudTarget.ToString().TrimEnd('/') + route + options.ToString();
            
            var client = this.GetHttpClient();
            client.Uri = new Uri(endpoint);

            client.Method = HttpMethod.Get;
            client.Headers.Add(BuildAuthenticationHeader());
        
        
            // TODO: vladi: Implement serialization

            var response = await client.SendAsync();
        
            
            return Util.DeserializePage<ListAllSpacesForSecurityGroupResponse>(await response.ReadContentAsStringAsync());
            
        
        }
    
        /// <summary>
        /// Retrieve a Particular Security Group
        /// </summary>
    
        
    

    
        public async Task<RetrieveSecurityGroupResponse> RetrieveSecurityGroup(Guid? guid)
    
        {
            string route = string.Format("/v2/security_groups/{0}", guid);
        
            
            string endpoint = this.CloudTarget.ToString().TrimEnd('/') + route;
            
            var client = this.GetHttpClient();
            client.Uri = new Uri(endpoint);

            client.Method = HttpMethod.Get;
            client.Headers.Add(BuildAuthenticationHeader());
        
        
            // TODO: vladi: Implement serialization

            var response = await client.SendAsync();
        
            
            return Util.DeserializeJson<RetrieveSecurityGroupResponse>(await response.ReadContentAsStringAsync());
            
        
        }
    
        /// <summary>
        /// Remove Space from the Security Group
        /// </summary>
    

    
        public async Task<RemoveSpaceFromSecurityGroupResponse> RemoveSpaceFromSecurityGroup(Guid? guid, Guid? space_guid)
    
        {
            string route = string.Format("/v2/security_groups/{0}/spaces/{1}", guid, space_guid);
        
            
            string endpoint = this.CloudTarget.ToString().TrimEnd('/') + route;
            
            var client = this.GetHttpClient();
            client.Uri = new Uri(endpoint);

            client.Method = HttpMethod.Delete;
            client.Headers.Add(BuildAuthenticationHeader());
        
            client.ContentType = "application/x-www-form-urlencoded";
        
        
            // TODO: vladi: Implement serialization

            var response = await client.SendAsync();
        
            
            return Util.DeserializeJson<RemoveSpaceFromSecurityGroupResponse>(await response.ReadContentAsStringAsync());
            
        
        }
    
        /// <summary>
        /// Associate Space with the Security Group
        /// </summary>
    

    
        public async Task<AssociateSpaceWithSecurityGroupResponse> AssociateSpaceWithSecurityGroup(Guid? guid, Guid? space_guid)
    
        {
            string route = string.Format("/v2/security_groups/{0}/spaces/{1}", guid, space_guid);
        
            
            string endpoint = this.CloudTarget.ToString().TrimEnd('/') + route;
            
            var client = this.GetHttpClient();
            client.Uri = new Uri(endpoint);

            client.Method = HttpMethod.Put;
            client.Headers.Add(BuildAuthenticationHeader());
        
            client.ContentType = "application/x-www-form-urlencoded";
        
        
            // TODO: vladi: Implement serialization

            var response = await client.SendAsync();
        
            
            return Util.DeserializeJson<AssociateSpaceWithSecurityGroupResponse>(await response.ReadContentAsStringAsync());
            
        
        }
    
        /// <summary>
        /// Updating a Security Group
        /// </summary>
    

    
        public async Task<UpdateSecurityGroupResponse> UpdateSecurityGroup(Guid? guid, UpdateSecurityGroupRequest value)
    
        {
            string route = string.Format("/v2/security_groups/{0}", guid);
        
            
            string endpoint = this.CloudTarget.ToString().TrimEnd('/') + route;
            
            var client = this.GetHttpClient();
            client.Uri = new Uri(endpoint);

            client.Method = HttpMethod.Put;
            client.Headers.Add(BuildAuthenticationHeader());
        
            client.ContentType = "application/x-www-form-urlencoded";
        
        
            client.Content = JsonConvert.SerializeObject(value).ConvertToStream();
        
            // TODO: vladi: Implement serialization

            var response = await client.SendAsync();
        
            
            return Util.DeserializeJson<UpdateSecurityGroupResponse>(await response.ReadContentAsStringAsync());
            
        
        }
    
        /// <summary>
        /// Creating a Security Group
        /// </summary>
    

    
        public async Task<CreateSecurityGroupResponse> CreateSecurityGroup(CreateSecurityGroupRequest value)
    
        {
            string route = "/v2/security_groups/";
        
            
            string endpoint = this.CloudTarget.ToString().TrimEnd('/') + route;
            
            var client = this.GetHttpClient();
            client.Uri = new Uri(endpoint);

            client.Method = HttpMethod.Post;
            client.Headers.Add(BuildAuthenticationHeader());
        
            client.ContentType = "application/x-www-form-urlencoded";
        
        
            client.Content = JsonConvert.SerializeObject(value).ConvertToStream();
        
            // TODO: vladi: Implement serialization

            var response = await client.SendAsync();
        
            
            return Util.DeserializeJson<CreateSecurityGroupResponse>(await response.ReadContentAsStringAsync());
            
        
        }
    
    }
}