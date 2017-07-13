﻿using com.persephony.api;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Text;

namespace com.persephony.percl
{
    /// <summary>
    /// AddToConference PerCL command.
    /// </summary>
    [JsonObject]
    public sealed class AddToConference : PerCLCommand
    {
        [JsonProperty(PropertyName = "conferenceId")]
        private string conferenceId = string.Empty;

        [JsonProperty(PropertyName = "callId")]
        private string callId = string.Empty;

        [JsonProperty(PropertyName = "startConfOnEnter")]
        private EBool startConfOnEnter = EBool.NONE;

        [JsonProperty(PropertyName = "talk")]
        private EBool talk = EBool.NONE;

        [JsonProperty(PropertyName = "listen")]
        private EBool listen = EBool.NONE;

        [JsonProperty(PropertyName = "leaveConferenceUrl")]
        private string leaveConferenceUrl = string.Empty;

        [JsonProperty(PropertyName = "notificationUrl")]
        private string notificationUrl = string.Empty;

        /// <summary>
        /// Helper method to build a JSON string from a AddToConference instance.
        /// </summary>
        /// <returns>A JSON string equivalent to the AddToConference instance.</returns>
        /// <exception cref="PersyJSONException">Thrown upon deserialize failure.</exception>
        public override string toJson()
        {
            try
            {
                JsonSerializer jsonSerializer = JsonSerializer.Create();
                jsonSerializer.NullValueHandling = NullValueHandling.Ignore;

                StringBuilder strb = new StringBuilder();
                jsonSerializer.Serialize(new StringWriter(strb), toKvp());

                return strb.ToString();
            }
            catch (Exception e)
            {
                throw new PersyJSONException(e.Message);
            }
        }

        /// <summary>
        /// Creates AddToConference PerCL with require fields. 
        /// </summary>
        /// <param name="conferenceId">Conference Id.</param>
        /// <param name="callId">Call Id.</param>
        public AddToConference(string conferenceId,
                               string callId)
        {
            this.conferenceId = conferenceId;
            this.callId = callId;
        }

        /// <summary>
        /// Retrieve the conferenceId value.
        /// </summary>
        /// <returns>The conferenceId value of the object.</returns>
        public string getConferenceId { get { return this.conferenceId; } }

        /// <summary>
        /// Set the conferenceId value.
        /// </summary>
        /// <param name="val">conferenceId value.</param>
        public void setConferenceId(string val) { this.conferenceId = val; }

        /// <summary>
        /// Retrieve the callId value.
        /// </summary>
        /// <returns>The callId value of the object.</returns>
        public string getCallId { get { return this.callId; } }

        /// <summary>
        /// Set the callId value.
        /// </summary>
        /// <param name="val">callId value.</param>
        public void setCallId(string val) { this.callId = val; }

        /// <summary>
        /// Retrieve the startConfOnEnter value.
        /// </summary>
        /// <returns>The startConfOnEnter value of the object.</returns>
        /// <see cref="EBool">Bool enumeration.</see>
        public EBool getStartConfOnEnter { get { return this.startConfOnEnter; } }

        /// <summary>
        /// Set the startConfOnEnter value.
        /// </summary>
        /// <param name="val">startConfOnEnter value.</param>
        /// <see cref="EBool">Bool enumeration.</see>
        public void setStartConfOnEnter(EBool val) { this.startConfOnEnter = val; }

        /// <summary>
        /// Retrieve the talk value.
        /// </summary>
        /// <returns>The talk value of the object.</returns>
        /// <see cref="EBool">Bool enumeration.</see>
        public EBool getTalk { get { return this.talk; } }

        /// <summary>
        /// Set the talk value.
        /// </summary>
        /// <param name="val">talk value.</param>
        /// <see cref="EBool">Bool enumeration.</see>
        public void setTalk(EBool val) { this.talk = val; }

        /// <summary>
        /// Retrieve the listen value.
        /// </summary>
        /// <returns>The listen value of the object.</returns>
        /// <see cref="EBool">Bool enumeration.</see>
        public EBool getListen { get { return this.listen; } }

        /// <summary>
        /// Set the listen value.
        /// </summary>
        /// <param name="val">listen value.</param>
        /// <see cref="EBool">Bool enumeration.</see>
        public void setListen(EBool val) { this.listen = val; }

        /// <summary>
        /// Retrieve the leaveConferenceUrl value.
        /// </summary>
        /// <returns>The leaveConferenceUrl value of the object.</returns>
        public string getLeaveConferenceUrl { get { return this.leaveConferenceUrl; } }

        /// <summary>
        /// Set the leaveConferenceUrl value.
        /// </summary>
        /// <param name="val">leaveConferenceUrl value.</param>
        public void setLeaveConferenceUrl(string val) { this.leaveConferenceUrl = val; }

        /// <summary>
        /// Retrieve the notificationUrl value.
        /// </summary>
        /// <returns>The notificationUrl value of the object.</returns>
        public string getNotificationUrl { get { return this.notificationUrl; } }

        /// <summary>
        /// Set the notificationUrl value.
        /// </summary>
        /// <param name="val">notificationUrl value.</param>
        public void setNotificationUrl(string val) { this.notificationUrl = val; }

        /// <summary>
        /// Retrieve the KVP Dictionary for the AddToConference instance. 
        /// </summary>
        /// <returns>KVP Dictionary</returns>
        /// <exception cref="PersyJSONException">Thrown upon deserialize failure.</exception>
        public override IDictionary<string, object> toKvp()
        {
            // change all properties with settings to a dictionary
            IDictionary<string, object> props = new Dictionary<string, object>();

            if (this.conferenceId == string.Empty)
            {
                throw new PersyJSONException("conferenceId is a required parameter");
            }
            props.Add("conferenceId", this.conferenceId);

            if (this.callId == string.Empty)
            {
                throw new PersyJSONException("callId is a required parameter");
            }
            props.Add("callId", this.callId);

            if (this.startConfOnEnter == EBool.NONE)
            {
                EnumMemberAttribute attr = EnumHelper.GetAttributeOfType<EnumMemberAttribute>(EBool.True);
                props.Add("startConfOnEnter", bool.Parse(attr.Value));
            }
            else
            {
                EnumMemberAttribute attr = EnumHelper.GetAttributeOfType<EnumMemberAttribute>(this.startConfOnEnter);
                props.Add("startConfOnEnter", bool.Parse(attr.Value));
            }

            if (this.talk == EBool.NONE)
            {
                EnumMemberAttribute attr = EnumHelper.GetAttributeOfType<EnumMemberAttribute>(EBool.True);
                props.Add("talk", bool.Parse(attr.Value));
            }
            else
            {
                EnumMemberAttribute attr = EnumHelper.GetAttributeOfType<EnumMemberAttribute>(this.talk);
                props.Add("talk", bool.Parse(attr.Value));
            }

            if (this.listen == EBool.NONE)
            {
                EnumMemberAttribute attr = EnumHelper.GetAttributeOfType<EnumMemberAttribute>(EBool.True);
                props.Add("listen", bool.Parse(attr.Value));
            }
            else
            {
                EnumMemberAttribute attr = EnumHelper.GetAttributeOfType<EnumMemberAttribute>(this.listen);
                props.Add("listen", bool.Parse(attr.Value));
            }

            if (this.leaveConferenceUrl == string.Empty)
            {
                props.Add("leaveConferenceUrl", null);
            }
            else
            {
                props.Add("leaveConferenceUrl", this.leaveConferenceUrl);
            }

            if (this.notificationUrl == string.Empty)
            {
                props.Add("notificationUrl", null);
            }
            else
            {
                props.Add("notificationUrl", this.notificationUrl);
            }

            IDictionary<string, object> command = new Dictionary<string, object>();
            command.Add("AddToConference", props);

            return command;
        }
    }
}
