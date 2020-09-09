// Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file except in compliance with
// the License. You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software distributed under the License is distributed on
// an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the License for the
// specific language governing permissions and limitations under the License.

// Generated code. DO NOT EDIT!

namespace Google.Apis.AdExchangeBuyer.v1_2
{
    /// <summary>The AdExchangeBuyer Service.</summary>
    public class AdExchangeBuyerService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1.2";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed =
            Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public AdExchangeBuyerService() :
            this(new Google.Apis.Services.BaseClientService.Initializer()) {}

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public AdExchangeBuyerService(Google.Apis.Services.BaseClientService.Initializer initializer)
            : base(initializer)
        {
            Accounts = new AccountsResource(this);
            Creatives = new CreativesResource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "adexchangebuyer";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri =>
        #if NETSTANDARD1_3 || NETSTANDARD2_0 || NET45
            BaseUriOverride ?? "https://www.googleapis.com/adexchangebuyer/v1.2/";
        #else
            "https://www.googleapis.com/adexchangebuyer/v1.2/";
        #endif

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "adexchangebuyer/v1.2/";

        #if !NET40
        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri => "https://www.googleapis.com/batch/adexchangebuyer/v1.2";

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch/adexchangebuyer/v1.2";
        #endif

        /// <summary>Available OAuth 2.0 scopes for use with the Ad Exchange Buyer API.</summary>
        public class Scope
        {
            /// <summary>Manage your Ad Exchange buyer account configuration</summary>
            public static string AdexchangeBuyer = "https://www.googleapis.com/auth/adexchange.buyer";

        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Ad Exchange Buyer API.</summary>
        public static class ScopeConstants
        {
            /// <summary>Manage your Ad Exchange buyer account configuration</summary>
            public const string AdexchangeBuyer = "https://www.googleapis.com/auth/adexchange.buyer";

        }



        /// <summary>Gets the Accounts resource.</summary>
        public virtual AccountsResource Accounts { get; }

        /// <summary>Gets the Creatives resource.</summary>
        public virtual CreativesResource Creatives { get; }
    }

    ///<summary>A base abstract class for AdExchangeBuyer requests.</summary>
    public abstract class AdExchangeBuyerBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        ///<summary>Constructs a new AdExchangeBuyerBaseServiceRequest instance.</summary>
        protected AdExchangeBuyerBaseServiceRequest(Google.Apis.Services.IClientService service)
            : base(service)
        {
        }

        /// <summary>Data format for the response.</summary>
        [Google.Apis.Util.RequestParameterAttribute("alt", Google.Apis.Util.RequestParameterType.Query)]
        public virtual System.Nullable<AltEnum> Alt { get; set; }

        /// <summary>Data format for the response.</summary>
        public enum AltEnum
        {
            /// <summary>Responses with Content-Type of application/json</summary>
            [Google.Apis.Util.StringValueAttribute("json")]
            Json,
        }

        /// <summary>Selector specifying which fields to include in a partial response.</summary>
        [Google.Apis.Util.RequestParameterAttribute("fields", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string Fields { get; set; }

        /// <summary>API key. Your API key identifies your project and provides you with API access, quota, and reports.
        /// Required unless you provide an OAuth 2.0 token.</summary>
        [Google.Apis.Util.RequestParameterAttribute("key", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string Key { get; set; }

        /// <summary>OAuth 2.0 token for the current user.</summary>
        [Google.Apis.Util.RequestParameterAttribute("oauth_token", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string OauthToken { get; set; }

        /// <summary>Returns response with indentations and line breaks.</summary>
        [Google.Apis.Util.RequestParameterAttribute("prettyPrint", Google.Apis.Util.RequestParameterType.Query)]
        public virtual System.Nullable<bool> PrettyPrint { get; set; }

        /// <summary>An opaque string that represents a user for quota purposes. Must not exceed 40
        /// characters.</summary>
        [Google.Apis.Util.RequestParameterAttribute("quotaUser", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string QuotaUser { get; set; }

        /// <summary>Deprecated. Please use quotaUser instead.</summary>
        [Google.Apis.Util.RequestParameterAttribute("userIp", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string UserIp { get; set; }

        /// <summary>Initializes AdExchangeBuyer parameter list.</summary>
        protected override void InitParameters()
        {
            base.InitParameters();

            RequestParameters.Add(
                "alt", new Google.Apis.Discovery.Parameter
                {
                    Name = "alt",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "json",
                    Pattern = null,
                });
            RequestParameters.Add(
                "fields", new Google.Apis.Discovery.Parameter
                {
                    Name = "fields",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            RequestParameters.Add(
                "key", new Google.Apis.Discovery.Parameter
                {
                    Name = "key",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            RequestParameters.Add(
                "oauth_token", new Google.Apis.Discovery.Parameter
                {
                    Name = "oauth_token",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            RequestParameters.Add(
                "prettyPrint", new Google.Apis.Discovery.Parameter
                {
                    Name = "prettyPrint",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "true",
                    Pattern = null,
                });
            RequestParameters.Add(
                "quotaUser", new Google.Apis.Discovery.Parameter
                {
                    Name = "quotaUser",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            RequestParameters.Add(
                "userIp", new Google.Apis.Discovery.Parameter
                {
                    Name = "userIp",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
        }
    }

    /// <summary>The "accounts" collection of methods.</summary>
    public class AccountsResource
    {
        private const string Resource = "accounts";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public AccountsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;

        }


        /// <summary>Gets one account by ID.</summary>
        /// <param name="id">The account id</param>
        public virtual GetRequest Get(int id)
        {
            return new GetRequest(service, id);
        }

        /// <summary>Gets one account by ID.</summary>
        public class GetRequest : AdExchangeBuyerBaseServiceRequest<Google.Apis.AdExchangeBuyer.v1_2.Data.Account>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, int id)
                : base(service)
            {
                Id = id;
                InitParameters();
            }


            /// <summary>The account id</summary>
            [Google.Apis.Util.RequestParameterAttribute("id", Google.Apis.Util.RequestParameterType.Path)]
            public virtual int Id { get; private set; }


            ///<summary>Gets the method name.</summary>
            public override string MethodName => "get";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "accounts/{id}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "id", new Google.Apis.Discovery.Parameter
                    {
                        Name = "id",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }

        /// <summary>Retrieves the authenticated user's list of accounts.</summary>
        public virtual ListRequest List()
        {
            return new ListRequest(service);
        }

        /// <summary>Retrieves the authenticated user's list of accounts.</summary>
        public class ListRequest : AdExchangeBuyerBaseServiceRequest<Google.Apis.AdExchangeBuyer.v1_2.Data.AccountsList>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service)
                : base(service)
            {
                InitParameters();
            }



            ///<summary>Gets the method name.</summary>
            public override string MethodName => "list";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "accounts";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

            }

        }

        /// <summary>Updates an existing account. This method supports patch semantics.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="id">The account id</param>
        public virtual PatchRequest Patch(Google.Apis.AdExchangeBuyer.v1_2.Data.Account body, int id)
        {
            return new PatchRequest(service, body, id);
        }

        /// <summary>Updates an existing account. This method supports patch semantics.</summary>
        public class PatchRequest : AdExchangeBuyerBaseServiceRequest<Google.Apis.AdExchangeBuyer.v1_2.Data.Account>
        {
            /// <summary>Constructs a new Patch request.</summary>
            public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.AdExchangeBuyer.v1_2.Data.Account body, int id)
                : base(service)
            {
                Id = id;
                Body = body;
                InitParameters();
            }


            /// <summary>The account id</summary>
            [Google.Apis.Util.RequestParameterAttribute("id", Google.Apis.Util.RequestParameterType.Path)]
            public virtual int Id { get; private set; }


            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.AdExchangeBuyer.v1_2.Data.Account Body { get; set; }

            ///<summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            ///<summary>Gets the method name.</summary>
            public override string MethodName => "patch";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PATCH";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "accounts/{id}";

            /// <summary>Initializes Patch parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "id", new Google.Apis.Discovery.Parameter
                    {
                        Name = "id",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }

        /// <summary>Updates an existing account.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="id">The account id</param>
        public virtual UpdateRequest Update(Google.Apis.AdExchangeBuyer.v1_2.Data.Account body, int id)
        {
            return new UpdateRequest(service, body, id);
        }

        /// <summary>Updates an existing account.</summary>
        public class UpdateRequest : AdExchangeBuyerBaseServiceRequest<Google.Apis.AdExchangeBuyer.v1_2.Data.Account>
        {
            /// <summary>Constructs a new Update request.</summary>
            public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.AdExchangeBuyer.v1_2.Data.Account body, int id)
                : base(service)
            {
                Id = id;
                Body = body;
                InitParameters();
            }


            /// <summary>The account id</summary>
            [Google.Apis.Util.RequestParameterAttribute("id", Google.Apis.Util.RequestParameterType.Path)]
            public virtual int Id { get; private set; }


            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.AdExchangeBuyer.v1_2.Data.Account Body { get; set; }

            ///<summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            ///<summary>Gets the method name.</summary>
            public override string MethodName => "update";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PUT";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "accounts/{id}";

            /// <summary>Initializes Update parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "id", new Google.Apis.Discovery.Parameter
                    {
                        Name = "id",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }
    }

    /// <summary>The "creatives" collection of methods.</summary>
    public class CreativesResource
    {
        private const string Resource = "creatives";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public CreativesResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;

        }


        /// <summary>Gets the status for a single creative. A creative will be available 30-40 minutes after
        /// submission.</summary>
        /// <param name="accountId">The id for the account that will serve this creative.</param>
        /// <param
        /// name="buyerCreativeId">The buyer-specific id for this creative.</param>
        public virtual GetRequest Get(int accountId, string buyerCreativeId)
        {
            return new GetRequest(service, accountId, buyerCreativeId);
        }

        /// <summary>Gets the status for a single creative. A creative will be available 30-40 minutes after
        /// submission.</summary>
        public class GetRequest : AdExchangeBuyerBaseServiceRequest<Google.Apis.AdExchangeBuyer.v1_2.Data.Creative>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, int accountId, string buyerCreativeId)
                : base(service)
            {
                AccountId = accountId;
                BuyerCreativeId = buyerCreativeId;
                InitParameters();
            }


            /// <summary>The id for the account that will serve this creative.</summary>
            [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual int AccountId { get; private set; }

            /// <summary>The buyer-specific id for this creative.</summary>
            [Google.Apis.Util.RequestParameterAttribute("buyerCreativeId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string BuyerCreativeId { get; private set; }


            ///<summary>Gets the method name.</summary>
            public override string MethodName => "get";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "creatives/{accountId}/{buyerCreativeId}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "accountId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "accountId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "buyerCreativeId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "buyerCreativeId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }

        /// <summary>Submit a new creative.</summary>
        /// <param name="body">The body of the request.</param>
        public virtual InsertRequest Insert(Google.Apis.AdExchangeBuyer.v1_2.Data.Creative body)
        {
            return new InsertRequest(service, body);
        }

        /// <summary>Submit a new creative.</summary>
        public class InsertRequest : AdExchangeBuyerBaseServiceRequest<Google.Apis.AdExchangeBuyer.v1_2.Data.Creative>
        {
            /// <summary>Constructs a new Insert request.</summary>
            public InsertRequest(Google.Apis.Services.IClientService service, Google.Apis.AdExchangeBuyer.v1_2.Data.Creative body)
                : base(service)
            {
                Body = body;
                InitParameters();
            }



            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.AdExchangeBuyer.v1_2.Data.Creative Body { get; set; }

            ///<summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            ///<summary>Gets the method name.</summary>
            public override string MethodName => "insert";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "creatives";

            /// <summary>Initializes Insert parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

            }

        }

        /// <summary>Retrieves a list of the authenticated user's active creatives. A creative will be available 30-40
        /// minutes after submission.</summary>
        public virtual ListRequest List()
        {
            return new ListRequest(service);
        }

        /// <summary>Retrieves a list of the authenticated user's active creatives. A creative will be available 30-40
        /// minutes after submission.</summary>
        public class ListRequest : AdExchangeBuyerBaseServiceRequest<Google.Apis.AdExchangeBuyer.v1_2.Data.CreativesList>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service)
                : base(service)
            {
                InitParameters();
            }


            /// <summary>Maximum number of entries returned on one result page. If not set, the default is 100.
            /// Optional.</summary>
            [Google.Apis.Util.RequestParameterAttribute("maxResults", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> MaxResults { get; set; }

            /// <summary>A continuation token, used to page through ad clients. To retrieve the next page, set this
            /// parameter to the value of "nextPageToken" from the previous response. Optional.</summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>When specified, only creatives having the given status are returned.</summary>
            [Google.Apis.Util.RequestParameterAttribute("statusFilter", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<StatusFilterEnum> StatusFilter { get; set; }

            /// <summary>When specified, only creatives having the given status are returned.</summary>
            public enum StatusFilterEnum
            {
                /// <summary>Creatives which have been approved.</summary>
                [Google.Apis.Util.StringValueAttribute("approved")]
                Approved,
                /// <summary>Creatives which have been disapproved.</summary>
                [Google.Apis.Util.StringValueAttribute("disapproved")]
                Disapproved,
                /// <summary>Creatives whose status is not yet checked.</summary>
                [Google.Apis.Util.StringValueAttribute("not_checked")]
                NotChecked,
            }


            ///<summary>Gets the method name.</summary>
            public override string MethodName => "list";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "creatives";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "maxResults", new Google.Apis.Discovery.Parameter
                    {
                        Name = "maxResults",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "pageToken", new Google.Apis.Discovery.Parameter
                    {
                        Name = "pageToken",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "statusFilter", new Google.Apis.Discovery.Parameter
                    {
                        Name = "statusFilter",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }
    }
}

namespace Google.Apis.AdExchangeBuyer.v1_2.Data
{    

    /// <summary>Configuration data for an Ad Exchange buyer account.</summary>
    public class Account : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Your bidder locations that have distinct URLs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bidderLocation")]
        public virtual System.Collections.Generic.IList<Account.BidderLocationData> BidderLocation { get; set; } 

        /// <summary>The nid parameter value used in cookie match requests. Please contact your technical account
        /// manager if you need to change this.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cookieMatchingNid")]
        public virtual string CookieMatchingNid { get; set; } 

        /// <summary>The base URL used in cookie match requests.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cookieMatchingUrl")]
        public virtual string CookieMatchingUrl { get; set; } 

        /// <summary>Account id.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual System.Nullable<int> Id { get; set; } 

        /// <summary>Resource type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; } 

        /// <summary>The maximum number of active creatives that an account can have, where a creative is active if it
        /// was inserted or bid with in the last 30 days. Please contact your technical account manager if you need to
        /// change this.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maximumActiveCreatives")]
        public virtual System.Nullable<int> MaximumActiveCreatives { get; set; } 

        /// <summary>The sum of all bidderLocation.maximumQps values cannot exceed this. Please contact your technical
        /// account manager if you need to change this.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maximumTotalQps")]
        public virtual System.Nullable<int> MaximumTotalQps { get; set; } 

        /// <summary>The number of creatives that this account inserted or bid with in the last 30 days.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("numberActiveCreatives")]
        public virtual System.Nullable<int> NumberActiveCreatives { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
        

        public class BidderLocationData
        {
            /// <summary>The maximum queries per second the Ad Exchange will send.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("maximumQps")]
            public virtual System.Nullable<int> MaximumQps { get; set; } 

            /// <summary>The geographical region the Ad Exchange should send requests from. Only used by some quota
            /// systems, but always setting the value is recommended. Allowed values: - ASIA - EUROPE - US_EAST -
            /// US_WEST</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("region")]
            public virtual string Region { get; set; } 

            /// <summary>The URL to which the Ad Exchange will send bid requests.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("url")]
            public virtual string Url { get; set; } 

        }
    }    

    /// <summary>An account feed lists Ad Exchange buyer accounts that the user has access to. Each entry in the feed
    /// corresponds to a single buyer account.</summary>
    public class AccountsList : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of accounts.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IList<Account> Items { get; set; } 

        /// <summary>Resource type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A creative and its classification data.</summary>
    public class Creative : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The HTML snippet that displays the ad when inserted in the web page. If set, videoURL should not be
        /// set.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("HTMLSnippet")]
        public virtual string HTMLSnippet { get; set; } 

        /// <summary>Account id.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accountId")]
        public virtual System.Nullable<int> AccountId { get; set; } 

        /// <summary>Detected advertiser id, if any. Read-only. This field should not be set in requests.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("advertiserId")]
        public virtual System.Collections.Generic.IList<System.Nullable<long>> AdvertiserId { get; set; } 

        /// <summary>The name of the company being advertised in the creative.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("advertiserName")]
        public virtual string AdvertiserName { get; set; } 

        /// <summary>The agency id for this creative.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("agencyId")]
        public virtual System.Nullable<long> AgencyId { get; set; } 

        /// <summary>The last upload timestamp of this creative if it was uploaded via API. Read-only. The value of this
        /// field is generated, and will be ignored for uploads. (formatted RFC 3339 timestamp).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("apiUploadTimestamp")]
        public virtual string ApiUploadTimestampRaw { get; set; }

        /// <summary><seealso cref="System.DateTime"/> representation of <see cref="ApiUploadTimestampRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnore]
        public virtual System.Nullable<System.DateTime> ApiUploadTimestamp
        {
            get
            {
                return Google.Apis.Util.Utilities.GetDateTimeFromString(ApiUploadTimestampRaw);
            }
            set
            {
                ApiUploadTimestampRaw = Google.Apis.Util.Utilities.GetStringFromDateTime(value);
            }
        }

        /// <summary>All attributes for the ads that may be shown from this snippet.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attribute")]
        public virtual System.Collections.Generic.IList<System.Nullable<int>> Attribute { get; set; } 

        /// <summary>A buyer-specific id identifying the creative in this ad.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("buyerCreativeId")]
        public virtual string BuyerCreativeId { get; set; } 

        /// <summary>The set of destination urls for the snippet.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clickThroughUrl")]
        public virtual System.Collections.Generic.IList<string> ClickThroughUrl { get; set; } 

        /// <summary>Shows any corrections that were applied to this creative. Read-only. This field should not be set
        /// in requests.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("corrections")]
        public virtual System.Collections.Generic.IList<Creative.CorrectionsData> Corrections { get; set; } 

        /// <summary>The reasons for disapproval, if any. Note that not all disapproval reasons may be categorized, so
        /// it is possible for the creative to have a status of DISAPPROVED with an empty list for disapproval_reasons.
        /// In this case, please reach out to your TAM to help debug the issue. Read-only. This field should not be set
        /// in requests.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disapprovalReasons")]
        public virtual System.Collections.Generic.IList<Creative.DisapprovalReasonsData> DisapprovalReasons { get; set; } 

        /// <summary>The filtering reasons for the creative. Read-only. This field should not be set in
        /// requests.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filteringReasons")]
        public virtual Creative.FilteringReasonsData FilteringReasons { get; set; } 

        /// <summary>Ad height.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("height")]
        public virtual System.Nullable<int> Height { get; set; } 

        /// <summary>The set of urls to be called to record an impression.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("impressionTrackingUrl")]
        public virtual System.Collections.Generic.IList<string> ImpressionTrackingUrl { get; set; } 

        /// <summary>Resource type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; } 

        /// <summary>Detected product categories, if any. Read-only. This field should not be set in requests.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productCategories")]
        public virtual System.Collections.Generic.IList<System.Nullable<int>> ProductCategories { get; set; } 

        /// <summary>All restricted categories for the ads that may be shown from this snippet.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("restrictedCategories")]
        public virtual System.Collections.Generic.IList<System.Nullable<int>> RestrictedCategories { get; set; } 

        /// <summary>Detected sensitive categories, if any. Read-only. This field should not be set in
        /// requests.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sensitiveCategories")]
        public virtual System.Collections.Generic.IList<System.Nullable<int>> SensitiveCategories { get; set; } 

        /// <summary>Creative serving status. Read-only. This field should not be set in requests.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual string Status { get; set; } 

        /// <summary>All vendor types for the ads that may be shown from this snippet.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vendorType")]
        public virtual System.Collections.Generic.IList<System.Nullable<int>> VendorType { get; set; } 

        /// <summary>The version for this creative. Read-only. This field should not be set in requests.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual System.Nullable<int> Version { get; set; } 

        /// <summary>The url to fetch a video ad. If set, HTMLSnippet should not be set.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("videoURL")]
        public virtual string VideoURL { get; set; } 

        /// <summary>Ad width.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("width")]
        public virtual System.Nullable<int> Width { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
        

        public class CorrectionsData
        {
            /// <summary>Additional details about the correction.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("details")]
            public virtual System.Collections.Generic.IList<string> Details { get; set; } 

            /// <summary>The type of correction that was applied to the creative.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("reason")]
            public virtual string Reason { get; set; } 

        }    

        public class DisapprovalReasonsData
        {
            /// <summary>Additional details about the reason for disapproval.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("details")]
            public virtual System.Collections.Generic.IList<string> Details { get; set; } 

            /// <summary>The categorized reason for disapproval.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("reason")]
            public virtual string Reason { get; set; } 

        }    

        /// <summary>The filtering reasons for the creative. Read-only. This field should not be set in
        /// requests.</summary>
        public class FilteringReasonsData
        {
            /// <summary>The date in ISO 8601 format for the data. The data is collected from 00:00:00 to 23:59:59 in
            /// PST.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("date")]
            public virtual string Date { get; set; } 

            /// <summary>The filtering reasons.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("reasons")]
            public virtual System.Collections.Generic.IList<FilteringReasonsData.ReasonsData> Reasons { get; set; } 

            

            public class ReasonsData
            {
                /// <summary>The number of times the creative was filtered for the status. The count is aggregated
                /// across all publishers on the exchange.</summary>
                [Newtonsoft.Json.JsonPropertyAttribute("filteringCount")]
                public virtual System.Nullable<long> FilteringCount { get; set; } 

                /// <summary>The filtering status code. Please refer to the creative-status-codes.txt file for different
                /// statuses.</summary>
                [Newtonsoft.Json.JsonPropertyAttribute("filteringStatus")]
                public virtual System.Nullable<int> FilteringStatus { get; set; } 

            }
        }
    }    

    /// <summary>The creatives feed lists the active creatives for the Ad Exchange buyer accounts that the user has
    /// access to. Each entry in the feed corresponds to a single creative.</summary>
    public class CreativesList : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of creatives.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IList<Creative> Items { get; set; } 

        /// <summary>Resource type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; } 

        /// <summary>Continuation token used to page through creatives. To retrieve the next page of results, set the
        /// next request's "pageToken" value to this.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
