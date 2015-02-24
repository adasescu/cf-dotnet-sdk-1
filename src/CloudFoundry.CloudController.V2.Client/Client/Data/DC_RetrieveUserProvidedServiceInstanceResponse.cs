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

using CloudFoundry.CloudController.V2.Interfaces;
using Newtonsoft.Json;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace CloudFoundry.CloudController.V2.Client.Data
{
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public partial class RetrieveUserProvidedServiceInstanceResponse : CloudFoundry.CloudController.V2.Client.Data.Base.AbstractRetrieveUserProvidedServiceInstanceResponse
    {
    }
}

namespace CloudFoundry.CloudController.V2.Client.Data.Base
{
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public abstract class AbstractRetrieveUserProvidedServiceInstanceResponse : IResponse
    {
        public Metadata EntityMetadata
        {
            get;
            set;
        }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name
        {
            get;
            set;
        }

        [JsonProperty("credentials", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, dynamic> Credentials
        {
            get;
            set;
        }

        [JsonProperty("space_guid", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? SpaceGuid
        {
            get;
            set;
        }

        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type
        {
            get;
            set;
        }

        [JsonProperty("syslog_drain_url", NullValueHandling = NullValueHandling.Ignore)]
        public string SyslogDrainUrl
        {
            get;
            set;
        }

        [JsonProperty("space_url", NullValueHandling = NullValueHandling.Ignore)]
        public string SpaceUrl
        {
            get;
            set;
        }

        [JsonProperty("service_bindings_url", NullValueHandling = NullValueHandling.Ignore)]
        public string ServiceBindingsUrl
        {
            get;
            set;
        }
    }
}