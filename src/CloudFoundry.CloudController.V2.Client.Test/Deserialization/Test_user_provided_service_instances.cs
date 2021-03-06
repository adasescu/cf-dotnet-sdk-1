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

using CloudFoundry.CloudController.V2.Client;
using CloudFoundry.CloudController.V2.Client.Data;
using Microsoft.CSharp;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.CodeDom.Compiler;

namespace CloudFoundry.CloudController.V2.Test.Deserialization
{
    [TestClass]
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public class UserProvidedServiceInstancesTest
    {


        [TestMethod]
        public void TestCreateUserProvidedServiceInstanceResponse()
        {
            string json = @"{
  ""metadata"": {
    ""guid"": ""cc78e76d-51e0-4480-a0a9-e99659347781"",
    ""url"": ""/v2/user_provided_service_instances/cc78e76d-51e0-4480-a0a9-e99659347781"",
    ""created_at"": ""2015-07-28T12:59:05Z"",
    ""updated_at"": null
  },
  ""entity"": {
    ""name"": ""my-user-provided-instance"",
    ""credentials"": {
      ""somekey"": ""somevalue""
    },
    ""space_guid"": ""d080653a-e55c-453a-b6e1-03d1ed7abfbb"",
    ""type"": ""user_provided_service_instance"",
    ""syslog_drain_url"": ""syslog://example.com"",
    ""space_url"": ""/v2/spaces/d080653a-e55c-453a-b6e1-03d1ed7abfbb"",
    ""service_bindings_url"": ""/v2/user_provided_service_instances/cc78e76d-51e0-4480-a0a9-e99659347781/service_bindings""
  }
}";

            CreateUserProvidedServiceInstanceResponse obj = Utilities.DeserializeJson<CreateUserProvidedServiceInstanceResponse>(json);

            Assert.AreEqual("cc78e76d-51e0-4480-a0a9-e99659347781", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/user_provided_service_instances/cc78e76d-51e0-4480-a0a9-e99659347781", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
            Assert.AreEqual("2015-07-28T12:59:05Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("my-user-provided-instance", TestUtil.ToTestableString(obj.Name), true);
            Assert.AreEqual("d080653a-e55c-453a-b6e1-03d1ed7abfbb", TestUtil.ToTestableString(obj.SpaceGuid), true);
            Assert.AreEqual("user_provided_service_instance", TestUtil.ToTestableString(obj.Type), true);
            Assert.AreEqual("syslog://example.com", TestUtil.ToTestableString(obj.SyslogDrainUrl), true);
            Assert.AreEqual("/v2/spaces/d080653a-e55c-453a-b6e1-03d1ed7abfbb", TestUtil.ToTestableString(obj.SpaceUrl), true);
            Assert.AreEqual("/v2/user_provided_service_instances/cc78e76d-51e0-4480-a0a9-e99659347781/service_bindings", TestUtil.ToTestableString(obj.ServiceBindingsUrl), true);
        }

        [TestMethod]
        public void TestRetrieveUserProvidedServiceInstanceResponse()
        {
            string json = @"{
  ""metadata"": {
    ""guid"": ""8b79770e-4ded-42c6-b49d-6dcf2373aab2"",
    ""url"": ""/v2/user_provided_service_instances/8b79770e-4ded-42c6-b49d-6dcf2373aab2"",
    ""created_at"": ""2015-07-28T12:59:05Z"",
    ""updated_at"": null
  },
  ""entity"": {
    ""name"": ""name-1176"",
    ""credentials"": {
      ""creds-key-286"": ""creds-val-286""
    },
    ""space_guid"": ""9a726c1c-3e01-47f8-bb77-475e41758bf0"",
    ""type"": ""user_provided_service_instance"",
    ""syslog_drain_url"": ""https://foo.com/url-61"",
    ""space_url"": ""/v2/spaces/9a726c1c-3e01-47f8-bb77-475e41758bf0"",
    ""service_bindings_url"": ""/v2/user_provided_service_instances/8b79770e-4ded-42c6-b49d-6dcf2373aab2/service_bindings""
  }
}";

            RetrieveUserProvidedServiceInstanceResponse obj = Utilities.DeserializeJson<RetrieveUserProvidedServiceInstanceResponse>(json);

            Assert.AreEqual("8b79770e-4ded-42c6-b49d-6dcf2373aab2", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/user_provided_service_instances/8b79770e-4ded-42c6-b49d-6dcf2373aab2", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
            Assert.AreEqual("2015-07-28T12:59:05Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("name-1176", TestUtil.ToTestableString(obj.Name), true);
            Assert.AreEqual("9a726c1c-3e01-47f8-bb77-475e41758bf0", TestUtil.ToTestableString(obj.SpaceGuid), true);
            Assert.AreEqual("user_provided_service_instance", TestUtil.ToTestableString(obj.Type), true);
            Assert.AreEqual("https://foo.com/url-61", TestUtil.ToTestableString(obj.SyslogDrainUrl), true);
            Assert.AreEqual("/v2/spaces/9a726c1c-3e01-47f8-bb77-475e41758bf0", TestUtil.ToTestableString(obj.SpaceUrl), true);
            Assert.AreEqual("/v2/user_provided_service_instances/8b79770e-4ded-42c6-b49d-6dcf2373aab2/service_bindings", TestUtil.ToTestableString(obj.ServiceBindingsUrl), true);
        }

        [TestMethod]
        public void TestListAllServiceBindingsForUserProvidedServiceInstanceResponse()
        {
            string json = @"{
  ""total_results"": 1,
  ""total_pages"": 1,
  ""prev_url"": null,
  ""next_url"": null,
  ""resources"": [
    {
      ""metadata"": {
        ""guid"": ""587ba3ad-db66-47a5-ae2b-405c334fa485"",
        ""url"": ""/v2/service_bindings/587ba3ad-db66-47a5-ae2b-405c334fa485"",
        ""created_at"": ""2015-07-28T12:59:05Z"",
        ""updated_at"": null
      },
      ""entity"": {
        ""app_guid"": ""17d7a423-c3d1-4400-8312-389539b03d3f"",
        ""service_instance_guid"": ""af520b73-292d-49b7-b114-f116b6f2fd8d"",
        ""credentials"": {
          ""creds-key-283"": ""creds-val-283""
        },
        ""binding_options"": {

        },
        ""gateway_data"": null,
        ""gateway_name"": """",
        ""syslog_drain_url"": null,
        ""app_url"": ""/v2/apps/17d7a423-c3d1-4400-8312-389539b03d3f"",
        ""service_instance_url"": ""/v2/user_provided_service_instances/af520b73-292d-49b7-b114-f116b6f2fd8d""
      }
    }
  ]
}";

            PagedResponseCollection<ListAllServiceBindingsForUserProvidedServiceInstanceResponse> page = Utilities.DeserializePage<ListAllServiceBindingsForUserProvidedServiceInstanceResponse>(json, null);

            Assert.AreEqual("1", TestUtil.ToTestableString(page.Properties.TotalResults), true);
            Assert.AreEqual("1", TestUtil.ToTestableString(page.Properties.TotalPages), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page.Properties.PreviousUrl), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page.Properties.NextUrl), true);
            Assert.AreEqual("587ba3ad-db66-47a5-ae2b-405c334fa485", TestUtil.ToTestableString(page[0].EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/service_bindings/587ba3ad-db66-47a5-ae2b-405c334fa485", TestUtil.ToTestableString(page[0].EntityMetadata.Url), true);
            Assert.AreEqual("2015-07-28T12:59:05Z", TestUtil.ToTestableString(page[0].EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("17d7a423-c3d1-4400-8312-389539b03d3f", TestUtil.ToTestableString(page[0].AppGuid), true);
            Assert.AreEqual("af520b73-292d-49b7-b114-f116b6f2fd8d", TestUtil.ToTestableString(page[0].ServiceInstanceGuid), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].GatewayData), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].GatewayName), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].SyslogDrainUrl), true);
            Assert.AreEqual("/v2/apps/17d7a423-c3d1-4400-8312-389539b03d3f", TestUtil.ToTestableString(page[0].AppUrl), true);
            Assert.AreEqual("/v2/user_provided_service_instances/af520b73-292d-49b7-b114-f116b6f2fd8d", TestUtil.ToTestableString(page[0].ServiceInstanceUrl), true);
        }

        [TestMethod]
        public void TestListAllUserProvidedServiceInstancesResponse()
        {
            string json = @"{
  ""total_results"": 1,
  ""total_pages"": 1,
  ""prev_url"": null,
  ""next_url"": null,
  ""resources"": [
    {
      ""metadata"": {
        ""guid"": ""27f23a2e-b334-45a4-90d6-f9bea6a54f82"",
        ""url"": ""/v2/user_provided_service_instances/27f23a2e-b334-45a4-90d6-f9bea6a54f82"",
        ""created_at"": ""2015-07-28T12:59:05Z"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""name-1184"",
        ""credentials"": {
          ""creds-key-292"": ""creds-val-292""
        },
        ""space_guid"": ""80b434c2-0164-42f9-8c80-11af24aced17"",
        ""type"": ""user_provided_service_instance"",
        ""syslog_drain_url"": ""https://foo.com/url-63"",
        ""space_url"": ""/v2/spaces/80b434c2-0164-42f9-8c80-11af24aced17"",
        ""service_bindings_url"": ""/v2/user_provided_service_instances/27f23a2e-b334-45a4-90d6-f9bea6a54f82/service_bindings""
      }
    }
  ]
}";

            PagedResponseCollection<ListAllUserProvidedServiceInstancesResponse> page = Utilities.DeserializePage<ListAllUserProvidedServiceInstancesResponse>(json, null);

            Assert.AreEqual("1", TestUtil.ToTestableString(page.Properties.TotalResults), true);
            Assert.AreEqual("1", TestUtil.ToTestableString(page.Properties.TotalPages), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page.Properties.PreviousUrl), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page.Properties.NextUrl), true);
            Assert.AreEqual("27f23a2e-b334-45a4-90d6-f9bea6a54f82", TestUtil.ToTestableString(page[0].EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/user_provided_service_instances/27f23a2e-b334-45a4-90d6-f9bea6a54f82", TestUtil.ToTestableString(page[0].EntityMetadata.Url), true);
            Assert.AreEqual("2015-07-28T12:59:05Z", TestUtil.ToTestableString(page[0].EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("name-1184", TestUtil.ToTestableString(page[0].Name), true);
            Assert.AreEqual("80b434c2-0164-42f9-8c80-11af24aced17", TestUtil.ToTestableString(page[0].SpaceGuid), true);
            Assert.AreEqual("user_provided_service_instance", TestUtil.ToTestableString(page[0].Type), true);
            Assert.AreEqual("https://foo.com/url-63", TestUtil.ToTestableString(page[0].SyslogDrainUrl), true);
            Assert.AreEqual("/v2/spaces/80b434c2-0164-42f9-8c80-11af24aced17", TestUtil.ToTestableString(page[0].SpaceUrl), true);
            Assert.AreEqual("/v2/user_provided_service_instances/27f23a2e-b334-45a4-90d6-f9bea6a54f82/service_bindings", TestUtil.ToTestableString(page[0].ServiceBindingsUrl), true);
        }

        [TestMethod]
        public void TestUpdateUserProvidedServiceInstanceResponse()
        {
            string json = @"{
  ""metadata"": {
    ""guid"": ""ca45503e-37af-47aa-af0d-ae66cd398b2e"",
    ""url"": ""/v2/user_provided_service_instances/ca45503e-37af-47aa-af0d-ae66cd398b2e"",
    ""created_at"": ""2015-07-28T12:59:05Z"",
    ""updated_at"": ""2015-07-28T12:59:05Z""
  },
  ""entity"": {
    ""name"": ""name-1195"",
    ""credentials"": {
      ""somekey"": ""somenewvalue""
    },
    ""space_guid"": ""0244b1ff-c4cb-4917-92ce-9260a5d2ccfb"",
    ""type"": ""user_provided_service_instance"",
    ""syslog_drain_url"": ""https://foo.com/url-65"",
    ""space_url"": ""/v2/spaces/0244b1ff-c4cb-4917-92ce-9260a5d2ccfb"",
    ""service_bindings_url"": ""/v2/user_provided_service_instances/ca45503e-37af-47aa-af0d-ae66cd398b2e/service_bindings""
  }
}";

            UpdateUserProvidedServiceInstanceResponse obj = Utilities.DeserializeJson<UpdateUserProvidedServiceInstanceResponse>(json);

            Assert.AreEqual("ca45503e-37af-47aa-af0d-ae66cd398b2e", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/user_provided_service_instances/ca45503e-37af-47aa-af0d-ae66cd398b2e", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
            Assert.AreEqual("2015-07-28T12:59:05Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
            Assert.AreEqual("2015-07-28T12:59:05Z", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("name-1195", TestUtil.ToTestableString(obj.Name), true);
            Assert.AreEqual("0244b1ff-c4cb-4917-92ce-9260a5d2ccfb", TestUtil.ToTestableString(obj.SpaceGuid), true);
            Assert.AreEqual("user_provided_service_instance", TestUtil.ToTestableString(obj.Type), true);
            Assert.AreEqual("https://foo.com/url-65", TestUtil.ToTestableString(obj.SyslogDrainUrl), true);
            Assert.AreEqual("/v2/spaces/0244b1ff-c4cb-4917-92ce-9260a5d2ccfb", TestUtil.ToTestableString(obj.SpaceUrl), true);
            Assert.AreEqual("/v2/user_provided_service_instances/ca45503e-37af-47aa-af0d-ae66cd398b2e/service_bindings", TestUtil.ToTestableString(obj.ServiceBindingsUrl), true);
        }
    }
}
