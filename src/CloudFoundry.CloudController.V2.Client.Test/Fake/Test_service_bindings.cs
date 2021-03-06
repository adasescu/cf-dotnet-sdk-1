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

using CloudFoundry.CloudController.V2.Client.Data;
using Microsoft.QualityTools.Testing.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.CodeDom.Compiler;
using System.Net;
using System.Threading.Tasks;

namespace CloudFoundry.CloudController.V2.Client.Test.Fake
{
    [TestClass]
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public class ServiceBindingsEndpoint
{
        [TestMethod]
        public void RetrieveServiceBindingTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""metadata"": {
    ""guid"": ""1f7ddefc-cc3d-4ebd-ac7d-86ff9a2a72f7"",
    ""url"": ""/v2/service_bindings/1f7ddefc-cc3d-4ebd-ac7d-86ff9a2a72f7"",
    ""created_at"": ""2015-07-28T12:59:04Z"",
    ""updated_at"": null
  },
  ""entity"": {
    ""app_guid"": ""a1071add-346d-4334-a751-8b1854a50067"",
    ""service_instance_guid"": ""2c99bd7c-116a-45cb-99d1-2edf84449611"",
    ""credentials"": {
      ""creds-key-233"": ""creds-val-233""
    },
    ""binding_options"": {

    },
    ""gateway_data"": null,
    ""gateway_name"": """",
    ""syslog_drain_url"": null,
    ""app_url"": ""/v2/apps/a1071add-346d-4334-a751-8b1854a50067"",
    ""service_instance_url"": ""/v2/service_instances/2c99bd7c-116a-45cb-99d1-2edf84449611""
  }
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)200;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();


                var obj = cfClient.ServiceBindings.RetrieveServiceBinding(guid).Result;


                Assert.AreEqual("1f7ddefc-cc3d-4ebd-ac7d-86ff9a2a72f7", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/service_bindings/1f7ddefc-cc3d-4ebd-ac7d-86ff9a2a72f7", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
                Assert.AreEqual("2015-07-28T12:59:04Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("a1071add-346d-4334-a751-8b1854a50067", TestUtil.ToTestableString(obj.AppGuid), true);
                Assert.AreEqual("2c99bd7c-116a-45cb-99d1-2edf84449611", TestUtil.ToTestableString(obj.ServiceInstanceGuid), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.GatewayData), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.GatewayName), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.SyslogDrainUrl), true);
                Assert.AreEqual("/v2/apps/a1071add-346d-4334-a751-8b1854a50067", TestUtil.ToTestableString(obj.AppUrl), true);
                Assert.AreEqual("/v2/service_instances/2c99bd7c-116a-45cb-99d1-2edf84449611", TestUtil.ToTestableString(obj.ServiceInstanceUrl), true);

            }
        }

        [TestMethod]
        public void ListAllServiceBindingsTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""total_results"": 1,
  ""total_pages"": 1,
  ""prev_url"": null,
  ""next_url"": null,
  ""resources"": [
    {
      ""metadata"": {
        ""guid"": ""31ee7cda-18e3-47c4-998f-a8e187ac96f4"",
        ""url"": ""/v2/service_bindings/31ee7cda-18e3-47c4-998f-a8e187ac96f4"",
        ""created_at"": ""2015-07-28T12:59:04Z"",
        ""updated_at"": null
      },
      ""entity"": {
        ""app_guid"": ""f7d15bfb-4b5c-4bc8-b7c7-a2ed906852e5"",
        ""service_instance_guid"": ""ccddd2fd-8f4a-46d0-b353-a7c5e7c2d77b"",
        ""credentials"": {
          ""creds-key-246"": ""creds-val-246""
        },
        ""binding_options"": {

        },
        ""gateway_data"": null,
        ""gateway_name"": """",
        ""syslog_drain_url"": null,
        ""app_url"": ""/v2/apps/f7d15bfb-4b5c-4bc8-b7c7-a2ed906852e5"",
        ""service_instance_url"": ""/v2/service_instances/ccddd2fd-8f4a-46d0-b353-a7c5e7c2d77b""
      }
    }
  ]
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)200;
                var cfClient = clients.CreateCloudFoundryClient();


                var obj = cfClient.ServiceBindings.ListAllServiceBindings().Result;

                Assert.AreEqual("1", TestUtil.ToTestableString(obj.Properties.TotalResults), true);
                Assert.AreEqual("1", TestUtil.ToTestableString(obj.Properties.TotalPages), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Properties.PreviousUrl), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Properties.NextUrl), true);
                Assert.AreEqual("31ee7cda-18e3-47c4-998f-a8e187ac96f4", TestUtil.ToTestableString(obj[0].EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/service_bindings/31ee7cda-18e3-47c4-998f-a8e187ac96f4", TestUtil.ToTestableString(obj[0].EntityMetadata.Url), true);
                Assert.AreEqual("2015-07-28T12:59:04Z", TestUtil.ToTestableString(obj[0].EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("f7d15bfb-4b5c-4bc8-b7c7-a2ed906852e5", TestUtil.ToTestableString(obj[0].AppGuid), true);
                Assert.AreEqual("ccddd2fd-8f4a-46d0-b353-a7c5e7c2d77b", TestUtil.ToTestableString(obj[0].ServiceInstanceGuid), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].GatewayData), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].GatewayName), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].SyslogDrainUrl), true);
                Assert.AreEqual("/v2/apps/f7d15bfb-4b5c-4bc8-b7c7-a2ed906852e5", TestUtil.ToTestableString(obj[0].AppUrl), true);
                Assert.AreEqual("/v2/service_instances/ccddd2fd-8f4a-46d0-b353-a7c5e7c2d77b", TestUtil.ToTestableString(obj[0].ServiceInstanceUrl), true);

            }
        }

        [TestMethod]
        public void DeleteServiceBindingTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                clients.ExpectedStatusCode = (HttpStatusCode)204;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();


                cfClient.ServiceBindings.DeleteServiceBinding(guid).Wait();

            }
        }

        [TestMethod]
        public void CreateServiceBindingTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""metadata"": {
    ""guid"": ""7640511c-c6fa-41ad-a35b-abaaef7dd08f"",
    ""url"": ""/v2/service_bindings/7640511c-c6fa-41ad-a35b-abaaef7dd08f"",
    ""created_at"": ""2015-07-28T12:59:04Z"",
    ""updated_at"": null
  },
  ""entity"": {
    ""app_guid"": ""3202e1cf-2a7e-4ff6-aedb-ceaf93d0338c"",
    ""service_instance_guid"": ""2482d618-c553-4d98-88ab-85615e46fcfb"",
    ""credentials"": {
      ""creds-key-243"": ""creds-val-243""
    },
    ""binding_options"": {

    },
    ""gateway_data"": null,
    ""gateway_name"": """",
    ""syslog_drain_url"": null,
    ""app_url"": ""/v2/apps/3202e1cf-2a7e-4ff6-aedb-ceaf93d0338c"",
    ""service_instance_url"": ""/v2/user_provided_service_instances/2482d618-c553-4d98-88ab-85615e46fcfb""
  }
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)201;
                var cfClient = clients.CreateCloudFoundryClient();

                CreateServiceBindingRequest value = new CreateServiceBindingRequest();


                var obj = cfClient.ServiceBindings.CreateServiceBinding(value).Result;


                Assert.AreEqual("7640511c-c6fa-41ad-a35b-abaaef7dd08f", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/service_bindings/7640511c-c6fa-41ad-a35b-abaaef7dd08f", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
                Assert.AreEqual("2015-07-28T12:59:04Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("3202e1cf-2a7e-4ff6-aedb-ceaf93d0338c", TestUtil.ToTestableString(obj.AppGuid), true);
                Assert.AreEqual("2482d618-c553-4d98-88ab-85615e46fcfb", TestUtil.ToTestableString(obj.ServiceInstanceGuid), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.GatewayData), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.GatewayName), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.SyslogDrainUrl), true);
                Assert.AreEqual("/v2/apps/3202e1cf-2a7e-4ff6-aedb-ceaf93d0338c", TestUtil.ToTestableString(obj.AppUrl), true);
                Assert.AreEqual("/v2/user_provided_service_instances/2482d618-c553-4d98-88ab-85615e46fcfb", TestUtil.ToTestableString(obj.ServiceInstanceUrl), true);

            }
        }

    }
}