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
    public partial class UpdateSpaceRequest : CloudFoundry.CloudController.V2.Client.Data.Base.AbstractUpdateSpaceRequest
    {
    }
}

namespace CloudFoundry.CloudController.V2.Client.Data.Base
{
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public abstract class AbstractUpdateSpaceRequest
    {

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name
        {
            get;
            set;
        }

        [JsonProperty("organization_guid", NullValueHandling = NullValueHandling.Ignore)]
        public string OrganizationGuid
        {
            get;
            set;
        }

        [JsonProperty("developer_guids", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic DeveloperGuids
        {
            get;
            set;
        }

        [JsonProperty("manager_guids", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic ManagerGuids
        {
            get;
            set;
        }

        [JsonProperty("auditor_guids", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic AuditorGuids
        {
            get;
            set;
        }

        [JsonProperty("domain_guids", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic DomainGuids
        {
            get;
            set;
        }

        [JsonProperty("security_group_guids", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic SecurityGroupGuids
        {
            get;
            set;
        }
    }
}