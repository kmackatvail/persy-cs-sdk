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
    /// Say PerCL command.
    /// </summary>
    [JsonObject]
    public sealed class Say : PerCLCommand, IGetDigitsNestable, IGetSpeechNestable
    {
        [JsonProperty(PropertyName = "text")]
        private string text = string.Empty;

        [JsonProperty(PropertyName = "language")]
        private ELanguage language = ELanguage.NONE;

        [JsonProperty(PropertyName = "loop")]
        private int loop = int.MinValue;

        [JsonProperty(PropertyName = "conferenceId")]
        private string conferenceId;

        /// <summary>
	    /// Helper method to build a JSON string from a Say instance.
        /// </summary>
        /// <returns>A JSON string equivalent to the Say instance.</returns>
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
        /// Retrieve the text value.
        /// </summary>
        /// <returns>The text value of the object.</returns>
        public string getText { get { return this.text; } }

        /// <summary>
        /// Set the text value.
        /// </summary>
        /// <param name="val">text value.</param>
        public void setText(string val) { this.text = val; }

        /// <summary>
        /// Retrieve the language value.
        /// </summary>
        /// <returns>The language value of the object.</returns>
        /// <see cref="ELanguage">Language enumeration.</see>
        public ELanguage getLanguage { get { return this.language; } }

        /// <summary>
        /// Set the language value.
        /// </summary>
        /// <param name="val">language value.</param>
        /// <see cref="ELanguage">Language enumeration.</see>
        public void setLanguage(ELanguage val) { this.language = val;  }

        /// <summary>
        /// Retrieve the loop value.
        /// </summary>
        /// <returns>The loop value of the object.</returns>
        public int getLoop { get { return this.loop; } }

        /// <summary>
        /// Set the loop value.
        /// </summary>
        /// <param name="val">loop value.</param>
        public void setLoop(int val) { this.loop = val; }

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
        /// Retrieve the KVP Dictionary for the Say instance. 
        /// </summary>
        /// <returns>KVP Dictionary</returns>
        public override IDictionary<string, object> toKvp()
        {
            // change all properties with settings to a dictionary
            IDictionary<string, object> props = new Dictionary<string, object>();

            props.Add("text", getText);

            if (String.IsNullOrEmpty(getConferenceId) == false)
            {
                props.Add("conferenceId", getConferenceId);
            }
            
            if (getLanguage != ELanguage.NONE)
            {
                EnumMemberAttribute attr = EnumHelper.GetAttributeOfType<EnumMemberAttribute>(getLanguage);
                props.Add("language", attr.Value);
            }

            if (getLoop != int.MinValue)
            {
                props.Add("loop", getLoop);
            }

            IDictionary<string, object> command = new Dictionary<string, object>();
            command.Add("Say", props);

            return command;
        }
    }
}
