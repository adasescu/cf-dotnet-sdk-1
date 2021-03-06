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
    public class SecurityGroupsTest
    {


        [TestMethod]
        public void TestRetrieveSecurityGroupResponse()
        {
            string json = @"{
  ""metadata"": {
    ""guid"": ""98f20d3f-ce6e-4c0b-bf57-c1561147e18b"",
    ""url"": ""/v2/security_groups/98f20d3f-ce6e-4c0b-bf57-c1561147e18b"",
    ""created_at"": ""2015-07-28T12:58:58Z"",
    ""updated_at"": null
  },
  ""entity"": {
    ""name"": ""dummy1"",
    ""rules"": [

    ],
    ""running_default"": false,
    ""staging_default"": false,
    ""spaces_url"": ""/v2/security_groups/98f20d3f-ce6e-4c0b-bf57-c1561147e18b/spaces""
  }
}";

            RetrieveSecurityGroupResponse obj = Utilities.DeserializeJson<RetrieveSecurityGroupResponse>(json);

            Assert.AreEqual("98f20d3f-ce6e-4c0b-bf57-c1561147e18b", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/security_groups/98f20d3f-ce6e-4c0b-bf57-c1561147e18b", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
            Assert.AreEqual("2015-07-28T12:58:58Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("dummy1", TestUtil.ToTestableString(obj.Name), true);
            Assert.AreEqual("false", TestUtil.ToTestableString(obj.RunningDefault), true);
            Assert.AreEqual("false", TestUtil.ToTestableString(obj.StagingDefault), true);
            Assert.AreEqual("/v2/security_groups/98f20d3f-ce6e-4c0b-bf57-c1561147e18b/spaces", TestUtil.ToTestableString(obj.SpacesUrl), true);
        }

        [TestMethod]
        public void TestAssociateSpaceWithSecurityGroupResponse()
        {
            string json = @"{
  ""metadata"": {
    ""guid"": ""98f20d3f-ce6e-4c0b-bf57-c1561147e18b"",
    ""url"": ""/v2/security_groups/98f20d3f-ce6e-4c0b-bf57-c1561147e18b"",
    ""created_at"": ""2015-07-28T12:58:58Z"",
    ""updated_at"": null
  },
  ""entity"": {
    ""name"": ""dummy1"",
    ""rules"": [

    ],
    ""running_default"": false,
    ""staging_default"": false,
    ""spaces_url"": ""/v2/security_groups/98f20d3f-ce6e-4c0b-bf57-c1561147e18b/spaces""
  }
}";

            AssociateSpaceWithSecurityGroupResponse obj = Utilities.DeserializeJson<AssociateSpaceWithSecurityGroupResponse>(json);

            Assert.AreEqual("98f20d3f-ce6e-4c0b-bf57-c1561147e18b", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/security_groups/98f20d3f-ce6e-4c0b-bf57-c1561147e18b", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
            Assert.AreEqual("2015-07-28T12:58:58Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("dummy1", TestUtil.ToTestableString(obj.Name), true);
            Assert.AreEqual("false", TestUtil.ToTestableString(obj.RunningDefault), true);
            Assert.AreEqual("false", TestUtil.ToTestableString(obj.StagingDefault), true);
            Assert.AreEqual("/v2/security_groups/98f20d3f-ce6e-4c0b-bf57-c1561147e18b/spaces", TestUtil.ToTestableString(obj.SpacesUrl), true);
        }

        [TestMethod]
        public void TestListAllSpacesForSecurityGroupResponse()
        {
            string json = @"{
  ""total_results"": 1,
  ""total_pages"": 1,
  ""prev_url"": null,
  ""next_url"": null,
  ""resources"": [
    {
      ""metadata"": {
        ""guid"": ""821ad47a-63b1-4541-aef6-4327c6f1f1d0"",
        ""url"": ""/v2/spaces/821ad47a-63b1-4541-aef6-4327c6f1f1d0"",
        ""created_at"": ""2015-07-28T12:59:07Z"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""name-1366"",
        ""organization_guid"": ""68afbaa3-3bcb-41b5-9b22-55d3eeeb6655"",
        ""space_quota_definition_guid"": null,
        ""organization_url"": ""/v2/organizations/68afbaa3-3bcb-41b5-9b22-55d3eeeb6655"",
        ""developers_url"": ""/v2/spaces/821ad47a-63b1-4541-aef6-4327c6f1f1d0/developers"",
        ""managers_url"": ""/v2/spaces/821ad47a-63b1-4541-aef6-4327c6f1f1d0/managers"",
        ""auditors_url"": ""/v2/spaces/821ad47a-63b1-4541-aef6-4327c6f1f1d0/auditors"",
        ""apps_url"": ""/v2/spaces/821ad47a-63b1-4541-aef6-4327c6f1f1d0/apps"",
        ""routes_url"": ""/v2/spaces/821ad47a-63b1-4541-aef6-4327c6f1f1d0/routes"",
        ""domains_url"": ""/v2/spaces/821ad47a-63b1-4541-aef6-4327c6f1f1d0/domains"",
        ""service_instances_url"": ""/v2/spaces/821ad47a-63b1-4541-aef6-4327c6f1f1d0/service_instances"",
        ""app_events_url"": ""/v2/spaces/821ad47a-63b1-4541-aef6-4327c6f1f1d0/app_events"",
        ""events_url"": ""/v2/spaces/821ad47a-63b1-4541-aef6-4327c6f1f1d0/events"",
        ""security_groups_url"": ""/v2/spaces/821ad47a-63b1-4541-aef6-4327c6f1f1d0/security_groups""
      }
    }
  ]
}";

            PagedResponseCollection<ListAllSpacesForSecurityGroupResponse> page = Utilities.DeserializePage<ListAllSpacesForSecurityGroupResponse>(json, null);

            Assert.AreEqual("1", TestUtil.ToTestableString(page.Properties.TotalResults), true);
            Assert.AreEqual("1", TestUtil.ToTestableString(page.Properties.TotalPages), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page.Properties.PreviousUrl), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page.Properties.NextUrl), true);
            Assert.AreEqual("821ad47a-63b1-4541-aef6-4327c6f1f1d0", TestUtil.ToTestableString(page[0].EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/spaces/821ad47a-63b1-4541-aef6-4327c6f1f1d0", TestUtil.ToTestableString(page[0].EntityMetadata.Url), true);
            Assert.AreEqual("2015-07-28T12:59:07Z", TestUtil.ToTestableString(page[0].EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("name-1366", TestUtil.ToTestableString(page[0].Name), true);
            Assert.AreEqual("68afbaa3-3bcb-41b5-9b22-55d3eeeb6655", TestUtil.ToTestableString(page[0].OrganizationGuid), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].SpaceQuotaDefinitionGuid), true);
            Assert.AreEqual("/v2/organizations/68afbaa3-3bcb-41b5-9b22-55d3eeeb6655", TestUtil.ToTestableString(page[0].OrganizationUrl), true);
            Assert.AreEqual("/v2/spaces/821ad47a-63b1-4541-aef6-4327c6f1f1d0/developers", TestUtil.ToTestableString(page[0].DevelopersUrl), true);
            Assert.AreEqual("/v2/spaces/821ad47a-63b1-4541-aef6-4327c6f1f1d0/managers", TestUtil.ToTestableString(page[0].ManagersUrl), true);
            Assert.AreEqual("/v2/spaces/821ad47a-63b1-4541-aef6-4327c6f1f1d0/auditors", TestUtil.ToTestableString(page[0].AuditorsUrl), true);
            Assert.AreEqual("/v2/spaces/821ad47a-63b1-4541-aef6-4327c6f1f1d0/apps", TestUtil.ToTestableString(page[0].AppsUrl), true);
            Assert.AreEqual("/v2/spaces/821ad47a-63b1-4541-aef6-4327c6f1f1d0/routes", TestUtil.ToTestableString(page[0].RoutesUrl), true);
            Assert.AreEqual("/v2/spaces/821ad47a-63b1-4541-aef6-4327c6f1f1d0/domains", TestUtil.ToTestableString(page[0].DomainsUrl), true);
            Assert.AreEqual("/v2/spaces/821ad47a-63b1-4541-aef6-4327c6f1f1d0/service_instances", TestUtil.ToTestableString(page[0].ServiceInstancesUrl), true);
            Assert.AreEqual("/v2/spaces/821ad47a-63b1-4541-aef6-4327c6f1f1d0/app_events", TestUtil.ToTestableString(page[0].AppEventsUrl), true);
            Assert.AreEqual("/v2/spaces/821ad47a-63b1-4541-aef6-4327c6f1f1d0/events", TestUtil.ToTestableString(page[0].EventsUrl), true);
            Assert.AreEqual("/v2/spaces/821ad47a-63b1-4541-aef6-4327c6f1f1d0/security_groups", TestUtil.ToTestableString(page[0].SecurityGroupsUrl), true);
        }

        [TestMethod]
        public void TestUpdateSecurityGroupResponse()
        {
            string json = @"{
  ""metadata"": {
    ""guid"": ""98f20d3f-ce6e-4c0b-bf57-c1561147e18b"",
    ""url"": ""/v2/security_groups/98f20d3f-ce6e-4c0b-bf57-c1561147e18b"",
    ""created_at"": ""2015-07-28T12:58:58Z"",
    ""updated_at"": ""2015-07-28T12:59:07Z""
  },
  ""entity"": {
    ""name"": ""new_name"",
    ""rules"": [

    ],
    ""running_default"": false,
    ""staging_default"": false,
    ""spaces_url"": ""/v2/security_groups/98f20d3f-ce6e-4c0b-bf57-c1561147e18b/spaces""
  }
}";

            UpdateSecurityGroupResponse obj = Utilities.DeserializeJson<UpdateSecurityGroupResponse>(json);

            Assert.AreEqual("98f20d3f-ce6e-4c0b-bf57-c1561147e18b", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/security_groups/98f20d3f-ce6e-4c0b-bf57-c1561147e18b", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
            Assert.AreEqual("2015-07-28T12:58:58Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
            Assert.AreEqual("2015-07-28T12:59:07Z", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("new_name", TestUtil.ToTestableString(obj.Name), true);
            Assert.AreEqual("false", TestUtil.ToTestableString(obj.RunningDefault), true);
            Assert.AreEqual("false", TestUtil.ToTestableString(obj.StagingDefault), true);
            Assert.AreEqual("/v2/security_groups/98f20d3f-ce6e-4c0b-bf57-c1561147e18b/spaces", TestUtil.ToTestableString(obj.SpacesUrl), true);
        }

        [TestMethod]
        public void TestListAllSecurityGroupsResponse()
        {
            string json = @"{
  ""total_results"": 5,
  ""total_pages"": 1,
  ""prev_url"": null,
  ""next_url"": null,
  ""resources"": [
    {
      ""metadata"": {
        ""guid"": ""98f20d3f-ce6e-4c0b-bf57-c1561147e18b"",
        ""url"": ""/v2/security_groups/98f20d3f-ce6e-4c0b-bf57-c1561147e18b"",
        ""created_at"": ""2015-07-28T12:58:58Z"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""dummy1"",
        ""rules"": [

        ],
        ""running_default"": false,
        ""staging_default"": false,
        ""spaces_url"": ""/v2/security_groups/98f20d3f-ce6e-4c0b-bf57-c1561147e18b/spaces""
      }
    },
    {
      ""metadata"": {
        ""guid"": ""808fcbe5-707d-4422-a73b-cd21a7c278c2"",
        ""url"": ""/v2/security_groups/808fcbe5-707d-4422-a73b-cd21a7c278c2"",
        ""created_at"": ""2015-07-28T12:58:58Z"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""dummy2"",
        ""rules"": [

        ],
        ""running_default"": false,
        ""staging_default"": false,
        ""spaces_url"": ""/v2/security_groups/808fcbe5-707d-4422-a73b-cd21a7c278c2/spaces""
      }
    },
    {
      ""metadata"": {
        ""guid"": ""08900294-71f8-4ee2-868d-3e71d5355a38"",
        ""url"": ""/v2/security_groups/08900294-71f8-4ee2-868d-3e71d5355a38"",
        ""created_at"": ""2015-07-28T12:59:07Z"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""name-1375"",
        ""rules"": [
          {
            ""protocol"": ""udp"",
            ""ports"": ""8080"",
            ""destination"": ""198.41.191.47/1""
          }
        ],
        ""running_default"": false,
        ""staging_default"": false,
        ""spaces_url"": ""/v2/security_groups/08900294-71f8-4ee2-868d-3e71d5355a38/spaces""
      }
    },
    {
      ""metadata"": {
        ""guid"": ""c06364c3-d916-45fa-81b9-4eef2852101e"",
        ""url"": ""/v2/security_groups/c06364c3-d916-45fa-81b9-4eef2852101e"",
        ""created_at"": ""2015-07-28T12:59:07Z"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""name-1376"",
        ""rules"": [
          {
            ""protocol"": ""udp"",
            ""ports"": ""8080"",
            ""destination"": ""198.41.191.47/1""
          }
        ],
        ""running_default"": false,
        ""staging_default"": false,
        ""spaces_url"": ""/v2/security_groups/c06364c3-d916-45fa-81b9-4eef2852101e/spaces""
      }
    },
    {
      ""metadata"": {
        ""guid"": ""9cba06d2-81da-43c7-93b0-3b502288c33e"",
        ""url"": ""/v2/security_groups/9cba06d2-81da-43c7-93b0-3b502288c33e"",
        ""created_at"": ""2015-07-28T12:59:07Z"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""name-1377"",
        ""rules"": [
          {
            ""protocol"": ""udp"",
            ""ports"": ""8080"",
            ""destination"": ""198.41.191.47/1""
          }
        ],
        ""running_default"": false,
        ""staging_default"": false,
        ""spaces_url"": ""/v2/security_groups/9cba06d2-81da-43c7-93b0-3b502288c33e/spaces""
      }
    }
  ]
}";

            PagedResponseCollection<ListAllSecurityGroupsResponse> page = Utilities.DeserializePage<ListAllSecurityGroupsResponse>(json, null);

            Assert.AreEqual("5", TestUtil.ToTestableString(page.Properties.TotalResults), true);
            Assert.AreEqual("1", TestUtil.ToTestableString(page.Properties.TotalPages), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page.Properties.PreviousUrl), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page.Properties.NextUrl), true);
            Assert.AreEqual("98f20d3f-ce6e-4c0b-bf57-c1561147e18b", TestUtil.ToTestableString(page[0].EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/security_groups/98f20d3f-ce6e-4c0b-bf57-c1561147e18b", TestUtil.ToTestableString(page[0].EntityMetadata.Url), true);
            Assert.AreEqual("2015-07-28T12:58:58Z", TestUtil.ToTestableString(page[0].EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("dummy1", TestUtil.ToTestableString(page[0].Name), true);
            Assert.AreEqual("false", TestUtil.ToTestableString(page[0].RunningDefault), true);
            Assert.AreEqual("false", TestUtil.ToTestableString(page[0].StagingDefault), true);
            Assert.AreEqual("/v2/security_groups/98f20d3f-ce6e-4c0b-bf57-c1561147e18b/spaces", TestUtil.ToTestableString(page[0].SpacesUrl), true);
            Assert.AreEqual("808fcbe5-707d-4422-a73b-cd21a7c278c2", TestUtil.ToTestableString(page[1].EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/security_groups/808fcbe5-707d-4422-a73b-cd21a7c278c2", TestUtil.ToTestableString(page[1].EntityMetadata.Url), true);
            Assert.AreEqual("2015-07-28T12:58:58Z", TestUtil.ToTestableString(page[1].EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[1].EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("dummy2", TestUtil.ToTestableString(page[1].Name), true);
            Assert.AreEqual("false", TestUtil.ToTestableString(page[1].RunningDefault), true);
            Assert.AreEqual("false", TestUtil.ToTestableString(page[1].StagingDefault), true);
            Assert.AreEqual("/v2/security_groups/808fcbe5-707d-4422-a73b-cd21a7c278c2/spaces", TestUtil.ToTestableString(page[1].SpacesUrl), true);
            Assert.AreEqual("08900294-71f8-4ee2-868d-3e71d5355a38", TestUtil.ToTestableString(page[2].EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/security_groups/08900294-71f8-4ee2-868d-3e71d5355a38", TestUtil.ToTestableString(page[2].EntityMetadata.Url), true);
            Assert.AreEqual("2015-07-28T12:59:07Z", TestUtil.ToTestableString(page[2].EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[2].EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("name-1375", TestUtil.ToTestableString(page[2].Name), true);
            Assert.AreEqual("false", TestUtil.ToTestableString(page[2].RunningDefault), true);
            Assert.AreEqual("false", TestUtil.ToTestableString(page[2].StagingDefault), true);
            Assert.AreEqual("/v2/security_groups/08900294-71f8-4ee2-868d-3e71d5355a38/spaces", TestUtil.ToTestableString(page[2].SpacesUrl), true);
            Assert.AreEqual("c06364c3-d916-45fa-81b9-4eef2852101e", TestUtil.ToTestableString(page[3].EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/security_groups/c06364c3-d916-45fa-81b9-4eef2852101e", TestUtil.ToTestableString(page[3].EntityMetadata.Url), true);
            Assert.AreEqual("2015-07-28T12:59:07Z", TestUtil.ToTestableString(page[3].EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[3].EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("name-1376", TestUtil.ToTestableString(page[3].Name), true);
            Assert.AreEqual("false", TestUtil.ToTestableString(page[3].RunningDefault), true);
            Assert.AreEqual("false", TestUtil.ToTestableString(page[3].StagingDefault), true);
            Assert.AreEqual("/v2/security_groups/c06364c3-d916-45fa-81b9-4eef2852101e/spaces", TestUtil.ToTestableString(page[3].SpacesUrl), true);
            Assert.AreEqual("9cba06d2-81da-43c7-93b0-3b502288c33e", TestUtil.ToTestableString(page[4].EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/security_groups/9cba06d2-81da-43c7-93b0-3b502288c33e", TestUtil.ToTestableString(page[4].EntityMetadata.Url), true);
            Assert.AreEqual("2015-07-28T12:59:07Z", TestUtil.ToTestableString(page[4].EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[4].EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("name-1377", TestUtil.ToTestableString(page[4].Name), true);
            Assert.AreEqual("false", TestUtil.ToTestableString(page[4].RunningDefault), true);
            Assert.AreEqual("false", TestUtil.ToTestableString(page[4].StagingDefault), true);
            Assert.AreEqual("/v2/security_groups/9cba06d2-81da-43c7-93b0-3b502288c33e/spaces", TestUtil.ToTestableString(page[4].SpacesUrl), true);
        }

        [TestMethod]
        public void TestRemoveSpaceFromSecurityGroupResponse()
        {
            string json = @"{
  ""metadata"": {
    ""guid"": ""98f20d3f-ce6e-4c0b-bf57-c1561147e18b"",
    ""url"": ""/v2/security_groups/98f20d3f-ce6e-4c0b-bf57-c1561147e18b"",
    ""created_at"": ""2015-07-28T12:58:58Z"",
    ""updated_at"": null
  },
  ""entity"": {
    ""name"": ""dummy1"",
    ""rules"": [

    ],
    ""running_default"": false,
    ""staging_default"": false,
    ""spaces_url"": ""/v2/security_groups/98f20d3f-ce6e-4c0b-bf57-c1561147e18b/spaces""
  }
}";

            RemoveSpaceFromSecurityGroupResponse obj = Utilities.DeserializeJson<RemoveSpaceFromSecurityGroupResponse>(json);

            Assert.AreEqual("98f20d3f-ce6e-4c0b-bf57-c1561147e18b", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/security_groups/98f20d3f-ce6e-4c0b-bf57-c1561147e18b", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
            Assert.AreEqual("2015-07-28T12:58:58Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("dummy1", TestUtil.ToTestableString(obj.Name), true);
            Assert.AreEqual("false", TestUtil.ToTestableString(obj.RunningDefault), true);
            Assert.AreEqual("false", TestUtil.ToTestableString(obj.StagingDefault), true);
            Assert.AreEqual("/v2/security_groups/98f20d3f-ce6e-4c0b-bf57-c1561147e18b/spaces", TestUtil.ToTestableString(obj.SpacesUrl), true);
        }

        [TestMethod]
        public void TestCreateSecurityGroupResponse()
        {
            string json = @"{
  ""metadata"": {
    ""guid"": ""2d0fd6ca-df52-4469-8ea3-91a27b646c2e"",
    ""url"": ""/v2/security_groups/2d0fd6ca-df52-4469-8ea3-91a27b646c2e"",
    ""created_at"": ""2015-07-28T12:59:07Z"",
    ""updated_at"": null
  },
  ""entity"": {
    ""name"": ""my_super_sec_group"",
    ""rules"": [
      {
        ""protocol"": ""icmp"",
        ""destination"": ""0.0.0.0/0"",
        ""type"": 0,
        ""code"": 1
      },
      {
        ""protocol"": ""tcp"",
        ""destination"": ""0.0.0.0/0"",
        ""ports"": ""2048-3000"",
        ""log"": true
      },
      {
        ""protocol"": ""udp"",
        ""destination"": ""0.0.0.0/0"",
        ""ports"": ""53, 5353""
      },
      {
        ""protocol"": ""all"",
        ""destination"": ""0.0.0.0/0""
      }
    ],
    ""running_default"": false,
    ""staging_default"": false,
    ""spaces_url"": ""/v2/security_groups/2d0fd6ca-df52-4469-8ea3-91a27b646c2e/spaces""
  }
}";

            CreateSecurityGroupResponse obj = Utilities.DeserializeJson<CreateSecurityGroupResponse>(json);

            Assert.AreEqual("2d0fd6ca-df52-4469-8ea3-91a27b646c2e", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/security_groups/2d0fd6ca-df52-4469-8ea3-91a27b646c2e", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
            Assert.AreEqual("2015-07-28T12:59:07Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("my_super_sec_group", TestUtil.ToTestableString(obj.Name), true);
            Assert.AreEqual("false", TestUtil.ToTestableString(obj.RunningDefault), true);
            Assert.AreEqual("false", TestUtil.ToTestableString(obj.StagingDefault), true);
            Assert.AreEqual("/v2/security_groups/2d0fd6ca-df52-4469-8ea3-91a27b646c2e/spaces", TestUtil.ToTestableString(obj.SpacesUrl), true);
        }
    }
}
