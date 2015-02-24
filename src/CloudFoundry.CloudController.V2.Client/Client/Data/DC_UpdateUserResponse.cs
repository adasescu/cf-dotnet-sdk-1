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
    public partial class UpdateUserResponse : CloudFoundry.CloudController.V2.Client.Data.Base.AbstractUpdateUserResponse
    {
    }
}

namespace CloudFoundry.CloudController.V2.Client.Data.Base
{
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public abstract class AbstractUpdateUserResponse : IResponse
    {
        public Metadata EntityMetadata
        {
            get;
            set;
        }

        [JsonProperty("admin", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic Admin
        {
            get;
            set;
        }

        [JsonProperty("active", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic Active
        {
            get;
            set;
        }

        [JsonProperty("default_space_guid", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? DefaultSpaceGuid
        {
            get;
            set;
        }

        [JsonProperty("default_space_url", NullValueHandling = NullValueHandling.Ignore)]
        public string DefaultSpaceUrl
        {
            get;
            set;
        }

        [JsonProperty("spaces_url", NullValueHandling = NullValueHandling.Ignore)]
        public string SpacesUrl
        {
            get;
            set;
        }

        [JsonProperty("organizations_url", NullValueHandling = NullValueHandling.Ignore)]
        public string OrganizationsUrl
        {
            get;
            set;
        }

        [JsonProperty("managed_organizations_url", NullValueHandling = NullValueHandling.Ignore)]
        public string ManagedOrganizationsUrl
        {
            get;
            set;
        }

        [JsonProperty("billing_managed_organizations_url", NullValueHandling = NullValueHandling.Ignore)]
        public string BillingManagedOrganizationsUrl
        {
            get;
            set;
        }

        [JsonProperty("audited_organizations_url", NullValueHandling = NullValueHandling.Ignore)]
        public string AuditedOrganizationsUrl
        {
            get;
            set;
        }

        [JsonProperty("managed_spaces_url", NullValueHandling = NullValueHandling.Ignore)]
        public string ManagedSpacesUrl
        {
            get;
            set;
        }

        [JsonProperty("audited_spaces_url", NullValueHandling = NullValueHandling.Ignore)]
        public string AuditedSpacesUrl
        {
            get;
            set;
        }
    }
}