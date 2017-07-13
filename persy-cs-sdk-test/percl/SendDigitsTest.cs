﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using com.persephony.percl;

namespace persy_cs_sdk_test.percl
{
    [TestClass]
    public class SendDigitsTest
    {
        [TestMethod]
        public void DefaultSendDigitsToJsonTest()
        {
            SendDigits sendDigits = new SendDigits();

            string json = sendDigits.toJson();

            Assert.IsNotNull(json);
            Assert.AreEqual(json, "{\"SendDigits\":{\"digits\":\"\"}}");
        }

        [TestMethod]
        public void SendDigitsToJsonTest()
        {
            SendDigits sendDigits = new SendDigits();
            sendDigits.setDigits("12{2}34{4}#");
            sendDigits.setPauseMs(1000);

            string json = sendDigits.toJson();

            Assert.IsNotNull(json);
            Assert.AreEqual(json, "{\"SendDigits\":{\"digits\":\"12{2}34{4}#\",\"pauseMs\":1000}}");
        }
    }
}
