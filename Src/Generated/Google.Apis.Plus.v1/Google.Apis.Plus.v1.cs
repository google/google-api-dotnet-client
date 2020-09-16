// Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file except in compliance with
// the License. You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software distributed under the License is distributed on
// an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the License for the
// specific language governing permissions and limitations under the License.

// Generated code. DO NOT EDIT!

namespace Google.Apis.Plus.v1
{
    /// <summary>The Plus Service.</summary>
    public class PlusService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public PlusService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public PlusService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Activities = new ActivitiesResource(this);
            Comments = new CommentsResource(this);
            People = new PeopleResource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "plus";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri =>
        #if NETSTANDARD1_3 || NETSTANDARD2_0 || NET45
            BaseUriOverride ?? "https://www.googleapis.com/plus/v1/";
        #else
            "https://www.googleapis.com/plus/v1/";
        #endif

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "plus/v1/";

        #if !NET40
        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri => "https://www.googleapis.com/batch/plus/v1";

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch/plus/v1";
        #endif

        /// <summary>Available OAuth 2.0 scopes for use with the Google+ API.</summary>
        public class Scope
        {
            /// <summary>View your basic profile info, including your age range and language</summary>
            public static string PlusLogin = "https://www.googleapis.com/auth/plus.login";

            /// <summary>Associate you with your personal info on Google</summary>
            public static string PlusMe = "https://www.googleapis.com/auth/plus.me";

            /// <summary>View your email address</summary>
            public static string UserinfoEmail = "https://www.googleapis.com/auth/userinfo.email";

            /// <summary>See your personal info, including any personal info you've made publicly available</summary>
            public static string UserinfoProfile = "https://www.googleapis.com/auth/userinfo.profile";

        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Google+ API.</summary>
        public static class ScopeConstants
        {
            /// <summary>View your basic profile info, including your age range and language</summary>
            public const string PlusLogin = "https://www.googleapis.com/auth/plus.login";

            /// <summary>Associate you with your personal info on Google</summary>
            public const string PlusMe = "https://www.googleapis.com/auth/plus.me";

            /// <summary>View your email address</summary>
            public const string UserinfoEmail = "https://www.googleapis.com/auth/userinfo.email";

            /// <summary>See your personal info, including any personal info you've made publicly available</summary>
            public const string UserinfoProfile = "https://www.googleapis.com/auth/userinfo.profile";

        }



        /// <summary>Gets the Activities resource.</summary>
        public virtual ActivitiesResource Activities { get; }

        /// <summary>Gets the Comments resource.</summary>
        public virtual CommentsResource Comments { get; }

        /// <summary>Gets the People resource.</summary>
        public virtual PeopleResource People { get; }
    }

    /// <summary>A base abstract class for Plus requests.</summary>
    public abstract class PlusBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new PlusBaseServiceRequest instance.</summary>
        protected PlusBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes Plus parameter list.</summary>
        protected override void InitParameters()
        {
            base.InitParameters();

            RequestParameters.Add("alt", new Google.Apis.Discovery.Parameter
            {
                Name = "alt",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = "json",
                Pattern = null,
            });
            RequestParameters.Add("fields", new Google.Apis.Discovery.Parameter
            {
                Name = "fields",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = null,
                Pattern = null,
            });
            RequestParameters.Add("key", new Google.Apis.Discovery.Parameter
            {
                Name = "key",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = null,
                Pattern = null,
            });
            RequestParameters.Add("oauth_token", new Google.Apis.Discovery.Parameter
            {
                Name = "oauth_token",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = null,
                Pattern = null,
            });
            RequestParameters.Add("prettyPrint", new Google.Apis.Discovery.Parameter
            {
                Name = "prettyPrint",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = "true",
                Pattern = null,
            });
            RequestParameters.Add("quotaUser", new Google.Apis.Discovery.Parameter
            {
                Name = "quotaUser",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = null,
                Pattern = null,
            });
            RequestParameters.Add("userIp", new Google.Apis.Discovery.Parameter
            {
                Name = "userIp",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = null,
                Pattern = null,
            });
        }
    }

    /// <summary>The "activities" collection of methods.</summary>
    public class ActivitiesResource
    {
        private const string Resource = "activities";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public ActivitiesResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;

        }


        /// <summary>Shut down. See https://developers.google.com/+/api-shutdown for more details.</summary>
        /// <param name="activityId">The ID of the activity to get.</param>
        public virtual GetRequest Get(string activityId)
        {
            return new GetRequest(service, activityId);
        }

        /// <summary>Shut down. See https://developers.google.com/+/api-shutdown for more details.</summary>
        public class GetRequest : PlusBaseServiceRequest<Google.Apis.Plus.v1.Data.Activity>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string activityId) : base(service)
            {
                ActivityId = activityId;
                InitParameters();
            }


            /// <summary>The ID of the activity to get.</summary>
            [Google.Apis.Util.RequestParameterAttribute("activityId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ActivityId { get; private set; }


            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "activities/{activityId}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add("activityId", new Google.Apis.Discovery.Parameter
                {
                    Name = "activityId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }

        }

        /// <summary>Shut down. See https://developers.google.com/+/api-shutdown for more details.</summary>
        /// <param name="userId">The ID of the user to get activities for. The special value "me" can be used to indicate the
        /// authenticated user.</param>
        /// <param name="collection">The collection of activities to list.</param>
        public virtual ListRequest List(string userId, ListRequest.CollectionEnum collection)
        {
            return new ListRequest(service, userId, collection);
        }

        /// <summary>Shut down. See https://developers.google.com/+/api-shutdown for more details.</summary>
        public class ListRequest : PlusBaseServiceRequest<Google.Apis.Plus.v1.Data.ActivityFeed>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service, string userId, ListRequest.CollectionEnum collection) : base(service)
            {
                UserId = userId;
                Collection = collection;
                InitParameters();
            }


            /// <summary>The ID of the user to get activities for. The special value "me" can be used to indicate the
            /// authenticated user.</summary>
            [Google.Apis.Util.RequestParameterAttribute("userId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string UserId { get; private set; }

            /// <summary>The collection of activities to list.</summary>
            [Google.Apis.Util.RequestParameterAttribute("collection", Google.Apis.Util.RequestParameterType.Path)]
            public virtual CollectionEnum Collection { get; private set; }

            /// <summary>The collection of activities to list.</summary>
            public enum CollectionEnum
            {
                /// <summary>All public activities created by the specified user.</summary>
                [Google.Apis.Util.StringValueAttribute("public")]
                Public__,
            }

            /// <summary>The maximum number of activities to include in the response, which is used for paging. For any
            /// response, the actual number returned might be less than the specified maxResults.</summary>
            [Google.Apis.Util.RequestParameterAttribute("maxResults", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> MaxResults { get; set; }

            /// <summary>The continuation token, which is used to page through large result sets. To get the next page
            /// of results, set this parameter to the value of "nextPageToken" from the previous response.</summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }


            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "people/{userId}/activities/{collection}";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add("userId", new Google.Apis.Discovery.Parameter
                {
                    Name = "userId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("collection", new Google.Apis.Discovery.Parameter
                {
                    Name = "collection",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("maxResults", new Google.Apis.Discovery.Parameter
                {
                    Name = "maxResults",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "20",
                    Pattern = null,
                });
                RequestParameters.Add("pageToken", new Google.Apis.Discovery.Parameter
                {
                    Name = "pageToken",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }

        }

        /// <summary>Shut down. See https://developers.google.com/+/api-shutdown for more details.</summary>
        /// <param name="query">Full-text search query string.</param>
        public virtual SearchRequest Search(string query)
        {
            return new SearchRequest(service, query);
        }

        /// <summary>Shut down. See https://developers.google.com/+/api-shutdown for more details.</summary>
        public class SearchRequest : PlusBaseServiceRequest<Google.Apis.Plus.v1.Data.ActivityFeed>
        {
            /// <summary>Constructs a new Search request.</summary>
            public SearchRequest(Google.Apis.Services.IClientService service, string query) : base(service)
            {
                Query = query;
                InitParameters();
            }


            /// <summary>Full-text search query string.</summary>
            [Google.Apis.Util.RequestParameterAttribute("query", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Query { get; private set; }

            /// <summary>Specify the preferred language to search with. See search language codes for available
            /// values.</summary>
            [Google.Apis.Util.RequestParameterAttribute("language", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Language { get; set; }

            /// <summary>The maximum number of activities to include in the response, which is used for paging. For any
            /// response, the actual number returned might be less than the specified maxResults.</summary>
            [Google.Apis.Util.RequestParameterAttribute("maxResults", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> MaxResults { get; set; }

            /// <summary>Specifies how to order search results.</summary>
            [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<OrderByEnum> OrderBy { get; set; }

            /// <summary>Specifies how to order search results.</summary>
            public enum OrderByEnum
            {
                /// <summary>Sort activities by relevance to the user, most relevant first.</summary>
                [Google.Apis.Util.StringValueAttribute("best")]
                Best,
                /// <summary>Sort activities by published date, most recent first.</summary>
                [Google.Apis.Util.StringValueAttribute("recent")]
                Recent,
            }

            /// <summary>The continuation token, which is used to page through large result sets. To get the next page
            /// of results, set this parameter to the value of "nextPageToken" from the previous response. This token
            /// can be of any length.</summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }


            /// <summary>Gets the method name.</summary>
            public override string MethodName => "search";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "activities";

            /// <summary>Initializes Search parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add("query", new Google.Apis.Discovery.Parameter
                {
                    Name = "query",
                    IsRequired = true,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("language", new Google.Apis.Discovery.Parameter
                {
                    Name = "language",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "en-US",
                    Pattern = null,
                });
                RequestParameters.Add("maxResults", new Google.Apis.Discovery.Parameter
                {
                    Name = "maxResults",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "10",
                    Pattern = null,
                });
                RequestParameters.Add("orderBy", new Google.Apis.Discovery.Parameter
                {
                    Name = "orderBy",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "recent",
                    Pattern = null,
                });
                RequestParameters.Add("pageToken", new Google.Apis.Discovery.Parameter
                {
                    Name = "pageToken",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }

        }
    }

    /// <summary>The "comments" collection of methods.</summary>
    public class CommentsResource
    {
        private const string Resource = "comments";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public CommentsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;

        }


        /// <summary>Shut down. See https://developers.google.com/+/api-shutdown for more details.</summary>
        /// <param name="commentId">The ID of the comment to get.</param>
        public virtual GetRequest Get(string commentId)
        {
            return new GetRequest(service, commentId);
        }

        /// <summary>Shut down. See https://developers.google.com/+/api-shutdown for more details.</summary>
        public class GetRequest : PlusBaseServiceRequest<Google.Apis.Plus.v1.Data.Comment>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string commentId) : base(service)
            {
                CommentId = commentId;
                InitParameters();
            }


            /// <summary>The ID of the comment to get.</summary>
            [Google.Apis.Util.RequestParameterAttribute("commentId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string CommentId { get; private set; }


            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "comments/{commentId}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add("commentId", new Google.Apis.Discovery.Parameter
                {
                    Name = "commentId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }

        }

        /// <summary>Shut down. See https://developers.google.com/+/api-shutdown for more details.</summary>
        /// <param name="activityId">The ID of the activity to get comments for.</param>
        public virtual ListRequest List(string activityId)
        {
            return new ListRequest(service, activityId);
        }

        /// <summary>Shut down. See https://developers.google.com/+/api-shutdown for more details.</summary>
        public class ListRequest : PlusBaseServiceRequest<Google.Apis.Plus.v1.Data.CommentFeed>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service, string activityId) : base(service)
            {
                ActivityId = activityId;
                InitParameters();
            }


            /// <summary>The ID of the activity to get comments for.</summary>
            [Google.Apis.Util.RequestParameterAttribute("activityId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ActivityId { get; private set; }

            /// <summary>The maximum number of comments to include in the response, which is used for paging. For any
            /// response, the actual number returned might be less than the specified maxResults.</summary>
            [Google.Apis.Util.RequestParameterAttribute("maxResults", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> MaxResults { get; set; }

            /// <summary>The continuation token, which is used to page through large result sets. To get the next page
            /// of results, set this parameter to the value of "nextPageToken" from the previous response.</summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>The order in which to sort the list of comments.</summary>
            [Google.Apis.Util.RequestParameterAttribute("sortOrder", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<SortOrderEnum> SortOrder { get; set; }

            /// <summary>The order in which to sort the list of comments.</summary>
            public enum SortOrderEnum
            {
                /// <summary>Sort oldest comments first.</summary>
                [Google.Apis.Util.StringValueAttribute("ascending")]
                Ascending,
                /// <summary>Sort newest comments first.</summary>
                [Google.Apis.Util.StringValueAttribute("descending")]
                Descending,
            }


            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "activities/{activityId}/comments";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add("activityId", new Google.Apis.Discovery.Parameter
                {
                    Name = "activityId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("maxResults", new Google.Apis.Discovery.Parameter
                {
                    Name = "maxResults",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "20",
                    Pattern = null,
                });
                RequestParameters.Add("pageToken", new Google.Apis.Discovery.Parameter
                {
                    Name = "pageToken",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("sortOrder", new Google.Apis.Discovery.Parameter
                {
                    Name = "sortOrder",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "ascending",
                    Pattern = null,
                });
            }

        }
    }

    /// <summary>The "people" collection of methods.</summary>
    public class PeopleResource
    {
        private const string Resource = "people";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public PeopleResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;

        }


        /// <summary>Get a person's profile. If your app uses scope https://www.googleapis.com/auth/plus.login, this
        /// method is guaranteed to return ageRange and language.</summary>
        /// <param name="userId">The ID of the person to get the profile for. The special value "me" can be used to indicate the
        /// authenticated user.</param>
        public virtual GetRequest Get(string userId)
        {
            return new GetRequest(service, userId);
        }

        /// <summary>Get a person's profile. If your app uses scope https://www.googleapis.com/auth/plus.login, this
        /// method is guaranteed to return ageRange and language.</summary>
        public class GetRequest : PlusBaseServiceRequest<Google.Apis.Plus.v1.Data.Person>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string userId) : base(service)
            {
                UserId = userId;
                InitParameters();
            }


            /// <summary>The ID of the person to get the profile for. The special value "me" can be used to indicate the
            /// authenticated user.</summary>
            [Google.Apis.Util.RequestParameterAttribute("userId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string UserId { get; private set; }


            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "people/{userId}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add("userId", new Google.Apis.Discovery.Parameter
                {
                    Name = "userId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }

        }

        /// <summary>List all of the people in the specified collection.</summary>
        /// <param name="userId">Get the collection of people for the person identified. Use "me" to indicate the authenticated
        /// user.</param>
        /// <param name="collection">The collection of people to list.</param>
        public virtual ListRequest List(string userId, ListRequest.CollectionEnum collection)
        {
            return new ListRequest(service, userId, collection);
        }

        /// <summary>List all of the people in the specified collection.</summary>
        public class ListRequest : PlusBaseServiceRequest<Google.Apis.Plus.v1.Data.PeopleFeed>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service, string userId, ListRequest.CollectionEnum collection) : base(service)
            {
                UserId = userId;
                Collection = collection;
                InitParameters();
            }


            /// <summary>Get the collection of people for the person identified. Use "me" to indicate the authenticated
            /// user.</summary>
            [Google.Apis.Util.RequestParameterAttribute("userId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string UserId { get; private set; }

            /// <summary>The collection of people to list.</summary>
            [Google.Apis.Util.RequestParameterAttribute("collection", Google.Apis.Util.RequestParameterType.Path)]
            public virtual CollectionEnum Collection { get; private set; }

            /// <summary>The collection of people to list.</summary>
            public enum CollectionEnum
            {
                /// <summary>The list of visible people in the authenticated user's circles who also use the requesting
                /// app. This list is limited to users who made their app activities visible to the authenticated
                /// user.</summary>
                [Google.Apis.Util.StringValueAttribute("connected")]
                Connected,
                /// <summary>The list of people who this user has added to one or more circles, limited to the circles
                /// visible to the requesting application.</summary>
                [Google.Apis.Util.StringValueAttribute("visible")]
                Visible,
            }

            /// <summary>The maximum number of people to include in the response, which is used for paging. For any
            /// response, the actual number returned might be less than the specified maxResults.</summary>
            [Google.Apis.Util.RequestParameterAttribute("maxResults", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> MaxResults { get; set; }

            /// <summary>The order to return people in.</summary>
            [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<OrderByEnum> OrderBy { get; set; }

            /// <summary>The order to return people in.</summary>
            public enum OrderByEnum
            {
                /// <summary>Order the people by their display name.</summary>
                [Google.Apis.Util.StringValueAttribute("alphabetical")]
                Alphabetical,
                /// <summary>Order people based on the relevence to the viewer.</summary>
                [Google.Apis.Util.StringValueAttribute("best")]
                Best,
            }

            /// <summary>The continuation token, which is used to page through large result sets. To get the next page
            /// of results, set this parameter to the value of "nextPageToken" from the previous response.</summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }


            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "people/{userId}/people/{collection}";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add("userId", new Google.Apis.Discovery.Parameter
                {
                    Name = "userId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("collection", new Google.Apis.Discovery.Parameter
                {
                    Name = "collection",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("maxResults", new Google.Apis.Discovery.Parameter
                {
                    Name = "maxResults",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "100",
                    Pattern = null,
                });
                RequestParameters.Add("orderBy", new Google.Apis.Discovery.Parameter
                {
                    Name = "orderBy",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("pageToken", new Google.Apis.Discovery.Parameter
                {
                    Name = "pageToken",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }

        }

        /// <summary>Shut down. See https://developers.google.com/+/api-shutdown for more details.</summary>
        /// <param name="activityId">The ID of the activity to get the list of people for.</param>
        /// <param
        /// name="collection">The collection of people to list.</param>
        public virtual ListByActivityRequest ListByActivity(string activityId, ListByActivityRequest.CollectionEnum collection)
        {
            return new ListByActivityRequest(service, activityId, collection);
        }

        /// <summary>Shut down. See https://developers.google.com/+/api-shutdown for more details.</summary>
        public class ListByActivityRequest : PlusBaseServiceRequest<Google.Apis.Plus.v1.Data.PeopleFeed>
        {
            /// <summary>Constructs a new ListByActivity request.</summary>
            public ListByActivityRequest(Google.Apis.Services.IClientService service, string activityId, ListByActivityRequest.CollectionEnum collection) : base(service)
            {
                ActivityId = activityId;
                Collection = collection;
                InitParameters();
            }


            /// <summary>The ID of the activity to get the list of people for.</summary>
            [Google.Apis.Util.RequestParameterAttribute("activityId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ActivityId { get; private set; }

            /// <summary>The collection of people to list.</summary>
            [Google.Apis.Util.RequestParameterAttribute("collection", Google.Apis.Util.RequestParameterType.Path)]
            public virtual CollectionEnum Collection { get; private set; }

            /// <summary>The collection of people to list.</summary>
            public enum CollectionEnum
            {
                /// <summary>List all people who have +1'd this activity.</summary>
                [Google.Apis.Util.StringValueAttribute("plusoners")]
                Plusoners,
                /// <summary>List all people who have reshared this activity.</summary>
                [Google.Apis.Util.StringValueAttribute("resharers")]
                Resharers,
            }

            /// <summary>The maximum number of people to include in the response, which is used for paging. For any
            /// response, the actual number returned might be less than the specified maxResults.</summary>
            [Google.Apis.Util.RequestParameterAttribute("maxResults", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> MaxResults { get; set; }

            /// <summary>The continuation token, which is used to page through large result sets. To get the next page
            /// of results, set this parameter to the value of "nextPageToken" from the previous response.</summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }


            /// <summary>Gets the method name.</summary>
            public override string MethodName => "listByActivity";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "activities/{activityId}/people/{collection}";

            /// <summary>Initializes ListByActivity parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add("activityId", new Google.Apis.Discovery.Parameter
                {
                    Name = "activityId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("collection", new Google.Apis.Discovery.Parameter
                {
                    Name = "collection",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("maxResults", new Google.Apis.Discovery.Parameter
                {
                    Name = "maxResults",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "20",
                    Pattern = null,
                });
                RequestParameters.Add("pageToken", new Google.Apis.Discovery.Parameter
                {
                    Name = "pageToken",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }

        }

        /// <summary>Shut down. See https://developers.google.com/+/api-shutdown for more details.</summary>
        /// <param name="query">Specify a query string for full text search of public text in all profiles.</param>
        public virtual SearchRequest Search(string query)
        {
            return new SearchRequest(service, query);
        }

        /// <summary>Shut down. See https://developers.google.com/+/api-shutdown for more details.</summary>
        public class SearchRequest : PlusBaseServiceRequest<Google.Apis.Plus.v1.Data.PeopleFeed>
        {
            /// <summary>Constructs a new Search request.</summary>
            public SearchRequest(Google.Apis.Services.IClientService service, string query) : base(service)
            {
                Query = query;
                InitParameters();
            }


            /// <summary>Specify a query string for full text search of public text in all profiles.</summary>
            [Google.Apis.Util.RequestParameterAttribute("query", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Query { get; private set; }

            /// <summary>Specify the preferred language to search with. See search language codes for available
            /// values.</summary>
            [Google.Apis.Util.RequestParameterAttribute("language", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Language { get; set; }

            /// <summary>The maximum number of people to include in the response, which is used for paging. For any
            /// response, the actual number returned might be less than the specified maxResults.</summary>
            [Google.Apis.Util.RequestParameterAttribute("maxResults", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> MaxResults { get; set; }

            /// <summary>The continuation token, which is used to page through large result sets. To get the next page
            /// of results, set this parameter to the value of "nextPageToken" from the previous response. This token
            /// can be of any length.</summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }


            /// <summary>Gets the method name.</summary>
            public override string MethodName => "search";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "people";

            /// <summary>Initializes Search parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add("query", new Google.Apis.Discovery.Parameter
                {
                    Name = "query",
                    IsRequired = true,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("language", new Google.Apis.Discovery.Parameter
                {
                    Name = "language",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "en-US",
                    Pattern = null,
                });
                RequestParameters.Add("maxResults", new Google.Apis.Discovery.Parameter
                {
                    Name = "maxResults",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "25",
                    Pattern = null,
                });
                RequestParameters.Add("pageToken", new Google.Apis.Discovery.Parameter
                {
                    Name = "pageToken",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }

        }
    }
}

namespace Google.Apis.Plus.v1.Data
{    

    public class Acl : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Description of the access granted, suitable for display.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; } 

        /// <summary>The list of access entries.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IList<PlusAclentryResource> Items { get; set; } 

        /// <summary>Identifies this resource as a collection of access controls. Value: "plus#acl".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class Activity : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Identifies who has access to see this activity.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("access")]
        public virtual Acl Access { get; set; } 

        /// <summary>The person who performed this activity.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("actor")]
        public virtual Activity.ActorData Actor { get; set; } 

        /// <summary>Street address where this activity occurred.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("address")]
        public virtual string Address { get; set; } 

        /// <summary>Additional content added by the person who shared this activity, applicable only when resharing an
        /// activity.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("annotation")]
        public virtual string Annotation { get; set; } 

        /// <summary>If this activity is a crosspost from another system, this property specifies the ID of the original
        /// activity.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("crosspostSource")]
        public virtual string CrosspostSource { get; set; } 

        /// <summary>ETag of this response for caching purposes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; } 

        /// <summary>Latitude and longitude where this activity occurred. Format is latitude followed by longitude,
        /// space separated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("geocode")]
        public virtual string Geocode { get; set; } 

        /// <summary>The ID of this activity.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; } 

        /// <summary>Identifies this resource as an activity. Value: "plus#activity".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; } 

        /// <summary>The location where this activity occurred.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("location")]
        public virtual Place Location { get; set; } 

        /// <summary>The object of this activity.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("object")]
        public virtual Activity.ObjectData Object__ { get; set; } 

        /// <summary>ID of the place where this activity occurred.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("placeId")]
        public virtual string PlaceId { get; set; } 

        /// <summary>Name of the place where this activity occurred.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("placeName")]
        public virtual string PlaceName { get; set; } 

        /// <summary>The service provider that initially published this activity.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("provider")]
        public virtual Activity.ProviderData Provider { get; set; } 

        /// <summary>The time at which this activity was initially published. Formatted as an RFC 3339
        /// timestamp.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("published")]
        public virtual string PublishedRaw { get; set; }

        /// <summary><seealso cref="System.DateTime"/> representation of <see cref="PublishedRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.Nullable<System.DateTime> Published
        {
            get => Google.Apis.Util.Utilities.GetDateTimeFromString(PublishedRaw);
            set => PublishedRaw = Google.Apis.Util.Utilities.GetStringFromDateTime(value);
        }

        /// <summary>Radius, in meters, of the region where this activity occurred, centered at the latitude and
        /// longitude identified in geocode.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("radius")]
        public virtual string Radius { get; set; } 

        /// <summary>Title of this activity.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; } 

        /// <summary>The time at which this activity was last updated. Formatted as an RFC 3339 timestamp.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updated")]
        public virtual string UpdatedRaw { get; set; }

        /// <summary><seealso cref="System.DateTime"/> representation of <see cref="UpdatedRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.Nullable<System.DateTime> Updated
        {
            get => Google.Apis.Util.Utilities.GetDateTimeFromString(UpdatedRaw);
            set => UpdatedRaw = Google.Apis.Util.Utilities.GetStringFromDateTime(value);
        }

        /// <summary>The link to this activity.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("url")]
        public virtual string Url { get; set; } 

        /// <summary>This activity's verb, which indicates the action that was performed. Possible values include, but
        /// are not limited to, the following values: - "post" - Publish content to the stream. - "share" - Reshare an
        /// activity.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("verb")]
        public virtual string Verb { get; set; } 

        

        /// <summary>The person who performed this activity.</summary>
        public class ActorData
        {
            /// <summary>Actor info specific to particular clients.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("clientSpecificActorInfo")]
            public virtual ActorData.ClientSpecificActorInfoData ClientSpecificActorInfo { get; set; } 

            /// <summary>The name of the actor, suitable for display.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
            public virtual string DisplayName { get; set; } 

            /// <summary>The ID of the actor's Person resource.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("id")]
            public virtual string Id { get; set; } 

            /// <summary>The image representation of the actor.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("image")]
            public virtual ActorData.ImageData Image { get; set; } 

            /// <summary>An object representation of the individual components of name.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("name")]
            public virtual ActorData.NameData Name { get; set; } 

            /// <summary>The link to the actor's Google profile.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("url")]
            public virtual string Url { get; set; } 

            /// <summary>Verification status of actor.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("verification")]
            public virtual ActorData.VerificationData Verification { get; set; } 

            

            /// <summary>Actor info specific to particular clients.</summary>
            public class ClientSpecificActorInfoData
            {
                /// <summary>Actor info specific to YouTube clients.</summary>
                [Newtonsoft.Json.JsonPropertyAttribute("youtubeActorInfo")]
                public virtual ClientSpecificActorInfoData.YoutubeActorInfoData YoutubeActorInfo { get; set; } 

                

                /// <summary>Actor info specific to YouTube clients.</summary>
                public class YoutubeActorInfoData
                {
                    /// <summary>ID of the YouTube channel owned by the Actor.</summary>
                    [Newtonsoft.Json.JsonPropertyAttribute("channelId")]
                    public virtual string ChannelId { get; set; } 

                }
            }    

            /// <summary>The image representation of the actor.</summary>
            public class ImageData
            {
                /// <summary>The URL of the actor's profile photo. To resize the image and crop it to a square, append
                /// the query string ?sz=x, where x is the dimension in pixels of each side.</summary>
                [Newtonsoft.Json.JsonPropertyAttribute("url")]
                public virtual string Url { get; set; } 

            }    

            /// <summary>An object representation of the individual components of name.</summary>
            public class NameData
            {
                /// <summary>The family name ("last name") of the actor.</summary>
                [Newtonsoft.Json.JsonPropertyAttribute("familyName")]
                public virtual string FamilyName { get; set; } 

                /// <summary>The given name ("first name") of the actor.</summary>
                [Newtonsoft.Json.JsonPropertyAttribute("givenName")]
                public virtual string GivenName { get; set; } 

            }    

            /// <summary>Verification status of actor.</summary>
            public class VerificationData
            {
                /// <summary>Verification for one-time or manual processes.</summary>
                [Newtonsoft.Json.JsonPropertyAttribute("adHocVerified")]
                public virtual string AdHocVerified { get; set; } 

            }
        }    

        /// <summary>The object of this activity.</summary>
        public class ObjectData
        {
            /// <summary>If this activity's object is itself another activity, such as when a person reshares an
            /// activity, this property specifies the original activity's actor.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("actor")]
            public virtual ObjectData.ActorData Actor { get; set; } 

            /// <summary>The media objects attached to this activity.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("attachments")]
            public virtual System.Collections.Generic.IList<ObjectData.AttachmentsData> Attachments { get; set; } 

            /// <summary>The HTML-formatted content, which is suitable for display.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("content")]
            public virtual string Content { get; set; } 

            /// <summary>The ID of the object. When resharing an activity, this is the ID of the activity that is being
            /// reshared.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("id")]
            public virtual string Id { get; set; } 

            /// <summary>The type of the object. Possible values include, but are not limited to, the following values:
            /// - "note" - Textual content. - "activity" - A Google+ activity.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("objectType")]
            public virtual string ObjectType { get; set; } 

            /// <summary>The content (text) as provided by the author, which is stored without any HTML formatting. When
            /// creating or updating an activity, this value must be supplied as plain text in the request.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("originalContent")]
            public virtual string OriginalContent { get; set; } 

            /// <summary>People who +1'd this activity.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("plusoners")]
            public virtual ObjectData.PlusonersData Plusoners { get; set; } 

            /// <summary>Comments in reply to this activity.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("replies")]
            public virtual ObjectData.RepliesData Replies { get; set; } 

            /// <summary>People who reshared this activity.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("resharers")]
            public virtual ObjectData.ResharersData Resharers { get; set; } 

            /// <summary>The URL that points to the linked resource.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("url")]
            public virtual string Url { get; set; } 

            

            /// <summary>If this activity's object is itself another activity, such as when a person reshares an
            /// activity, this property specifies the original activity's actor.</summary>
            public class ActorData
            {
                /// <summary>Actor info specific to particular clients.</summary>
                [Newtonsoft.Json.JsonPropertyAttribute("clientSpecificActorInfo")]
                public virtual ActorData.ClientSpecificActorInfoData ClientSpecificActorInfo { get; set; } 

                /// <summary>The original actor's name, which is suitable for display.</summary>
                [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
                public virtual string DisplayName { get; set; } 

                /// <summary>ID of the original actor.</summary>
                [Newtonsoft.Json.JsonPropertyAttribute("id")]
                public virtual string Id { get; set; } 

                /// <summary>The image representation of the original actor.</summary>
                [Newtonsoft.Json.JsonPropertyAttribute("image")]
                public virtual ActorData.ImageData Image { get; set; } 

                /// <summary>A link to the original actor's Google profile.</summary>
                [Newtonsoft.Json.JsonPropertyAttribute("url")]
                public virtual string Url { get; set; } 

                /// <summary>Verification status of actor.</summary>
                [Newtonsoft.Json.JsonPropertyAttribute("verification")]
                public virtual ActorData.VerificationData Verification { get; set; } 

                

                /// <summary>Actor info specific to particular clients.</summary>
                public class ClientSpecificActorInfoData
                {
                    /// <summary>Actor info specific to YouTube clients.</summary>
                    [Newtonsoft.Json.JsonPropertyAttribute("youtubeActorInfo")]
                    public virtual ClientSpecificActorInfoData.YoutubeActorInfoData YoutubeActorInfo { get; set; } 

                    

                    /// <summary>Actor info specific to YouTube clients.</summary>
                    public class YoutubeActorInfoData
                    {
                        /// <summary>ID of the YouTube channel owned by the Actor.</summary>
                        [Newtonsoft.Json.JsonPropertyAttribute("channelId")]
                        public virtual string ChannelId { get; set; } 

                    }
                }    

                /// <summary>The image representation of the original actor.</summary>
                public class ImageData
                {
                    /// <summary>A URL that points to a thumbnail photo of the original actor.</summary>
                    [Newtonsoft.Json.JsonPropertyAttribute("url")]
                    public virtual string Url { get; set; } 

                }    

                /// <summary>Verification status of actor.</summary>
                public class VerificationData
                {
                    /// <summary>Verification for one-time or manual processes.</summary>
                    [Newtonsoft.Json.JsonPropertyAttribute("adHocVerified")]
                    public virtual string AdHocVerified { get; set; } 

                }
            }    

            public class AttachmentsData
            {
                /// <summary>If the attachment is an article, this property contains a snippet of text from the article.
                /// It can also include descriptions for other types.</summary>
                [Newtonsoft.Json.JsonPropertyAttribute("content")]
                public virtual string Content { get; set; } 

                /// <summary>The title of the attachment, such as a photo caption or an article title.</summary>
                [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
                public virtual string DisplayName { get; set; } 

                /// <summary>If the attachment is a video, the embeddable link.</summary>
                [Newtonsoft.Json.JsonPropertyAttribute("embed")]
                public virtual AttachmentsData.EmbedData Embed { get; set; } 

                /// <summary>The full image URL for photo attachments.</summary>
                [Newtonsoft.Json.JsonPropertyAttribute("fullImage")]
                public virtual AttachmentsData.FullImageData FullImage { get; set; } 

                /// <summary>The ID of the attachment.</summary>
                [Newtonsoft.Json.JsonPropertyAttribute("id")]
                public virtual string Id { get; set; } 

                /// <summary>The preview image for photos or videos.</summary>
                [Newtonsoft.Json.JsonPropertyAttribute("image")]
                public virtual AttachmentsData.ImageData Image { get; set; } 

                /// <summary>The type of media object. Possible values include, but are not limited to, the following
                /// values: - "photo" - A photo. - "album" - A photo album. - "video" - A video. - "article" - An
                /// article, specified by a link.</summary>
                [Newtonsoft.Json.JsonPropertyAttribute("objectType")]
                public virtual string ObjectType { get; set; } 

                /// <summary>If the attachment is an album, this property is a list of potential additional thumbnails
                /// from the album.</summary>
                [Newtonsoft.Json.JsonPropertyAttribute("thumbnails")]
                public virtual System.Collections.Generic.IList<AttachmentsData.ThumbnailsData> Thumbnails { get; set; } 

                /// <summary>The link to the attachment, which should be of type text/html.</summary>
                [Newtonsoft.Json.JsonPropertyAttribute("url")]
                public virtual string Url { get; set; } 

                

                /// <summary>If the attachment is a video, the embeddable link.</summary>
                public class EmbedData
                {
                    /// <summary>Media type of the link.</summary>
                    [Newtonsoft.Json.JsonPropertyAttribute("type")]
                    public virtual string Type { get; set; } 

                    /// <summary>URL of the link.</summary>
                    [Newtonsoft.Json.JsonPropertyAttribute("url")]
                    public virtual string Url { get; set; } 

                }    

                /// <summary>The full image URL for photo attachments.</summary>
                public class FullImageData
                {
                    /// <summary>The height, in pixels, of the linked resource.</summary>
                    [Newtonsoft.Json.JsonPropertyAttribute("height")]
                    public virtual System.Nullable<long> Height { get; set; } 

                    /// <summary>Media type of the link.</summary>
                    [Newtonsoft.Json.JsonPropertyAttribute("type")]
                    public virtual string Type { get; set; } 

                    /// <summary>URL of the image.</summary>
                    [Newtonsoft.Json.JsonPropertyAttribute("url")]
                    public virtual string Url { get; set; } 

                    /// <summary>The width, in pixels, of the linked resource.</summary>
                    [Newtonsoft.Json.JsonPropertyAttribute("width")]
                    public virtual System.Nullable<long> Width { get; set; } 

                }    

                /// <summary>The preview image for photos or videos.</summary>
                public class ImageData
                {
                    /// <summary>The height, in pixels, of the linked resource.</summary>
                    [Newtonsoft.Json.JsonPropertyAttribute("height")]
                    public virtual System.Nullable<long> Height { get; set; } 

                    /// <summary>Media type of the link.</summary>
                    [Newtonsoft.Json.JsonPropertyAttribute("type")]
                    public virtual string Type { get; set; } 

                    /// <summary>Image URL.</summary>
                    [Newtonsoft.Json.JsonPropertyAttribute("url")]
                    public virtual string Url { get; set; } 

                    /// <summary>The width, in pixels, of the linked resource.</summary>
                    [Newtonsoft.Json.JsonPropertyAttribute("width")]
                    public virtual System.Nullable<long> Width { get; set; } 

                }    

                public class ThumbnailsData
                {
                    /// <summary>Potential name of the thumbnail.</summary>
                    [Newtonsoft.Json.JsonPropertyAttribute("description")]
                    public virtual string Description { get; set; } 

                    /// <summary>Image resource.</summary>
                    [Newtonsoft.Json.JsonPropertyAttribute("image")]
                    public virtual ThumbnailsData.ImageData Image { get; set; } 

                    /// <summary>URL of the webpage containing the image.</summary>
                    [Newtonsoft.Json.JsonPropertyAttribute("url")]
                    public virtual string Url { get; set; } 

                    

                    /// <summary>Image resource.</summary>
                    public class ImageData
                    {
                        /// <summary>The height, in pixels, of the linked resource.</summary>
                        [Newtonsoft.Json.JsonPropertyAttribute("height")]
                        public virtual System.Nullable<long> Height { get; set; } 

                        /// <summary>Media type of the link.</summary>
                        [Newtonsoft.Json.JsonPropertyAttribute("type")]
                        public virtual string Type { get; set; } 

                        /// <summary>Image url.</summary>
                        [Newtonsoft.Json.JsonPropertyAttribute("url")]
                        public virtual string Url { get; set; } 

                        /// <summary>The width, in pixels, of the linked resource.</summary>
                        [Newtonsoft.Json.JsonPropertyAttribute("width")]
                        public virtual System.Nullable<long> Width { get; set; } 

                    }
                }
            }    

            /// <summary>People who +1'd this activity.</summary>
            public class PlusonersData
            {
                /// <summary>The URL for the collection of people who +1'd this activity.</summary>
                [Newtonsoft.Json.JsonPropertyAttribute("selfLink")]
                public virtual string SelfLink { get; set; } 

                /// <summary>Total number of people who +1'd this activity.</summary>
                [Newtonsoft.Json.JsonPropertyAttribute("totalItems")]
                public virtual System.Nullable<long> TotalItems { get; set; } 

            }    

            /// <summary>Comments in reply to this activity.</summary>
            public class RepliesData
            {
                /// <summary>The URL for the collection of comments in reply to this activity.</summary>
                [Newtonsoft.Json.JsonPropertyAttribute("selfLink")]
                public virtual string SelfLink { get; set; } 

                /// <summary>Total number of comments on this activity.</summary>
                [Newtonsoft.Json.JsonPropertyAttribute("totalItems")]
                public virtual System.Nullable<long> TotalItems { get; set; } 

            }    

            /// <summary>People who reshared this activity.</summary>
            public class ResharersData
            {
                /// <summary>The URL for the collection of resharers.</summary>
                [Newtonsoft.Json.JsonPropertyAttribute("selfLink")]
                public virtual string SelfLink { get; set; } 

                /// <summary>Total number of people who reshared this activity.</summary>
                [Newtonsoft.Json.JsonPropertyAttribute("totalItems")]
                public virtual System.Nullable<long> TotalItems { get; set; } 

            }
        }    

        /// <summary>The service provider that initially published this activity.</summary>
        public class ProviderData
        {
            /// <summary>Name of the service provider.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("title")]
            public virtual string Title { get; set; } 

        }
    }    

    public class ActivityFeed : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>ETag of this response for caching purposes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; } 

        /// <summary>The ID of this collection of activities. Deprecated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; } 

        /// <summary>The activities in this page of results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IList<Activity> Items { get; set; } 

        /// <summary>Identifies this resource as a collection of activities. Value: "plus#activityFeed".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; } 

        /// <summary>Link to the next page of activities.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextLink")]
        public virtual string NextLink { get; set; } 

        /// <summary>The continuation token, which is used to page through large result sets. Provide this value in a
        /// subsequent request to return the next page of results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; } 

        /// <summary>Link to this activity resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("selfLink")]
        public virtual string SelfLink { get; set; } 

        /// <summary>The title of this collection of activities, which is a truncated portion of the content.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; } 

        /// <summary>The time at which this collection of activities was last updated. Formatted as an RFC 3339
        /// timestamp.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updated")]
        public virtual string UpdatedRaw { get; set; }

        /// <summary><seealso cref="System.DateTime"/> representation of <see cref="UpdatedRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.Nullable<System.DateTime> Updated
        {
            get => Google.Apis.Util.Utilities.GetDateTimeFromString(UpdatedRaw);
            set => UpdatedRaw = Google.Apis.Util.Utilities.GetStringFromDateTime(value);
        }

    }    

    public class Comment : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The person who posted this comment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("actor")]
        public virtual Comment.ActorData Actor { get; set; } 

        /// <summary>ETag of this response for caching purposes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; } 

        /// <summary>The ID of this comment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; } 

        /// <summary>The activity this comment replied to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inReplyTo")]
        public virtual System.Collections.Generic.IList<Comment.InReplyToData> InReplyTo { get; set; } 

        /// <summary>Identifies this resource as a comment. Value: "plus#comment".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; } 

        /// <summary>The object of this comment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("object")]
        public virtual Comment.ObjectData Object__ { get; set; } 

        /// <summary>People who +1'd this comment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("plusoners")]
        public virtual Comment.PlusonersData Plusoners { get; set; } 

        /// <summary>The time at which this comment was initially published. Formatted as an RFC 3339
        /// timestamp.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("published")]
        public virtual string PublishedRaw { get; set; }

        /// <summary><seealso cref="System.DateTime"/> representation of <see cref="PublishedRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.Nullable<System.DateTime> Published
        {
            get => Google.Apis.Util.Utilities.GetDateTimeFromString(PublishedRaw);
            set => PublishedRaw = Google.Apis.Util.Utilities.GetStringFromDateTime(value);
        }

        /// <summary>Link to this comment resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("selfLink")]
        public virtual string SelfLink { get; set; } 

        /// <summary>The time at which this comment was last updated. Formatted as an RFC 3339 timestamp.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updated")]
        public virtual string UpdatedRaw { get; set; }

        /// <summary><seealso cref="System.DateTime"/> representation of <see cref="UpdatedRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.Nullable<System.DateTime> Updated
        {
            get => Google.Apis.Util.Utilities.GetDateTimeFromString(UpdatedRaw);
            set => UpdatedRaw = Google.Apis.Util.Utilities.GetStringFromDateTime(value);
        }

        /// <summary>This comment's verb, indicating what action was performed. Possible values are: - "post" - Publish
        /// content to the stream.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("verb")]
        public virtual string Verb { get; set; } 

        

        /// <summary>The person who posted this comment.</summary>
        public class ActorData
        {
            /// <summary>Actor info specific to particular clients.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("clientSpecificActorInfo")]
            public virtual ActorData.ClientSpecificActorInfoData ClientSpecificActorInfo { get; set; } 

            /// <summary>The name of this actor, suitable for display.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
            public virtual string DisplayName { get; set; } 

            /// <summary>The ID of the actor.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("id")]
            public virtual string Id { get; set; } 

            /// <summary>The image representation of this actor.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("image")]
            public virtual ActorData.ImageData Image { get; set; } 

            /// <summary>A link to the Person resource for this actor.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("url")]
            public virtual string Url { get; set; } 

            /// <summary>Verification status of actor.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("verification")]
            public virtual ActorData.VerificationData Verification { get; set; } 

            

            /// <summary>Actor info specific to particular clients.</summary>
            public class ClientSpecificActorInfoData
            {
                /// <summary>Actor info specific to YouTube clients.</summary>
                [Newtonsoft.Json.JsonPropertyAttribute("youtubeActorInfo")]
                public virtual ClientSpecificActorInfoData.YoutubeActorInfoData YoutubeActorInfo { get; set; } 

                

                /// <summary>Actor info specific to YouTube clients.</summary>
                public class YoutubeActorInfoData
                {
                    /// <summary>ID of the YouTube channel owned by the Actor.</summary>
                    [Newtonsoft.Json.JsonPropertyAttribute("channelId")]
                    public virtual string ChannelId { get; set; } 

                }
            }    

            /// <summary>The image representation of this actor.</summary>
            public class ImageData
            {
                /// <summary>The URL of the actor's profile photo. To resize the image and crop it to a square, append
                /// the query string ?sz=x, where x is the dimension in pixels of each side.</summary>
                [Newtonsoft.Json.JsonPropertyAttribute("url")]
                public virtual string Url { get; set; } 

            }    

            /// <summary>Verification status of actor.</summary>
            public class VerificationData
            {
                /// <summary>Verification for one-time or manual processes.</summary>
                [Newtonsoft.Json.JsonPropertyAttribute("adHocVerified")]
                public virtual string AdHocVerified { get; set; } 

            }
        }    

        public class InReplyToData
        {
            /// <summary>The ID of the activity.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("id")]
            public virtual string Id { get; set; } 

            /// <summary>The URL of the activity.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("url")]
            public virtual string Url { get; set; } 

        }    

        /// <summary>The object of this comment.</summary>
        public class ObjectData
        {
            /// <summary>The HTML-formatted content, suitable for display.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("content")]
            public virtual string Content { get; set; } 

            /// <summary>The object type of this comment. Possible values are: - "comment" - A comment in reply to an
            /// activity.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("objectType")]
            public virtual string ObjectType { get; set; } 

            /// <summary>The content (text) as provided by the author, stored without any HTML formatting. When creating
            /// or updating a comment, this value must be supplied as plain text in the request.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("originalContent")]
            public virtual string OriginalContent { get; set; } 

        }    

        /// <summary>People who +1'd this comment.</summary>
        public class PlusonersData
        {
            /// <summary>Total number of people who +1'd this comment.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("totalItems")]
            public virtual System.Nullable<long> TotalItems { get; set; } 

        }
    }    

    public class CommentFeed : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>ETag of this response for caching purposes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; } 

        /// <summary>The ID of this collection of comments.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; } 

        /// <summary>The comments in this page of results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IList<Comment> Items { get; set; } 

        /// <summary>Identifies this resource as a collection of comments. Value: "plus#commentFeed".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; } 

        /// <summary>Link to the next page of activities.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextLink")]
        public virtual string NextLink { get; set; } 

        /// <summary>The continuation token, which is used to page through large result sets. Provide this value in a
        /// subsequent request to return the next page of results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; } 

        /// <summary>The title of this collection of comments.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; } 

        /// <summary>The time at which this collection of comments was last updated. Formatted as an RFC 3339
        /// timestamp.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updated")]
        public virtual string UpdatedRaw { get; set; }

        /// <summary><seealso cref="System.DateTime"/> representation of <see cref="UpdatedRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.Nullable<System.DateTime> Updated
        {
            get => Google.Apis.Util.Utilities.GetDateTimeFromString(UpdatedRaw);
            set => UpdatedRaw = Google.Apis.Util.Utilities.GetStringFromDateTime(value);
        }

    }    

    public class PeopleFeed : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>ETag of this response for caching purposes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; } 

        /// <summary>The people in this page of results. Each item includes the id, displayName, image, and url for the
        /// person. To retrieve additional profile data, see the people.get method.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IList<Person> Items { get; set; } 

        /// <summary>Identifies this resource as a collection of people. Value: "plus#peopleFeed".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; } 

        /// <summary>The continuation token, which is used to page through large result sets. Provide this value in a
        /// subsequent request to return the next page of results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; } 

        /// <summary>Link to this resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("selfLink")]
        public virtual string SelfLink { get; set; } 

        /// <summary>The title of this collection of people.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; } 

        /// <summary>The total number of people available in this list. The number of people in a response might be
        /// smaller due to paging. This might not be set for all collections.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalItems")]
        public virtual System.Nullable<int> TotalItems { get; set; } 

    }    

    public class Person : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A short biography for this person.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("aboutMe")]
        public virtual string AboutMe { get; set; } 

        /// <summary>The age range of the person. Valid ranges are 17 or younger, 18 to 20, and 21 or older. Age is
        /// determined from the user's birthday using Western age reckoning.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ageRange")]
        public virtual Person.AgeRangeData AgeRange { get; set; } 

        /// <summary>The person's date of birth, represented as YYYY-MM-DD.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("birthday")]
        public virtual string Birthday { get; set; } 

        /// <summary>The "bragging rights" line of this person.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("braggingRights")]
        public virtual string BraggingRights { get; set; } 

        /// <summary>For followers who are visible, the number of people who have added this person or page to a
        /// circle.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("circledByCount")]
        public virtual System.Nullable<int> CircledByCount { get; set; } 

        /// <summary>The cover photo content.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cover")]
        public virtual Person.CoverData Cover { get; set; } 

        /// <summary>(this field is not currently used)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("currentLocation")]
        public virtual string CurrentLocation { get; set; } 

        /// <summary>The name of this person, which is suitable for display.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; } 

        /// <summary>The hosted domain name for the user's Google Apps account. For instance, example.com. The
        /// plus.profile.emails.read or email scope is needed to get this domain name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("domain")]
        public virtual string Domain { get; set; } 

        /// <summary>A list of email addresses that this person has, including their Google account email address, and
        /// the public verified email addresses on their Google+ profile. The plus.profile.emails.read scope is needed
        /// to retrieve these email addresses, or the email scope can be used to retrieve just the Google account email
        /// address.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("emails")]
        public virtual System.Collections.Generic.IList<Person.EmailsData> Emails { get; set; } 

        /// <summary>ETag of this response for caching purposes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; } 

        /// <summary>The person's gender. Possible values include, but are not limited to, the following values: -
        /// "male" - Male gender. - "female" - Female gender. - "other" - Other.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gender")]
        public virtual string Gender { get; set; } 

        /// <summary>The ID of this person.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; } 

        /// <summary>The representation of the person's profile photo.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("image")]
        public virtual Person.ImageData Image { get; set; } 

        /// <summary>Whether this user has signed up for Google+.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isPlusUser")]
        public virtual System.Nullable<bool> IsPlusUser { get; set; } 

        /// <summary>Identifies this resource as a person. Value: "plus#person".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; } 

        /// <summary>The user's preferred language for rendering.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("language")]
        public virtual string Language { get; set; } 

        /// <summary>An object representation of the individual components of a person's name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual Person.NameData Name { get; set; } 

        /// <summary>The nickname of this person.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nickname")]
        public virtual string Nickname { get; set; } 

        /// <summary>Type of person within Google+. Possible values include, but are not limited to, the following
        /// values: - "person" - represents an actual person. - "page" - represents a page.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("objectType")]
        public virtual string ObjectType { get; set; } 

        /// <summary>The occupation of this person.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("occupation")]
        public virtual string Occupation { get; set; } 

        /// <summary>A list of current or past organizations with which this person is associated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("organizations")]
        public virtual System.Collections.Generic.IList<Person.OrganizationsData> Organizations { get; set; } 

        /// <summary>A list of places where this person has lived.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("placesLived")]
        public virtual System.Collections.Generic.IList<Person.PlacesLivedData> PlacesLived { get; set; } 

        /// <summary>If a Google+ Page, the number of people who have +1'd this page.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("plusOneCount")]
        public virtual System.Nullable<int> PlusOneCount { get; set; } 

        /// <summary>The person's relationship status. Possible values include, but are not limited to, the following
        /// values: - "single" - Person is single. - "in_a_relationship" - Person is in a relationship. - "engaged" -
        /// Person is engaged. - "married" - Person is married. - "its_complicated" - The relationship is complicated. -
        /// "open_relationship" - Person is in an open relationship. - "widowed" - Person is widowed. -
        /// "in_domestic_partnership" - Person is in a domestic partnership. - "in_civil_union" - Person is in a civil
        /// union.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("relationshipStatus")]
        public virtual string RelationshipStatus { get; set; } 

        /// <summary>The person's skills.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("skills")]
        public virtual string Skills { get; set; } 

        /// <summary>The brief description (tagline) of this person.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tagline")]
        public virtual string Tagline { get; set; } 

        /// <summary>The URL of this person's profile.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("url")]
        public virtual string Url { get; set; } 

        /// <summary>A list of URLs for this person.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("urls")]
        public virtual System.Collections.Generic.IList<Person.UrlsData> Urls { get; set; } 

        /// <summary>Whether the person or Google+ Page has been verified.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("verified")]
        public virtual System.Nullable<bool> Verified { get; set; } 

        

        /// <summary>The age range of the person. Valid ranges are 17 or younger, 18 to 20, and 21 or older. Age is
        /// determined from the user's birthday using Western age reckoning.</summary>
        public class AgeRangeData
        {
            /// <summary>The age range's upper bound, if any. Possible values include, but are not limited to, the
            /// following: - "17" - for age 17 - "20" - for age 20</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("max")]
            public virtual System.Nullable<int> Max { get; set; } 

            /// <summary>The age range's lower bound, if any. Possible values include, but are not limited to, the
            /// following: - "21" - for age 21 - "18" - for age 18</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("min")]
            public virtual System.Nullable<int> Min { get; set; } 

        }    

        /// <summary>The cover photo content.</summary>
        public class CoverData
        {
            /// <summary>Extra information about the cover photo.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("coverInfo")]
            public virtual CoverData.CoverInfoData CoverInfo { get; set; } 

            /// <summary>The person's primary cover image.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("coverPhoto")]
            public virtual CoverData.CoverPhotoData CoverPhoto { get; set; } 

            /// <summary>The layout of the cover art. Possible values include, but are not limited to, the following
            /// values: - "banner" - One large image banner.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("layout")]
            public virtual string Layout { get; set; } 

            

            /// <summary>Extra information about the cover photo.</summary>
            public class CoverInfoData
            {
                /// <summary>The difference between the left position of the cover image and the actual displayed cover
                /// image. Only valid for banner layout.</summary>
                [Newtonsoft.Json.JsonPropertyAttribute("leftImageOffset")]
                public virtual System.Nullable<int> LeftImageOffset { get; set; } 

                /// <summary>The difference between the top position of the cover image and the actual displayed cover
                /// image. Only valid for banner layout.</summary>
                [Newtonsoft.Json.JsonPropertyAttribute("topImageOffset")]
                public virtual System.Nullable<int> TopImageOffset { get; set; } 

            }    

            /// <summary>The person's primary cover image.</summary>
            public class CoverPhotoData
            {
                /// <summary>The height of the image.</summary>
                [Newtonsoft.Json.JsonPropertyAttribute("height")]
                public virtual System.Nullable<int> Height { get; set; } 

                /// <summary>The URL of the image.</summary>
                [Newtonsoft.Json.JsonPropertyAttribute("url")]
                public virtual string Url { get; set; } 

                /// <summary>The width of the image.</summary>
                [Newtonsoft.Json.JsonPropertyAttribute("width")]
                public virtual System.Nullable<int> Width { get; set; } 

            }
        }    

        public class EmailsData
        {
            /// <summary>The type of address. Possible values include, but are not limited to, the following values: -
            /// "account" - Google account email address. - "home" - Home email address. - "work" - Work email address.
            /// - "other" - Other.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("type")]
            public virtual string Type { get; set; } 

            /// <summary>The email address.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("value")]
            public virtual string Value { get; set; } 

        }    

        /// <summary>The representation of the person's profile photo.</summary>
        public class ImageData
        {
            /// <summary>Whether the person's profile photo is the default one</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("isDefault")]
            public virtual System.Nullable<bool> IsDefault { get; set; } 

            /// <summary>The URL of the person's profile photo. To resize the image and crop it to a square, append the
            /// query string ?sz=x, where x is the dimension in pixels of each side.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("url")]
            public virtual string Url { get; set; } 

        }    

        /// <summary>An object representation of the individual components of a person's name.</summary>
        public class NameData
        {
            /// <summary>The family name (last name) of this person.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("familyName")]
            public virtual string FamilyName { get; set; } 

            /// <summary>The full name of this person, including middle names, suffixes, etc.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("formatted")]
            public virtual string Formatted { get; set; } 

            /// <summary>The given name (first name) of this person.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("givenName")]
            public virtual string GivenName { get; set; } 

            /// <summary>The honorific prefixes (such as "Dr." or "Mrs.") for this person.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("honorificPrefix")]
            public virtual string HonorificPrefix { get; set; } 

            /// <summary>The honorific suffixes (such as "Jr.") for this person.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("honorificSuffix")]
            public virtual string HonorificSuffix { get; set; } 

            /// <summary>The middle name of this person.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("middleName")]
            public virtual string MiddleName { get; set; } 

        }    

        public class OrganizationsData
        {
            /// <summary>The department within the organization. Deprecated.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("department")]
            public virtual string Department { get; set; } 

            /// <summary>A short description of the person's role in this organization. Deprecated.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("description")]
            public virtual string Description { get; set; } 

            /// <summary>The date that the person left this organization.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("endDate")]
            public virtual string EndDate { get; set; } 

            /// <summary>The location of this organization. Deprecated.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("location")]
            public virtual string Location { get; set; } 

            /// <summary>The name of the organization.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("name")]
            public virtual string Name { get; set; } 

            /// <summary>If "true", indicates this organization is the person's primary one, which is typically
            /// interpreted as the current one.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("primary")]
            public virtual System.Nullable<bool> Primary { get; set; } 

            /// <summary>The date that the person joined this organization.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("startDate")]
            public virtual string StartDate { get; set; } 

            /// <summary>The person's job title or role within the organization.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("title")]
            public virtual string Title { get; set; } 

            /// <summary>The type of organization. Possible values include, but are not limited to, the following
            /// values: - "work" - Work. - "school" - School.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("type")]
            public virtual string Type { get; set; } 

        }    

        public class PlacesLivedData
        {
            /// <summary>If "true", this place of residence is this person's primary residence.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("primary")]
            public virtual System.Nullable<bool> Primary { get; set; } 

            /// <summary>A place where this person has lived. For example: "Seattle, WA", "Near Toronto".</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("value")]
            public virtual string Value { get; set; } 

        }    

        public class UrlsData
        {
            /// <summary>The label of the URL.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("label")]
            public virtual string Label { get; set; } 

            /// <summary>The type of URL. Possible values include, but are not limited to, the following values: -
            /// "otherProfile" - URL for another profile. - "contributor" - URL to a site for which this person is a
            /// contributor. - "website" - URL for this Google+ Page's primary website. - "other" - Other URL.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("type")]
            public virtual string Type { get; set; } 

            /// <summary>The URL value.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("value")]
            public virtual string Value { get; set; } 

        }
    }    

    public class Place : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The physical address of the place.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("address")]
        public virtual Place.AddressData Address { get; set; } 

        /// <summary>The display name of the place.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; } 

        /// <summary>The id of the place.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; } 

        /// <summary>Identifies this resource as a place. Value: "plus#place".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; } 

        /// <summary>The position of the place.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("position")]
        public virtual Place.PositionData Position { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
        

        /// <summary>The physical address of the place.</summary>
        public class AddressData
        {
            /// <summary>The formatted address for display.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("formatted")]
            public virtual string Formatted { get; set; } 

        }    

        /// <summary>The position of the place.</summary>
        public class PositionData
        {
            /// <summary>The latitude of this position.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("latitude")]
            public virtual System.Nullable<double> Latitude { get; set; } 

            /// <summary>The longitude of this position.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("longitude")]
            public virtual System.Nullable<double> Longitude { get; set; } 

        }
    }    

    public class PlusAclentryResource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A descriptive name for this entry. Suitable for display.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; } 

        /// <summary>The ID of the entry. For entries of type "person" or "circle", this is the ID of the resource. For
        /// other types, this property is not set.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; } 

        /// <summary>The type of entry describing to whom access is granted. Possible values are: - "person" - Access to
        /// an individual. - "circle" - Access to members of a circle. - "myCircles" - Access to members of all the
        /// person's circles. - "extendedCircles" - Access to members of all the person's circles, plus all of the
        /// people in their circles. - "domain" - Access to members of the person's Google Apps domain. - "public" -
        /// Access to anyone on the web.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
