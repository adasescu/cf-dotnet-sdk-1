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
using System.Net.Http;
using System.Threading.Tasks;


namespace CloudFoundry.CloudController.V2.Client
{
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public partial class JobsEndpoint : CloudFoundry.CloudController.V2.Client.Base.AbstractJobsEndpoint
    {
        public JobsEndpoint(CloudFoundryClient client) : base()
        {
            this.CloudTarget = client.CloudTarget;
            this.CancellationToken = client.CancellationToken;
            this.ServiceLocator = client.ServiceLocator;
            this.Auth = client.Auth;
        }    
    }
}

namespace CloudFoundry.CloudController.V2.Client.Base
{

    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public abstract class AbstractJobsEndpoint : BaseEndpoint
    {

        /// <summary>
        /// Retrieve Job that was successful
        /// </summary>
        public async Task<RetrieveJobThatWasSuccessfulResponse> RetrieveJobThatWasSuccessful(Guid? guid)
        {
            string route = string.Format("/v2/jobs/{0}", guid);
            string endpoint = this.CloudTarget.ToString().TrimEnd('/') + route;
            var client = this.GetHttpClient();
            client.Uri = new Uri(endpoint);
            client.Method = HttpMethod.Get;
            client.Headers.Add(BuildAuthenticationHeader());
            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializeJson<RetrieveJobThatWasSuccessfulResponse>(await response.ReadContentAsStringAsync());
        }

        /// <summary>
        /// Retrieve Job with known failure
        /// </summary>
        public async Task<RetrieveJobWithKnownFailureResponse> RetrieveJobWithKnownFailure(Guid? guid)
        {
            string route = string.Format("/v2/jobs/{0}", guid);
            string endpoint = this.CloudTarget.ToString().TrimEnd('/') + route;
            var client = this.GetHttpClient();
            client.Uri = new Uri(endpoint);
            client.Method = HttpMethod.Get;
            client.Headers.Add(BuildAuthenticationHeader());
            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializeJson<RetrieveJobWithKnownFailureResponse>(await response.ReadContentAsStringAsync());
        }

        /// <summary>
        /// Retrieve Job that is queued
        /// </summary>
        public async Task<RetrieveJobThatIsQueuedResponse> RetrieveJobThatIsQueued(Guid? guid)
        {
            string route = string.Format("/v2/jobs/{0}", guid);
            string endpoint = this.CloudTarget.ToString().TrimEnd('/') + route;
            var client = this.GetHttpClient();
            client.Uri = new Uri(endpoint);
            client.Method = HttpMethod.Get;
            client.Headers.Add(BuildAuthenticationHeader());
            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializeJson<RetrieveJobThatIsQueuedResponse>(await response.ReadContentAsStringAsync());
        }

        /// <summary>
        /// Retrieve Job with unknown failure
        /// </summary>
        public async Task<RetrieveJobWithUnknownFailureResponse> RetrieveJobWithUnknownFailure(Guid? guid)
        {
            string route = string.Format("/v2/jobs/{0}", guid);
            string endpoint = this.CloudTarget.ToString().TrimEnd('/') + route;
            var client = this.GetHttpClient();
            client.Uri = new Uri(endpoint);
            client.Method = HttpMethod.Get;
            client.Headers.Add(BuildAuthenticationHeader());
            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializeJson<RetrieveJobWithUnknownFailureResponse>(await response.ReadContentAsStringAsync());
        }
    }
}