﻿using JohnsonControls.Metasys.BasicServices;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;

namespace MetasysServices.Tests
{
    /// <summary>
    /// Tests for Alarms.
    /// </summary>
    public class MetasysClientObjectAlarmsTests : MetasysClientTestsBase
    {        
       
        [Test]
        public void TestGetObjectAlarmsNone()
        {
            var response = @"{
            ""total"": 0,
            ""next"": null,
            ""previous"": null,
            ""items"": [],
            ""self"": ""https://hostname/api/v2/alarms?pageSize=100&excludePending=false&excludeAcknowledged=false&excludeDiscarded=false&page=1&sort=creationTime""
            ";
            httpTest.RespondWith(response);
            var alarms = client.Alarms.GetForObject(mockid,new AlarmFilter { }); // No filter
            httpTest.ShouldHaveCalled($"https://hostname/api/v2/objects/{mockid}/alarms")
                .WithVerb(HttpMethod.Get)
                .Times(1);
            Assert.AreEqual(0, alarms.Items.Count());
        }

        [Test]
        public void TestGetObjectAlarmsOnePage()
        {
            var response = @"{
            ""total"": 1,
            ""next"": null,
            ""previous"": null,
            ""items"": [" + Alarm + @"],
            ""self"": ""https://hostname/api/v2/alarms?pageSize=100&excludePending=false&excludeAcknowledged=false&excludeDiscarded=false&page=1&sort=creationTime""
            ";
            httpTest.RespondWith(response);

            var alarms = client.Alarms.GetForObject(mockid, AlarmFilter);
            httpTest.ShouldHaveCalled($"https://hostname/api/v2/objects/{mockid}/alarms")
                .WithVerb(HttpMethod.Get)
                .Times(1);
            var expected = JsonConvert.DeserializeObject<Alarm>(Alarm);
            Assert.AreEqual(expected, alarms.Items.ElementAt(0));
        }

        [Test]
        public void TestGetObjectAlarmsManyPages()
        {
            var response = @"{
            ""total"": 2,
            ""next"": ""https://hostname/api/v2/alarms?pageSize=1&excludePending=false&excludeAcknowledged=false&excludeDiscarded=false&page=2&sort=creationTime"",
            ""previous"": null,
            ""items"": [" + Alarm + @"],
            ""self"": ""https://hostname/api/v2/alarms?pageSize=1&excludePending=false&excludeAcknowledged=false&excludeDiscarded=false&page=1&sort=creationTime""
            ";
            httpTest
             .RespondWith(response);
            var alarms = client.Alarms.GetForObject(mockid, AlarmFilter);
            httpTest.ShouldHaveCalled($"https://hostname/api/v2/objects/{mockid}/alarms")
                .WithVerb(HttpMethod.Get)
                .Times(1);
            var expected = JsonConvert.DeserializeObject<Alarm>(Alarm);
            Assert.AreEqual(expected, alarms.Items.ElementAt(0));
        }

        [Test]
        public void TestGetObjectAlarmsWithType()
        {

            var response = @"{
            ""total"": 1,
            ""next"": ""https://hostname/api/v2/alarms?pageSize=1&excludePending=false&excludeAcknowledged=false&excludeDiscarded=false&page=2&sort=creationTime"",
            ""previous"": null,
            ""items"": [" + Alarm + @"],
            ""self"": ""https://hostname/api/v2/alarms?pageSize=1&excludePending=false&excludeAcknowledged=false&excludeDiscarded=false&page=1&sort=creationTime""
            ";
            httpTest.RespondWith(response);

            var alarms = client.Alarms.GetForObject(mockid, new AlarmFilter { Type = 71 });

            httpTest.ShouldHaveCalled($"https://hostname/api/v2/objects/{mockid}/alarms")
                .WithVerb(HttpMethod.Get)
                .Times(1);
            var expected = JsonConvert.DeserializeObject<Alarm>(Alarm);
            Assert.AreEqual(expected, alarms.Items.ElementAt(0));
        }

        
        [Test]
        public void TestGetObjectAlarmsMissingItems()
        {
            var response = @"{
            ""total"": 0,
            ""next"": null,
            ""previous"": null,
            ""items"": [{}],
            ""self"": ""https://hostname/api/v2/alarms?pageSize=1&excludePending=false&excludeAcknowledged=false&excludeDiscarded=false&page=1&sort=creationTime""
            ";
            httpTest.RespondWith(response);
            Assert.Throws<MetasysObjectException>(()=>client.Alarms.GetForObject(mockid, new AlarmFilter { }));
            httpTest.ShouldHaveCalled($"https://hostname/api/v2/objects/{mockid}/alarms")
                .WithVerb(HttpMethod.Get)
                .Times(1);          
        }

        [Test]
        public void TestObjectAlarmMissingValuesThrowsException()
        {
            string alarm= string.Concat("{",
                "\"id\": \"", mockid, "\",",
                "\"typeUrl\": \"https://hostname/api/v2/enumSets/1766/members/3\"}");
            var response = @"{
            ""total"": 1,
            ""next"": null,
            ""previous"": null,
            ""items"": [" + alarm + @"],
            ""self"": ""https://hostname/api/v2/alarms?pageSize=100&excludePending=false&excludeAcknowledged=false&excludeDiscarded=false&page=1&sort=creationTime""
            ";
            httpTest.RespondWith(response);

            var e = Assert.Throws<MetasysObjectException>(() => // To do: Use Specific Exception for Alarm Item Provider
                client.Alarms.GetForObject(mockid, new AlarmFilter { }));

            httpTest.ShouldHaveCalled($"https://hostname/api/v2/objects/{mockid}/alarms")
                .WithVerb(HttpMethod.Get)
                .Times(1);
            PrintMessage($"TestGetSpacesMissingValuesThrowsException: {e.Message}", true);
        }

        [Test]
        public void TestGetObjectAlarmsUnauthorizedThrowsException()
        {
            httpTest.RespondWith("Unauthorized", 401);

            var e = Assert.Throws<MetasysHttpException>(() =>
                client.Alarms.GetForObject(mockid, new AlarmFilter { }));

            httpTest.ShouldHaveCalled($"https://hostname/api/v2/objects/{mockid}/alarms")
                .WithVerb(HttpMethod.Get)
                .Times(1);
            PrintMessage($"TestGetAlarmsUnauthorizedThrowsException: {e.Message}", true);
        }
    }
}
