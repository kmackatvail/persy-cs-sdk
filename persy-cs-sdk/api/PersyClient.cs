﻿using com.persephony.api.account;
using com.persephony.api.application;
using com.persephony.api.call;
using com.persephony.api.conference;
using com.persephony.api.log;
using com.persephony.api.phonenumber;
using com.persephony.api.queue;
using com.persephony.api.recording;

namespace com.persephony.api
{
    /// <summary>
    /// The PersyClient is the main way within the SDK to interact with the
    /// Persephony API. After creating a PersyClient the user can any of it's many
    /// APIRequesters to make requests to the API.
    /// </summary>
    public class PersyClient
    {
        private readonly string credAccountId;
        private readonly string credAuthToken;
        private readonly string accountId;

        private readonly CallsRequester calls;
        private readonly RecordingsRequester recordings;
        private readonly ConferencesRequester conferences;
        private readonly QueuesRequester queues;
        private readonly ApplicationsRequester applications;
        private readonly LogsRequester logs;
        private readonly AvailablePhoneNumbersRequester availablePhoneNumbers;
        private readonly IncomingPhoneNumbersRequester incomingPhoneNumbers;
        private readonly CallingNumbersRequester callingNumbers;
        private readonly AccountsRequester accounts;

        /// <summary>
        /// This constructor allows one to create a PersyClient that authenticates
        /// with one set of credentials but acts as a second account (i.e. a sub
        /// account).
        /// </summary>
        /// <param name="credAccountId">The Account ID to use in your credentials for the Persephony API.</param>
        /// <param name="credAuthToken">The Auth Token to use in your credentials for the Persephony API. This should be the matching Auth Token to the credAccountId parameter.</param>
        /// <param name="accountId">The Account ID of the account you want to act as. This should either be the same Account ID ass credAccountId or the id of a sub-account to the credAccountId's account.</param>
        /// <exception cref="PersyException">Thrown upon failed request.</exception>
        public PersyClient(string credAccountId, string credAuthToken, string accountId)
        {
		    this.credAccountId = credAccountId;
		    this.credAuthToken = credAuthToken;
		    this.accountId = accountId;

            calls = new CallsRequester(credAccountId, credAuthToken, accountId);
            recordings = new RecordingsRequester(credAccountId, credAuthToken, accountId);
            conferences = new ConferencesRequester(credAccountId, credAuthToken, accountId);
            queues = new QueuesRequester(credAccountId, credAuthToken, accountId);
            applications = new ApplicationsRequester(credAccountId, credAuthToken, accountId);
            logs = new LogsRequester(credAccountId, credAuthToken, accountId);
            availablePhoneNumbers = new AvailablePhoneNumbersRequester(credAccountId, credAuthToken, accountId);
            incomingPhoneNumbers = new IncomingPhoneNumbersRequester(credAccountId, credAuthToken, accountId);
            callingNumbers = new CallingNumbersRequester(credAccountId, credAuthToken, accountId);
            accounts = new AccountsRequester(credAccountId, credAuthToken);
        }

        /// <summary>
        /// This constructor allows one to create a PersyClient that authenticates
        /// with one set of credentials and acts as that account.
        /// </summary>
        /// This Constructor is a shortcut for calling 'PersyClient(credAccountId, credAuthToken, credAccountId)'.
        /// <remarks>
        /// </remarks>
        /// <param name="credAccountId">The Account ID to use in your credentials for the Persephony API.</param>
        /// <param name="credAuthToken">The Auth Token to use in your credentials for the Persephony API. This should be the matching Auth Token to the credAccountId parameter.</param>       
        /// <exception cref="PersyException">Thrown upon failed request.</exception>
        public PersyClient(string credAccountId, string credAuthToken) : this(credAccountId, credAuthToken, credAccountId)
        {}

        /// <summary>
        /// Retrieve  account ID being used to authenticate with the API.
        /// </summary>
        /// <returns>Account ID being used to authenticate with the API.</returns>
        public string getCredAccountId { get { return this.credAccountId; } }

        /// <summary>
        /// Retrieve  Auth Token being used to authenticate with the API.
        /// </summary>
        /// <returns>Auth Token being used to authenticate with the API.</returns>
        public string getCredAuthToken { get { return this.credAuthToken; } }

        /// <summary>
        /// Retrieve  Account ID of the account that this client is acting as.
        /// </summary>
        /// <returns>Account ID of the account that this client is acting as.</returns>
        public string getAccountId { get { return this.accountId; } }

        /// <summary>
        /// Retrieve  CallsRequester object value.
        /// </summary>
        /// <returns>CallsRequester instance.</returns>
        public CallsRequester getCallsRequester { get { return this.calls; } }

        /// <summary>
        /// Retrieve  RecordingsRequester object value.
        /// </summary>
        /// <returns>RecordingsRequester instance.</returns>
        public RecordingsRequester getRecordingsRequester { get { return this.recordings; } }

        /// <summary>
        /// Retrieve  QueuesRequester object value.
        /// </summary>
        /// <returns>QueuesRequester instance.</returns>
        public QueuesRequester getQueuesRequester { get { return this.queues; } }

        /// <summary>
        /// Retrieve  ConferencesRequester object value.
        /// </summary>
        /// <returns>ConferencesRequester instance.</returns>
        public ConferencesRequester getConferencesRequester { get { return this.conferences; } }

        /// <summary>
        /// Retrieve  ApplicationRequester object value.
        /// </summary>
        /// <returns>ApplicationRequester instance.</returns>
        public ApplicationsRequester getApplicationsRequester { get { return this.applications; } }

        /// <summary>
        /// Retrieve  LogRequester object value.
        /// </summary>
        /// <returns>LogRequester instance.</returns>
        public LogsRequester getLogsRequester { get { return this.logs; } }

        /// <summary>
        /// Retrieve  AvailablePhoneNumberRequester object value.
        /// </summary>
        /// <returns>AvailablePhoneNumberRequester instance.</returns>
        public AvailablePhoneNumbersRequester getAvailablePhoneNumbersRequester { get { return this.availablePhoneNumbers; } }

        /// <summary>
        /// Retrieve  IncomingPhoneNumberRequester object value.
        /// </summary>
        /// <returns>IncomingPhoneNumberRequester instance.</returns>
        public IncomingPhoneNumbersRequester getIncomingPhoneNumbersRequester { get { return this.incomingPhoneNumbers; } }

        /// <summary>
        /// Retrieve  CallingNumberRequester object value.
        /// </summary>
        /// <returns>CallingNumberRequester instance.</returns>
        public CallingNumbersRequester getCallingNumbersRequester { get { return this.callingNumbers; } }

        /// <summary>
        /// Retrieve  AccountsRequester object value.
        /// </summary>
        /// <returns>AccountsRequester instance.</returns>
        public AccountsRequester getAccountsRequester { get { return this.accounts; } }
    }
}
