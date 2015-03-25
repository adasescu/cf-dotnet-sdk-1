//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

//
// This source code was auto-generated by cf-sdk-builder
//

using CloudFoundry.CloudController.Common;
using CloudFoundry.CloudController.V2.Client.Data;
using Newtonsoft.Json;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Globalization;
using System.Net.Http;
using System.Threading.Tasks;


namespace CloudFoundry.CloudController.V2.Client
{
    /// <summary>
    /// ServiceauthtokensDeprecated Endpoint
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public partial class ServiceauthtokensDeprecatedEndpoint : CloudFoundry.CloudController.V2.Client.Base.AbstractServiceauthtokensDeprecatedEndpoint
    {
        internal ServiceauthtokensDeprecatedEndpoint(CloudFoundryClient client) : base()
        {
            this.Client = client;
        }    
    }
}

namespace CloudFoundry.CloudController.V2.Client.Base
{
    /// <summary>
    /// Base abstract class for ServiceauthtokensDeprecated Endpoint
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public abstract class AbstractServiceauthtokensDeprecatedEndpoint : BaseEndpoint
    {
        /// <summary>
        /// Initializes the class
        /// </summary>
        protected AbstractServiceauthtokensDeprecatedEndpoint()
        {
        }

        /// <summary>
        /// List all Service Auth Tokens (deprecated)
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/195/serviceauthtokens__deprecated_/list_all_service_auth_tokens_(deprecated).html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListAllServiceAuthTokensDeprecatedResponse>> ListAllServiceAuthTokensDeprecated()
        {
            return await ListAllServiceAuthTokensDeprecated(new RequestOptions());
        }

        /// <summary>
        /// List all Service Auth Tokens (deprecated)
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/195/serviceauthtokens__deprecated_/list_all_service_auth_tokens_(deprecated).html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListAllServiceAuthTokensDeprecatedResponse>> ListAllServiceAuthTokensDeprecated(RequestOptions options)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = "/v2/service_auth_tokens";
            uriBuilder.Query = options.ToString();
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Get;
            client.Headers.Add(await BuildAuthenticationHeader());
            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializePage<ListAllServiceAuthTokensDeprecatedResponse>(await response.ReadContentAsStringAsync());
        }

        /// <summary>
        /// Filtering the result set by label (deprecated)
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/195/serviceauthtokens__deprecated_/filtering_the_result_set_by_label_(deprecated).html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<FilterResultSetByLabelDeprecatedResponse>> FilterResultSetByLabelDeprecated()
        {
            return await FilterResultSetByLabelDeprecated(new RequestOptions());
        }

        /// <summary>
        /// Filtering the result set by label (deprecated)
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/195/serviceauthtokens__deprecated_/filtering_the_result_set_by_label_(deprecated).html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<FilterResultSetByLabelDeprecatedResponse>> FilterResultSetByLabelDeprecated(RequestOptions options)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = "/v2/service_auth_tokens";
            uriBuilder.Query = options.ToString();
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Get;
            client.Headers.Add(await BuildAuthenticationHeader());
            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializePage<FilterResultSetByLabelDeprecatedResponse>(await response.ReadContentAsStringAsync());
        }

        /// <summary>
        /// Delete a Particular Service Auth Token (deprecated)
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/195/serviceauthtokens__deprecated_/delete_a_particular_service_auth_token_(deprecated).html"</para>
        /// </summary>
        public async Task DeleteServiceAuthTokenDeprecated(Guid? guid)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = string.Format(CultureInfo.InvariantCulture, "/v2/service_auth_tokens/{0}", guid);
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Delete;
            client.Headers.Add(await BuildAuthenticationHeader());
            client.ContentType = "application/x-www-form-urlencoded";
            var expectedReturnStatus = 204;
            var response = await this.SendAsync(client, expectedReturnStatus);
        }

        /// <summary>
        /// Retrieve a Particular Service Auth Token (deprecated)
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/195/serviceauthtokens__deprecated_/retrieve_a_particular_service_auth_token_(deprecated).html"</para>
        /// </summary>
        public async Task<RetrieveServiceAuthTokenDeprecatedResponse> RetrieveServiceAuthTokenDeprecated(Guid? guid)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = string.Format(CultureInfo.InvariantCulture, "/v2/service_auth_tokens/{0}", guid);
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Get;
            client.Headers.Add(await BuildAuthenticationHeader());
            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializeJson<RetrieveServiceAuthTokenDeprecatedResponse>(await response.ReadContentAsStringAsync());
        }

        /// <summary>
        /// Filtering the result set by provider (deprecated)
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/195/serviceauthtokens__deprecated_/filtering_the_result_set_by_provider_(deprecated).html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<FilterResultSetByProviderDeprecatedResponse>> FilterResultSetByProviderDeprecated()
        {
            return await FilterResultSetByProviderDeprecated(new RequestOptions());
        }

        /// <summary>
        /// Filtering the result set by provider (deprecated)
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/195/serviceauthtokens__deprecated_/filtering_the_result_set_by_provider_(deprecated).html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<FilterResultSetByProviderDeprecatedResponse>> FilterResultSetByProviderDeprecated(RequestOptions options)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = "/v2/service_auth_tokens";
            uriBuilder.Query = options.ToString();
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Get;
            client.Headers.Add(await BuildAuthenticationHeader());
            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializePage<FilterResultSetByProviderDeprecatedResponse>(await response.ReadContentAsStringAsync());
        }
    }
}