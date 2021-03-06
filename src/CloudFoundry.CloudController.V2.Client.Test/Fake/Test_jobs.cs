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
    public class JobsEndpoint
{
        [TestMethod]
        public void RetrieveJobThatWasSuccessfulTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""metadata"": {
    ""guid"": ""0"",
    ""created_at"": ""1970-01-01T00:00:00Z"",
    ""url"": ""/v2/jobs/0""
  },
  ""entity"": {
    ""guid"": ""0"",
    ""status"": ""finished""
  }
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)200;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();


                var obj = cfClient.Jobs.RetrieveJobThatWasSuccessful(guid).Result;


                Assert.AreEqual("0", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
                Assert.AreEqual("1970-01-01T00:00:00Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
                Assert.AreEqual("/v2/jobs/0", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
                Assert.AreEqual("0", TestUtil.ToTestableString(obj.Guid), true);
                Assert.AreEqual("finished", TestUtil.ToTestableString(obj.Status), true);

            }
        }

        [TestMethod]
        public void RetrieveJobWithKnownFailureTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""metadata"": {
    ""guid"": ""f7dbf2a6-dd5d-4251-80ba-2a1196d1f5d4"",
    ""created_at"": ""2015-07-28T12:59:14Z"",
    ""url"": ""/v2/jobs/f7dbf2a6-dd5d-4251-80ba-2a1196d1f5d4""
  },
  ""entity"": {
    ""guid"": ""f7dbf2a6-dd5d-4251-80ba-2a1196d1f5d4"",
    ""status"": ""failed"",
    ""error"": ""Use of entity>error is deprecated in favor of entity>error_details."",
    ""error_details"": {
      ""code"": 1001,
      ""description"": ""Request invalid due to parse error: arbitrary string"",
      ""error_code"": ""CF-MessageParseError""
    }
  }
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)200;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();


                var obj = cfClient.Jobs.RetrieveJobWithKnownFailure(guid).Result;


                Assert.AreEqual("f7dbf2a6-dd5d-4251-80ba-2a1196d1f5d4", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
                Assert.AreEqual("2015-07-28T12:59:14Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
                Assert.AreEqual("/v2/jobs/f7dbf2a6-dd5d-4251-80ba-2a1196d1f5d4", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
                Assert.AreEqual("f7dbf2a6-dd5d-4251-80ba-2a1196d1f5d4", TestUtil.ToTestableString(obj.Guid), true);
                Assert.AreEqual("failed", TestUtil.ToTestableString(obj.Status), true);
                Assert.AreEqual("Use of entity>error is deprecated in favor of entity>error_details.", TestUtil.ToTestableString(obj.Error), true);

            }
        }

        [TestMethod]
        public void RetrieveJobThatIsQueuedTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""metadata"": {
    ""guid"": ""06eb2831-a513-449a-9fea-b6b0c4700a67"",
    ""created_at"": ""2015-07-28T12:59:14Z"",
    ""url"": ""/v2/jobs/06eb2831-a513-449a-9fea-b6b0c4700a67""
  },
  ""entity"": {
    ""guid"": ""06eb2831-a513-449a-9fea-b6b0c4700a67"",
    ""status"": ""queued""
  }
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)200;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();


                var obj = cfClient.Jobs.RetrieveJobThatIsQueued(guid).Result;


                Assert.AreEqual("06eb2831-a513-449a-9fea-b6b0c4700a67", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
                Assert.AreEqual("2015-07-28T12:59:14Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
                Assert.AreEqual("/v2/jobs/06eb2831-a513-449a-9fea-b6b0c4700a67", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
                Assert.AreEqual("06eb2831-a513-449a-9fea-b6b0c4700a67", TestUtil.ToTestableString(obj.Guid), true);
                Assert.AreEqual("queued", TestUtil.ToTestableString(obj.Status), true);

            }
        }

        [TestMethod]
        public void RetrieveJobWithUnknownFailureTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""metadata"": {
    ""guid"": ""b4c5ec5d-dc52-4d3a-83fc-6b48a268d217"",
    ""created_at"": ""2015-07-28T12:59:14Z"",
    ""url"": ""/v2/jobs/b4c5ec5d-dc52-4d3a-83fc-6b48a268d217""
  },
  ""entity"": {
    ""guid"": ""b4c5ec5d-dc52-4d3a-83fc-6b48a268d217"",
    ""status"": ""failed"",
    ""error"": ""Use of entity>error is deprecated in favor of entity>error_details."",
    ""error_details"": {
      ""error_code"": ""UnknownError"",
      ""description"": ""An unknown error occurred."",
      ""code"": 10001
    }
  }
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)200;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();


                var obj = cfClient.Jobs.RetrieveJobWithUnknownFailure(guid).Result;


                Assert.AreEqual("b4c5ec5d-dc52-4d3a-83fc-6b48a268d217", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
                Assert.AreEqual("2015-07-28T12:59:14Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
                Assert.AreEqual("/v2/jobs/b4c5ec5d-dc52-4d3a-83fc-6b48a268d217", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
                Assert.AreEqual("b4c5ec5d-dc52-4d3a-83fc-6b48a268d217", TestUtil.ToTestableString(obj.Guid), true);
                Assert.AreEqual("failed", TestUtil.ToTestableString(obj.Status), true);
                Assert.AreEqual("Use of entity>error is deprecated in favor of entity>error_details.", TestUtil.ToTestableString(obj.Error), true);

            }
        }

    }
}