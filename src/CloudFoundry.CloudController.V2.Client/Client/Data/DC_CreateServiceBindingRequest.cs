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
    public partial class CreateServiceBindingRequest : CloudFoundry.CloudController.V2.Client.Data.Base.AbstractCreateServiceBindingRequest
    {
    }
}

namespace CloudFoundry.CloudController.V2.Client.Data.Base
{
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public abstract class AbstractCreateServiceBindingRequest
    {

        [JsonProperty("service_instance_guid", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? ServiceInstanceGuid
        {
            get;
            set;
        }

        [JsonProperty("app_guid", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? AppGuid
        {
            get;
            set;
        }

        [JsonProperty("binding_options", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic BindingOptions
        {
            get;
            set;
        }
    }
}