﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using com.persephony.percl;
using com.persephony;

namespace persy_cs_sdk_test.percl
{
    [TestClass]
    public class AddToConferenceTest
    {
        [TestMethod]
        public void AddToConferenceRequiredTest()
        {
            AddToConference addToConference = new AddToConference("CFafa975185bfe5e34bb70b18dfbdb4dfdd74d9a64", "CA0f9381bf1fa2d3df41142fe24d938d7f62c09074");

            string json = addToConference.toJson();

            Assert.IsNotNull(json);
            Assert.AreEqual(json, "{\"AddToConference\":{\"conferenceId\":\"CFafa975185bfe5e34bb70b18dfbdb4dfdd74d9a64\",\"callId\":\"CA0f9381bf1fa2d3df41142fe24d938d7f62c09074\",\"startConfOnEnter\":true,\"talk\":true,\"listen\":true,\"leaveConferenceUrl\":null,\"notificationUrl\":null}}");
        }

        [TestMethod]
        public void AddToConferenceWithLeaveConferenceUrlTest()
        {
            AddToConference addToConference = new AddToConference("CFafa975185bfe5e34bb70b18dfbdb4dfdd74d9a64", "CA0f9381bf1fa2d3df41142fe24d938d7f62c09074");

            addToConference.setLeaveConferenceUrl("http://foo.com/conf");
            string json = addToConference.toJson();

            Assert.IsNotNull(json);
            Assert.AreEqual(json, "{\"AddToConference\":{\"conferenceId\":\"CFafa975185bfe5e34bb70b18dfbdb4dfdd74d9a64\",\"callId\":\"CA0f9381bf1fa2d3df41142fe24d938d7f62c09074\",\"startConfOnEnter\":true,\"talk\":true,\"listen\":true,\"leaveConferenceUrl\":\"http://foo.com/conf\",\"notificationUrl\":null}}");
        }

        [TestMethod]
        public void AddToConferenceRequiredWithNotificationUrlTest()
        {
            AddToConference addToConference = new AddToConference("CFafa975185bfe5e34bb70b18dfbdb4dfdd74d9a64", "CA0f9381bf1fa2d3df41142fe24d938d7f62c09074");

            addToConference.setNotificationUrl("http://foo.com/notif");
            string json = addToConference.toJson();

            Assert.IsNotNull(json);
            Assert.AreEqual(json, "{\"AddToConference\":{\"conferenceId\":\"CFafa975185bfe5e34bb70b18dfbdb4dfdd74d9a64\",\"callId\":\"CA0f9381bf1fa2d3df41142fe24d938d7f62c09074\",\"startConfOnEnter\":true,\"talk\":true,\"listen\":true,\"leaveConferenceUrl\":null,\"notificationUrl\":\"http://foo.com/notif\"}}");
        }

        [TestMethod]
        public void AddToConferenceWithAllTest()
        {
            AddToConference addToConference = new AddToConference("CFafa975185bfe5e34bb70b18dfbdb4dfdd74d9a64", "CA0f9381bf1fa2d3df41142fe24d938d7f62c09074");

            addToConference.setNotificationUrl("http://foo.com/notif");
            addToConference.setLeaveConferenceUrl("http://foo.com/conf");
            addToConference.setListen(EBool.False);
            addToConference.setTalk(EBool.False);
            addToConference.setStartConfOnEnter(EBool.False);
            string json = addToConference.toJson();

            Assert.IsNotNull(json);
            Assert.AreEqual(json, "{\"AddToConference\":{\"conferenceId\":\"CFafa975185bfe5e34bb70b18dfbdb4dfdd74d9a64\",\"callId\":\"CA0f9381bf1fa2d3df41142fe24d938d7f62c09074\",\"startConfOnEnter\":false,\"talk\":false,\"listen\":false,\"leaveConferenceUrl\":\"http://foo.com/conf\",\"notificationUrl\":\"http://foo.com/notif\"}}");
        }
    }
}
