﻿using com.persephony.api;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace com.persephony.api.application
{
    /// <summary>
    /// Represents a paginated list of Persephony Application instances. This object will
    /// be automatically created by ApplicationsRequester.
    /// </summary>
    public sealed class ApplicationList : PersyList
    {
        /// <summary>
        /// Creates a new ApplicationList.
        /// </summary>
        /// <param name="accountId">The accountId to use in requests for subsequent pages.</param>
        /// <param name="authToken">The authToken to use in requests for subsequent pages.</param>
        /// <param name="rawPage">The raw JSON string representing a page of a applications list from the Persephony API.</param>
        public ApplicationList(string accountId, string authToken, string rawPage) : base(accountId, authToken, rawPage, "applications")
        { }

        /// <summary>
        /// Used by ApplicationList to create Application objects from the JSON list.
        /// </summary>
        /// <param name="element">A JSON string representing a Persephony application instance.</param>
        /// <returns>A equivalent application object to the one represented by the inputted JSON string.</returns>
        protected override IPersyCommon constructElement(string element)
        {
            return JsonConvert.DeserializeObject<Application>(element);
        }
    }
}