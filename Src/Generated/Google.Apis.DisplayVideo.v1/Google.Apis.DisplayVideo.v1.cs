// Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file except in compliance with
// the License. You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software distributed under the License is distributed on
// an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the License for the
// specific language governing permissions and limitations under the License.

// Generated code. DO NOT EDIT!

namespace Google.Apis.DisplayVideo.v1
{
    /// <summary>The DisplayVideo Service.</summary>
    public class DisplayVideoService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public DisplayVideoService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public DisplayVideoService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Advertisers = new AdvertisersResource(this);
            CombinedAudiences = new CombinedAudiencesResource(this);
            CustomBiddingAlgorithms = new CustomBiddingAlgorithmsResource(this);
            CustomLists = new CustomListsResource(this);
            FirstAndThirdPartyAudiences = new FirstAndThirdPartyAudiencesResource(this);
            FloodlightGroups = new FloodlightGroupsResource(this);
            GoogleAudiences = new GoogleAudiencesResource(this);
            InventorySourceGroups = new InventorySourceGroupsResource(this);
            InventorySources = new InventorySourcesResource(this);
            Media = new MediaResource(this);
            Partners = new PartnersResource(this);
            Sdfdownloadtasks = new SdfdownloadtasksResource(this);
            TargetingTypes = new TargetingTypesResource(this);
            Users = new UsersResource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "displayvideo";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri =>
        #if NETSTANDARD1_3 || NETSTANDARD2_0 || NET45
            BaseUriOverride ?? "https://displayvideo.googleapis.com/";
        #else
            "https://displayvideo.googleapis.com/";
        #endif

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        #if !NET40
        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri => "https://displayvideo.googleapis.com/batch";

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";
        #endif

        /// <summary>Available OAuth 2.0 scopes for use with the Display & Video 360 API.</summary>
        public class Scope
        {
            /// <summary>Create, see, edit, and permanently delete your Display & Video 360 entities and
            /// reports</summary>
            public static string DisplayVideo = "https://www.googleapis.com/auth/display-video";

            /// <summary>Create, see, and edit Display & Video 360 Campaign entities and see billing invoices</summary>
            public static string DisplayVideoMediaplanning = "https://www.googleapis.com/auth/display-video-mediaplanning";

            /// <summary>New Service: https://www.googleapis.com/auth/display-video-user-management</summary>
            public static string DisplayVideoUserManagement = "https://www.googleapis.com/auth/display-video-user-management";

            /// <summary>View and manage your reports in DoubleClick Bid Manager</summary>
            public static string Doubleclickbidmanager = "https://www.googleapis.com/auth/doubleclickbidmanager";

        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Display & Video 360 API.</summary>
        public static class ScopeConstants
        {
            /// <summary>Create, see, edit, and permanently delete your Display & Video 360 entities and
            /// reports</summary>
            public const string DisplayVideo = "https://www.googleapis.com/auth/display-video";

            /// <summary>Create, see, and edit Display & Video 360 Campaign entities and see billing invoices</summary>
            public const string DisplayVideoMediaplanning = "https://www.googleapis.com/auth/display-video-mediaplanning";

            /// <summary>New Service: https://www.googleapis.com/auth/display-video-user-management</summary>
            public const string DisplayVideoUserManagement = "https://www.googleapis.com/auth/display-video-user-management";

            /// <summary>View and manage your reports in DoubleClick Bid Manager</summary>
            public const string Doubleclickbidmanager = "https://www.googleapis.com/auth/doubleclickbidmanager";

        }



        /// <summary>Gets the Advertisers resource.</summary>
        public virtual AdvertisersResource Advertisers { get; }

        /// <summary>Gets the CombinedAudiences resource.</summary>
        public virtual CombinedAudiencesResource CombinedAudiences { get; }

        /// <summary>Gets the CustomBiddingAlgorithms resource.</summary>
        public virtual CustomBiddingAlgorithmsResource CustomBiddingAlgorithms { get; }

        /// <summary>Gets the CustomLists resource.</summary>
        public virtual CustomListsResource CustomLists { get; }

        /// <summary>Gets the FirstAndThirdPartyAudiences resource.</summary>
        public virtual FirstAndThirdPartyAudiencesResource FirstAndThirdPartyAudiences { get; }

        /// <summary>Gets the FloodlightGroups resource.</summary>
        public virtual FloodlightGroupsResource FloodlightGroups { get; }

        /// <summary>Gets the GoogleAudiences resource.</summary>
        public virtual GoogleAudiencesResource GoogleAudiences { get; }

        /// <summary>Gets the InventorySourceGroups resource.</summary>
        public virtual InventorySourceGroupsResource InventorySourceGroups { get; }

        /// <summary>Gets the InventorySources resource.</summary>
        public virtual InventorySourcesResource InventorySources { get; }

        /// <summary>Gets the Media resource.</summary>
        public virtual MediaResource Media { get; }

        /// <summary>Gets the Partners resource.</summary>
        public virtual PartnersResource Partners { get; }

        /// <summary>Gets the Sdfdownloadtasks resource.</summary>
        public virtual SdfdownloadtasksResource Sdfdownloadtasks { get; }

        /// <summary>Gets the TargetingTypes resource.</summary>
        public virtual TargetingTypesResource TargetingTypes { get; }

        /// <summary>Gets the Users resource.</summary>
        public virtual UsersResource Users { get; }
    }

    /// <summary>A base abstract class for DisplayVideo requests.</summary>
    public abstract class DisplayVideoBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new DisplayVideoBaseServiceRequest instance.</summary>
        protected DisplayVideoBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
        {
        }

        /// <summary>V1 error format.</summary>
        [Google.Apis.Util.RequestParameterAttribute("$.xgafv", Google.Apis.Util.RequestParameterType.Query)]
        public virtual System.Nullable<XgafvEnum> Xgafv { get; set; }

        /// <summary>V1 error format.</summary>
        public enum XgafvEnum
        {
            /// <summary>v1 error format</summary>
            [Google.Apis.Util.StringValueAttribute("1")]
            Value1,
            /// <summary>v2 error format</summary>
            [Google.Apis.Util.StringValueAttribute("2")]
            Value2,
        }

        /// <summary>OAuth access token.</summary>
        [Google.Apis.Util.RequestParameterAttribute("access_token", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string AccessToken { get; set; }

        /// <summary>Data format for response.</summary>
        [Google.Apis.Util.RequestParameterAttribute("alt", Google.Apis.Util.RequestParameterType.Query)]
        public virtual System.Nullable<AltEnum> Alt { get; set; }

        /// <summary>Data format for response.</summary>
        public enum AltEnum
        {
            /// <summary>Responses with Content-Type of application/json</summary>
            [Google.Apis.Util.StringValueAttribute("json")]
            Json,
            /// <summary>Media download with context-dependent Content-Type</summary>
            [Google.Apis.Util.StringValueAttribute("media")]
            Media,
            /// <summary>Responses with Content-Type of application/x-protobuf</summary>
            [Google.Apis.Util.StringValueAttribute("proto")]
            Proto,
        }

        /// <summary>JSONP</summary>
        [Google.Apis.Util.RequestParameterAttribute("callback", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string Callback { get; set; }

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

        /// <summary>Available to use for quota purposes for server-side applications. Can be any arbitrary string
        /// assigned to a user, but should not exceed 40 characters.</summary>
        [Google.Apis.Util.RequestParameterAttribute("quotaUser", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string QuotaUser { get; set; }

        /// <summary>Legacy upload protocol for media (e.g. "media", "multipart").</summary>
        [Google.Apis.Util.RequestParameterAttribute("uploadType", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string UploadType { get; set; }

        /// <summary>Upload protocol for media (e.g. "raw", "multipart").</summary>
        [Google.Apis.Util.RequestParameterAttribute("upload_protocol", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string UploadProtocol { get; set; }

        /// <summary>Initializes DisplayVideo parameter list.</summary>
        protected override void InitParameters()
        {
            base.InitParameters();

            RequestParameters.Add("$.xgafv", new Google.Apis.Discovery.Parameter
            {
                Name = "$.xgafv",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = null,
                Pattern = null,
            });
            RequestParameters.Add("access_token", new Google.Apis.Discovery.Parameter
            {
                Name = "access_token",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = null,
                Pattern = null,
            });
            RequestParameters.Add("alt", new Google.Apis.Discovery.Parameter
            {
                Name = "alt",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = "json",
                Pattern = null,
            });
            RequestParameters.Add("callback", new Google.Apis.Discovery.Parameter
            {
                Name = "callback",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = null,
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
            RequestParameters.Add("uploadType", new Google.Apis.Discovery.Parameter
            {
                Name = "uploadType",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = null,
                Pattern = null,
            });
            RequestParameters.Add("upload_protocol", new Google.Apis.Discovery.Parameter
            {
                Name = "upload_protocol",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = null,
                Pattern = null,
            });
        }
    }

    /// <summary>The "advertisers" collection of methods.</summary>
    public class AdvertisersResource
    {
        private const string Resource = "advertisers";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public AdvertisersResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
            Assets = new AssetsResource(service);
            Campaigns = new CampaignsResource(service);
            Channels = new ChannelsResource(service);
            Creatives = new CreativesResource(service);
            InsertionOrders = new InsertionOrdersResource(service);
            LineItems = new LineItemsResource(service);
            LocationLists = new LocationListsResource(service);
            NegativeKeywordLists = new NegativeKeywordListsResource(service);
            TargetingTypes = new TargetingTypesResource(service);

        }

        /// <summary>Gets the Assets resource.</summary>
        public virtual AssetsResource Assets { get; }

        /// <summary>The "assets" collection of methods.</summary>
        public class AssetsResource
        {
            private const string Resource = "assets";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public AssetsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;

            }


            /// <summary>Uploads an asset. Returns the ID of the newly uploaded asset if successful. The asset file size
            /// should be no more than 10 MB for images, 200 MB for ZIP files, and 1 GB for videos.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="advertiserId">Required. The ID of the advertiser this asset belongs to.</param>
            public virtual UploadRequest Upload(Google.Apis.DisplayVideo.v1.Data.CreateAssetRequest body, long advertiserId)
            {
                return new UploadRequest(service, body, advertiserId);
            }

            /// <summary>Uploads an asset. Returns the ID of the newly uploaded asset if successful. The asset file size
            /// should be no more than 10 MB for images, 200 MB for ZIP files, and 1 GB for videos.</summary>
            public class UploadRequest : DisplayVideoBaseServiceRequest<Google.Apis.DisplayVideo.v1.Data.CreateAssetResponse>
            {
                /// <summary>Constructs a new Upload request.</summary>
                public UploadRequest(Google.Apis.Services.IClientService service, Google.Apis.DisplayVideo.v1.Data.CreateAssetRequest body, long advertiserId) : base(service)
                {
                    AdvertiserId = advertiserId;
                    Body = body;
                    InitParameters();
                }


                /// <summary>Required. The ID of the advertiser this asset belongs to.</summary>
                [Google.Apis.Util.RequestParameterAttribute("advertiserId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual long AdvertiserId { get; private set; }


                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.DisplayVideo.v1.Data.CreateAssetRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "upload";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/advertisers/{+advertiserId}/assets";

                /// <summary>Initializes Upload parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();

                    RequestParameters.Add("advertiserId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "advertiserId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^[^/]+$",
                    });
                }

            }

            /// <summary>Uploads an asset. Returns the ID of the newly uploaded asset if successful. The asset file size
            /// should be no more than 10 MB for images, 200 MB for ZIP files, and 1 GB for videos.</summary>
            /// <remarks>
            /// Considerations regarding <paramref name="stream"/>:
            /// <list type="bullet">
            /// <item><description>
            /// If <paramref name="stream"/> is seekable, then the stream position will be reset to
            /// <c>0</c> before reading commences. If <paramref name="stream"/> is not
            /// seekable, then it will be read from its current position.
            /// </description></item>
            /// <item><description>
            /// Caller is responsible for maintaining the <paramref name="stream"/> open until the
            /// upload is completed.
            /// </description></item>
            /// <item><description>
            /// Caller is responsible for closing the <paramref name="stream"/>.
            /// </description></item>
            /// </list>
            /// </remarks>
            /// <param name="body">The body of the request.</param>
            /// <param name="advertiserId">Required. The ID of the advertiser this asset belongs to.</param>
            /// <param name="stream">The stream to upload. See remarks for further information.</param>
            /// <param name="contentType">The content type of the stream to upload.</param>
            public virtual UploadMediaUpload Upload(Google.Apis.DisplayVideo.v1.Data.CreateAssetRequest body, long advertiserId, System.IO.Stream stream, string contentType)
            {
                return new UploadMediaUpload(service, body, advertiserId, stream, contentType);
            }

            /// <summary>Upload media upload which supports resumable upload.</summary>
            public class UploadMediaUpload : Google.Apis.Upload.ResumableUpload<Google.Apis.DisplayVideo.v1.Data.CreateAssetRequest, Google.Apis.DisplayVideo.v1.Data.CreateAssetResponse>
            {

                /// <summary>V1 error format.</summary>
                [Google.Apis.Util.RequestParameterAttribute("$.xgafv", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<XgafvEnum> Xgafv { get; set; }

                /// <summary>V1 error format.</summary>
                public enum XgafvEnum
                {
                    /// <summary>v1 error format</summary>
                    [Google.Apis.Util.StringValueAttribute("1")]
                    Value1,
                    /// <summary>v2 error format</summary>
                    [Google.Apis.Util.StringValueAttribute("2")]
                    Value2,
                }

                /// <summary>OAuth access token.</summary>
                [Google.Apis.Util.RequestParameterAttribute("access_token", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string AccessToken { get; set; }

                /// <summary>Data format for response.</summary>
                [Google.Apis.Util.RequestParameterAttribute("alt", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<AltEnum> Alt { get; set; }

                /// <summary>Data format for response.</summary>
                public enum AltEnum
                {
                    /// <summary>Responses with Content-Type of application/json</summary>
                    [Google.Apis.Util.StringValueAttribute("json")]
                    Json,
                    /// <summary>Media download with context-dependent Content-Type</summary>
                    [Google.Apis.Util.StringValueAttribute("media")]
                    Media,
                    /// <summary>Responses with Content-Type of application/x-protobuf</summary>
                    [Google.Apis.Util.StringValueAttribute("proto")]
                    Proto,
                }

                /// <summary>JSONP</summary>
                [Google.Apis.Util.RequestParameterAttribute("callback", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Callback { get; set; }

                /// <summary>Selector specifying which fields to include in a partial response.</summary>
                [Google.Apis.Util.RequestParameterAttribute("fields", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Fields { get; set; }

                /// <summary>API key. Your API key identifies your project and provides you with API access, quota, and
                /// reports. Required unless you provide an OAuth 2.0 token.</summary>
                [Google.Apis.Util.RequestParameterAttribute("key", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Key { get; set; }

                /// <summary>OAuth 2.0 token for the current user.</summary>
                [Google.Apis.Util.RequestParameterAttribute("oauth_token", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string OauthToken { get; set; }

                /// <summary>Returns response with indentations and line breaks.</summary>
                [Google.Apis.Util.RequestParameterAttribute("prettyPrint", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<bool> PrettyPrint { get; set; }

                /// <summary>Available to use for quota purposes for server-side applications. Can be any arbitrary
                /// string assigned to a user, but should not exceed 40 characters.</summary>
                [Google.Apis.Util.RequestParameterAttribute("quotaUser", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string QuotaUser { get; set; }

                /// <summary>Legacy upload protocol for media (e.g. "media", "multipart").</summary>
                [Google.Apis.Util.RequestParameterAttribute("uploadType", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string UploadType { get; set; }

                /// <summary>Upload protocol for media (e.g. "raw", "multipart").</summary>
                [Google.Apis.Util.RequestParameterAttribute("upload_protocol", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string UploadProtocol { get; set; }


                /// <summary>Required. The ID of the advertiser this asset belongs to.</summary>
                [Google.Apis.Util.RequestParameterAttribute("advertiserId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual long AdvertiserId { get; private set; }

                /// <summary>Constructs a new Upload media upload instance.</summary>
                /// <remarks>
                /// Considerations regarding <paramref name="stream"/>:
                /// <list type="bullet">
                /// <item><description>
                /// If <paramref name="stream"/> is seekable, then the stream position will be reset to
                /// <c>0</c> before reading commences. If <paramref name="stream"/> is not
                /// seekable, then it will be read from its current position.
                /// </description></item>
                /// <item><description>
                /// Caller is responsible for maintaining the <paramref name="stream"/> open until the
                /// upload is completed.
                /// </description></item>
                /// <item><description>
                /// Caller is responsible for closing the <paramref name="stream"/>.
                /// </description></item>
                /// </list>
                /// </remarks>
                public UploadMediaUpload(Google.Apis.Services.IClientService service, Google.Apis.DisplayVideo.v1.Data.CreateAssetRequest body, long
                 advertiserId, System.IO.Stream stream, string contentType)
                    : base(service, string.Format("/{0}/{1}{2}", "upload", service.BasePath, "v1/advertisers/{+advertiserId}/assets"), "POST", stream, contentType)
                {
                    AdvertiserId = advertiserId;
                    Body = body;
                }
            }
        }
        /// <summary>Gets the Campaigns resource.</summary>
        public virtual CampaignsResource Campaigns { get; }

        /// <summary>The "campaigns" collection of methods.</summary>
        public class CampaignsResource
        {
            private const string Resource = "campaigns";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public CampaignsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;

            }


            /// <summary>Creates a new campaign. Returns the newly created campaign if successful.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="advertiserId">Output only. The unique ID of the advertiser the campaign belongs to.</param>
            public virtual CreateRequest Create(Google.Apis.DisplayVideo.v1.Data.Campaign body, long advertiserId)
            {
                return new CreateRequest(service, body, advertiserId);
            }

            /// <summary>Creates a new campaign. Returns the newly created campaign if successful.</summary>
            public class CreateRequest : DisplayVideoBaseServiceRequest<Google.Apis.DisplayVideo.v1.Data.Campaign>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.DisplayVideo.v1.Data.Campaign body, long advertiserId) : base(service)
                {
                    AdvertiserId = advertiserId;
                    Body = body;
                    InitParameters();
                }


                /// <summary>Output only. The unique ID of the advertiser the campaign belongs to.</summary>
                [Google.Apis.Util.RequestParameterAttribute("advertiserId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual long AdvertiserId { get; private set; }


                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.DisplayVideo.v1.Data.Campaign Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/advertisers/{+advertiserId}/campaigns";

                /// <summary>Initializes Create parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();

                    RequestParameters.Add("advertiserId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "advertiserId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^[^/]+$",
                    });
                }

            }

            /// <summary>Permanently deletes a campaign. A deleted campaign cannot be recovered. The campaign should be
            /// archived first, i.e. set entity_status to `ENTITY_STATUS_ARCHIVED`, to be able to delete it.</summary>
            /// <param name="advertiserId">The ID of the advertiser this campaign belongs to.</param>
            /// <param
            /// name="campaignId">The ID of the campaign we need to delete.</param>
            public virtual DeleteRequest Delete(long advertiserId, long campaignId)
            {
                return new DeleteRequest(service, advertiserId, campaignId);
            }

            /// <summary>Permanently deletes a campaign. A deleted campaign cannot be recovered. The campaign should be
            /// archived first, i.e. set entity_status to `ENTITY_STATUS_ARCHIVED`, to be able to delete it.</summary>
            public class DeleteRequest : DisplayVideoBaseServiceRequest<Google.Apis.DisplayVideo.v1.Data.Empty>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, long advertiserId, long campaignId) : base(service)
                {
                    AdvertiserId = advertiserId;
                    CampaignId = campaignId;
                    InitParameters();
                }


                /// <summary>The ID of the advertiser this campaign belongs to.</summary>
                [Google.Apis.Util.RequestParameterAttribute("advertiserId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual long AdvertiserId { get; private set; }

                /// <summary>The ID of the campaign we need to delete.</summary>
                [Google.Apis.Util.RequestParameterAttribute("campaignId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual long CampaignId { get; private set; }


                /// <summary>Gets the method name.</summary>
                public override string MethodName => "delete";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "DELETE";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/advertisers/{+advertiserId}/campaigns/{+campaignId}";

                /// <summary>Initializes Delete parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();

                    RequestParameters.Add("advertiserId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "advertiserId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^[^/]+$",
                    });
                    RequestParameters.Add("campaignId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "campaignId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^[^/]+$",
                    });
                }

            }

            /// <summary>Gets a campaign.</summary>
            /// <param name="advertiserId">Required. The ID of the advertiser this campaign belongs to.</param>
            /// <param
            /// name="campaignId">Required. The ID of the campaign to fetch.</param>
            public virtual GetRequest Get(long advertiserId, long campaignId)
            {
                return new GetRequest(service, advertiserId, campaignId);
            }

            /// <summary>Gets a campaign.</summary>
            public class GetRequest : DisplayVideoBaseServiceRequest<Google.Apis.DisplayVideo.v1.Data.Campaign>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, long advertiserId, long campaignId) : base(service)
                {
                    AdvertiserId = advertiserId;
                    CampaignId = campaignId;
                    InitParameters();
                }


                /// <summary>Required. The ID of the advertiser this campaign belongs to.</summary>
                [Google.Apis.Util.RequestParameterAttribute("advertiserId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual long AdvertiserId { get; private set; }

                /// <summary>Required. The ID of the campaign to fetch.</summary>
                [Google.Apis.Util.RequestParameterAttribute("campaignId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual long CampaignId { get; private set; }


                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/advertisers/{+advertiserId}/campaigns/{+campaignId}";

                /// <summary>Initializes Get parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();

                    RequestParameters.Add("advertiserId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "advertiserId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^[^/]+$",
                    });
                    RequestParameters.Add("campaignId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "campaignId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^[^/]+$",
                    });
                }

            }

            /// <summary>Lists campaigns in an advertiser. The order is defined by the order_by parameter. If a filter
            /// by entity_status is not specified, campaigns with `ENTITY_STATUS_ARCHIVED` will not be included in the
            /// results.</summary>
            /// <param name="advertiserId">The ID of the advertiser to list campaigns for.</param>
            public virtual ListRequest List(long advertiserId)
            {
                return new ListRequest(service, advertiserId);
            }

            /// <summary>Lists campaigns in an advertiser. The order is defined by the order_by parameter. If a filter
            /// by entity_status is not specified, campaigns with `ENTITY_STATUS_ARCHIVED` will not be included in the
            /// results.</summary>
            public class ListRequest : DisplayVideoBaseServiceRequest<Google.Apis.DisplayVideo.v1.Data.ListCampaignsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, long advertiserId) : base(service)
                {
                    AdvertiserId = advertiserId;
                    InitParameters();
                }


                /// <summary>The ID of the advertiser to list campaigns for.</summary>
                [Google.Apis.Util.RequestParameterAttribute("advertiserId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual long AdvertiserId { get; private set; }

                /// <summary>Allows filtering by campaign properties. Supported syntax: * Filter expressions are made up
                /// of one or more restrictions. * Restrictions can be combined by `AND` or `OR` logical operators. A
                /// sequence of restrictions implicitly uses `AND`. * A restriction has the form of `{field} {operator}
                /// {value}`. * The operator must be `EQUALS (=)`. * Supported fields: - `campaignId` - `displayName` -
                /// `entityStatus` Examples: * All `ENTITY_STATUS_ACTIVE` or `ENTITY_STATUS_PAUSED` campaigns under an
                /// advertiser: `(entityStatus="ENTITY_STATUS_ACTIVE" OR entityStatus="ENTITY_STATUS_PAUSED")` The
                /// length of this field should be no more than 500 characters.</summary>
                [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Filter { get; set; }

                /// <summary>Field by which to sort the list. Acceptable values are: * `displayName` (default) *
                /// `entityStatus` The default sorting order is ascending. To specify descending order for a field, a
                /// suffix "desc" should be added to the field name. Example: `displayName desc`.</summary>
                [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string OrderBy { get; set; }

                /// <summary>Requested page size. Must be between `1` and `100`. If unspecified will default to
                /// `100`.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>A token identifying a page of results the server should return. Typically, this is the
                /// value of next_page_token returned from the previous call to `ListCampaigns` method. If not
                /// specified, the first page of results will be returned.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }


                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/advertisers/{+advertiserId}/campaigns";

                /// <summary>Initializes List parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();

                    RequestParameters.Add("advertiserId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "advertiserId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^[^/]+$",
                    });
                    RequestParameters.Add("filter", new Google.Apis.Discovery.Parameter
                    {
                        Name = "filter",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
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
                    RequestParameters.Add("pageSize", new Google.Apis.Discovery.Parameter
                    {
                        Name = "pageSize",
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

            /// <summary>Updates an existing campaign. Returns the updated campaign if successful.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="advertiserId">Output only. The unique ID of the advertiser the campaign belongs to.</param>
            ///
            /// <param name="campaignId">Output only. The unique ID of the campaign. Assigned by the system.</param>
            public virtual PatchRequest Patch(Google.Apis.DisplayVideo.v1.Data.Campaign body, long advertiserId, long campaignId)
            {
                return new PatchRequest(service, body, advertiserId, campaignId);
            }

            /// <summary>Updates an existing campaign. Returns the updated campaign if successful.</summary>
            public class PatchRequest : DisplayVideoBaseServiceRequest<Google.Apis.DisplayVideo.v1.Data.Campaign>
            {
                /// <summary>Constructs a new Patch request.</summary>
                public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.DisplayVideo.v1.Data.Campaign body, long advertiserId, long campaignId) : base(service)
                {
                    AdvertiserId = advertiserId;
                    CampaignId = campaignId;
                    Body = body;
                    InitParameters();
                }


                /// <summary>Output only. The unique ID of the advertiser the campaign belongs to.</summary>
                [Google.Apis.Util.RequestParameterAttribute("advertiserId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual long AdvertiserId { get; private set; }

                /// <summary>Output only. The unique ID of the campaign. Assigned by the system.</summary>
                [Google.Apis.Util.RequestParameterAttribute("campaignId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual long CampaignId { get; private set; }

                /// <summary>Required. The mask to control which fields to update.</summary>
                [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                public virtual object UpdateMask { get; set; }


                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.DisplayVideo.v1.Data.Campaign Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "patch";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PATCH";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/advertisers/{+advertiserId}/campaigns/{+campaignId}";

                /// <summary>Initializes Patch parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();

                    RequestParameters.Add("advertiserId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "advertiserId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^[^/]+$",
                    });
                    RequestParameters.Add("campaignId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "campaignId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^[^/]+$",
                    });
                    RequestParameters.Add("updateMask", new Google.Apis.Discovery.Parameter
                    {
                        Name = "updateMask",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }

            }
        }
        /// <summary>Gets the Channels resource.</summary>
        public virtual ChannelsResource Channels { get; }

        /// <summary>The "channels" collection of methods.</summary>
        public class ChannelsResource
        {
            private const string Resource = "channels";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public ChannelsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
                Sites = new SitesResource(service);

            }

            /// <summary>Gets the Sites resource.</summary>
            public virtual SitesResource Sites { get; }

            /// <summary>The "sites" collection of methods.</summary>
            public class SitesResource
            {
                private const string Resource = "sites";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public SitesResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;

                }


                /// <summary>Bulk edits sites under a single channel. The operation will delete the sites provided in
                /// BulkEditSitesRequest.deleted_sites and then create the sites provided in
                /// BulkEditSitesRequest.created_sites.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="advertiserId">The ID of the advertiser that owns the parent channel.</param>
                /// <param
                /// name="channelId">Required. The ID of the parent channel to which the sites belong.</param>
                public virtual BulkEditRequest BulkEdit(Google.Apis.DisplayVideo.v1.Data.BulkEditSitesRequest body, long advertiserId, long channelId)
                {
                    return new BulkEditRequest(service, body, advertiserId, channelId);
                }

                /// <summary>Bulk edits sites under a single channel. The operation will delete the sites provided in
                /// BulkEditSitesRequest.deleted_sites and then create the sites provided in
                /// BulkEditSitesRequest.created_sites.</summary>
                public class BulkEditRequest : DisplayVideoBaseServiceRequest<Google.Apis.DisplayVideo.v1.Data.BulkEditSitesResponse>
                {
                    /// <summary>Constructs a new BulkEdit request.</summary>
                    public BulkEditRequest(Google.Apis.Services.IClientService service, Google.Apis.DisplayVideo.v1.Data.BulkEditSitesRequest body, long advertiserId, long channelId) : base(service)
                    {
                        AdvertiserId = advertiserId;
                        ChannelId = channelId;
                        Body = body;
                        InitParameters();
                    }


                    /// <summary>The ID of the advertiser that owns the parent channel.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("advertiserId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual long AdvertiserId { get; private set; }

                    /// <summary>Required. The ID of the parent channel to which the sites belong.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("channelId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual long ChannelId { get; private set; }


                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.DisplayVideo.v1.Data.BulkEditSitesRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "bulkEdit";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/advertisers/{advertiserId}/channels/{+channelId}/sites:bulkEdit";

                    /// <summary>Initializes BulkEdit parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();

                        RequestParameters.Add("advertiserId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "advertiserId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("channelId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "channelId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^[^/]+$",
                        });
                    }

                }

                /// <summary>Creates a site in a channel.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="advertiserId">The ID of the advertiser that owns the parent channel.</param>
                /// <param
                /// name="channelId">Required. The ID of the parent channel in which the site will be created.</param>
                public virtual CreateRequest Create(Google.Apis.DisplayVideo.v1.Data.Site body, long advertiserId, long channelId)
                {
                    return new CreateRequest(service, body, advertiserId, channelId);
                }

                /// <summary>Creates a site in a channel.</summary>
                public class CreateRequest : DisplayVideoBaseServiceRequest<Google.Apis.DisplayVideo.v1.Data.Site>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.DisplayVideo.v1.Data.Site body, long advertiserId, long channelId) : base(service)
                    {
                        AdvertiserId = advertiserId;
                        ChannelId = channelId;
                        Body = body;
                        InitParameters();
                    }


                    /// <summary>The ID of the advertiser that owns the parent channel.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("advertiserId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual long AdvertiserId { get; private set; }

                    /// <summary>Required. The ID of the parent channel in which the site will be created.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("channelId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual long ChannelId { get; private set; }

                    /// <summary>The ID of the partner that owns the parent channel.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("partnerId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<long> PartnerId { get; set; }


                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.DisplayVideo.v1.Data.Site Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/advertisers/{advertiserId}/channels/{+channelId}/sites";

                    /// <summary>Initializes Create parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();

                        RequestParameters.Add("advertiserId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "advertiserId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("channelId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "channelId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^[^/]+$",
                        });
                        RequestParameters.Add("partnerId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "partnerId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }

                }

                /// <summary>Deletes a site from a channel.</summary>
                /// <param name="advertiserId">The ID of the advertiser that owns the parent channel.</param>
                /// <param
                /// name="channelId">Required. The ID of the parent channel to which the site belongs.</param>
                /// <param
                /// name="urlOrAppId">Required. The URL or app ID of the site to delete.</param>
                public virtual DeleteRequest Delete(long advertiserId, long channelId, string urlOrAppId)
                {
                    return new DeleteRequest(service, advertiserId, channelId, urlOrAppId);
                }

                /// <summary>Deletes a site from a channel.</summary>
                public class DeleteRequest : DisplayVideoBaseServiceRequest<Google.Apis.DisplayVideo.v1.Data.Empty>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, long advertiserId, long channelId, string urlOrAppId) : base(service)
                    {
                        AdvertiserId = advertiserId;
                        ChannelId = channelId;
                        UrlOrAppId = urlOrAppId;
                        InitParameters();
                    }


                    /// <summary>The ID of the advertiser that owns the parent channel.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("advertiserId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual long AdvertiserId { get; private set; }

                    /// <summary>Required. The ID of the parent channel to which the site belongs.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("channelId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual long ChannelId { get; private set; }

                    /// <summary>Required. The URL or app ID of the site to delete.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("urlOrAppId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string UrlOrAppId { get; private set; }

                    /// <summary>The ID of the partner that owns the parent channel.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("partnerId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<long> PartnerId { get; set; }


                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "delete";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "DELETE";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/advertisers/{advertiserId}/channels/{+channelId}/sites/{+urlOrAppId}";

                    /// <summary>Initializes Delete parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();

                        RequestParameters.Add("advertiserId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "advertiserId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("channelId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "channelId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^[^/]+$",
                        });
                        RequestParameters.Add("urlOrAppId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "urlOrAppId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^[^/]+$",
                        });
                        RequestParameters.Add("partnerId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "partnerId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }

                }

                /// <summary>Lists sites in a channel.</summary>
                /// <param name="advertiserId">The ID of the advertiser that owns the parent channel.</param>
                /// <param
                /// name="channelId">Required. The ID of the parent channel to which the requested sites belong.</param>
                public virtual ListRequest List(long advertiserId, long channelId)
                {
                    return new ListRequest(service, advertiserId, channelId);
                }

                /// <summary>Lists sites in a channel.</summary>
                public class ListRequest : DisplayVideoBaseServiceRequest<Google.Apis.DisplayVideo.v1.Data.ListSitesResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, long advertiserId, long channelId) : base(service)
                    {
                        AdvertiserId = advertiserId;
                        ChannelId = channelId;
                        InitParameters();
                    }


                    /// <summary>The ID of the advertiser that owns the parent channel.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("advertiserId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual long AdvertiserId { get; private set; }

                    /// <summary>Required. The ID of the parent channel to which the requested sites belong.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("channelId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual long ChannelId { get; private set; }

                    /// <summary>Allows filtering by site fields. Supported syntax: * Filter expressions for site
                    /// currently can only contain at most one * restriction. * A restriction has the form of `{field}
                    /// {operator} {value}`. * The operator must be `CONTAINS (:)`. * Supported fields: - `urlOrAppId`
                    /// Examples: * All sites for which the URL or app ID contains "google": `urlOrAppId :
                    /// "google"`</summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>Field by which to sort the list. Acceptable values are: * `urlOrAppId` (default) The
                    /// default sorting order is ascending. To specify descending order for a field, a suffix " desc"
                    /// should be added to the field name. Example: `urlOrAppId desc`.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string OrderBy { get; set; }

                    /// <summary>Requested page size. Must be between `1` and `100`. If unspecified will default to
                    /// `100`. Returns error code `INVALID_ARGUMENT` if an invalid value is specified.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>A token identifying a page of results the server should return. Typically, this is the
                    /// value of next_page_token returned from the previous call to `ListSites` method. If not
                    /// specified, the first page of results will be returned.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>The ID of the partner that owns the parent channel.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("partnerId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<long> PartnerId { get; set; }


                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/advertisers/{+advertiserId}/channels/{+channelId}/sites";

                    /// <summary>Initializes List parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();

                        RequestParameters.Add("advertiserId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "advertiserId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^[^/]+$",
                        });
                        RequestParameters.Add("channelId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "channelId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^[^/]+$",
                        });
                        RequestParameters.Add("filter", new Google.Apis.Discovery.Parameter
                        {
                            Name = "filter",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
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
                        RequestParameters.Add("pageSize", new Google.Apis.Discovery.Parameter
                        {
                            Name = "pageSize",
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
                        RequestParameters.Add("partnerId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "partnerId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }

                }
            }

            /// <summary>Creates a new channel. Returns the newly created channel if successful.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="advertiserId">The ID of the advertiser that owns the created channel.</param>
            public virtual CreateRequest Create(Google.Apis.DisplayVideo.v1.Data.Channel body, long advertiserId)
            {
                return new CreateRequest(service, body, advertiserId);
            }

            /// <summary>Creates a new channel. Returns the newly created channel if successful.</summary>
            public class CreateRequest : DisplayVideoBaseServiceRequest<Google.Apis.DisplayVideo.v1.Data.Channel>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.DisplayVideo.v1.Data.Channel body, long advertiserId) : base(service)
                {
                    AdvertiserId = advertiserId;
                    Body = body;
                    InitParameters();
                }


                /// <summary>The ID of the advertiser that owns the created channel.</summary>
                [Google.Apis.Util.RequestParameterAttribute("advertiserId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual long AdvertiserId { get; private set; }

                /// <summary>The ID of the partner that owns the created channel.</summary>
                [Google.Apis.Util.RequestParameterAttribute("partnerId", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<long> PartnerId { get; set; }


                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.DisplayVideo.v1.Data.Channel Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/advertisers/{+advertiserId}/channels";

                /// <summary>Initializes Create parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();

                    RequestParameters.Add("advertiserId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "advertiserId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^[^/]+$",
                    });
                    RequestParameters.Add("partnerId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "partnerId",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }

            }

            /// <summary>Gets a channel for a partner or advertiser.</summary>
            /// <param name="advertiserId">The ID of the advertiser that owns the fetched channel.</param>
            /// <param
            /// name="channelId">Required. The ID of the channel to fetch.</param>
            public virtual GetRequest Get(long advertiserId, long channelId)
            {
                return new GetRequest(service, advertiserId, channelId);
            }

            /// <summary>Gets a channel for a partner or advertiser.</summary>
            public class GetRequest : DisplayVideoBaseServiceRequest<Google.Apis.DisplayVideo.v1.Data.Channel>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, long advertiserId, long channelId) : base(service)
                {
                    AdvertiserId = advertiserId;
                    ChannelId = channelId;
                    InitParameters();
                }


                /// <summary>The ID of the advertiser that owns the fetched channel.</summary>
                [Google.Apis.Util.RequestParameterAttribute("advertiserId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual long AdvertiserId { get; private set; }

                /// <summary>Required. The ID of the channel to fetch.</summary>
                [Google.Apis.Util.RequestParameterAttribute("channelId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual long ChannelId { get; private set; }

                /// <summary>The ID of the partner that owns the fetched channel.</summary>
                [Google.Apis.Util.RequestParameterAttribute("partnerId", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<long> PartnerId { get; set; }


                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/advertisers/{+advertiserId}/channels/{+channelId}";

                /// <summary>Initializes Get parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();

                    RequestParameters.Add("advertiserId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "advertiserId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^[^/]+$",
                    });
                    RequestParameters.Add("channelId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "channelId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^[^/]+$",
                    });
                    RequestParameters.Add("partnerId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "partnerId",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }

            }

            /// <summary>Lists channels for a partner or advertiser.</summary>
            /// <param name="advertiserId">The ID of the advertiser that owns the channels.</param>
            public virtual ListRequest List(long advertiserId)
            {
                return new ListRequest(service, advertiserId);
            }

            /// <summary>Lists channels for a partner or advertiser.</summary>
            public class ListRequest : DisplayVideoBaseServiceRequest<Google.Apis.DisplayVideo.v1.Data.ListChannelsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, long advertiserId) : base(service)
                {
                    AdvertiserId = advertiserId;
                    InitParameters();
                }


                /// <summary>The ID of the advertiser that owns the channels.</summary>
                [Google.Apis.Util.RequestParameterAttribute("advertiserId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual long AdvertiserId { get; private set; }

                /// <summary>Allows filtering by channel fields. Supported syntax: * Filter expressions for channel
                /// currently can only contain at most one * restriction. * A restriction has the form of `{field}
                /// {operator} {value}`. * The operator must be `CONTAINS (:)`. * Supported fields: - `displayName`
                /// Examples: * All channels for which the display name contains "google": `displayName : "google"`. The
                /// length of this field should be no more than 500 characters.</summary>
                [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Filter { get; set; }

                /// <summary>Field by which to sort the list. Acceptable values are: * `displayName` (default) *
                /// `channelId` The default sorting order is ascending. To specify descending order for a field, a
                /// suffix " desc" should be added to the field name. Example: `displayName desc`.</summary>
                [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string OrderBy { get; set; }

                /// <summary>Requested page size. Must be between `1` and `100`. If unspecified will default to `100`.
                /// Returns error code `INVALID_ARGUMENT` if an invalid value is specified.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>A token identifying a page of results the server should return. Typically, this is the
                /// value of next_page_token returned from the previous call to `ListChannels` method. If not specified,
                /// the first page of results will be returned.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>The ID of the partner that owns the channels.</summary>
                [Google.Apis.Util.RequestParameterAttribute("partnerId", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<long> PartnerId { get; set; }


                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/advertisers/{+advertiserId}/channels";

                /// <summary>Initializes List parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();

                    RequestParameters.Add("advertiserId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "advertiserId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^[^/]+$",
                    });
                    RequestParameters.Add("filter", new Google.Apis.Discovery.Parameter
                    {
                        Name = "filter",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
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
                    RequestParameters.Add("pageSize", new Google.Apis.Discovery.Parameter
                    {
                        Name = "pageSize",
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
                    RequestParameters.Add("partnerId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "partnerId",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }

            }

            /// <summary>Updates a channel. Returns the updated channel if successful.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="advertiserId">The ID of the advertiser that owns the created channel.</param>
            /// <param
            /// name="channelId">Output only. The unique ID of the channel. Assigned by the system.</param>
            public virtual PatchRequest Patch(Google.Apis.DisplayVideo.v1.Data.Channel body, long advertiserId, long channelId)
            {
                return new PatchRequest(service, body, advertiserId, channelId);
            }

            /// <summary>Updates a channel. Returns the updated channel if successful.</summary>
            public class PatchRequest : DisplayVideoBaseServiceRequest<Google.Apis.DisplayVideo.v1.Data.Channel>
            {
                /// <summary>Constructs a new Patch request.</summary>
                public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.DisplayVideo.v1.Data.Channel body, long advertiserId, long channelId) : base(service)
                {
                    AdvertiserId = advertiserId;
                    ChannelId = channelId;
                    Body = body;
                    InitParameters();
                }


                /// <summary>The ID of the advertiser that owns the created channel.</summary>
                [Google.Apis.Util.RequestParameterAttribute("advertiserId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual long AdvertiserId { get; private set; }

                /// <summary>Output only. The unique ID of the channel. Assigned by the system.</summary>
                [Google.Apis.Util.RequestParameterAttribute("channelId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual long ChannelId { get; private set; }

                /// <summary>The ID of the partner that owns the created channel.</summary>
                [Google.Apis.Util.RequestParameterAttribute("partnerId", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<long> PartnerId { get; set; }

                /// <summary>Required. The mask to control which fields to update.</summary>
                [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                public virtual object UpdateMask { get; set; }


                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.DisplayVideo.v1.Data.Channel Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "patch";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PATCH";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/advertisers/{+advertiserId}/channels/{channelId}";

                /// <summary>Initializes Patch parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();

                    RequestParameters.Add("advertiserId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "advertiserId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^[^/]+$",
                    });
                    RequestParameters.Add("channelId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "channelId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("partnerId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "partnerId",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("updateMask", new Google.Apis.Discovery.Parameter
                    {
                        Name = "updateMask",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }

            }
        }
        /// <summary>Gets the Creatives resource.</summary>
        public virtual CreativesResource Creatives { get; }

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


            /// <summary>Creates a new creative. Returns the newly created creative if successful.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="advertiserId">Output only. The unique ID of the advertiser the creative belongs to.</param>
            public virtual CreateRequest Create(Google.Apis.DisplayVideo.v1.Data.Creative body, long advertiserId)
            {
                return new CreateRequest(service, body, advertiserId);
            }

            /// <summary>Creates a new creative. Returns the newly created creative if successful.</summary>
            public class CreateRequest : DisplayVideoBaseServiceRequest<Google.Apis.DisplayVideo.v1.Data.Creative>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.DisplayVideo.v1.Data.Creative body, long advertiserId) : base(service)
                {
                    AdvertiserId = advertiserId;
                    Body = body;
                    InitParameters();
                }


                /// <summary>Output only. The unique ID of the advertiser the creative belongs to.</summary>
                [Google.Apis.Util.RequestParameterAttribute("advertiserId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual long AdvertiserId { get; private set; }


                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.DisplayVideo.v1.Data.Creative Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/advertisers/{+advertiserId}/creatives";

                /// <summary>Initializes Create parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();

                    RequestParameters.Add("advertiserId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "advertiserId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^[^/]+$",
                    });
                }

            }

            /// <summary>Deletes a creative. Returns error code `NOT_FOUND` if the creative does not exist. The creative
            /// should be archived first, i.e. set entity_status to `ENTITY_STATUS_ARCHIVED`, before it can be
            /// deleted.</summary>
            /// <param name="advertiserId">The ID of the advertiser this creative belongs to.</param>
            /// <param
            /// name="creativeId">The ID of the creative to be deleted.</param>
            public virtual DeleteRequest Delete(long advertiserId, long creativeId)
            {
                return new DeleteRequest(service, advertiserId, creativeId);
            }

            /// <summary>Deletes a creative. Returns error code `NOT_FOUND` if the creative does not exist. The creative
            /// should be archived first, i.e. set entity_status to `ENTITY_STATUS_ARCHIVED`, before it can be
            /// deleted.</summary>
            public class DeleteRequest : DisplayVideoBaseServiceRequest<Google.Apis.DisplayVideo.v1.Data.Empty>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, long advertiserId, long creativeId) : base(service)
                {
                    AdvertiserId = advertiserId;
                    CreativeId = creativeId;
                    InitParameters();
                }


                /// <summary>The ID of the advertiser this creative belongs to.</summary>
                [Google.Apis.Util.RequestParameterAttribute("advertiserId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual long AdvertiserId { get; private set; }

                /// <summary>The ID of the creative to be deleted.</summary>
                [Google.Apis.Util.RequestParameterAttribute("creativeId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual long CreativeId { get; private set; }


                /// <summary>Gets the method name.</summary>
                public override string MethodName => "delete";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "DELETE";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/advertisers/{+advertiserId}/creatives/{+creativeId}";

                /// <summary>Initializes Delete parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();

                    RequestParameters.Add("advertiserId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "advertiserId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^[^/]+$",
                    });
                    RequestParameters.Add("creativeId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "creativeId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^[^/]+$",
                    });
                }

            }

            /// <summary>Gets a creative.</summary>
            /// <param name="advertiserId">Required. The ID of the advertiser this creative belongs to.</param>
            /// <param
            /// name="creativeId">Required. The ID of the creative to fetch.</param>
            public virtual GetRequest Get(long advertiserId, long creativeId)
            {
                return new GetRequest(service, advertiserId, creativeId);
            }

            /// <summary>Gets a creative.</summary>
            public class GetRequest : DisplayVideoBaseServiceRequest<Google.Apis.DisplayVideo.v1.Data.Creative>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, long advertiserId, long creativeId) : base(service)
                {
                    AdvertiserId = advertiserId;
                    CreativeId = creativeId;
                    InitParameters();
                }


                /// <summary>Required. The ID of the advertiser this creative belongs to.</summary>
                [Google.Apis.Util.RequestParameterAttribute("advertiserId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual long AdvertiserId { get; private set; }

                /// <summary>Required. The ID of the creative to fetch.</summary>
                [Google.Apis.Util.RequestParameterAttribute("creativeId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual long CreativeId { get; private set; }


                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/advertisers/{+advertiserId}/creatives/{+creativeId}";

                /// <summary>Initializes Get parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();

                    RequestParameters.Add("advertiserId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "advertiserId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^[^/]+$",
                    });
                    RequestParameters.Add("creativeId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "creativeId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^[^/]+$",
                    });
                }

            }

            /// <summary>Lists creatives in an advertiser. The order is defined by the order_by parameter. If a filter
            /// by entity_status is not specified, creatives with `ENTITY_STATUS_ARCHIVED` will not be included in the
            /// results.</summary>
            /// <param name="advertiserId">Required. The ID of the advertiser to list creatives for.</param>
            public virtual ListRequest List(long advertiserId)
            {
                return new ListRequest(service, advertiserId);
            }

            /// <summary>Lists creatives in an advertiser. The order is defined by the order_by parameter. If a filter
            /// by entity_status is not specified, creatives with `ENTITY_STATUS_ARCHIVED` will not be included in the
            /// results.</summary>
            public class ListRequest : DisplayVideoBaseServiceRequest<Google.Apis.DisplayVideo.v1.Data.ListCreativesResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, long advertiserId) : base(service)
                {
                    AdvertiserId = advertiserId;
                    InitParameters();
                }


                /// <summary>Required. The ID of the advertiser to list creatives for.</summary>
                [Google.Apis.Util.RequestParameterAttribute("advertiserId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual long AdvertiserId { get; private set; }

                /// <summary>Allows filtering by creative properties. Supported syntax: * Filter expressions are made up
                /// of one or more restrictions. * Restriction for the same field must be combined by `OR`. *
                /// Restriction for different fields must be combined by `AND`. * Between `(` and `)` there can only be
                /// restrictions combined by `OR` for the same field. * A restriction has the form of `{field}
                /// {operator} {value}`. * The operator must be `EQUALS (=)` for the following fields: - `entityStatus`
                /// - `creativeType`. - `dimensions` - `minDuration` - `maxDuration` - `approvalStatus` -
                /// `exchangeReviewStatus` - `dynamic` - `creativeId` * The operator must be `HAS (:)` for the following
                /// fields: - `lineItemIds` * For `entityStatus`, `minDuration`, `maxDuration`, and `dynamic` there may
                /// be at most one restriction. * For `dimensions`, the value is in the form of `"{width}x{height}"`. *
                /// For `exchangeReviewStatus`, the value is in the form of `{exchange}-{reviewStatus}`. * For
                /// `minDuration` and `maxDuration`, the value is in the form of `"{duration}s"`. Only seconds are
                /// supported with millisecond granularity. * There may be multiple `lineItemIds` restrictions in order
                /// to search against multiple possible line item IDs. * There may be multiple `creativeId` restrictions
                /// in order to search against multiple possible creative IDs. Examples: * All native creatives:
                /// `creativeType="CREATIVE_TYPE_NATIVE"` * All active creatives with 300x400 or 50x100 dimensions:
                /// `entityStatus="ENTITY_STATUS_ACTIVE" AND (dimensions="300x400" OR dimensions="50x100")` * All
                /// dynamic creatives that are approved by AdX or AppNexus, with a minimum duration of 5 seconds and
                /// 200ms. `dynamic="true" AND minDuration="5.2s" AND (exchangeReviewStatus="EXCHANGE_GOOGLE_AD_MANAGER-
                /// REVIEW_STATUS_APPROVED" OR exchangeReviewStatus="EXCHANGE_APPNEXUS-REVIEW_STATUS_APPROVED")` * All
                /// video creatives that are associated with line item ID 1 or 2: `creativeType="CREATIVE_TYPE_VIDEO"
                /// AND (lineItemIds:1 OR lineItemIds:2)` * Find creatives by multiple creative IDs: `creativeId=1 OR
                /// creativeId=2` The length of this field should be no more than 500 characters.</summary>
                [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Filter { get; set; }

                /// <summary>Field by which to sort the list. Acceptable values are: * `creativeId` (default) *
                /// `createTime` * `mediaDuration` * `dimensions` (sorts by width first, then by height) The default
                /// sorting order is ascending. To specify descending order for a field, a suffix "desc" should be added
                /// to the field name. Example: `createTime desc`.</summary>
                [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string OrderBy { get; set; }

                /// <summary>Requested page size. Must be between `1` and `100`. If unspecified will default to `100`.
                /// Returns error code `INVALID_ARGUMENT` if an invalid value is specified.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>A token identifying a page of results the server should return. Typically, this is the
                /// value of next_page_token returned from the previous call to `ListCreatives` method. If not
                /// specified, the first page of results will be returned.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }


                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/advertisers/{+advertiserId}/creatives";

                /// <summary>Initializes List parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();

                    RequestParameters.Add("advertiserId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "advertiserId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^[^/]+$",
                    });
                    RequestParameters.Add("filter", new Google.Apis.Discovery.Parameter
                    {
                        Name = "filter",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
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
                    RequestParameters.Add("pageSize", new Google.Apis.Discovery.Parameter
                    {
                        Name = "pageSize",
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

            /// <summary>Updates an existing creative. Returns the updated creative if successful.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="advertiserId">Output only. The unique ID of the advertiser the creative belongs to.</param>
            ///
            /// <param name="creativeId">Output only. The unique ID of the creative. Assigned by the system.</param>
            public virtual PatchRequest Patch(Google.Apis.DisplayVideo.v1.Data.Creative body, long advertiserId, long creativeId)
            {
                return new PatchRequest(service, body, advertiserId, creativeId);
            }

            /// <summary>Updates an existing creative. Returns the updated creative if successful.</summary>
            public class PatchRequest : DisplayVideoBaseServiceRequest<Google.Apis.DisplayVideo.v1.Data.Creative>
            {
                /// <summary>Constructs a new Patch request.</summary>
                public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.DisplayVideo.v1.Data.Creative body, long advertiserId, long creativeId) : base(service)
                {
                    AdvertiserId = advertiserId;
                    CreativeId = creativeId;
                    Body = body;
                    InitParameters();
                }


                /// <summary>Output only. The unique ID of the advertiser the creative belongs to.</summary>
                [Google.Apis.Util.RequestParameterAttribute("advertiserId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual long AdvertiserId { get; private set; }

                /// <summary>Output only. The unique ID of the creative. Assigned by the system.</summary>
                [Google.Apis.Util.RequestParameterAttribute("creativeId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual long CreativeId { get; private set; }

                /// <summary>Required. The mask to control which fields to update.</summary>
                [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                public virtual object UpdateMask { get; set; }


                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.DisplayVideo.v1.Data.Creative Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "patch";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PATCH";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/advertisers/{+advertiserId}/creatives/{+creativeId}";

                /// <summary>Initializes Patch parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();

                    RequestParameters.Add("advertiserId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "advertiserId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^[^/]+$",
                    });
                    RequestParameters.Add("creativeId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "creativeId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^[^/]+$",
                    });
                    RequestParameters.Add("updateMask", new Google.Apis.Discovery.Parameter
                    {
                        Name = "updateMask",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }

            }
        }
        /// <summary>Gets the InsertionOrders resource.</summary>
        public virtual InsertionOrdersResource InsertionOrders { get; }

        /// <summary>The "insertionOrders" collection of methods.</summary>
        public class InsertionOrdersResource
        {
            private const string Resource = "insertionOrders";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public InsertionOrdersResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;

            }


            /// <summary>Creates a new insertion order. Returns the newly created insertion order if
            /// successful.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="advertiserId">Output only. The unique ID of the advertiser the insertion order belongs to.</param>
            public virtual CreateRequest Create(Google.Apis.DisplayVideo.v1.Data.InsertionOrder body, long advertiserId)
            {
                return new CreateRequest(service, body, advertiserId);
            }

            /// <summary>Creates a new insertion order. Returns the newly created insertion order if
            /// successful.</summary>
            public class CreateRequest : DisplayVideoBaseServiceRequest<Google.Apis.DisplayVideo.v1.Data.InsertionOrder>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.DisplayVideo.v1.Data.InsertionOrder body, long advertiserId) : base(service)
                {
                    AdvertiserId = advertiserId;
                    Body = body;
                    InitParameters();
                }


                /// <summary>Output only. The unique ID of the advertiser the insertion order belongs to.</summary>
                [Google.Apis.Util.RequestParameterAttribute("advertiserId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual long AdvertiserId { get; private set; }


                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.DisplayVideo.v1.Data.InsertionOrder Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/advertisers/{+advertiserId}/insertionOrders";

                /// <summary>Initializes Create parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();

                    RequestParameters.Add("advertiserId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "advertiserId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^[^/]+$",
                    });
                }

            }

            /// <summary>Deletes an insertion order. Returns error code `NOT_FOUND` if the insertion order does not
            /// exist. The insertion order should be archived first, i.e. set entity_status to `ENTITY_STATUS_ARCHIVED`,
            /// to be able to delete it.</summary>
            /// <param name="advertiserId">The ID of the advertiser this insertion order belongs to.</param>
            /// <param
            /// name="insertionOrderId">The ID of the insertion order we need to delete.</param>
            public virtual DeleteRequest Delete(long advertiserId, long insertionOrderId)
            {
                return new DeleteRequest(service, advertiserId, insertionOrderId);
            }

            /// <summary>Deletes an insertion order. Returns error code `NOT_FOUND` if the insertion order does not
            /// exist. The insertion order should be archived first, i.e. set entity_status to `ENTITY_STATUS_ARCHIVED`,
            /// to be able to delete it.</summary>
            public class DeleteRequest : DisplayVideoBaseServiceRequest<Google.Apis.DisplayVideo.v1.Data.Empty>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, long advertiserId, long insertionOrderId) : base(service)
                {
                    AdvertiserId = advertiserId;
                    InsertionOrderId = insertionOrderId;
                    InitParameters();
                }


                /// <summary>The ID of the advertiser this insertion order belongs to.</summary>
                [Google.Apis.Util.RequestParameterAttribute("advertiserId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual long AdvertiserId { get; private set; }

                /// <summary>The ID of the insertion order we need to delete.</summary>
                [Google.Apis.Util.RequestParameterAttribute("insertionOrderId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual long InsertionOrderId { get; private set; }


                /// <summary>Gets the method name.</summary>
                public override string MethodName => "delete";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "DELETE";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/advertisers/{+advertiserId}/insertionOrders/{+insertionOrderId}";

                /// <summary>Initializes Delete parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();

                    RequestParameters.Add("advertiserId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "advertiserId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^[^/]+$",
                    });
                    RequestParameters.Add("insertionOrderId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "insertionOrderId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^[^/]+$",
                    });
                }

            }

            /// <summary>Gets an insertion order. Returns error code `NOT_FOUND` if the insertion order does not
            /// exist.</summary>
            /// <param name="advertiserId">Required. The ID of the advertiser this insertion order belongs to.</param>
            ///
            /// <param name="insertionOrderId">Required. The ID of the insertion order to fetch.</param>
            public virtual GetRequest Get(long advertiserId, long insertionOrderId)
            {
                return new GetRequest(service, advertiserId, insertionOrderId);
            }

            /// <summary>Gets an insertion order. Returns error code `NOT_FOUND` if the insertion order does not
            /// exist.</summary>
            public class GetRequest : DisplayVideoBaseServiceRequest<Google.Apis.DisplayVideo.v1.Data.InsertionOrder>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, long advertiserId, long insertionOrderId) : base(service)
                {
                    AdvertiserId = advertiserId;
                    InsertionOrderId = insertionOrderId;
                    InitParameters();
                }


                /// <summary>Required. The ID of the advertiser this insertion order belongs to.</summary>
                [Google.Apis.Util.RequestParameterAttribute("advertiserId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual long AdvertiserId { get; private set; }

                /// <summary>Required. The ID of the insertion order to fetch.</summary>
                [Google.Apis.Util.RequestParameterAttribute("insertionOrderId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual long InsertionOrderId { get; private set; }


                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/advertisers/{+advertiserId}/insertionOrders/{+insertionOrderId}";

                /// <summary>Initializes Get parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();

                    RequestParameters.Add("advertiserId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "advertiserId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^[^/]+$",
                    });
                    RequestParameters.Add("insertionOrderId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "insertionOrderId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^[^/]+$",
                    });
                }

            }

            /// <summary>Lists insertion orders in an advertiser. The order is defined by the order_by parameter. If a
            /// filter by entity_status is not specified, insertion orders with `ENTITY_STATUS_ARCHIVED` will not be
            /// included in the results.</summary>
            /// <param name="advertiserId">Required. The ID of the advertiser to list insertion orders for.</param>
            public virtual ListRequest List(long advertiserId)
            {
                return new ListRequest(service, advertiserId);
            }

            /// <summary>Lists insertion orders in an advertiser. The order is defined by the order_by parameter. If a
            /// filter by entity_status is not specified, insertion orders with `ENTITY_STATUS_ARCHIVED` will not be
            /// included in the results.</summary>
            public class ListRequest : DisplayVideoBaseServiceRequest<Google.Apis.DisplayVideo.v1.Data.ListInsertionOrdersResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, long advertiserId) : base(service)
                {
                    AdvertiserId = advertiserId;
                    InitParameters();
                }


                /// <summary>Required. The ID of the advertiser to list insertion orders for.</summary>
                [Google.Apis.Util.RequestParameterAttribute("advertiserId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual long AdvertiserId { get; private set; }

                /// <summary>Allows filtering by insertion order properties. Supported syntax: * Filter expressions are
                /// made up of one or more restrictions. * Restrictions can be combined by `AND` or `OR` logical
                /// operators. A sequence of restrictions implicitly uses `AND`. * A restriction has the form of
                /// `{field} {operator} {value}`. * The operator used on `budget.budget_segments.date_range.end_date`
                /// must be LESS THAN (<). * The operators used on all other fields must be `EQUALS (=)`. * Supported
                /// fields: - `campaignId` - `displayName` - `entityStatus` -
                /// `budget.budget_segments.date_range.end_date` (input as YYYY-MM-DD) Examples: * All insertion orders
                /// under a campaign: `campaignId="1234"` * All `ENTITY_STATUS_ACTIVE` or `ENTITY_STATUS_PAUSED`
                /// insertion orders under an advertiser: `(entityStatus="ENTITY_STATUS_ACTIVE" OR
                /// entityStatus="ENTITY_STATUS_PAUSED")` * All insertion orders whose budget segments' dates end before
                /// March 28, 2019: `budget.budget_segments.date_range.end_date<"2019-03-28"` The length of this field
                /// should be no more than 500 characters.</summary>
                [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Filter { get; set; }

                /// <summary>Field by which to sort the list. Acceptable values are: * "displayName" (default) *
                /// "entityStatus" The default sorting order is ascending. To specify descending order for a field, a
                /// suffix "desc" should be added to the field name. Example: `displayName desc`.</summary>
                [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string OrderBy { get; set; }

                /// <summary>Requested page size. Must be between `1` and `100`. If unspecified will default to `100`.
                /// Returns error code `INVALID_ARGUMENT` if an invalid value is specified.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>A token identifying a page of results the server should return. Typically, this is the
                /// value of next_page_token returned from the previous call to `ListInsertionOrders` method. If not
                /// specified, the first page of results will be returned.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }


                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/advertisers/{+advertiserId}/insertionOrders";

                /// <summary>Initializes List parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();

                    RequestParameters.Add("advertiserId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "advertiserId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^[^/]+$",
                    });
                    RequestParameters.Add("filter", new Google.Apis.Discovery.Parameter
                    {
                        Name = "filter",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
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
                    RequestParameters.Add("pageSize", new Google.Apis.Discovery.Parameter
                    {
                        Name = "pageSize",
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

            /// <summary>Updates an existing insertion order. Returns the updated insertion order if
            /// successful.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="advertiserId">Output only. The unique ID of the advertiser the insertion order belongs
            /// to.</param>
            /// <param name="insertionOrderId">Output only. The unique ID of the insertion order. Assigned by
            /// the system.</param>
            public virtual PatchRequest Patch(Google.Apis.DisplayVideo.v1.Data.InsertionOrder body, long advertiserId, long insertionOrderId)
            {
                return new PatchRequest(service, body, advertiserId, insertionOrderId);
            }

            /// <summary>Updates an existing insertion order. Returns the updated insertion order if
            /// successful.</summary>
            public class PatchRequest : DisplayVideoBaseServiceRequest<Google.Apis.DisplayVideo.v1.Data.InsertionOrder>
            {
                /// <summary>Constructs a new Patch request.</summary>
                public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.DisplayVideo.v1.Data.InsertionOrder body, long advertiserId, long insertionOrderId) : base(service)
                {
                    AdvertiserId = advertiserId;
                    InsertionOrderId = insertionOrderId;
                    Body = body;
                    InitParameters();
                }


                /// <summary>Output only. The unique ID of the advertiser the insertion order belongs to.</summary>
                [Google.Apis.Util.RequestParameterAttribute("advertiserId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual long AdvertiserId { get; private set; }

                /// <summary>Output only. The unique ID of the insertion order. Assigned by the system.</summary>
                [Google.Apis.Util.RequestParameterAttribute("insertionOrderId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual long InsertionOrderId { get; private set; }

                /// <summary>Required. The mask to control which fields to update.</summary>
                [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                public virtual object UpdateMask { get; set; }


                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.DisplayVideo.v1.Data.InsertionOrder Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "patch";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PATCH";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/advertisers/{+advertiserId}/insertionOrders/{+insertionOrderId}";

                /// <summary>Initializes Patch parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();

                    RequestParameters.Add("advertiserId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "advertiserId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^[^/]+$",
                    });
                    RequestParameters.Add("insertionOrderId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "insertionOrderId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^[^/]+$",
                    });
                    RequestParameters.Add("updateMask", new Google.Apis.Discovery.Parameter
                    {
                        Name = "updateMask",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }

            }
        }
        /// <summary>Gets the LineItems resource.</summary>
        public virtual LineItemsResource LineItems { get; }

        /// <summary>The "lineItems" collection of methods.</summary>
        public class LineItemsResource
        {
            private const string Resource = "lineItems";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public LineItemsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
                TargetingTypes = new TargetingTypesResource(service);

            }

            /// <summary>Gets the TargetingTypes resource.</summary>
            public virtual TargetingTypesResource TargetingTypes { get; }

            /// <summary>The "targetingTypes" collection of methods.</summary>
            public class TargetingTypesResource
            {
                private const string Resource = "targetingTypes";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public TargetingTypesResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                    AssignedTargetingOptions = new AssignedTargetingOptionsResource(service);

                }

                /// <summary>Gets the AssignedTargetingOptions resource.</summary>
                public virtual AssignedTargetingOptionsResource AssignedTargetingOptions { get; }

                /// <summary>The "assignedTargetingOptions" collection of methods.</summary>
                public class AssignedTargetingOptionsResource
                {
                    private const string Resource = "assignedTargetingOptions";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public AssignedTargetingOptionsResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;

                    }


                    /// <summary>Assigns a targeting option to a line item. Returns the assigned targeting option if
                    /// successful.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="advertiserId">Required. The ID of the advertiser the line item belongs to.</param>
                    /// <param
                    /// name="lineItemId">Required. The ID of the line item the assigned targeting option will belong to.</param>
                    ///
                    /// <param name="targetingType">Required. Identifies the type of this assigned targeting option.</param>
                    public virtual CreateRequest Create(Google.Apis.DisplayVideo.v1.Data.AssignedTargetingOption body, long advertiserId, long lineItemId, CreateRequest.TargetingTypeEnum targetingType)
                    {
                        return new CreateRequest(service, body, advertiserId, lineItemId, targetingType);
                    }

                    /// <summary>Assigns a targeting option to a line item. Returns the assigned targeting option if
                    /// successful.</summary>
                    public class CreateRequest : DisplayVideoBaseServiceRequest<Google.Apis.DisplayVideo.v1.Data.AssignedTargetingOption>
                    {
                        /// <summary>Constructs a new Create request.</summary>
                        public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.DisplayVideo.v1.Data.AssignedTargetingOption body, long advertiserId, long lineItemId, CreateRequest.TargetingTypeEnum targetingType) : base(service)
                        {
                            AdvertiserId = advertiserId;
                            LineItemId = lineItemId;
                            TargetingType = targetingType;
                            Body = body;
                            InitParameters();
                        }


                        /// <summary>Required. The ID of the advertiser the line item belongs to.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("advertiserId", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual long AdvertiserId { get; private set; }

                        /// <summary>Required. The ID of the line item the assigned targeting option will belong
                        /// to.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("lineItemId", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual long LineItemId { get; private set; }

                        /// <summary>Required. Identifies the type of this assigned targeting option.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("targetingType", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual TargetingTypeEnum TargetingType { get; private set; }

                        /// <summary>Required. Identifies the type of this assigned targeting option.</summary>
                        public enum TargetingTypeEnum
                        {
                            /// <summary>Default value when type is not specified or is unknown in this
                            /// version.</summary>
                            [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_UNSPECIFIED")]
                            TARGETINGTYPEUNSPECIFIED,
                            /// <summary>Target a channel (a custom group of related websites or apps).</summary>
                            [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_CHANNEL")]
                            TARGETINGTYPECHANNEL,
                            /// <summary>Target an app category (for example, education or puzzle games).</summary>
                            [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_APP_CATEGORY")]
                            TARGETINGTYPEAPPCATEGORY,
                            /// <summary>Target a specific app (for example, Angry Birds).</summary>
                            [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_APP")]
                            TARGETINGTYPEAPP,
                            /// <summary>Target a specific url (for example, quora.com).</summary>
                            [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_URL")]
                            TARGETINGTYPEURL,
                            /// <summary>Target ads during a chosen time period on a specific day.</summary>
                            [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_DAY_AND_TIME")]
                            TARGETINGTYPEDAYANDTIME,
                            /// <summary>Target ads to a specific age range (for example, 18-24).</summary>
                            [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_AGE_RANGE")]
                            TARGETINGTYPEAGERANGE,
                            /// <summary>Target ads to the specified regions on a regional location list.</summary>
                            [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_REGIONAL_LOCATION_LIST")]
                            TARGETINGTYPEREGIONALLOCATIONLIST,
                            /// <summary>Target ads to the specified points of interest on a proximity location
                            /// list.</summary>
                            [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_PROXIMITY_LOCATION_LIST")]
                            TARGETINGTYPEPROXIMITYLOCATIONLIST,
                            /// <summary>Target ads to a specific gender (for example, female or male).</summary>
                            [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_GENDER")]
                            TARGETINGTYPEGENDER,
                            /// <summary>Target a specific video player size for video ads.</summary>
                            [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_VIDEO_PLAYER_SIZE")]
                            TARGETINGTYPEVIDEOPLAYERSIZE,
                            /// <summary>Target user rewarded content for video ads.</summary>
                            [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_USER_REWARDED_CONTENT")]
                            TARGETINGTYPEUSERREWARDEDCONTENT,
                            /// <summary>Target ads to a specific parental status (for example, parent or not a
                            /// parent).</summary>
                            [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_PARENTAL_STATUS")]
                            TARGETINGTYPEPARENTALSTATUS,
                            /// <summary>Target video or audio ads in a specific content instream position (for example,
                            /// pre-roll, mid-roll, or post-roll).</summary>
                            [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_CONTENT_INSTREAM_POSITION")]
                            TARGETINGTYPECONTENTINSTREAMPOSITION,
                            /// <summary>Target ads in a specific content outstream position.</summary>
                            [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_CONTENT_OUTSTREAM_POSITION")]
                            TARGETINGTYPECONTENTOUTSTREAMPOSITION,
                            /// <summary>Target ads to a specific device type (for example, tablet or connected
                            /// TV).</summary>
                            [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_DEVICE_TYPE")]
                            TARGETINGTYPEDEVICETYPE,
                            /// <summary>Target ads to an audience or groups of audiences. Singleton field, at most one
                            /// can exist on a single Lineitem at a time.</summary>
                            [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_AUDIENCE_GROUP")]
                            TARGETINGTYPEAUDIENCEGROUP,
                            /// <summary>Target ads to specific web browsers (for example, Chrome).</summary>
                            [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_BROWSER")]
                            TARGETINGTYPEBROWSER,
                            /// <summary>Target ads to a specific household income range (for example, top
                            /// 10%).</summary>
                            [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_HOUSEHOLD_INCOME")]
                            TARGETINGTYPEHOUSEHOLDINCOME,
                            /// <summary>Target ads in a specific on screen position.</summary>
                            [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_ON_SCREEN_POSITION")]
                            TARGETINGTYPEONSCREENPOSITION,
                            /// <summary>Filter web sites through third party verification (for example, IAS or
                            /// DoubleVerify).</summary>
                            [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_THIRD_PARTY_VERIFIER")]
                            TARGETINGTYPETHIRDPARTYVERIFIER,
                            /// <summary>Filter web sites by specific digital content label ratings (for example, DL-MA:
                            /// suitable only for mature audiences).</summary>
                            [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_DIGITAL_CONTENT_LABEL_EXCLUSION")]
                            TARGETINGTYPEDIGITALCONTENTLABELEXCLUSION,
                            /// <summary>Filter website content by sensitive categories (for example, adult).</summary>
                            [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_SENSITIVE_CATEGORY_EXCLUSION")]
                            TARGETINGTYPESENSITIVECATEGORYEXCLUSION,
                            /// <summary>Target ads to a specific environment (for example, web or app).</summary>
                            [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_ENVIRONMENT")]
                            TARGETINGTYPEENVIRONMENT,
                            /// <summary>Target ads to a specific network carrier or internet service provider (ISP)
                            /// (for example, Comcast or Orange).</summary>
                            [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_CARRIER_AND_ISP")]
                            TARGETINGTYPECARRIERANDISP,
                            /// <summary>Target ads to a specific operating system (for example, macOS).</summary>
                            [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_OPERATING_SYSTEM")]
                            TARGETINGTYPEOPERATINGSYSTEM,
                            /// <summary>Target ads to a specific device make or model (for example, Roku or
                            /// Samsung).</summary>
                            [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_DEVICE_MAKE_MODEL")]
                            TARGETINGTYPEDEVICEMAKEMODEL,
                            /// <summary>Target ads to a specific keyword (for example, dog or retriever).</summary>
                            [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_KEYWORD")]
                            TARGETINGTYPEKEYWORD,
                            /// <summary>Target ads to a specific negative keyword list.</summary>
                            [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_NEGATIVE_KEYWORD_LIST")]
                            TARGETINGTYPENEGATIVEKEYWORDLIST,
                            /// <summary>Target ads to a specific viewability (for example, 80% viewable).</summary>
                            [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_VIEWABILITY")]
                            TARGETINGTYPEVIEWABILITY,
                            /// <summary>Target ads to a specific content category (for example, arts &
                            /// entertainment).</summary>
                            [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_CATEGORY")]
                            TARGETINGTYPECATEGORY,
                            /// <summary>Purchase impressions from specific deals and auction packages.</summary>
                            [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_INVENTORY_SOURCE")]
                            TARGETINGTYPEINVENTORYSOURCE,
                            /// <summary>Target ads to a specific language (for example, English or Japanese).</summary>
                            [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_LANGUAGE")]
                            TARGETINGTYPELANGUAGE,
                            /// <summary>Target ads to ads.txt authorized sellers.</summary>
                            [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_AUTHORIZED_SELLER_STATUS")]
                            TARGETINGTYPEAUTHORIZEDSELLERSTATUS,
                            /// <summary>Target ads to a specific regional location (for example, a city or
                            /// state).</summary>
                            [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_GEO_REGION")]
                            TARGETINGTYPEGEOREGION,
                            /// <summary>Purchase impressions from a group of deals and auction packages.</summary>
                            [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_INVENTORY_SOURCE_GROUP")]
                            TARGETINGTYPEINVENTORYSOURCEGROUP,
                            /// <summary>Purchase impressions from specific exchanges.</summary>
                            [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_EXCHANGE")]
                            TARGETINGTYPEEXCHANGE,
                            /// <summary>Purchase impressions from specific sub-exchanges.</summary>
                            [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_SUB_EXCHANGE")]
                            TARGETINGTYPESUBEXCHANGE,
                        }


                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.DisplayVideo.v1.Data.AssignedTargetingOption Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "create";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/advertisers/{+advertiserId}/lineItems/{+lineItemId}/targetingTypes/{+targetingType}/assignedTargetingOptions";

                        /// <summary>Initializes Create parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();

                            RequestParameters.Add("advertiserId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "advertiserId",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^[^/]+$",
                            });
                            RequestParameters.Add("lineItemId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "lineItemId",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^[^/]+$",
                            });
                            RequestParameters.Add("targetingType", new Google.Apis.Discovery.Parameter
                            {
                                Name = "targetingType",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^[^/]+$",
                            });
                        }

                    }

                    /// <summary>Deletes an assigned targeting option from a line item.</summary>
                    /// <param name="advertiserId">Required. The ID of the advertiser the line item belongs to.</param>
                    /// <param
                    /// name="lineItemId">Required. The ID of the line item the assigned targeting option belongs to.</param>
                    /// <param
                    /// name="targetingType">Required. Identifies the type of this assigned targeting option.</param>
                    /// <param
                    /// name="assignedTargetingOptionId">Required. The ID of the assigned targeting option to delete.</param>
                    public virtual DeleteRequest Delete(long advertiserId, long lineItemId, DeleteRequest.TargetingTypeEnum targetingType, string assignedTargetingOptionId)
                    {
                        return new DeleteRequest(service, advertiserId, lineItemId, targetingType, assignedTargetingOptionId);
                    }

                    /// <summary>Deletes an assigned targeting option from a line item.</summary>
                    public class DeleteRequest : DisplayVideoBaseServiceRequest<Google.Apis.DisplayVideo.v1.Data.Empty>
                    {
                        /// <summary>Constructs a new Delete request.</summary>
                        public DeleteRequest(Google.Apis.Services.IClientService service, long advertiserId, long lineItemId, DeleteRequest.TargetingTypeEnum targetingType, string assignedTargetingOptionId) : base(service)
                        {
                            AdvertiserId = advertiserId;
                            LineItemId = lineItemId;
                            TargetingType = targetingType;
                            AssignedTargetingOptionId = assignedTargetingOptionId;
                            InitParameters();
                        }


                        /// <summary>Required. The ID of the advertiser the line item belongs to.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("advertiserId", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual long AdvertiserId { get; private set; }

                        /// <summary>Required. The ID of the line item the assigned targeting option belongs
                        /// to.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("lineItemId", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual long LineItemId { get; private set; }

                        /// <summary>Required. Identifies the type of this assigned targeting option.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("targetingType", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual TargetingTypeEnum TargetingType { get; private set; }

                        /// <summary>Required. Identifies the type of this assigned targeting option.</summary>
                        public enum TargetingTypeEnum
                        {
                            /// <summary>Default value when type is not specified or is unknown in this
                            /// version.</summary>
                            [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_UNSPECIFIED")]
                            TARGETINGTYPEUNSPECIFIED,
                            /// <summary>Target a channel (a custom group of related websites or apps).</summary>
                            [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_CHANNEL")]
                            TARGETINGTYPECHANNEL,
                            /// <summary>Target an app category (for example, education or puzzle games).</summary>
                            [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_APP_CATEGORY")]
                            TARGETINGTYPEAPPCATEGORY,
                            /// <summary>Target a specific app (for example, Angry Birds).</summary>
                            [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_APP")]
                            TARGETINGTYPEAPP,
                            /// <summary>Target a specific url (for example, quora.com).</summary>
                            [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_URL")]
                            TARGETINGTYPEURL,
                            /// <summary>Target ads during a chosen time period on a specific day.</summary>
                            [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_DAY_AND_TIME")]
                            TARGETINGTYPEDAYANDTIME,
                            /// <summary>Target ads to a specific age range (for example, 18-24).</summary>
                            [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_AGE_RANGE")]
                            TARGETINGTYPEAGERANGE,
                            /// <summary>Target ads to the specified regions on a regional location list.</summary>
                            [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_REGIONAL_LOCATION_LIST")]
                            TARGETINGTYPEREGIONALLOCATIONLIST,
                            /// <summary>Target ads to the specified points of interest on a proximity location
                            /// list.</summary>
                            [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_PROXIMITY_LOCATION_LIST")]
                            TARGETINGTYPEPROXIMITYLOCATIONLIST,
                            /// <summary>Target ads to a specific gender (for example, female or male).</summary>
                            [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_GENDER")]
                            TARGETINGTYPEGENDER,
                            /// <summary>Target a specific video player size for video ads.</summary>
                            [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_VIDEO_PLAYER_SIZE")]
                            TARGETINGTYPEVIDEOPLAYERSIZE,
                            /// <summary>Target user rewarded content for video ads.</summary>
                            [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_USER_REWARDED_CONTENT")]
                            TARGETINGTYPEUSERREWARDEDCONTENT,
                            /// <summary>Target ads to a specific parental status (for example, parent or not a
                            /// parent).</summary>
                            [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_PARENTAL_STATUS")]
                            TARGETINGTYPEPARENTALSTATUS,
                            /// <summary>Target video or audio ads in a specific content instream position (for example,
                            /// pre-roll, mid-roll, or post-roll).</summary>
                            [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_CONTENT_INSTREAM_POSITION")]
                            TARGETINGTYPECONTENTINSTREAMPOSITION,
                            /// <summary>Target ads in a specific content outstream position.</summary>
                            [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_CONTENT_OUTSTREAM_POSITION")]
                            TARGETINGTYPECONTENTOUTSTREAMPOSITION,
                            /// <summary>Target ads to a specific device type (for example, tablet or connected
                            /// TV).</summary>
                            [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_DEVICE_TYPE")]
                            TARGETINGTYPEDEVICETYPE,
                            /// <summary>Target ads to an audience or groups of audiences. Singleton field, at most one
                            /// can exist on a single Lineitem at a time.</summary>
                            [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_AUDIENCE_GROUP")]
                            TARGETINGTYPEAUDIENCEGROUP,
                            /// <summary>Target ads to specific web browsers (for example, Chrome).</summary>
                            [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_BROWSER")]
                            TARGETINGTYPEBROWSER,
                            /// <summary>Target ads to a specific household income range (for example, top
                            /// 10%).</summary>
                            [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_HOUSEHOLD_INCOME")]
                            TARGETINGTYPEHOUSEHOLDINCOME,
                            /// <summary>Target ads in a specific on screen position.</summary>
                            [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_ON_SCREEN_POSITION")]
                            TARGETINGTYPEONSCREENPOSITION,
                            /// <summary>Filter web sites through third party verification (for example, IAS or
                            /// DoubleVerify).</summary>
                            [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_THIRD_PARTY_VERIFIER")]
                            TARGETINGTYPETHIRDPARTYVERIFIER,
                            /// <summary>Filter web sites by specific digital content label ratings (for example, DL-MA:
                            /// suitable only for mature audiences).</summary>
                            [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_DIGITAL_CONTENT_LABEL_EXCLUSION")]
                            TARGETINGTYPEDIGITALCONTENTLABELEXCLUSION,
                            /// <summary>Filter website content by sensitive categories (for example, adult).</summary>
                            [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_SENSITIVE_CATEGORY_EXCLUSION")]
                            TARGETINGTYPESENSITIVECATEGORYEXCLUSION,
                            /// <summary>Target ads to a specific environment (for example, web or app).</summary>
                            [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_ENVIRONMENT")]
                            TARGETINGTYPEENVIRONMENT,
                            /// <summary>Target ads to a specific network carrier or internet service provider (ISP)
                            /// (for example, Comcast or Orange).</summary>
                            [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_CARRIER_AND_ISP")]
                            TARGETINGTYPECARRIERANDISP,
                            /// <summary>Target ads to a specific operating system (for example, macOS).</summary>
                            [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_OPERATING_SYSTEM")]
                            TARGETINGTYPEOPERATINGSYSTEM,
                            /// <summary>Target ads to a specific device make or model (for example, Roku or
                            /// Samsung).</summary>
                            [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_DEVICE_MAKE_MODEL")]
                            TARGETINGTYPEDEVICEMAKEMODEL,
                            /// <summary>Target ads to a specific keyword (for example, dog or retriever).</summary>
                            [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_KEYWORD")]
                            TARGETINGTYPEKEYWORD,
                            /// <summary>Target ads to a specific negative keyword list.</summary>
                            [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_NEGATIVE_KEYWORD_LIST")]
                            TARGETINGTYPENEGATIVEKEYWORDLIST,
                            /// <summary>Target ads to a specific viewability (for example, 80% viewable).</summary>
                            [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_VIEWABILITY")]
                            TARGETINGTYPEVIEWABILITY,
                            /// <summary>Target ads to a specific content category (for example, arts &
                            /// entertainment).</summary>
                            [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_CATEGORY")]
                            TARGETINGTYPECATEGORY,
                            /// <summary>Purchase impressions from specific deals and auction packages.</summary>
                            [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_INVENTORY_SOURCE")]
                            TARGETINGTYPEINVENTORYSOURCE,
                            /// <summary>Target ads to a specific language (for example, English or Japanese).</summary>
                            [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_LANGUAGE")]
                            TARGETINGTYPELANGUAGE,
                            /// <summary>Target ads to ads.txt authorized sellers.</summary>
                            [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_AUTHORIZED_SELLER_STATUS")]
                            TARGETINGTYPEAUTHORIZEDSELLERSTATUS,
                            /// <summary>Target ads to a specific regional location (for example, a city or
                            /// state).</summary>
                            [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_GEO_REGION")]
                            TARGETINGTYPEGEOREGION,
                            /// <summary>Purchase impressions from a group of deals and auction packages.</summary>
                            [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_INVENTORY_SOURCE_GROUP")]
                            TARGETINGTYPEINVENTORYSOURCEGROUP,
                            /// <summary>Purchase impressions from specific exchanges.</summary>
                            [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_EXCHANGE")]
                            TARGETINGTYPEEXCHANGE,
                            /// <summary>Purchase impressions from specific sub-exchanges.</summary>
                            [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_SUB_EXCHANGE")]
                            TARGETINGTYPESUBEXCHANGE,
                        }

                        /// <summary>Required. The ID of the assigned targeting option to delete.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("assignedTargetingOptionId", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string AssignedTargetingOptionId { get; private set; }


                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "delete";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "DELETE";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/advertisers/{+advertiserId}/lineItems/{+lineItemId}/targetingTypes/{+targetingType}/assignedTargetingOptions/{+assignedTargetingOptionId}";

                        /// <summary>Initializes Delete parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();

                            RequestParameters.Add("advertiserId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "advertiserId",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^[^/]+$",
                            });
                            RequestParameters.Add("lineItemId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "lineItemId",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^[^/]+$",
                            });
                            RequestParameters.Add("targetingType", new Google.Apis.Discovery.Parameter
                            {
                                Name = "targetingType",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^[^/]+$",
                            });
                            RequestParameters.Add("assignedTargetingOptionId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "assignedTargetingOptionId",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^[^/]+$",
                            });
                        }

                    }

                    /// <summary>Gets a single targeting option assigned to a line item.</summary>
                    /// <param name="advertiserId">Required. The ID of the advertiser the line item belongs to.</param>
                    /// <param
                    /// name="lineItemId">Required. The ID of the line item the assigned targeting option belongs to.</param>
                    /// <param
                    /// name="targetingType">Required. Identifies the type of this assigned targeting option.</param>
                    /// <param
                    /// name="assignedTargetingOptionId">Required. An identifier unique to the targeting type in this line item that
                    /// identifies the assigned targeting option being requested.</param>
                    public virtual GetRequest Get(long advertiserId, long lineItemId, GetRequest.TargetingTypeEnum targetingType, string assignedTargetingOptionId)
                    {
                        return new GetRequest(service, advertiserId, lineItemId, targetingType, assignedTargetingOptionId);
                    }

                    /// <summary>Gets a single targeting option assigned to a line item.</summary>
                    public class GetRequest : DisplayVideoBaseServiceRequest<Google.Apis.DisplayVideo.v1.Data.AssignedTargetingOption>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, long advertiserId, long lineItemId, GetRequest.TargetingTypeEnum targetingType, string assignedTargetingOptionId) : base(service)
                        {
                            AdvertiserId = advertiserId;
                            LineItemId = lineItemId;
                            TargetingType = targetingType;
                            AssignedTargetingOptionId = assignedTargetingOptionId;
                            InitParameters();
                        }


                        /// <summary>Required. The ID of the advertiser the line item belongs to.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("advertiserId", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual long AdvertiserId { get; private set; }

                        /// <summary>Required. The ID of the line item the assigned targeting option belongs
                        /// to.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("lineItemId", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual long LineItemId { get; private set; }

                        /// <summary>Required. Identifies the type of this assigned targeting option.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("targetingType", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual TargetingTypeEnum TargetingType { get; private set; }

                        /// <summary>Required. Identifies the type of this assigned targeting option.</summary>
                        public enum TargetingTypeEnum
                        {
                            /// <summary>Default value when type is not specified or is unknown in this
                            /// version.</summary>
                            [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_UNSPECIFIED")]
                            TARGETINGTYPEUNSPECIFIED,
                            /// <summary>Target a channel (a custom group of related websites or apps).</summary>
                            [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_CHANNEL")]
                            TARGETINGTYPECHANNEL,
                            /// <summary>Target an app category (for example, education or puzzle games).</summary>
                            [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_APP_CATEGORY")]
                            TARGETINGTYPEAPPCATEGORY,
                            /// <summary>Target a specific app (for example, Angry Birds).</summary>
                            [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_APP")]
                            TARGETINGTYPEAPP,
                            /// <summary>Target a specific url (for example, quora.com).</summary>
                            [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_URL")]
                            TARGETINGTYPEURL,
                            /// <summary>Target ads during a chosen time period on a specific day.</summary>
                            [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_DAY_AND_TIME")]
                            TARGETINGTYPEDAYANDTIME,
                            /// <summary>Target ads to a specific age range (for example, 18-24).</summary>
                            [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_AGE_RANGE")]
                            TARGETINGTYPEAGERANGE,
                            /// <summary>Target ads to the specified regions on a regional location list.</summary>
                            [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_REGIONAL_LOCATION_LIST")]
                            TARGETINGTYPEREGIONALLOCATIONLIST,
                            /// <summary>Target ads to the specified points of interest on a proximity location
                            /// list.</summary>
                            [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_PROXIMITY_LOCATION_LIST")]
                            TARGETINGTYPEPROXIMITYLOCATIONLIST,
                            /// <summary>Target ads to a specific gender (for example, female or male).</summary>
                            [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_GENDER")]
                            TARGETINGTYPEGENDER,
                            /// <summary>Target a specific video player size for video ads.</summary>
                            [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_VIDEO_PLAYER_SIZE")]
                            TARGETINGTYPEVIDEOPLAYERSIZE,
                            /// <summary>Target user rewarded content for video ads.</summary>
                            [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_USER_REWARDED_CONTENT")]
                            TARGETINGTYPEUSERREWARDEDCONTENT,
                            /// <summary>Target ads to a specific parental status (for example, parent or not a
                            /// parent).</summary>
                            [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_PARENTAL_STATUS")]
                            TARGETINGTYPEPARENTALSTATUS,
                            /// <summary>Target video or audio ads in a specific content instream position (for example,
                            /// pre-roll, mid-roll, or post-roll).</summary>
                            [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_CONTENT_INSTREAM_POSITION")]
                            TARGETINGTYPECONTENTINSTREAMPOSITION,
                            /// <summary>Target ads in a specific content outstream position.</summary>
                            [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_CONTENT_OUTSTREAM_POSITION")]
                            TARGETINGTYPECONTENTOUTSTREAMPOSITION,
                            /// <summary>Target ads to a specific device type (for example, tablet or connected
                            /// TV).</summary>
                            [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_DEVICE_TYPE")]
                            TARGETINGTYPEDEVICETYPE,
                            /// <summary>Target ads to an audience or groups of audiences. Singleton field, at most one
                            /// can exist on a single Lineitem at a time.</summary>
                            [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_AUDIENCE_GROUP")]
                            TARGETINGTYPEAUDIENCEGROUP,
                            /// <summary>Target ads to specific web browsers (for example, Chrome).</summary>
                            [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_BROWSER")]
                            TARGETINGTYPEBROWSER,
                            /// <summary>Target ads to a specific household income range (for example, top
                            /// 10%).</summary>
                            [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_HOUSEHOLD_INCOME")]
                            TARGETINGTYPEHOUSEHOLDINCOME,
                            /// <summary>Target ads in a specific on screen position.</summary>
                            [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_ON_SCREEN_POSITION")]
                            TARGETINGTYPEONSCREENPOSITION,
                            /// <summary>Filter web sites through third party verification (for example, IAS or
                            /// DoubleVerify).</summary>
                            [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_THIRD_PARTY_VERIFIER")]
                            TARGETINGTYPETHIRDPARTYVERIFIER,
                            /// <summary>Filter web sites by specific digital content label ratings (for example, DL-MA:
                            /// suitable only for mature audiences).</summary>
                            [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_DIGITAL_CONTENT_LABEL_EXCLUSION")]
                            TARGETINGTYPEDIGITALCONTENTLABELEXCLUSION,
                            /// <summary>Filter website content by sensitive categories (for example, adult).</summary>
                            [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_SENSITIVE_CATEGORY_EXCLUSION")]
                            TARGETINGTYPESENSITIVECATEGORYEXCLUSION,
                            /// <summary>Target ads to a specific environment (for example, web or app).</summary>
                            [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_ENVIRONMENT")]
                            TARGETINGTYPEENVIRONMENT,
                            /// <summary>Target ads to a specific network carrier or internet service provider (ISP)
                            /// (for example, Comcast or Orange).</summary>
                            [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_CARRIER_AND_ISP")]
                            TARGETINGTYPECARRIERANDISP,
                            /// <summary>Target ads to a specific operating system (for example, macOS).</summary>
                            [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_OPERATING_SYSTEM")]
                            TARGETINGTYPEOPERATINGSYSTEM,
                            /// <summary>Target ads to a specific device make or model (for example, Roku or
                            /// Samsung).</summary>
                            [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_DEVICE_MAKE_MODEL")]
                            TARGETINGTYPEDEVICEMAKEMODEL,
                            /// <summary>Target ads to a specific keyword (for example, dog or retriever).</summary>
                            [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_KEYWORD")]
                            TARGETINGTYPEKEYWORD,
                            /// <summary>Target ads to a specific negative keyword list.</summary>
                            [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_NEGATIVE_KEYWORD_LIST")]
                            TARGETINGTYPENEGATIVEKEYWORDLIST,
                            /// <summary>Target ads to a specific viewability (for example, 80% viewable).</summary>
                            [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_VIEWABILITY")]
                            TARGETINGTYPEVIEWABILITY,
                            /// <summary>Target ads to a specific content category (for example, arts &
                            /// entertainment).</summary>
                            [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_CATEGORY")]
                            TARGETINGTYPECATEGORY,
                            /// <summary>Purchase impressions from specific deals and auction packages.</summary>
                            [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_INVENTORY_SOURCE")]
                            TARGETINGTYPEINVENTORYSOURCE,
                            /// <summary>Target ads to a specific language (for example, English or Japanese).</summary>
                            [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_LANGUAGE")]
                            TARGETINGTYPELANGUAGE,
                            /// <summary>Target ads to ads.txt authorized sellers.</summary>
                            [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_AUTHORIZED_SELLER_STATUS")]
                            TARGETINGTYPEAUTHORIZEDSELLERSTATUS,
                            /// <summary>Target ads to a specific regional location (for example, a city or
                            /// state).</summary>
                            [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_GEO_REGION")]
                            TARGETINGTYPEGEOREGION,
                            /// <summary>Purchase impressions from a group of deals and auction packages.</summary>
                            [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_INVENTORY_SOURCE_GROUP")]
                            TARGETINGTYPEINVENTORYSOURCEGROUP,
                            /// <summary>Purchase impressions from specific exchanges.</summary>
                            [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_EXCHANGE")]
                            TARGETINGTYPEEXCHANGE,
                            /// <summary>Purchase impressions from specific sub-exchanges.</summary>
                            [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_SUB_EXCHANGE")]
                            TARGETINGTYPESUBEXCHANGE,
                        }

                        /// <summary>Required. An identifier unique to the targeting type in this line item that
                        /// identifies the assigned targeting option being requested.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("assignedTargetingOptionId", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string AssignedTargetingOptionId { get; private set; }


                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "get";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/advertisers/{+advertiserId}/lineItems/{+lineItemId}/targetingTypes/{+targetingType}/assignedTargetingOptions/{+assignedTargetingOptionId}";

                        /// <summary>Initializes Get parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();

                            RequestParameters.Add("advertiserId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "advertiserId",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^[^/]+$",
                            });
                            RequestParameters.Add("lineItemId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "lineItemId",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^[^/]+$",
                            });
                            RequestParameters.Add("targetingType", new Google.Apis.Discovery.Parameter
                            {
                                Name = "targetingType",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^[^/]+$",
                            });
                            RequestParameters.Add("assignedTargetingOptionId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "assignedTargetingOptionId",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^[^/]+$",
                            });
                        }

                    }

                    /// <summary>Lists the targeting options assigned to a line item.</summary>
                    /// <param name="advertiserId">Required. The ID of the advertiser the line item belongs to.</param>
                    /// <param
                    /// name="lineItemId">Required. The ID of the line item to list assigned targeting options for.</param>
                    /// <param
                    /// name="targetingType">Required. Identifies the type of assigned targeting options to list.</param>
                    public virtual ListRequest List(long advertiserId, long lineItemId, ListRequest.TargetingTypeEnum targetingType)
                    {
                        return new ListRequest(service, advertiserId, lineItemId, targetingType);
                    }

                    /// <summary>Lists the targeting options assigned to a line item.</summary>
                    public class ListRequest : DisplayVideoBaseServiceRequest<Google.Apis.DisplayVideo.v1.Data.ListLineItemAssignedTargetingOptionsResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, long advertiserId, long lineItemId, ListRequest.TargetingTypeEnum targetingType) : base(service)
                        {
                            AdvertiserId = advertiserId;
                            LineItemId = lineItemId;
                            TargetingType = targetingType;
                            InitParameters();
                        }


                        /// <summary>Required. The ID of the advertiser the line item belongs to.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("advertiserId", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual long AdvertiserId { get; private set; }

                        /// <summary>Required. The ID of the line item to list assigned targeting options for.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("lineItemId", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual long LineItemId { get; private set; }

                        /// <summary>Required. Identifies the type of assigned targeting options to list.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("targetingType", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual TargetingTypeEnum TargetingType { get; private set; }

                        /// <summary>Required. Identifies the type of assigned targeting options to list.</summary>
                        public enum TargetingTypeEnum
                        {
                            /// <summary>Default value when type is not specified or is unknown in this
                            /// version.</summary>
                            [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_UNSPECIFIED")]
                            TARGETINGTYPEUNSPECIFIED,
                            /// <summary>Target a channel (a custom group of related websites or apps).</summary>
                            [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_CHANNEL")]
                            TARGETINGTYPECHANNEL,
                            /// <summary>Target an app category (for example, education or puzzle games).</summary>
                            [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_APP_CATEGORY")]
                            TARGETINGTYPEAPPCATEGORY,
                            /// <summary>Target a specific app (for example, Angry Birds).</summary>
                            [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_APP")]
                            TARGETINGTYPEAPP,
                            /// <summary>Target a specific url (for example, quora.com).</summary>
                            [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_URL")]
                            TARGETINGTYPEURL,
                            /// <summary>Target ads during a chosen time period on a specific day.</summary>
                            [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_DAY_AND_TIME")]
                            TARGETINGTYPEDAYANDTIME,
                            /// <summary>Target ads to a specific age range (for example, 18-24).</summary>
                            [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_AGE_RANGE")]
                            TARGETINGTYPEAGERANGE,
                            /// <summary>Target ads to the specified regions on a regional location list.</summary>
                            [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_REGIONAL_LOCATION_LIST")]
                            TARGETINGTYPEREGIONALLOCATIONLIST,
                            /// <summary>Target ads to the specified points of interest on a proximity location
                            /// list.</summary>
                            [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_PROXIMITY_LOCATION_LIST")]
                            TARGETINGTYPEPROXIMITYLOCATIONLIST,
                            /// <summary>Target ads to a specific gender (for example, female or male).</summary>
                            [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_GENDER")]
                            TARGETINGTYPEGENDER,
                            /// <summary>Target a specific video player size for video ads.</summary>
                            [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_VIDEO_PLAYER_SIZE")]
                            TARGETINGTYPEVIDEOPLAYERSIZE,
                            /// <summary>Target user rewarded content for video ads.</summary>
                            [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_USER_REWARDED_CONTENT")]
                            TARGETINGTYPEUSERREWARDEDCONTENT,
                            /// <summary>Target ads to a specific parental status (for example, parent or not a
                            /// parent).</summary>
                            [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_PARENTAL_STATUS")]
                            TARGETINGTYPEPARENTALSTATUS,
                            /// <summary>Target video or audio ads in a specific content instream position (for example,
                            /// pre-roll, mid-roll, or post-roll).</summary>
                            [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_CONTENT_INSTREAM_POSITION")]
                            TARGETINGTYPECONTENTINSTREAMPOSITION,
                            /// <summary>Target ads in a specific content outstream position.</summary>
                            [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_CONTENT_OUTSTREAM_POSITION")]
                            TARGETINGTYPECONTENTOUTSTREAMPOSITION,
                            /// <summary>Target ads to a specific device type (for example, tablet or connected
                            /// TV).</summary>
                            [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_DEVICE_TYPE")]
                            TARGETINGTYPEDEVICETYPE,
                            /// <summary>Target ads to an audience or groups of audiences. Singleton field, at most one
                            /// can exist on a single Lineitem at a time.</summary>
                            [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_AUDIENCE_GROUP")]
                            TARGETINGTYPEAUDIENCEGROUP,
                            /// <summary>Target ads to specific web browsers (for example, Chrome).</summary>
                            [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_BROWSER")]
                            TARGETINGTYPEBROWSER,
                            /// <summary>Target ads to a specific household income range (for example, top
                            /// 10%).</summary>
                            [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_HOUSEHOLD_INCOME")]
                            TARGETINGTYPEHOUSEHOLDINCOME,
                            /// <summary>Target ads in a specific on screen position.</summary>
                            [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_ON_SCREEN_POSITION")]
                            TARGETINGTYPEONSCREENPOSITION,
                            /// <summary>Filter web sites through third party verification (for example, IAS or
                            /// DoubleVerify).</summary>
                            [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_THIRD_PARTY_VERIFIER")]
                            TARGETINGTYPETHIRDPARTYVERIFIER,
                            /// <summary>Filter web sites by specific digital content label ratings (for example, DL-MA:
                            /// suitable only for mature audiences).</summary>
                            [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_DIGITAL_CONTENT_LABEL_EXCLUSION")]
                            TARGETINGTYPEDIGITALCONTENTLABELEXCLUSION,
                            /// <summary>Filter website content by sensitive categories (for example, adult).</summary>
                            [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_SENSITIVE_CATEGORY_EXCLUSION")]
                            TARGETINGTYPESENSITIVECATEGORYEXCLUSION,
                            /// <summary>Target ads to a specific environment (for example, web or app).</summary>
                            [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_ENVIRONMENT")]
                            TARGETINGTYPEENVIRONMENT,
                            /// <summary>Target ads to a specific network carrier or internet service provider (ISP)
                            /// (for example, Comcast or Orange).</summary>
                            [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_CARRIER_AND_ISP")]
                            TARGETINGTYPECARRIERANDISP,
                            /// <summary>Target ads to a specific operating system (for example, macOS).</summary>
                            [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_OPERATING_SYSTEM")]
                            TARGETINGTYPEOPERATINGSYSTEM,
                            /// <summary>Target ads to a specific device make or model (for example, Roku or
                            /// Samsung).</summary>
                            [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_DEVICE_MAKE_MODEL")]
                            TARGETINGTYPEDEVICEMAKEMODEL,
                            /// <summary>Target ads to a specific keyword (for example, dog or retriever).</summary>
                            [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_KEYWORD")]
                            TARGETINGTYPEKEYWORD,
                            /// <summary>Target ads to a specific negative keyword list.</summary>
                            [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_NEGATIVE_KEYWORD_LIST")]
                            TARGETINGTYPENEGATIVEKEYWORDLIST,
                            /// <summary>Target ads to a specific viewability (for example, 80% viewable).</summary>
                            [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_VIEWABILITY")]
                            TARGETINGTYPEVIEWABILITY,
                            /// <summary>Target ads to a specific content category (for example, arts &
                            /// entertainment).</summary>
                            [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_CATEGORY")]
                            TARGETINGTYPECATEGORY,
                            /// <summary>Purchase impressions from specific deals and auction packages.</summary>
                            [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_INVENTORY_SOURCE")]
                            TARGETINGTYPEINVENTORYSOURCE,
                            /// <summary>Target ads to a specific language (for example, English or Japanese).</summary>
                            [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_LANGUAGE")]
                            TARGETINGTYPELANGUAGE,
                            /// <summary>Target ads to ads.txt authorized sellers.</summary>
                            [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_AUTHORIZED_SELLER_STATUS")]
                            TARGETINGTYPEAUTHORIZEDSELLERSTATUS,
                            /// <summary>Target ads to a specific regional location (for example, a city or
                            /// state).</summary>
                            [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_GEO_REGION")]
                            TARGETINGTYPEGEOREGION,
                            /// <summary>Purchase impressions from a group of deals and auction packages.</summary>
                            [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_INVENTORY_SOURCE_GROUP")]
                            TARGETINGTYPEINVENTORYSOURCEGROUP,
                            /// <summary>Purchase impressions from specific exchanges.</summary>
                            [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_EXCHANGE")]
                            TARGETINGTYPEEXCHANGE,
                            /// <summary>Purchase impressions from specific sub-exchanges.</summary>
                            [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_SUB_EXCHANGE")]
                            TARGETINGTYPESUBEXCHANGE,
                        }

                        /// <summary>Allows filtering by assigned targeting option properties. Supported syntax: *
                        /// Filter expressions are made up of one or more restrictions. * Restrictions can be combined
                        /// by the logical operator `OR`. * A restriction has the form of `{field} {operator} {value}`.
                        /// * The operator must be `EQUALS (=)`. * Supported fields: - `assignedTargetingOptionId` -
                        /// `inheritance` Examples: * AssignedTargetingOptions with ID 1 or 2
                        /// `assignedTargetingOptionId="1" OR assignedTargetingOptionId="2"` * AssignedTargetingOptions
                        /// with inheritance status of NOT_INHERITED or INHERITED_FROM_PARTNER
                        /// `inheritance="NOT_INHERITED" OR inheritance="INHERITED_FROM_PARTNER"` The length of this
                        /// field should be no more than 500 characters.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string Filter { get; set; }

                        /// <summary>Field by which to sort the list. Acceptable values are: *
                        /// `assignedTargetingOptionId` (default) The default sorting order is ascending. To specify
                        /// descending order for a field, a suffix "desc" should be added to the field name. Example:
                        /// `assignedTargetingOptionId desc`.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string OrderBy { get; set; }

                        /// <summary>Requested page size. Must be between `1` and `100`. If unspecified will default to
                        /// `100`. Returns error code `INVALID_ARGUMENT` if an invalid value is specified.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>A token identifying a page of results the server should return. Typically, this is
                        /// the value of next_page_token returned from the previous call to
                        /// `ListLineItemAssignedTargetingOptions` method. If not specified, the first page of results
                        /// will be returned.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }


                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/advertisers/{+advertiserId}/lineItems/{+lineItemId}/targetingTypes/{+targetingType}/assignedTargetingOptions";

                        /// <summary>Initializes List parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();

                            RequestParameters.Add("advertiserId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "advertiserId",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^[^/]+$",
                            });
                            RequestParameters.Add("lineItemId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "lineItemId",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^[^/]+$",
                            });
                            RequestParameters.Add("targetingType", new Google.Apis.Discovery.Parameter
                            {
                                Name = "targetingType",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^[^/]+$",
                            });
                            RequestParameters.Add("filter", new Google.Apis.Discovery.Parameter
                            {
                                Name = "filter",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
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
                            RequestParameters.Add("pageSize", new Google.Apis.Discovery.Parameter
                            {
                                Name = "pageSize",
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
                }
            }

            /// <summary>Bulk edits targeting options under a single line item. The operation will delete the assigned
            /// targeting options provided in BulkEditLineItemAssignedTargetingOptionsRequest.delete_requests and then
            /// create the assigned targeting options provided in
            /// BulkEditLineItemAssignedTargetingOptionsRequest.create_requests .</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="advertiserId">Required. The ID of the advertiser the line item belongs to.</param>
            /// <param
            /// name="lineItemId">Required. The ID of the line item the assigned targeting option will belong to.</param>
            public virtual BulkEditLineItemAssignedTargetingOptionsRequest BulkEditLineItemAssignedTargetingOptions(Google.Apis.DisplayVideo.v1.Data.BulkEditLineItemAssignedTargetingOptionsRequest body, long advertiserId, long lineItemId)
            {
                return new BulkEditLineItemAssignedTargetingOptionsRequest(service, body, advertiserId, lineItemId);
            }

            /// <summary>Bulk edits targeting options under a single line item. The operation will delete the assigned
            /// targeting options provided in BulkEditLineItemAssignedTargetingOptionsRequest.delete_requests and then
            /// create the assigned targeting options provided in
            /// BulkEditLineItemAssignedTargetingOptionsRequest.create_requests .</summary>
            public class BulkEditLineItemAssignedTargetingOptionsRequest : DisplayVideoBaseServiceRequest<Google.Apis.DisplayVideo.v1.Data.BulkEditLineItemAssignedTargetingOptionsResponse>
            {
                /// <summary>Constructs a new BulkEditLineItemAssignedTargetingOptions request.</summary>
                public BulkEditLineItemAssignedTargetingOptionsRequest(Google.Apis.Services.IClientService service, Google.Apis.DisplayVideo.v1.Data.BulkEditLineItemAssignedTargetingOptionsRequest body, long advertiserId, long lineItemId) : base(service)
                {
                    AdvertiserId = advertiserId;
                    LineItemId = lineItemId;
                    Body = body;
                    InitParameters();
                }


                /// <summary>Required. The ID of the advertiser the line item belongs to.</summary>
                [Google.Apis.Util.RequestParameterAttribute("advertiserId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual long AdvertiserId { get; private set; }

                /// <summary>Required. The ID of the line item the assigned targeting option will belong to.</summary>
                [Google.Apis.Util.RequestParameterAttribute("lineItemId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual long LineItemId { get; private set; }


                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.DisplayVideo.v1.Data.BulkEditLineItemAssignedTargetingOptionsRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "bulkEditLineItemAssignedTargetingOptions";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/advertisers/{+advertiserId}/lineItems/{+lineItemId}:bulkEditLineItemAssignedTargetingOptions";

                /// <summary>Initializes BulkEditLineItemAssignedTargetingOptions parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();

                    RequestParameters.Add("advertiserId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "advertiserId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^[^/]+$",
                    });
                    RequestParameters.Add("lineItemId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "lineItemId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^[^/]+$",
                    });
                }

            }

            /// <summary>Lists assigned targeting options of a line item across targeting types.</summary>
            /// <param name="advertiserId">Required. The ID of the advertiser the line item belongs to.</param>
            /// <param
            /// name="lineItemId">Required. The ID of the line item to list assigned targeting options for.</param>
            public virtual BulkListLineItemAssignedTargetingOptionsRequest BulkListLineItemAssignedTargetingOptions(long advertiserId, long lineItemId)
            {
                return new BulkListLineItemAssignedTargetingOptionsRequest(service, advertiserId, lineItemId);
            }

            /// <summary>Lists assigned targeting options of a line item across targeting types.</summary>
            public class BulkListLineItemAssignedTargetingOptionsRequest : DisplayVideoBaseServiceRequest<Google.Apis.DisplayVideo.v1.Data.BulkListLineItemAssignedTargetingOptionsResponse>
            {
                /// <summary>Constructs a new BulkListLineItemAssignedTargetingOptions request.</summary>
                public BulkListLineItemAssignedTargetingOptionsRequest(Google.Apis.Services.IClientService service, long advertiserId, long lineItemId) : base(service)
                {
                    AdvertiserId = advertiserId;
                    LineItemId = lineItemId;
                    InitParameters();
                }


                /// <summary>Required. The ID of the advertiser the line item belongs to.</summary>
                [Google.Apis.Util.RequestParameterAttribute("advertiserId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual long AdvertiserId { get; private set; }

                /// <summary>Required. The ID of the line item to list assigned targeting options for.</summary>
                [Google.Apis.Util.RequestParameterAttribute("lineItemId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual long LineItemId { get; private set; }

                /// <summary>Allows filtering by assigned targeting option properties. Supported syntax: * Filter
                /// expressions are made up of one or more restrictions. * Restrictions can be combined by the logical
                /// operator `OR` on the same field. * A restriction has the form of `{field} {operator} {value}`. * The
                /// operator must be `EQUALS (=)`. * Supported fields: - `targetingType` - `inheritance` Examples: *
                /// AssignedTargetingOptions of targeting type TARGETING_TYPE_PROXIMITY_LOCATION_LIST or
                /// TARGETING_TYPE_CHANNEL `targetingType="TARGETING_TYPE_PROXIMITY_LOCATION_LIST" OR
                /// targetingType="TARGETING_TYPE_CHANNEL"` * AssignedTargetingOptions with inheritance status of
                /// NOT_INHERITED or INHERITED_FROM_PARTNER `inheritance="NOT_INHERITED" OR
                /// inheritance="INHERITED_FROM_PARTNER"` The length of this field should be no more than 500
                /// characters.</summary>
                [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Filter { get; set; }

                /// <summary>Field by which to sort the list. Acceptable values are: * `targetingType` (default) The
                /// default sorting order is ascending. To specify descending order for a field, a suffix "desc" should
                /// be added to the field name. Example: `targetingType desc`.</summary>
                [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string OrderBy { get; set; }

                /// <summary>Requested page size. The size must be an integer between `1` and `5000`. If unspecified,
                /// the default is '5000'. Returns error code `INVALID_ARGUMENT` if an invalid value is
                /// specified.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>A token that lets the client fetch the next page of results. Typically, this is the value
                /// of next_page_token returned from the previous call to `BulkListLineItemAssignedTargetingOptions`
                /// method. If not specified, the first page of results will be returned.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }


                /// <summary>Gets the method name.</summary>
                public override string MethodName => "bulkListLineItemAssignedTargetingOptions";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/advertisers/{+advertiserId}/lineItems/{+lineItemId}:bulkListLineItemAssignedTargetingOptions";

                /// <summary>Initializes BulkListLineItemAssignedTargetingOptions parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();

                    RequestParameters.Add("advertiserId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "advertiserId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^[^/]+$",
                    });
                    RequestParameters.Add("lineItemId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "lineItemId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^[^/]+$",
                    });
                    RequestParameters.Add("filter", new Google.Apis.Discovery.Parameter
                    {
                        Name = "filter",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
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
                    RequestParameters.Add("pageSize", new Google.Apis.Discovery.Parameter
                    {
                        Name = "pageSize",
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

            /// <summary>Creates a new line item. Returns the newly created line item if successful.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="advertiserId">Output only. The unique ID of the advertiser the line item belongs to.</param>
            public virtual CreateRequest Create(Google.Apis.DisplayVideo.v1.Data.LineItem body, long advertiserId)
            {
                return new CreateRequest(service, body, advertiserId);
            }

            /// <summary>Creates a new line item. Returns the newly created line item if successful.</summary>
            public class CreateRequest : DisplayVideoBaseServiceRequest<Google.Apis.DisplayVideo.v1.Data.LineItem>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.DisplayVideo.v1.Data.LineItem body, long advertiserId) : base(service)
                {
                    AdvertiserId = advertiserId;
                    Body = body;
                    InitParameters();
                }


                /// <summary>Output only. The unique ID of the advertiser the line item belongs to.</summary>
                [Google.Apis.Util.RequestParameterAttribute("advertiserId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual long AdvertiserId { get; private set; }


                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.DisplayVideo.v1.Data.LineItem Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/advertisers/{+advertiserId}/lineItems";

                /// <summary>Initializes Create parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();

                    RequestParameters.Add("advertiserId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "advertiserId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^[^/]+$",
                    });
                }

            }

            /// <summary>Deletes a line item. Returns error code `NOT_FOUND` if the line item does not exist. The line
            /// item should be archived first, i.e. set entity_status to `ENTITY_STATUS_ARCHIVED`, to be able to delete
            /// it.</summary>
            /// <param name="advertiserId">The ID of the advertiser this line item belongs to.</param>
            /// <param
            /// name="lineItemId">The ID of the line item we need to fetch.</param>
            public virtual DeleteRequest Delete(long advertiserId, long lineItemId)
            {
                return new DeleteRequest(service, advertiserId, lineItemId);
            }

            /// <summary>Deletes a line item. Returns error code `NOT_FOUND` if the line item does not exist. The line
            /// item should be archived first, i.e. set entity_status to `ENTITY_STATUS_ARCHIVED`, to be able to delete
            /// it.</summary>
            public class DeleteRequest : DisplayVideoBaseServiceRequest<Google.Apis.DisplayVideo.v1.Data.Empty>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, long advertiserId, long lineItemId) : base(service)
                {
                    AdvertiserId = advertiserId;
                    LineItemId = lineItemId;
                    InitParameters();
                }


                /// <summary>The ID of the advertiser this line item belongs to.</summary>
                [Google.Apis.Util.RequestParameterAttribute("advertiserId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual long AdvertiserId { get; private set; }

                /// <summary>The ID of the line item we need to fetch.</summary>
                [Google.Apis.Util.RequestParameterAttribute("lineItemId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual long LineItemId { get; private set; }


                /// <summary>Gets the method name.</summary>
                public override string MethodName => "delete";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "DELETE";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/advertisers/{+advertiserId}/lineItems/{+lineItemId}";

                /// <summary>Initializes Delete parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();

                    RequestParameters.Add("advertiserId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "advertiserId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^[^/]+$",
                    });
                    RequestParameters.Add("lineItemId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "lineItemId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^[^/]+$",
                    });
                }

            }

            /// <summary>Gets a line item.</summary>
            /// <param name="advertiserId">Required. The ID of the advertiser this line item belongs to.</param>
            /// <param
            /// name="lineItemId">Required. The ID of the line item to fetch.</param>
            public virtual GetRequest Get(long advertiserId, long lineItemId)
            {
                return new GetRequest(service, advertiserId, lineItemId);
            }

            /// <summary>Gets a line item.</summary>
            public class GetRequest : DisplayVideoBaseServiceRequest<Google.Apis.DisplayVideo.v1.Data.LineItem>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, long advertiserId, long lineItemId) : base(service)
                {
                    AdvertiserId = advertiserId;
                    LineItemId = lineItemId;
                    InitParameters();
                }


                /// <summary>Required. The ID of the advertiser this line item belongs to.</summary>
                [Google.Apis.Util.RequestParameterAttribute("advertiserId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual long AdvertiserId { get; private set; }

                /// <summary>Required. The ID of the line item to fetch.</summary>
                [Google.Apis.Util.RequestParameterAttribute("lineItemId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual long LineItemId { get; private set; }


                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/advertisers/{+advertiserId}/lineItems/{+lineItemId}";

                /// <summary>Initializes Get parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();

                    RequestParameters.Add("advertiserId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "advertiserId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^[^/]+$",
                    });
                    RequestParameters.Add("lineItemId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "lineItemId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^[^/]+$",
                    });
                }

            }

            /// <summary>Lists line items in an advertiser. The order is defined by the order_by parameter. If a filter
            /// by entity_status is not specified, line items with `ENTITY_STATUS_ARCHIVED` will not be included in the
            /// results.</summary>
            /// <param name="advertiserId">Required. The ID of the advertiser to list line items for.</param>
            public virtual ListRequest List(long advertiserId)
            {
                return new ListRequest(service, advertiserId);
            }

            /// <summary>Lists line items in an advertiser. The order is defined by the order_by parameter. If a filter
            /// by entity_status is not specified, line items with `ENTITY_STATUS_ARCHIVED` will not be included in the
            /// results.</summary>
            public class ListRequest : DisplayVideoBaseServiceRequest<Google.Apis.DisplayVideo.v1.Data.ListLineItemsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, long advertiserId) : base(service)
                {
                    AdvertiserId = advertiserId;
                    InitParameters();
                }


                /// <summary>Required. The ID of the advertiser to list line items for.</summary>
                [Google.Apis.Util.RequestParameterAttribute("advertiserId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual long AdvertiserId { get; private set; }

                /// <summary>Allows filtering by line item properties. Supported syntax: * Filter expressions are made
                /// up of one or more restrictions. * Restrictions can be combined by `AND` or `OR` logical operators. A
                /// sequence of restrictions implicitly uses `AND`. * A restriction has the form of `{field} {operator}
                /// {value}`. * The operator used on `flight.dateRange.endDate` must be LESS THAN (<). * The operators
                /// used on all other fields must be `EQUALS (=)`. * Supported fields: - `campaignId` - `displayName` -
                /// `insertionOrderId` - `entityStatus` - `lineItemId` - `lineItemType` - `flight.dateRange.endDate`
                /// (input formatted as YYYY-MM-DD) Examples: * All line items under an insertion order:
                /// `insertionOrderId="1234"` * All `ENTITY_STATUS_ACTIVE` or `ENTITY_STATUS_PAUSED` and
                /// `LINE_ITEM_TYPE_DISPLAY_DEFAULT` line items under an advertiser:
                /// `(entityStatus="ENTITY_STATUS_ACTIVE" OR entityStatus="ENTITY_STATUS_PAUSED") AND
                /// lineItemType="LINE_ITEM_TYPE_DISPLAY_DEFAULT"` * All line items whose flight dates end before March
                /// 28, 2019: `flight.dateRange.endDate<"2019-03-28"` The length of this field should be no more than
                /// 500 characters.</summary>
                [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Filter { get; set; }

                /// <summary>Field by which to sort the list. Acceptable values are: * "displayName" (default) *
                /// "entityStatus" * “flight.dateRange.endDate” The default sorting order is ascending. To specify
                /// descending order for a field, a suffix "desc" should be added to the field name. Example:
                /// `displayName desc`.</summary>
                [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string OrderBy { get; set; }

                /// <summary>Requested page size. Must be between `1` and `100`. If unspecified will default to `100`.
                /// Returns error code `INVALID_ARGUMENT` if an invalid value is specified.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>A token identifying a page of results the server should return. Typically, this is the
                /// value of next_page_token returned from the previous call to `ListLineItems` method. If not
                /// specified, the first page of results will be returned.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }


                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/advertisers/{+advertiserId}/lineItems";

                /// <summary>Initializes List parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();

                    RequestParameters.Add("advertiserId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "advertiserId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^[^/]+$",
                    });
                    RequestParameters.Add("filter", new Google.Apis.Discovery.Parameter
                    {
                        Name = "filter",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
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
                    RequestParameters.Add("pageSize", new Google.Apis.Discovery.Parameter
                    {
                        Name = "pageSize",
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

            /// <summary>Updates an existing line item. Returns the updated line item if successful.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="advertiserId">Output only. The unique ID of the advertiser the line item belongs to.</param>
            ///
            /// <param name="lineItemId">Output only. The unique ID of the line item. Assigned by the system.</param>
            public virtual PatchRequest Patch(Google.Apis.DisplayVideo.v1.Data.LineItem body, long advertiserId, long lineItemId)
            {
                return new PatchRequest(service, body, advertiserId, lineItemId);
            }

            /// <summary>Updates an existing line item. Returns the updated line item if successful.</summary>
            public class PatchRequest : DisplayVideoBaseServiceRequest<Google.Apis.DisplayVideo.v1.Data.LineItem>
            {
                /// <summary>Constructs a new Patch request.</summary>
                public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.DisplayVideo.v1.Data.LineItem body, long advertiserId, long lineItemId) : base(service)
                {
                    AdvertiserId = advertiserId;
                    LineItemId = lineItemId;
                    Body = body;
                    InitParameters();
                }


                /// <summary>Output only. The unique ID of the advertiser the line item belongs to.</summary>
                [Google.Apis.Util.RequestParameterAttribute("advertiserId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual long AdvertiserId { get; private set; }

                /// <summary>Output only. The unique ID of the line item. Assigned by the system.</summary>
                [Google.Apis.Util.RequestParameterAttribute("lineItemId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual long LineItemId { get; private set; }

                /// <summary>Required. The mask to control which fields to update.</summary>
                [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                public virtual object UpdateMask { get; set; }


                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.DisplayVideo.v1.Data.LineItem Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "patch";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PATCH";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/advertisers/{+advertiserId}/lineItems/{+lineItemId}";

                /// <summary>Initializes Patch parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();

                    RequestParameters.Add("advertiserId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "advertiserId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^[^/]+$",
                    });
                    RequestParameters.Add("lineItemId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "lineItemId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^[^/]+$",
                    });
                    RequestParameters.Add("updateMask", new Google.Apis.Discovery.Parameter
                    {
                        Name = "updateMask",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }

            }
        }
        /// <summary>Gets the LocationLists resource.</summary>
        public virtual LocationListsResource LocationLists { get; }

        /// <summary>The "locationLists" collection of methods.</summary>
        public class LocationListsResource
        {
            private const string Resource = "locationLists";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public LocationListsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
                AssignedLocations = new AssignedLocationsResource(service);

            }

            /// <summary>Gets the AssignedLocations resource.</summary>
            public virtual AssignedLocationsResource AssignedLocations { get; }

            /// <summary>The "assignedLocations" collection of methods.</summary>
            public class AssignedLocationsResource
            {
                private const string Resource = "assignedLocations";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public AssignedLocationsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;

                }


                /// <summary>Bulk edits multiple assignments between locations and a single location list. The operation
                /// will delete the assigned locations provided in
                /// BulkEditAssignedLocationsRequest.deleted_assigned_locations and then create the assigned locations
                /// provided in BulkEditAssignedLocationsRequest.created_assigned_locations.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="advertiserId">Required. The ID of the DV360 advertiser to which the location list
                /// belongs.</param>
                /// <param name="locationListId">Required. The ID of the location list to which these
                /// assignments are assigned.</param>
                public virtual BulkEditRequest BulkEdit(Google.Apis.DisplayVideo.v1.Data.BulkEditAssignedLocationsRequest body, long advertiserId, long locationListId)
                {
                    return new BulkEditRequest(service, body, advertiserId, locationListId);
                }

                /// <summary>Bulk edits multiple assignments between locations and a single location list. The operation
                /// will delete the assigned locations provided in
                /// BulkEditAssignedLocationsRequest.deleted_assigned_locations and then create the assigned locations
                /// provided in BulkEditAssignedLocationsRequest.created_assigned_locations.</summary>
                public class BulkEditRequest : DisplayVideoBaseServiceRequest<Google.Apis.DisplayVideo.v1.Data.BulkEditAssignedLocationsResponse>
                {
                    /// <summary>Constructs a new BulkEdit request.</summary>
                    public BulkEditRequest(Google.Apis.Services.IClientService service, Google.Apis.DisplayVideo.v1.Data.BulkEditAssignedLocationsRequest body, long advertiserId, long locationListId) : base(service)
                    {
                        AdvertiserId = advertiserId;
                        LocationListId = locationListId;
                        Body = body;
                        InitParameters();
                    }


                    /// <summary>Required. The ID of the DV360 advertiser to which the location list belongs.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("advertiserId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual long AdvertiserId { get; private set; }

                    /// <summary>Required. The ID of the location list to which these assignments are
                    /// assigned.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("locationListId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual long LocationListId { get; private set; }


                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.DisplayVideo.v1.Data.BulkEditAssignedLocationsRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "bulkEdit";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/advertisers/{advertiserId}/locationLists/{+locationListId}/assignedLocations:bulkEdit";

                    /// <summary>Initializes BulkEdit parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();

                        RequestParameters.Add("advertiserId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "advertiserId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("locationListId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "locationListId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^[^/]+$",
                        });
                    }

                }

                /// <summary>Creates an assignment between a location and a location list.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="advertiserId">Required. The ID of the DV360 advertiser to which the location list
                /// belongs.</param>
                /// <param name="locationListId">Required. The ID of the location list for which the assignment
                /// will be created.</param>
                public virtual CreateRequest Create(Google.Apis.DisplayVideo.v1.Data.AssignedLocation body, long advertiserId, long locationListId)
                {
                    return new CreateRequest(service, body, advertiserId, locationListId);
                }

                /// <summary>Creates an assignment between a location and a location list.</summary>
                public class CreateRequest : DisplayVideoBaseServiceRequest<Google.Apis.DisplayVideo.v1.Data.AssignedLocation>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.DisplayVideo.v1.Data.AssignedLocation body, long advertiserId, long locationListId) : base(service)
                    {
                        AdvertiserId = advertiserId;
                        LocationListId = locationListId;
                        Body = body;
                        InitParameters();
                    }


                    /// <summary>Required. The ID of the DV360 advertiser to which the location list belongs.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("advertiserId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual long AdvertiserId { get; private set; }

                    /// <summary>Required. The ID of the location list for which the assignment will be
                    /// created.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("locationListId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual long LocationListId { get; private set; }


                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.DisplayVideo.v1.Data.AssignedLocation Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/advertisers/{advertiserId}/locationLists/{locationListId}/assignedLocations";

                    /// <summary>Initializes Create parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();

                        RequestParameters.Add("advertiserId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "advertiserId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("locationListId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "locationListId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }

                }

                /// <summary>Deletes the assignment between a location and a location list.</summary>
                /// <param name="advertiserId">Required. The ID of the DV360 advertiser to which the location list
                /// belongs.</param>
                /// <param name="locationListId">Required. The ID of the location list to which this assignment
                /// is assigned.</param>
                /// <param name="assignedLocationId">Required. The ID of the assigned location to
                /// delete.</param>
                public virtual DeleteRequest Delete(long advertiserId, long locationListId, long assignedLocationId)
                {
                    return new DeleteRequest(service, advertiserId, locationListId, assignedLocationId);
                }

                /// <summary>Deletes the assignment between a location and a location list.</summary>
                public class DeleteRequest : DisplayVideoBaseServiceRequest<Google.Apis.DisplayVideo.v1.Data.Empty>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, long advertiserId, long locationListId, long assignedLocationId) : base(service)
                    {
                        AdvertiserId = advertiserId;
                        LocationListId = locationListId;
                        AssignedLocationId = assignedLocationId;
                        InitParameters();
                    }


                    /// <summary>Required. The ID of the DV360 advertiser to which the location list belongs.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("advertiserId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual long AdvertiserId { get; private set; }

                    /// <summary>Required. The ID of the location list to which this assignment is assigned.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("locationListId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual long LocationListId { get; private set; }

                    /// <summary>Required. The ID of the assigned location to delete.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("assignedLocationId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual long AssignedLocationId { get; private set; }


                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "delete";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "DELETE";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/advertisers/{advertiserId}/locationLists/{locationListId}/assignedLocations/{+assignedLocationId}";

                    /// <summary>Initializes Delete parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();

                        RequestParameters.Add("advertiserId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "advertiserId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("locationListId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "locationListId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("assignedLocationId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "assignedLocationId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^[^/]+$",
                        });
                    }

                }

                /// <summary>Lists locations assigned to a location list.</summary>
                /// <param name="advertiserId">Required. The ID of the DV360 advertiser to which the location list
                /// belongs.</param>
                /// <param name="locationListId">Required. The ID of the location list to which these
                /// assignments are assigned.</param>
                public virtual ListRequest List(long advertiserId, long locationListId)
                {
                    return new ListRequest(service, advertiserId, locationListId);
                }

                /// <summary>Lists locations assigned to a location list.</summary>
                public class ListRequest : DisplayVideoBaseServiceRequest<Google.Apis.DisplayVideo.v1.Data.ListAssignedLocationsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, long advertiserId, long locationListId) : base(service)
                    {
                        AdvertiserId = advertiserId;
                        LocationListId = locationListId;
                        InitParameters();
                    }


                    /// <summary>Required. The ID of the DV360 advertiser to which the location list belongs.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("advertiserId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual long AdvertiserId { get; private set; }

                    /// <summary>Required. The ID of the location list to which these assignments are
                    /// assigned.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("locationListId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual long LocationListId { get; private set; }

                    /// <summary>Allows filtering by location list assignment fields. Supported syntax: * Filter
                    /// expressions are made up of one or more restrictions. * Restrictions can be combined by the
                    /// logical operator `OR`. * A restriction has the form of `{field} {operator} {value}`. * The
                    /// operator must be `EQUALS (=)`. * Supported fields: - `assignedLocationId` The length of this
                    /// field should be no more than 500 characters.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>Field by which to sort the list. Acceptable values are: * `assignedLocationId`
                    /// (default) The default sorting order is ascending. To specify descending order for a field, a
                    /// suffix " desc" should be added to the field name. Example: `assignedLocationId desc`.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string OrderBy { get; set; }

                    /// <summary>Requested page size. Must be between `1` and `100`. If unspecified will default to
                    /// `100`. Returns error code `INVALID_ARGUMENT` if an invalid value is specified.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>A token identifying a page of results the server should return. Typically, this is the
                    /// value of next_page_token returned from the previous call to `ListAssignedLocations` method. If
                    /// not specified, the first page of results will be returned.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }


                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/advertisers/{advertiserId}/locationLists/{locationListId}/assignedLocations";

                    /// <summary>Initializes List parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();

                        RequestParameters.Add("advertiserId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "advertiserId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("locationListId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "locationListId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("filter", new Google.Apis.Discovery.Parameter
                        {
                            Name = "filter",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
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
                        RequestParameters.Add("pageSize", new Google.Apis.Discovery.Parameter
                        {
                            Name = "pageSize",
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
            }

            /// <summary>Creates a new location list. Returns the newly created location list if successful.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="advertiserId">Required. The ID of the DV360 advertiser to which the location list belongs.</param>
            public virtual CreateRequest Create(Google.Apis.DisplayVideo.v1.Data.LocationList body, long advertiserId)
            {
                return new CreateRequest(service, body, advertiserId);
            }

            /// <summary>Creates a new location list. Returns the newly created location list if successful.</summary>
            public class CreateRequest : DisplayVideoBaseServiceRequest<Google.Apis.DisplayVideo.v1.Data.LocationList>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.DisplayVideo.v1.Data.LocationList body, long advertiserId) : base(service)
                {
                    AdvertiserId = advertiserId;
                    Body = body;
                    InitParameters();
                }


                /// <summary>Required. The ID of the DV360 advertiser to which the location list belongs.</summary>
                [Google.Apis.Util.RequestParameterAttribute("advertiserId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual long AdvertiserId { get; private set; }


                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.DisplayVideo.v1.Data.LocationList Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/advertisers/{+advertiserId}/locationLists";

                /// <summary>Initializes Create parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();

                    RequestParameters.Add("advertiserId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "advertiserId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^[^/]+$",
                    });
                }

            }

            /// <summary>Gets a location list.</summary>
            /// <param name="advertiserId">Required. The ID of the DV360 advertiser to which the fetched location list
            /// belongs.</param>
            /// <param name="locationListId">Required. The ID of the location list to fetch.</param>
            public virtual GetRequest Get(long advertiserId, long locationListId)
            {
                return new GetRequest(service, advertiserId, locationListId);
            }

            /// <summary>Gets a location list.</summary>
            public class GetRequest : DisplayVideoBaseServiceRequest<Google.Apis.DisplayVideo.v1.Data.LocationList>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, long advertiserId, long locationListId) : base(service)
                {
                    AdvertiserId = advertiserId;
                    LocationListId = locationListId;
                    InitParameters();
                }


                /// <summary>Required. The ID of the DV360 advertiser to which the fetched location list
                /// belongs.</summary>
                [Google.Apis.Util.RequestParameterAttribute("advertiserId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual long AdvertiserId { get; private set; }

                /// <summary>Required. The ID of the location list to fetch.</summary>
                [Google.Apis.Util.RequestParameterAttribute("locationListId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual long LocationListId { get; private set; }


                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/advertisers/{+advertiserId}/locationLists/{+locationListId}";

                /// <summary>Initializes Get parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();

                    RequestParameters.Add("advertiserId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "advertiserId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^[^/]+$",
                    });
                    RequestParameters.Add("locationListId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "locationListId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^[^/]+$",
                    });
                }

            }

            /// <summary>Lists location lists based on a given advertiser id.</summary>
            /// <param name="advertiserId">Required. The ID of the DV360 advertiser to which the fetched location lists
            /// belong.</param>
            public virtual ListRequest List(long advertiserId)
            {
                return new ListRequest(service, advertiserId);
            }

            /// <summary>Lists location lists based on a given advertiser id.</summary>
            public class ListRequest : DisplayVideoBaseServiceRequest<Google.Apis.DisplayVideo.v1.Data.ListLocationListsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, long advertiserId) : base(service)
                {
                    AdvertiserId = advertiserId;
                    InitParameters();
                }


                /// <summary>Required. The ID of the DV360 advertiser to which the fetched location lists
                /// belong.</summary>
                [Google.Apis.Util.RequestParameterAttribute("advertiserId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual long AdvertiserId { get; private set; }

                /// <summary>Allows filtering by location list fields. Supported syntax: * Filter expressions are made
                /// up of one or more restrictions. * Restrictions can be combined by `AND` or `OR` logical operators. A
                /// sequence of restrictions implicitly uses `AND`. * A restriction has the form of `{field} {operator}
                /// {value}`. * The operator must be `EQUALS (=)`. * Supported fields: - `locationType` Examples: * All
                /// regional location list: `locationType="TARGETING_LOCATION_TYPE_REGIONAL"` * All proximity location
                /// list: `locationType="TARGETING_LOCATION_TYPE_PROXIMITY"`</summary>
                [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Filter { get; set; }

                /// <summary>Field by which to sort the list. Acceptable values are: * `locationListId` (default) *
                /// `displayName` The default sorting order is ascending. To specify descending order for a field, a
                /// suffix "desc" should be added to the field name. Example: `displayName desc`.</summary>
                [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string OrderBy { get; set; }

                /// <summary>Requested page size. Must be between `1` and `100`. Defaults to `100` if not set. Returns
                /// error code `INVALID_ARGUMENT` if an invalid value is specified.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>A token identifying a page of results the server should return. Typically, this is the
                /// value of next_page_token returned from the previous call to `ListLocationLists` method. If not
                /// specified, the first page of results will be returned.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }


                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/advertisers/{+advertiserId}/locationLists";

                /// <summary>Initializes List parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();

                    RequestParameters.Add("advertiserId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "advertiserId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^[^/]+$",
                    });
                    RequestParameters.Add("filter", new Google.Apis.Discovery.Parameter
                    {
                        Name = "filter",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
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
                    RequestParameters.Add("pageSize", new Google.Apis.Discovery.Parameter
                    {
                        Name = "pageSize",
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

            /// <summary>Updates a location list. Returns the updated location list if successful.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="advertiserId">Required. The ID of the DV360 advertiser to which the location lists
            /// belongs.</param>
            /// <param name="locationListId">Output only. The unique ID of the location list. Assigned by
            /// the system.</param>
            public virtual PatchRequest Patch(Google.Apis.DisplayVideo.v1.Data.LocationList body, long advertiserId, long locationListId)
            {
                return new PatchRequest(service, body, advertiserId, locationListId);
            }

            /// <summary>Updates a location list. Returns the updated location list if successful.</summary>
            public class PatchRequest : DisplayVideoBaseServiceRequest<Google.Apis.DisplayVideo.v1.Data.LocationList>
            {
                /// <summary>Constructs a new Patch request.</summary>
                public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.DisplayVideo.v1.Data.LocationList body, long advertiserId, long locationListId) : base(service)
                {
                    AdvertiserId = advertiserId;
                    LocationListId = locationListId;
                    Body = body;
                    InitParameters();
                }


                /// <summary>Required. The ID of the DV360 advertiser to which the location lists belongs.</summary>
                [Google.Apis.Util.RequestParameterAttribute("advertiserId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual long AdvertiserId { get; private set; }

                /// <summary>Output only. The unique ID of the location list. Assigned by the system.</summary>
                [Google.Apis.Util.RequestParameterAttribute("locationListId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual long LocationListId { get; private set; }

                /// <summary>Required. The mask to control which fields to update.</summary>
                [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                public virtual object UpdateMask { get; set; }


                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.DisplayVideo.v1.Data.LocationList Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "patch";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PATCH";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/advertisers/{+advertiserId}/locationLists/{locationListId}";

                /// <summary>Initializes Patch parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();

                    RequestParameters.Add("advertiserId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "advertiserId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^[^/]+$",
                    });
                    RequestParameters.Add("locationListId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "locationListId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("updateMask", new Google.Apis.Discovery.Parameter
                    {
                        Name = "updateMask",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }

            }
        }
        /// <summary>Gets the NegativeKeywordLists resource.</summary>
        public virtual NegativeKeywordListsResource NegativeKeywordLists { get; }

        /// <summary>The "negativeKeywordLists" collection of methods.</summary>
        public class NegativeKeywordListsResource
        {
            private const string Resource = "negativeKeywordLists";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public NegativeKeywordListsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
                NegativeKeywords = new NegativeKeywordsResource(service);

            }

            /// <summary>Gets the NegativeKeywords resource.</summary>
            public virtual NegativeKeywordsResource NegativeKeywords { get; }

            /// <summary>The "negativeKeywords" collection of methods.</summary>
            public class NegativeKeywordsResource
            {
                private const string Resource = "negativeKeywords";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public NegativeKeywordsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;

                }


                /// <summary>Bulk edits negative keywords in a single negative keyword list. The operation will delete
                /// the negative keywords provided in BulkEditNegativeKeywordsRequest.deleted_negative_keywords and then
                /// create the negative keywords provided in BulkEditNegativeKeywordsRequest.created_negative_keywords.
                /// This operation is guaranteed to be atomic and will never result in a partial success or partial
                /// failure.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="advertiserId">Required. The ID of the DV360 advertiser to which the parent negative keyword list
                /// belongs.</param>
                /// <param name="negativeKeywordListId">Required. The ID of the parent negative keyword list to
                /// which the negative keywords belong.</param>
                public virtual BulkEditRequest BulkEdit(Google.Apis.DisplayVideo.v1.Data.BulkEditNegativeKeywordsRequest body, long advertiserId, long negativeKeywordListId)
                {
                    return new BulkEditRequest(service, body, advertiserId, negativeKeywordListId);
                }

                /// <summary>Bulk edits negative keywords in a single negative keyword list. The operation will delete
                /// the negative keywords provided in BulkEditNegativeKeywordsRequest.deleted_negative_keywords and then
                /// create the negative keywords provided in BulkEditNegativeKeywordsRequest.created_negative_keywords.
                /// This operation is guaranteed to be atomic and will never result in a partial success or partial
                /// failure.</summary>
                public class BulkEditRequest : DisplayVideoBaseServiceRequest<Google.Apis.DisplayVideo.v1.Data.BulkEditNegativeKeywordsResponse>
                {
                    /// <summary>Constructs a new BulkEdit request.</summary>
                    public BulkEditRequest(Google.Apis.Services.IClientService service, Google.Apis.DisplayVideo.v1.Data.BulkEditNegativeKeywordsRequest body, long advertiserId, long negativeKeywordListId) : base(service)
                    {
                        AdvertiserId = advertiserId;
                        NegativeKeywordListId = negativeKeywordListId;
                        Body = body;
                        InitParameters();
                    }


                    /// <summary>Required. The ID of the DV360 advertiser to which the parent negative keyword list
                    /// belongs.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("advertiserId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual long AdvertiserId { get; private set; }

                    /// <summary>Required. The ID of the parent negative keyword list to which the negative keywords
                    /// belong.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("negativeKeywordListId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual long NegativeKeywordListId { get; private set; }


                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.DisplayVideo.v1.Data.BulkEditNegativeKeywordsRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "bulkEdit";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/advertisers/{advertiserId}/negativeKeywordLists/{+negativeKeywordListId}/negativeKeywords:bulkEdit";

                    /// <summary>Initializes BulkEdit parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();

                        RequestParameters.Add("advertiserId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "advertiserId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("negativeKeywordListId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "negativeKeywordListId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^[^/]+$",
                        });
                    }

                }

                /// <summary>Creates a negative keyword in a negative keyword list.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="advertiserId">Required. The ID of the DV360 advertiser to which the parent negative keyword list
                /// belongs.</param>
                /// <param name="negativeKeywordListId">Required. The ID of the parent negative keyword list in
                /// which the negative keyword will be created.</param>
                public virtual CreateRequest Create(Google.Apis.DisplayVideo.v1.Data.NegativeKeyword body, long advertiserId, long negativeKeywordListId)
                {
                    return new CreateRequest(service, body, advertiserId, negativeKeywordListId);
                }

                /// <summary>Creates a negative keyword in a negative keyword list.</summary>
                public class CreateRequest : DisplayVideoBaseServiceRequest<Google.Apis.DisplayVideo.v1.Data.NegativeKeyword>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.DisplayVideo.v1.Data.NegativeKeyword body, long advertiserId, long negativeKeywordListId) : base(service)
                    {
                        AdvertiserId = advertiserId;
                        NegativeKeywordListId = negativeKeywordListId;
                        Body = body;
                        InitParameters();
                    }


                    /// <summary>Required. The ID of the DV360 advertiser to which the parent negative keyword list
                    /// belongs.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("advertiserId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual long AdvertiserId { get; private set; }

                    /// <summary>Required. The ID of the parent negative keyword list in which the negative keyword will
                    /// be created.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("negativeKeywordListId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual long NegativeKeywordListId { get; private set; }


                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.DisplayVideo.v1.Data.NegativeKeyword Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/advertisers/{advertiserId}/negativeKeywordLists/{+negativeKeywordListId}/negativeKeywords";

                    /// <summary>Initializes Create parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();

                        RequestParameters.Add("advertiserId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "advertiserId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("negativeKeywordListId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "negativeKeywordListId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^[^/]+$",
                        });
                    }

                }

                /// <summary>Deletes a negative keyword from a negative keyword list.</summary>
                /// <param name="advertiserId">Required. The ID of the DV360 advertiser to which the parent negative keyword list
                /// belongs.</param>
                /// <param name="negativeKeywordListId">Required. The ID of the parent negative keyword list to
                /// which the negative keyword belongs.</param>
                /// <param name="keywordValue">Required. The keyword value of the
                /// negative keyword to delete.</param>
                public virtual DeleteRequest Delete(long advertiserId, long negativeKeywordListId, string keywordValue)
                {
                    return new DeleteRequest(service, advertiserId, negativeKeywordListId, keywordValue);
                }

                /// <summary>Deletes a negative keyword from a negative keyword list.</summary>
                public class DeleteRequest : DisplayVideoBaseServiceRequest<Google.Apis.DisplayVideo.v1.Data.Empty>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, long advertiserId, long negativeKeywordListId, string keywordValue) : base(service)
                    {
                        AdvertiserId = advertiserId;
                        NegativeKeywordListId = negativeKeywordListId;
                        KeywordValue = keywordValue;
                        InitParameters();
                    }


                    /// <summary>Required. The ID of the DV360 advertiser to which the parent negative keyword list
                    /// belongs.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("advertiserId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual long AdvertiserId { get; private set; }

                    /// <summary>Required. The ID of the parent negative keyword list to which the negative keyword
                    /// belongs.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("negativeKeywordListId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual long NegativeKeywordListId { get; private set; }

                    /// <summary>Required. The keyword value of the negative keyword to delete.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("keywordValue", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string KeywordValue { get; private set; }


                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "delete";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "DELETE";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/advertisers/{advertiserId}/negativeKeywordLists/{+negativeKeywordListId}/negativeKeywords/{+keywordValue}";

                    /// <summary>Initializes Delete parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();

                        RequestParameters.Add("advertiserId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "advertiserId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("negativeKeywordListId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "negativeKeywordListId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^[^/]+$",
                        });
                        RequestParameters.Add("keywordValue", new Google.Apis.Discovery.Parameter
                        {
                            Name = "keywordValue",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^[^/]+$",
                        });
                    }

                }

                /// <summary>Lists negative keywords in a negative keyword list.</summary>
                /// <param name="advertiserId">Required. The ID of the DV360 advertiser to which the parent negative keyword list
                /// belongs.</param>
                /// <param name="negativeKeywordListId">Required. The ID of the parent negative keyword list to
                /// which the requested negative keywords belong.</param>
                public virtual ListRequest List(long advertiserId, long negativeKeywordListId)
                {
                    return new ListRequest(service, advertiserId, negativeKeywordListId);
                }

                /// <summary>Lists negative keywords in a negative keyword list.</summary>
                public class ListRequest : DisplayVideoBaseServiceRequest<Google.Apis.DisplayVideo.v1.Data.ListNegativeKeywordsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, long advertiserId, long negativeKeywordListId) : base(service)
                    {
                        AdvertiserId = advertiserId;
                        NegativeKeywordListId = negativeKeywordListId;
                        InitParameters();
                    }


                    /// <summary>Required. The ID of the DV360 advertiser to which the parent negative keyword list
                    /// belongs.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("advertiserId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual long AdvertiserId { get; private set; }

                    /// <summary>Required. The ID of the parent negative keyword list to which the requested negative
                    /// keywords belong.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("negativeKeywordListId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual long NegativeKeywordListId { get; private set; }

                    /// <summary>Allows filtering by negative keyword fields. Supported syntax: * Filter expressions for
                    /// negative keyword currently can only contain at most one * restriction. * A restriction has the
                    /// form of `{field} {operator} {value}`. * The operator must be `CONTAINS (:)`. * Supported fields:
                    /// - `keywordValue` Examples: * All negative keywords for which the keyword value contains
                    /// "google": `keywordValue : "google"`</summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>Field by which to sort the list. Acceptable values are: * `keywordValue` (default) The
                    /// default sorting order is ascending. To specify descending order for a field, a suffix " desc"
                    /// should be added to the field name. Example: `keywordValue desc`.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string OrderBy { get; set; }

                    /// <summary>Requested page size. Must be between `1` and `100`. If unspecified will default to
                    /// `100`. Returns error code `INVALID_ARGUMENT` if an invalid value is specified.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>A token identifying a page of results the server should return. Typically, this is the
                    /// value of next_page_token returned from the previous call to `ListNegativeKeywords` method. If
                    /// not specified, the first page of results will be returned.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }


                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/advertisers/{+advertiserId}/negativeKeywordLists/{+negativeKeywordListId}/negativeKeywords";

                    /// <summary>Initializes List parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();

                        RequestParameters.Add("advertiserId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "advertiserId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^[^/]+$",
                        });
                        RequestParameters.Add("negativeKeywordListId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "negativeKeywordListId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^[^/]+$",
                        });
                        RequestParameters.Add("filter", new Google.Apis.Discovery.Parameter
                        {
                            Name = "filter",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
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
                        RequestParameters.Add("pageSize", new Google.Apis.Discovery.Parameter
                        {
                            Name = "pageSize",
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
            }

            /// <summary>Creates a new negative keyword list. Returns the newly created negative keyword list if
            /// successful.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="advertiserId">Required. The ID of the DV360 advertiser to which the negative keyword list will
            /// belong.</param>
            public virtual CreateRequest Create(Google.Apis.DisplayVideo.v1.Data.NegativeKeywordList body, long advertiserId)
            {
                return new CreateRequest(service, body, advertiserId);
            }

            /// <summary>Creates a new negative keyword list. Returns the newly created negative keyword list if
            /// successful.</summary>
            public class CreateRequest : DisplayVideoBaseServiceRequest<Google.Apis.DisplayVideo.v1.Data.NegativeKeywordList>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.DisplayVideo.v1.Data.NegativeKeywordList body, long advertiserId) : base(service)
                {
                    AdvertiserId = advertiserId;
                    Body = body;
                    InitParameters();
                }


                /// <summary>Required. The ID of the DV360 advertiser to which the negative keyword list will
                /// belong.</summary>
                [Google.Apis.Util.RequestParameterAttribute("advertiserId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual long AdvertiserId { get; private set; }


                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.DisplayVideo.v1.Data.NegativeKeywordList Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/advertisers/{+advertiserId}/negativeKeywordLists";

                /// <summary>Initializes Create parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();

                    RequestParameters.Add("advertiserId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "advertiserId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^[^/]+$",
                    });
                }

            }

            /// <summary>Deletes a negative keyword list given an advertiser ID and a negative keyword list
            /// ID.</summary>
            /// <param name="advertiserId">Required. The ID of the DV360 advertiser to which the negative keyword list
            /// belongs.</param>
            /// <param name="negativeKeywordListId">Required. The ID of the negative keyword list to
            /// delete.</param>
            public virtual DeleteRequest Delete(long advertiserId, long negativeKeywordListId)
            {
                return new DeleteRequest(service, advertiserId, negativeKeywordListId);
            }

            /// <summary>Deletes a negative keyword list given an advertiser ID and a negative keyword list
            /// ID.</summary>
            public class DeleteRequest : DisplayVideoBaseServiceRequest<Google.Apis.DisplayVideo.v1.Data.Empty>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, long advertiserId, long negativeKeywordListId) : base(service)
                {
                    AdvertiserId = advertiserId;
                    NegativeKeywordListId = negativeKeywordListId;
                    InitParameters();
                }


                /// <summary>Required. The ID of the DV360 advertiser to which the negative keyword list
                /// belongs.</summary>
                [Google.Apis.Util.RequestParameterAttribute("advertiserId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual long AdvertiserId { get; private set; }

                /// <summary>Required. The ID of the negative keyword list to delete.</summary>
                [Google.Apis.Util.RequestParameterAttribute("negativeKeywordListId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual long NegativeKeywordListId { get; private set; }


                /// <summary>Gets the method name.</summary>
                public override string MethodName => "delete";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "DELETE";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/advertisers/{+advertiserId}/negativeKeywordLists/{+negativeKeywordListId}";

                /// <summary>Initializes Delete parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();

                    RequestParameters.Add("advertiserId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "advertiserId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^[^/]+$",
                    });
                    RequestParameters.Add("negativeKeywordListId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "negativeKeywordListId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^[^/]+$",
                    });
                }

            }

            /// <summary>Gets a negative keyword list given an advertiser ID and a negative keyword list ID.</summary>
            /// <param name="advertiserId">Required. The ID of the DV360 advertiser to which the fetched negative keyword list
            /// belongs.</param>
            /// <param name="negativeKeywordListId">Required. The ID of the negative keyword list to
            /// fetch.</param>
            public virtual GetRequest Get(long advertiserId, long negativeKeywordListId)
            {
                return new GetRequest(service, advertiserId, negativeKeywordListId);
            }

            /// <summary>Gets a negative keyword list given an advertiser ID and a negative keyword list ID.</summary>
            public class GetRequest : DisplayVideoBaseServiceRequest<Google.Apis.DisplayVideo.v1.Data.NegativeKeywordList>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, long advertiserId, long negativeKeywordListId) : base(service)
                {
                    AdvertiserId = advertiserId;
                    NegativeKeywordListId = negativeKeywordListId;
                    InitParameters();
                }


                /// <summary>Required. The ID of the DV360 advertiser to which the fetched negative keyword list
                /// belongs.</summary>
                [Google.Apis.Util.RequestParameterAttribute("advertiserId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual long AdvertiserId { get; private set; }

                /// <summary>Required. The ID of the negative keyword list to fetch.</summary>
                [Google.Apis.Util.RequestParameterAttribute("negativeKeywordListId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual long NegativeKeywordListId { get; private set; }


                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/advertisers/{+advertiserId}/negativeKeywordLists/{+negativeKeywordListId}";

                /// <summary>Initializes Get parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();

                    RequestParameters.Add("advertiserId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "advertiserId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^[^/]+$",
                    });
                    RequestParameters.Add("negativeKeywordListId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "negativeKeywordListId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^[^/]+$",
                    });
                }

            }

            /// <summary>Lists negative keyword lists based on a given advertiser id.</summary>
            /// <param name="advertiserId">Required. The ID of the DV360 advertiser to which the fetched negative keyword lists
            /// belong.</param>
            public virtual ListRequest List(long advertiserId)
            {
                return new ListRequest(service, advertiserId);
            }

            /// <summary>Lists negative keyword lists based on a given advertiser id.</summary>
            public class ListRequest : DisplayVideoBaseServiceRequest<Google.Apis.DisplayVideo.v1.Data.ListNegativeKeywordListsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, long advertiserId) : base(service)
                {
                    AdvertiserId = advertiserId;
                    InitParameters();
                }


                /// <summary>Required. The ID of the DV360 advertiser to which the fetched negative keyword lists
                /// belong.</summary>
                [Google.Apis.Util.RequestParameterAttribute("advertiserId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual long AdvertiserId { get; private set; }

                /// <summary>Requested page size. Must be between `1` and `100`. Defaults to `100` if not set. Returns
                /// error code `INVALID_ARGUMENT` if an invalid value is specified.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>A token identifying a page of results the server should return. Typically, this is the
                /// value of next_page_token returned from the previous call to `ListNegativeKeywordLists` method. If
                /// not specified, the first page of results will be returned.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }


                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/advertisers/{+advertiserId}/negativeKeywordLists";

                /// <summary>Initializes List parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();

                    RequestParameters.Add("advertiserId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "advertiserId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^[^/]+$",
                    });
                    RequestParameters.Add("pageSize", new Google.Apis.Discovery.Parameter
                    {
                        Name = "pageSize",
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

            /// <summary>Updates a negative keyword list. Returns the updated negative keyword list if
            /// successful.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="advertiserId">Required. The ID of the DV360 advertiser to which the negative keyword list
            /// belongs.</param>
            /// <param name="negativeKeywordListId">Output only. The unique ID of the negative keyword
            /// list. Assigned by the system.</param>
            public virtual PatchRequest Patch(Google.Apis.DisplayVideo.v1.Data.NegativeKeywordList body, long advertiserId, long negativeKeywordListId)
            {
                return new PatchRequest(service, body, advertiserId, negativeKeywordListId);
            }

            /// <summary>Updates a negative keyword list. Returns the updated negative keyword list if
            /// successful.</summary>
            public class PatchRequest : DisplayVideoBaseServiceRequest<Google.Apis.DisplayVideo.v1.Data.NegativeKeywordList>
            {
                /// <summary>Constructs a new Patch request.</summary>
                public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.DisplayVideo.v1.Data.NegativeKeywordList body, long advertiserId, long negativeKeywordListId) : base(service)
                {
                    AdvertiserId = advertiserId;
                    NegativeKeywordListId = negativeKeywordListId;
                    Body = body;
                    InitParameters();
                }


                /// <summary>Required. The ID of the DV360 advertiser to which the negative keyword list
                /// belongs.</summary>
                [Google.Apis.Util.RequestParameterAttribute("advertiserId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual long AdvertiserId { get; private set; }

                /// <summary>Output only. The unique ID of the negative keyword list. Assigned by the system.</summary>
                [Google.Apis.Util.RequestParameterAttribute("negativeKeywordListId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual long NegativeKeywordListId { get; private set; }

                /// <summary>Required. The mask to control which fields to update.</summary>
                [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                public virtual object UpdateMask { get; set; }


                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.DisplayVideo.v1.Data.NegativeKeywordList Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "patch";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PATCH";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/advertisers/{+advertiserId}/negativeKeywordLists/{negativeKeywordListId}";

                /// <summary>Initializes Patch parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();

                    RequestParameters.Add("advertiserId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "advertiserId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^[^/]+$",
                    });
                    RequestParameters.Add("negativeKeywordListId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "negativeKeywordListId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("updateMask", new Google.Apis.Discovery.Parameter
                    {
                        Name = "updateMask",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }

            }
        }
        /// <summary>Gets the TargetingTypes resource.</summary>
        public virtual TargetingTypesResource TargetingTypes { get; }

        /// <summary>The "targetingTypes" collection of methods.</summary>
        public class TargetingTypesResource
        {
            private const string Resource = "targetingTypes";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public TargetingTypesResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
                AssignedTargetingOptions = new AssignedTargetingOptionsResource(service);

            }

            /// <summary>Gets the AssignedTargetingOptions resource.</summary>
            public virtual AssignedTargetingOptionsResource AssignedTargetingOptions { get; }

            /// <summary>The "assignedTargetingOptions" collection of methods.</summary>
            public class AssignedTargetingOptionsResource
            {
                private const string Resource = "assignedTargetingOptions";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public AssignedTargetingOptionsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;

                }


                /// <summary>Assigns a targeting option to an advertiser. Returns the assigned targeting option if
                /// successful.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="advertiserId">Required. The ID of the advertiser.</param>
                /// <param name="targetingType">Required.
                /// Identifies the type of this assigned targeting option.</param>
                public virtual CreateRequest Create(Google.Apis.DisplayVideo.v1.Data.AssignedTargetingOption body, long advertiserId, CreateRequest.TargetingTypeEnum targetingType)
                {
                    return new CreateRequest(service, body, advertiserId, targetingType);
                }

                /// <summary>Assigns a targeting option to an advertiser. Returns the assigned targeting option if
                /// successful.</summary>
                public class CreateRequest : DisplayVideoBaseServiceRequest<Google.Apis.DisplayVideo.v1.Data.AssignedTargetingOption>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.DisplayVideo.v1.Data.AssignedTargetingOption body, long advertiserId, CreateRequest.TargetingTypeEnum targetingType) : base(service)
                    {
                        AdvertiserId = advertiserId;
                        TargetingType = targetingType;
                        Body = body;
                        InitParameters();
                    }


                    /// <summary>Required. The ID of the advertiser.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("advertiserId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual long AdvertiserId { get; private set; }

                    /// <summary>Required. Identifies the type of this assigned targeting option.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("targetingType", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual TargetingTypeEnum TargetingType { get; private set; }

                    /// <summary>Required. Identifies the type of this assigned targeting option.</summary>
                    public enum TargetingTypeEnum
                    {
                        /// <summary>Default value when type is not specified or is unknown in this version.</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_UNSPECIFIED")]
                        TARGETINGTYPEUNSPECIFIED,
                        /// <summary>Target a channel (a custom group of related websites or apps).</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_CHANNEL")]
                        TARGETINGTYPECHANNEL,
                        /// <summary>Target an app category (for example, education or puzzle games).</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_APP_CATEGORY")]
                        TARGETINGTYPEAPPCATEGORY,
                        /// <summary>Target a specific app (for example, Angry Birds).</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_APP")]
                        TARGETINGTYPEAPP,
                        /// <summary>Target a specific url (for example, quora.com).</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_URL")]
                        TARGETINGTYPEURL,
                        /// <summary>Target ads during a chosen time period on a specific day.</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_DAY_AND_TIME")]
                        TARGETINGTYPEDAYANDTIME,
                        /// <summary>Target ads to a specific age range (for example, 18-24).</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_AGE_RANGE")]
                        TARGETINGTYPEAGERANGE,
                        /// <summary>Target ads to the specified regions on a regional location list.</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_REGIONAL_LOCATION_LIST")]
                        TARGETINGTYPEREGIONALLOCATIONLIST,
                        /// <summary>Target ads to the specified points of interest on a proximity location
                        /// list.</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_PROXIMITY_LOCATION_LIST")]
                        TARGETINGTYPEPROXIMITYLOCATIONLIST,
                        /// <summary>Target ads to a specific gender (for example, female or male).</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_GENDER")]
                        TARGETINGTYPEGENDER,
                        /// <summary>Target a specific video player size for video ads.</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_VIDEO_PLAYER_SIZE")]
                        TARGETINGTYPEVIDEOPLAYERSIZE,
                        /// <summary>Target user rewarded content for video ads.</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_USER_REWARDED_CONTENT")]
                        TARGETINGTYPEUSERREWARDEDCONTENT,
                        /// <summary>Target ads to a specific parental status (for example, parent or not a
                        /// parent).</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_PARENTAL_STATUS")]
                        TARGETINGTYPEPARENTALSTATUS,
                        /// <summary>Target video or audio ads in a specific content instream position (for example,
                        /// pre-roll, mid-roll, or post-roll).</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_CONTENT_INSTREAM_POSITION")]
                        TARGETINGTYPECONTENTINSTREAMPOSITION,
                        /// <summary>Target ads in a specific content outstream position.</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_CONTENT_OUTSTREAM_POSITION")]
                        TARGETINGTYPECONTENTOUTSTREAMPOSITION,
                        /// <summary>Target ads to a specific device type (for example, tablet or connected
                        /// TV).</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_DEVICE_TYPE")]
                        TARGETINGTYPEDEVICETYPE,
                        /// <summary>Target ads to an audience or groups of audiences. Singleton field, at most one can
                        /// exist on a single Lineitem at a time.</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_AUDIENCE_GROUP")]
                        TARGETINGTYPEAUDIENCEGROUP,
                        /// <summary>Target ads to specific web browsers (for example, Chrome).</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_BROWSER")]
                        TARGETINGTYPEBROWSER,
                        /// <summary>Target ads to a specific household income range (for example, top 10%).</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_HOUSEHOLD_INCOME")]
                        TARGETINGTYPEHOUSEHOLDINCOME,
                        /// <summary>Target ads in a specific on screen position.</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_ON_SCREEN_POSITION")]
                        TARGETINGTYPEONSCREENPOSITION,
                        /// <summary>Filter web sites through third party verification (for example, IAS or
                        /// DoubleVerify).</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_THIRD_PARTY_VERIFIER")]
                        TARGETINGTYPETHIRDPARTYVERIFIER,
                        /// <summary>Filter web sites by specific digital content label ratings (for example, DL-MA:
                        /// suitable only for mature audiences).</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_DIGITAL_CONTENT_LABEL_EXCLUSION")]
                        TARGETINGTYPEDIGITALCONTENTLABELEXCLUSION,
                        /// <summary>Filter website content by sensitive categories (for example, adult).</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_SENSITIVE_CATEGORY_EXCLUSION")]
                        TARGETINGTYPESENSITIVECATEGORYEXCLUSION,
                        /// <summary>Target ads to a specific environment (for example, web or app).</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_ENVIRONMENT")]
                        TARGETINGTYPEENVIRONMENT,
                        /// <summary>Target ads to a specific network carrier or internet service provider (ISP) (for
                        /// example, Comcast or Orange).</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_CARRIER_AND_ISP")]
                        TARGETINGTYPECARRIERANDISP,
                        /// <summary>Target ads to a specific operating system (for example, macOS).</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_OPERATING_SYSTEM")]
                        TARGETINGTYPEOPERATINGSYSTEM,
                        /// <summary>Target ads to a specific device make or model (for example, Roku or
                        /// Samsung).</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_DEVICE_MAKE_MODEL")]
                        TARGETINGTYPEDEVICEMAKEMODEL,
                        /// <summary>Target ads to a specific keyword (for example, dog or retriever).</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_KEYWORD")]
                        TARGETINGTYPEKEYWORD,
                        /// <summary>Target ads to a specific negative keyword list.</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_NEGATIVE_KEYWORD_LIST")]
                        TARGETINGTYPENEGATIVEKEYWORDLIST,
                        /// <summary>Target ads to a specific viewability (for example, 80% viewable).</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_VIEWABILITY")]
                        TARGETINGTYPEVIEWABILITY,
                        /// <summary>Target ads to a specific content category (for example, arts &
                        /// entertainment).</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_CATEGORY")]
                        TARGETINGTYPECATEGORY,
                        /// <summary>Purchase impressions from specific deals and auction packages.</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_INVENTORY_SOURCE")]
                        TARGETINGTYPEINVENTORYSOURCE,
                        /// <summary>Target ads to a specific language (for example, English or Japanese).</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_LANGUAGE")]
                        TARGETINGTYPELANGUAGE,
                        /// <summary>Target ads to ads.txt authorized sellers.</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_AUTHORIZED_SELLER_STATUS")]
                        TARGETINGTYPEAUTHORIZEDSELLERSTATUS,
                        /// <summary>Target ads to a specific regional location (for example, a city or
                        /// state).</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_GEO_REGION")]
                        TARGETINGTYPEGEOREGION,
                        /// <summary>Purchase impressions from a group of deals and auction packages.</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_INVENTORY_SOURCE_GROUP")]
                        TARGETINGTYPEINVENTORYSOURCEGROUP,
                        /// <summary>Purchase impressions from specific exchanges.</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_EXCHANGE")]
                        TARGETINGTYPEEXCHANGE,
                        /// <summary>Purchase impressions from specific sub-exchanges.</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_SUB_EXCHANGE")]
                        TARGETINGTYPESUBEXCHANGE,
                    }


                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.DisplayVideo.v1.Data.AssignedTargetingOption Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/advertisers/{+advertiserId}/targetingTypes/{+targetingType}/assignedTargetingOptions";

                    /// <summary>Initializes Create parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();

                        RequestParameters.Add("advertiserId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "advertiserId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^[^/]+$",
                        });
                        RequestParameters.Add("targetingType", new Google.Apis.Discovery.Parameter
                        {
                            Name = "targetingType",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^[^/]+$",
                        });
                    }

                }

                /// <summary>Deletes an assigned targeting option from an advertiser.</summary>
                /// <param name="advertiserId">Required. The ID of the advertiser.</param>
                /// <param name="targetingType">Required.
                /// Identifies the type of this assigned targeting option.</param>
                /// <param
                /// name="assignedTargetingOptionId">Required. The ID of the assigned targeting option to delete.</param>
                public virtual DeleteRequest Delete(long advertiserId, DeleteRequest.TargetingTypeEnum targetingType, string assignedTargetingOptionId)
                {
                    return new DeleteRequest(service, advertiserId, targetingType, assignedTargetingOptionId);
                }

                /// <summary>Deletes an assigned targeting option from an advertiser.</summary>
                public class DeleteRequest : DisplayVideoBaseServiceRequest<Google.Apis.DisplayVideo.v1.Data.Empty>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, long advertiserId, DeleteRequest.TargetingTypeEnum targetingType, string assignedTargetingOptionId) : base(service)
                    {
                        AdvertiserId = advertiserId;
                        TargetingType = targetingType;
                        AssignedTargetingOptionId = assignedTargetingOptionId;
                        InitParameters();
                    }


                    /// <summary>Required. The ID of the advertiser.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("advertiserId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual long AdvertiserId { get; private set; }

                    /// <summary>Required. Identifies the type of this assigned targeting option.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("targetingType", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual TargetingTypeEnum TargetingType { get; private set; }

                    /// <summary>Required. Identifies the type of this assigned targeting option.</summary>
                    public enum TargetingTypeEnum
                    {
                        /// <summary>Default value when type is not specified or is unknown in this version.</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_UNSPECIFIED")]
                        TARGETINGTYPEUNSPECIFIED,
                        /// <summary>Target a channel (a custom group of related websites or apps).</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_CHANNEL")]
                        TARGETINGTYPECHANNEL,
                        /// <summary>Target an app category (for example, education or puzzle games).</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_APP_CATEGORY")]
                        TARGETINGTYPEAPPCATEGORY,
                        /// <summary>Target a specific app (for example, Angry Birds).</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_APP")]
                        TARGETINGTYPEAPP,
                        /// <summary>Target a specific url (for example, quora.com).</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_URL")]
                        TARGETINGTYPEURL,
                        /// <summary>Target ads during a chosen time period on a specific day.</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_DAY_AND_TIME")]
                        TARGETINGTYPEDAYANDTIME,
                        /// <summary>Target ads to a specific age range (for example, 18-24).</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_AGE_RANGE")]
                        TARGETINGTYPEAGERANGE,
                        /// <summary>Target ads to the specified regions on a regional location list.</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_REGIONAL_LOCATION_LIST")]
                        TARGETINGTYPEREGIONALLOCATIONLIST,
                        /// <summary>Target ads to the specified points of interest on a proximity location
                        /// list.</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_PROXIMITY_LOCATION_LIST")]
                        TARGETINGTYPEPROXIMITYLOCATIONLIST,
                        /// <summary>Target ads to a specific gender (for example, female or male).</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_GENDER")]
                        TARGETINGTYPEGENDER,
                        /// <summary>Target a specific video player size for video ads.</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_VIDEO_PLAYER_SIZE")]
                        TARGETINGTYPEVIDEOPLAYERSIZE,
                        /// <summary>Target user rewarded content for video ads.</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_USER_REWARDED_CONTENT")]
                        TARGETINGTYPEUSERREWARDEDCONTENT,
                        /// <summary>Target ads to a specific parental status (for example, parent or not a
                        /// parent).</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_PARENTAL_STATUS")]
                        TARGETINGTYPEPARENTALSTATUS,
                        /// <summary>Target video or audio ads in a specific content instream position (for example,
                        /// pre-roll, mid-roll, or post-roll).</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_CONTENT_INSTREAM_POSITION")]
                        TARGETINGTYPECONTENTINSTREAMPOSITION,
                        /// <summary>Target ads in a specific content outstream position.</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_CONTENT_OUTSTREAM_POSITION")]
                        TARGETINGTYPECONTENTOUTSTREAMPOSITION,
                        /// <summary>Target ads to a specific device type (for example, tablet or connected
                        /// TV).</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_DEVICE_TYPE")]
                        TARGETINGTYPEDEVICETYPE,
                        /// <summary>Target ads to an audience or groups of audiences. Singleton field, at most one can
                        /// exist on a single Lineitem at a time.</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_AUDIENCE_GROUP")]
                        TARGETINGTYPEAUDIENCEGROUP,
                        /// <summary>Target ads to specific web browsers (for example, Chrome).</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_BROWSER")]
                        TARGETINGTYPEBROWSER,
                        /// <summary>Target ads to a specific household income range (for example, top 10%).</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_HOUSEHOLD_INCOME")]
                        TARGETINGTYPEHOUSEHOLDINCOME,
                        /// <summary>Target ads in a specific on screen position.</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_ON_SCREEN_POSITION")]
                        TARGETINGTYPEONSCREENPOSITION,
                        /// <summary>Filter web sites through third party verification (for example, IAS or
                        /// DoubleVerify).</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_THIRD_PARTY_VERIFIER")]
                        TARGETINGTYPETHIRDPARTYVERIFIER,
                        /// <summary>Filter web sites by specific digital content label ratings (for example, DL-MA:
                        /// suitable only for mature audiences).</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_DIGITAL_CONTENT_LABEL_EXCLUSION")]
                        TARGETINGTYPEDIGITALCONTENTLABELEXCLUSION,
                        /// <summary>Filter website content by sensitive categories (for example, adult).</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_SENSITIVE_CATEGORY_EXCLUSION")]
                        TARGETINGTYPESENSITIVECATEGORYEXCLUSION,
                        /// <summary>Target ads to a specific environment (for example, web or app).</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_ENVIRONMENT")]
                        TARGETINGTYPEENVIRONMENT,
                        /// <summary>Target ads to a specific network carrier or internet service provider (ISP) (for
                        /// example, Comcast or Orange).</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_CARRIER_AND_ISP")]
                        TARGETINGTYPECARRIERANDISP,
                        /// <summary>Target ads to a specific operating system (for example, macOS).</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_OPERATING_SYSTEM")]
                        TARGETINGTYPEOPERATINGSYSTEM,
                        /// <summary>Target ads to a specific device make or model (for example, Roku or
                        /// Samsung).</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_DEVICE_MAKE_MODEL")]
                        TARGETINGTYPEDEVICEMAKEMODEL,
                        /// <summary>Target ads to a specific keyword (for example, dog or retriever).</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_KEYWORD")]
                        TARGETINGTYPEKEYWORD,
                        /// <summary>Target ads to a specific negative keyword list.</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_NEGATIVE_KEYWORD_LIST")]
                        TARGETINGTYPENEGATIVEKEYWORDLIST,
                        /// <summary>Target ads to a specific viewability (for example, 80% viewable).</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_VIEWABILITY")]
                        TARGETINGTYPEVIEWABILITY,
                        /// <summary>Target ads to a specific content category (for example, arts &
                        /// entertainment).</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_CATEGORY")]
                        TARGETINGTYPECATEGORY,
                        /// <summary>Purchase impressions from specific deals and auction packages.</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_INVENTORY_SOURCE")]
                        TARGETINGTYPEINVENTORYSOURCE,
                        /// <summary>Target ads to a specific language (for example, English or Japanese).</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_LANGUAGE")]
                        TARGETINGTYPELANGUAGE,
                        /// <summary>Target ads to ads.txt authorized sellers.</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_AUTHORIZED_SELLER_STATUS")]
                        TARGETINGTYPEAUTHORIZEDSELLERSTATUS,
                        /// <summary>Target ads to a specific regional location (for example, a city or
                        /// state).</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_GEO_REGION")]
                        TARGETINGTYPEGEOREGION,
                        /// <summary>Purchase impressions from a group of deals and auction packages.</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_INVENTORY_SOURCE_GROUP")]
                        TARGETINGTYPEINVENTORYSOURCEGROUP,
                        /// <summary>Purchase impressions from specific exchanges.</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_EXCHANGE")]
                        TARGETINGTYPEEXCHANGE,
                        /// <summary>Purchase impressions from specific sub-exchanges.</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_SUB_EXCHANGE")]
                        TARGETINGTYPESUBEXCHANGE,
                    }

                    /// <summary>Required. The ID of the assigned targeting option to delete.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("assignedTargetingOptionId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string AssignedTargetingOptionId { get; private set; }


                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "delete";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "DELETE";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/advertisers/{+advertiserId}/targetingTypes/{+targetingType}/assignedTargetingOptions/{+assignedTargetingOptionId}";

                    /// <summary>Initializes Delete parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();

                        RequestParameters.Add("advertiserId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "advertiserId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^[^/]+$",
                        });
                        RequestParameters.Add("targetingType", new Google.Apis.Discovery.Parameter
                        {
                            Name = "targetingType",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^[^/]+$",
                        });
                        RequestParameters.Add("assignedTargetingOptionId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "assignedTargetingOptionId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^[^/]+$",
                        });
                    }

                }

                /// <summary>Gets a single targeting option assigned to an advertiser.</summary>
                /// <param name="advertiserId">Required. The ID of the advertiser.</param>
                /// <param name="targetingType">Required.
                /// Identifies the type of this assigned targeting option.</param>
                /// <param
                /// name="assignedTargetingOptionId">Required. An identifier unique to the targeting type in this advertiser that
                /// identifies the assigned targeting option being requested.</param>
                public virtual GetRequest Get(long advertiserId, GetRequest.TargetingTypeEnum targetingType, string assignedTargetingOptionId)
                {
                    return new GetRequest(service, advertiserId, targetingType, assignedTargetingOptionId);
                }

                /// <summary>Gets a single targeting option assigned to an advertiser.</summary>
                public class GetRequest : DisplayVideoBaseServiceRequest<Google.Apis.DisplayVideo.v1.Data.AssignedTargetingOption>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, long advertiserId, GetRequest.TargetingTypeEnum targetingType, string assignedTargetingOptionId) : base(service)
                    {
                        AdvertiserId = advertiserId;
                        TargetingType = targetingType;
                        AssignedTargetingOptionId = assignedTargetingOptionId;
                        InitParameters();
                    }


                    /// <summary>Required. The ID of the advertiser.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("advertiserId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual long AdvertiserId { get; private set; }

                    /// <summary>Required. Identifies the type of this assigned targeting option.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("targetingType", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual TargetingTypeEnum TargetingType { get; private set; }

                    /// <summary>Required. Identifies the type of this assigned targeting option.</summary>
                    public enum TargetingTypeEnum
                    {
                        /// <summary>Default value when type is not specified or is unknown in this version.</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_UNSPECIFIED")]
                        TARGETINGTYPEUNSPECIFIED,
                        /// <summary>Target a channel (a custom group of related websites or apps).</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_CHANNEL")]
                        TARGETINGTYPECHANNEL,
                        /// <summary>Target an app category (for example, education or puzzle games).</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_APP_CATEGORY")]
                        TARGETINGTYPEAPPCATEGORY,
                        /// <summary>Target a specific app (for example, Angry Birds).</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_APP")]
                        TARGETINGTYPEAPP,
                        /// <summary>Target a specific url (for example, quora.com).</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_URL")]
                        TARGETINGTYPEURL,
                        /// <summary>Target ads during a chosen time period on a specific day.</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_DAY_AND_TIME")]
                        TARGETINGTYPEDAYANDTIME,
                        /// <summary>Target ads to a specific age range (for example, 18-24).</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_AGE_RANGE")]
                        TARGETINGTYPEAGERANGE,
                        /// <summary>Target ads to the specified regions on a regional location list.</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_REGIONAL_LOCATION_LIST")]
                        TARGETINGTYPEREGIONALLOCATIONLIST,
                        /// <summary>Target ads to the specified points of interest on a proximity location
                        /// list.</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_PROXIMITY_LOCATION_LIST")]
                        TARGETINGTYPEPROXIMITYLOCATIONLIST,
                        /// <summary>Target ads to a specific gender (for example, female or male).</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_GENDER")]
                        TARGETINGTYPEGENDER,
                        /// <summary>Target a specific video player size for video ads.</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_VIDEO_PLAYER_SIZE")]
                        TARGETINGTYPEVIDEOPLAYERSIZE,
                        /// <summary>Target user rewarded content for video ads.</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_USER_REWARDED_CONTENT")]
                        TARGETINGTYPEUSERREWARDEDCONTENT,
                        /// <summary>Target ads to a specific parental status (for example, parent or not a
                        /// parent).</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_PARENTAL_STATUS")]
                        TARGETINGTYPEPARENTALSTATUS,
                        /// <summary>Target video or audio ads in a specific content instream position (for example,
                        /// pre-roll, mid-roll, or post-roll).</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_CONTENT_INSTREAM_POSITION")]
                        TARGETINGTYPECONTENTINSTREAMPOSITION,
                        /// <summary>Target ads in a specific content outstream position.</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_CONTENT_OUTSTREAM_POSITION")]
                        TARGETINGTYPECONTENTOUTSTREAMPOSITION,
                        /// <summary>Target ads to a specific device type (for example, tablet or connected
                        /// TV).</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_DEVICE_TYPE")]
                        TARGETINGTYPEDEVICETYPE,
                        /// <summary>Target ads to an audience or groups of audiences. Singleton field, at most one can
                        /// exist on a single Lineitem at a time.</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_AUDIENCE_GROUP")]
                        TARGETINGTYPEAUDIENCEGROUP,
                        /// <summary>Target ads to specific web browsers (for example, Chrome).</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_BROWSER")]
                        TARGETINGTYPEBROWSER,
                        /// <summary>Target ads to a specific household income range (for example, top 10%).</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_HOUSEHOLD_INCOME")]
                        TARGETINGTYPEHOUSEHOLDINCOME,
                        /// <summary>Target ads in a specific on screen position.</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_ON_SCREEN_POSITION")]
                        TARGETINGTYPEONSCREENPOSITION,
                        /// <summary>Filter web sites through third party verification (for example, IAS or
                        /// DoubleVerify).</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_THIRD_PARTY_VERIFIER")]
                        TARGETINGTYPETHIRDPARTYVERIFIER,
                        /// <summary>Filter web sites by specific digital content label ratings (for example, DL-MA:
                        /// suitable only for mature audiences).</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_DIGITAL_CONTENT_LABEL_EXCLUSION")]
                        TARGETINGTYPEDIGITALCONTENTLABELEXCLUSION,
                        /// <summary>Filter website content by sensitive categories (for example, adult).</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_SENSITIVE_CATEGORY_EXCLUSION")]
                        TARGETINGTYPESENSITIVECATEGORYEXCLUSION,
                        /// <summary>Target ads to a specific environment (for example, web or app).</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_ENVIRONMENT")]
                        TARGETINGTYPEENVIRONMENT,
                        /// <summary>Target ads to a specific network carrier or internet service provider (ISP) (for
                        /// example, Comcast or Orange).</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_CARRIER_AND_ISP")]
                        TARGETINGTYPECARRIERANDISP,
                        /// <summary>Target ads to a specific operating system (for example, macOS).</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_OPERATING_SYSTEM")]
                        TARGETINGTYPEOPERATINGSYSTEM,
                        /// <summary>Target ads to a specific device make or model (for example, Roku or
                        /// Samsung).</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_DEVICE_MAKE_MODEL")]
                        TARGETINGTYPEDEVICEMAKEMODEL,
                        /// <summary>Target ads to a specific keyword (for example, dog or retriever).</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_KEYWORD")]
                        TARGETINGTYPEKEYWORD,
                        /// <summary>Target ads to a specific negative keyword list.</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_NEGATIVE_KEYWORD_LIST")]
                        TARGETINGTYPENEGATIVEKEYWORDLIST,
                        /// <summary>Target ads to a specific viewability (for example, 80% viewable).</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_VIEWABILITY")]
                        TARGETINGTYPEVIEWABILITY,
                        /// <summary>Target ads to a specific content category (for example, arts &
                        /// entertainment).</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_CATEGORY")]
                        TARGETINGTYPECATEGORY,
                        /// <summary>Purchase impressions from specific deals and auction packages.</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_INVENTORY_SOURCE")]
                        TARGETINGTYPEINVENTORYSOURCE,
                        /// <summary>Target ads to a specific language (for example, English or Japanese).</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_LANGUAGE")]
                        TARGETINGTYPELANGUAGE,
                        /// <summary>Target ads to ads.txt authorized sellers.</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_AUTHORIZED_SELLER_STATUS")]
                        TARGETINGTYPEAUTHORIZEDSELLERSTATUS,
                        /// <summary>Target ads to a specific regional location (for example, a city or
                        /// state).</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_GEO_REGION")]
                        TARGETINGTYPEGEOREGION,
                        /// <summary>Purchase impressions from a group of deals and auction packages.</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_INVENTORY_SOURCE_GROUP")]
                        TARGETINGTYPEINVENTORYSOURCEGROUP,
                        /// <summary>Purchase impressions from specific exchanges.</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_EXCHANGE")]
                        TARGETINGTYPEEXCHANGE,
                        /// <summary>Purchase impressions from specific sub-exchanges.</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_SUB_EXCHANGE")]
                        TARGETINGTYPESUBEXCHANGE,
                    }

                    /// <summary>Required. An identifier unique to the targeting type in this advertiser that identifies
                    /// the assigned targeting option being requested.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("assignedTargetingOptionId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string AssignedTargetingOptionId { get; private set; }


                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "get";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/advertisers/{+advertiserId}/targetingTypes/{+targetingType}/assignedTargetingOptions/{+assignedTargetingOptionId}";

                    /// <summary>Initializes Get parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();

                        RequestParameters.Add("advertiserId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "advertiserId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^[^/]+$",
                        });
                        RequestParameters.Add("targetingType", new Google.Apis.Discovery.Parameter
                        {
                            Name = "targetingType",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^[^/]+$",
                        });
                        RequestParameters.Add("assignedTargetingOptionId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "assignedTargetingOptionId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^[^/]+$",
                        });
                    }

                }

                /// <summary>Lists the targeting options assigned to an advertiser.</summary>
                /// <param name="advertiserId">Required. The ID of the advertiser.</param>
                /// <param name="targetingType">Required.
                /// Identifies the type of assigned targeting options to list.</param>
                public virtual ListRequest List(long advertiserId, ListRequest.TargetingTypeEnum targetingType)
                {
                    return new ListRequest(service, advertiserId, targetingType);
                }

                /// <summary>Lists the targeting options assigned to an advertiser.</summary>
                public class ListRequest : DisplayVideoBaseServiceRequest<Google.Apis.DisplayVideo.v1.Data.ListAdvertiserAssignedTargetingOptionsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, long advertiserId, ListRequest.TargetingTypeEnum targetingType) : base(service)
                    {
                        AdvertiserId = advertiserId;
                        TargetingType = targetingType;
                        InitParameters();
                    }


                    /// <summary>Required. The ID of the advertiser.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("advertiserId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual long AdvertiserId { get; private set; }

                    /// <summary>Required. Identifies the type of assigned targeting options to list.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("targetingType", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual TargetingTypeEnum TargetingType { get; private set; }

                    /// <summary>Required. Identifies the type of assigned targeting options to list.</summary>
                    public enum TargetingTypeEnum
                    {
                        /// <summary>Default value when type is not specified or is unknown in this version.</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_UNSPECIFIED")]
                        TARGETINGTYPEUNSPECIFIED,
                        /// <summary>Target a channel (a custom group of related websites or apps).</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_CHANNEL")]
                        TARGETINGTYPECHANNEL,
                        /// <summary>Target an app category (for example, education or puzzle games).</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_APP_CATEGORY")]
                        TARGETINGTYPEAPPCATEGORY,
                        /// <summary>Target a specific app (for example, Angry Birds).</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_APP")]
                        TARGETINGTYPEAPP,
                        /// <summary>Target a specific url (for example, quora.com).</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_URL")]
                        TARGETINGTYPEURL,
                        /// <summary>Target ads during a chosen time period on a specific day.</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_DAY_AND_TIME")]
                        TARGETINGTYPEDAYANDTIME,
                        /// <summary>Target ads to a specific age range (for example, 18-24).</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_AGE_RANGE")]
                        TARGETINGTYPEAGERANGE,
                        /// <summary>Target ads to the specified regions on a regional location list.</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_REGIONAL_LOCATION_LIST")]
                        TARGETINGTYPEREGIONALLOCATIONLIST,
                        /// <summary>Target ads to the specified points of interest on a proximity location
                        /// list.</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_PROXIMITY_LOCATION_LIST")]
                        TARGETINGTYPEPROXIMITYLOCATIONLIST,
                        /// <summary>Target ads to a specific gender (for example, female or male).</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_GENDER")]
                        TARGETINGTYPEGENDER,
                        /// <summary>Target a specific video player size for video ads.</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_VIDEO_PLAYER_SIZE")]
                        TARGETINGTYPEVIDEOPLAYERSIZE,
                        /// <summary>Target user rewarded content for video ads.</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_USER_REWARDED_CONTENT")]
                        TARGETINGTYPEUSERREWARDEDCONTENT,
                        /// <summary>Target ads to a specific parental status (for example, parent or not a
                        /// parent).</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_PARENTAL_STATUS")]
                        TARGETINGTYPEPARENTALSTATUS,
                        /// <summary>Target video or audio ads in a specific content instream position (for example,
                        /// pre-roll, mid-roll, or post-roll).</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_CONTENT_INSTREAM_POSITION")]
                        TARGETINGTYPECONTENTINSTREAMPOSITION,
                        /// <summary>Target ads in a specific content outstream position.</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_CONTENT_OUTSTREAM_POSITION")]
                        TARGETINGTYPECONTENTOUTSTREAMPOSITION,
                        /// <summary>Target ads to a specific device type (for example, tablet or connected
                        /// TV).</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_DEVICE_TYPE")]
                        TARGETINGTYPEDEVICETYPE,
                        /// <summary>Target ads to an audience or groups of audiences. Singleton field, at most one can
                        /// exist on a single Lineitem at a time.</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_AUDIENCE_GROUP")]
                        TARGETINGTYPEAUDIENCEGROUP,
                        /// <summary>Target ads to specific web browsers (for example, Chrome).</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_BROWSER")]
                        TARGETINGTYPEBROWSER,
                        /// <summary>Target ads to a specific household income range (for example, top 10%).</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_HOUSEHOLD_INCOME")]
                        TARGETINGTYPEHOUSEHOLDINCOME,
                        /// <summary>Target ads in a specific on screen position.</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_ON_SCREEN_POSITION")]
                        TARGETINGTYPEONSCREENPOSITION,
                        /// <summary>Filter web sites through third party verification (for example, IAS or
                        /// DoubleVerify).</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_THIRD_PARTY_VERIFIER")]
                        TARGETINGTYPETHIRDPARTYVERIFIER,
                        /// <summary>Filter web sites by specific digital content label ratings (for example, DL-MA:
                        /// suitable only for mature audiences).</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_DIGITAL_CONTENT_LABEL_EXCLUSION")]
                        TARGETINGTYPEDIGITALCONTENTLABELEXCLUSION,
                        /// <summary>Filter website content by sensitive categories (for example, adult).</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_SENSITIVE_CATEGORY_EXCLUSION")]
                        TARGETINGTYPESENSITIVECATEGORYEXCLUSION,
                        /// <summary>Target ads to a specific environment (for example, web or app).</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_ENVIRONMENT")]
                        TARGETINGTYPEENVIRONMENT,
                        /// <summary>Target ads to a specific network carrier or internet service provider (ISP) (for
                        /// example, Comcast or Orange).</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_CARRIER_AND_ISP")]
                        TARGETINGTYPECARRIERANDISP,
                        /// <summary>Target ads to a specific operating system (for example, macOS).</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_OPERATING_SYSTEM")]
                        TARGETINGTYPEOPERATINGSYSTEM,
                        /// <summary>Target ads to a specific device make or model (for example, Roku or
                        /// Samsung).</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_DEVICE_MAKE_MODEL")]
                        TARGETINGTYPEDEVICEMAKEMODEL,
                        /// <summary>Target ads to a specific keyword (for example, dog or retriever).</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_KEYWORD")]
                        TARGETINGTYPEKEYWORD,
                        /// <summary>Target ads to a specific negative keyword list.</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_NEGATIVE_KEYWORD_LIST")]
                        TARGETINGTYPENEGATIVEKEYWORDLIST,
                        /// <summary>Target ads to a specific viewability (for example, 80% viewable).</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_VIEWABILITY")]
                        TARGETINGTYPEVIEWABILITY,
                        /// <summary>Target ads to a specific content category (for example, arts &
                        /// entertainment).</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_CATEGORY")]
                        TARGETINGTYPECATEGORY,
                        /// <summary>Purchase impressions from specific deals and auction packages.</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_INVENTORY_SOURCE")]
                        TARGETINGTYPEINVENTORYSOURCE,
                        /// <summary>Target ads to a specific language (for example, English or Japanese).</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_LANGUAGE")]
                        TARGETINGTYPELANGUAGE,
                        /// <summary>Target ads to ads.txt authorized sellers.</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_AUTHORIZED_SELLER_STATUS")]
                        TARGETINGTYPEAUTHORIZEDSELLERSTATUS,
                        /// <summary>Target ads to a specific regional location (for example, a city or
                        /// state).</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_GEO_REGION")]
                        TARGETINGTYPEGEOREGION,
                        /// <summary>Purchase impressions from a group of deals and auction packages.</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_INVENTORY_SOURCE_GROUP")]
                        TARGETINGTYPEINVENTORYSOURCEGROUP,
                        /// <summary>Purchase impressions from specific exchanges.</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_EXCHANGE")]
                        TARGETINGTYPEEXCHANGE,
                        /// <summary>Purchase impressions from specific sub-exchanges.</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_SUB_EXCHANGE")]
                        TARGETINGTYPESUBEXCHANGE,
                    }

                    /// <summary>Allows filtering by assigned targeting option properties. Supported syntax: * Filter
                    /// expressions are made up of one or more restrictions. * Restrictions can be combined by the
                    /// logical operator `OR`. * A restriction has the form of `{field} {operator} {value}`. * The
                    /// operator must be `EQUALS (=)`. * Supported fields: - `assignedTargetingOptionId` Examples: *
                    /// AssignedTargetingOption with ID 123456 `assignedTargetingOptionId="123456"` The length of this
                    /// field should be no more than 500 characters.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>Field by which to sort the list. Acceptable values are: * `assignedTargetingOptionId`
                    /// (default) The default sorting order is ascending. To specify descending order for a field, a
                    /// suffix "desc" should be added to the field name. Example: `assignedTargetingOptionId
                    /// desc`.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string OrderBy { get; set; }

                    /// <summary>Requested page size. Must be between `1` and `100`. If unspecified will default to
                    /// `100`. Returns error code `INVALID_ARGUMENT` if an invalid value is specified.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>A token identifying a page of results the server should return. Typically, this is the
                    /// value of next_page_token returned from the previous call to
                    /// `ListAdvertiserAssignedTargetingOptions` method. If not specified, the first page of results
                    /// will be returned.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }


                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/advertisers/{+advertiserId}/targetingTypes/{+targetingType}/assignedTargetingOptions";

                    /// <summary>Initializes List parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();

                        RequestParameters.Add("advertiserId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "advertiserId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^[^/]+$",
                        });
                        RequestParameters.Add("targetingType", new Google.Apis.Discovery.Parameter
                        {
                            Name = "targetingType",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^[^/]+$",
                        });
                        RequestParameters.Add("filter", new Google.Apis.Discovery.Parameter
                        {
                            Name = "filter",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
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
                        RequestParameters.Add("pageSize", new Google.Apis.Discovery.Parameter
                        {
                            Name = "pageSize",
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
            }
        }

        /// <summary>Audits an advertiser. Returns the counts of used entities per resource type under the advertiser
        /// provided. Used entities count towards their respective resource limit. See
        /// https://support.google.com/displayvideo/answer/6071450.</summary>
        /// <param name="advertiserId">Required. The ID of the advertiser to audit.</param>
        public virtual AuditRequest Audit(long advertiserId)
        {
            return new AuditRequest(service, advertiserId);
        }

        /// <summary>Audits an advertiser. Returns the counts of used entities per resource type under the advertiser
        /// provided. Used entities count towards their respective resource limit. See
        /// https://support.google.com/displayvideo/answer/6071450.</summary>
        public class AuditRequest : DisplayVideoBaseServiceRequest<Google.Apis.DisplayVideo.v1.Data.AuditAdvertiserResponse>
        {
            /// <summary>Constructs a new Audit request.</summary>
            public AuditRequest(Google.Apis.Services.IClientService service, long advertiserId) : base(service)
            {
                AdvertiserId = advertiserId;
                InitParameters();
            }


            /// <summary>Required. The ID of the advertiser to audit.</summary>
            [Google.Apis.Util.RequestParameterAttribute("advertiserId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual long AdvertiserId { get; private set; }

            /// <summary>Optional. The specific fields to return. If no mask is specified, all fields in the response
            /// proto will be filled. Valid values are: * usedLineItemsCount * usedInsertionOrdersCount *
            /// usedCampaignsCount * channelsCount * negativelyTargetedChannelsCount * negativeKeywordListsCount *
            /// adGroupCriteriaCount * campaignCriteriaCount</summary>
            [Google.Apis.Util.RequestParameterAttribute("readMask", Google.Apis.Util.RequestParameterType.Query)]
            public virtual object ReadMask { get; set; }


            /// <summary>Gets the method name.</summary>
            public override string MethodName => "audit";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/advertisers/{+advertiserId}:audit";

            /// <summary>Initializes Audit parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add("advertiserId", new Google.Apis.Discovery.Parameter
                {
                    Name = "advertiserId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^[^/]+$",
                });
                RequestParameters.Add("readMask", new Google.Apis.Discovery.Parameter
                {
                    Name = "readMask",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }

        }

        /// <summary>Bulk edits targeting options under a single advertiser. The operation will delete the assigned
        /// targeting options provided in BulkEditAdvertiserAssignedTargetingOptionsRequest.delete_requests and then
        /// create the assigned targeting options provided in
        /// BulkEditAdvertiserAssignedTargetingOptionsRequest.create_requests .</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="advertiserId">Required. The ID of the advertiser.</param>
        public virtual BulkEditAdvertiserAssignedTargetingOptionsRequest BulkEditAdvertiserAssignedTargetingOptions(Google.Apis.DisplayVideo.v1.Data.BulkEditAdvertiserAssignedTargetingOptionsRequest body, long advertiserId)
        {
            return new BulkEditAdvertiserAssignedTargetingOptionsRequest(service, body, advertiserId);
        }

        /// <summary>Bulk edits targeting options under a single advertiser. The operation will delete the assigned
        /// targeting options provided in BulkEditAdvertiserAssignedTargetingOptionsRequest.delete_requests and then
        /// create the assigned targeting options provided in
        /// BulkEditAdvertiserAssignedTargetingOptionsRequest.create_requests .</summary>
        public class BulkEditAdvertiserAssignedTargetingOptionsRequest : DisplayVideoBaseServiceRequest<Google.Apis.DisplayVideo.v1.Data.BulkEditAdvertiserAssignedTargetingOptionsResponse>
        {
            /// <summary>Constructs a new BulkEditAdvertiserAssignedTargetingOptions request.</summary>
            public BulkEditAdvertiserAssignedTargetingOptionsRequest(Google.Apis.Services.IClientService service, Google.Apis.DisplayVideo.v1.Data.BulkEditAdvertiserAssignedTargetingOptionsRequest body, long advertiserId) : base(service)
            {
                AdvertiserId = advertiserId;
                Body = body;
                InitParameters();
            }


            /// <summary>Required. The ID of the advertiser.</summary>
            [Google.Apis.Util.RequestParameterAttribute("advertiserId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual long AdvertiserId { get; private set; }


            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.DisplayVideo.v1.Data.BulkEditAdvertiserAssignedTargetingOptionsRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "bulkEditAdvertiserAssignedTargetingOptions";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/advertisers/{+advertiserId}:bulkEditAdvertiserAssignedTargetingOptions";

            /// <summary>Initializes BulkEditAdvertiserAssignedTargetingOptions parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add("advertiserId", new Google.Apis.Discovery.Parameter
                {
                    Name = "advertiserId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^[^/]+$",
                });
            }

        }

        /// <summary>Lists assigned targeting options of an advertiser across targeting types.</summary>
        /// <param name="advertiserId">Required. The ID of the advertiser the line item belongs to.</param>
        public virtual BulkListAdvertiserAssignedTargetingOptionsRequest BulkListAdvertiserAssignedTargetingOptions(long advertiserId)
        {
            return new BulkListAdvertiserAssignedTargetingOptionsRequest(service, advertiserId);
        }

        /// <summary>Lists assigned targeting options of an advertiser across targeting types.</summary>
        public class BulkListAdvertiserAssignedTargetingOptionsRequest : DisplayVideoBaseServiceRequest<Google.Apis.DisplayVideo.v1.Data.BulkListAdvertiserAssignedTargetingOptionsResponse>
        {
            /// <summary>Constructs a new BulkListAdvertiserAssignedTargetingOptions request.</summary>
            public BulkListAdvertiserAssignedTargetingOptionsRequest(Google.Apis.Services.IClientService service, long advertiserId) : base(service)
            {
                AdvertiserId = advertiserId;
                InitParameters();
            }


            /// <summary>Required. The ID of the advertiser the line item belongs to.</summary>
            [Google.Apis.Util.RequestParameterAttribute("advertiserId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual long AdvertiserId { get; private set; }

            /// <summary>Allows filtering by assigned targeting option properties. Supported syntax: * Filter
            /// expressions are made up of one or more restrictions. * Restrictions can be combined by the logical
            /// operator `OR`.. * A restriction has the form of `{field} {operator} {value}`. * The operator must be
            /// `EQUALS (=)`. * Supported fields: - `targetingType` Examples: * targetingType with value
            /// TARGETING_TYPE_CHANNEL `targetingType="TARGETING_TYPE_CHANNEL"` The length of this field should be no
            /// more than 500 characters.</summary>
            [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Filter { get; set; }

            /// <summary>Field by which to sort the list. Acceptable values are: * `targetingType` (default) The default
            /// sorting order is ascending. To specify descending order for a field, a suffix "desc" should be added to
            /// the field name. Example: `targetingType desc`.</summary>
            [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string OrderBy { get; set; }

            /// <summary>Requested page size. The size must be an integer between `1` and `5000`. If unspecified, the
            /// default is '5000'. Returns error code `INVALID_ARGUMENT` if an invalid value is specified.</summary>
            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> PageSize { get; set; }

            /// <summary>A token that lets the client fetch the next page of results. Typically, this is the value of
            /// next_page_token returned from the previous call to `BulkListAdvertiserAssignedTargetingOptions` method.
            /// If not specified, the first page of results will be returned.</summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }


            /// <summary>Gets the method name.</summary>
            public override string MethodName => "bulkListAdvertiserAssignedTargetingOptions";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/advertisers/{+advertiserId}:bulkListAdvertiserAssignedTargetingOptions";

            /// <summary>Initializes BulkListAdvertiserAssignedTargetingOptions parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add("advertiserId", new Google.Apis.Discovery.Parameter
                {
                    Name = "advertiserId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^[^/]+$",
                });
                RequestParameters.Add("filter", new Google.Apis.Discovery.Parameter
                {
                    Name = "filter",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
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
                RequestParameters.Add("pageSize", new Google.Apis.Discovery.Parameter
                {
                    Name = "pageSize",
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

        /// <summary>Creates a new advertiser. Returns the newly created advertiser if successful. This method can take
        /// up to 180 seconds to complete.</summary>
        /// <param name="body">The body of the request.</param>
        public virtual CreateRequest Create(Google.Apis.DisplayVideo.v1.Data.Advertiser body)
        {
            return new CreateRequest(service, body);
        }

        /// <summary>Creates a new advertiser. Returns the newly created advertiser if successful. This method can take
        /// up to 180 seconds to complete.</summary>
        public class CreateRequest : DisplayVideoBaseServiceRequest<Google.Apis.DisplayVideo.v1.Data.Advertiser>
        {
            /// <summary>Constructs a new Create request.</summary>
            public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.DisplayVideo.v1.Data.Advertiser body) : base(service)
            {
                Body = body;
                InitParameters();
            }



            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.DisplayVideo.v1.Data.Advertiser Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "create";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/advertisers";

            /// <summary>Initializes Create parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

            }

        }

        /// <summary>Deletes an advertiser. Deleting an advertiser will delete all of its child resources, for example,
        /// campaigns, insertion orders and line items. A deleted advertiser cannot be recovered.</summary>
        /// <param name="advertiserId">The ID of the advertiser we need to delete.</param>
        public virtual DeleteRequest Delete(long advertiserId)
        {
            return new DeleteRequest(service, advertiserId);
        }

        /// <summary>Deletes an advertiser. Deleting an advertiser will delete all of its child resources, for example,
        /// campaigns, insertion orders and line items. A deleted advertiser cannot be recovered.</summary>
        public class DeleteRequest : DisplayVideoBaseServiceRequest<Google.Apis.DisplayVideo.v1.Data.Empty>
        {
            /// <summary>Constructs a new Delete request.</summary>
            public DeleteRequest(Google.Apis.Services.IClientService service, long advertiserId) : base(service)
            {
                AdvertiserId = advertiserId;
                InitParameters();
            }


            /// <summary>The ID of the advertiser we need to delete.</summary>
            [Google.Apis.Util.RequestParameterAttribute("advertiserId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual long AdvertiserId { get; private set; }


            /// <summary>Gets the method name.</summary>
            public override string MethodName => "delete";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "DELETE";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/advertisers/{+advertiserId}";

            /// <summary>Initializes Delete parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add("advertiserId", new Google.Apis.Discovery.Parameter
                {
                    Name = "advertiserId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^[^/]+$",
                });
            }

        }

        /// <summary>Gets an advertiser.</summary>
        /// <param name="advertiserId">Required. The ID of the advertiser to fetch.</param>
        public virtual GetRequest Get(long advertiserId)
        {
            return new GetRequest(service, advertiserId);
        }

        /// <summary>Gets an advertiser.</summary>
        public class GetRequest : DisplayVideoBaseServiceRequest<Google.Apis.DisplayVideo.v1.Data.Advertiser>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, long advertiserId) : base(service)
            {
                AdvertiserId = advertiserId;
                InitParameters();
            }


            /// <summary>Required. The ID of the advertiser to fetch.</summary>
            [Google.Apis.Util.RequestParameterAttribute("advertiserId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual long AdvertiserId { get; private set; }


            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/advertisers/{+advertiserId}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add("advertiserId", new Google.Apis.Discovery.Parameter
                {
                    Name = "advertiserId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^[^/]+$",
                });
            }

        }

        /// <summary>Lists advertisers that are accessible to the current user. The order is defined by the order_by
        /// parameter. A single partner_id is required. Cross-partner listing is not supported.</summary>
        public virtual ListRequest List()
        {
            return new ListRequest(service);
        }

        /// <summary>Lists advertisers that are accessible to the current user. The order is defined by the order_by
        /// parameter. A single partner_id is required. Cross-partner listing is not supported.</summary>
        public class ListRequest : DisplayVideoBaseServiceRequest<Google.Apis.DisplayVideo.v1.Data.ListAdvertisersResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }


            /// <summary>Allows filtering by advertiser properties. Supported syntax: * Filter expressions are made up
            /// of one or more restrictions. * Restrictions can be combined by `AND` or `OR` logical operators. A
            /// sequence of restrictions implicitly uses `AND`. * A restriction has the form of `{field} {operator}
            /// {value}`. * The operator must be `EQUALS (=)`. * Supported fields: - `advertiserId` - `displayName` -
            /// `entityStatus` Examples: * All active advertisers under a partner: `entityStatus="ENTITY_STATUS_ACTIVE"`
            /// The length of this field should be no more than 500 characters.</summary>
            [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Filter { get; set; }

            /// <summary>Field by which to sort the list. Acceptable values are: * `displayName` (default) *
            /// `entityStatus` The default sorting order is ascending. To specify descending order for a field, a suffix
            /// "desc" should be added to the field name. For example, `displayName desc`.</summary>
            [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string OrderBy { get; set; }

            /// <summary>Requested page size. Must be between `1` and `100`. If unspecified will default to
            /// `100`.</summary>
            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> PageSize { get; set; }

            /// <summary>A token identifying a page of results the server should return. Typically, this is the value of
            /// next_page_token returned from the previous call to `ListAdvertisers` method. If not specified, the first
            /// page of results will be returned.</summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>Required. The ID of the partner that the fetched advertisers should all belong to. The system
            /// only supports listing advertisers for one partner at a time.</summary>
            [Google.Apis.Util.RequestParameterAttribute("partnerId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> PartnerId { get; set; }


            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/advertisers";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add("filter", new Google.Apis.Discovery.Parameter
                {
                    Name = "filter",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
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
                RequestParameters.Add("pageSize", new Google.Apis.Discovery.Parameter
                {
                    Name = "pageSize",
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
                RequestParameters.Add("partnerId", new Google.Apis.Discovery.Parameter
                {
                    Name = "partnerId",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }

        }

        /// <summary>Updates an existing advertiser. Returns the updated advertiser if successful.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="advertiserId">Output only. The unique ID of the advertiser. Assigned by the system.</param>
        public virtual PatchRequest Patch(Google.Apis.DisplayVideo.v1.Data.Advertiser body, long advertiserId)
        {
            return new PatchRequest(service, body, advertiserId);
        }

        /// <summary>Updates an existing advertiser. Returns the updated advertiser if successful.</summary>
        public class PatchRequest : DisplayVideoBaseServiceRequest<Google.Apis.DisplayVideo.v1.Data.Advertiser>
        {
            /// <summary>Constructs a new Patch request.</summary>
            public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.DisplayVideo.v1.Data.Advertiser body, long advertiserId) : base(service)
            {
                AdvertiserId = advertiserId;
                Body = body;
                InitParameters();
            }


            /// <summary>Output only. The unique ID of the advertiser. Assigned by the system.</summary>
            [Google.Apis.Util.RequestParameterAttribute("advertiserId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual long AdvertiserId { get; private set; }

            /// <summary>Required. The mask to control which fields to update.</summary>
            [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
            public virtual object UpdateMask { get; set; }


            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.DisplayVideo.v1.Data.Advertiser Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "patch";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PATCH";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/advertisers/{+advertiserId}";

            /// <summary>Initializes Patch parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add("advertiserId", new Google.Apis.Discovery.Parameter
                {
                    Name = "advertiserId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^[^/]+$",
                });
                RequestParameters.Add("updateMask", new Google.Apis.Discovery.Parameter
                {
                    Name = "updateMask",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }

        }
    }

    /// <summary>The "combinedAudiences" collection of methods.</summary>
    public class CombinedAudiencesResource
    {
        private const string Resource = "combinedAudiences";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public CombinedAudiencesResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;

        }


        /// <summary>Gets a combined audience.</summary>
        /// <param name="combinedAudienceId">Required. The ID of the combined audience to fetch.</param>
        public virtual GetRequest Get(long combinedAudienceId)
        {
            return new GetRequest(service, combinedAudienceId);
        }

        /// <summary>Gets a combined audience.</summary>
        public class GetRequest : DisplayVideoBaseServiceRequest<Google.Apis.DisplayVideo.v1.Data.CombinedAudience>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, long combinedAudienceId) : base(service)
            {
                CombinedAudienceId = combinedAudienceId;
                InitParameters();
            }


            /// <summary>Required. The ID of the combined audience to fetch.</summary>
            [Google.Apis.Util.RequestParameterAttribute("combinedAudienceId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual long CombinedAudienceId { get; private set; }

            /// <summary>The ID of the advertiser that has access to the fetched combined audience.</summary>
            [Google.Apis.Util.RequestParameterAttribute("advertiserId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> AdvertiserId { get; set; }

            /// <summary>The ID of the partner that has access to the fetched combined audience.</summary>
            [Google.Apis.Util.RequestParameterAttribute("partnerId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> PartnerId { get; set; }


            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/combinedAudiences/{+combinedAudienceId}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add("combinedAudienceId", new Google.Apis.Discovery.Parameter
                {
                    Name = "combinedAudienceId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^[^/]+$",
                });
                RequestParameters.Add("advertiserId", new Google.Apis.Discovery.Parameter
                {
                    Name = "advertiserId",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("partnerId", new Google.Apis.Discovery.Parameter
                {
                    Name = "partnerId",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }

        }

        /// <summary>Lists combined audiences. The order is defined by the order_by parameter.</summary>
        public virtual ListRequest List()
        {
            return new ListRequest(service);
        }

        /// <summary>Lists combined audiences. The order is defined by the order_by parameter.</summary>
        public class ListRequest : DisplayVideoBaseServiceRequest<Google.Apis.DisplayVideo.v1.Data.ListCombinedAudiencesResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }


            /// <summary>The ID of the advertiser that has access to the fetched combined audiences.</summary>
            [Google.Apis.Util.RequestParameterAttribute("advertiserId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> AdvertiserId { get; set; }

            /// <summary>Allows filtering by combined audience fields. Supported syntax: * Filter expressions for
            /// combined audiences currently can only contain at most one restriction. * A restriction has the form of
            /// `{field} {operator} {value}`. * The operator must be `CONTAINS (:)`. * Supported fields: - `displayName`
            /// Examples: * All combined audiences for which the display name contains "Google": `displayName :
            /// "Google"`. The length of this field should be no more than 500 characters.</summary>
            [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Filter { get; set; }

            /// <summary>Field by which to sort the list. Acceptable values are: * `combinedAudienceId` (default) *
            /// `displayName` The default sorting order is ascending. To specify descending order for a field, a suffix
            /// "desc" should be added to the field name. Example: `displayName desc`.</summary>
            [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string OrderBy { get; set; }

            /// <summary>Requested page size. Must be between `1` and `100`. If unspecified will default to `100`.
            /// Returns error code `INVALID_ARGUMENT` if an invalid value is specified.</summary>
            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> PageSize { get; set; }

            /// <summary>A token identifying a page of results the server should return. Typically, this is the value of
            /// next_page_token returned from the previous call to `ListCombinedAudiences` method. If not specified, the
            /// first page of results will be returned.</summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>The ID of the partner that has access to the fetched combined audiences.</summary>
            [Google.Apis.Util.RequestParameterAttribute("partnerId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> PartnerId { get; set; }


            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/combinedAudiences";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add("advertiserId", new Google.Apis.Discovery.Parameter
                {
                    Name = "advertiserId",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("filter", new Google.Apis.Discovery.Parameter
                {
                    Name = "filter",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
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
                RequestParameters.Add("pageSize", new Google.Apis.Discovery.Parameter
                {
                    Name = "pageSize",
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
                RequestParameters.Add("partnerId", new Google.Apis.Discovery.Parameter
                {
                    Name = "partnerId",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }

        }
    }

    /// <summary>The "customBiddingAlgorithms" collection of methods.</summary>
    public class CustomBiddingAlgorithmsResource
    {
        private const string Resource = "customBiddingAlgorithms";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public CustomBiddingAlgorithmsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;

        }


        /// <summary>Gets a custom bidding algorithm.</summary>
        /// <param name="customBiddingAlgorithmId">Required. The ID of the custom bidding algorithm to fetch.</param>
        public virtual GetRequest Get(long customBiddingAlgorithmId)
        {
            return new GetRequest(service, customBiddingAlgorithmId);
        }

        /// <summary>Gets a custom bidding algorithm.</summary>
        public class GetRequest : DisplayVideoBaseServiceRequest<Google.Apis.DisplayVideo.v1.Data.CustomBiddingAlgorithm>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, long customBiddingAlgorithmId) : base(service)
            {
                CustomBiddingAlgorithmId = customBiddingAlgorithmId;
                InitParameters();
            }


            /// <summary>Required. The ID of the custom bidding algorithm to fetch.</summary>
            [Google.Apis.Util.RequestParameterAttribute("customBiddingAlgorithmId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual long CustomBiddingAlgorithmId { get; private set; }

            /// <summary>The ID of the DV360 partner that has access to the custom bidding algorithm.</summary>
            [Google.Apis.Util.RequestParameterAttribute("advertiserId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> AdvertiserId { get; set; }

            /// <summary>The ID of the DV360 partner that has access to the custom bidding algorithm.</summary>
            [Google.Apis.Util.RequestParameterAttribute("partnerId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> PartnerId { get; set; }


            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/customBiddingAlgorithms/{+customBiddingAlgorithmId}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add("customBiddingAlgorithmId", new Google.Apis.Discovery.Parameter
                {
                    Name = "customBiddingAlgorithmId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^[^/]+$",
                });
                RequestParameters.Add("advertiserId", new Google.Apis.Discovery.Parameter
                {
                    Name = "advertiserId",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("partnerId", new Google.Apis.Discovery.Parameter
                {
                    Name = "partnerId",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }

        }

        /// <summary>Lists custom bidding algorithms that are accessible to the current user and can be used in bidding
        /// stratgies. The order is defined by the order_by parameter.</summary>
        public virtual ListRequest List()
        {
            return new ListRequest(service);
        }

        /// <summary>Lists custom bidding algorithms that are accessible to the current user and can be used in bidding
        /// stratgies. The order is defined by the order_by parameter.</summary>
        public class ListRequest : DisplayVideoBaseServiceRequest<Google.Apis.DisplayVideo.v1.Data.ListCustomBiddingAlgorithmsResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }


            /// <summary>The ID of the DV360 advertiser that has access to the custom bidding algorithm.</summary>
            [Google.Apis.Util.RequestParameterAttribute("advertiserId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> AdvertiserId { get; set; }

            /// <summary>Allows filtering by custom bidding algorithm fields. Supported syntax: * Filter expressions are
            /// made up of one or more restrictions. * Restrictions can be combined by `AND`. A sequence of restrictions
            /// * implicitly uses `AND`. * A restriction has the form of `{field} {operator} {value}`. * The operator
            /// must be `CONTAINS (:)` or `EQUALS (=)`. * The operator must be `CONTAINS (:)` for the following field: -
            /// `displayName` * The operator must be `EQUALS (=)` for the following field: -
            /// `customBiddingAlgorithmType` * For `displayName`, the value is a string. We return all custom bidding
            /// algorithms whose display_name contains such string. * For `customBiddingAlgorithmType`, the value is a
            /// string. We return all algorithms whose custom_bidding_algorithm_type is equal to the given type.
            /// Examples: * All custom bidding algorithms for which the display name contains "politics":
            /// `displayName:politics`. * All custom bidding algorithms for which the type is "SCRIPT_BASED":
            /// `customBiddingAlgorithmType=SCRIPT_BASED` The length of this field should be no more than 500
            /// characters.</summary>
            [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Filter { get; set; }

            /// <summary>Field by which to sort the list. Acceptable values are: * `displayName` (default) The default
            /// sorting order is ascending. To specify descending order for a field, a suffix "desc" should be added to
            /// the field name. Example: `displayName desc`.</summary>
            [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string OrderBy { get; set; }

            /// <summary>Requested page size. Must be between `1` and `100`. If unspecified will default to `100`.
            /// Returns error code `INVALID_ARGUMENT` if an invalid value is specified.</summary>
            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> PageSize { get; set; }

            /// <summary>A token identifying a page of results the server should return. Typically, this is the value of
            /// next_page_token returned from the previous call to `ListCustomBiddingAlgorithms` method. If not
            /// specified, the first page of results will be returned.</summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>The ID of the DV360 partner that has access to the custom bidding algorithm.</summary>
            [Google.Apis.Util.RequestParameterAttribute("partnerId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> PartnerId { get; set; }


            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/customBiddingAlgorithms";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add("advertiserId", new Google.Apis.Discovery.Parameter
                {
                    Name = "advertiserId",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("filter", new Google.Apis.Discovery.Parameter
                {
                    Name = "filter",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
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
                RequestParameters.Add("pageSize", new Google.Apis.Discovery.Parameter
                {
                    Name = "pageSize",
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
                RequestParameters.Add("partnerId", new Google.Apis.Discovery.Parameter
                {
                    Name = "partnerId",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }

        }
    }

    /// <summary>The "customLists" collection of methods.</summary>
    public class CustomListsResource
    {
        private const string Resource = "customLists";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public CustomListsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;

        }


        /// <summary>Gets a custom list.</summary>
        /// <param name="customListId">Required. The ID of the custom list to fetch.</param>
        public virtual GetRequest Get(long customListId)
        {
            return new GetRequest(service, customListId);
        }

        /// <summary>Gets a custom list.</summary>
        public class GetRequest : DisplayVideoBaseServiceRequest<Google.Apis.DisplayVideo.v1.Data.CustomList>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, long customListId) : base(service)
            {
                CustomListId = customListId;
                InitParameters();
            }


            /// <summary>Required. The ID of the custom list to fetch.</summary>
            [Google.Apis.Util.RequestParameterAttribute("customListId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual long CustomListId { get; private set; }

            /// <summary>The ID of the DV360 advertiser that has access to the fetched custom lists.</summary>
            [Google.Apis.Util.RequestParameterAttribute("advertiserId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> AdvertiserId { get; set; }


            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/customLists/{+customListId}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add("customListId", new Google.Apis.Discovery.Parameter
                {
                    Name = "customListId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^[^/]+$",
                });
                RequestParameters.Add("advertiserId", new Google.Apis.Discovery.Parameter
                {
                    Name = "advertiserId",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }

        }

        /// <summary>Lists custom lists. The order is defined by the order_by parameter.</summary>
        public virtual ListRequest List()
        {
            return new ListRequest(service);
        }

        /// <summary>Lists custom lists. The order is defined by the order_by parameter.</summary>
        public class ListRequest : DisplayVideoBaseServiceRequest<Google.Apis.DisplayVideo.v1.Data.ListCustomListsResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }


            /// <summary>The ID of the DV360 advertiser that has access to the fetched custom lists.</summary>
            [Google.Apis.Util.RequestParameterAttribute("advertiserId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> AdvertiserId { get; set; }

            /// <summary>Allows filtering by custom list fields. Supported syntax: * Filter expressions for custom lists
            /// currently can only contain at most one restriction. * A restriction has the form of `{field} {operator}
            /// {value}`. * The operator must be `CONTAINS (:)`. * Supported fields: - `displayName` Examples: * All
            /// custom lists for which the display name contains "Google": `displayName : "Google"`. The length of this
            /// field should be no more than 500 characters.</summary>
            [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Filter { get; set; }

            /// <summary>Field by which to sort the list. Acceptable values are: * `customListId` (default) *
            /// `displayName` The default sorting order is ascending. To specify descending order for a field, a suffix
            /// "desc" should be added to the field name. Example: `displayName desc`.</summary>
            [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string OrderBy { get; set; }

            /// <summary>Requested page size. Must be between `1` and `100`. If unspecified will default to `100`.
            /// Returns error code `INVALID_ARGUMENT` if an invalid value is specified.</summary>
            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> PageSize { get; set; }

            /// <summary>A token identifying a page of results the server should return. Typically, this is the value of
            /// next_page_token returned from the previous call to `ListCustomLists` method. If not specified, the first
            /// page of results will be returned.</summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }


            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/customLists";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add("advertiserId", new Google.Apis.Discovery.Parameter
                {
                    Name = "advertiserId",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("filter", new Google.Apis.Discovery.Parameter
                {
                    Name = "filter",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
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
                RequestParameters.Add("pageSize", new Google.Apis.Discovery.Parameter
                {
                    Name = "pageSize",
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
    }

    /// <summary>The "firstAndThirdPartyAudiences" collection of methods.</summary>
    public class FirstAndThirdPartyAudiencesResource
    {
        private const string Resource = "firstAndThirdPartyAudiences";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public FirstAndThirdPartyAudiencesResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;

        }


        /// <summary>Gets a first and third party audience.</summary>
        /// <param name="firstAndThirdPartyAudienceId">Required. The ID of the first and third party audience to
        /// fetch.</param>
        public virtual GetRequest Get(long firstAndThirdPartyAudienceId)
        {
            return new GetRequest(service, firstAndThirdPartyAudienceId);
        }

        /// <summary>Gets a first and third party audience.</summary>
        public class GetRequest : DisplayVideoBaseServiceRequest<Google.Apis.DisplayVideo.v1.Data.FirstAndThirdPartyAudience>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, long firstAndThirdPartyAudienceId) : base(service)
            {
                FirstAndThirdPartyAudienceId = firstAndThirdPartyAudienceId;
                InitParameters();
            }


            /// <summary>Required. The ID of the first and third party audience to fetch.</summary>
            [Google.Apis.Util.RequestParameterAttribute("firstAndThirdPartyAudienceId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual long FirstAndThirdPartyAudienceId { get; private set; }

            /// <summary>The ID of the advertiser that has access to the fetched first and third party
            /// audience.</summary>
            [Google.Apis.Util.RequestParameterAttribute("advertiserId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> AdvertiserId { get; set; }

            /// <summary>The ID of the partner that has access to the fetched first and third party audience.</summary>
            [Google.Apis.Util.RequestParameterAttribute("partnerId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> PartnerId { get; set; }


            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/firstAndThirdPartyAudiences/{+firstAndThirdPartyAudienceId}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add("firstAndThirdPartyAudienceId", new Google.Apis.Discovery.Parameter
                {
                    Name = "firstAndThirdPartyAudienceId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^[^/]+$",
                });
                RequestParameters.Add("advertiserId", new Google.Apis.Discovery.Parameter
                {
                    Name = "advertiserId",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("partnerId", new Google.Apis.Discovery.Parameter
                {
                    Name = "partnerId",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }

        }

        /// <summary>Lists first and third party audiences. The order is defined by the order_by parameter.</summary>
        public virtual ListRequest List()
        {
            return new ListRequest(service);
        }

        /// <summary>Lists first and third party audiences. The order is defined by the order_by parameter.</summary>
        public class ListRequest : DisplayVideoBaseServiceRequest<Google.Apis.DisplayVideo.v1.Data.ListFirstAndThirdPartyAudiencesResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }


            /// <summary>The ID of the advertiser that has access to the fetched first and third party
            /// audiences.</summary>
            [Google.Apis.Util.RequestParameterAttribute("advertiserId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> AdvertiserId { get; set; }

            /// <summary>Allows filtering by first and third party audience fields. Supported syntax: * Filter
            /// expressions for first and third party audiences currently can only contain at most one restriction. * A
            /// restriction has the form of `{field} {operator} {value}`. * The operator must be `CONTAINS (:)`. *
            /// Supported fields: - `displayName` Examples: * All first and third party audiences for which the display
            /// name contains "Google": `displayName : "Google"`. The length of this field should be no more than 500
            /// characters.</summary>
            [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Filter { get; set; }

            /// <summary>Field by which to sort the list. Acceptable values are: * `firstAndThirdPartyAudienceId`
            /// (default) * `displayName` The default sorting order is ascending. To specify descending order for a
            /// field, a suffix "desc" should be added to the field name. Example: `displayName desc`.</summary>
            [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string OrderBy { get; set; }

            /// <summary>Requested page size. Must be between `1` and `100`. If unspecified will default to `100`.
            /// Returns error code `INVALID_ARGUMENT` if an invalid value is specified.</summary>
            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> PageSize { get; set; }

            /// <summary>A token identifying a page of results the server should return. Typically, this is the value of
            /// next_page_token returned from the previous call to `ListFirstAndThirdPartyAudiences` method. If not
            /// specified, the first page of results will be returned.</summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>The ID of the partner that has access to the fetched first and third party audiences.</summary>
            [Google.Apis.Util.RequestParameterAttribute("partnerId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> PartnerId { get; set; }


            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/firstAndThirdPartyAudiences";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add("advertiserId", new Google.Apis.Discovery.Parameter
                {
                    Name = "advertiserId",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("filter", new Google.Apis.Discovery.Parameter
                {
                    Name = "filter",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
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
                RequestParameters.Add("pageSize", new Google.Apis.Discovery.Parameter
                {
                    Name = "pageSize",
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
                RequestParameters.Add("partnerId", new Google.Apis.Discovery.Parameter
                {
                    Name = "partnerId",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }

        }
    }

    /// <summary>The "floodlightGroups" collection of methods.</summary>
    public class FloodlightGroupsResource
    {
        private const string Resource = "floodlightGroups";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public FloodlightGroupsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;

        }


        /// <summary>Gets a Floodlight group.</summary>
        /// <param name="floodlightGroupId">Required. The ID of the Floodlight group to fetch.</param>
        public virtual GetRequest Get(long floodlightGroupId)
        {
            return new GetRequest(service, floodlightGroupId);
        }

        /// <summary>Gets a Floodlight group.</summary>
        public class GetRequest : DisplayVideoBaseServiceRequest<Google.Apis.DisplayVideo.v1.Data.FloodlightGroup>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, long floodlightGroupId) : base(service)
            {
                FloodlightGroupId = floodlightGroupId;
                InitParameters();
            }


            /// <summary>Required. The ID of the Floodlight group to fetch.</summary>
            [Google.Apis.Util.RequestParameterAttribute("floodlightGroupId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual long FloodlightGroupId { get; private set; }

            /// <summary>Required. The partner context by which the Floodlight group is being accessed.</summary>
            [Google.Apis.Util.RequestParameterAttribute("partnerId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> PartnerId { get; set; }


            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/floodlightGroups/{+floodlightGroupId}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add("floodlightGroupId", new Google.Apis.Discovery.Parameter
                {
                    Name = "floodlightGroupId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^[^/]+$",
                });
                RequestParameters.Add("partnerId", new Google.Apis.Discovery.Parameter
                {
                    Name = "partnerId",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }

        }

        /// <summary>Updates an existing Floodlight group. Returns the updated Floodlight group if successful.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="floodlightGroupId">Output only. The unique ID of the Floodlight group. Assigned by the
        /// system.</param>
        public virtual PatchRequest Patch(Google.Apis.DisplayVideo.v1.Data.FloodlightGroup body, long floodlightGroupId)
        {
            return new PatchRequest(service, body, floodlightGroupId);
        }

        /// <summary>Updates an existing Floodlight group. Returns the updated Floodlight group if successful.</summary>
        public class PatchRequest : DisplayVideoBaseServiceRequest<Google.Apis.DisplayVideo.v1.Data.FloodlightGroup>
        {
            /// <summary>Constructs a new Patch request.</summary>
            public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.DisplayVideo.v1.Data.FloodlightGroup body, long floodlightGroupId) : base(service)
            {
                FloodlightGroupId = floodlightGroupId;
                Body = body;
                InitParameters();
            }


            /// <summary>Output only. The unique ID of the Floodlight group. Assigned by the system.</summary>
            [Google.Apis.Util.RequestParameterAttribute("floodlightGroupId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual long FloodlightGroupId { get; private set; }

            /// <summary>Required. The partner context by which the Floodlight group is being accessed.</summary>
            [Google.Apis.Util.RequestParameterAttribute("partnerId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> PartnerId { get; set; }

            /// <summary>Required. The mask to control which fields to update.</summary>
            [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
            public virtual object UpdateMask { get; set; }


            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.DisplayVideo.v1.Data.FloodlightGroup Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "patch";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PATCH";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/floodlightGroups/{floodlightGroupId}";

            /// <summary>Initializes Patch parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add("floodlightGroupId", new Google.Apis.Discovery.Parameter
                {
                    Name = "floodlightGroupId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("partnerId", new Google.Apis.Discovery.Parameter
                {
                    Name = "partnerId",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("updateMask", new Google.Apis.Discovery.Parameter
                {
                    Name = "updateMask",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }

        }
    }

    /// <summary>The "googleAudiences" collection of methods.</summary>
    public class GoogleAudiencesResource
    {
        private const string Resource = "googleAudiences";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public GoogleAudiencesResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;

        }


        /// <summary>Gets a Google audience.</summary>
        /// <param name="googleAudienceId">Required. The ID of the Google audience to fetch.</param>
        public virtual GetRequest Get(long googleAudienceId)
        {
            return new GetRequest(service, googleAudienceId);
        }

        /// <summary>Gets a Google audience.</summary>
        public class GetRequest : DisplayVideoBaseServiceRequest<Google.Apis.DisplayVideo.v1.Data.GoogleAudience>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, long googleAudienceId) : base(service)
            {
                GoogleAudienceId = googleAudienceId;
                InitParameters();
            }


            /// <summary>Required. The ID of the Google audience to fetch.</summary>
            [Google.Apis.Util.RequestParameterAttribute("googleAudienceId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual long GoogleAudienceId { get; private set; }

            /// <summary>The ID of the advertiser that has access to the fetched Google audience.</summary>
            [Google.Apis.Util.RequestParameterAttribute("advertiserId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> AdvertiserId { get; set; }

            /// <summary>The ID of the partner that has access to the fetched Google audience.</summary>
            [Google.Apis.Util.RequestParameterAttribute("partnerId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> PartnerId { get; set; }


            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/googleAudiences/{+googleAudienceId}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add("googleAudienceId", new Google.Apis.Discovery.Parameter
                {
                    Name = "googleAudienceId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^[^/]+$",
                });
                RequestParameters.Add("advertiserId", new Google.Apis.Discovery.Parameter
                {
                    Name = "advertiserId",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("partnerId", new Google.Apis.Discovery.Parameter
                {
                    Name = "partnerId",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }

        }

        /// <summary>Lists Google audiences. The order is defined by the order_by parameter.</summary>
        public virtual ListRequest List()
        {
            return new ListRequest(service);
        }

        /// <summary>Lists Google audiences. The order is defined by the order_by parameter.</summary>
        public class ListRequest : DisplayVideoBaseServiceRequest<Google.Apis.DisplayVideo.v1.Data.ListGoogleAudiencesResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }


            /// <summary>The ID of the advertiser that has access to the fetched Google audiences.</summary>
            [Google.Apis.Util.RequestParameterAttribute("advertiserId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> AdvertiserId { get; set; }

            /// <summary>Allows filtering by Google audience fields. Supported syntax: * Filter expressions for Google
            /// audiences currently can only contain at most one restriction. * A restriction has the form of `{field}
            /// {operator} {value}`. * The operator must be `CONTAINS (:)`. * Supported fields: - `displayName`
            /// Examples: * All Google audiences for which the display name contains "Google": `displayName : "Google"`.
            /// The length of this field should be no more than 500 characters.</summary>
            [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Filter { get; set; }

            /// <summary>Field by which to sort the list. Acceptable values are: * `googleAudienceId` (default) *
            /// `displayName` The default sorting order is ascending. To specify descending order for a field, a suffix
            /// "desc" should be added to the field name. Example: `displayName desc`.</summary>
            [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string OrderBy { get; set; }

            /// <summary>Requested page size. Must be between `1` and `100`. If unspecified will default to `100`.
            /// Returns error code `INVALID_ARGUMENT` if an invalid value is specified.</summary>
            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> PageSize { get; set; }

            /// <summary>A token identifying a page of results the server should return. Typically, this is the value of
            /// next_page_token returned from the previous call to `ListGoogleAudiences` method. If not specified, the
            /// first page of results will be returned.</summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>The ID of the partner that has access to the fetched Google audiences.</summary>
            [Google.Apis.Util.RequestParameterAttribute("partnerId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> PartnerId { get; set; }


            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/googleAudiences";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add("advertiserId", new Google.Apis.Discovery.Parameter
                {
                    Name = "advertiserId",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("filter", new Google.Apis.Discovery.Parameter
                {
                    Name = "filter",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
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
                RequestParameters.Add("pageSize", new Google.Apis.Discovery.Parameter
                {
                    Name = "pageSize",
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
                RequestParameters.Add("partnerId", new Google.Apis.Discovery.Parameter
                {
                    Name = "partnerId",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }

        }
    }

    /// <summary>The "inventorySourceGroups" collection of methods.</summary>
    public class InventorySourceGroupsResource
    {
        private const string Resource = "inventorySourceGroups";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public InventorySourceGroupsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
            AssignedInventorySources = new AssignedInventorySourcesResource(service);

        }

        /// <summary>Gets the AssignedInventorySources resource.</summary>
        public virtual AssignedInventorySourcesResource AssignedInventorySources { get; }

        /// <summary>The "assignedInventorySources" collection of methods.</summary>
        public class AssignedInventorySourcesResource
        {
            private const string Resource = "assignedInventorySources";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public AssignedInventorySourcesResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;

            }


            /// <summary>Bulk edits multiple assignments between inventory sources and a single inventory source group.
            /// The operation will delete the assigned inventory sources provided in
            /// BulkEditAssignedInventorySourcesRequest.deleted_assigned_inventory_sources and then create the assigned
            /// inventory sources provided in
            /// BulkEditAssignedInventorySourcesRequest.created_assigned_inventory_sources.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="inventorySourceGroupId">Required. The ID of the inventory source group to which the assignments are
            /// assigned.</param>
            public virtual BulkEditRequest BulkEdit(Google.Apis.DisplayVideo.v1.Data.BulkEditAssignedInventorySourcesRequest body, long inventorySourceGroupId)
            {
                return new BulkEditRequest(service, body, inventorySourceGroupId);
            }

            /// <summary>Bulk edits multiple assignments between inventory sources and a single inventory source group.
            /// The operation will delete the assigned inventory sources provided in
            /// BulkEditAssignedInventorySourcesRequest.deleted_assigned_inventory_sources and then create the assigned
            /// inventory sources provided in
            /// BulkEditAssignedInventorySourcesRequest.created_assigned_inventory_sources.</summary>
            public class BulkEditRequest : DisplayVideoBaseServiceRequest<Google.Apis.DisplayVideo.v1.Data.BulkEditAssignedInventorySourcesResponse>
            {
                /// <summary>Constructs a new BulkEdit request.</summary>
                public BulkEditRequest(Google.Apis.Services.IClientService service, Google.Apis.DisplayVideo.v1.Data.BulkEditAssignedInventorySourcesRequest body, long inventorySourceGroupId) : base(service)
                {
                    InventorySourceGroupId = inventorySourceGroupId;
                    Body = body;
                    InitParameters();
                }


                /// <summary>Required. The ID of the inventory source group to which the assignments are
                /// assigned.</summary>
                [Google.Apis.Util.RequestParameterAttribute("inventorySourceGroupId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual long InventorySourceGroupId { get; private set; }


                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.DisplayVideo.v1.Data.BulkEditAssignedInventorySourcesRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "bulkEdit";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/inventorySourceGroups/{+inventorySourceGroupId}/assignedInventorySources:bulkEdit";

                /// <summary>Initializes BulkEdit parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();

                    RequestParameters.Add("inventorySourceGroupId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "inventorySourceGroupId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^[^/]+$",
                    });
                }

            }

            /// <summary>Creates an assignment between an inventory source and an inventory source group.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="inventorySourceGroupId">Required. The ID of the inventory source group to which the assignment will be
            /// assigned.</param>
            public virtual CreateRequest Create(Google.Apis.DisplayVideo.v1.Data.AssignedInventorySource body, long inventorySourceGroupId)
            {
                return new CreateRequest(service, body, inventorySourceGroupId);
            }

            /// <summary>Creates an assignment between an inventory source and an inventory source group.</summary>
            public class CreateRequest : DisplayVideoBaseServiceRequest<Google.Apis.DisplayVideo.v1.Data.AssignedInventorySource>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.DisplayVideo.v1.Data.AssignedInventorySource body, long inventorySourceGroupId) : base(service)
                {
                    InventorySourceGroupId = inventorySourceGroupId;
                    Body = body;
                    InitParameters();
                }


                /// <summary>Required. The ID of the inventory source group to which the assignment will be
                /// assigned.</summary>
                [Google.Apis.Util.RequestParameterAttribute("inventorySourceGroupId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual long InventorySourceGroupId { get; private set; }

                /// <summary>The ID of the advertiser that owns the parent inventory source group. The parent partner
                /// will not have access to this assigned inventory source.</summary>
                [Google.Apis.Util.RequestParameterAttribute("advertiserId", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<long> AdvertiserId { get; set; }

                /// <summary>The ID of the partner that owns the parent inventory source group. Only this partner will
                /// have write access to this assigned inventory source.</summary>
                [Google.Apis.Util.RequestParameterAttribute("partnerId", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<long> PartnerId { get; set; }


                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.DisplayVideo.v1.Data.AssignedInventorySource Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/inventorySourceGroups/{+inventorySourceGroupId}/assignedInventorySources";

                /// <summary>Initializes Create parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();

                    RequestParameters.Add("inventorySourceGroupId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "inventorySourceGroupId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^[^/]+$",
                    });
                    RequestParameters.Add("advertiserId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "advertiserId",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("partnerId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "partnerId",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }

            }

            /// <summary>Deletes the assignment between an inventory source and an inventory source group.</summary>
            /// <param name="inventorySourceGroupId">Required. The ID of the inventory source group to which this assignment is
            /// assigned.</param>
            /// <param name="assignedInventorySourceId">Required. The ID of the assigned inventory source
            /// to delete.</param>
            public virtual DeleteRequest Delete(long inventorySourceGroupId, long assignedInventorySourceId)
            {
                return new DeleteRequest(service, inventorySourceGroupId, assignedInventorySourceId);
            }

            /// <summary>Deletes the assignment between an inventory source and an inventory source group.</summary>
            public class DeleteRequest : DisplayVideoBaseServiceRequest<Google.Apis.DisplayVideo.v1.Data.Empty>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, long inventorySourceGroupId, long assignedInventorySourceId) : base(service)
                {
                    InventorySourceGroupId = inventorySourceGroupId;
                    AssignedInventorySourceId = assignedInventorySourceId;
                    InitParameters();
                }


                /// <summary>Required. The ID of the inventory source group to which this assignment is
                /// assigned.</summary>
                [Google.Apis.Util.RequestParameterAttribute("inventorySourceGroupId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual long InventorySourceGroupId { get; private set; }

                /// <summary>Required. The ID of the assigned inventory source to delete.</summary>
                [Google.Apis.Util.RequestParameterAttribute("assignedInventorySourceId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual long AssignedInventorySourceId { get; private set; }

                /// <summary>The ID of the advertiser that owns the parent inventory source group. The parent partner
                /// does not have access to this assigned inventory source.</summary>
                [Google.Apis.Util.RequestParameterAttribute("advertiserId", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<long> AdvertiserId { get; set; }

                /// <summary>The ID of the partner that owns the parent inventory source group. Only this partner has
                /// write access to this assigned inventory source.</summary>
                [Google.Apis.Util.RequestParameterAttribute("partnerId", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<long> PartnerId { get; set; }


                /// <summary>Gets the method name.</summary>
                public override string MethodName => "delete";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "DELETE";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/inventorySourceGroups/{+inventorySourceGroupId}/assignedInventorySources/{+assignedInventorySourceId}";

                /// <summary>Initializes Delete parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();

                    RequestParameters.Add("inventorySourceGroupId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "inventorySourceGroupId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^[^/]+$",
                    });
                    RequestParameters.Add("assignedInventorySourceId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "assignedInventorySourceId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^[^/]+$",
                    });
                    RequestParameters.Add("advertiserId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "advertiserId",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("partnerId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "partnerId",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }

            }

            /// <summary>Lists inventory sources assigned to an inventory source group.</summary>
            /// <param name="inventorySourceGroupId">Required. The ID of the inventory source group to which these assignments are
            /// assigned.</param>
            public virtual ListRequest List(long inventorySourceGroupId)
            {
                return new ListRequest(service, inventorySourceGroupId);
            }

            /// <summary>Lists inventory sources assigned to an inventory source group.</summary>
            public class ListRequest : DisplayVideoBaseServiceRequest<Google.Apis.DisplayVideo.v1.Data.ListAssignedInventorySourcesResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, long inventorySourceGroupId) : base(service)
                {
                    InventorySourceGroupId = inventorySourceGroupId;
                    InitParameters();
                }


                /// <summary>Required. The ID of the inventory source group to which these assignments are
                /// assigned.</summary>
                [Google.Apis.Util.RequestParameterAttribute("inventorySourceGroupId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual long InventorySourceGroupId { get; private set; }

                /// <summary>The ID of the advertiser that has access to the assignment. If the parent inventory source
                /// group is partner-owned, only advertisers to which the parent group is explicitly shared can access
                /// the assigned inventory source.</summary>
                [Google.Apis.Util.RequestParameterAttribute("advertiserId", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<long> AdvertiserId { get; set; }

                /// <summary>Allows filtering by assigned inventory source fields. Supported syntax: * Filter
                /// expressions are made up of one or more restrictions. * Restrictions can be combined by the logical
                /// operator `OR`. * A restriction has the form of `{field} {operator} {value}`. * The operator must be
                /// `EQUALS (=)`. * Supported fields: - `assignedInventorySourceId` The length of this field should be
                /// no more than 500 characters.</summary>
                [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Filter { get; set; }

                /// <summary>Field by which to sort the list. Acceptable values are: * `assignedInventorySourceId`
                /// (default) The default sorting order is ascending. To specify descending order for a field, a suffix
                /// " desc" should be added to the field name. Example: `assignedInventorySourceId desc`.</summary>
                [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string OrderBy { get; set; }

                /// <summary>Requested page size. Must be between `1` and `100`. If unspecified will default to `100`.
                /// Returns error code `INVALID_ARGUMENT` if an invalid value is specified.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>A token identifying a page of results the server should return. Typically, this is the
                /// value of next_page_token returned from the previous call to `ListAssignedInventorySources` method.
                /// If not specified, the first page of results will be returned.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>The ID of the partner that has access to the assignment. If the parent inventory source
                /// group is advertiser-owned, the assignment cannot be accessed via a partner.</summary>
                [Google.Apis.Util.RequestParameterAttribute("partnerId", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<long> PartnerId { get; set; }


                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/inventorySourceGroups/{+inventorySourceGroupId}/assignedInventorySources";

                /// <summary>Initializes List parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();

                    RequestParameters.Add("inventorySourceGroupId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "inventorySourceGroupId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^[^/]+$",
                    });
                    RequestParameters.Add("advertiserId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "advertiserId",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("filter", new Google.Apis.Discovery.Parameter
                    {
                        Name = "filter",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
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
                    RequestParameters.Add("pageSize", new Google.Apis.Discovery.Parameter
                    {
                        Name = "pageSize",
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
                    RequestParameters.Add("partnerId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "partnerId",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }

            }
        }

        /// <summary>Creates a new inventory source group. Returns the newly created inventory source group if
        /// successful.</summary>
        /// <param name="body">The body of the request.</param>
        public virtual CreateRequest Create(Google.Apis.DisplayVideo.v1.Data.InventorySourceGroup body)
        {
            return new CreateRequest(service, body);
        }

        /// <summary>Creates a new inventory source group. Returns the newly created inventory source group if
        /// successful.</summary>
        public class CreateRequest : DisplayVideoBaseServiceRequest<Google.Apis.DisplayVideo.v1.Data.InventorySourceGroup>
        {
            /// <summary>Constructs a new Create request.</summary>
            public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.DisplayVideo.v1.Data.InventorySourceGroup body) : base(service)
            {
                Body = body;
                InitParameters();
            }


            /// <summary>The ID of the advertiser that owns the inventory source group. The parent partner will not have
            /// access to this group.</summary>
            [Google.Apis.Util.RequestParameterAttribute("advertiserId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> AdvertiserId { get; set; }

            /// <summary>The ID of the partner that owns the inventory source group. Only this partner will have write
            /// access to this group. Only advertisers to which this group is explicitly shared will have read access to
            /// this group.</summary>
            [Google.Apis.Util.RequestParameterAttribute("partnerId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> PartnerId { get; set; }


            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.DisplayVideo.v1.Data.InventorySourceGroup Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "create";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/inventorySourceGroups";

            /// <summary>Initializes Create parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add("advertiserId", new Google.Apis.Discovery.Parameter
                {
                    Name = "advertiserId",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("partnerId", new Google.Apis.Discovery.Parameter
                {
                    Name = "partnerId",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }

        }

        /// <summary>Deletes an inventory source group.</summary>
        /// <param name="inventorySourceGroupId">Required. The ID of the inventory source group to delete.</param>
        public virtual DeleteRequest Delete(long inventorySourceGroupId)
        {
            return new DeleteRequest(service, inventorySourceGroupId);
        }

        /// <summary>Deletes an inventory source group.</summary>
        public class DeleteRequest : DisplayVideoBaseServiceRequest<Google.Apis.DisplayVideo.v1.Data.Empty>
        {
            /// <summary>Constructs a new Delete request.</summary>
            public DeleteRequest(Google.Apis.Services.IClientService service, long inventorySourceGroupId) : base(service)
            {
                InventorySourceGroupId = inventorySourceGroupId;
                InitParameters();
            }


            /// <summary>Required. The ID of the inventory source group to delete.</summary>
            [Google.Apis.Util.RequestParameterAttribute("inventorySourceGroupId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual long InventorySourceGroupId { get; private set; }

            /// <summary>The ID of the advertiser that owns the inventory source group. The parent partner does not have
            /// access to this group.</summary>
            [Google.Apis.Util.RequestParameterAttribute("advertiserId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> AdvertiserId { get; set; }

            /// <summary>The ID of the partner that owns the inventory source group. Only this partner has write access
            /// to this group.</summary>
            [Google.Apis.Util.RequestParameterAttribute("partnerId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> PartnerId { get; set; }


            /// <summary>Gets the method name.</summary>
            public override string MethodName => "delete";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "DELETE";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/inventorySourceGroups/{+inventorySourceGroupId}";

            /// <summary>Initializes Delete parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add("inventorySourceGroupId", new Google.Apis.Discovery.Parameter
                {
                    Name = "inventorySourceGroupId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^[^/]+$",
                });
                RequestParameters.Add("advertiserId", new Google.Apis.Discovery.Parameter
                {
                    Name = "advertiserId",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("partnerId", new Google.Apis.Discovery.Parameter
                {
                    Name = "partnerId",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }

        }

        /// <summary>Gets an inventory source group.</summary>
        /// <param name="inventorySourceGroupId">Required. The ID of the inventory source group to fetch.</param>
        public virtual GetRequest Get(long inventorySourceGroupId)
        {
            return new GetRequest(service, inventorySourceGroupId);
        }

        /// <summary>Gets an inventory source group.</summary>
        public class GetRequest : DisplayVideoBaseServiceRequest<Google.Apis.DisplayVideo.v1.Data.InventorySourceGroup>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, long inventorySourceGroupId) : base(service)
            {
                InventorySourceGroupId = inventorySourceGroupId;
                InitParameters();
            }


            /// <summary>Required. The ID of the inventory source group to fetch.</summary>
            [Google.Apis.Util.RequestParameterAttribute("inventorySourceGroupId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual long InventorySourceGroupId { get; private set; }

            /// <summary>The ID of the advertiser that has access to the inventory source group. If an inventory source
            /// group is partner-owned, only advertisers to which the group is explicitly shared can access the
            /// group.</summary>
            [Google.Apis.Util.RequestParameterAttribute("advertiserId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> AdvertiserId { get; set; }

            /// <summary>The ID of the partner that has access to the inventory source group. A partner cannot access an
            /// advertiser-owned inventory source group.</summary>
            [Google.Apis.Util.RequestParameterAttribute("partnerId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> PartnerId { get; set; }


            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/inventorySourceGroups/{+inventorySourceGroupId}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add("inventorySourceGroupId", new Google.Apis.Discovery.Parameter
                {
                    Name = "inventorySourceGroupId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^[^/]+$",
                });
                RequestParameters.Add("advertiserId", new Google.Apis.Discovery.Parameter
                {
                    Name = "advertiserId",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("partnerId", new Google.Apis.Discovery.Parameter
                {
                    Name = "partnerId",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }

        }

        /// <summary>Lists inventory source groups that are accessible to the current user. The order is defined by the
        /// order_by parameter.</summary>
        public virtual ListRequest List()
        {
            return new ListRequest(service);
        }

        /// <summary>Lists inventory source groups that are accessible to the current user. The order is defined by the
        /// order_by parameter.</summary>
        public class ListRequest : DisplayVideoBaseServiceRequest<Google.Apis.DisplayVideo.v1.Data.ListInventorySourceGroupsResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }


            /// <summary>The ID of the advertiser that has access to the inventory source group. If an inventory source
            /// group is partner-owned, only advertisers to which the group is explicitly shared can access the
            /// group.</summary>
            [Google.Apis.Util.RequestParameterAttribute("advertiserId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> AdvertiserId { get; set; }

            /// <summary>Allows filtering by inventory source group properties. Supported syntax: * Filter expressions
            /// are made up of one or more restrictions. * Restrictions can be combined by the logical operator `OR`. *
            /// A restriction has the form of `{field} {operator} {value}`. * The operator must be `EQUALS (=)`. *
            /// Supported fields: - `inventorySourceGroupId` The length of this field should be no more than 500
            /// characters.</summary>
            [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Filter { get; set; }

            /// <summary>Field by which to sort the list. Acceptable values are: * `displayName` (default) *
            /// `inventorySourceGroupId` The default sorting order is ascending. To specify descending order for a
            /// field, a suffix "desc" should be added to the field name. For example, `displayName desc`.</summary>
            [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string OrderBy { get; set; }

            /// <summary>Requested page size. Must be between `1` and `100`. If unspecified will default to
            /// `100`.</summary>
            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> PageSize { get; set; }

            /// <summary>A token identifying a page of results the server should return. Typically, this is the value of
            /// next_page_token returned from the previous call to `ListInventorySources` method. If not specified, the
            /// first page of results will be returned.</summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>The ID of the partner that has access to the inventory source group. A partner cannot access
            /// advertiser-owned inventory source groups.</summary>
            [Google.Apis.Util.RequestParameterAttribute("partnerId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> PartnerId { get; set; }


            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/inventorySourceGroups";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add("advertiserId", new Google.Apis.Discovery.Parameter
                {
                    Name = "advertiserId",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("filter", new Google.Apis.Discovery.Parameter
                {
                    Name = "filter",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
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
                RequestParameters.Add("pageSize", new Google.Apis.Discovery.Parameter
                {
                    Name = "pageSize",
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
                RequestParameters.Add("partnerId", new Google.Apis.Discovery.Parameter
                {
                    Name = "partnerId",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }

        }

        /// <summary>Updates an inventory source group. Returns the updated inventory source group if
        /// successful.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="inventorySourceGroupId">Output only. The unique ID of the inventory source group. Assigned by the
        /// system.</param>
        public virtual PatchRequest Patch(Google.Apis.DisplayVideo.v1.Data.InventorySourceGroup body, long inventorySourceGroupId)
        {
            return new PatchRequest(service, body, inventorySourceGroupId);
        }

        /// <summary>Updates an inventory source group. Returns the updated inventory source group if
        /// successful.</summary>
        public class PatchRequest : DisplayVideoBaseServiceRequest<Google.Apis.DisplayVideo.v1.Data.InventorySourceGroup>
        {
            /// <summary>Constructs a new Patch request.</summary>
            public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.DisplayVideo.v1.Data.InventorySourceGroup body, long inventorySourceGroupId) : base(service)
            {
                InventorySourceGroupId = inventorySourceGroupId;
                Body = body;
                InitParameters();
            }


            /// <summary>Output only. The unique ID of the inventory source group. Assigned by the system.</summary>
            [Google.Apis.Util.RequestParameterAttribute("inventorySourceGroupId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual long InventorySourceGroupId { get; private set; }

            /// <summary>The ID of the advertiser that owns the inventory source group. The parent partner does not have
            /// access to this group.</summary>
            [Google.Apis.Util.RequestParameterAttribute("advertiserId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> AdvertiserId { get; set; }

            /// <summary>The ID of the partner that owns the inventory source group. Only this partner has write access
            /// to this group.</summary>
            [Google.Apis.Util.RequestParameterAttribute("partnerId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> PartnerId { get; set; }

            /// <summary>Required. The mask to control which fields to update.</summary>
            [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
            public virtual object UpdateMask { get; set; }


            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.DisplayVideo.v1.Data.InventorySourceGroup Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "patch";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PATCH";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/inventorySourceGroups/{inventorySourceGroupId}";

            /// <summary>Initializes Patch parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add("inventorySourceGroupId", new Google.Apis.Discovery.Parameter
                {
                    Name = "inventorySourceGroupId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("advertiserId", new Google.Apis.Discovery.Parameter
                {
                    Name = "advertiserId",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("partnerId", new Google.Apis.Discovery.Parameter
                {
                    Name = "partnerId",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("updateMask", new Google.Apis.Discovery.Parameter
                {
                    Name = "updateMask",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }

        }
    }

    /// <summary>The "inventorySources" collection of methods.</summary>
    public class InventorySourcesResource
    {
        private const string Resource = "inventorySources";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public InventorySourcesResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;

        }


        /// <summary>Gets an inventory source.</summary>
        /// <param name="inventorySourceId">Required. The ID of the inventory source to fetch.</param>
        public virtual GetRequest Get(long inventorySourceId)
        {
            return new GetRequest(service, inventorySourceId);
        }

        /// <summary>Gets an inventory source.</summary>
        public class GetRequest : DisplayVideoBaseServiceRequest<Google.Apis.DisplayVideo.v1.Data.InventorySource>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, long inventorySourceId) : base(service)
            {
                InventorySourceId = inventorySourceId;
                InitParameters();
            }


            /// <summary>Required. The ID of the inventory source to fetch.</summary>
            [Google.Apis.Util.RequestParameterAttribute("inventorySourceId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual long InventorySourceId { get; private set; }

            /// <summary>Required. The ID of the DV360 partner to which the fetched inventory source is
            /// permissioned.</summary>
            [Google.Apis.Util.RequestParameterAttribute("partnerId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> PartnerId { get; set; }


            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/inventorySources/{+inventorySourceId}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add("inventorySourceId", new Google.Apis.Discovery.Parameter
                {
                    Name = "inventorySourceId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^[^/]+$",
                });
                RequestParameters.Add("partnerId", new Google.Apis.Discovery.Parameter
                {
                    Name = "partnerId",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }

        }

        /// <summary>Lists inventory sources that are accessible to the current user. The order is defined by the
        /// order_by parameter. If a filter by entity_status is not specified, inventory sources with entity status
        /// `ENTITY_STATUS_ARCHIVED` will not be included in the results.</summary>
        public virtual ListRequest List()
        {
            return new ListRequest(service);
        }

        /// <summary>Lists inventory sources that are accessible to the current user. The order is defined by the
        /// order_by parameter. If a filter by entity_status is not specified, inventory sources with entity status
        /// `ENTITY_STATUS_ARCHIVED` will not be included in the results.</summary>
        public class ListRequest : DisplayVideoBaseServiceRequest<Google.Apis.DisplayVideo.v1.Data.ListInventorySourcesResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }


            /// <summary>The ID of the advertiser that has access to the inventory source.</summary>
            [Google.Apis.Util.RequestParameterAttribute("advertiserId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> AdvertiserId { get; set; }

            /// <summary>Allows filtering by inventory source properties. Supported syntax: * Filter expressions are
            /// made up of one or more restrictions. * Restrictions can be combined by `AND` or `OR` logical operators.
            /// A sequence of restrictions implicitly uses `AND`. * A restriction has the form of `{field} {operator}
            /// {value}`. * The operator must be `EQUALS (=)`. * Supported fields: - `status.entityStatus` -
            /// `commitment` - `deliveryMethod` - `rateDetails.rateType` - `exchange` Examples: * All active inventory
            /// sources: `status.entityStatus="ENTITY_STATUS_ACTIVE"` * Inventory sources belonging to Google Ad Manager
            /// or Rubicon exchanges: `exchange="EXCHANGE_GOOGLE_AD_MANAGER" OR exchange="EXCHANGE_RUBICON"` The length
            /// of this field should be no more than 500 characters.</summary>
            [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Filter { get; set; }

            /// <summary>Field by which to sort the list. Acceptable values are: * `displayName` (default) The default
            /// sorting order is ascending. To specify descending order for a field, a suffix "desc" should be added to
            /// the field name. For example, `displayName desc`.</summary>
            [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string OrderBy { get; set; }

            /// <summary>Requested page size. Must be between `1` and `100`. If unspecified will default to
            /// `100`.</summary>
            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> PageSize { get; set; }

            /// <summary>A token identifying a page of results the server should return. Typically, this is the value of
            /// next_page_token returned from the previous call to `ListInventorySources` method. If not specified, the
            /// first page of results will be returned.</summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>The ID of the partner that has access to the inventory source.</summary>
            [Google.Apis.Util.RequestParameterAttribute("partnerId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> PartnerId { get; set; }


            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/inventorySources";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add("advertiserId", new Google.Apis.Discovery.Parameter
                {
                    Name = "advertiserId",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("filter", new Google.Apis.Discovery.Parameter
                {
                    Name = "filter",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
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
                RequestParameters.Add("pageSize", new Google.Apis.Discovery.Parameter
                {
                    Name = "pageSize",
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
                RequestParameters.Add("partnerId", new Google.Apis.Discovery.Parameter
                {
                    Name = "partnerId",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }

        }
    }

    /// <summary>The "media" collection of methods.</summary>
    public class MediaResource
    {
        private const string Resource = "media";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public MediaResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;

        }


        /// <summary>Downloads media. Download is supported on the URI `/download/{resource_name=**}?alt=media.`
        /// **Note**: Download requests will not be successful without including `alt=media` query string.</summary>
        /// <param name="resourceName">Name of the media that is being downloaded. See ReadRequest.resource_name.</param>
        public virtual DownloadRequest Download(string resourceName)
        {
            return new DownloadRequest(service, resourceName);
        }

        /// <summary>Downloads media. Download is supported on the URI `/download/{resource_name=**}?alt=media.`
        /// **Note**: Download requests will not be successful without including `alt=media` query string.</summary>
        public class DownloadRequest : DisplayVideoBaseServiceRequest<Google.Apis.DisplayVideo.v1.Data.GoogleBytestreamMedia>
        {
            /// <summary>Constructs a new Download request.</summary>
            public DownloadRequest(Google.Apis.Services.IClientService service, string resourceName) : base(service)
            {
                ResourceName = resourceName;
                MediaDownloader = new Google.Apis.Download.MediaDownloader(service);
                InitParameters();
            }


            /// <summary>Name of the media that is being downloaded. See ReadRequest.resource_name.</summary>
            [Google.Apis.Util.RequestParameterAttribute("resourceName", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ResourceName { get; private set; }


            /// <summary>Gets the method name.</summary>
            public override string MethodName => "download";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "download/{+resourceName}";

            /// <summary>Initializes Download parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add("resourceName", new Google.Apis.Discovery.Parameter
                {
                    Name = "resourceName",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^.*$",
                });
            }

            /// <summary>Gets the media downloader.</summary>
            public Google.Apis.Download.IMediaDownloader MediaDownloader { get; private set; }

            /// <summary>
            /// <para>Synchronously download the media into the given stream.</para>
            /// <para>Warning: This method hides download errors; use <see cref="DownloadWithStatus"/> instead.</para>
            /// </summary>
            public virtual void Download(System.IO.Stream stream)
            {
                MediaDownloader.Download(this.GenerateRequestUri(), stream);
            }

            /// <summary>Synchronously download the media into the given stream.</summary>
            /// <returns>The final status of the download; including whether the download succeeded or failed.</returns>
            public virtual Google.Apis.Download.IDownloadProgress DownloadWithStatus(System.IO.Stream stream)
            {
                return MediaDownloader.Download(this.GenerateRequestUri(), stream);
            }

            /// <summary>Asynchronously download the media into the given stream.</summary>
            public virtual System.Threading.Tasks.Task<Google.Apis.Download.IDownloadProgress> DownloadAsync(System.IO.Stream stream)
            {
                return MediaDownloader.DownloadAsync(this.GenerateRequestUri(), stream);
            }

            /// <summary>Asynchronously download the media into the given stream.</summary>
            public virtual System.Threading.Tasks.Task<Google.Apis.Download.IDownloadProgress> DownloadAsync(System.IO.Stream stream,
                System.Threading.CancellationToken cancellationToken)
            {
                return MediaDownloader.DownloadAsync(this.GenerateRequestUri(), stream, cancellationToken);
            }

            #if !NET40
            /// <summary>Synchronously download a range of the media into the given stream.</summary>
            public virtual Google.Apis.Download.IDownloadProgress DownloadRange(System.IO.Stream stream, System.Net.Http.Headers.RangeHeaderValue range)
            {
                var mediaDownloader = new Google.Apis.Download.MediaDownloader(Service);
                mediaDownloader.Range = range;
                return mediaDownloader.Download(this.GenerateRequestUri(), stream);
            }

            /// <summary>Asynchronously download a range of the media into the given stream.</summary>
            public virtual System.Threading.Tasks.Task<Google.Apis.Download.IDownloadProgress> DownloadRangeAsync(System.IO.Stream stream,
                System.Net.Http.Headers.RangeHeaderValue range,
                System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                var mediaDownloader = new Google.Apis.Download.MediaDownloader(Service);
                mediaDownloader.Range = range;
                return mediaDownloader.DownloadAsync(this.GenerateRequestUri(), stream, cancellationToken);
            }
            #endif

        }
    }

    /// <summary>The "partners" collection of methods.</summary>
    public class PartnersResource
    {
        private const string Resource = "partners";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public PartnersResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
            Channels = new ChannelsResource(service);
            TargetingTypes = new TargetingTypesResource(service);

        }

        /// <summary>Gets the Channels resource.</summary>
        public virtual ChannelsResource Channels { get; }

        /// <summary>The "channels" collection of methods.</summary>
        public class ChannelsResource
        {
            private const string Resource = "channels";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public ChannelsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
                Sites = new SitesResource(service);

            }

            /// <summary>Gets the Sites resource.</summary>
            public virtual SitesResource Sites { get; }

            /// <summary>The "sites" collection of methods.</summary>
            public class SitesResource
            {
                private const string Resource = "sites";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public SitesResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;

                }


                /// <summary>Bulk edits sites under a single channel. The operation will delete the sites provided in
                /// BulkEditSitesRequest.deleted_sites and then create the sites provided in
                /// BulkEditSitesRequest.created_sites.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="partnerId">The ID of the partner that owns the parent channel.</param>
                /// <param
                /// name="channelId">Required. The ID of the parent channel to which the sites belong.</param>
                public virtual BulkEditRequest BulkEdit(Google.Apis.DisplayVideo.v1.Data.BulkEditSitesRequest body, long partnerId, long channelId)
                {
                    return new BulkEditRequest(service, body, partnerId, channelId);
                }

                /// <summary>Bulk edits sites under a single channel. The operation will delete the sites provided in
                /// BulkEditSitesRequest.deleted_sites and then create the sites provided in
                /// BulkEditSitesRequest.created_sites.</summary>
                public class BulkEditRequest : DisplayVideoBaseServiceRequest<Google.Apis.DisplayVideo.v1.Data.BulkEditSitesResponse>
                {
                    /// <summary>Constructs a new BulkEdit request.</summary>
                    public BulkEditRequest(Google.Apis.Services.IClientService service, Google.Apis.DisplayVideo.v1.Data.BulkEditSitesRequest body, long partnerId, long channelId) : base(service)
                    {
                        PartnerId = partnerId;
                        ChannelId = channelId;
                        Body = body;
                        InitParameters();
                    }


                    /// <summary>The ID of the partner that owns the parent channel.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("partnerId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual long PartnerId { get; private set; }

                    /// <summary>Required. The ID of the parent channel to which the sites belong.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("channelId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual long ChannelId { get; private set; }


                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.DisplayVideo.v1.Data.BulkEditSitesRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "bulkEdit";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/partners/{partnerId}/channels/{+channelId}/sites:bulkEdit";

                    /// <summary>Initializes BulkEdit parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();

                        RequestParameters.Add("partnerId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "partnerId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("channelId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "channelId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^[^/]+$",
                        });
                    }

                }

                /// <summary>Creates a site in a channel.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="partnerId">The ID of the partner that owns the parent channel.</param>
                /// <param
                /// name="channelId">Required. The ID of the parent channel in which the site will be created.</param>
                public virtual CreateRequest Create(Google.Apis.DisplayVideo.v1.Data.Site body, long partnerId, long channelId)
                {
                    return new CreateRequest(service, body, partnerId, channelId);
                }

                /// <summary>Creates a site in a channel.</summary>
                public class CreateRequest : DisplayVideoBaseServiceRequest<Google.Apis.DisplayVideo.v1.Data.Site>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.DisplayVideo.v1.Data.Site body, long partnerId, long channelId) : base(service)
                    {
                        PartnerId = partnerId;
                        ChannelId = channelId;
                        Body = body;
                        InitParameters();
                    }


                    /// <summary>The ID of the partner that owns the parent channel.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("partnerId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual long PartnerId { get; private set; }

                    /// <summary>Required. The ID of the parent channel in which the site will be created.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("channelId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual long ChannelId { get; private set; }

                    /// <summary>The ID of the advertiser that owns the parent channel.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("advertiserId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<long> AdvertiserId { get; set; }


                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.DisplayVideo.v1.Data.Site Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/partners/{partnerId}/channels/{+channelId}/sites";

                    /// <summary>Initializes Create parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();

                        RequestParameters.Add("partnerId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "partnerId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("channelId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "channelId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^[^/]+$",
                        });
                        RequestParameters.Add("advertiserId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "advertiserId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }

                }

                /// <summary>Deletes a site from a channel.</summary>
                /// <param name="partnerId">The ID of the partner that owns the parent channel.</param>
                /// <param
                /// name="channelId">Required. The ID of the parent channel to which the site belongs.</param>
                /// <param
                /// name="urlOrAppId">Required. The URL or app ID of the site to delete.</param>
                public virtual DeleteRequest Delete(long partnerId, long channelId, string urlOrAppId)
                {
                    return new DeleteRequest(service, partnerId, channelId, urlOrAppId);
                }

                /// <summary>Deletes a site from a channel.</summary>
                public class DeleteRequest : DisplayVideoBaseServiceRequest<Google.Apis.DisplayVideo.v1.Data.Empty>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, long partnerId, long channelId, string urlOrAppId) : base(service)
                    {
                        PartnerId = partnerId;
                        ChannelId = channelId;
                        UrlOrAppId = urlOrAppId;
                        InitParameters();
                    }


                    /// <summary>The ID of the partner that owns the parent channel.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("partnerId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual long PartnerId { get; private set; }

                    /// <summary>Required. The ID of the parent channel to which the site belongs.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("channelId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual long ChannelId { get; private set; }

                    /// <summary>Required. The URL or app ID of the site to delete.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("urlOrAppId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string UrlOrAppId { get; private set; }

                    /// <summary>The ID of the advertiser that owns the parent channel.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("advertiserId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<long> AdvertiserId { get; set; }


                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "delete";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "DELETE";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/partners/{partnerId}/channels/{+channelId}/sites/{+urlOrAppId}";

                    /// <summary>Initializes Delete parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();

                        RequestParameters.Add("partnerId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "partnerId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("channelId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "channelId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^[^/]+$",
                        });
                        RequestParameters.Add("urlOrAppId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "urlOrAppId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^[^/]+$",
                        });
                        RequestParameters.Add("advertiserId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "advertiserId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }

                }

                /// <summary>Lists sites in a channel.</summary>
                /// <param name="partnerId">The ID of the partner that owns the parent channel.</param>
                /// <param
                /// name="channelId">Required. The ID of the parent channel to which the requested sites belong.</param>
                public virtual ListRequest List(long partnerId, long channelId)
                {
                    return new ListRequest(service, partnerId, channelId);
                }

                /// <summary>Lists sites in a channel.</summary>
                public class ListRequest : DisplayVideoBaseServiceRequest<Google.Apis.DisplayVideo.v1.Data.ListSitesResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, long partnerId, long channelId) : base(service)
                    {
                        PartnerId = partnerId;
                        ChannelId = channelId;
                        InitParameters();
                    }


                    /// <summary>The ID of the partner that owns the parent channel.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("partnerId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual long PartnerId { get; private set; }

                    /// <summary>Required. The ID of the parent channel to which the requested sites belong.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("channelId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual long ChannelId { get; private set; }

                    /// <summary>The ID of the advertiser that owns the parent channel.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("advertiserId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<long> AdvertiserId { get; set; }

                    /// <summary>Allows filtering by site fields. Supported syntax: * Filter expressions for site
                    /// currently can only contain at most one * restriction. * A restriction has the form of `{field}
                    /// {operator} {value}`. * The operator must be `CONTAINS (:)`. * Supported fields: - `urlOrAppId`
                    /// Examples: * All sites for which the URL or app ID contains "google": `urlOrAppId :
                    /// "google"`</summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>Field by which to sort the list. Acceptable values are: * `urlOrAppId` (default) The
                    /// default sorting order is ascending. To specify descending order for a field, a suffix " desc"
                    /// should be added to the field name. Example: `urlOrAppId desc`.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string OrderBy { get; set; }

                    /// <summary>Requested page size. Must be between `1` and `100`. If unspecified will default to
                    /// `100`. Returns error code `INVALID_ARGUMENT` if an invalid value is specified.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>A token identifying a page of results the server should return. Typically, this is the
                    /// value of next_page_token returned from the previous call to `ListSites` method. If not
                    /// specified, the first page of results will be returned.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }


                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/partners/{+partnerId}/channels/{+channelId}/sites";

                    /// <summary>Initializes List parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();

                        RequestParameters.Add("partnerId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "partnerId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^[^/]+$",
                        });
                        RequestParameters.Add("channelId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "channelId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^[^/]+$",
                        });
                        RequestParameters.Add("advertiserId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "advertiserId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("filter", new Google.Apis.Discovery.Parameter
                        {
                            Name = "filter",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
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
                        RequestParameters.Add("pageSize", new Google.Apis.Discovery.Parameter
                        {
                            Name = "pageSize",
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
            }

            /// <summary>Creates a new channel. Returns the newly created channel if successful.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="partnerId">The ID of the partner that owns the created channel.</param>
            public virtual CreateRequest Create(Google.Apis.DisplayVideo.v1.Data.Channel body, long partnerId)
            {
                return new CreateRequest(service, body, partnerId);
            }

            /// <summary>Creates a new channel. Returns the newly created channel if successful.</summary>
            public class CreateRequest : DisplayVideoBaseServiceRequest<Google.Apis.DisplayVideo.v1.Data.Channel>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.DisplayVideo.v1.Data.Channel body, long partnerId) : base(service)
                {
                    PartnerId = partnerId;
                    Body = body;
                    InitParameters();
                }


                /// <summary>The ID of the partner that owns the created channel.</summary>
                [Google.Apis.Util.RequestParameterAttribute("partnerId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual long PartnerId { get; private set; }

                /// <summary>The ID of the advertiser that owns the created channel.</summary>
                [Google.Apis.Util.RequestParameterAttribute("advertiserId", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<long> AdvertiserId { get; set; }


                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.DisplayVideo.v1.Data.Channel Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/partners/{+partnerId}/channels";

                /// <summary>Initializes Create parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();

                    RequestParameters.Add("partnerId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "partnerId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^[^/]+$",
                    });
                    RequestParameters.Add("advertiserId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "advertiserId",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }

            }

            /// <summary>Gets a channel for a partner or advertiser.</summary>
            /// <param name="partnerId">The ID of the partner that owns the fetched channel.</param>
            /// <param
            /// name="channelId">Required. The ID of the channel to fetch.</param>
            public virtual GetRequest Get(long partnerId, long channelId)
            {
                return new GetRequest(service, partnerId, channelId);
            }

            /// <summary>Gets a channel for a partner or advertiser.</summary>
            public class GetRequest : DisplayVideoBaseServiceRequest<Google.Apis.DisplayVideo.v1.Data.Channel>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, long partnerId, long channelId) : base(service)
                {
                    PartnerId = partnerId;
                    ChannelId = channelId;
                    InitParameters();
                }


                /// <summary>The ID of the partner that owns the fetched channel.</summary>
                [Google.Apis.Util.RequestParameterAttribute("partnerId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual long PartnerId { get; private set; }

                /// <summary>Required. The ID of the channel to fetch.</summary>
                [Google.Apis.Util.RequestParameterAttribute("channelId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual long ChannelId { get; private set; }

                /// <summary>The ID of the advertiser that owns the fetched channel.</summary>
                [Google.Apis.Util.RequestParameterAttribute("advertiserId", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<long> AdvertiserId { get; set; }


                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/partners/{+partnerId}/channels/{+channelId}";

                /// <summary>Initializes Get parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();

                    RequestParameters.Add("partnerId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "partnerId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^[^/]+$",
                    });
                    RequestParameters.Add("channelId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "channelId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^[^/]+$",
                    });
                    RequestParameters.Add("advertiserId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "advertiserId",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }

            }

            /// <summary>Lists channels for a partner or advertiser.</summary>
            /// <param name="partnerId">The ID of the partner that owns the channels.</param>
            public virtual ListRequest List(long partnerId)
            {
                return new ListRequest(service, partnerId);
            }

            /// <summary>Lists channels for a partner or advertiser.</summary>
            public class ListRequest : DisplayVideoBaseServiceRequest<Google.Apis.DisplayVideo.v1.Data.ListChannelsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, long partnerId) : base(service)
                {
                    PartnerId = partnerId;
                    InitParameters();
                }


                /// <summary>The ID of the partner that owns the channels.</summary>
                [Google.Apis.Util.RequestParameterAttribute("partnerId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual long PartnerId { get; private set; }

                /// <summary>The ID of the advertiser that owns the channels.</summary>
                [Google.Apis.Util.RequestParameterAttribute("advertiserId", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<long> AdvertiserId { get; set; }

                /// <summary>Allows filtering by channel fields. Supported syntax: * Filter expressions for channel
                /// currently can only contain at most one * restriction. * A restriction has the form of `{field}
                /// {operator} {value}`. * The operator must be `CONTAINS (:)`. * Supported fields: - `displayName`
                /// Examples: * All channels for which the display name contains "google": `displayName : "google"`. The
                /// length of this field should be no more than 500 characters.</summary>
                [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Filter { get; set; }

                /// <summary>Field by which to sort the list. Acceptable values are: * `displayName` (default) *
                /// `channelId` The default sorting order is ascending. To specify descending order for a field, a
                /// suffix " desc" should be added to the field name. Example: `displayName desc`.</summary>
                [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string OrderBy { get; set; }

                /// <summary>Requested page size. Must be between `1` and `100`. If unspecified will default to `100`.
                /// Returns error code `INVALID_ARGUMENT` if an invalid value is specified.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>A token identifying a page of results the server should return. Typically, this is the
                /// value of next_page_token returned from the previous call to `ListChannels` method. If not specified,
                /// the first page of results will be returned.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }


                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/partners/{+partnerId}/channels";

                /// <summary>Initializes List parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();

                    RequestParameters.Add("partnerId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "partnerId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^[^/]+$",
                    });
                    RequestParameters.Add("advertiserId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "advertiserId",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("filter", new Google.Apis.Discovery.Parameter
                    {
                        Name = "filter",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
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
                    RequestParameters.Add("pageSize", new Google.Apis.Discovery.Parameter
                    {
                        Name = "pageSize",
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

            /// <summary>Updates a channel. Returns the updated channel if successful.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="partnerId">The ID of the partner that owns the created channel.</param>
            /// <param
            /// name="channelId">Output only. The unique ID of the channel. Assigned by the system.</param>
            public virtual PatchRequest Patch(Google.Apis.DisplayVideo.v1.Data.Channel body, long partnerId, long channelId)
            {
                return new PatchRequest(service, body, partnerId, channelId);
            }

            /// <summary>Updates a channel. Returns the updated channel if successful.</summary>
            public class PatchRequest : DisplayVideoBaseServiceRequest<Google.Apis.DisplayVideo.v1.Data.Channel>
            {
                /// <summary>Constructs a new Patch request.</summary>
                public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.DisplayVideo.v1.Data.Channel body, long partnerId, long channelId) : base(service)
                {
                    PartnerId = partnerId;
                    ChannelId = channelId;
                    Body = body;
                    InitParameters();
                }


                /// <summary>The ID of the partner that owns the created channel.</summary>
                [Google.Apis.Util.RequestParameterAttribute("partnerId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual long PartnerId { get; private set; }

                /// <summary>Output only. The unique ID of the channel. Assigned by the system.</summary>
                [Google.Apis.Util.RequestParameterAttribute("channelId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual long ChannelId { get; private set; }

                /// <summary>The ID of the advertiser that owns the created channel.</summary>
                [Google.Apis.Util.RequestParameterAttribute("advertiserId", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<long> AdvertiserId { get; set; }

                /// <summary>Required. The mask to control which fields to update.</summary>
                [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                public virtual object UpdateMask { get; set; }


                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.DisplayVideo.v1.Data.Channel Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "patch";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PATCH";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/partners/{+partnerId}/channels/{channelId}";

                /// <summary>Initializes Patch parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();

                    RequestParameters.Add("partnerId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "partnerId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^[^/]+$",
                    });
                    RequestParameters.Add("channelId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "channelId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("advertiserId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "advertiserId",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("updateMask", new Google.Apis.Discovery.Parameter
                    {
                        Name = "updateMask",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }

            }
        }
        /// <summary>Gets the TargetingTypes resource.</summary>
        public virtual TargetingTypesResource TargetingTypes { get; }

        /// <summary>The "targetingTypes" collection of methods.</summary>
        public class TargetingTypesResource
        {
            private const string Resource = "targetingTypes";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public TargetingTypesResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
                AssignedTargetingOptions = new AssignedTargetingOptionsResource(service);

            }

            /// <summary>Gets the AssignedTargetingOptions resource.</summary>
            public virtual AssignedTargetingOptionsResource AssignedTargetingOptions { get; }

            /// <summary>The "assignedTargetingOptions" collection of methods.</summary>
            public class AssignedTargetingOptionsResource
            {
                private const string Resource = "assignedTargetingOptions";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public AssignedTargetingOptionsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;

                }


                /// <summary>Assigns a targeting option to a partner. Returns the assigned targeting option if
                /// successful.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="partnerId">Required. The ID of the partner.</param>
                /// <param name="targetingType">Required.
                /// Identifies the type of this assigned targeting option. Supported targeting types: *
                /// `TARGETING_TYPE_CHANNEL`</param>
                public virtual CreateRequest Create(Google.Apis.DisplayVideo.v1.Data.AssignedTargetingOption body, long partnerId, CreateRequest.TargetingTypeEnum targetingType)
                {
                    return new CreateRequest(service, body, partnerId, targetingType);
                }

                /// <summary>Assigns a targeting option to a partner. Returns the assigned targeting option if
                /// successful.</summary>
                public class CreateRequest : DisplayVideoBaseServiceRequest<Google.Apis.DisplayVideo.v1.Data.AssignedTargetingOption>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.DisplayVideo.v1.Data.AssignedTargetingOption body, long partnerId, CreateRequest.TargetingTypeEnum targetingType) : base(service)
                    {
                        PartnerId = partnerId;
                        TargetingType = targetingType;
                        Body = body;
                        InitParameters();
                    }


                    /// <summary>Required. The ID of the partner.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("partnerId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual long PartnerId { get; private set; }

                    /// <summary>Required. Identifies the type of this assigned targeting option. Supported targeting
                    /// types: * `TARGETING_TYPE_CHANNEL`</summary>
                    [Google.Apis.Util.RequestParameterAttribute("targetingType", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual TargetingTypeEnum TargetingType { get; private set; }

                    /// <summary>Required. Identifies the type of this assigned targeting option. Supported targeting
                    /// types: * `TARGETING_TYPE_CHANNEL`</summary>
                    public enum TargetingTypeEnum
                    {
                        /// <summary>Default value when type is not specified or is unknown in this version.</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_UNSPECIFIED")]
                        TARGETINGTYPEUNSPECIFIED,
                        /// <summary>Target a channel (a custom group of related websites or apps).</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_CHANNEL")]
                        TARGETINGTYPECHANNEL,
                        /// <summary>Target an app category (for example, education or puzzle games).</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_APP_CATEGORY")]
                        TARGETINGTYPEAPPCATEGORY,
                        /// <summary>Target a specific app (for example, Angry Birds).</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_APP")]
                        TARGETINGTYPEAPP,
                        /// <summary>Target a specific url (for example, quora.com).</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_URL")]
                        TARGETINGTYPEURL,
                        /// <summary>Target ads during a chosen time period on a specific day.</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_DAY_AND_TIME")]
                        TARGETINGTYPEDAYANDTIME,
                        /// <summary>Target ads to a specific age range (for example, 18-24).</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_AGE_RANGE")]
                        TARGETINGTYPEAGERANGE,
                        /// <summary>Target ads to the specified regions on a regional location list.</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_REGIONAL_LOCATION_LIST")]
                        TARGETINGTYPEREGIONALLOCATIONLIST,
                        /// <summary>Target ads to the specified points of interest on a proximity location
                        /// list.</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_PROXIMITY_LOCATION_LIST")]
                        TARGETINGTYPEPROXIMITYLOCATIONLIST,
                        /// <summary>Target ads to a specific gender (for example, female or male).</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_GENDER")]
                        TARGETINGTYPEGENDER,
                        /// <summary>Target a specific video player size for video ads.</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_VIDEO_PLAYER_SIZE")]
                        TARGETINGTYPEVIDEOPLAYERSIZE,
                        /// <summary>Target user rewarded content for video ads.</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_USER_REWARDED_CONTENT")]
                        TARGETINGTYPEUSERREWARDEDCONTENT,
                        /// <summary>Target ads to a specific parental status (for example, parent or not a
                        /// parent).</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_PARENTAL_STATUS")]
                        TARGETINGTYPEPARENTALSTATUS,
                        /// <summary>Target video or audio ads in a specific content instream position (for example,
                        /// pre-roll, mid-roll, or post-roll).</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_CONTENT_INSTREAM_POSITION")]
                        TARGETINGTYPECONTENTINSTREAMPOSITION,
                        /// <summary>Target ads in a specific content outstream position.</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_CONTENT_OUTSTREAM_POSITION")]
                        TARGETINGTYPECONTENTOUTSTREAMPOSITION,
                        /// <summary>Target ads to a specific device type (for example, tablet or connected
                        /// TV).</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_DEVICE_TYPE")]
                        TARGETINGTYPEDEVICETYPE,
                        /// <summary>Target ads to an audience or groups of audiences. Singleton field, at most one can
                        /// exist on a single Lineitem at a time.</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_AUDIENCE_GROUP")]
                        TARGETINGTYPEAUDIENCEGROUP,
                        /// <summary>Target ads to specific web browsers (for example, Chrome).</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_BROWSER")]
                        TARGETINGTYPEBROWSER,
                        /// <summary>Target ads to a specific household income range (for example, top 10%).</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_HOUSEHOLD_INCOME")]
                        TARGETINGTYPEHOUSEHOLDINCOME,
                        /// <summary>Target ads in a specific on screen position.</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_ON_SCREEN_POSITION")]
                        TARGETINGTYPEONSCREENPOSITION,
                        /// <summary>Filter web sites through third party verification (for example, IAS or
                        /// DoubleVerify).</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_THIRD_PARTY_VERIFIER")]
                        TARGETINGTYPETHIRDPARTYVERIFIER,
                        /// <summary>Filter web sites by specific digital content label ratings (for example, DL-MA:
                        /// suitable only for mature audiences).</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_DIGITAL_CONTENT_LABEL_EXCLUSION")]
                        TARGETINGTYPEDIGITALCONTENTLABELEXCLUSION,
                        /// <summary>Filter website content by sensitive categories (for example, adult).</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_SENSITIVE_CATEGORY_EXCLUSION")]
                        TARGETINGTYPESENSITIVECATEGORYEXCLUSION,
                        /// <summary>Target ads to a specific environment (for example, web or app).</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_ENVIRONMENT")]
                        TARGETINGTYPEENVIRONMENT,
                        /// <summary>Target ads to a specific network carrier or internet service provider (ISP) (for
                        /// example, Comcast or Orange).</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_CARRIER_AND_ISP")]
                        TARGETINGTYPECARRIERANDISP,
                        /// <summary>Target ads to a specific operating system (for example, macOS).</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_OPERATING_SYSTEM")]
                        TARGETINGTYPEOPERATINGSYSTEM,
                        /// <summary>Target ads to a specific device make or model (for example, Roku or
                        /// Samsung).</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_DEVICE_MAKE_MODEL")]
                        TARGETINGTYPEDEVICEMAKEMODEL,
                        /// <summary>Target ads to a specific keyword (for example, dog or retriever).</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_KEYWORD")]
                        TARGETINGTYPEKEYWORD,
                        /// <summary>Target ads to a specific negative keyword list.</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_NEGATIVE_KEYWORD_LIST")]
                        TARGETINGTYPENEGATIVEKEYWORDLIST,
                        /// <summary>Target ads to a specific viewability (for example, 80% viewable).</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_VIEWABILITY")]
                        TARGETINGTYPEVIEWABILITY,
                        /// <summary>Target ads to a specific content category (for example, arts &
                        /// entertainment).</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_CATEGORY")]
                        TARGETINGTYPECATEGORY,
                        /// <summary>Purchase impressions from specific deals and auction packages.</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_INVENTORY_SOURCE")]
                        TARGETINGTYPEINVENTORYSOURCE,
                        /// <summary>Target ads to a specific language (for example, English or Japanese).</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_LANGUAGE")]
                        TARGETINGTYPELANGUAGE,
                        /// <summary>Target ads to ads.txt authorized sellers.</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_AUTHORIZED_SELLER_STATUS")]
                        TARGETINGTYPEAUTHORIZEDSELLERSTATUS,
                        /// <summary>Target ads to a specific regional location (for example, a city or
                        /// state).</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_GEO_REGION")]
                        TARGETINGTYPEGEOREGION,
                        /// <summary>Purchase impressions from a group of deals and auction packages.</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_INVENTORY_SOURCE_GROUP")]
                        TARGETINGTYPEINVENTORYSOURCEGROUP,
                        /// <summary>Purchase impressions from specific exchanges.</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_EXCHANGE")]
                        TARGETINGTYPEEXCHANGE,
                        /// <summary>Purchase impressions from specific sub-exchanges.</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_SUB_EXCHANGE")]
                        TARGETINGTYPESUBEXCHANGE,
                    }


                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.DisplayVideo.v1.Data.AssignedTargetingOption Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/partners/{+partnerId}/targetingTypes/{+targetingType}/assignedTargetingOptions";

                    /// <summary>Initializes Create parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();

                        RequestParameters.Add("partnerId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "partnerId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^[^/]+$",
                        });
                        RequestParameters.Add("targetingType", new Google.Apis.Discovery.Parameter
                        {
                            Name = "targetingType",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^[^/]+$",
                        });
                    }

                }

                /// <summary>Deletes an assigned targeting option from a partner.</summary>
                /// <param name="partnerId">Required. The ID of the partner.</param>
                /// <param name="targetingType">Required.
                /// Identifies the type of this assigned targeting option. Supported targeting types: *
                /// `TARGETING_TYPE_CHANNEL`</param>
                /// <param name="assignedTargetingOptionId">Required. The ID of the assigned
                /// targeting option to delete.</param>
                public virtual DeleteRequest Delete(long partnerId, DeleteRequest.TargetingTypeEnum targetingType, string assignedTargetingOptionId)
                {
                    return new DeleteRequest(service, partnerId, targetingType, assignedTargetingOptionId);
                }

                /// <summary>Deletes an assigned targeting option from a partner.</summary>
                public class DeleteRequest : DisplayVideoBaseServiceRequest<Google.Apis.DisplayVideo.v1.Data.Empty>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, long partnerId, DeleteRequest.TargetingTypeEnum targetingType, string assignedTargetingOptionId) : base(service)
                    {
                        PartnerId = partnerId;
                        TargetingType = targetingType;
                        AssignedTargetingOptionId = assignedTargetingOptionId;
                        InitParameters();
                    }


                    /// <summary>Required. The ID of the partner.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("partnerId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual long PartnerId { get; private set; }

                    /// <summary>Required. Identifies the type of this assigned targeting option. Supported targeting
                    /// types: * `TARGETING_TYPE_CHANNEL`</summary>
                    [Google.Apis.Util.RequestParameterAttribute("targetingType", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual TargetingTypeEnum TargetingType { get; private set; }

                    /// <summary>Required. Identifies the type of this assigned targeting option. Supported targeting
                    /// types: * `TARGETING_TYPE_CHANNEL`</summary>
                    public enum TargetingTypeEnum
                    {
                        /// <summary>Default value when type is not specified or is unknown in this version.</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_UNSPECIFIED")]
                        TARGETINGTYPEUNSPECIFIED,
                        /// <summary>Target a channel (a custom group of related websites or apps).</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_CHANNEL")]
                        TARGETINGTYPECHANNEL,
                        /// <summary>Target an app category (for example, education or puzzle games).</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_APP_CATEGORY")]
                        TARGETINGTYPEAPPCATEGORY,
                        /// <summary>Target a specific app (for example, Angry Birds).</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_APP")]
                        TARGETINGTYPEAPP,
                        /// <summary>Target a specific url (for example, quora.com).</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_URL")]
                        TARGETINGTYPEURL,
                        /// <summary>Target ads during a chosen time period on a specific day.</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_DAY_AND_TIME")]
                        TARGETINGTYPEDAYANDTIME,
                        /// <summary>Target ads to a specific age range (for example, 18-24).</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_AGE_RANGE")]
                        TARGETINGTYPEAGERANGE,
                        /// <summary>Target ads to the specified regions on a regional location list.</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_REGIONAL_LOCATION_LIST")]
                        TARGETINGTYPEREGIONALLOCATIONLIST,
                        /// <summary>Target ads to the specified points of interest on a proximity location
                        /// list.</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_PROXIMITY_LOCATION_LIST")]
                        TARGETINGTYPEPROXIMITYLOCATIONLIST,
                        /// <summary>Target ads to a specific gender (for example, female or male).</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_GENDER")]
                        TARGETINGTYPEGENDER,
                        /// <summary>Target a specific video player size for video ads.</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_VIDEO_PLAYER_SIZE")]
                        TARGETINGTYPEVIDEOPLAYERSIZE,
                        /// <summary>Target user rewarded content for video ads.</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_USER_REWARDED_CONTENT")]
                        TARGETINGTYPEUSERREWARDEDCONTENT,
                        /// <summary>Target ads to a specific parental status (for example, parent or not a
                        /// parent).</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_PARENTAL_STATUS")]
                        TARGETINGTYPEPARENTALSTATUS,
                        /// <summary>Target video or audio ads in a specific content instream position (for example,
                        /// pre-roll, mid-roll, or post-roll).</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_CONTENT_INSTREAM_POSITION")]
                        TARGETINGTYPECONTENTINSTREAMPOSITION,
                        /// <summary>Target ads in a specific content outstream position.</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_CONTENT_OUTSTREAM_POSITION")]
                        TARGETINGTYPECONTENTOUTSTREAMPOSITION,
                        /// <summary>Target ads to a specific device type (for example, tablet or connected
                        /// TV).</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_DEVICE_TYPE")]
                        TARGETINGTYPEDEVICETYPE,
                        /// <summary>Target ads to an audience or groups of audiences. Singleton field, at most one can
                        /// exist on a single Lineitem at a time.</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_AUDIENCE_GROUP")]
                        TARGETINGTYPEAUDIENCEGROUP,
                        /// <summary>Target ads to specific web browsers (for example, Chrome).</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_BROWSER")]
                        TARGETINGTYPEBROWSER,
                        /// <summary>Target ads to a specific household income range (for example, top 10%).</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_HOUSEHOLD_INCOME")]
                        TARGETINGTYPEHOUSEHOLDINCOME,
                        /// <summary>Target ads in a specific on screen position.</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_ON_SCREEN_POSITION")]
                        TARGETINGTYPEONSCREENPOSITION,
                        /// <summary>Filter web sites through third party verification (for example, IAS or
                        /// DoubleVerify).</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_THIRD_PARTY_VERIFIER")]
                        TARGETINGTYPETHIRDPARTYVERIFIER,
                        /// <summary>Filter web sites by specific digital content label ratings (for example, DL-MA:
                        /// suitable only for mature audiences).</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_DIGITAL_CONTENT_LABEL_EXCLUSION")]
                        TARGETINGTYPEDIGITALCONTENTLABELEXCLUSION,
                        /// <summary>Filter website content by sensitive categories (for example, adult).</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_SENSITIVE_CATEGORY_EXCLUSION")]
                        TARGETINGTYPESENSITIVECATEGORYEXCLUSION,
                        /// <summary>Target ads to a specific environment (for example, web or app).</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_ENVIRONMENT")]
                        TARGETINGTYPEENVIRONMENT,
                        /// <summary>Target ads to a specific network carrier or internet service provider (ISP) (for
                        /// example, Comcast or Orange).</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_CARRIER_AND_ISP")]
                        TARGETINGTYPECARRIERANDISP,
                        /// <summary>Target ads to a specific operating system (for example, macOS).</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_OPERATING_SYSTEM")]
                        TARGETINGTYPEOPERATINGSYSTEM,
                        /// <summary>Target ads to a specific device make or model (for example, Roku or
                        /// Samsung).</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_DEVICE_MAKE_MODEL")]
                        TARGETINGTYPEDEVICEMAKEMODEL,
                        /// <summary>Target ads to a specific keyword (for example, dog or retriever).</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_KEYWORD")]
                        TARGETINGTYPEKEYWORD,
                        /// <summary>Target ads to a specific negative keyword list.</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_NEGATIVE_KEYWORD_LIST")]
                        TARGETINGTYPENEGATIVEKEYWORDLIST,
                        /// <summary>Target ads to a specific viewability (for example, 80% viewable).</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_VIEWABILITY")]
                        TARGETINGTYPEVIEWABILITY,
                        /// <summary>Target ads to a specific content category (for example, arts &
                        /// entertainment).</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_CATEGORY")]
                        TARGETINGTYPECATEGORY,
                        /// <summary>Purchase impressions from specific deals and auction packages.</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_INVENTORY_SOURCE")]
                        TARGETINGTYPEINVENTORYSOURCE,
                        /// <summary>Target ads to a specific language (for example, English or Japanese).</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_LANGUAGE")]
                        TARGETINGTYPELANGUAGE,
                        /// <summary>Target ads to ads.txt authorized sellers.</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_AUTHORIZED_SELLER_STATUS")]
                        TARGETINGTYPEAUTHORIZEDSELLERSTATUS,
                        /// <summary>Target ads to a specific regional location (for example, a city or
                        /// state).</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_GEO_REGION")]
                        TARGETINGTYPEGEOREGION,
                        /// <summary>Purchase impressions from a group of deals and auction packages.</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_INVENTORY_SOURCE_GROUP")]
                        TARGETINGTYPEINVENTORYSOURCEGROUP,
                        /// <summary>Purchase impressions from specific exchanges.</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_EXCHANGE")]
                        TARGETINGTYPEEXCHANGE,
                        /// <summary>Purchase impressions from specific sub-exchanges.</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_SUB_EXCHANGE")]
                        TARGETINGTYPESUBEXCHANGE,
                    }

                    /// <summary>Required. The ID of the assigned targeting option to delete.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("assignedTargetingOptionId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string AssignedTargetingOptionId { get; private set; }


                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "delete";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "DELETE";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/partners/{+partnerId}/targetingTypes/{+targetingType}/assignedTargetingOptions/{+assignedTargetingOptionId}";

                    /// <summary>Initializes Delete parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();

                        RequestParameters.Add("partnerId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "partnerId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^[^/]+$",
                        });
                        RequestParameters.Add("targetingType", new Google.Apis.Discovery.Parameter
                        {
                            Name = "targetingType",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^[^/]+$",
                        });
                        RequestParameters.Add("assignedTargetingOptionId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "assignedTargetingOptionId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^[^/]+$",
                        });
                    }

                }

                /// <summary>Gets a single targeting option assigned to a partner.</summary>
                /// <param name="partnerId">Required. The ID of the partner.</param>
                /// <param name="targetingType">Required.
                /// Identifies the type of this assigned targeting option. Supported targeting types: *
                /// `TARGETING_TYPE_CHANNEL`</param>
                /// <param name="assignedTargetingOptionId">Required. An identifier unique to
                /// the targeting type in this partner that identifies the assigned targeting option being requested.</param>
                public virtual GetRequest Get(long partnerId, GetRequest.TargetingTypeEnum targetingType, string assignedTargetingOptionId)
                {
                    return new GetRequest(service, partnerId, targetingType, assignedTargetingOptionId);
                }

                /// <summary>Gets a single targeting option assigned to a partner.</summary>
                public class GetRequest : DisplayVideoBaseServiceRequest<Google.Apis.DisplayVideo.v1.Data.AssignedTargetingOption>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, long partnerId, GetRequest.TargetingTypeEnum targetingType, string assignedTargetingOptionId) : base(service)
                    {
                        PartnerId = partnerId;
                        TargetingType = targetingType;
                        AssignedTargetingOptionId = assignedTargetingOptionId;
                        InitParameters();
                    }


                    /// <summary>Required. The ID of the partner.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("partnerId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual long PartnerId { get; private set; }

                    /// <summary>Required. Identifies the type of this assigned targeting option. Supported targeting
                    /// types: * `TARGETING_TYPE_CHANNEL`</summary>
                    [Google.Apis.Util.RequestParameterAttribute("targetingType", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual TargetingTypeEnum TargetingType { get; private set; }

                    /// <summary>Required. Identifies the type of this assigned targeting option. Supported targeting
                    /// types: * `TARGETING_TYPE_CHANNEL`</summary>
                    public enum TargetingTypeEnum
                    {
                        /// <summary>Default value when type is not specified or is unknown in this version.</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_UNSPECIFIED")]
                        TARGETINGTYPEUNSPECIFIED,
                        /// <summary>Target a channel (a custom group of related websites or apps).</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_CHANNEL")]
                        TARGETINGTYPECHANNEL,
                        /// <summary>Target an app category (for example, education or puzzle games).</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_APP_CATEGORY")]
                        TARGETINGTYPEAPPCATEGORY,
                        /// <summary>Target a specific app (for example, Angry Birds).</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_APP")]
                        TARGETINGTYPEAPP,
                        /// <summary>Target a specific url (for example, quora.com).</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_URL")]
                        TARGETINGTYPEURL,
                        /// <summary>Target ads during a chosen time period on a specific day.</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_DAY_AND_TIME")]
                        TARGETINGTYPEDAYANDTIME,
                        /// <summary>Target ads to a specific age range (for example, 18-24).</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_AGE_RANGE")]
                        TARGETINGTYPEAGERANGE,
                        /// <summary>Target ads to the specified regions on a regional location list.</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_REGIONAL_LOCATION_LIST")]
                        TARGETINGTYPEREGIONALLOCATIONLIST,
                        /// <summary>Target ads to the specified points of interest on a proximity location
                        /// list.</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_PROXIMITY_LOCATION_LIST")]
                        TARGETINGTYPEPROXIMITYLOCATIONLIST,
                        /// <summary>Target ads to a specific gender (for example, female or male).</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_GENDER")]
                        TARGETINGTYPEGENDER,
                        /// <summary>Target a specific video player size for video ads.</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_VIDEO_PLAYER_SIZE")]
                        TARGETINGTYPEVIDEOPLAYERSIZE,
                        /// <summary>Target user rewarded content for video ads.</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_USER_REWARDED_CONTENT")]
                        TARGETINGTYPEUSERREWARDEDCONTENT,
                        /// <summary>Target ads to a specific parental status (for example, parent or not a
                        /// parent).</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_PARENTAL_STATUS")]
                        TARGETINGTYPEPARENTALSTATUS,
                        /// <summary>Target video or audio ads in a specific content instream position (for example,
                        /// pre-roll, mid-roll, or post-roll).</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_CONTENT_INSTREAM_POSITION")]
                        TARGETINGTYPECONTENTINSTREAMPOSITION,
                        /// <summary>Target ads in a specific content outstream position.</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_CONTENT_OUTSTREAM_POSITION")]
                        TARGETINGTYPECONTENTOUTSTREAMPOSITION,
                        /// <summary>Target ads to a specific device type (for example, tablet or connected
                        /// TV).</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_DEVICE_TYPE")]
                        TARGETINGTYPEDEVICETYPE,
                        /// <summary>Target ads to an audience or groups of audiences. Singleton field, at most one can
                        /// exist on a single Lineitem at a time.</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_AUDIENCE_GROUP")]
                        TARGETINGTYPEAUDIENCEGROUP,
                        /// <summary>Target ads to specific web browsers (for example, Chrome).</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_BROWSER")]
                        TARGETINGTYPEBROWSER,
                        /// <summary>Target ads to a specific household income range (for example, top 10%).</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_HOUSEHOLD_INCOME")]
                        TARGETINGTYPEHOUSEHOLDINCOME,
                        /// <summary>Target ads in a specific on screen position.</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_ON_SCREEN_POSITION")]
                        TARGETINGTYPEONSCREENPOSITION,
                        /// <summary>Filter web sites through third party verification (for example, IAS or
                        /// DoubleVerify).</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_THIRD_PARTY_VERIFIER")]
                        TARGETINGTYPETHIRDPARTYVERIFIER,
                        /// <summary>Filter web sites by specific digital content label ratings (for example, DL-MA:
                        /// suitable only for mature audiences).</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_DIGITAL_CONTENT_LABEL_EXCLUSION")]
                        TARGETINGTYPEDIGITALCONTENTLABELEXCLUSION,
                        /// <summary>Filter website content by sensitive categories (for example, adult).</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_SENSITIVE_CATEGORY_EXCLUSION")]
                        TARGETINGTYPESENSITIVECATEGORYEXCLUSION,
                        /// <summary>Target ads to a specific environment (for example, web or app).</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_ENVIRONMENT")]
                        TARGETINGTYPEENVIRONMENT,
                        /// <summary>Target ads to a specific network carrier or internet service provider (ISP) (for
                        /// example, Comcast or Orange).</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_CARRIER_AND_ISP")]
                        TARGETINGTYPECARRIERANDISP,
                        /// <summary>Target ads to a specific operating system (for example, macOS).</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_OPERATING_SYSTEM")]
                        TARGETINGTYPEOPERATINGSYSTEM,
                        /// <summary>Target ads to a specific device make or model (for example, Roku or
                        /// Samsung).</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_DEVICE_MAKE_MODEL")]
                        TARGETINGTYPEDEVICEMAKEMODEL,
                        /// <summary>Target ads to a specific keyword (for example, dog or retriever).</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_KEYWORD")]
                        TARGETINGTYPEKEYWORD,
                        /// <summary>Target ads to a specific negative keyword list.</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_NEGATIVE_KEYWORD_LIST")]
                        TARGETINGTYPENEGATIVEKEYWORDLIST,
                        /// <summary>Target ads to a specific viewability (for example, 80% viewable).</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_VIEWABILITY")]
                        TARGETINGTYPEVIEWABILITY,
                        /// <summary>Target ads to a specific content category (for example, arts &
                        /// entertainment).</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_CATEGORY")]
                        TARGETINGTYPECATEGORY,
                        /// <summary>Purchase impressions from specific deals and auction packages.</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_INVENTORY_SOURCE")]
                        TARGETINGTYPEINVENTORYSOURCE,
                        /// <summary>Target ads to a specific language (for example, English or Japanese).</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_LANGUAGE")]
                        TARGETINGTYPELANGUAGE,
                        /// <summary>Target ads to ads.txt authorized sellers.</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_AUTHORIZED_SELLER_STATUS")]
                        TARGETINGTYPEAUTHORIZEDSELLERSTATUS,
                        /// <summary>Target ads to a specific regional location (for example, a city or
                        /// state).</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_GEO_REGION")]
                        TARGETINGTYPEGEOREGION,
                        /// <summary>Purchase impressions from a group of deals and auction packages.</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_INVENTORY_SOURCE_GROUP")]
                        TARGETINGTYPEINVENTORYSOURCEGROUP,
                        /// <summary>Purchase impressions from specific exchanges.</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_EXCHANGE")]
                        TARGETINGTYPEEXCHANGE,
                        /// <summary>Purchase impressions from specific sub-exchanges.</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_SUB_EXCHANGE")]
                        TARGETINGTYPESUBEXCHANGE,
                    }

                    /// <summary>Required. An identifier unique to the targeting type in this partner that identifies
                    /// the assigned targeting option being requested.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("assignedTargetingOptionId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string AssignedTargetingOptionId { get; private set; }


                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "get";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/partners/{+partnerId}/targetingTypes/{+targetingType}/assignedTargetingOptions/{+assignedTargetingOptionId}";

                    /// <summary>Initializes Get parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();

                        RequestParameters.Add("partnerId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "partnerId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^[^/]+$",
                        });
                        RequestParameters.Add("targetingType", new Google.Apis.Discovery.Parameter
                        {
                            Name = "targetingType",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^[^/]+$",
                        });
                        RequestParameters.Add("assignedTargetingOptionId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "assignedTargetingOptionId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^[^/]+$",
                        });
                    }

                }

                /// <summary>Lists the targeting options assigned to a partner.</summary>
                /// <param name="partnerId">Required. The ID of the partner.</param>
                /// <param name="targetingType">Required.
                /// Identifies the type of assigned targeting options to list. Supported targeting types: *
                /// `TARGETING_TYPE_CHANNEL`</param>
                public virtual ListRequest List(long partnerId, ListRequest.TargetingTypeEnum targetingType)
                {
                    return new ListRequest(service, partnerId, targetingType);
                }

                /// <summary>Lists the targeting options assigned to a partner.</summary>
                public class ListRequest : DisplayVideoBaseServiceRequest<Google.Apis.DisplayVideo.v1.Data.ListPartnerAssignedTargetingOptionsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, long partnerId, ListRequest.TargetingTypeEnum targetingType) : base(service)
                    {
                        PartnerId = partnerId;
                        TargetingType = targetingType;
                        InitParameters();
                    }


                    /// <summary>Required. The ID of the partner.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("partnerId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual long PartnerId { get; private set; }

                    /// <summary>Required. Identifies the type of assigned targeting options to list. Supported
                    /// targeting types: * `TARGETING_TYPE_CHANNEL`</summary>
                    [Google.Apis.Util.RequestParameterAttribute("targetingType", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual TargetingTypeEnum TargetingType { get; private set; }

                    /// <summary>Required. Identifies the type of assigned targeting options to list. Supported
                    /// targeting types: * `TARGETING_TYPE_CHANNEL`</summary>
                    public enum TargetingTypeEnum
                    {
                        /// <summary>Default value when type is not specified or is unknown in this version.</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_UNSPECIFIED")]
                        TARGETINGTYPEUNSPECIFIED,
                        /// <summary>Target a channel (a custom group of related websites or apps).</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_CHANNEL")]
                        TARGETINGTYPECHANNEL,
                        /// <summary>Target an app category (for example, education or puzzle games).</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_APP_CATEGORY")]
                        TARGETINGTYPEAPPCATEGORY,
                        /// <summary>Target a specific app (for example, Angry Birds).</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_APP")]
                        TARGETINGTYPEAPP,
                        /// <summary>Target a specific url (for example, quora.com).</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_URL")]
                        TARGETINGTYPEURL,
                        /// <summary>Target ads during a chosen time period on a specific day.</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_DAY_AND_TIME")]
                        TARGETINGTYPEDAYANDTIME,
                        /// <summary>Target ads to a specific age range (for example, 18-24).</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_AGE_RANGE")]
                        TARGETINGTYPEAGERANGE,
                        /// <summary>Target ads to the specified regions on a regional location list.</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_REGIONAL_LOCATION_LIST")]
                        TARGETINGTYPEREGIONALLOCATIONLIST,
                        /// <summary>Target ads to the specified points of interest on a proximity location
                        /// list.</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_PROXIMITY_LOCATION_LIST")]
                        TARGETINGTYPEPROXIMITYLOCATIONLIST,
                        /// <summary>Target ads to a specific gender (for example, female or male).</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_GENDER")]
                        TARGETINGTYPEGENDER,
                        /// <summary>Target a specific video player size for video ads.</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_VIDEO_PLAYER_SIZE")]
                        TARGETINGTYPEVIDEOPLAYERSIZE,
                        /// <summary>Target user rewarded content for video ads.</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_USER_REWARDED_CONTENT")]
                        TARGETINGTYPEUSERREWARDEDCONTENT,
                        /// <summary>Target ads to a specific parental status (for example, parent or not a
                        /// parent).</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_PARENTAL_STATUS")]
                        TARGETINGTYPEPARENTALSTATUS,
                        /// <summary>Target video or audio ads in a specific content instream position (for example,
                        /// pre-roll, mid-roll, or post-roll).</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_CONTENT_INSTREAM_POSITION")]
                        TARGETINGTYPECONTENTINSTREAMPOSITION,
                        /// <summary>Target ads in a specific content outstream position.</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_CONTENT_OUTSTREAM_POSITION")]
                        TARGETINGTYPECONTENTOUTSTREAMPOSITION,
                        /// <summary>Target ads to a specific device type (for example, tablet or connected
                        /// TV).</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_DEVICE_TYPE")]
                        TARGETINGTYPEDEVICETYPE,
                        /// <summary>Target ads to an audience or groups of audiences. Singleton field, at most one can
                        /// exist on a single Lineitem at a time.</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_AUDIENCE_GROUP")]
                        TARGETINGTYPEAUDIENCEGROUP,
                        /// <summary>Target ads to specific web browsers (for example, Chrome).</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_BROWSER")]
                        TARGETINGTYPEBROWSER,
                        /// <summary>Target ads to a specific household income range (for example, top 10%).</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_HOUSEHOLD_INCOME")]
                        TARGETINGTYPEHOUSEHOLDINCOME,
                        /// <summary>Target ads in a specific on screen position.</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_ON_SCREEN_POSITION")]
                        TARGETINGTYPEONSCREENPOSITION,
                        /// <summary>Filter web sites through third party verification (for example, IAS or
                        /// DoubleVerify).</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_THIRD_PARTY_VERIFIER")]
                        TARGETINGTYPETHIRDPARTYVERIFIER,
                        /// <summary>Filter web sites by specific digital content label ratings (for example, DL-MA:
                        /// suitable only for mature audiences).</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_DIGITAL_CONTENT_LABEL_EXCLUSION")]
                        TARGETINGTYPEDIGITALCONTENTLABELEXCLUSION,
                        /// <summary>Filter website content by sensitive categories (for example, adult).</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_SENSITIVE_CATEGORY_EXCLUSION")]
                        TARGETINGTYPESENSITIVECATEGORYEXCLUSION,
                        /// <summary>Target ads to a specific environment (for example, web or app).</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_ENVIRONMENT")]
                        TARGETINGTYPEENVIRONMENT,
                        /// <summary>Target ads to a specific network carrier or internet service provider (ISP) (for
                        /// example, Comcast or Orange).</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_CARRIER_AND_ISP")]
                        TARGETINGTYPECARRIERANDISP,
                        /// <summary>Target ads to a specific operating system (for example, macOS).</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_OPERATING_SYSTEM")]
                        TARGETINGTYPEOPERATINGSYSTEM,
                        /// <summary>Target ads to a specific device make or model (for example, Roku or
                        /// Samsung).</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_DEVICE_MAKE_MODEL")]
                        TARGETINGTYPEDEVICEMAKEMODEL,
                        /// <summary>Target ads to a specific keyword (for example, dog or retriever).</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_KEYWORD")]
                        TARGETINGTYPEKEYWORD,
                        /// <summary>Target ads to a specific negative keyword list.</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_NEGATIVE_KEYWORD_LIST")]
                        TARGETINGTYPENEGATIVEKEYWORDLIST,
                        /// <summary>Target ads to a specific viewability (for example, 80% viewable).</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_VIEWABILITY")]
                        TARGETINGTYPEVIEWABILITY,
                        /// <summary>Target ads to a specific content category (for example, arts &
                        /// entertainment).</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_CATEGORY")]
                        TARGETINGTYPECATEGORY,
                        /// <summary>Purchase impressions from specific deals and auction packages.</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_INVENTORY_SOURCE")]
                        TARGETINGTYPEINVENTORYSOURCE,
                        /// <summary>Target ads to a specific language (for example, English or Japanese).</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_LANGUAGE")]
                        TARGETINGTYPELANGUAGE,
                        /// <summary>Target ads to ads.txt authorized sellers.</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_AUTHORIZED_SELLER_STATUS")]
                        TARGETINGTYPEAUTHORIZEDSELLERSTATUS,
                        /// <summary>Target ads to a specific regional location (for example, a city or
                        /// state).</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_GEO_REGION")]
                        TARGETINGTYPEGEOREGION,
                        /// <summary>Purchase impressions from a group of deals and auction packages.</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_INVENTORY_SOURCE_GROUP")]
                        TARGETINGTYPEINVENTORYSOURCEGROUP,
                        /// <summary>Purchase impressions from specific exchanges.</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_EXCHANGE")]
                        TARGETINGTYPEEXCHANGE,
                        /// <summary>Purchase impressions from specific sub-exchanges.</summary>
                        [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_SUB_EXCHANGE")]
                        TARGETINGTYPESUBEXCHANGE,
                    }

                    /// <summary>Allows filtering by assigned targeting option properties. Supported syntax: * Filter
                    /// expressions are made up of one or more restrictions. * Restrictions can be combined by the
                    /// logical operator `OR`. * A restriction has the form of `{field} {operator} {value}`. * The
                    /// operator must be `EQUALS (=)`. * Supported fields: - `assignedTargetingOptionId` Examples: *
                    /// AssignedTargetingOption with ID 123456 `assignedTargetingOptionId="123456"` The length of this
                    /// field should be no more than 500 characters.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>Field by which to sort the list. Acceptable values are: * `assignedTargetingOptionId`
                    /// (default) The default sorting order is ascending. To specify descending order for a field, a
                    /// suffix "desc" should be added to the field name. Example: `assignedTargetingOptionId
                    /// desc`.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string OrderBy { get; set; }

                    /// <summary>Requested page size. Must be between `1` and `100`. If unspecified will default to
                    /// `100`. Returns error code `INVALID_ARGUMENT` if an invalid value is specified.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>A token identifying a page of results the server should return. Typically, this is the
                    /// value of next_page_token returned from the previous call to
                    /// `ListPartnerAssignedTargetingOptions` method. If not specified, the first page of results will
                    /// be returned.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }


                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/partners/{+partnerId}/targetingTypes/{+targetingType}/assignedTargetingOptions";

                    /// <summary>Initializes List parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();

                        RequestParameters.Add("partnerId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "partnerId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^[^/]+$",
                        });
                        RequestParameters.Add("targetingType", new Google.Apis.Discovery.Parameter
                        {
                            Name = "targetingType",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^[^/]+$",
                        });
                        RequestParameters.Add("filter", new Google.Apis.Discovery.Parameter
                        {
                            Name = "filter",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
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
                        RequestParameters.Add("pageSize", new Google.Apis.Discovery.Parameter
                        {
                            Name = "pageSize",
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
            }
        }

        /// <summary>Bulk edits targeting options under a single partner. The operation will delete the assigned
        /// targeting options provided in BulkEditPartnerAssignedTargetingOptionsRequest.deleteRequests and then create
        /// the assigned targeting options provided in BulkEditPartnerAssignedTargetingOptionsRequest.createRequests
        /// .</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="partnerId">Required. The ID of the partner.</param>
        public virtual BulkEditPartnerAssignedTargetingOptionsRequest BulkEditPartnerAssignedTargetingOptions(Google.Apis.DisplayVideo.v1.Data.BulkEditPartnerAssignedTargetingOptionsRequest body, long partnerId)
        {
            return new BulkEditPartnerAssignedTargetingOptionsRequest(service, body, partnerId);
        }

        /// <summary>Bulk edits targeting options under a single partner. The operation will delete the assigned
        /// targeting options provided in BulkEditPartnerAssignedTargetingOptionsRequest.deleteRequests and then create
        /// the assigned targeting options provided in BulkEditPartnerAssignedTargetingOptionsRequest.createRequests
        /// .</summary>
        public class BulkEditPartnerAssignedTargetingOptionsRequest : DisplayVideoBaseServiceRequest<Google.Apis.DisplayVideo.v1.Data.BulkEditPartnerAssignedTargetingOptionsResponse>
        {
            /// <summary>Constructs a new BulkEditPartnerAssignedTargetingOptions request.</summary>
            public BulkEditPartnerAssignedTargetingOptionsRequest(Google.Apis.Services.IClientService service, Google.Apis.DisplayVideo.v1.Data.BulkEditPartnerAssignedTargetingOptionsRequest body, long partnerId) : base(service)
            {
                PartnerId = partnerId;
                Body = body;
                InitParameters();
            }


            /// <summary>Required. The ID of the partner.</summary>
            [Google.Apis.Util.RequestParameterAttribute("partnerId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual long PartnerId { get; private set; }


            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.DisplayVideo.v1.Data.BulkEditPartnerAssignedTargetingOptionsRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "bulkEditPartnerAssignedTargetingOptions";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/partners/{+partnerId}:bulkEditPartnerAssignedTargetingOptions";

            /// <summary>Initializes BulkEditPartnerAssignedTargetingOptions parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add("partnerId", new Google.Apis.Discovery.Parameter
                {
                    Name = "partnerId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^[^/]+$",
                });
            }

        }

        /// <summary>Gets a partner.</summary>
        /// <param name="partnerId">Required. The ID of the partner to fetch.</param>
        public virtual GetRequest Get(long partnerId)
        {
            return new GetRequest(service, partnerId);
        }

        /// <summary>Gets a partner.</summary>
        public class GetRequest : DisplayVideoBaseServiceRequest<Google.Apis.DisplayVideo.v1.Data.Partner>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, long partnerId) : base(service)
            {
                PartnerId = partnerId;
                InitParameters();
            }


            /// <summary>Required. The ID of the partner to fetch.</summary>
            [Google.Apis.Util.RequestParameterAttribute("partnerId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual long PartnerId { get; private set; }


            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/partners/{+partnerId}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add("partnerId", new Google.Apis.Discovery.Parameter
                {
                    Name = "partnerId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^[^/]+$",
                });
            }

        }

        /// <summary>Lists partners that are accessible to the current user. The order is defined by the order_by
        /// parameter.</summary>
        public virtual ListRequest List()
        {
            return new ListRequest(service);
        }

        /// <summary>Lists partners that are accessible to the current user. The order is defined by the order_by
        /// parameter.</summary>
        public class ListRequest : DisplayVideoBaseServiceRequest<Google.Apis.DisplayVideo.v1.Data.ListPartnersResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }


            /// <summary>Allows filtering by partner properties. Supported syntax: * Filter expressions are made up of
            /// one or more restrictions. * Restrictions can be combined by `AND` or `OR` logical operators. A sequence
            /// of restrictions implicitly uses `AND`. * A restriction has the form of `{field} {operator} {value}`. *
            /// The operator must be `EQUALS (=)`. * Supported fields: - `entityStatus` Examples: * All active partners:
            /// `entityStatus="ENTITY_STATUS_ACTIVE"` The length of this field should be no more than 500
            /// characters.</summary>
            [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Filter { get; set; }

            /// <summary>Field by which to sort the list. Acceptable values are: * `displayName` The default sorting
            /// order is ascending. To specify descending order for a field, a suffix "desc" should be added to the
            /// field name. For example, `displayName desc`.</summary>
            [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string OrderBy { get; set; }

            /// <summary>Requested page size. Must be between `1` and `100`. If unspecified will default to
            /// `100`.</summary>
            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> PageSize { get; set; }

            /// <summary>A token identifying a page of results the server should return. Typically, this is the value of
            /// next_page_token returned from the previous call to `ListPartners` method. If not specified, the first
            /// page of results will be returned.</summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }


            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/partners";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add("filter", new Google.Apis.Discovery.Parameter
                {
                    Name = "filter",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
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
                RequestParameters.Add("pageSize", new Google.Apis.Discovery.Parameter
                {
                    Name = "pageSize",
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
    }

    /// <summary>The "sdfdownloadtasks" collection of methods.</summary>
    public class SdfdownloadtasksResource
    {
        private const string Resource = "sdfdownloadtasks";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public SdfdownloadtasksResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
            Operations = new OperationsResource(service);

        }

        /// <summary>Gets the Operations resource.</summary>
        public virtual OperationsResource Operations { get; }

        /// <summary>The "operations" collection of methods.</summary>
        public class OperationsResource
        {
            private const string Resource = "operations";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public OperationsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;

            }


            /// <summary>Gets the latest state of an asynchronous SDF download task operation. Clients should poll this
            /// method at intervals of 30 seconds.</summary>
            /// <param name="name">The name of the operation resource.</param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(service, name);
            }

            /// <summary>Gets the latest state of an asynchronous SDF download task operation. Clients should poll this
            /// method at intervals of 30 seconds.</summary>
            public class GetRequest : DisplayVideoBaseServiceRequest<Google.Apis.DisplayVideo.v1.Data.Operation>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }


                /// <summary>The name of the operation resource.</summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }


                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+name}";

                /// <summary>Initializes Get parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();

                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^sdfdownloadtasks/operations/[^/]+$",
                    });
                }

            }
        }

        /// <summary>Creates an SDF Download Task. Returns an Operation. An SDF Download Task is a long-running,
        /// asynchronous operation. The metadata type of this operation is SdfDownloadTaskMetadata. If the request is
        /// successful, the response type of the operation is SdfDownloadTask. The response will not include the
        /// download files, which must be retrieved with media.download. The state of operation can be retrieved with
        /// sdfdownloadtask.operations.get. Any errors can be found in the error.message. Note that error.details is
        /// expected to be empty.</summary>
        /// <param name="body">The body of the request.</param>
        public virtual CreateRequest Create(Google.Apis.DisplayVideo.v1.Data.CreateSdfDownloadTaskRequest body)
        {
            return new CreateRequest(service, body);
        }

        /// <summary>Creates an SDF Download Task. Returns an Operation. An SDF Download Task is a long-running,
        /// asynchronous operation. The metadata type of this operation is SdfDownloadTaskMetadata. If the request is
        /// successful, the response type of the operation is SdfDownloadTask. The response will not include the
        /// download files, which must be retrieved with media.download. The state of operation can be retrieved with
        /// sdfdownloadtask.operations.get. Any errors can be found in the error.message. Note that error.details is
        /// expected to be empty.</summary>
        public class CreateRequest : DisplayVideoBaseServiceRequest<Google.Apis.DisplayVideo.v1.Data.Operation>
        {
            /// <summary>Constructs a new Create request.</summary>
            public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.DisplayVideo.v1.Data.CreateSdfDownloadTaskRequest body) : base(service)
            {
                Body = body;
                InitParameters();
            }



            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.DisplayVideo.v1.Data.CreateSdfDownloadTaskRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "create";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/sdfdownloadtasks";

            /// <summary>Initializes Create parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

            }

        }
    }

    /// <summary>The "targetingTypes" collection of methods.</summary>
    public class TargetingTypesResource
    {
        private const string Resource = "targetingTypes";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public TargetingTypesResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
            TargetingOptions = new TargetingOptionsResource(service);

        }

        /// <summary>Gets the TargetingOptions resource.</summary>
        public virtual TargetingOptionsResource TargetingOptions { get; }

        /// <summary>The "targetingOptions" collection of methods.</summary>
        public class TargetingOptionsResource
        {
            private const string Resource = "targetingOptions";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public TargetingOptionsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;

            }


            /// <summary>Gets a single targeting option.</summary>
            /// <param name="targetingType">Required. The type of targeting option to retrieve.</param>
            /// <param
            /// name="targetingOptionId">Required. The ID of the of targeting option to retrieve.</param>
            public virtual GetRequest Get(GetRequest.TargetingTypeEnum targetingType, string targetingOptionId)
            {
                return new GetRequest(service, targetingType, targetingOptionId);
            }

            /// <summary>Gets a single targeting option.</summary>
            public class GetRequest : DisplayVideoBaseServiceRequest<Google.Apis.DisplayVideo.v1.Data.TargetingOption>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, GetRequest.TargetingTypeEnum targetingType, string targetingOptionId) : base(service)
                {
                    TargetingType = targetingType;
                    TargetingOptionId = targetingOptionId;
                    InitParameters();
                }


                /// <summary>Required. The type of targeting option to retrieve.</summary>
                [Google.Apis.Util.RequestParameterAttribute("targetingType", Google.Apis.Util.RequestParameterType.Path)]
                public virtual TargetingTypeEnum TargetingType { get; private set; }

                /// <summary>Required. The type of targeting option to retrieve.</summary>
                public enum TargetingTypeEnum
                {
                    /// <summary>Default value when type is not specified or is unknown in this version.</summary>
                    [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_UNSPECIFIED")]
                    TARGETINGTYPEUNSPECIFIED,
                    /// <summary>Target a channel (a custom group of related websites or apps).</summary>
                    [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_CHANNEL")]
                    TARGETINGTYPECHANNEL,
                    /// <summary>Target an app category (for example, education or puzzle games).</summary>
                    [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_APP_CATEGORY")]
                    TARGETINGTYPEAPPCATEGORY,
                    /// <summary>Target a specific app (for example, Angry Birds).</summary>
                    [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_APP")]
                    TARGETINGTYPEAPP,
                    /// <summary>Target a specific url (for example, quora.com).</summary>
                    [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_URL")]
                    TARGETINGTYPEURL,
                    /// <summary>Target ads during a chosen time period on a specific day.</summary>
                    [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_DAY_AND_TIME")]
                    TARGETINGTYPEDAYANDTIME,
                    /// <summary>Target ads to a specific age range (for example, 18-24).</summary>
                    [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_AGE_RANGE")]
                    TARGETINGTYPEAGERANGE,
                    /// <summary>Target ads to the specified regions on a regional location list.</summary>
                    [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_REGIONAL_LOCATION_LIST")]
                    TARGETINGTYPEREGIONALLOCATIONLIST,
                    /// <summary>Target ads to the specified points of interest on a proximity location list.</summary>
                    [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_PROXIMITY_LOCATION_LIST")]
                    TARGETINGTYPEPROXIMITYLOCATIONLIST,
                    /// <summary>Target ads to a specific gender (for example, female or male).</summary>
                    [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_GENDER")]
                    TARGETINGTYPEGENDER,
                    /// <summary>Target a specific video player size for video ads.</summary>
                    [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_VIDEO_PLAYER_SIZE")]
                    TARGETINGTYPEVIDEOPLAYERSIZE,
                    /// <summary>Target user rewarded content for video ads.</summary>
                    [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_USER_REWARDED_CONTENT")]
                    TARGETINGTYPEUSERREWARDEDCONTENT,
                    /// <summary>Target ads to a specific parental status (for example, parent or not a
                    /// parent).</summary>
                    [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_PARENTAL_STATUS")]
                    TARGETINGTYPEPARENTALSTATUS,
                    /// <summary>Target video or audio ads in a specific content instream position (for example, pre-
                    /// roll, mid-roll, or post-roll).</summary>
                    [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_CONTENT_INSTREAM_POSITION")]
                    TARGETINGTYPECONTENTINSTREAMPOSITION,
                    /// <summary>Target ads in a specific content outstream position.</summary>
                    [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_CONTENT_OUTSTREAM_POSITION")]
                    TARGETINGTYPECONTENTOUTSTREAMPOSITION,
                    /// <summary>Target ads to a specific device type (for example, tablet or connected TV).</summary>
                    [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_DEVICE_TYPE")]
                    TARGETINGTYPEDEVICETYPE,
                    /// <summary>Target ads to an audience or groups of audiences. Singleton field, at most one can
                    /// exist on a single Lineitem at a time.</summary>
                    [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_AUDIENCE_GROUP")]
                    TARGETINGTYPEAUDIENCEGROUP,
                    /// <summary>Target ads to specific web browsers (for example, Chrome).</summary>
                    [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_BROWSER")]
                    TARGETINGTYPEBROWSER,
                    /// <summary>Target ads to a specific household income range (for example, top 10%).</summary>
                    [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_HOUSEHOLD_INCOME")]
                    TARGETINGTYPEHOUSEHOLDINCOME,
                    /// <summary>Target ads in a specific on screen position.</summary>
                    [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_ON_SCREEN_POSITION")]
                    TARGETINGTYPEONSCREENPOSITION,
                    /// <summary>Filter web sites through third party verification (for example, IAS or
                    /// DoubleVerify).</summary>
                    [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_THIRD_PARTY_VERIFIER")]
                    TARGETINGTYPETHIRDPARTYVERIFIER,
                    /// <summary>Filter web sites by specific digital content label ratings (for example, DL-MA:
                    /// suitable only for mature audiences).</summary>
                    [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_DIGITAL_CONTENT_LABEL_EXCLUSION")]
                    TARGETINGTYPEDIGITALCONTENTLABELEXCLUSION,
                    /// <summary>Filter website content by sensitive categories (for example, adult).</summary>
                    [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_SENSITIVE_CATEGORY_EXCLUSION")]
                    TARGETINGTYPESENSITIVECATEGORYEXCLUSION,
                    /// <summary>Target ads to a specific environment (for example, web or app).</summary>
                    [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_ENVIRONMENT")]
                    TARGETINGTYPEENVIRONMENT,
                    /// <summary>Target ads to a specific network carrier or internet service provider (ISP) (for
                    /// example, Comcast or Orange).</summary>
                    [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_CARRIER_AND_ISP")]
                    TARGETINGTYPECARRIERANDISP,
                    /// <summary>Target ads to a specific operating system (for example, macOS).</summary>
                    [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_OPERATING_SYSTEM")]
                    TARGETINGTYPEOPERATINGSYSTEM,
                    /// <summary>Target ads to a specific device make or model (for example, Roku or Samsung).</summary>
                    [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_DEVICE_MAKE_MODEL")]
                    TARGETINGTYPEDEVICEMAKEMODEL,
                    /// <summary>Target ads to a specific keyword (for example, dog or retriever).</summary>
                    [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_KEYWORD")]
                    TARGETINGTYPEKEYWORD,
                    /// <summary>Target ads to a specific negative keyword list.</summary>
                    [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_NEGATIVE_KEYWORD_LIST")]
                    TARGETINGTYPENEGATIVEKEYWORDLIST,
                    /// <summary>Target ads to a specific viewability (for example, 80% viewable).</summary>
                    [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_VIEWABILITY")]
                    TARGETINGTYPEVIEWABILITY,
                    /// <summary>Target ads to a specific content category (for example, arts &
                    /// entertainment).</summary>
                    [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_CATEGORY")]
                    TARGETINGTYPECATEGORY,
                    /// <summary>Purchase impressions from specific deals and auction packages.</summary>
                    [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_INVENTORY_SOURCE")]
                    TARGETINGTYPEINVENTORYSOURCE,
                    /// <summary>Target ads to a specific language (for example, English or Japanese).</summary>
                    [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_LANGUAGE")]
                    TARGETINGTYPELANGUAGE,
                    /// <summary>Target ads to ads.txt authorized sellers.</summary>
                    [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_AUTHORIZED_SELLER_STATUS")]
                    TARGETINGTYPEAUTHORIZEDSELLERSTATUS,
                    /// <summary>Target ads to a specific regional location (for example, a city or state).</summary>
                    [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_GEO_REGION")]
                    TARGETINGTYPEGEOREGION,
                    /// <summary>Purchase impressions from a group of deals and auction packages.</summary>
                    [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_INVENTORY_SOURCE_GROUP")]
                    TARGETINGTYPEINVENTORYSOURCEGROUP,
                    /// <summary>Purchase impressions from specific exchanges.</summary>
                    [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_EXCHANGE")]
                    TARGETINGTYPEEXCHANGE,
                    /// <summary>Purchase impressions from specific sub-exchanges.</summary>
                    [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_SUB_EXCHANGE")]
                    TARGETINGTYPESUBEXCHANGE,
                }

                /// <summary>Required. The ID of the of targeting option to retrieve.</summary>
                [Google.Apis.Util.RequestParameterAttribute("targetingOptionId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string TargetingOptionId { get; private set; }

                /// <summary>Required. The Advertiser this request is being made in the context of.</summary>
                [Google.Apis.Util.RequestParameterAttribute("advertiserId", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<long> AdvertiserId { get; set; }


                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/targetingTypes/{+targetingType}/targetingOptions/{+targetingOptionId}";

                /// <summary>Initializes Get parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();

                    RequestParameters.Add("targetingType", new Google.Apis.Discovery.Parameter
                    {
                        Name = "targetingType",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^[^/]+$",
                    });
                    RequestParameters.Add("targetingOptionId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "targetingOptionId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^[^/]+$",
                    });
                    RequestParameters.Add("advertiserId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "advertiserId",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }

            }

            /// <summary>Lists targeting options of a given type.</summary>
            /// <param name="targetingType">Required. The type of targeting option to be listed.</param>
            public virtual ListRequest List(ListRequest.TargetingTypeEnum targetingType)
            {
                return new ListRequest(service, targetingType);
            }

            /// <summary>Lists targeting options of a given type.</summary>
            public class ListRequest : DisplayVideoBaseServiceRequest<Google.Apis.DisplayVideo.v1.Data.ListTargetingOptionsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, ListRequest.TargetingTypeEnum targetingType) : base(service)
                {
                    TargetingType = targetingType;
                    InitParameters();
                }


                /// <summary>Required. The type of targeting option to be listed.</summary>
                [Google.Apis.Util.RequestParameterAttribute("targetingType", Google.Apis.Util.RequestParameterType.Path)]
                public virtual TargetingTypeEnum TargetingType { get; private set; }

                /// <summary>Required. The type of targeting option to be listed.</summary>
                public enum TargetingTypeEnum
                {
                    /// <summary>Default value when type is not specified or is unknown in this version.</summary>
                    [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_UNSPECIFIED")]
                    TARGETINGTYPEUNSPECIFIED,
                    /// <summary>Target a channel (a custom group of related websites or apps).</summary>
                    [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_CHANNEL")]
                    TARGETINGTYPECHANNEL,
                    /// <summary>Target an app category (for example, education or puzzle games).</summary>
                    [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_APP_CATEGORY")]
                    TARGETINGTYPEAPPCATEGORY,
                    /// <summary>Target a specific app (for example, Angry Birds).</summary>
                    [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_APP")]
                    TARGETINGTYPEAPP,
                    /// <summary>Target a specific url (for example, quora.com).</summary>
                    [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_URL")]
                    TARGETINGTYPEURL,
                    /// <summary>Target ads during a chosen time period on a specific day.</summary>
                    [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_DAY_AND_TIME")]
                    TARGETINGTYPEDAYANDTIME,
                    /// <summary>Target ads to a specific age range (for example, 18-24).</summary>
                    [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_AGE_RANGE")]
                    TARGETINGTYPEAGERANGE,
                    /// <summary>Target ads to the specified regions on a regional location list.</summary>
                    [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_REGIONAL_LOCATION_LIST")]
                    TARGETINGTYPEREGIONALLOCATIONLIST,
                    /// <summary>Target ads to the specified points of interest on a proximity location list.</summary>
                    [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_PROXIMITY_LOCATION_LIST")]
                    TARGETINGTYPEPROXIMITYLOCATIONLIST,
                    /// <summary>Target ads to a specific gender (for example, female or male).</summary>
                    [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_GENDER")]
                    TARGETINGTYPEGENDER,
                    /// <summary>Target a specific video player size for video ads.</summary>
                    [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_VIDEO_PLAYER_SIZE")]
                    TARGETINGTYPEVIDEOPLAYERSIZE,
                    /// <summary>Target user rewarded content for video ads.</summary>
                    [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_USER_REWARDED_CONTENT")]
                    TARGETINGTYPEUSERREWARDEDCONTENT,
                    /// <summary>Target ads to a specific parental status (for example, parent or not a
                    /// parent).</summary>
                    [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_PARENTAL_STATUS")]
                    TARGETINGTYPEPARENTALSTATUS,
                    /// <summary>Target video or audio ads in a specific content instream position (for example, pre-
                    /// roll, mid-roll, or post-roll).</summary>
                    [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_CONTENT_INSTREAM_POSITION")]
                    TARGETINGTYPECONTENTINSTREAMPOSITION,
                    /// <summary>Target ads in a specific content outstream position.</summary>
                    [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_CONTENT_OUTSTREAM_POSITION")]
                    TARGETINGTYPECONTENTOUTSTREAMPOSITION,
                    /// <summary>Target ads to a specific device type (for example, tablet or connected TV).</summary>
                    [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_DEVICE_TYPE")]
                    TARGETINGTYPEDEVICETYPE,
                    /// <summary>Target ads to an audience or groups of audiences. Singleton field, at most one can
                    /// exist on a single Lineitem at a time.</summary>
                    [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_AUDIENCE_GROUP")]
                    TARGETINGTYPEAUDIENCEGROUP,
                    /// <summary>Target ads to specific web browsers (for example, Chrome).</summary>
                    [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_BROWSER")]
                    TARGETINGTYPEBROWSER,
                    /// <summary>Target ads to a specific household income range (for example, top 10%).</summary>
                    [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_HOUSEHOLD_INCOME")]
                    TARGETINGTYPEHOUSEHOLDINCOME,
                    /// <summary>Target ads in a specific on screen position.</summary>
                    [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_ON_SCREEN_POSITION")]
                    TARGETINGTYPEONSCREENPOSITION,
                    /// <summary>Filter web sites through third party verification (for example, IAS or
                    /// DoubleVerify).</summary>
                    [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_THIRD_PARTY_VERIFIER")]
                    TARGETINGTYPETHIRDPARTYVERIFIER,
                    /// <summary>Filter web sites by specific digital content label ratings (for example, DL-MA:
                    /// suitable only for mature audiences).</summary>
                    [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_DIGITAL_CONTENT_LABEL_EXCLUSION")]
                    TARGETINGTYPEDIGITALCONTENTLABELEXCLUSION,
                    /// <summary>Filter website content by sensitive categories (for example, adult).</summary>
                    [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_SENSITIVE_CATEGORY_EXCLUSION")]
                    TARGETINGTYPESENSITIVECATEGORYEXCLUSION,
                    /// <summary>Target ads to a specific environment (for example, web or app).</summary>
                    [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_ENVIRONMENT")]
                    TARGETINGTYPEENVIRONMENT,
                    /// <summary>Target ads to a specific network carrier or internet service provider (ISP) (for
                    /// example, Comcast or Orange).</summary>
                    [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_CARRIER_AND_ISP")]
                    TARGETINGTYPECARRIERANDISP,
                    /// <summary>Target ads to a specific operating system (for example, macOS).</summary>
                    [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_OPERATING_SYSTEM")]
                    TARGETINGTYPEOPERATINGSYSTEM,
                    /// <summary>Target ads to a specific device make or model (for example, Roku or Samsung).</summary>
                    [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_DEVICE_MAKE_MODEL")]
                    TARGETINGTYPEDEVICEMAKEMODEL,
                    /// <summary>Target ads to a specific keyword (for example, dog or retriever).</summary>
                    [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_KEYWORD")]
                    TARGETINGTYPEKEYWORD,
                    /// <summary>Target ads to a specific negative keyword list.</summary>
                    [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_NEGATIVE_KEYWORD_LIST")]
                    TARGETINGTYPENEGATIVEKEYWORDLIST,
                    /// <summary>Target ads to a specific viewability (for example, 80% viewable).</summary>
                    [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_VIEWABILITY")]
                    TARGETINGTYPEVIEWABILITY,
                    /// <summary>Target ads to a specific content category (for example, arts &
                    /// entertainment).</summary>
                    [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_CATEGORY")]
                    TARGETINGTYPECATEGORY,
                    /// <summary>Purchase impressions from specific deals and auction packages.</summary>
                    [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_INVENTORY_SOURCE")]
                    TARGETINGTYPEINVENTORYSOURCE,
                    /// <summary>Target ads to a specific language (for example, English or Japanese).</summary>
                    [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_LANGUAGE")]
                    TARGETINGTYPELANGUAGE,
                    /// <summary>Target ads to ads.txt authorized sellers.</summary>
                    [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_AUTHORIZED_SELLER_STATUS")]
                    TARGETINGTYPEAUTHORIZEDSELLERSTATUS,
                    /// <summary>Target ads to a specific regional location (for example, a city or state).</summary>
                    [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_GEO_REGION")]
                    TARGETINGTYPEGEOREGION,
                    /// <summary>Purchase impressions from a group of deals and auction packages.</summary>
                    [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_INVENTORY_SOURCE_GROUP")]
                    TARGETINGTYPEINVENTORYSOURCEGROUP,
                    /// <summary>Purchase impressions from specific exchanges.</summary>
                    [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_EXCHANGE")]
                    TARGETINGTYPEEXCHANGE,
                    /// <summary>Purchase impressions from specific sub-exchanges.</summary>
                    [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_SUB_EXCHANGE")]
                    TARGETINGTYPESUBEXCHANGE,
                }

                /// <summary>Required. The Advertiser this request is being made in the context of.</summary>
                [Google.Apis.Util.RequestParameterAttribute("advertiserId", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<long> AdvertiserId { get; set; }

                /// <summary>Allows filtering by targeting option properties. Supported syntax: * Filter expressions are
                /// made up of one or more restrictions. * Restrictions can be combined by `OR` logical operators. * A
                /// restriction has the form of `{field} {operator} {value}`. * The operator must be "=" (equal sign). *
                /// Supported fields: - `carrier_and_isp_details.type` - `geo_region_details.geo_region_type` -
                /// `targetingOptionId` Examples: * All `GEO REGION` targeting options that belong to sub type
                /// `GEO_REGION_TYPE_COUNTRY` or `GEO_REGION_TYPE_STATE`:
                /// `geo_region_details.geo_region_type="GEO_REGION_TYPE_COUNTRY" OR
                /// geo_region_details.geo_region_type="GEO_REGION_TYPE_STATE"` * All `CARRIER AND ISP` targeting
                /// options that belong to sub type `CARRIER_AND_ISP_TYPE_CARRIER`:
                /// `carrier_and_isp_details.type="CARRIER_AND_ISP_TYPE_CARRIER"`. The length of this field should be no
                /// more than 500 characters.</summary>
                [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Filter { get; set; }

                /// <summary>Field by which to sort the list. Acceptable values are: * `targetingOptionId` (default) The
                /// default sorting order is ascending. To specify descending order for a field, a suffix "desc" should
                /// be added to the field name. Example: `targetingOptionId desc`.</summary>
                [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string OrderBy { get; set; }

                /// <summary>Requested page size. Must be between `1` and `100`. If unspecified will default to `100`.
                /// Returns error code `INVALID_ARGUMENT` if an invalid value is specified.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>A token identifying a page of results the server should return. Typically, this is the
                /// value of next_page_token returned from the previous call to `ListTargetingOptions` method. If not
                /// specified, the first page of results will be returned.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }


                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/targetingTypes/{+targetingType}/targetingOptions";

                /// <summary>Initializes List parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();

                    RequestParameters.Add("targetingType", new Google.Apis.Discovery.Parameter
                    {
                        Name = "targetingType",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^[^/]+$",
                    });
                    RequestParameters.Add("advertiserId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "advertiserId",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("filter", new Google.Apis.Discovery.Parameter
                    {
                        Name = "filter",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
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
                    RequestParameters.Add("pageSize", new Google.Apis.Discovery.Parameter
                    {
                        Name = "pageSize",
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
        }
    }

    /// <summary>The "users" collection of methods.</summary>
    public class UsersResource
    {
        private const string Resource = "users";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public UsersResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;

        }


        /// <summary>Bulk edits user roles for a user. The operation will delete the assigned user roles provided in
        /// BulkEditAssignedUserRolesRequest.deletedAssignedUserRoles and then assign the user roles provided in
        /// BulkEditAssignedUserRolesRequest.createdAssignedUserRoles.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="userId">Required. The ID of the user to which the assigned user roles belong.</param>
        public virtual BulkEditAssignedUserRolesRequest BulkEditAssignedUserRoles(Google.Apis.DisplayVideo.v1.Data.BulkEditAssignedUserRolesRequest body, long userId)
        {
            return new BulkEditAssignedUserRolesRequest(service, body, userId);
        }

        /// <summary>Bulk edits user roles for a user. The operation will delete the assigned user roles provided in
        /// BulkEditAssignedUserRolesRequest.deletedAssignedUserRoles and then assign the user roles provided in
        /// BulkEditAssignedUserRolesRequest.createdAssignedUserRoles.</summary>
        public class BulkEditAssignedUserRolesRequest : DisplayVideoBaseServiceRequest<Google.Apis.DisplayVideo.v1.Data.BulkEditAssignedUserRolesResponse>
        {
            /// <summary>Constructs a new BulkEditAssignedUserRoles request.</summary>
            public BulkEditAssignedUserRolesRequest(Google.Apis.Services.IClientService service, Google.Apis.DisplayVideo.v1.Data.BulkEditAssignedUserRolesRequest body, long userId) : base(service)
            {
                UserId = userId;
                Body = body;
                InitParameters();
            }


            /// <summary>Required. The ID of the user to which the assigned user roles belong.</summary>
            [Google.Apis.Util.RequestParameterAttribute("userId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual long UserId { get; private set; }


            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.DisplayVideo.v1.Data.BulkEditAssignedUserRolesRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "bulkEditAssignedUserRoles";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/users/{+userId}:bulkEditAssignedUserRoles";

            /// <summary>Initializes BulkEditAssignedUserRoles parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add("userId", new Google.Apis.Discovery.Parameter
                {
                    Name = "userId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^[^/]+$",
                });
            }

        }

        /// <summary>Creates a new user. Returns the newly created user if successful.</summary>
        /// <param name="body">The body of the request.</param>
        public virtual CreateRequest Create(Google.Apis.DisplayVideo.v1.Data.User body)
        {
            return new CreateRequest(service, body);
        }

        /// <summary>Creates a new user. Returns the newly created user if successful.</summary>
        public class CreateRequest : DisplayVideoBaseServiceRequest<Google.Apis.DisplayVideo.v1.Data.User>
        {
            /// <summary>Constructs a new Create request.</summary>
            public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.DisplayVideo.v1.Data.User body) : base(service)
            {
                Body = body;
                InitParameters();
            }



            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.DisplayVideo.v1.Data.User Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "create";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/users";

            /// <summary>Initializes Create parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

            }

        }

        /// <summary>Deletes a user.</summary>
        /// <param name="userId">Required. The ID of the user to delete.</param>
        public virtual DeleteRequest Delete(long userId)
        {
            return new DeleteRequest(service, userId);
        }

        /// <summary>Deletes a user.</summary>
        public class DeleteRequest : DisplayVideoBaseServiceRequest<Google.Apis.DisplayVideo.v1.Data.Empty>
        {
            /// <summary>Constructs a new Delete request.</summary>
            public DeleteRequest(Google.Apis.Services.IClientService service, long userId) : base(service)
            {
                UserId = userId;
                InitParameters();
            }


            /// <summary>Required. The ID of the user to delete.</summary>
            [Google.Apis.Util.RequestParameterAttribute("userId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual long UserId { get; private set; }


            /// <summary>Gets the method name.</summary>
            public override string MethodName => "delete";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "DELETE";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/users/{+userId}";

            /// <summary>Initializes Delete parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add("userId", new Google.Apis.Discovery.Parameter
                {
                    Name = "userId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^[^/]+$",
                });
            }

        }

        /// <summary>Gets a user.</summary>
        /// <param name="userId">Required. The ID of the user to fetch.</param>
        public virtual GetRequest Get(long userId)
        {
            return new GetRequest(service, userId);
        }

        /// <summary>Gets a user.</summary>
        public class GetRequest : DisplayVideoBaseServiceRequest<Google.Apis.DisplayVideo.v1.Data.User>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, long userId) : base(service)
            {
                UserId = userId;
                InitParameters();
            }


            /// <summary>Required. The ID of the user to fetch.</summary>
            [Google.Apis.Util.RequestParameterAttribute("userId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual long UserId { get; private set; }


            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/users/{+userId}";

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
                    Pattern = @"^[^/]+$",
                });
            }

        }

        /// <summary>Lists users that are accessible to the current user. If two users have user roles on the same
        /// partner or advertiser, they can access each other.</summary>
        public virtual ListRequest List()
        {
            return new ListRequest(service);
        }

        /// <summary>Lists users that are accessible to the current user. If two users have user roles on the same
        /// partner or advertiser, they can access each other.</summary>
        public class ListRequest : DisplayVideoBaseServiceRequest<Google.Apis.DisplayVideo.v1.Data.ListUsersResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }


            /// <summary>Allows filtering by user properties. Supported syntax: * Filter expressions are made up of one
            /// or more restrictions. * Restrictions can be combined by the logical operator `AND`. * A restriction has
            /// the form of `{field} {operator} {value}`. * The operator must be `CONTAINS (:)` or `EQUALS (=)`. * The
            /// operator must be `CONTAINS (:)` for the following fields: - `displayName` - `email` * The operator must
            /// be `EQUALS (=)` for the following fields: - `assignedUserRole.userRole` - `assignedUserRole.partnerId` -
            /// `assignedUserRole.advertiserId` - `assignedUserRole.entityType`: A synthetic field of AssignedUserRole
            /// used for filtering. Identifies the type of entity to which the user role is assigned. Valid values are
            /// `Partner` and `Advertiser`. - `assignedUserRole.parentPartnerId`: A synthetic field of AssignedUserRole
            /// used for filtering. Identifies the parent partner of the entity to which the user role is assigned."
            /// Examples: * The user with displayName containing `foo`: `displayName:"foo"` * The user with email
            /// containing `bar`: `email:"bar"` * All users with standard user roles:
            /// `assignedUserRole.userRole="STANDARD"` * All users with user roles for partner 123:
            /// `assignedUserRole.partnerId="123"` * All users with user roles for advertiser 123:
            /// `assignedUserRole.advertiserId="123"` * All users with partner level user roles: `entityType="PARTNER"`
            /// * All users with user roles for partner 123 and advertisers under partner 123: `parentPartnerId="123"`
            /// The length of this field should be no more than 500 characters.</summary>
            [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Filter { get; set; }

            /// <summary>Field by which to sort the list. Acceptable values are: * `displayName` (default) The default
            /// sorting order is ascending. To specify descending order for a field, a suffix "desc" should be added to
            /// the field name. For example, `displayName desc`.</summary>
            [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string OrderBy { get; set; }

            /// <summary>Requested page size. Must be between `1` and `100`. If unspecified will default to
            /// `100`.</summary>
            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> PageSize { get; set; }

            /// <summary>A token identifying a page of results the server should return. Typically, this is the value of
            /// next_page_token returned from the previous call to `ListUsers` method. If not specified, the first page
            /// of results will be returned.</summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }


            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/users";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add("filter", new Google.Apis.Discovery.Parameter
                {
                    Name = "filter",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
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
                RequestParameters.Add("pageSize", new Google.Apis.Discovery.Parameter
                {
                    Name = "pageSize",
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

        /// <summary>Updates an existing user. Returns the updated user if successful.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="userId">Output only. The unique ID of the user. Assigned by the system.</param>
        public virtual PatchRequest Patch(Google.Apis.DisplayVideo.v1.Data.User body, long userId)
        {
            return new PatchRequest(service, body, userId);
        }

        /// <summary>Updates an existing user. Returns the updated user if successful.</summary>
        public class PatchRequest : DisplayVideoBaseServiceRequest<Google.Apis.DisplayVideo.v1.Data.User>
        {
            /// <summary>Constructs a new Patch request.</summary>
            public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.DisplayVideo.v1.Data.User body, long userId) : base(service)
            {
                UserId = userId;
                Body = body;
                InitParameters();
            }


            /// <summary>Output only. The unique ID of the user. Assigned by the system.</summary>
            [Google.Apis.Util.RequestParameterAttribute("userId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual long UserId { get; private set; }

            /// <summary>Required. The mask to control which fields to update.</summary>
            [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
            public virtual object UpdateMask { get; set; }


            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.DisplayVideo.v1.Data.User Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "patch";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PATCH";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/users/{+userId}";

            /// <summary>Initializes Patch parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add("userId", new Google.Apis.Discovery.Parameter
                {
                    Name = "userId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^[^/]+$",
                });
                RequestParameters.Add("updateMask", new Google.Apis.Discovery.Parameter
                {
                    Name = "updateMask",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }

        }
    }
}

namespace Google.Apis.DisplayVideo.v1.Data
{    

    /// <summary>Configuration for custom Active View video viewability metrics.</summary>
    public class ActiveViewVideoViewabilityMetricConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The display name of the custom metric.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; } 

        /// <summary>The minimum visible video duration required (in seconds) in order for an impression to be recorded.
        /// You must specify minimum_duration, minimum_quartile or both. If both are specified, an impression meets the
        /// metric criteria if either requirement is met (whichever happens first).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minimumDuration")]
        public virtual string MinimumDuration { get; set; } 

        /// <summary>The minimum visible video duration required, based on the video quartiles, in order for an
        /// impression to be recorded. You must specify minimum_duration, minimum_quartile or both. If both are
        /// specified, an impression meets the metric criteria if either requirement is met (whichever happens
        /// first).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minimumQuartile")]
        public virtual string MinimumQuartile { get; set; } 

        /// <summary>Required. The minimum percentage of the video ad's pixels visible on the screen in order for an
        /// impression to be recorded.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minimumViewability")]
        public virtual string MinimumViewability { get; set; } 

        /// <summary>Required. The minimum percentage of the video ad's volume required in order for an impression to be
        /// recorded.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minimumVolume")]
        public virtual string MinimumVolume { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Details of Adloox settings.</summary>
    public class Adloox : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Adloox's brand safety settings.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("excludedAdlooxCategories")]
        public virtual System.Collections.Generic.IList<string> ExcludedAdlooxCategories { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A single advertiser in Display & Video 360 (DV360).</summary>
    public class Advertiser : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Immutable. Ad server related settings of the advertiser.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("adServerConfig")]
        public virtual AdvertiserAdServerConfig AdServerConfig { get; set; } 

        /// <summary>Output only. The unique ID of the advertiser. Assigned by the system.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("advertiserId")]
        public virtual System.Nullable<long> AdvertiserId { get; set; } 

        /// <summary>Required. Creative related settings of the advertiser.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("creativeConfig")]
        public virtual AdvertiserCreativeConfig CreativeConfig { get; set; } 

        /// <summary>Settings that control how advertiser data may be accessed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataAccessConfig")]
        public virtual AdvertiserDataAccessConfig DataAccessConfig { get; set; } 

        /// <summary>Required. The display name of the advertiser. Must be UTF-8 encoded with a maximum size of 240
        /// bytes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; } 

        /// <summary>Required. Controls whether or not insertion orders and line items of the advertiser can spend their
        /// budgets and bid on inventory. * Accepted values are `ENTITY_STATUS_ACTIVE` and
        /// `ENTITY_STATUS_SCHEDULED_FOR_DELETION`. * If set to `ENTITY_STATUS_SCHEDULED_FOR_DELETION`, the advertiser
        /// will be deleted 30 days from when it was first scheduled for deletion.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entityStatus")]
        public virtual string EntityStatus { get; set; } 

        /// <summary>Required. General settings of the advertiser.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("generalConfig")]
        public virtual AdvertiserGeneralConfig GeneralConfig { get; set; } 

        /// <summary>Integration details of the advertiser. Only integrationCode is currently applicable to advertiser.
        /// Other fields of IntegrationDetails are not supported and will be ignored if provided.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("integrationDetails")]
        public virtual IntegrationDetails IntegrationDetails { get; set; } 

        /// <summary>Output only. The resource name of the advertiser.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; } 

        /// <summary>Required. Immutable. The unique ID of the partner that the advertiser belongs to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("partnerId")]
        public virtual System.Nullable<long> PartnerId { get; set; } 

        /// <summary>Targeting settings related to ad serving of the advertiser.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("servingConfig")]
        public virtual AdvertiserTargetingConfig ServingConfig { get; set; } 

        /// <summary>Output only. The timestamp when the advertiser was last updated. Assigned by the system.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Ad server related settings of an advertiser.</summary>
    public class AdvertiserAdServerConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The configuration for advertisers that use both Campaign Manager (CM) and third-party ad
        /// servers.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cmHybridConfig")]
        public virtual CmHybridConfig CmHybridConfig { get; set; } 

        /// <summary>The configuration for advertisers that use third-party ad servers only.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("thirdPartyOnlyConfig")]
        public virtual ThirdPartyOnlyConfig ThirdPartyOnlyConfig { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Creatives related settings of an advertiser.</summary>
    public class AdvertiserCreativeConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Whether or not the advertiser is enabled for dynamic creatives.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dynamicCreativeEnabled")]
        public virtual System.Nullable<bool> DynamicCreativeEnabled { get; set; } 

        /// <summary>An ID for configuring campaign monitoring provided by Integral Ad Service (IAS). The DV360 system
        /// will append an IAS "Campaign Monitor" tag containing this ID to the creative tag.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("iasClientId")]
        public virtual System.Nullable<long> IasClientId { get; set; } 

        /// <summary>Whether or not to use DV360's Online Behavioral Advertising (OBA) compliance. Warning: Changing OBA
        /// settings may cause the audit status of your creatives to be reset by some ad exchanges, making them
        /// ineligible to serve until they are re-approved.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("obaComplianceDisabled")]
        public virtual System.Nullable<bool> ObaComplianceDisabled { get; set; } 

        /// <summary>By setting this field to `true`, you, on behalf of your company, authorize Google to use video
        /// creatives associated with this Display & Video 360 advertiser to provide reporting and features related to
        /// the advertiser's television campaigns. Applicable only when the advertiser has a CM hybrid ad server
        /// configuration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("videoCreativeDataSharingAuthorized")]
        public virtual System.Nullable<bool> VideoCreativeDataSharingAuthorized { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Settings that control how advertiser related data may be accessed.</summary>
    public class AdvertiserDataAccessConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Structured Data Files (SDF) settings for the advertiser. If not specified, the SDF settings of the
        /// parent partner are used.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sdfConfig")]
        public virtual AdvertiserSdfConfig SdfConfig { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>General settings of an advertiser.</summary>
    public class AdvertiserGeneralConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Immutable. Advertiser's currency in ISO 4217 format. Accepted codes and the currencies
        /// they represent are: Currency Code : Currency Name * `ARS` : Argentine Peso * `AUD` : Australian Dollar *
        /// `BRL` : Brazilian Real * `CAD` : Canadian Dollar * `CHF` : Swiss Franc * `CLP` : Chilean Peso * `CNY` :
        /// Chinese Yuan * `COP` : Colombian Peso * `CZK` : Czech Koruna * `DKK` : Danish Krone * `EGP` : Egyption Pound
        /// * `EUR` : Euro * `GBP` : British Pound * `HKD` : Hong Kong Dollar * `HUF` : Hungarian Forint * `IDR` :
        /// Indonesian Rupiah * `ILS` : Israeli Shekel * `INR` : Indian Rupee * `JPY` : Japanese Yen * `KRW` : South
        /// Korean Won * `MXN` : Mexican Pesos * `MYR` : Malaysian Ringgit * `NGN` : Nigerian Naira * `NOK` : Norwegian
        /// Krone * `NZD` : New Zealand Dollar * `PEN` : Peruvian Nuevo Sol * `PLN` : Polish Zloty * `RON` : New
        /// Romanian Leu * `RUB` : Russian Ruble * `SEK` : Swedish Krona * `TRY` : Turkish Lira * `TWD` : New Taiwan
        /// Dollar * `USD` : US Dollar * `ZAR` : South African Rand</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("currencyCode")]
        public virtual string CurrencyCode { get; set; } 

        /// <summary>Required. The domain URL of the advertiser's primary website. The system will send this information
        /// to publishers that require website URL to associate a campaign with an advertiser. Provide a URL with no
        /// path or query string, beginning with `http:` or `https:`. For example, http://www.example.com</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("domainUrl")]
        public virtual string DomainUrl { get; set; } 

        /// <summary>Output only. The standard TZ database name of the advertiser's time zone. For example,
        /// `America/New_York`. See more at: https://en.wikipedia.org/wiki/List_of_tz_database_time_zones For CM hybrid
        /// advertisers, the time zone is the same as that of the associated CM account; for third-party only
        /// advertisers, the time zone is the same as that of the parent partner.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeZone")]
        public virtual string TimeZone { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Structured Data Files (SDF) settings of an advertiser.</summary>
    public class AdvertiserSdfConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Whether or not this advertiser overrides the SDF configuration of its parent partner. By default,
        /// an advertiser inherits the SDF configuration from the parent partner. To override the partner configuration,
        /// set this field to `true` and provide the new configuration in sdfConfig.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("overridePartnerSdfConfig")]
        public virtual System.Nullable<bool> OverridePartnerSdfConfig { get; set; } 

        /// <summary>The SDF configuration for the advertiser. * Required when overridePartnerSdfConfig is `true`. *
        /// Output only when overridePartnerSdfConfig is `false`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sdfConfig")]
        public virtual SdfConfig SdfConfig { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Targeting settings related to ad serving of an advertiser.</summary>
    public class AdvertiserTargetingConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Whether or not connected TV devices are exempt from viewability targeting for all video line items
        /// under the advertiser.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exemptTvFromViewabilityTargeting")]
        public virtual System.Nullable<bool> ExemptTvFromViewabilityTargeting { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Represents a targetable age range. This will be populated in the details field of an
    /// AssignedTargetingOption when targeting_type is `TARGETING_TYPE_AGE_RANGE`.</summary>
    public class AgeRangeAssignedTargetingOptionDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The age range of an audience. We only support targeting a continuous age range of an
        /// audience. Thus, the age range represented in this field can be 1) targeted solely, or, 2) part of a larger
        /// continuous age range. The reach of a continuous age range targeting can be expanded by also targeting an
        /// audience of an unknown age.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ageRange")]
        public virtual string AgeRange { get; set; } 

        /// <summary>Required. The targeting_option_id of a TargetingOption of type
        /// `TARGETING_TYPE_AGE_RANGE`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetingOptionId")]
        public virtual string TargetingOptionId { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Represents a targetable age range. This will be populated in the age_range_details field when
    /// targeting_type is `TARGETING_TYPE_AGE_RANGE`.</summary>
    public class AgeRangeTargetingOptionDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The age range of an audience.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ageRange")]
        public virtual string AgeRange { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Details for assigned app targeting option. This will be populated in the details field of an
    /// AssignedTargetingOption when targeting_type is `TARGETING_TYPE_APP`.</summary>
    public class AppAssignedTargetingOptionDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The ID of the app. Android's Play store app uses bundle ID, for example
        /// `com.google.android.gm`. Apple's App store app ID uses 9 digit string, for example `422689480`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("appId")]
        public virtual string AppId { get; set; } 

        /// <summary>Output only. The display name of the app.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; } 

        /// <summary>Indicates if this option is being negatively targeted.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("negative")]
        public virtual System.Nullable<bool> Negative { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Details for assigned app category targeting option. This will be populated in the app_category_details
    /// field of an AssignedTargetingOption when targeting_type is `TARGETING_TYPE_APP_CATEGORY`.</summary>
    public class AppCategoryAssignedTargetingOptionDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The display name of the app category.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; } 

        /// <summary>Indicates if this option is being negatively targeted.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("negative")]
        public virtual System.Nullable<bool> Negative { get; set; } 

        /// <summary>Required. The targeting_option_id field when targeting_type is
        /// `TARGETING_TYPE_APP_CATEGORY`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetingOptionId")]
        public virtual string TargetingOptionId { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Represents a targetable collection of apps. A collection lets you target dynamic groups of related apps
    /// that are maintained by the platform, for example `All Apps/Google Play/Games`. This will be populated in the
    /// app_category_details field when targeting_type is `TARGETING_TYPE_APP_CATEGORY`.</summary>
    public class AppCategoryTargetingOptionDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The name of the app collection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A single asset.</summary>
    public class Asset : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The asset content. For uploaded assets, the content is the serving path.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("content")]
        public virtual string Content { get; set; } 

        /// <summary>Media ID of the uploaded asset. This is a unique identifier for the asset. This ID can be passed to
        /// other API calls, e.g. CreateCreative to associate the asset with a creative.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mediaId")]
        public virtual System.Nullable<long> MediaId { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Asset association for the creative.</summary>
    public class AssetAssociation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The associated asset.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("asset")]
        public virtual Asset Asset { get; set; } 

        /// <summary>The role of this asset for the creative.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("role")]
        public virtual string Role { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>An assignment between a targetable inventory source and an inventory source group.</summary>
    public class AssignedInventorySource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The unique ID of the assigned inventory source. The ID is only unique within a given
        /// inventory source group. It may be reused in other contexts.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("assignedInventorySourceId")]
        public virtual System.Nullable<long> AssignedInventorySourceId { get; set; } 

        /// <summary>Required. The ID of the inventory source entity being targeted.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inventorySourceId")]
        public virtual string InventorySourceId { get; set; } 

        /// <summary>Output only. The resource name of the assigned inventory source.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>An assignment between a location list and a relevant targeting option. Currently, geo region targeting
    /// options are the only supported option for assignment.</summary>
    public class AssignedLocation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The unique ID of the assigned location. The ID is only unique within a location list.
        /// It may be reused in other contexts.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("assignedLocationId")]
        public virtual System.Nullable<long> AssignedLocationId { get; set; } 

        /// <summary>Output only. The resource name of the assigned location.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; } 

        /// <summary>Required. The ID of the targeting option assigned to the location list. Must be of type
        /// TARGETING_TYPE_GEO_REGION.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetingOptionId")]
        public virtual string TargetingOptionId { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A single assigned targeting option, which defines the state of a targeting option for an entity with
    /// targeting settings.</summary>
    public class AssignedTargetingOption : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Age range details. This field will be populated when the TargetingType is
        /// `TARGETING_TYPE_AGE_RANGE`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ageRangeDetails")]
        public virtual AgeRangeAssignedTargetingOptionDetails AgeRangeDetails { get; set; } 

        /// <summary>App category details. This field will be populated when the TargetingType is
        /// `TARGETING_TYPE_APP_CATEGORY`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("appCategoryDetails")]
        public virtual AppCategoryAssignedTargetingOptionDetails AppCategoryDetails { get; set; } 

        /// <summary>App details. This field will be populated when the TargetingType is `TARGETING_TYPE_APP`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("appDetails")]
        public virtual AppAssignedTargetingOptionDetails AppDetails { get; set; } 

        /// <summary>Output only. The unique ID of the assigned targeting option. The ID is only unique within a given
        /// line item and targeting type. It may be reused in other contexts.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("assignedTargetingOptionId")]
        public virtual string AssignedTargetingOptionId { get; set; } 

        /// <summary>Audience targeting details. This field will be populated when the TargetingType is
        /// `TARGETING_TYPE_AUDIENCE_GROUP`. You can only target one audience group option per line item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("audienceGroupDetails")]
        public virtual AudienceGroupAssignedTargetingOptionDetails AudienceGroupDetails { get; set; } 

        /// <summary>Authorized seller status details. This field will be populated when the TargetingType is
        /// `TARGETING_TYPE_AUTHORIZED_SELLER_STATUS`. You can only target one authorized seller status option per line
        /// item. If a line item doesn't have an authorized seller status option, all authorized sellers indicated as
        /// DIRECT or RESELLER in the ads.txt file are targeted by default.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("authorizedSellerStatusDetails")]
        public virtual AuthorizedSellerStatusAssignedTargetingOptionDetails AuthorizedSellerStatusDetails { get; set; } 

        /// <summary>Browser details. This field will be populated when the TargetingType is
        /// `TARGETING_TYPE_BROWSER`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("browserDetails")]
        public virtual BrowserAssignedTargetingOptionDetails BrowserDetails { get; set; } 

        /// <summary>Carrier and ISP details. This field will be populated when the TargetingType is
        /// `TARGETING_TYPE_CARRIER_AND_ISP`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("carrierAndIspDetails")]
        public virtual CarrierAndIspAssignedTargetingOptionDetails CarrierAndIspDetails { get; set; } 

        /// <summary>Category details. This field will be populated when the TargetingType is `TARGETING_TYPE_CATEGORY`.
        /// Targeting a category will also target its subcategories. If a category is excluded from targeting and a
        /// subcategory is included, the exclusion will take precedence.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("categoryDetails")]
        public virtual CategoryAssignedTargetingOptionDetails CategoryDetails { get; set; } 

        /// <summary>Channel details. This field will be populated when the TargetingType is
        /// `TARGETING_TYPE_CHANNEL`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("channelDetails")]
        public virtual ChannelAssignedTargetingOptionDetails ChannelDetails { get; set; } 

        /// <summary>Content instream position details. This field will be populated when the TargetingType is
        /// `TARGETING_TYPE_CONTENT_INSTREAM_POSITION`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contentInstreamPositionDetails")]
        public virtual ContentInstreamPositionAssignedTargetingOptionDetails ContentInstreamPositionDetails { get; set; } 

        /// <summary>Content outstream position details. This field will be populated when the TargetingType is
        /// `TARGETING_TYPE_CONTENT_OUTSTREAM_POSITION`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contentOutstreamPositionDetails")]
        public virtual ContentOutstreamPositionAssignedTargetingOptionDetails ContentOutstreamPositionDetails { get; set; } 

        /// <summary>Day and time details. This field will be populated when the TargetingType is
        /// `TARGETING_TYPE_DAY_AND_TIME`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dayAndTimeDetails")]
        public virtual DayAndTimeAssignedTargetingOptionDetails DayAndTimeDetails { get; set; } 

        /// <summary>Device make and model details. This field will be populated when the TargetingType is
        /// `TARGETING_TYPE_DEVICE_MAKE_MODEL`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deviceMakeModelDetails")]
        public virtual DeviceMakeModelAssignedTargetingOptionDetails DeviceMakeModelDetails { get; set; } 

        /// <summary>Device Type details. This field will be populated when the TargetingType is
        /// `TARGETING_TYPE_DEVICE_TYPE`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deviceTypeDetails")]
        public virtual DeviceTypeAssignedTargetingOptionDetails DeviceTypeDetails { get; set; } 

        /// <summary>Digital content label details. This field will be populated when the TargetingType is
        /// `TARGETING_TYPE_DIGITAL_CONTENT_LABEL_EXCLUSION`. Digital content labels are targeting exclusions.
        /// Advertiser level digital content label exclusions, if set, are always applied in serving (even though they
        /// aren't visible in line item settings). Line item settings can exclude content labels in addition to
        /// advertiser exclusions, but can't override them. A line item won't serve if all the digital content labels
        /// are excluded.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("digitalContentLabelExclusionDetails")]
        public virtual DigitalContentLabelAssignedTargetingOptionDetails DigitalContentLabelExclusionDetails { get; set; } 

        /// <summary>Environment details. This field will be populated when the TargetingType is
        /// `TARGETING_TYPE_ENVIRONMENT`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("environmentDetails")]
        public virtual EnvironmentAssignedTargetingOptionDetails EnvironmentDetails { get; set; } 

        /// <summary>Exchange details. This field will be populated when the TargetingType is
        /// `TARGETING_TYPE_EXCHANGE`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exchangeDetails")]
        public virtual ExchangeAssignedTargetingOptionDetails ExchangeDetails { get; set; } 

        /// <summary>Gender details. This field will be populated when the TargetingType is
        /// `TARGETING_TYPE_GENDER`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("genderDetails")]
        public virtual GenderAssignedTargetingOptionDetails GenderDetails { get; set; } 

        /// <summary>Geographic region details. This field will be populated when the TargetingType is
        /// `TARGETING_TYPE_GEO_REGION`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("geoRegionDetails")]
        public virtual GeoRegionAssignedTargetingOptionDetails GeoRegionDetails { get; set; } 

        /// <summary>Household income details. This field will be populated when the TargetingType is
        /// `TARGETING_TYPE_HOUSEHOLD_INCOME`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("householdIncomeDetails")]
        public virtual HouseholdIncomeAssignedTargetingOptionDetails HouseholdIncomeDetails { get; set; } 

        /// <summary>Output only. The inheritance status of the assigned targeting option.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inheritance")]
        public virtual string Inheritance { get; set; } 

        /// <summary>Inventory source details. This field will be populated when the TargetingType is
        /// `TARGETING_TYPE_INVENTORY_SOURCE`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inventorySourceDetails")]
        public virtual InventorySourceAssignedTargetingOptionDetails InventorySourceDetails { get; set; } 

        /// <summary>Inventory source group details. This field will be populated when the TargetingType is
        /// `TARGETING_TYPE_INVENTORY_SOURCE_GROUP`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inventorySourceGroupDetails")]
        public virtual InventorySourceGroupAssignedTargetingOptionDetails InventorySourceGroupDetails { get; set; } 

        /// <summary>Keyword details. This field will be populated when the TargetingType is `TARGETING_TYPE_KEYWORD`. A
        /// maximum of 5000 direct negative keywords can be assigned to a line item. No limit on number of positive
        /// keywords that can be assigned.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("keywordDetails")]
        public virtual KeywordAssignedTargetingOptionDetails KeywordDetails { get; set; } 

        /// <summary>Language details. This field will be populated when the TargetingType is
        /// `TARGETING_TYPE_LANGUAGE`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("languageDetails")]
        public virtual LanguageAssignedTargetingOptionDetails LanguageDetails { get; set; } 

        /// <summary>Output only. The resource name for this assigned targeting option.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; } 

        /// <summary>Keyword details. This field will be populated when the TargetingType is
        /// `TARGETING_TYPE_NEGATIVE_KEYWORD_LIST`. A maximum of 4 negative keyword lists can be assigned to a line
        /// item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("negativeKeywordListDetails")]
        public virtual NegativeKeywordListAssignedTargetingOptionDetails NegativeKeywordListDetails { get; set; } 

        /// <summary>On screen position details. This field will be populated when the TargetingType is
        /// `TARGETING_TYPE_ON_SCREEN_POSITION`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("onScreenPositionDetails")]
        public virtual OnScreenPositionAssignedTargetingOptionDetails OnScreenPositionDetails { get; set; } 

        /// <summary>Operating system details. This field will be populated when the TargetingType is
        /// `TARGETING_TYPE_OPERATING_SYSTEM`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operatingSystemDetails")]
        public virtual OperatingSystemAssignedTargetingOptionDetails OperatingSystemDetails { get; set; } 

        /// <summary>Parental status details. This field will be populated when the TargetingType is
        /// `TARGETING_TYPE_PARENTAL_STATUS`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parentalStatusDetails")]
        public virtual ParentalStatusAssignedTargetingOptionDetails ParentalStatusDetails { get; set; } 

        /// <summary>Proximity location list details. This field will be populated when the TargetingType is
        /// `TARGETING_TYPE_PROXIMITY_LOCATION_LIST`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("proximityLocationListDetails")]
        public virtual ProximityLocationListAssignedTargetingOptionDetails ProximityLocationListDetails { get; set; } 

        /// <summary>Regional location list details. This field will be populated when the TargetingType is
        /// `TARGETING_TYPE_REGIONAL_LOCATION_LIST`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("regionalLocationListDetails")]
        public virtual RegionalLocationListAssignedTargetingOptionDetails RegionalLocationListDetails { get; set; } 

        /// <summary>Sensitive category details. This field will be populated when the TargetingType is
        /// `TARGETING_TYPE_SENSITIVE_CATEGORY_EXCLUSION`. Sensitive categories are targeting exclusions. Advertiser
        /// level sensitive category exclusions, if set, are always applied in serving (even though they aren't visible
        /// in line item settings). Line item settings can exclude sensitive categories in addition to advertiser
        /// exclusions, but can't override them.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sensitiveCategoryExclusionDetails")]
        public virtual SensitiveCategoryAssignedTargetingOptionDetails SensitiveCategoryExclusionDetails { get; set; } 

        /// <summary>Sub-exchange details. This field will be populated when the TargetingType is
        /// `TARGETING_TYPE_SUB_EXCHANGE`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subExchangeDetails")]
        public virtual SubExchangeAssignedTargetingOptionDetails SubExchangeDetails { get; set; } 

        /// <summary>Output only. Identifies the type of this assigned targeting option.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetingType")]
        public virtual string TargetingType { get; set; } 

        /// <summary>Third party verification details. This field will be populated when the TargetingType is
        /// `TARGETING_TYPE_THIRD_PARTY_VERIFIER`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("thirdPartyVerifierDetails")]
        public virtual ThirdPartyVerifierAssignedTargetingOptionDetails ThirdPartyVerifierDetails { get; set; } 

        /// <summary>URL details. This field will be populated when the TargetingType is `TARGETING_TYPE_URL`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("urlDetails")]
        public virtual UrlAssignedTargetingOptionDetails UrlDetails { get; set; } 

        /// <summary>User rewarded content details. This field will be populated when the TargetingType is
        /// `TARGETING_TYPE_USER_REWARDED_CONTENT`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userRewardedContentDetails")]
        public virtual UserRewardedContentAssignedTargetingOptionDetails UserRewardedContentDetails { get; set; } 

        /// <summary>Video player size details. This field will be populated when the TargetingType is
        /// `TARGETING_TYPE_VIDEO_PLAYER_SIZE`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("videoPlayerSizeDetails")]
        public virtual VideoPlayerSizeAssignedTargetingOptionDetails VideoPlayerSizeDetails { get; set; } 

        /// <summary>Viewability details. This field will be populated when the TargetingType is
        /// `TARGETING_TYPE_VIEWABILITY`. You can only target one viewability option per line item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("viewabilityDetails")]
        public virtual ViewabilityAssignedTargetingOptionDetails ViewabilityDetails { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A single assigned user role, which defines a user's authorized interaction with a specified partner or
    /// advertiser.</summary>
    public class AssignedUserRole : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ID of the advertiser that the assigend user role applies to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("advertiserId")]
        public virtual System.Nullable<long> AdvertiserId { get; set; } 

        /// <summary>Output only. The ID of the assigned user role.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("assignedUserRoleId")]
        public virtual string AssignedUserRoleId { get; set; } 

        /// <summary>The ID of the partner that the assigned user role applies to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("partnerId")]
        public virtual System.Nullable<long> PartnerId { get; set; } 

        /// <summary>Required. The user role to assign to a user for the entity.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userRole")]
        public virtual string UserRole { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Assigned audience group targeting option details. This will be populated in the details field of an
    /// AssignedTargetingOption when targeting_type is `TARGETING_TYPE_AUDIENCE_GROUP`. The relation between each group
    /// is UNION, except for excluded_first_and_third_party_audience_group and excluded_google_audience_group, of which
    /// COMPLEMENT is UNION'ed with other groups.</summary>
    public class AudienceGroupAssignedTargetingOptionDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The first and third party audience ids and recencies of the excluded first and third party audience
        /// group. Used for negative targeting. Its COMPLEMENT is used to UNION other audience groups.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("excludedFirstAndThirdPartyAudienceGroup")]
        public virtual FirstAndThirdPartyAudienceGroup ExcludedFirstAndThirdPartyAudienceGroup { get; set; } 

        /// <summary>The Google audience ids of the excluded Google audience group. Used for negative targeting. It's
        /// COMPLEMENT is used to UNION other audience groups. Only contains Affinity, In-market and Installed-apps type
        /// Google audiences. All items are logically ‘OR’ of each other.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("excludedGoogleAudienceGroup")]
        public virtual GoogleAudienceGroup ExcludedGoogleAudienceGroup { get; set; } 

        /// <summary>The combined audience ids of the included combined audience group. Contains combined audience ids
        /// only.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("includedCombinedAudienceGroup")]
        public virtual CombinedAudienceGroup IncludedCombinedAudienceGroup { get; set; } 

        /// <summary>The custom list ids of the included custom list group. Contains custom list ids only.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("includedCustomListGroup")]
        public virtual CustomListGroup IncludedCustomListGroup { get; set; } 

        /// <summary>The first and third party audience ids and recencies of included first and third party audience
        /// groups. Each first and third party audience group contains first and third party audience ids only. The
        /// relation between each first and third party audience group is INTERSECTION, and the result is UNION'ed with
        /// other audience groups. Repeated groups with same settings will be ignored.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("includedFirstAndThirdPartyAudienceGroups")]
        public virtual System.Collections.Generic.IList<FirstAndThirdPartyAudienceGroup> IncludedFirstAndThirdPartyAudienceGroups { get; set; } 

        /// <summary>The Google audience ids of the included Google audience group. Contains Google audience ids
        /// only.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("includedGoogleAudienceGroup")]
        public virtual GoogleAudienceGroup IncludedGoogleAudienceGroup { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>The length an audio or a video has been played.</summary>
    public class AudioVideoOffset : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The offset in percentage of the audio or video duration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("percentage")]
        public virtual System.Nullable<long> Percentage { get; set; } 

        /// <summary>The offset in seconds from the start of the audio or video.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("seconds")]
        public virtual System.Nullable<long> Seconds { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Response message for AdvertiserService.AuditAdvertiser.</summary>
    public class AuditAdvertiserResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The number of individual targeting options from the following targeting types that are assigned to
        /// a line item under this advertiser. These individual targeting options count towards the limit of 4500000 ad
        /// group targeting options per advertiser. Qualifying Targeting types: * Channels, URLs, apps, and collections
        /// * Demographic * Google Audiences, including Affinity, Custom Affinity, and In-market audiences * Inventory
        /// source * Keyword * Mobile app category * User lists * Video targeting * Viewability</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("adGroupCriteriaCount")]
        public virtual System.Nullable<long> AdGroupCriteriaCount { get; set; } 

        /// <summary>The number of individual targeting options from the following targeting types that are assigned to
        /// a line item under this advertiser. These individual targeting options count towards the limit of 900000
        /// campaign targeting options per advertiser. Qualifying Targeting types: * Position * Browser * Connection
        /// speed * Day and time * Device and operating system * Digital content label * Sensitive categories *
        /// Environment * Geography, including business chains and proximity * ISP * Language * Third-party
        /// verification</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("campaignCriteriaCount")]
        public virtual System.Nullable<long> CampaignCriteriaCount { get; set; } 

        /// <summary>The number of channels created under this advertiser. These channels count towards the limit of
        /// 1000 channels per advertiser.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("channelsCount")]
        public virtual System.Nullable<long> ChannelsCount { get; set; } 

        /// <summary>The number of negative keyword lists created under this advertiser. These negative keyword lists
        /// count towards the limit of 20 negative keyword lists per advertiser.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("negativeKeywordListsCount")]
        public virtual System.Nullable<long> NegativeKeywordListsCount { get; set; } 

        /// <summary>The number of negatively targeted channels created under this advertiser. These negatively targeted
        /// channels count towards the limit of 5 negatively targeted channels per advertiser.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("negativelyTargetedChannelsCount")]
        public virtual System.Nullable<long> NegativelyTargetedChannelsCount { get; set; } 

        /// <summary>The number of ACTIVE and PAUSED campaigns under this advertiser. These campaigns count towards the
        /// limit of 9999 campaigns per advertiser.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("usedCampaignsCount")]
        public virtual System.Nullable<long> UsedCampaignsCount { get; set; } 

        /// <summary>The number of ACTIVE, PAUSED and DRAFT insertion orders under this advertiser. These insertion
        /// orders count towards the limit of 9999 insertion orders per advertiser.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("usedInsertionOrdersCount")]
        public virtual System.Nullable<long> UsedInsertionOrdersCount { get; set; } 

        /// <summary>The number of ACTIVE, PAUSED, and DRAFT line items under this advertiser. These line items count
        /// towards the limit of 9999 line items per advertiser.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("usedLineItemsCount")]
        public virtual System.Nullable<long> UsedLineItemsCount { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Represents an assigned authorized seller status. This will be populated in the details field of an
    /// AssignedTargetingOption when targeting_type is `TARGETING_TYPE_AUTHORIZED_SELLER_STATUS`.</summary>
    public class AuthorizedSellerStatusAssignedTargetingOptionDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The authorized seller status to target.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("authorizedSellerStatus")]
        public virtual string AuthorizedSellerStatus { get; set; } 

        /// <summary>Required. The targeting_option_id of a TargetingOption of type
        /// `TARGETING_TYPE_AUTHORIZED_SELLER_STATUS`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetingOptionId")]
        public virtual string TargetingOptionId { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Represents a targetable authorized seller status. This will be populated in the
    /// authorized_seller_status_details field when targeting_type is
    /// `TARGETING_TYPE_AUTHORIZED_SELLER_STATUS`.</summary>
    public class AuthorizedSellerStatusTargetingOptionDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The authorized seller status.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("authorizedSellerStatus")]
        public virtual string AuthorizedSellerStatus { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Settings that control the bid strategy. Bid strategy determines the bid price.</summary>
    public class BiddingStrategy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A strategy that uses a fixed bid price.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fixedBid")]
        public virtual FixedBidStrategy FixedBid { get; set; } 

        /// <summary>A strategy that automatically adjusts the bid to optimize to your performance goal while spending
        /// the full budget. At insertion order level, the markup_type of line items cannot be set to
        /// `PARTNER_REVENUE_MODEL_MARKUP_TYPE_CPM`. In addition, when performance_goal_type is one of: *
        /// `BIDDING_STRATEGY_PERFORMANCE_GOAL_TYPE_CPA` * `BIDDING_STRATEGY_PERFORMANCE_GOAL_TYPE_CPC` *
        /// `BIDDING_STRATEGY_PERFORMANCE_GOAL_TYPE_AV_VIEWED` , the line_item_type of the insertion order line items
        /// must be either: * `LINE_ITEM_TYPE_DISPLAY_DEFAULT` * `LINE_ITEM_TYPE_VIDEO_DEFAULT` , and when
        /// performance_goal_type is either: * `BIDDING_STRATEGY_PERFORMANCE_GOAL_TYPE_CIVA` *
        /// `BIDDING_STRATEGY_PERFORMANCE_GOAL_TYPE_IVO_TEN` the line_item_type of the insertion order line items must
        /// be `LINE_ITEM_TYPE_VIDEO_DEFAULT`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maximizeSpendAutoBid")]
        public virtual MaximizeSpendBidStrategy MaximizeSpendAutoBid { get; set; } 

        /// <summary>A strategy that automatically adjusts the bid to meet or beat a specified performance goal. It is
        /// to be used only for a line item entity.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("performanceGoalAutoBid")]
        public virtual PerformanceGoalBidStrategy PerformanceGoalAutoBid { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Details for assigned browser targeting option. This will be populated in the details field of an
    /// AssignedTargetingOption when targeting_type is `TARGETING_TYPE_BROWSER`.</summary>
    public class BrowserAssignedTargetingOptionDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The display name of the browser.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; } 

        /// <summary>Indicates if this option is being negatively targeted. All assigned browser targeting options on
        /// the same line item must have the same value for this field.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("negative")]
        public virtual System.Nullable<bool> Negative { get; set; } 

        /// <summary>Required. The targeting_option_id of a TargetingOption of type `TARGETING_TYPE_BROWSER`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetingOptionId")]
        public virtual string TargetingOptionId { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Represents a targetable browser. This will be populated in the browser_details field when
    /// targeting_type is `TARGETING_TYPE_BROWSER`.</summary>
    public class BrowserTargetingOptionDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The display name of the browser.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Request message for BulkEditAdvertiserAssignedTargetingOptions.</summary>
    public class BulkEditAdvertiserAssignedTargetingOptionsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The assigned targeting options to create in batch, specified as a list of
        /// `CreateAssignedTargetingOptionsRequest`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createRequests")]
        public virtual System.Collections.Generic.IList<CreateAssignedTargetingOptionsRequest> CreateRequests { get; set; } 

        /// <summary>The assigned targeting options to delete in batch, specified as a list of
        /// `DeleteAssignedTargetingOptionsRequest`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deleteRequests")]
        public virtual System.Collections.Generic.IList<DeleteAssignedTargetingOptionsRequest> DeleteRequests { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class BulkEditAdvertiserAssignedTargetingOptionsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of assigned targeting options that have been successfully created. This list will be
        /// absent if empty.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createdAssignedTargetingOptions")]
        public virtual System.Collections.Generic.IList<AssignedTargetingOption> CreatedAssignedTargetingOptions { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Request message for AssignedInventorySourceService.BulkEdit.</summary>
    public class BulkEditAssignedInventorySourcesRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ID of the advertiser that owns the parent inventory source group. The parent partner does not
        /// have access to these assigned inventory sources.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("advertiserId")]
        public virtual System.Nullable<long> AdvertiserId { get; set; } 

        /// <summary>The assigned inventory sources to create in bulk, specified as a list of
        /// AssignedInventorySources.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createdAssignedInventorySources")]
        public virtual System.Collections.Generic.IList<AssignedInventorySource> CreatedAssignedInventorySources { get; set; } 

        /// <summary>The IDs of the assigned inventory sources to delete in bulk, specified as a list of
        /// assigned_inventory_source_ids.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deletedAssignedInventorySources")]
        public virtual System.Collections.Generic.IList<System.Nullable<long>> DeletedAssignedInventorySources { get; set; } 

        /// <summary>The ID of the partner that owns the inventory source group. Only this partner has write access to
        /// these assigned inventory sources.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("partnerId")]
        public virtual System.Nullable<long> PartnerId { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Response message for AssignedInventorySourceService.BulkEdit.</summary>
    public class BulkEditAssignedInventorySourcesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of assigned inventory sources that have been successfully created. This list will be
        /// absent if empty.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("assignedInventorySources")]
        public virtual System.Collections.Generic.IList<AssignedInventorySource> AssignedInventorySources { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Request message for AssignedLocationService.BulkEditAssignedLocations.</summary>
    public class BulkEditAssignedLocationsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The assigned locations to create in bulk, specified as a list of AssignedLocations.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createdAssignedLocations")]
        public virtual System.Collections.Generic.IList<AssignedLocation> CreatedAssignedLocations { get; set; } 

        /// <summary>The IDs of the assigned locations to delete in bulk, specified as a list of
        /// assigned_location_ids.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deletedAssignedLocations")]
        public virtual System.Collections.Generic.IList<System.Nullable<long>> DeletedAssignedLocations { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Response message for AssignedLocationService.BulkEditAssignedLocations.</summary>
    public class BulkEditAssignedLocationsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of assigned locations that have been successfully created. This list will be absent if
        /// empty.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("assignedLocations")]
        public virtual System.Collections.Generic.IList<AssignedLocation> AssignedLocations { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Request message for BulkEditAssignedUserRoles.</summary>
    public class BulkEditAssignedUserRolesRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The assigned user roles to create in batch, specified as a list of AssignedUserRoles.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createdAssignedUserRoles")]
        public virtual System.Collections.Generic.IList<AssignedUserRole> CreatedAssignedUserRoles { get; set; } 

        /// <summary>The assigned user roles to delete in batch, specified as a list of assigned_user_role_ids. The
        /// format of assigned_user_role_id is `entityType-entityid`, for example `partner-123`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deletedAssignedUserRoles")]
        public virtual System.Collections.Generic.IList<string> DeletedAssignedUserRoles { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class BulkEditAssignedUserRolesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of assigned user roles that have been successfully created. This list will be absent if
        /// empty.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createdAssignedUserRoles")]
        public virtual System.Collections.Generic.IList<AssignedUserRole> CreatedAssignedUserRoles { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Request message for BulkEditLineItemAssignedTargetingOptions.</summary>
    public class BulkEditLineItemAssignedTargetingOptionsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The assigned targeting options to create in batch, specified as a list of
        /// `CreateAssignedTargetingOptionsRequest`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createRequests")]
        public virtual System.Collections.Generic.IList<CreateAssignedTargetingOptionsRequest> CreateRequests { get; set; } 

        /// <summary>The assigned targeting options to delete in batch, specified as a list of
        /// `DeleteAssignedTargetingOptionsRequest`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deleteRequests")]
        public virtual System.Collections.Generic.IList<DeleteAssignedTargetingOptionsRequest> DeleteRequests { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class BulkEditLineItemAssignedTargetingOptionsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of assigned targeting options that have been successfully created. This list will be
        /// absent if empty.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createdAssignedTargetingOptions")]
        public virtual System.Collections.Generic.IList<AssignedTargetingOption> CreatedAssignedTargetingOptions { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Request message for NegativeKeywordService.BulkEditNegativeKeywords.</summary>
    public class BulkEditNegativeKeywordsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The negative keywords to create in batch, specified as a list of NegativeKeywords.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createdNegativeKeywords")]
        public virtual System.Collections.Generic.IList<NegativeKeyword> CreatedNegativeKeywords { get; set; } 

        /// <summary>The negative keywords to delete in batch, specified as a list of keyword_values.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deletedNegativeKeywords")]
        public virtual System.Collections.Generic.IList<string> DeletedNegativeKeywords { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Response message for NegativeKeywordService.BulkEditNegativeKeywords.</summary>
    public class BulkEditNegativeKeywordsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of negative keywords that have been successfully created. This list will be absent if
        /// empty.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("negativeKeywords")]
        public virtual System.Collections.Generic.IList<NegativeKeyword> NegativeKeywords { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Request message for BulkEditPartnerAssignedTargetingOptions.</summary>
    public class BulkEditPartnerAssignedTargetingOptionsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The assigned targeting options to create in batch, specified as a list of
        /// `CreateAssignedTargetingOptionsRequest`. Supported targeting types: * `TARGETING_TYPE_CHANNEL`</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createRequests")]
        public virtual System.Collections.Generic.IList<CreateAssignedTargetingOptionsRequest> CreateRequests { get; set; } 

        /// <summary>The assigned targeting options to delete in batch, specified as a list of
        /// `DeleteAssignedTargetingOptionsRequest`. Supported targeting types: * `TARGETING_TYPE_CHANNEL`</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deleteRequests")]
        public virtual System.Collections.Generic.IList<DeleteAssignedTargetingOptionsRequest> DeleteRequests { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class BulkEditPartnerAssignedTargetingOptionsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of assigned targeting options that have been successfully created. This list will be
        /// absent if empty.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createdAssignedTargetingOptions")]
        public virtual System.Collections.Generic.IList<AssignedTargetingOption> CreatedAssignedTargetingOptions { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Request message for SiteService.BulkEditSites.</summary>
    public class BulkEditSitesRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ID of the advertiser that owns the parent channel.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("advertiserId")]
        public virtual System.Nullable<long> AdvertiserId { get; set; } 

        /// <summary>The sites to create in batch, specified as a list of Sites.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createdSites")]
        public virtual System.Collections.Generic.IList<Site> CreatedSites { get; set; } 

        /// <summary>The sites to delete in batch, specified as a list of site url_or_app_ids.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deletedSites")]
        public virtual System.Collections.Generic.IList<string> DeletedSites { get; set; } 

        /// <summary>The ID of the partner that owns the parent channel.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("partnerId")]
        public virtual System.Nullable<long> PartnerId { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Response message for SiteService.BulkEditSites.</summary>
    public class BulkEditSitesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of sites that have been successfully created. This list will be absent if empty.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sites")]
        public virtual System.Collections.Generic.IList<Site> Sites { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class BulkListAdvertiserAssignedTargetingOptionsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of assigned targeting options. This list will be absent if empty.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("assignedTargetingOptions")]
        public virtual System.Collections.Generic.IList<AssignedTargetingOption> AssignedTargetingOptions { get; set; } 

        /// <summary>A token identifying the next page of results. This value should be specified as the pageToken in a
        /// subsequent BulkListAdvertiserAssignedTargetingOptionsRequest to fetch the next page of results. This token
        /// will be absent if there are no more assigned_targeting_options to return.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class BulkListLineItemAssignedTargetingOptionsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of assigned targeting options. This list will be absent if empty.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("assignedTargetingOptions")]
        public virtual System.Collections.Generic.IList<AssignedTargetingOption> AssignedTargetingOptions { get; set; } 

        /// <summary>A token identifying the next page of results. This value should be specified as the pageToken in a
        /// subsequent BulkListLineItemAssignedTargetingOptionsRequest to fetch the next page of results. This token
        /// will be absent if there are no more assigned_targeting_options to return.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A single campaign.</summary>
    public class Campaign : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The unique ID of the advertiser the campaign belongs to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("advertiserId")]
        public virtual System.Nullable<long> AdvertiserId { get; set; } 

        /// <summary>Required. The planned spend and duration of the campaign.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("campaignFlight")]
        public virtual CampaignFlight CampaignFlight { get; set; } 

        /// <summary>Required. The goal of the campaign.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("campaignGoal")]
        public virtual CampaignGoal CampaignGoal { get; set; } 

        /// <summary>Output only. The unique ID of the campaign. Assigned by the system.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("campaignId")]
        public virtual System.Nullable<long> CampaignId { get; set; } 

        /// <summary>Required. The display name of the campaign. Must be UTF-8 encoded with a maximum size of 240
        /// bytes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; } 

        /// <summary>Required. Controls whether or not the insertion orders under this campaign can spend their budgets
        /// and bid on inventory. * Accepted values are `ENTITY_STATUS_ACTIVE`, `ENTITY_STATUS_ARCHIVED`, and
        /// `ENTITY_STATUS_PAUSED`. * For CreateCampaign method, `ENTITY_STATUS_ARCHIVED` is not allowed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entityStatus")]
        public virtual string EntityStatus { get; set; } 

        /// <summary>Required. The frequency cap setting of the campaign.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("frequencyCap")]
        public virtual FrequencyCap FrequencyCap { get; set; } 

        /// <summary>Output only. The resource name of the campaign.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; } 

        /// <summary>Output only. The timestamp when the campaign was last updated. Assigned by the system.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Settings that track the planned spend and duration of a campaign.</summary>
    public class CampaignFlight : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The dates that the campaign is expected to run. They are resolved relative to the parent
        /// advertiser's time zone. * The dates specified here will not affect serving. They are used to generate alerts
        /// and warnings. For example, if the flight date of any child insertion order is outside the range of these
        /// dates, the user interface will show a warning. * `start_date` is required and must be the current date or
        /// later. * `end_date` is optional. If specified, it must be the `start_date` or later. * Any specified date
        /// must be before the year 2037.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("plannedDates")]
        public virtual DateRange PlannedDates { get; set; } 

        /// <summary>The amount the campaign is expected to spend for its given planned_dates. This will not limit
        /// serving, but will be used for tracking spend in the DV360 UI. The amount is in micros. Must be greater than
        /// or equal to 0. For example, 500000000 represents 500 standard units of the currency.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("plannedSpendAmountMicros")]
        public virtual System.Nullable<long> PlannedSpendAmountMicros { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Settings that control the goal of a campaign.</summary>
    public class CampaignGoal : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The type of the campaign goal.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("campaignGoalType")]
        public virtual string CampaignGoalType { get; set; } 

        /// <summary>Required. The performance goal of the campaign. Acceptable values for performance_goal_type are: *
        /// `PERFORMANCE_GOAL_TYPE_CPM` * `PERFORMANCE_GOAL_TYPE_CPC` * `PERFORMANCE_GOAL_TYPE_CPA` *
        /// `PERFORMANCE_GOAL_TYPE_CPIAVC` * `PERFORMANCE_GOAL_TYPE_CTR` * `PERFORMANCE_GOAL_TYPE_VIEWABILITY` *
        /// `PERFORMANCE_GOAL_TYPE_OTHER`</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("performanceGoal")]
        public virtual PerformanceGoal PerformanceGoal { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Details for assigned carrier and ISP targeting option. This will be populated in the details field of
    /// an AssignedTargetingOption when targeting_type is `TARGETING_TYPE_CARRIER_AND_ISP`.</summary>
    public class CarrierAndIspAssignedTargetingOptionDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The display name of the carrier or ISP.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; } 

        /// <summary>Indicates if this option is being negatively targeted. All assigned carrier and ISP targeting
        /// options on the same line item must have the same value for this field.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("negative")]
        public virtual System.Nullable<bool> Negative { get; set; } 

        /// <summary>Required. The targeting_option_id of a TargetingOption of type
        /// `TARGETING_TYPE_CARRIER_AND_ISP`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetingOptionId")]
        public virtual string TargetingOptionId { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Represents a targetable carrier or ISP. This will be populated in the carrier_and_isp_details field of
    /// a TargetingOption when targeting_type is `TARGETING_TYPE_CARRIER_AND_ISP`.</summary>
    public class CarrierAndIspTargetingOptionDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The display name of the carrier or ISP.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; } 

        /// <summary>Output only. The type indicating if it's carrier or ISP.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Assigned category targeting option details. This will be populated in the category_details field when
    /// targeting_type is `TARGETING_TYPE_CATEGORY`.</summary>
    public class CategoryAssignedTargetingOptionDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The display name of the category.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; } 

        /// <summary>Indicates if this option is being negatively targeted.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("negative")]
        public virtual System.Nullable<bool> Negative { get; set; } 

        /// <summary>Required. The targeting_option_id field when targeting_type is `TARGETING_TYPE_CATEGORY`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetingOptionId")]
        public virtual string TargetingOptionId { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Represents a targetable category. This will be populated in the category_details field of a
    /// TargetingOption when targeting_type is `TARGETING_TYPE_CATEGORY`.</summary>
    public class CategoryTargetingOptionDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The display name of the category.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A single channel. Channels are custom groups of related websites and apps.</summary>
    public class Channel : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ID of the advertiser that owns the channel.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("advertiserId")]
        public virtual System.Nullable<long> AdvertiserId { get; set; } 

        /// <summary>Output only. The unique ID of the channel. Assigned by the system.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("channelId")]
        public virtual System.Nullable<long> ChannelId { get; set; } 

        /// <summary>Required. The display name of the channel. Must be UTF-8 encoded with a maximum length of 240
        /// bytes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; } 

        /// <summary>Output only. The resource name of the channel.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; } 

        /// <summary>The ID of the partner that owns the channel.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("partnerId")]
        public virtual System.Nullable<long> PartnerId { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Details for assigned channel targeting option. This will be populated in the details field of an
    /// AssignedTargetingOption when targeting_type is `TARGETING_TYPE_CHANNEL`.</summary>
    public class ChannelAssignedTargetingOptionDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. ID of the channel. Should refer to the channel ID field on a [Partner-owned
        /// channel](partners.channels#Channel.FIELDS.channel_id) or [advertiser-owned
        /// channel](advertisers.channels#Channel.FIELDS.channel_id) resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("channelId")]
        public virtual System.Nullable<long> ChannelId { get; set; } 

        /// <summary>Indicates if this option is being negatively targeted. For advertiser level assigned targeting
        /// option, this field must be true.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("negative")]
        public virtual System.Nullable<bool> Negative { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Settings for advertisers that use both Campaign Manager (CM) and third-party ad servers.</summary>
    public class CmHybridConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Immutable. Account ID of the CM Floodlight configuration linked with the DV360
        /// advertiser.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cmAccountId")]
        public virtual System.Nullable<long> CmAccountId { get; set; } 

        /// <summary>Required. Immutable. ID of the CM Floodlight configuration linked with the DV360
        /// advertiser.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cmFloodlightConfigId")]
        public virtual System.Nullable<long> CmFloodlightConfigId { get; set; } 

        /// <summary>Required. Immutable. By setting this field to `true`, you, on behalf of your company, authorize the
        /// sharing of information from the given Floodlight configuration to this Display & Video 360
        /// advertiser.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cmFloodlightLinkingAuthorized")]
        public virtual System.Nullable<bool> CmFloodlightLinkingAuthorized { get; set; } 

        /// <summary>A list of CM sites whose placements will be synced to DV360 as creatives. If absent or empty in
        /// CreateAdvertiser method, the system will automatically create a CM site. Removing sites from this list may
        /// cause DV360 creatives synced from CM to be deleted. At least one site must be specified.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cmSyncableSiteIds")]
        public virtual System.Collections.Generic.IList<System.Nullable<long>> CmSyncableSiteIds { get; set; } 

        /// <summary>Whether or not to report DV360 cost to CM.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dv360ToCmCostReportingEnabled")]
        public virtual System.Nullable<bool> Dv360ToCmCostReportingEnabled { get; set; } 

        /// <summary>Whether or not to include DV360 data in CM data transfer reports.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dv360ToCmDataSharingEnabled")]
        public virtual System.Nullable<bool> Dv360ToCmDataSharingEnabled { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A Campaign Manager tracking ad.</summary>
    public class CmTrackingAd : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ad ID of the campaign manager tracking Ad.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cmAdId")]
        public virtual System.Nullable<long> CmAdId { get; set; } 

        /// <summary>The creative ID of the campaign manager tracking Ad.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cmCreativeId")]
        public virtual System.Nullable<long> CmCreativeId { get; set; } 

        /// <summary>The placement ID of the campaign manager tracking Ad.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cmPlacementId")]
        public virtual System.Nullable<long> CmPlacementId { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Describes a combined audience resource.</summary>
    public class CombinedAudience : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The unique ID of the combined audience. Assigned by the system.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("combinedAudienceId")]
        public virtual System.Nullable<long> CombinedAudienceId { get; set; } 

        /// <summary>Output only. The display name of the combined audience. .</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; } 

        /// <summary>Output only. The resource name of the combined audience.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Details of combined audience group. All combined audience targeting settings are logically ‘OR’ of each
    /// other.</summary>
    public class CombinedAudienceGroup : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. All combined audience targeting settings in combined audience group. Repeated settings
        /// with same id will be ignored. The number of combined audience settings should be no more than five, error
        /// will be thrown otherwise.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("settings")]
        public virtual System.Collections.Generic.IList<CombinedAudienceTargetingSetting> Settings { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Details of combined audience targeting setting.</summary>
    public class CombinedAudienceTargetingSetting : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Combined audience id of combined audience targeting setting. This id is
        /// combined_audience_id.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("combinedAudienceId")]
        public virtual System.Nullable<long> CombinedAudienceId { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Assigned content instream position targeting option details. This will be populated in the
    /// content_instream_position_details field when targeting_type is
    /// `TARGETING_TYPE_CONTENT_INSTREAM_POSITION`.</summary>
    public class ContentInstreamPositionAssignedTargetingOptionDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The content instream position for video or audio ads.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contentInstreamPosition")]
        public virtual string ContentInstreamPosition { get; set; } 

        /// <summary>Required. The targeting_option_id field when targeting_type is
        /// `TARGETING_TYPE_CONTENT_INSTREAM_POSITION`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetingOptionId")]
        public virtual string TargetingOptionId { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Represents a targetable content instream position, which could be used by video and audio ads. This
    /// will be populated in the content_instream_position_details field when targeting_type is
    /// `TARGETING_TYPE_CONTENT_INSTREAM_POSITION`.</summary>
    public class ContentInstreamPositionTargetingOptionDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The content instream position.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contentInstreamPosition")]
        public virtual string ContentInstreamPosition { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Assigned content outstream position targeting option details. This will be populated in the
    /// content_outstream_position_details field when targeting_type is
    /// `TARGETING_TYPE_CONTENT_OUTSTREAM_POSITION`.</summary>
    public class ContentOutstreamPositionAssignedTargetingOptionDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The content outstream position.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contentOutstreamPosition")]
        public virtual string ContentOutstreamPosition { get; set; } 

        /// <summary>Required. The targeting_option_id field when targeting_type is
        /// `TARGETING_TYPE_CONTENT_OUTSTREAM_POSITION`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetingOptionId")]
        public virtual string TargetingOptionId { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Represents a targetable content outstream position, which could be used by display and video ads. This
    /// will be populated in the content_outstream_position_details field when targeting_type is
    /// `TARGETING_TYPE_CONTENT_OUTSTREAM_POSITION`.</summary>
    public class ContentOutstreamPositionTargetingOptionDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The content outstream position.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contentOutstreamPosition")]
        public virtual string ContentOutstreamPosition { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Settings that control how conversions are counted. All post-click conversions will be counted. A
    /// percentage value can be set for post-view conversions counting.</summary>
    public class ConversionCountingConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The Floodlight activity configs used to track conversions. The number of conversions counted is the
        /// sum of all of the conversions counted by all of the Floodlight activity IDs specified in this
        /// field.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("floodlightActivityConfigs")]
        public virtual System.Collections.Generic.IList<TrackingFloodlightActivityConfig> FloodlightActivityConfigs { get; set; } 

        /// <summary>The percentage of post-view conversions to count, in millis (1/1000 of a percent). Must be between
        /// 0 and 100000 inclusive. For example, to track 50% of the post-click conversions, set a value of
        /// 50000.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("postViewCountPercentageMillis")]
        public virtual System.Nullable<long> PostViewCountPercentageMillis { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Counter event of the creative.</summary>
    public class CounterEvent : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The name of the counter event.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; } 

        /// <summary>Required. The name used to identify this counter event in reports.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reportingName")]
        public virtual string ReportingName { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A request message for CreateAsset.</summary>
    public class CreateAssetRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The filename of the asset, including the file extension. The filename must be UTF-8
        /// encoded with a maximum size of 240 bytes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filename")]
        public virtual string Filename { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A response message for CreateAsset.</summary>
    public class CreateAssetResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The uploaded asset, if successful.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("asset")]
        public virtual Asset Asset { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A request listing which assigned targeting options of a given targeting type should be created and
    /// added.</summary>
    public class CreateAssignedTargetingOptionsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The assigned targeting options to create and add.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("assignedTargetingOptions")]
        public virtual System.Collections.Generic.IList<AssignedTargetingOption> AssignedTargetingOptions { get; set; } 

        /// <summary>Required. Identifies the type of this assigned targeting option.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetingType")]
        public virtual string TargetingType { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Request message for [SdfDownloadTaskService.CreateSdfDownloadTask].</summary>
    public class CreateSdfDownloadTaskRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ID of the advertiser to download SDF for.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("advertiserId")]
        public virtual System.Nullable<long> AdvertiserId { get; set; } 

        /// <summary>Filters on entities by their entity IDs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("idFilter")]
        public virtual IdFilter IdFilter { get; set; } 

        /// <summary>Filters on Inventory Sources by their IDs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inventorySourceFilter")]
        public virtual InventorySourceFilter InventorySourceFilter { get; set; } 

        /// <summary>Filters on selected file types. The entities in each file are filtered by a chosen set of filter
        /// entities. The filter entities must be the same type as, or a parent type of, the selected file
        /// types.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parentEntityFilter")]
        public virtual ParentEntityFilter ParentEntityFilter { get; set; } 

        /// <summary>The ID of the partner to download SDF for.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("partnerId")]
        public virtual System.Nullable<long> PartnerId { get; set; } 

        /// <summary>Required. The SDF version of the downloaded file. If set to `SDF_VERSION_UNSPECIFIED`, this will
        /// default to the version specified by the advertiser or partner identified by `root_id`. An advertiser
        /// inherits its SDF version from its partner unless configured otherwise.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual string Version { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A single Creative.</summary>
    public class Creative : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Additional dimensions. Applicable when creative_type is one of: * `CREATIVE_TYPE_STANDARD` *
        /// `CREATIVE_TYPE_EXPANDABLE` * `CREATIVE_TYPE_NATIVE` * `CREATIVE_TYPE_TEMPLATED_APP_INSTALL` *
        /// `CREATIVE_TYPE_NATIVE_SITE_SQUARE` * `CREATIVE_TYPE_LIGHTBOX` * `CREATIVE_TYPE_NATIVE_APP_INSTALL` *
        /// `CREATIVE_TYPE_NATIVE_APP_INSTALL_SQUARE` * `CREATIVE_TYPE_PUBLISHER_HOSTED` If this field is specified,
        /// width_pixels and height_pixels are both required and must be greater than or equal to 0.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("additionalDimensions")]
        public virtual System.Collections.Generic.IList<Dimensions> AdditionalDimensions { get; set; } 

        /// <summary>Output only. The unique ID of the advertiser the creative belongs to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("advertiserId")]
        public virtual System.Nullable<long> AdvertiserId { get; set; } 

        /// <summary>Third-party HTML tracking tag to be appended to the creative tag.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("appendedTag")]
        public virtual string AppendedTag { get; set; } 

        /// <summary>Required. Assets associated to this creative. Assets can be associated to the creative in one of
        /// following roles: * `ASSET_ROLE_UNSPECIFIED` * `ASSET_ROLE_MAIN` * `ASSET_ROLE_BACKUP` *
        /// `ASSET_ROLE_POLITE_LOAD`</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("assets")]
        public virtual System.Collections.Generic.IList<AssetAssociation> Assets { get; set; } 

        /// <summary>Output only. The unique ID of the Campaign Manager placement associated with the creative. This
        /// field is only applicable for creatives that are synced from Campaign Manager.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cmPlacementId")]
        public virtual System.Nullable<long> CmPlacementId { get; set; } 

        /// <summary>The Campaign Manager tracking ad associated with the creative. Optional for the following
        /// creative_type when created by an advertiser that uses both Campaign Manager and third-party ad serving: *
        /// `CREATIVE_TYPE_NATIVE` * `CREATIVE_TYPE_NATIVE_SITE_SQUARE` * `CREATIVE_TYPE_NATIVE_APP_INSTALL` *
        /// `CREATIVE_TYPE_NATIVE_APP_INSTALL_SQUARE` Output only for other cases.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cmTrackingAd")]
        public virtual CmTrackingAd CmTrackingAd { get; set; } 

        /// <summary>The IDs of companion creatives for a video creative. You can assign existing display creatives
        /// (with image or HTML5 assets) to serve surrounding the publisher's video player. Companions display around
        /// the video player while the video is playing and remain after the video has completed. Creatives contain
        /// additional dimensions can not be companion creatives. This field is only supported for following
        /// creative_type: * `CREATIVE_TYPE_AUDIO` * `CREATIVE_TYPE_VIDEO`</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("companionCreativeIds")]
        public virtual System.Collections.Generic.IList<System.Nullable<long>> CompanionCreativeIds { get; set; } 

        /// <summary>Counter events for a rich media creative. Counters track the number of times that a user interacts
        /// with any part of a rich media creative in a specified way (mouse-overs, mouse-outs, clicks, taps, data
        /// loading, keyboard entries, etc.). Any event that can be captured in the creative can be recorded as a
        /// counter. Leave it empty or unset for creatives containing image assets only.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("counterEvents")]
        public virtual System.Collections.Generic.IList<CounterEvent> CounterEvents { get; set; } 

        /// <summary>Output only. The timestamp when the creative was created. Assigned by the system.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; } 

        /// <summary>Output only. A list of attributes of the creative that is generated by the system.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("creativeAttributes")]
        public virtual System.Collections.Generic.IList<string> CreativeAttributes { get; set; } 

        /// <summary>Output only. The unique ID of the creative. Assigned by the system.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("creativeId")]
        public virtual System.Nullable<long> CreativeId { get; set; } 

        /// <summary>Required. Immutable. The type of the creative.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("creativeType")]
        public virtual string CreativeType { get; set; } 

        /// <summary>Required. Primary dimensions of the creative. Applicable to all creative types. The value of
        /// width_pixels and height_pixels defaults to `0` when creative_type is one of: * `CREATIVE_TYPE_VIDEO` *
        /// `CREATIVE_TYPE_TEMPLATED_APP_INSTALL_INTERSTITIAL` * `CREATIVE_TYPE_AUDIO` * `CREATIVE_TYPE_NATIVE_VIDEO` *
        /// `CREATIVE_TYPE_TEMPLATED_APP_INSTALL_VIDEO`</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dimensions")]
        public virtual Dimensions Dimensions { get; set; } 

        /// <summary>Required. The display name of the creative. Must be UTF-8 encoded with a maximum size of 240
        /// bytes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; } 

        /// <summary>Output only. Indicates whether the creative is dynamic.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dynamic")]
        public virtual System.Nullable<bool> Dynamic { get; set; } 

        /// <summary>Required. Controls whether or not the creative can serve. Accepted values are: *
        /// `ENTITY_STATUS_ACTIVE` * `ENTITY_STATUS_ARCHIVED` * `ENTITY_STATUS_PAUSED`</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entityStatus")]
        public virtual string EntityStatus { get; set; } 

        /// <summary>Required. Exit events for this creative. An exit (also known as a click tag) is any area in your
        /// creative that someone can click or tap to open an advertiser's landing page. Every creative must include at
        /// least one exit. You can add an exit to your creative in any of the following ways: * Use Google Web
        /// Designer's tap area. * Define a JavaScript variable called "clickTag". * Use the Enabler (Enabler.exit()) to
        /// track exits in rich media formats.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exitEvents")]
        public virtual System.Collections.Generic.IList<ExitEvent> ExitEvents { get; set; } 

        /// <summary>Optional. Indicates the creative will automatically expand on hover. Optional and only valid for
        /// third-party expandable creatives. Third-party expandable creatives are creatives with following hosting
        /// source: * `HOSTING_SOURCE_THIRD_PARTY` combined with following creative_type: *
        /// `CREATIVE_TYPE_EXPANDABLE`</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expandOnHover")]
        public virtual System.Nullable<bool> ExpandOnHover { get; set; } 

        /// <summary>Optional. Specifies the expanding direction of the creative. Required and only valid for third-
        /// party expandable creatives. Third-party expandable creatives are creatives with following hosting source: *
        /// `HOSTING_SOURCE_THIRD_PARTY` combined with following creative_type: * `CREATIVE_TYPE_EXPANDABLE`</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expandingDirection")]
        public virtual string ExpandingDirection { get; set; } 

        /// <summary>Required. Indicates where the creative is hosted.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hostingSource")]
        public virtual string HostingSource { get; set; } 

        /// <summary>Output only. Indicates the third-party VAST tag creative requires HTML5 Video support. Output only
        /// and only valid for third-party VAST tag creatives. Third-party VAST tag creatives are creatives with
        /// following hosting_source: * `HOSTING_SOURCE_THIRD_PARTY` combined with following creative_type: *
        /// `CREATIVE_TYPE_VIDEO`</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("html5Video")]
        public virtual System.Nullable<bool> Html5Video { get; set; } 

        /// <summary>Indicates whether Integral Ad Science (IAS) campaign monitoring is enabled. To enable this for the
        /// creative, make sure the Advertiser.creative_config.ias_client_id has been set to your IAS client
        /// ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("iasCampaignMonitoring")]
        public virtual System.Nullable<bool> IasCampaignMonitoring { get; set; } 

        /// <summary>ID information used to link this creative to an external system. Must be UTF-8 encoded with a
        /// length of no more than 10,000 characters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("integrationCode")]
        public virtual string IntegrationCode { get; set; } 

        /// <summary>JavaScript measurement URL from supported third-party verification providers (ComScore,
        /// DoubleVerify, IAS, Moat). HTML script tags are not supported. This field is only supported in following
        /// creative_type: * `CREATIVE_TYPE_NATIVE` * `CREATIVE_TYPE_NATIVE_SITE_SQUARE` *
        /// `CREATIVE_TYPE_NATIVE_APP_INSTALL` * `CREATIVE_TYPE_NATIVE_APP_INSTALL_SQUARE` *
        /// `CREATIVE_TYPE_NATIVE_VIDEO`</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("jsTrackerUrl")]
        public virtual string JsTrackerUrl { get; set; } 

        /// <summary>Output only. The IDs of the line items this creative is associated with. To associate a creative to
        /// a line item, use LineItem.creative_ids instead.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lineItemIds")]
        public virtual System.Collections.Generic.IList<System.Nullable<long>> LineItemIds { get; set; } 

        /// <summary>Output only. Media duration of the creative. Applicable when creative_type is one of: *
        /// `CREATIVE_TYPE_VIDEO` * `CREATIVE_TYPE_AUDIO` * `CREATIVE_TYPE_NATIVE_VIDEO` *
        /// `CREATIVE_TYPE_PUBLISHER_HOSTED`</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mediaDuration")]
        public virtual object MediaDuration { get; set; } 

        /// <summary>Output only. The resource name of the creative.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; } 

        /// <summary>User notes for this creative. Must be UTF-8 encoded with a length of no more than 20,000
        /// characters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("notes")]
        public virtual string Notes { get; set; } 

        /// <summary>Specifies the OBA icon for a video creative. This field is only supported in following
        /// creative_type: * `CREATIVE_TYPE_VIDEO`</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("obaIcon")]
        public virtual ObaIcon ObaIcon { get; set; } 

        /// <summary>Amount of time to play the video before counting a view. This field is required when skippable is
        /// true. This field is only supported for the following creative_type: * `CREATIVE_TYPE_VIDEO`</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("progressOffset")]
        public virtual AudioVideoOffset ProgressOffset { get; set; } 

        /// <summary>Optional. Indicates that the creative relies on HTML5 to render properly. Optional and only valid
        /// for third-party tag creatives. Third-party tag creatives are creatives with following hosting_source: *
        /// `HOSTING_SOURCE_THIRD_PARTY` combined with following creative_type: * `CREATIVE_TYPE_STANDARD` *
        /// `CREATIVE_TYPE_EXPANDABLE`</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requireHtml5")]
        public virtual System.Nullable<bool> RequireHtml5 { get; set; } 

        /// <summary>Optional. Indicates that the creative requires MRAID (Mobile Rich Media Ad Interface Definitions
        /// system). Set this if the creative relies on mobile gestures for interactivity, such as swiping or tapping.
        /// Optional and only valid for third-party tag creatives. Third-party tag creatives are creatives with
        /// following hosting_source: * `HOSTING_SOURCE_THIRD_PARTY` combined with following creative_type: *
        /// `CREATIVE_TYPE_STANDARD` * `CREATIVE_TYPE_EXPANDABLE`</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requireMraid")]
        public virtual System.Nullable<bool> RequireMraid { get; set; } 

        /// <summary>Optional. Indicates that the creative will wait for a return ping for attribution. Only valid when
        /// using a Campaign Manager tracking ad with a third-party ad server parameter and the ${DC_DBM_TOKEN} macro.
        /// Optional and only valid for third-party tag creatives or third-party VAST tag creatives. Third-party tag
        /// creatives are creatives with following hosting_source: * `HOSTING_SOURCE_THIRD_PARTY` combined with
        /// following creative_type: * `CREATIVE_TYPE_STANDARD` * `CREATIVE_TYPE_EXPANDABLE` Third-party VAST tag
        /// creatives are creatives with following hosting_source: * `HOSTING_SOURCE_THIRD_PARTY` combined with
        /// following creative_type: * `CREATIVE_TYPE_VIDEO`</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requirePingForAttribution")]
        public virtual System.Nullable<bool> RequirePingForAttribution { get; set; } 

        /// <summary>Output only. The current status of the creative review process.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reviewStatus")]
        public virtual ReviewStatusInfo ReviewStatus { get; set; } 

        /// <summary>Amount of time to play the video before the skip button appears. This field is required when
        /// skippable is true. This field is only supported for the following creative_type: *
        /// `CREATIVE_TYPE_VIDEO`</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("skipOffset")]
        public virtual AudioVideoOffset SkipOffset { get; set; } 

        /// <summary>Whether the user can choose to skip a video creative. This field is only supported for the
        /// following creative_type: * `CREATIVE_TYPE_VIDEO`</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("skippable")]
        public virtual System.Nullable<bool> Skippable { get; set; } 

        /// <summary>Optional. The original third-party tag used for the creative. Required and only valid for third-
        /// party tag creatives. Third-party tag creatives are creatives with following hosting_source: *
        /// `HOSTING_SOURCE_THIRD_PARTY` combined with following creative_type: * `CREATIVE_TYPE_STANDARD` *
        /// `CREATIVE_TYPE_EXPANDABLE`</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("thirdPartyTag")]
        public virtual string ThirdPartyTag { get; set; } 

        /// <summary>Tracking URLs from third parties to track interactions with a video creative. This field is only
        /// supported for the following creative_type: * `CREATIVE_TYPE_AUDIO` * `CREATIVE_TYPE_VIDEO` *
        /// `CREATIVE_TYPE_NATIVE_VIDEO`</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("thirdPartyUrls")]
        public virtual System.Collections.Generic.IList<ThirdPartyUrl> ThirdPartyUrls { get; set; } 

        /// <summary>Timer custom events for a rich media creative. Timers track the time during which a user views and
        /// interacts with a specified part of a rich media creative. A creative can have multiple timer events, each
        /// timed independently. Leave it empty or unset for creatives containing image assets only.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timerEvents")]
        public virtual System.Collections.Generic.IList<TimerEvent> TimerEvents { get; set; } 

        /// <summary>Tracking URLs for analytics providers or third-party ad technology vendors. The URLs must start
        /// with https (except on inventory that doesn't require SSL compliance). If using macros in your URL, use only
        /// macros supported by Display & Video 360. Standard URLs only, no IMG or SCRIPT tags. This field is only
        /// supported in following creative_type: * `CREATIVE_TYPE_NATIVE` * `CREATIVE_TYPE_NATIVE_SITE_SQUARE` *
        /// `CREATIVE_TYPE_NATIVE_APP_INSTALL` * `CREATIVE_TYPE_NATIVE_APP_INSTALL_SQUARE` *
        /// `CREATIVE_TYPE_NATIVE_VIDEO`</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("trackerUrls")]
        public virtual System.Collections.Generic.IList<string> TrackerUrls { get; set; } 

        /// <summary>Output only. Audio/Video transcodes. Display & Video 360 transcodes the main asset into a number of
        /// alternative versions that use different file formats or have different properties (resolution, audio bit
        /// rate, and video bit rate), each designed for specific video players or bandwidths. These transcodes give a
        /// publisher's system more options to choose from for each impression on your video and ensures that the
        /// appropriate file serves based on the viewer’s connection and screen size. This field is only supported in
        /// following creative_type: * `CREATIVE_TYPE_VIDEO` * `CREATIVE_TYPE_NATIVE_VIDEO` *
        /// `CREATIVE_TYPE_AUDIO`</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("transcodes")]
        public virtual System.Collections.Generic.IList<Transcode> Transcodes { get; set; } 

        /// <summary>Optional. An optional creative identifier provided by a registry that is unique across all
        /// platforms. Universal Ad ID is part of the VAST 4.0 standard. It can be modified after the creative is
        /// created. This field is only supported for the following creative_type: * `CREATIVE_TYPE_VIDEO`</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("universalAdId")]
        public virtual UniversalAdId UniversalAdId { get; set; } 

        /// <summary>Output only. The timestamp when the creative was last updated. Assigned by the system.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; } 

        /// <summary>Optional. The URL of the VAST tag for a third-party VAST tag creative. Required and only valid for
        /// third-party VAST tag creatives. Third-party VAST tag creatives are creatives with following hosting_source:
        /// * `HOSTING_SOURCE_THIRD_PARTY` combined with following creative_type: * `CREATIVE_TYPE_VIDEO`</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vastTagUrl")]
        public virtual string VastTagUrl { get; set; } 

        /// <summary>Output only. Indicates the third-party VAST tag creative requires VPAID (Digital Video Player-Ad
        /// Interface). Output only and only valid for third-party VAST tag creatives. Third-party VAST tag creatives
        /// are creatives with following hosting_source: * `HOSTING_SOURCE_THIRD_PARTY` combined with following
        /// creative_type: * `CREATIVE_TYPE_VIDEO`</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vpaid")]
        public virtual System.Nullable<bool> Vpaid { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Creative requirements configuration for the inventory source.</summary>
    public class CreativeConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The type of creative that can be assigned to the inventory source.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("creativeType")]
        public virtual string CreativeType { get; set; } 

        /// <summary>The configuration for display creatives. Applicable when creative_type is
        /// `CREATIVE_TYPE_STANDARD`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayCreativeConfig")]
        public virtual InventorySourceDisplayCreativeConfig DisplayCreativeConfig { get; set; } 

        /// <summary>The configuration for video creatives. Applicable when creative_type is
        /// `CREATIVE_TYPE_VIDEO`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("videoCreativeConfig")]
        public virtual InventorySourceVideoCreativeConfig VideoCreativeConfig { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A single custom bidding algorithm.</summary>
    public class CustomBiddingAlgorithm : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Immutable. The unique ID of the advertiser that owns the custom bidding algorithm.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("advertiserId")]
        public virtual System.Nullable<long> AdvertiserId { get; set; } 

        /// <summary>Output only. The unique ID of the custom bidding algorithm. Assigned by the system.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customBiddingAlgorithmId")]
        public virtual System.Nullable<long> CustomBiddingAlgorithmId { get; set; } 

        /// <summary>Required. Immutable. The type of custom bidding algorithm.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customBiddingAlgorithmType")]
        public virtual string CustomBiddingAlgorithmType { get; set; } 

        /// <summary>Required. The display name of the custom bidding algorithm. Must be UTF-8 encoded with a maximum
        /// size of 240 bytes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; } 

        /// <summary>Controls whether or not the custom bidding algorithm can be used as a bidding strategy. Accepted
        /// values are: * `ENTITY_STATUS_ACTIVE` * `ENTITY_STATUS_ARCHIVED`</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entityStatus")]
        public virtual string EntityStatus { get; set; } 

        /// <summary>Output only. The resource name of the custom bidding algorithm.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; } 

        /// <summary>Immutable. The unique ID of the partner that owns the custom bidding algorithm.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("partnerId")]
        public virtual System.Nullable<long> PartnerId { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Describes a custom list entity, such as a custom affinity or custom intent audience list.</summary>
    public class CustomList : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The unique ID of the custom list. Assigned by the system.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customListId")]
        public virtual System.Nullable<long> CustomListId { get; set; } 

        /// <summary>Output only. The display name of the custom list. .</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; } 

        /// <summary>Output only. The resource name of the custom list.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Details of custom list group. All custom list targeting settings are logically ‘OR’ of each
    /// other.</summary>
    public class CustomListGroup : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. All custom list targeting settings in custom list group. Repeated settings with same id
        /// will be ignored.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("settings")]
        public virtual System.Collections.Generic.IList<CustomListTargetingSetting> Settings { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Details of custom list targeting setting.</summary>
    public class CustomListTargetingSetting : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Custom id of custom list targeting setting. This id is custom_list_id.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customListId")]
        public virtual System.Nullable<long> CustomListId { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Represents a whole or partial calendar date, e.g. a birthday. The time of day and time zone are either
    /// specified elsewhere or are not significant. The date is relative to the Proleptic Gregorian Calendar. This can
    /// represent: * A full date, with non-zero year, month and day values * A month and day value, with a zero year,
    /// e.g. an anniversary * A year on its own, with zero month and day values * A year and month value, with a zero
    /// day, e.g. a credit card expiration date Related types are google.type.TimeOfDay and
    /// `google.protobuf.Timestamp`.</summary>
    public class Date : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Day of month. Must be from 1 to 31 and valid for the year and month, or 0 if specifying a year by
        /// itself or a year and month where the day is not significant.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("day")]
        public virtual System.Nullable<int> Day { get; set; } 

        /// <summary>Month of year. Must be from 1 to 12, or 0 if specifying a year without a month and day.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("month")]
        public virtual System.Nullable<int> Month { get; set; } 

        /// <summary>Year of date. Must be from 1 to 9999, or 0 if specifying a date without a year.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("year")]
        public virtual System.Nullable<int> Year { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A date range.</summary>
    public class DateRange : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The upper bound of the date range, inclusive. Must specify a positive value for `year`, `month`,
        /// and `day`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endDate")]
        public virtual Date EndDate { get; set; } 

        /// <summary>The lower bound of the date range, inclusive. Must specify a positive value for `year`, `month`,
        /// and `day`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startDate")]
        public virtual Date StartDate { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Representation of a segment of time defined on a specific day of the week and with a start and end
    /// time. The time represented by `start_hour` must be before the time represented by `end_hour`.</summary>
    public class DayAndTimeAssignedTargetingOptionDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The day of the week for this day and time targeting setting.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dayOfWeek")]
        public virtual string DayOfWeek { get; set; } 

        /// <summary>Required. The end hour for day and time targeting. Must be between 1 (1 hour after start of day)
        /// and 24 (end of day).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endHour")]
        public virtual System.Nullable<int> EndHour { get; set; } 

        /// <summary>Required. The start hour for day and time targeting. Must be between 0 (start of day) and 23 (1
        /// hour before end of day).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startHour")]
        public virtual System.Nullable<int> StartHour { get; set; } 

        /// <summary>Required. The mechanism used to determine which timezone to use for this day and time targeting
        /// setting.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeZoneResolution")]
        public virtual string TimeZoneResolution { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A request listing which assigned targeting options of a given targeting type should be
    /// deleted.</summary>
    public class DeleteAssignedTargetingOptionsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The assigned targeting option IDs to delete.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("assignedTargetingOptionIds")]
        public virtual System.Collections.Generic.IList<string> AssignedTargetingOptionIds { get; set; } 

        /// <summary>Required. Identifies the type of this assigned targeting option.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetingType")]
        public virtual string TargetingType { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Assigned device make and model targeting option details. This will be populated in the
    /// device_make_model_details field when targeting_type is `TARGETING_TYPE_DEVICE_MAKE_MODEL`.</summary>
    public class DeviceMakeModelAssignedTargetingOptionDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The display name of the device make and model.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; } 

        /// <summary>Indicates if this option is being negatively targeted.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("negative")]
        public virtual System.Nullable<bool> Negative { get; set; } 

        /// <summary>Required. The targeting_option_id field when targeting_type is
        /// `TARGETING_TYPE_DEVICE_MAKE_MODEL`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetingOptionId")]
        public virtual string TargetingOptionId { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Represents a targetable device make and model. This will be populated in the device_make_model_details
    /// field of a TargetingOption when targeting_type is `TARGETING_TYPE_DEVICE_MAKE_MODEL`.</summary>
    public class DeviceMakeModelTargetingOptionDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The display name of the device make and model.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Targeting details for device type. This will be populated in the details field of an
    /// AssignedTargetingOption when targeting_type is `TARGETING_TYPE_DEVICE_TYPE`.</summary>
    public class DeviceTypeAssignedTargetingOptionDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The display name of the device type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deviceType")]
        public virtual string DeviceType { get; set; } 

        /// <summary>Required. ID of the device type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetingOptionId")]
        public virtual string TargetingOptionId { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Represents a targetable device type. This will be populated in the device_type_details field of a
    /// TargetingOption when targeting_type is `TARGETING_TYPE_DEVICE_TYPE`.</summary>
    public class DeviceTypeTargetingOptionDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The device type that is used to be targeted.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deviceType")]
        public virtual string DeviceType { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Targeting details for digital content label. This will be populated in the details field of an
    /// AssignedTargetingOption when targeting_type is `TARGETING_TYPE_DIGITAL_CONTENT_LABEL_EXCLUSION`.</summary>
    public class DigitalContentLabelAssignedTargetingOptionDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The display name of the digital content label rating tier.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contentRatingTier")]
        public virtual string ContentRatingTier { get; set; } 

        /// <summary>Required. ID of the digital content label to be EXCLUDED.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("excludedTargetingOptionId")]
        public virtual string ExcludedTargetingOptionId { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Represents a targetable digital content label rating tier. This will be populated in the
    /// digital_content_label_details field of the TargetingOption when targeting_type is
    /// `TARGETING_TYPE_DIGITAL_CONTENT_LABEL_EXCLUSION`.</summary>
    public class DigitalContentLabelTargetingOptionDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. An enum for the content label brand safety tiers.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contentRatingTier")]
        public virtual string ContentRatingTier { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Dimensions.</summary>
    public class Dimensions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The height in pixels.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("heightPixels")]
        public virtual System.Nullable<int> HeightPixels { get; set; } 

        /// <summary>The width in pixels.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("widthPixels")]
        public virtual System.Nullable<int> WidthPixels { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Details of DoubleVerify settings.</summary>
    public class DoubleVerify : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Avoid bidding on apps with the star ratings.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("appStarRating")]
        public virtual DoubleVerifyAppStarRating AppStarRating { get; set; } 

        /// <summary>Avoid bidding on apps with the age rating.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("avoidedAgeRatings")]
        public virtual System.Collections.Generic.IList<string> AvoidedAgeRatings { get; set; } 

        /// <summary>DV Brand Safety Controls.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("brandSafetyCategories")]
        public virtual DoubleVerifyBrandSafetyCategories BrandSafetyCategories { get; set; } 

        /// <summary>Display viewability settings (applicable to display line items only).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayViewability")]
        public virtual DoubleVerifyDisplayViewability DisplayViewability { get; set; } 

        /// <summary>Avoid Sites and Apps with historical Fraud & IVT Rates.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fraudInvalidTraffic")]
        public virtual DoubleVerifyFraudInvalidTraffic FraudInvalidTraffic { get; set; } 

        /// <summary>Video viewability settings (applicable to video line items only).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("videoViewability")]
        public virtual DoubleVerifyVideoViewability VideoViewability { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Details of DoubleVerify star ratings settings.</summary>
    public class DoubleVerifyAppStarRating : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Avoid bidding on apps with insufficient star ratings.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("avoidInsufficientStarRating")]
        public virtual System.Nullable<bool> AvoidInsufficientStarRating { get; set; } 

        /// <summary>Avoid bidding on apps with the star ratings.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("avoidedStarRating")]
        public virtual string AvoidedStarRating { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Settings for brand safety controls.</summary>
    public class DoubleVerifyBrandSafetyCategories : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Unknown or unrateable.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("avoidUnknownBrandSafetyCategory")]
        public virtual System.Nullable<bool> AvoidUnknownBrandSafetyCategory { get; set; } 

        /// <summary>Brand safety high severity avoidance categories.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("avoidedHighSeverityCategories")]
        public virtual System.Collections.Generic.IList<string> AvoidedHighSeverityCategories { get; set; } 

        /// <summary>Brand safety medium severity avoidance categories.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("avoidedMediumSeverityCategories")]
        public virtual System.Collections.Generic.IList<string> AvoidedMediumSeverityCategories { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Details of DoubleVerify display viewability settings.</summary>
    public class DoubleVerifyDisplayViewability : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Target web and app inventory to maximize IAB viewable rate.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("iab")]
        public virtual string Iab { get; set; } 

        /// <summary>Target web and app inventory to maximize 100% viewable duration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("viewableDuring")]
        public virtual string ViewableDuring { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>DoubleVerify Fraud & Invalid Traffic settings.</summary>
    public class DoubleVerifyFraudInvalidTraffic : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Insufficient Historical Fraud & IVT Stats.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("avoidInsufficientOption")]
        public virtual System.Nullable<bool> AvoidInsufficientOption { get; set; } 

        /// <summary>Avoid Sites and Apps with historical Fraud & IVT.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("avoidedFraudOption")]
        public virtual string AvoidedFraudOption { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Details of DoubleVerify video viewability settings.</summary>
    public class DoubleVerifyVideoViewability : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Target inventory to maximize impressions with 400x300 or greater player size.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("playerImpressionRate")]
        public virtual string PlayerImpressionRate { get; set; } 

        /// <summary>Target web inventory to maximize IAB viewable rate.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("videoIab")]
        public virtual string VideoIab { get; set; } 

        /// <summary>Target web inventory to maximize fully viewable rate.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("videoViewableRate")]
        public virtual string VideoViewableRate { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A generic empty message that you can re-use to avoid defining duplicated empty messages in your APIs. A
    /// typical example is to use it as the request or the response type of an API method. For instance: service Foo {
    /// rpc Bar(google.protobuf.Empty) returns (google.protobuf.Empty); } The JSON representation for `Empty` is empty
    /// JSON object `{}`.</summary>
    public class Empty : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Assigned environment targeting option details. This will be populated in the details field of an
    /// AssignedTargetingOption when targeting_type is `TARGETING_TYPE_ENVIRONMENT`.</summary>
    public class EnvironmentAssignedTargetingOptionDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The serving environment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("environment")]
        public virtual string Environment { get; set; } 

        /// <summary>Required. The targeting_option_id of a TargetingOption of type `TARGETING_TYPE_ENVIRONMENT` (e.g.,
        /// "508010" for targeting the `ENVIRONMENT_WEB_OPTIMIZED` option).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetingOptionId")]
        public virtual string TargetingOptionId { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Represents a targetable environment. This will be populated in the environment_details field of a
    /// TargetingOption when targeting_type is `TARGETING_TYPE_ENVIRONMENT`.</summary>
    public class EnvironmentTargetingOptionDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The serving environment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("environment")]
        public virtual string Environment { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Details for assigned exchange targeting option. This will be populated in the details field of an
    /// AssignedTargetingOption when targeting_type is `TARGETING_TYPE_EXCHANGE`.</summary>
    public class ExchangeAssignedTargetingOptionDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The targeting_option_id of a TargetingOption of type `TARGETING_TYPE_EXCHANGE`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetingOptionId")]
        public virtual string TargetingOptionId { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Settings that control which exchanges are enabled for a partner.</summary>
    public class ExchangeConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>All enabled exchanges in the partner. Duplicate enabled exchanges will be ignored.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enabledExchanges")]
        public virtual System.Collections.Generic.IList<ExchangeConfigEnabledExchange> EnabledExchanges { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>An enabled exchange in the partner.</summary>
    public class ExchangeConfigEnabledExchange : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The enabled exchange.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exchange")]
        public virtual string Exchange { get; set; } 

        /// <summary>Output only. Agency ID of Google Ad Manager. The field is only relevant when Google Ad Manager is
        /// the enabled exchange.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("googleAdManagerAgencyId")]
        public virtual string GoogleAdManagerAgencyId { get; set; } 

        /// <summary>Output only. Network ID of Google Ad Manager. The field is only relevant when Google Ad Manager is
        /// the enabled exchange.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("googleAdManagerBuyerNetworkId")]
        public virtual string GoogleAdManagerBuyerNetworkId { get; set; } 

        /// <summary>Output only. Seat ID of the enabled exchange.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("seatId")]
        public virtual string SeatId { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Exchange review status for the creative.</summary>
    public class ExchangeReviewStatus : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The exchange reviewing the creative.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exchange")]
        public virtual string Exchange { get; set; } 

        /// <summary>Status of the exchange review.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual string Status { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Represents a targetable exchange. This will be populated in the exchange_details field of a
    /// TargetingOption when targeting_type is `TARGETING_TYPE_EXCHANGE`.</summary>
    public class ExchangeTargetingOptionDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The type of exchange.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exchange")]
        public virtual string Exchange { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Exit event of the creative.</summary>
    public class ExitEvent : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The name of the click tag of the exit event. The name must be unique within one creative. Leave it
        /// empty or unset for creatives containing image assets only.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; } 

        /// <summary>The name used to identify this event in reports. Leave it empty or unset for creatives containing
        /// image assets only.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reportingName")]
        public virtual string ReportingName { get; set; } 

        /// <summary>Required. The type of the exit event.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; } 

        /// <summary>Required. The click through URL of the exit event. This is required when type is: *
        /// `EXIT_EVENT_TYPE_DEFAULT` * `EXIT_EVENT_TYPE_BACKUP`</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("url")]
        public virtual string Url { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Describes a first or third party audience list used for targeting. First party audiences are created
    /// via usage of client data. Third party audiences are provided by Third Party data providers and can only be
    /// licensed to customers.</summary>
    public class FirstAndThirdPartyAudience : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The estimated audience size for the Display network in the past month. If the size is
        /// less than 1000, the number will be hidden and 0 will be returned due to privacy reasons. Otherwise, the
        /// number will be rounded off to two significant digits. Only returned in GET request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("activeDisplayAudienceSize")]
        public virtual System.Nullable<long> ActiveDisplayAudienceSize { get; set; } 

        /// <summary>Output only. The source of the audience.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("audienceSource")]
        public virtual string AudienceSource { get; set; } 

        /// <summary>Output only. The type of the audience.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("audienceType")]
        public virtual string AudienceType { get; set; } 

        /// <summary>The user-provided description of the audience. Only applicable to first party audiences.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; } 

        /// <summary>Output only. The estimated audience size for the Display network. If the size is less than 1000,
        /// the number will be hidden and 0 will be returned due to privacy reasons. Otherwise, the number will be
        /// rounded off to two significant digits. Only returned in GET request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayAudienceSize")]
        public virtual System.Nullable<long> DisplayAudienceSize { get; set; } 

        /// <summary>Output only. The estimated desktop audience size in Display network. If the size is less than 1000,
        /// the number will be hidden and 0 will be returned due to privacy reasons. Otherwise, the number will be
        /// rounded off to two significant digits. Only applicable to first party audiences. Only returned in GET
        /// request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayDesktopAudienceSize")]
        public virtual System.Nullable<long> DisplayDesktopAudienceSize { get; set; } 

        /// <summary>Output only. The estimated mobile app audience size in Display network. If the size is less than
        /// 1000, the number will be hidden and 0 will be returned due to privacy reasons. Otherwise, the number will be
        /// rounded off to two significant digits. Only applicable to first party audiences. Only returned in GET
        /// request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayMobileAppAudienceSize")]
        public virtual System.Nullable<long> DisplayMobileAppAudienceSize { get; set; } 

        /// <summary>Output only. The estimated mobile web audience size in Display network. If the size is less than
        /// 1000, the number will be hidden and 0 will be returned due to privacy reasons. Otherwise, the number will be
        /// rounded off to two significant digits. Only applicable to first party audiences. Only returned in GET
        /// request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayMobileWebAudienceSize")]
        public virtual System.Nullable<long> DisplayMobileWebAudienceSize { get; set; } 

        /// <summary>The display name of the first and third party audience.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; } 

        /// <summary>Output only. The unique ID of the first and third party audience. Assigned by the system.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("firstAndThirdPartyAudienceId")]
        public virtual System.Nullable<long> FirstAndThirdPartyAudienceId { get; set; } 

        /// <summary>Output only. Whether the audience is a first or third party audience.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("firstAndThirdPartyAudienceType")]
        public virtual string FirstAndThirdPartyAudienceType { get; set; } 

        /// <summary>Output only. The estimated audience size for Gmail network. If the size is less than 1000, the
        /// number will be hidden and 0 will be returned due to privacy reasons. Otherwise, the number will be rounded
        /// off to two significant digits. Only applicable to first party audiences. Only returned in GET
        /// request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gmailAudienceSize")]
        public virtual System.Nullable<long> GmailAudienceSize { get; set; } 

        /// <summary>The duration in days that an entry remains in the audience after the qualifying event. Only
        /// applicable to first party audiences.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("membershipDurationDays")]
        public virtual System.Nullable<long> MembershipDurationDays { get; set; } 

        /// <summary>Output only. The resource name of the first and third party audience.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; } 

        /// <summary>Output only. The estimated audience size for YouTube network. If the size is less than 1000, the
        /// number will be hidden and 0 will be returned due to privacy reasons. Otherwise, the number will be rounded
        /// off to two significant digits. Only applicable to first party audiences. Only returned in GET
        /// request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("youtubeAudienceSize")]
        public virtual System.Nullable<long> YoutubeAudienceSize { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Details of first and third party audience group. All first and third party audience targeting settings
    /// are logically ‘OR’ of each other.</summary>
    public class FirstAndThirdPartyAudienceGroup : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. All first and third party audience targeting settings in first and third party audience
        /// group. Repeated settings with same id are not allowed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("settings")]
        public virtual System.Collections.Generic.IList<FirstAndThirdPartyAudienceTargetingSetting> Settings { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Details of first and third party audience targeting setting.</summary>
    public class FirstAndThirdPartyAudienceTargetingSetting : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. First and third party audience id of the first and third party audience targeting
        /// setting. This id is first_and_third_party_audience_id.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("firstAndThirdPartyAudienceId")]
        public virtual System.Nullable<long> FirstAndThirdPartyAudienceId { get; set; } 

        /// <summary>The recency of the first and third party audience targeting setting. Only applicable to first party
        /// audiences, otherwise will be ignored. For more info, refer to
        /// https://support.google.com/displayvideo/answer/2949947#recency When unspecified, no recency limit will be
        /// used.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("recency")]
        public virtual string Recency { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A strategy that uses a fixed bidding price.</summary>
    public class FixedBidStrategy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The fixed bid amount, in micros of the advertiser's currency. For insertion order entity,
        /// bid_amount_micros should be set as 0. For line item entity, bid_amount_micros must be greater than or equal
        /// to billable unit of the given currency and smaller than or equal to the upper limit 1000000000. For example,
        /// 1500000 represents 1.5 standard units of the currency.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bidAmountMicros")]
        public virtual System.Nullable<long> BidAmountMicros { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A single Floodlight group.</summary>
    public class FloodlightGroup : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The Active View video viewability metric configuration for the Floodlight group.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("activeViewConfig")]
        public virtual ActiveViewVideoViewabilityMetricConfig ActiveViewConfig { get; set; } 

        /// <summary>User-defined custom variables owned by the Floodlight group. Use custom Floodlight variables to
        /// create reporting data that is tailored to your unique business needs. Custom Floodlight variables use the
        /// keys `U1=`, `U2=`, and so on, and can take any values that you choose to pass to them. You can use them to
        /// track virtually any type of data that you collect about your customers, such as the genre of movie that a
        /// customer purchases, the country to which the item is shipped, and so on. Custom Floodlight variables may not
        /// be used to pass any data that could be used or recognized as personally identifiable information (PII).
        /// Example: `custom_variables { fields { "U1": value { number_value: 123.4 }, "U2": value { string_value:
        /// "MyVariable2" }, "U3": value { string_value: "MyVariable3" } } }` Acceptable values for keys are "U1"
        /// through "U100", inclusive. String values must be less than 64 characters long, and cannot contain the
        /// following characters: `"<>`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customVariables")]
        public virtual System.Collections.Generic.IDictionary<string,object> CustomVariables { get; set; } 

        /// <summary>Required. The display name of the Floodlight group.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; } 

        /// <summary>Output only. The unique ID of the Floodlight group. Assigned by the system.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("floodlightGroupId")]
        public virtual System.Nullable<long> FloodlightGroupId { get; set; } 

        /// <summary>Required. The lookback window for the Floodlight group. Both click_days and impression_days are
        /// required. Acceptable values for both are `0` to `90`, inclusive.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lookbackWindow")]
        public virtual LookbackWindow LookbackWindow { get; set; } 

        /// <summary>Output only. The resource name of the Floodlight group.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; } 

        /// <summary>Required. The web tag type enabled for the Floodlight group.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("webTagType")]
        public virtual string WebTagType { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Settings that control the number of times a user may be shown with the same ad during a given time
    /// period.</summary>
    public class FrequencyCap : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The maximum number of times a user may be shown with the same ad during this period. Must be
        /// greater than 0. Applicable when unlimited is `false`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxImpressions")]
        public virtual System.Nullable<int> MaxImpressions { get; set; } 

        /// <summary>The time unit in which the frequency cap will be applied. Applicable when unlimited is
        /// `false`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeUnit")]
        public virtual string TimeUnit { get; set; } 

        /// <summary>The number of time_unit the frequency cap will last. Applicable when unlimited is `false`. The
        /// following restrictions apply based on the value of time_unit: * `TIME_UNIT_LIFETIME` - this field is output
        /// only and will default to 1 * `TIME_UNIT_MONTHS` - must be between 1 and 2 * `TIME_UNIT_WEEKS` - must be
        /// between 1 and 4 * `TIME_UNIT_DAYS` - must be between 1 and 6 * `TIME_UNIT_HOURS` - must be between 1 and 23
        /// * `TIME_UNIT_MINUTES` - must be between 1 and 59</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeUnitCount")]
        public virtual System.Nullable<int> TimeUnitCount { get; set; } 

        /// <summary>Whether unlimited frequency capping is applied. When this field is set to `true`, the remaining
        /// frequency cap fields are not applicable.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unlimited")]
        public virtual System.Nullable<bool> Unlimited { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Details for assigned gender targeting option. This will be populated in the details field of an
    /// AssignedTargetingOption when targeting_type is `TARTGETING_TYPE_GENDER`.</summary>
    public class GenderAssignedTargetingOptionDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The gender of the audience.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gender")]
        public virtual string Gender { get; set; } 

        /// <summary>Required. The targeting_option_id of a TargetingOption of type `TARGETING_TYPE_GENDER`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetingOptionId")]
        public virtual string TargetingOptionId { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Represents a targetable gender. This will be populated in the gender_details field of a TargetingOption
    /// when targeting_type is `TARGETING_TYPE_GENDER`.</summary>
    public class GenderTargetingOptionDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The gender of an audience.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gender")]
        public virtual string Gender { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Details for assigned geographic region targeting option. This will be populated in the details field of
    /// an AssignedTargetingOption when targeting_type is `TARGETING_TYPE_GEO_REGION`.</summary>
    public class GeoRegionAssignedTargetingOptionDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The display name of the geographic region (e.g., "Ontario, Canada").</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; } 

        /// <summary>Output only. The type of geographic region targeting.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("geoRegionType")]
        public virtual string GeoRegionType { get; set; } 

        /// <summary>Indicates if this option is being negatively targeted.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("negative")]
        public virtual System.Nullable<bool> Negative { get; set; } 

        /// <summary>Required. The targeting_option_id of a TargetingOption of type
        /// `TARGETING_TYPE_GEO_REGION`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetingOptionId")]
        public virtual string TargetingOptionId { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Represents a targetable geographic region. This will be populated in the geo_region_details field when
    /// targeting_type is `TARGETING_TYPE_GEO_REGION`.</summary>
    public class GeoRegionTargetingOptionDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The display name of the geographic region (e.g., "Ontario, Canada").</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; } 

        /// <summary>Output only. The type of geographic region targeting.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("geoRegionType")]
        public virtual string GeoRegionType { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Describes a Google audience resource. Includes Google audience lists.</summary>
    public class GoogleAudience : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The display name of the Google audience. .</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; } 

        /// <summary>Output only. The unique ID of the Google audience. Assigned by the system.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("googleAudienceId")]
        public virtual System.Nullable<long> GoogleAudienceId { get; set; } 

        /// <summary>Output only. The type of Google audience. .</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("googleAudienceType")]
        public virtual string GoogleAudienceType { get; set; } 

        /// <summary>Output only. The resource name of the google audience.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Details of Google audience group. All Google audience targeting settings are logically ‘OR’ of each
    /// other.</summary>
    public class GoogleAudienceGroup : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. All Google audience targeting settings in Google audience group. Repeated settings with
        /// same id will be ignored.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("settings")]
        public virtual System.Collections.Generic.IList<GoogleAudienceTargetingSetting> Settings { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Details of Google audience targeting setting.</summary>
    public class GoogleAudienceTargetingSetting : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Google audience id of the Google audience targeting setting. This id is
        /// google_audience_id.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("googleAudienceId")]
        public virtual System.Nullable<long> GoogleAudienceId { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Media resource.</summary>
    public class GoogleBytestreamMedia : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Name of the media resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceName")]
        public virtual string ResourceName { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Details for assigned household income targeting option. This will be populated in the details field of
    /// an AssignedTargetingOption when targeting_type is `TARGETING_TYPE_HOUSEHOLD_INCOME`.</summary>
    public class HouseholdIncomeAssignedTargetingOptionDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The household income of the audience.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("householdIncome")]
        public virtual string HouseholdIncome { get; set; } 

        /// <summary>Required. The targeting_option_id of a TargetingOption of type
        /// `TARGETING_TYPE_HOUSEHOLD_INCOME`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetingOptionId")]
        public virtual string TargetingOptionId { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Represents a targetable household income. This will be populated in the household_income_details field
    /// of a TargetingOption when targeting_type is `TARGETING_TYPE_HOUSEHOLD_INCOME`.</summary>
    public class HouseholdIncomeTargetingOptionDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The household income of an audience.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("householdIncome")]
        public virtual string HouseholdIncome { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A filtering option that filters entities by their entity IDs.</summary>
    public class IdFilter : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>YouTube Ads to download by ID. All IDs must belong to the same Advertiser or Partner specified in
        /// CreateSdfDownloadTaskRequest.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("adGroupAdIds")]
        public virtual System.Collections.Generic.IList<System.Nullable<long>> AdGroupAdIds { get; set; } 

        /// <summary>YouTube Ad Groups to download by ID. All IDs must belong to the same Advertiser or Partner
        /// specified in CreateSdfDownloadTaskRequest.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("adGroupIds")]
        public virtual System.Collections.Generic.IList<System.Nullable<long>> AdGroupIds { get; set; } 

        /// <summary>Campaigns to download by ID. All IDs must belong to the same Advertiser or Partner specified in
        /// CreateSdfDownloadTaskRequest.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("campaignIds")]
        public virtual System.Collections.Generic.IList<System.Nullable<long>> CampaignIds { get; set; } 

        /// <summary>Insertion Orders to download by ID. All IDs must belong to the same Advertiser or Partner specified
        /// in CreateSdfDownloadTaskRequest.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("insertionOrderIds")]
        public virtual System.Collections.Generic.IList<System.Nullable<long>> InsertionOrderIds { get; set; } 

        /// <summary>Line Items to download by ID. All IDs must belong to the same Advertiser or Partner specified in
        /// CreateSdfDownloadTaskRequest.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lineItemIds")]
        public virtual System.Collections.Generic.IList<System.Nullable<long>> LineItemIds { get; set; } 

        /// <summary>Media Products to download by ID. All IDs must belong to the same Advertiser or Partner specified
        /// in CreateSdfDownloadTaskRequest.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mediaProductIds")]
        public virtual System.Collections.Generic.IList<System.Nullable<long>> MediaProductIds { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A single insertion order.</summary>
    public class InsertionOrder : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The unique ID of the advertiser the insertion order belongs to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("advertiserId")]
        public virtual System.Nullable<long> AdvertiserId { get; set; } 

        /// <summary>Optional. The bidding strategy of the insertion order. By default, fixed_bid is set.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bidStrategy")]
        public virtual BiddingStrategy BidStrategy { get; set; } 

        /// <summary>Required. The budget allocation settings of the insertion order.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("budget")]
        public virtual InsertionOrderBudget Budget { get; set; } 

        /// <summary>Required. Immutable. The unique ID of the campaign that the insertion order belongs to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("campaignId")]
        public virtual System.Nullable<long> CampaignId { get; set; } 

        /// <summary>Required. The display name of the insertion order. Must be UTF-8 encoded with a maximum size of 240
        /// bytes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; } 

        /// <summary>Required. Controls whether or not the insertion order can spend its budget and bid on inventory. *
        /// For CreateInsertionOrder method, only `ENTITY_STATUS_DRAFT` is allowed. To activate an insertion order, use
        /// UpdateInsertionOrder method and update the status to `ENTITY_STATUS_ACTIVE` after creation. * An insertion
        /// order cannot be changed back to `ENTITY_STATUS_DRAFT` status from any other status. * An insertion order
        /// cannot be set to `ENTITY_STATUS_ACTIVE` if its parent campaign is not active.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entityStatus")]
        public virtual string EntityStatus { get; set; } 

        /// <summary>Required. The frequency capping setting of the insertion order.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("frequencyCap")]
        public virtual FrequencyCap FrequencyCap { get; set; } 

        /// <summary>Output only. The unique ID of the insertion order. Assigned by the system.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("insertionOrderId")]
        public virtual System.Nullable<long> InsertionOrderId { get; set; } 

        /// <summary>Additional integration details of the insertion order.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("integrationDetails")]
        public virtual IntegrationDetails IntegrationDetails { get; set; } 

        /// <summary>Output only. The resource name of the insertion order.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; } 

        /// <summary>Required. The budget spending speed setting of the insertion order.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pacing")]
        public virtual Pacing Pacing { get; set; } 

        /// <summary>The partner costs associated with the insertion order. If absent or empty in CreateInsertionOrder
        /// method, the newly created insertion order will inherit partner costs from the partner settings.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("partnerCosts")]
        public virtual System.Collections.Generic.IList<PartnerCost> PartnerCosts { get; set; } 

        /// <summary>Required. Performance goal of the insertion order.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("performanceGoal")]
        public virtual PerformanceGoal PerformanceGoal { get; set; } 

        /// <summary>Output only. The timestamp when the insertion order was last updated. Assigned by the
        /// system.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Settings that control how insertion order budget is allocated.</summary>
    public class InsertionOrderBudget : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The type of automation used to manage bid and budget for the insertion order. If this field is
        /// unspecified in creation, the value defaults to `INSERTION_ORDER_AUTOMATION_TYPE_NONE`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("automationType")]
        public virtual string AutomationType { get; set; } 

        /// <summary>Required. The list of budget segments. Use a budget segment to specify a specific budget for a
        /// given period of time an insertion order is running.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("budgetSegments")]
        public virtual System.Collections.Generic.IList<InsertionOrderBudgetSegment> BudgetSegments { get; set; } 

        /// <summary>Required. Immutable. The budget unit specifies whether the budget is currency based or impression
        /// based.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("budgetUnit")]
        public virtual string BudgetUnit { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Settings that control the budget of a single budget segment.</summary>
    public class InsertionOrderBudgetSegment : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The budget amount the insertion order will spend for the given date_range. The amount is
        /// in micros. Must be greater than 0. For example, 500000000 represents 500 standard units of the
        /// currency.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("budgetAmountMicros")]
        public virtual System.Nullable<long> BudgetAmountMicros { get; set; } 

        /// <summary>The ID of the campaign budget linked to this insertion order budget segment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("campaignBudgetId")]
        public virtual System.Nullable<long> CampaignBudgetId { get; set; } 

        /// <summary>Required. The start and end date settings of the budget segment. They are resolved relative to the
        /// parent advertiser's time zone. * When creating a new budget segment, both `start_date` and `end_date` must
        /// be in the future. * An existing budget segment with a `start_date` in the past has a mutable `end_date` but
        /// an immutable `start_date`. * `end_date` must be the `start_date` or later, both before the year
        /// 2037.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dateRange")]
        public virtual DateRange DateRange { get; set; } 

        /// <summary>The budget segment description. It can be used to enter Purchase Order information for each budget
        /// segment and have that information printed on the invoices. Must be UTF-8 encoded with a length of no more
        /// than 80 characters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Details of Integral Ad Science settings.</summary>
    public class IntegralAdScience : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Display Viewability section (applicable to display line items only).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayViewability")]
        public virtual string DisplayViewability { get; set; } 

        /// <summary>Brand Safety - **Unrateable**.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("excludeUnrateable")]
        public virtual System.Nullable<bool> ExcludeUnrateable { get; set; } 

        /// <summary>Ad Fraud settings.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("excludedAdFraudRisk")]
        public virtual string ExcludedAdFraudRisk { get; set; } 

        /// <summary>Brand Safety - **Adult content**.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("excludedAdultRisk")]
        public virtual string ExcludedAdultRisk { get; set; } 

        /// <summary>Brand Safety - **Alcohol**.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("excludedAlcoholRisk")]
        public virtual string ExcludedAlcoholRisk { get; set; } 

        /// <summary>Brand Safety - **Drugs**.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("excludedDrugsRisk")]
        public virtual string ExcludedDrugsRisk { get; set; } 

        /// <summary>Brand Safety - **Gambling**.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("excludedGamblingRisk")]
        public virtual string ExcludedGamblingRisk { get; set; } 

        /// <summary>Brand Safety - **Hate speech**.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("excludedHateSpeechRisk")]
        public virtual string ExcludedHateSpeechRisk { get; set; } 

        /// <summary>Brand Safety - **Illegal downloads**.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("excludedIllegalDownloadsRisk")]
        public virtual string ExcludedIllegalDownloadsRisk { get; set; } 

        /// <summary>Brand Safety - **Offensive language**.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("excludedOffensiveLanguageRisk")]
        public virtual string ExcludedOffensiveLanguageRisk { get; set; } 

        /// <summary>Brand Safety - **Violence**.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("excludedViolenceRisk")]
        public virtual string ExcludedViolenceRisk { get; set; } 

        /// <summary>True advertising quality (applicable to Display line items only).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("traqScoreOption")]
        public virtual string TraqScoreOption { get; set; } 

        /// <summary>Video Viewability Section (applicable to video line items only).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("videoViewability")]
        public virtual string VideoViewability { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Integration details of an entry.</summary>
    public class IntegrationDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Additional details of the entry in string format. Must be UTF-8 encoded with a length of no more
        /// than 1000 characters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("details")]
        public virtual string Details { get; set; } 

        /// <summary>An external identifier to be associated with the entry. The integration code will show up together
        /// with the entry in many places in the system, for example, reporting. Must be UTF-8 encoded with a length of
        /// no more than 500 characters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("integrationCode")]
        public virtual string IntegrationCode { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>An inventory source.</summary>
    public class InventorySource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Whether the inventory source has a guaranteed or non-guaranteed delivery.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("commitment")]
        public virtual string Commitment { get; set; } 

        /// <summary>The creative requirements of the inventory source. Not applicable for auction packages.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("creativeConfigs")]
        public virtual System.Collections.Generic.IList<CreativeConfig> CreativeConfigs { get; set; } 

        /// <summary>The ID in the exchange space that uniquely identifies the inventory source. Must be unique across
        /// buyers within each exchange but not necessarily unique across exchanges.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dealId")]
        public virtual string DealId { get; set; } 

        /// <summary>The delivery method of the inventory source. * For non-guaranteed inventory sources, the only
        /// acceptable value is `INVENTORY_SOURCE_DELIVERY_METHOD_PROGRAMMATIC`. * For guaranteed inventory sources,
        /// acceptable values are `INVENTORY_SOURCE_DELIVERY_METHOD_TAG` and
        /// `INVENTORY_SOURCE_DELIVERY_METHOD_PROGRAMMATIC`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deliveryMethod")]
        public virtual string DeliveryMethod { get; set; } 

        /// <summary>The display name of the inventory source. Must be UTF-8 encoded with a maximum size of 240
        /// bytes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; } 

        /// <summary>The exchange to which the inventory source belongs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exchange")]
        public virtual string Exchange { get; set; } 

        /// <summary>Output only. The unique ID of the inventory source. Assigned by the system.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inventorySourceId")]
        public virtual System.Nullable<long> InventorySourceId { get; set; } 

        /// <summary>Denotes the type of the inventory source.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inventorySourceType")]
        public virtual string InventorySourceType { get; set; } 

        /// <summary>Output only. The resource name of the inventory source.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; } 

        /// <summary>The publisher/seller name of the inventory source.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("publisherName")]
        public virtual string PublisherName { get; set; } 

        /// <summary>Required. The rate details of the inventory source.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rateDetails")]
        public virtual RateDetails RateDetails { get; set; } 

        /// <summary>The status settings of the inventory source.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual InventorySourceStatus Status { get; set; } 

        /// <summary>The time range when this inventory source starts and stops serving.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeRange")]
        public virtual TimeRange TimeRange { get; set; } 

        /// <summary>Output only. The timestamp when the inventory source was last updated. Assigned by the
        /// system.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Targeting details for inventory source. This will be populated in the details field of an
    /// AssignedTargetingOption when targeting_type is `TARGETING_TYPE_INVENTORY_SOURCE`.</summary>
    public class InventorySourceAssignedTargetingOptionDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. ID of the inventory source. Should refer to the inventory_source_id field of an
        /// InventorySource resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inventorySourceId")]
        public virtual System.Nullable<long> InventorySourceId { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>The configuration for display creatives.</summary>
    public class InventorySourceDisplayCreativeConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The size requirements for display creatives that can be assigned to the inventory source.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("creativeSize")]
        public virtual Dimensions CreativeSize { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A filtering option for filtering on Inventory Source entities.</summary>
    public class InventorySourceFilter : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Inventory Sources to download by ID. All IDs must belong to the same Advertiser or Partner
        /// specified in CreateSdfDownloadTaskRequest. Leave empty to download all Inventory Sources for the selected
        /// Advertiser or Partner.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inventorySourceIds")]
        public virtual System.Collections.Generic.IList<System.Nullable<long>> InventorySourceIds { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A collection of targetable inventory sources.</summary>
    public class InventorySourceGroup : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The display name of the inventory source group. Must be UTF-8 encoded with a maximum size
        /// of 240 bytes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; } 

        /// <summary>Output only. The unique ID of the inventory source group. Assigned by the system.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inventorySourceGroupId")]
        public virtual System.Nullable<long> InventorySourceGroupId { get; set; } 

        /// <summary>Output only. The resource name of the inventory source group.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Targeting details for inventory source group. This will be populated in the details field of an
    /// AssignedTargetingOption when targeting_type is `TARGETING_TYPE_INVENTORY_SOURCE_GROUP`.</summary>
    public class InventorySourceGroupAssignedTargetingOptionDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. ID of the inventory source group. Should refer to the inventory_source_group_id field of
        /// an InventorySourceGroup resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inventorySourceGroupId")]
        public virtual System.Nullable<long> InventorySourceGroupId { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>The status related settings of the inventory source.</summary>
    public class InventorySourceStatus : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The configuration status of the inventory source. Only applicable for guaranteed
        /// inventory sources. Acceptable values are `INVENTORY_SOURCE_CONFIG_STATUS_PENDING` and
        /// `INVENTORY_SOURCE_CONFIG_STATUS_COMPLETED`. An inventory source must be configured (fill in the required
        /// fields, choose creatives, and select a default campaign) before it can serve.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("configStatus")]
        public virtual string ConfigStatus { get; set; } 

        /// <summary>The user-provided reason for pausing this inventory source. Must not exceed 100 characters. Only
        /// applicable when entity_status is set to `ENTITY_STATUS_PAUSED`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entityPauseReason")]
        public virtual string EntityPauseReason { get; set; } 

        /// <summary>Whether or not the inventory source is servable. Acceptable values are `ENTITY_STATUS_ACTIVE`,
        /// `ENTITY_STATUS_ARCHIVED`, and `ENTITY_STATUS_PAUSED`. Default value is `ENTITY_STATUS_ACTIVE`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entityStatus")]
        public virtual string EntityStatus { get; set; } 

        /// <summary>Output only. The seller-provided reason for pausing this inventory source. Only applicable for
        /// inventory sources synced directly from the publishers and when seller_status is set to
        /// `ENTITY_STATUS_PAUSED`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sellerPauseReason")]
        public virtual string SellerPauseReason { get; set; } 

        /// <summary>Output only. The status set by the seller for the inventory source. Only applicable for inventory
        /// sources synced directly from the publishers. Acceptable values are `ENTITY_STATUS_ACTIVE` and
        /// `ENTITY_STATUS_PAUSED`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sellerStatus")]
        public virtual string SellerStatus { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>The configuration for video creatives.</summary>
    public class InventorySourceVideoCreativeConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The duration requirements for the video creatives that can be assigned to the inventory
        /// source.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("duration")]
        public virtual object Duration { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Details for assigned keyword targeting option. This will be populated in the details field of an
    /// AssignedTargetingOption when targeting_type is `TARGETING_TYPE_KEYWORD`.</summary>
    public class KeywordAssignedTargetingOptionDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The keyword, for example `car insurance`. Positive keyword cannot be offensive word. Must
        /// be UTF-8 encoded with a maximum size of 255 bytes. Maximum number of characters is 80. Maximum number of
        /// words is 10.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("keyword")]
        public virtual string Keyword { get; set; } 

        /// <summary>Indicates if this option is being negatively targeted.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("negative")]
        public virtual System.Nullable<bool> Negative { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Details for assigned language targeting option. This will be populated in the details field of an
    /// AssignedTargetingOption when targeting_type is `TARGETING_TYPE_LANGUAGE`.</summary>
    public class LanguageAssignedTargetingOptionDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The display name of the language (e.g., "French").</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; } 

        /// <summary>Indicates if this option is being negatively targeted. All assigned language targeting options on
        /// the same line item must have the same value for this field.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("negative")]
        public virtual System.Nullable<bool> Negative { get; set; } 

        /// <summary>Required. The targeting_option_id of a TargetingOption of type `TARGETING_TYPE_LANGUAGE`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetingOptionId")]
        public virtual string TargetingOptionId { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Represents a targetable language. This will be populated in the language_details field when
    /// targeting_type is `TARGETING_TYPE_LANGUAGE`.</summary>
    public class LanguageTargetingOptionDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The display name of the language (e.g., "French").</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A single line item.</summary>
    public class LineItem : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The unique ID of the advertiser the line item belongs to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("advertiserId")]
        public virtual System.Nullable<long> AdvertiserId { get; set; } 

        /// <summary>Required. The bidding strategy of the line item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bidStrategy")]
        public virtual BiddingStrategy BidStrategy { get; set; } 

        /// <summary>Required. The budget allocation setting of the line item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("budget")]
        public virtual LineItemBudget Budget { get; set; } 

        /// <summary>Output only. The unique ID of the campaign that the line item belongs to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("campaignId")]
        public virtual System.Nullable<long> CampaignId { get; set; } 

        /// <summary>The conversion tracking setting of the line item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("conversionCounting")]
        public virtual ConversionCountingConfig ConversionCounting { get; set; } 

        /// <summary>The IDs of the creatives associated with the line item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("creativeIds")]
        public virtual System.Collections.Generic.IList<System.Nullable<long>> CreativeIds { get; set; } 

        /// <summary>Required. The display name of the line item. Must be UTF-8 encoded with a maximum size of 240
        /// bytes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; } 

        /// <summary>Required. Controls whether or not the line item can spend its budget and bid on inventory. * For
        /// CreateLineItem method, only `ENTITY_STATUS_DRAFT` is allowed. To activate a line item, use UpdateLineItem
        /// method and update the status to `ENTITY_STATUS_ACTIVE` after creation. * A line item cannot be changed back
        /// to `ENTITY_STATUS_DRAFT` status from any other status. * If the line item's parent insertion order is not
        /// active, the line item can't spend its budget even if its own status is `ENTITY_STATUS_ACTIVE`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entityStatus")]
        public virtual string EntityStatus { get; set; } 

        /// <summary>Required. The start and end time of the line item's flight.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("flight")]
        public virtual LineItemFlight Flight { get; set; } 

        /// <summary>Required. The frequency capping setting of the line item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("frequencyCap")]
        public virtual FrequencyCap FrequencyCap { get; set; } 

        /// <summary>Required. Immutable. The unique ID of the insertion order that the line item belongs to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("insertionOrderId")]
        public virtual System.Nullable<long> InsertionOrderId { get; set; } 

        /// <summary>Integration details of the line item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("integrationDetails")]
        public virtual IntegrationDetails IntegrationDetails { get; set; } 

        /// <summary>The IDs of the private inventory sources assigned to the line item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inventorySourceIds")]
        public virtual System.Collections.Generic.IList<System.Nullable<long>> InventorySourceIds { get; set; } 

        /// <summary>Output only. The unique ID of the line item. Assigned by the system.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lineItemId")]
        public virtual System.Nullable<long> LineItemId { get; set; } 

        /// <summary>Required. Immutable. The type of the line item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lineItemType")]
        public virtual string LineItemType { get; set; } 

        /// <summary>Output only. The resource name of the line item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; } 

        /// <summary>Required. The budget spending speed setting of the line item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pacing")]
        public virtual Pacing Pacing { get; set; } 

        /// <summary>The partner costs associated with the line item. If absent or empty in CreateLineItem method, the
        /// newly created line item will inherit partner costs from its parent insertion order.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("partnerCosts")]
        public virtual System.Collections.Generic.IList<PartnerCost> PartnerCosts { get; set; } 

        /// <summary>Required. The partner revenue model setting of the line item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("partnerRevenueModel")]
        public virtual PartnerRevenueModel PartnerRevenueModel { get; set; } 

        /// <summary>Output only. The timestamp when the line item was last updated. Assigned by the system.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Settings that control how budget is allocated.</summary>
    public class LineItemBudget : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The type of the budget allocation. `LINE_ITEM_BUDGET_ALLOCATION_TYPE_AUTOMATIC` is only
        /// applicable when automatic budget allocation is enabled for the parent insertion order.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("budgetAllocationType")]
        public virtual string BudgetAllocationType { get; set; } 

        /// <summary>Output only. The budget unit specifies whether the budget is currency based or impression based.
        /// This value is inherited from the parent insertion order.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("budgetUnit")]
        public virtual string BudgetUnit { get; set; } 

        /// <summary>The maximum budget amount the line item will spend. Must be greater than 0. When
        /// budget_allocation_type is: * `LINE_ITEM_BUDGET_ALLOCATION_TYPE_AUTOMATIC`, this field is immutable and is
        /// set by the system. * `LINE_ITEM_BUDGET_ALLOCATION_TYPE_FIXED`, if budget_unit is: - `BUDGET_UNIT_CURRENCY`,
        /// this field represents maximum budget amount to spend, in micros of the advertiser's currency. For example,
        /// 1500000 represents 1.5 standard units of the currency. - `BUDGET_UNIT_IMPRESSIONS`, this field represents
        /// the maximum number of impressions to serve. * `LINE_ITEM_BUDGET_ALLOCATION_TYPE_UNLIMITED`, this field is
        /// not applicable and will be ignored by the system.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxAmount")]
        public virtual System.Nullable<long> MaxAmount { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Settings that control the active duration of a line item.</summary>
    public class LineItemFlight : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The flight start and end dates of the line item. They are resolved relative to the parent
        /// advertiser's time zone. * Required when flight_date_type is `LINE_ITEM_FLIGHT_DATE_TYPE_CUSTOM`. Output only
        /// otherwise. * When creating a new flight, both `start_date` and `end_date` must be in the future. * An
        /// existing flight with a `start_date` in the past has a mutable `end_date` but an immutable `start_date`. *
        /// `end_date` must be the `start_date` or later, both before the year 2037.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dateRange")]
        public virtual DateRange DateRange { get; set; } 

        /// <summary>Required. The type of the line item's flight dates.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("flightDateType")]
        public virtual string FlightDateType { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Response message for ListAdvertiserAssignedTargetingOptions.</summary>
    public class ListAdvertiserAssignedTargetingOptionsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of assigned targeting options. This list will be absent if empty.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("assignedTargetingOptions")]
        public virtual System.Collections.Generic.IList<AssignedTargetingOption> AssignedTargetingOptions { get; set; } 

        /// <summary>A token identifying the next page of results. This value should be specified as the pageToken in a
        /// subsequent ListAdvertiserAssignedTargetingOptionsRequest to fetch the next page of results. This token will
        /// be absent if there are no more assigned_targeting_options to return.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class ListAdvertisersResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of advertisers. This list will be absent if empty.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("advertisers")]
        public virtual System.Collections.Generic.IList<Advertiser> Advertisers { get; set; } 

        /// <summary>A token to retrieve the next page of results. Pass this value in the page_token field in the
        /// subsequent call to `ListAdvertisers` method to retrieve the next page of results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Response message for AssignedInventorySourceService.ListAssignedInventorySources.</summary>
    public class ListAssignedInventorySourcesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of assigned inventory sources. This list will be absent if empty.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("assignedInventorySources")]
        public virtual System.Collections.Generic.IList<AssignedInventorySource> AssignedInventorySources { get; set; } 

        /// <summary>A token to retrieve the next page of results. Pass this value in the page_token field in the
        /// subsequent call to `ListAssignedInventorySources` method to retrieve the next page of results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Response message for AssignedLocationService.ListAssignedLocations.</summary>
    public class ListAssignedLocationsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of assigned locations. This list will be absent if empty.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("assignedLocations")]
        public virtual System.Collections.Generic.IList<AssignedLocation> AssignedLocations { get; set; } 

        /// <summary>A token to retrieve the next page of results. Pass this value in the page_token field in the
        /// subsequent call to `ListAssignedLocations` method to retrieve the next page of results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class ListCampaignsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of campaigns. This list will be absent if empty.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("campaigns")]
        public virtual System.Collections.Generic.IList<Campaign> Campaigns { get; set; } 

        /// <summary>A token to retrieve the next page of results. Pass this value in the page_token field in the
        /// subsequent call to `ListCampaigns` method to retrieve the next page of results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class ListChannelsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of channels. This list will be absent if empty.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("channels")]
        public virtual System.Collections.Generic.IList<Channel> Channels { get; set; } 

        /// <summary>A token to retrieve the next page of results. Pass this value in the page_token field in the
        /// subsequent call to `ListChannels` method to retrieve the next page of results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class ListCombinedAudiencesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of combined audiences. This list will be absent if empty.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("combinedAudiences")]
        public virtual System.Collections.Generic.IList<CombinedAudience> CombinedAudiences { get; set; } 

        /// <summary>A token to retrieve the next page of results. Pass this value in the page_token field in the
        /// subsequent call to `ListCombinedAudiences` method to retrieve the next page of results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class ListCreativesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of creatives. This list will be absent if empty.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("creatives")]
        public virtual System.Collections.Generic.IList<Creative> Creatives { get; set; } 

        /// <summary>A token to retrieve the next page of results. Pass this value in the page_token field in the
        /// subsequent call to `ListCreativesRequest` method to retrieve the next page of results. If this field is
        /// null, it means this is the last page.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class ListCustomBiddingAlgorithmsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of custom bidding algorithms. This list will be absent if empty.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customBiddingAlgorithms")]
        public virtual System.Collections.Generic.IList<CustomBiddingAlgorithm> CustomBiddingAlgorithms { get; set; } 

        /// <summary>A token to retrieve the next page of results. Pass this value in the page_token field in the
        /// subsequent call to `ListCustomBiddingAlgorithmsRequest` method to retrieve the next page of results. If this
        /// field is null, it means this is the last page.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class ListCustomListsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of custom lists. This list will be absent if empty.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customLists")]
        public virtual System.Collections.Generic.IList<CustomList> CustomLists { get; set; } 

        /// <summary>A token to retrieve the next page of results. Pass this value in the page_token field in the
        /// subsequent call to `ListCustomLists` method to retrieve the next page of results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class ListFirstAndThirdPartyAudiencesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of first and third party audiences. Audience size properties will not be included. This
        /// list will be absent if empty.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("firstAndThirdPartyAudiences")]
        public virtual System.Collections.Generic.IList<FirstAndThirdPartyAudience> FirstAndThirdPartyAudiences { get; set; } 

        /// <summary>A token to retrieve the next page of results. Pass this value in the page_token field in the
        /// subsequent call to `ListFirstAndThirdPartyAudiences` method to retrieve the next page of results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class ListGoogleAudiencesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of Google audiences. This list will be absent if empty.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("googleAudiences")]
        public virtual System.Collections.Generic.IList<GoogleAudience> GoogleAudiences { get; set; } 

        /// <summary>A token to retrieve the next page of results. Pass this value in the page_token field in the
        /// subsequent call to `ListGoogleAudiences` method to retrieve the next page of results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class ListInsertionOrdersResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of insertion orders. This list will be absent if empty.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("insertionOrders")]
        public virtual System.Collections.Generic.IList<InsertionOrder> InsertionOrders { get; set; } 

        /// <summary>A token to retrieve the next page of results. Pass this value in the page_token field in the
        /// subsequent call to `ListInsertionOrders` method to retrieve the next page of results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Response message for InventorySourceGroupService.ListInventorySourceGroups.</summary>
    public class ListInventorySourceGroupsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of inventory source groups. This list will be absent if empty.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inventorySourceGroups")]
        public virtual System.Collections.Generic.IList<InventorySourceGroup> InventorySourceGroups { get; set; } 

        /// <summary>A token to retrieve the next page of results. Pass this value in the page_token field in the
        /// subsequent call to `ListInventorySourceGroups` method to retrieve the next page of results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class ListInventorySourcesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of inventory sources. This list will be absent if empty.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inventorySources")]
        public virtual System.Collections.Generic.IList<InventorySource> InventorySources { get; set; } 

        /// <summary>A token to retrieve the next page of results. Pass this value in the page_token field in the
        /// subsequent call to `ListInventorySources` method to retrieve the next page of results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Response message for ListLineItemAssignedTargetingOptions.</summary>
    public class ListLineItemAssignedTargetingOptionsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of assigned targeting options. This list will be absent if empty.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("assignedTargetingOptions")]
        public virtual System.Collections.Generic.IList<AssignedTargetingOption> AssignedTargetingOptions { get; set; } 

        /// <summary>A token identifying the next page of results. This value should be specified as the pageToken in a
        /// subsequent ListLineItemAssignedTargetingOptionsRequest to fetch the next page of results. This token will be
        /// absent if there are no more assigned_targeting_options to return.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class ListLineItemsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of line items. This list will be absent if empty.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lineItems")]
        public virtual System.Collections.Generic.IList<LineItem> LineItems { get; set; } 

        /// <summary>A token to retrieve the next page of results. Pass this value in the page_token field in the
        /// subsequent call to `ListLineItems` method to retrieve the next page of results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class ListLocationListsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of location lists. This list will be absent if empty.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locationLists")]
        public virtual System.Collections.Generic.IList<LocationList> LocationLists { get; set; } 

        /// <summary>A token to retrieve the next page of results. Pass this value in the page_token field in the
        /// subsequent call to `ListLocationLists` method to retrieve the next page of results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Response message for NegativeKeywordListService.ListNegativeKeywordLists.</summary>
    public class ListNegativeKeywordListsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of negative keyword lists. This list will be absent if empty.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("negativeKeywordLists")]
        public virtual System.Collections.Generic.IList<NegativeKeywordList> NegativeKeywordLists { get; set; } 

        /// <summary>A token to retrieve the next page of results. Pass this value in the page_token field in the
        /// subsequent call to `ListNegativeKeywordLists` method to retrieve the next page of results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Response message for NegativeKeywordService.ListNegativeKeywords.</summary>
    public class ListNegativeKeywordsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of negative keywords. This list will be absent if empty.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("negativeKeywords")]
        public virtual System.Collections.Generic.IList<NegativeKeyword> NegativeKeywords { get; set; } 

        /// <summary>A token to retrieve the next page of results. Pass this value in the page_token field in the
        /// subsequent call to `ListNegativeKeywords` method to retrieve the next page of results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class ListPartnerAssignedTargetingOptionsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of assigned targeting options. This list will be absent if empty.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("assignedTargetingOptions")]
        public virtual System.Collections.Generic.IList<AssignedTargetingOption> AssignedTargetingOptions { get; set; } 

        /// <summary>A token identifying the next page of results. This value should be specified as the pageToken in a
        /// subsequent ListPartnerAssignedTargetingOptionsRequest to fetch the next page of results. This token will be
        /// absent if there are no more assigned_targeting_options to return.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class ListPartnersResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A token to retrieve the next page of results. Pass this value in the page_token field in the
        /// subsequent call to `ListPartners` method to retrieve the next page of results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; } 

        /// <summary>The list of partners. This list will be absent if empty.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("partners")]
        public virtual System.Collections.Generic.IList<Partner> Partners { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Response message for SiteService.ListSites.</summary>
    public class ListSitesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A token to retrieve the next page of results. Pass this value in the page_token field in the
        /// subsequent call to `ListSites` method to retrieve the next page of results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; } 

        /// <summary>The list of sites. This list will be absent if empty.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sites")]
        public virtual System.Collections.Generic.IList<Site> Sites { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Response message for ListTargetingOptions.</summary>
    public class ListTargetingOptionsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A token to retrieve the next page of results. Pass this value in the page_token field in the
        /// subsequent call to `ListTargetingOptions` method to retrieve the next page of results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; } 

        /// <summary>The list of targeting options. This list will be absent if empty.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetingOptions")]
        public virtual System.Collections.Generic.IList<TargetingOption> TargetingOptions { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class ListUsersResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A token to retrieve the next page of results. Pass this value in the page_token field in the
        /// subsequent call to `ListUsers` method to retrieve the next page of results. This token will be absent if
        /// there are no more results to return.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; } 

        /// <summary>The list of users. This list will be absent if empty.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("users")]
        public virtual System.Collections.Generic.IList<User> Users { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A list of locations used for targeting.</summary>
    public class LocationList : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Immutable. The unique ID of the advertiser the location list belongs to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("advertiserId")]
        public virtual System.Nullable<long> AdvertiserId { get; set; } 

        /// <summary>Required. The display name of the location list. Must be UTF-8 encoded with a maximum size of 240
        /// bytes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; } 

        /// <summary>Output only. The unique ID of the location list. Assigned by the system.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locationListId")]
        public virtual System.Nullable<long> LocationListId { get; set; } 

        /// <summary>Required. Immutable. The type of location. All locations in the list will share this
        /// type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locationType")]
        public virtual string LocationType { get; set; } 

        /// <summary>Output only. The resource name of the location list.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Specifies how many days into the past to look when determining whether to record a
    /// conversion.</summary>
    public class LookbackWindow : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Lookback window, in days, from the last time a given user clicked on one of your ads.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clickDays")]
        public virtual System.Nullable<int> ClickDays { get; set; } 

        /// <summary>Lookback window, in days, from the last time a given user viewed one of your ads.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("impressionDays")]
        public virtual System.Nullable<int> ImpressionDays { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A strategy that automatically adjusts the bid to optimize a specified performance goal while spending
    /// the full budget.</summary>
    public class MaximizeSpendBidStrategy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ID of the Custom Bidding Algorithm used by this strategy. Only applicable when
        /// performance_goal_type is set to `BIDDING_STRATEGY_PERFORMANCE_GOAL_TYPE_CUSTOM_ALGO`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customBiddingAlgorithmId")]
        public virtual System.Nullable<long> CustomBiddingAlgorithmId { get; set; } 

        /// <summary>The maximum average CPM that may be bid, in micros of the advertiser's currency. Must be greater
        /// than or equal to a billable unit of the given currency. For example, 1500000 represents 1.5 standard units
        /// of the currency.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxAverageCpmBidAmountMicros")]
        public virtual System.Nullable<long> MaxAverageCpmBidAmountMicros { get; set; } 

        /// <summary>Required. The type of the performance goal that the bidding strategy tries to minimize while
        /// spending the full budget. `BIDDING_STRATEGY_PERFORMANCE_GOAL_TYPE_VIEWABLE_CPM` is not supported for this
        /// strategy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("performanceGoalType")]
        public virtual string PerformanceGoalType { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Measurement settings of a partner.</summary>
    public class MeasurementConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Whether or not to report DV360 cost to CM.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dv360ToCmCostReportingEnabled")]
        public virtual System.Nullable<bool> Dv360ToCmCostReportingEnabled { get; set; } 

        /// <summary>Whether or not to include DV360 data in CM data transfer reports.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dv360ToCmDataSharingEnabled")]
        public virtual System.Nullable<bool> Dv360ToCmDataSharingEnabled { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Represents an amount of money with its currency type.</summary>
    public class Money : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The 3-letter currency code defined in ISO 4217.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("currencyCode")]
        public virtual string CurrencyCode { get; set; } 

        /// <summary>Number of nano (10^-9) units of the amount. The value must be between -999,999,999 and +999,999,999
        /// inclusive. If `units` is positive, `nanos` must be positive or zero. If `units` is zero, `nanos` can be
        /// positive, zero, or negative. If `units` is negative, `nanos` must be negative or zero. For example $-1.75 is
        /// represented as `units`=-1 and `nanos`=-750,000,000.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nanos")]
        public virtual System.Nullable<int> Nanos { get; set; } 

        /// <summary>The whole units of the amount. For example if `currencyCode` is `"USD"`, then 1 unit is one US
        /// dollar.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("units")]
        public virtual System.Nullable<long> Units { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A negatively targeted keyword that belongs to a negative keyword list.</summary>
    public class NegativeKeyword : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Immutable. The negatively targeted keyword, for example `car insurance`. Must be UTF-8
        /// encoded with a maximum size of 255 bytes. Maximum number of characters is 80. Maximum number of words is 10.
        /// Valid characters are restricted to ASCII characters only. The only URL-escaping permitted is for
        /// representing whitespace between words. Leading or trailing whitespace is ignored.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("keywordValue")]
        public virtual string KeywordValue { get; set; } 

        /// <summary>Output only. The resource name of the negative keyword.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A list of negative keywords used for targeting.</summary>
    public class NegativeKeywordList : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The unique ID of the advertiser the negative keyword list belongs to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("advertiserId")]
        public virtual System.Nullable<long> AdvertiserId { get; set; } 

        /// <summary>Required. The display name of the negative keyword list. Must be UTF-8 encoded with a maximum size
        /// of 255 bytes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; } 

        /// <summary>Output only. The resource name of the negative keyword list.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; } 

        /// <summary>Output only. The unique ID of the negative keyword list. Assigned by the system.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("negativeKeywordListId")]
        public virtual System.Nullable<long> NegativeKeywordListId { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Targeting details for negative keyword list. This will be populated in the details field of an
    /// AssignedTargetingOption when targeting_type is `TARGETING_TYPE_NEGATIVE_KEYWORD_LIST`.</summary>
    public class NegativeKeywordListAssignedTargetingOptionDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. ID of the negative keyword list. Should refer to the negative_keyword_list_id field of a
        /// NegativeKeywordList resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("negativeKeywordListId")]
        public virtual System.Nullable<long> NegativeKeywordListId { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>OBA Icon for a Creative</summary>
    public class ObaIcon : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The click tracking URL of the OBA icon. Only URLs of the following domains are allowed: *
        /// https://info.evidon.com * https://l.betrad.com</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clickTrackingUrl")]
        public virtual string ClickTrackingUrl { get; set; } 

        /// <summary>The dimensions of the OBA icon.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dimensions")]
        public virtual Dimensions Dimensions { get; set; } 

        /// <summary>Required. The landing page URL of the OBA icon. Only URLs of the following domains are allowed: *
        /// https://info.evidon.com * https://l.betrad.com</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("landingPageUrl")]
        public virtual string LandingPageUrl { get; set; } 

        /// <summary>The position of the OBA icon on the creative.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("position")]
        public virtual string Position { get; set; } 

        /// <summary>The program of the OBA icon. For example: “AdChoices”.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("program")]
        public virtual string Program { get; set; } 

        /// <summary>The MIME type of the OBA icon resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceMimeType")]
        public virtual string ResourceMimeType { get; set; } 

        /// <summary>The URL of the OBA icon resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceUrl")]
        public virtual string ResourceUrl { get; set; } 

        /// <summary>Required. The view tracking URL of the OBA icon. Only URLs of the following domains are allowed: *
        /// https://info.evidon.com * https://l.betrad.com</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("viewTrackingUrl")]
        public virtual string ViewTrackingUrl { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>On screen position targeting option details. This will be populated in the on_screen_position_details
    /// field when targeting_type is `TARGETING_TYPE_ON_SCREEN_POSITION`.</summary>
    public class OnScreenPositionAssignedTargetingOptionDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The on screen position.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("onScreenPosition")]
        public virtual string OnScreenPosition { get; set; } 

        /// <summary>Required. The targeting_option_id field when targeting_type is
        /// `TARGETING_TYPE_ON_SCREEN_POSITION`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetingOptionId")]
        public virtual string TargetingOptionId { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Represents a targetable on screen position, which could be used by display and video ads. This will be
    /// populated in the on_screen_position_details field when targeting_type is
    /// `TARGETING_TYPE_ON_SCREEN_POSITION`.</summary>
    public class OnScreenPositionTargetingOptionDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The on screen position.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("onScreenPosition")]
        public virtual string OnScreenPosition { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Assigned operating system targeting option details. This will be populated in the
    /// operating_system_details field when targeting_type is `TARGETING_TYPE_OPERATING_SYSTEM`.</summary>
    public class OperatingSystemAssignedTargetingOptionDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The display name of the operating system.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; } 

        /// <summary>Indicates if this option is being negatively targeted.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("negative")]
        public virtual System.Nullable<bool> Negative { get; set; } 

        /// <summary>Required. The targeting option ID populated in targeting_option_id field when targeting_type is
        /// `TARGETING_TYPE_OPERATING_SYSTEM`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetingOptionId")]
        public virtual string TargetingOptionId { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Represents a targetable operating system. This will be populated in the operating_system_details field
    /// of a TargetingOption when targeting_type is `TARGETING_TYPE_OPERATING_SYSTEM`.</summary>
    public class OperatingSystemTargetingOptionDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The display name of the operating system.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>This resource represents a long-running operation that is the result of a network API call.</summary>
    public class Operation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>If the value is `false`, it means the operation is still in progress. If `true`, the operation is
        /// completed, and either `error` or `response` is available.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("done")]
        public virtual System.Nullable<bool> Done { get; set; } 

        /// <summary>The error result of the operation in case of failure or cancellation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("error")]
        public virtual Status Error { get; set; } 

        /// <summary>Service-specific metadata associated with the operation. It typically contains progress information
        /// and common metadata such as create time. Some services might not provide such metadata. Any method that
        /// returns a long-running operation should document the metadata type, if any.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual System.Collections.Generic.IDictionary<string,object> Metadata { get; set; } 

        /// <summary>The server-assigned name, which is only unique within the same service that originally returns it.
        /// If you use the default HTTP mapping, the `name` should be a resource name ending with
        /// `operations/{unique_id}`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; } 

        /// <summary>The normal response of the operation in case of success. If the original method returns no data on
        /// success, such as `Delete`, the response is `google.protobuf.Empty`. If the original method is standard
        /// `Get`/`Create`/`Update`, the response should be the resource. For other methods, the response should have
        /// the type `XxxResponse`, where `Xxx` is the original method name. For example, if the original method name is
        /// `TakeSnapshot()`, the inferred response type is `TakeSnapshotResponse`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("response")]
        public virtual System.Collections.Generic.IDictionary<string,object> Response { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Settings that control the rate at which a budget is spent.</summary>
    public class Pacing : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Maximum number of impressions to serve every day. Applicable when the budget is impression based.
        /// Must be greater than 0.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dailyMaxImpressions")]
        public virtual System.Nullable<long> DailyMaxImpressions { get; set; } 

        /// <summary>Maximum currency amount to spend every day in micros of advertiser's currency. Applicable when the
        /// budget is currency based. Must be greater than 0. For example, for 1.5 standard unit of the currency, set
        /// this field to 1500000. The value assigned will be rounded to whole billable units for the relevant currency
        /// by the following rules: any positive value less than a single billable unit will be rounded up to one
        /// billable unit and any value larger than a single billable unit will be rounded down to the nearest billable
        /// value. For example, if the currency's billable unit is 0.01, and this field is set to 10257770, it will
        /// round down to 10250000, a value of 10.25. If set to 505, it will round up to 10000, a value of
        /// 0.01.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dailyMaxMicros")]
        public virtual System.Nullable<long> DailyMaxMicros { get; set; } 

        /// <summary>Required. The time period in which the pacing budget will be spent. When automatic budget
        /// allocation is enabled at the insertion order via auto_budget_allocation, this field is output only and
        /// defaults to `PACING_PERIOD_FLIGHT`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pacingPeriod")]
        public virtual string PacingPeriod { get; set; } 

        /// <summary>Required. The type of pacing that defines how the budget amount will be spent across the
        /// pacing_period.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pacingType")]
        public virtual string PacingType { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A filtering option that filters on selected file types belonging to a chosen set of filter
    /// entities.</summary>
    public class ParentEntityFilter : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. File types that will be returned.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fileType")]
        public virtual System.Collections.Generic.IList<string> FileType { get; set; } 

        /// <summary>The IDs of the specified filter type. This is used to filter entities to fetch. If filter type is
        /// not `FILTER_TYPE_NONE`, at least one ID must be specified.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filterIds")]
        public virtual System.Collections.Generic.IList<System.Nullable<long>> FilterIds { get; set; } 

        /// <summary>Required. Filter type used to filter fetched entities.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filterType")]
        public virtual string FilterType { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Details for assigned parental status targeting option. This will be populated in the details field of
    /// an AssignedTargetingOption when targeting_type is `TARTGETING_TYPE_PARENTAL_STATUS`.</summary>
    public class ParentalStatusAssignedTargetingOptionDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The parental status of the audience.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parentalStatus")]
        public virtual string ParentalStatus { get; set; } 

        /// <summary>Required. The targeting_option_id of a TargetingOption of type
        /// `TARGETING_TYPE_PARENTAL_STATUS`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetingOptionId")]
        public virtual string TargetingOptionId { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Represents a targetable parental status. This will be populated in the parental_status_details field of
    /// a TargetingOption when targeting_type is `TARGETING_TYPE_PARENTAL_STATUS`.</summary>
    public class ParentalStatusTargetingOptionDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The parental status of an audience.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parentalStatus")]
        public virtual string ParentalStatus { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A single partner in Display & Video 360 (DV360).</summary>
    public class Partner : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Ad server related settings of the partner.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("adServerConfig")]
        public virtual PartnerAdServerConfig AdServerConfig { get; set; } 

        /// <summary>Settings that control how partner data may be accessed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataAccessConfig")]
        public virtual PartnerDataAccessConfig DataAccessConfig { get; set; } 

        /// <summary>The display name of the partner. Must be UTF-8 encoded with a maximum size of 240 bytes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; } 

        /// <summary>Output only. The status of the partner.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entityStatus")]
        public virtual string EntityStatus { get; set; } 

        /// <summary>Settings that control which exchanges are enabled for the partner.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exchangeConfig")]
        public virtual ExchangeConfig ExchangeConfig { get; set; } 

        /// <summary>General settings of the partner.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("generalConfig")]
        public virtual PartnerGeneralConfig GeneralConfig { get; set; } 

        /// <summary>Output only. The resource name of the partner.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; } 

        /// <summary>Output only. The unique ID of the partner. Assigned by the system.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("partnerId")]
        public virtual System.Nullable<long> PartnerId { get; set; } 

        /// <summary>Output only. The timestamp when the partner was last updated. Assigned by the system.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Ad server related settings of a partner.</summary>
    public class PartnerAdServerConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Measurement settings of a partner.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("measurementConfig")]
        public virtual MeasurementConfig MeasurementConfig { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Settings that control a partner cost. A partner cost is any type of expense involved in running a
    /// campaign, other than the costs of purchasing impressions (which is called the media cost) and using third-party
    /// audience segment data (data fee). Some examples of partner costs include the fees for using DV360, a third-party
    /// ad server, or a third-party ad serving verification service.</summary>
    public class PartnerCost : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The type of the partner cost.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("costType")]
        public virtual string CostType { get; set; } 

        /// <summary>The CPM fee amount in micros of advertiser's currency. Applicable when the fee_type is
        /// `PARTNER_FEE_TYPE_CPM_FEE`. Must be greater than or equal to 0. For example, for 1.5 standard unit of the
        /// advertiser's currency, set this field to 1500000.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("feeAmount")]
        public virtual System.Nullable<long> FeeAmount { get; set; } 

        /// <summary>The media fee percentage in millis (1/1000 of a percent). Applicable when the fee_type is
        /// `PARTNER_FEE_TYPE_MEDIA_FEE`. Must be greater than or equal to 0. For example: 100 represents
        /// 0.1%.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("feePercentageMillis")]
        public virtual System.Nullable<long> FeePercentageMillis { get; set; } 

        /// <summary>Required. The fee type for this partner cost.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("feeType")]
        public virtual string FeeType { get; set; } 

        /// <summary>The invoice type for this partner cost. * Required when cost_type is one of: -
        /// `PARTNER_COST_TYPE_ADLOOX` - `PARTNER_COST_TYPE_DOUBLE_VERIFY` - `PARTNER_COST_TYPE_INTEGRAL_AD_SCIENCE`. *
        /// Output only for other types.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("invoiceType")]
        public virtual string InvoiceType { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Settings that control how partner related data may be accessed.</summary>
    public class PartnerDataAccessConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Structured Data Files (SDF) settings for the partner. The SDF configuration for the
        /// partner.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sdfConfig")]
        public virtual SdfConfig SdfConfig { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>General settings of a partner.</summary>
    public class PartnerGeneralConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Immutable. Partner's currency in ISO 4217 format.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("currencyCode")]
        public virtual string CurrencyCode { get; set; } 

        /// <summary>Immutable. The standard TZ database name of the partner's time zone. For example,
        /// `America/New_York`. See more at: https://en.wikipedia.org/wiki/List_of_tz_database_time_zones</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeZone")]
        public virtual string TimeZone { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Settings that control how partner revenue is calculated.</summary>
    public class PartnerRevenueModel : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The markup amount of the partner revenue model. Must be greater than or equal to 0. *
        /// When the markup_type is set to be `PARTNER_REVENUE_MODEL_MARKUP_TYPE_CPM`, this field represents the CPM
        /// markup in micros of advertiser's currency. For example, 1500000 represents 1.5 standard units of the
        /// currency. * When the markup_type is set to be `PARTNER_REVENUE_MODEL_MARKUP_TYPE_MEDIA_COST_MARKUP`, this
        /// field represents the media cost percent markup in millis. For example, 100 represents 0.1% (decimal 0.001).
        /// * When the markup_type is set to be `PARTNER_REVENUE_MODEL_MARKUP_TYPE_TOTAL_MEDIA_COST_MARKUP`, this field
        /// represents the total media cost percent markup in millis. For example, 100 represents 0.1% (decimal
        /// 0.001).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("markupAmount")]
        public virtual System.Nullable<long> MarkupAmount { get; set; } 

        /// <summary>Required. The markup type of the partner revenue model.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("markupType")]
        public virtual string MarkupType { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Settings that control the performance goal of a campaign or insertion order.</summary>
    public class PerformanceGoal : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The goal amount, in micros of the advertiser's currency. Applicable when performance_goal_type is
        /// one of: * `PERFORMANCE_GOAL_TYPE_CPM` * `PERFORMANCE_GOAL_TYPE_CPC` * `PERFORMANCE_GOAL_TYPE_CPA` *
        /// `PERFORMANCE_GOAL_TYPE_CPIAVC` For example 1500000 represents 1.5 standard units of the currency.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("performanceGoalAmountMicros")]
        public virtual System.Nullable<long> PerformanceGoalAmountMicros { get; set; } 

        /// <summary>The decimal representation of the goal percentage in micros. Applicable when performance_goal_type
        /// is one of: * `PERFORMANCE_GOAL_TYPE_CTR` * `PERFORMANCE_GOAL_TYPE_VIEWABILITY` For example, 70000 represents
        /// 7% (decimal 0.07).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("performanceGoalPercentageMicros")]
        public virtual System.Nullable<long> PerformanceGoalPercentageMicros { get; set; } 

        /// <summary>A key performance indicator (KPI) string, which can be empty. Must be UTF-8 encoded with a length
        /// of no more than 100 characters. Applicable when performance_goal_type is set to
        /// `PERFORMANCE_GOAL_TYPE_OTHER`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("performanceGoalString")]
        public virtual string PerformanceGoalString { get; set; } 

        /// <summary>Required. The type of the performance goal.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("performanceGoalType")]
        public virtual string PerformanceGoalType { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A strategy that automatically adjusts the bid to meet or beat a specified performance goal.</summary>
    public class PerformanceGoalBidStrategy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ID of the Custom Bidding Algorithm used by this strategy. Only applicable when
        /// performance_goal_type is set to `BIDDING_STRATEGY_PERFORMANCE_GOAL_TYPE_CUSTOM_ALGO`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customBiddingAlgorithmId")]
        public virtual System.Nullable<long> CustomBiddingAlgorithmId { get; set; } 

        /// <summary>The maximum average CPM that may be bid, in micros of the advertiser's currency. Must be greater
        /// than or equal to a billable unit of the given currency. Not applicable when performance_goal_type is set to
        /// `BIDDING_STRATEGY_PERFORMANCE_GOAL_TYPE_VIEWABLE_CPM`. For example, 1500000 represents 1.5 standard units of
        /// the currency.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxAverageCpmBidAmountMicros")]
        public virtual System.Nullable<long> MaxAverageCpmBidAmountMicros { get; set; } 

        /// <summary>Required. The performance goal the bidding strategy will attempt to meet or beat, in micros of the
        /// advertiser's currency or in micro of the ROAS (Return On Advertising Spend) value which is also based on
        /// advertiser's currency. Must be greater than or equal to a billable unit of the given currency and smaller or
        /// equal to upper bounds. Each performance_goal_type has its upper bound: * when performance_goal_type is
        /// `BIDDING_STRATEGY_PERFORMANCE_GOAL_TYPE_CPA`, upper bound is 10000.00 USD. * when performance_goal_type is
        /// `BIDDING_STRATEGY_PERFORMANCE_GOAL_TYPE_CPC`, upper bound is 1000.00 USD. * when performance_goal_type is
        /// `BIDDING_STRATEGY_PERFORMANCE_GOAL_TYPE_VIEWABLE_CPM`, upper bound is 1000.00 USD. * when
        /// performance_goal_type is `BIDDING_STRATEGY_PERFORMANCE_GOAL_TYPE_CUSTOM_ALGO`, upper bound is 1000.00 and
        /// lower bound is 0.01. Example: If set to `BIDDING_STRATEGY_PERFORMANCE_GOAL_TYPE_VIEWABLE_CPM`, the bid price
        /// will be based on the probability that each available impression will be viewable. For example, if viewable
        /// CPM target is $2 and an impression is 40% likely to be viewable, the bid price will be $0.80 CPM (40% of
        /// $2). For example, 1500000 represents 1.5 standard units of the currency or ROAS value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("performanceGoalAmountMicros")]
        public virtual System.Nullable<long> PerformanceGoalAmountMicros { get; set; } 

        /// <summary>Required. The type of the performance goal that the bidding strategy will try to meet or beat. For
        /// line item level usage, the value must be one of: * `BIDDING_STRATEGY_PERFORMANCE_GOAL_TYPE_CPA` *
        /// `BIDDING_STRATEGY_PERFORMANCE_GOAL_TYPE_CPC` * `BIDDING_STRATEGY_PERFORMANCE_GOAL_TYPE_VIEWABLE_CPM` *
        /// `BIDDING_STRATEGY_PERFORMANCE_GOAL_TYPE_CUSTOM_ALGO`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("performanceGoalType")]
        public virtual string PerformanceGoalType { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Targeting details for proximity location list. This will be populated in the details field of an
    /// AssignedTargetingOption when targeting_type is `TARGETING_TYPE_PROXIMITY_LOCATION_LIST`.</summary>
    public class ProximityLocationListAssignedTargetingOptionDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. ID of the proximity location list. Should refer to the location_list_id field of a
        /// LocationList resource whose type is `TARGETING_LOCATION_TYPE_PROXIMITY`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("proximityLocationListId")]
        public virtual System.Nullable<long> ProximityLocationListId { get; set; } 

        /// <summary>Required. Radius range for proximity location list. This represents the size of the area around a
        /// chosen location that will be targeted. `All` proximity location targeting under a single line item must have
        /// the same radius range value. Set this value to match any existing targeting. If updated, this field will
        /// change the radius range for all proximity targeting under the line item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("proximityRadiusRange")]
        public virtual string ProximityRadiusRange { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Publisher review status for the creative.</summary>
    public class PublisherReviewStatus : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The publisher reviewing the creative.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("publisherName")]
        public virtual string PublisherName { get; set; } 

        /// <summary>Status of the publisher review.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual string Status { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>The rate related settings of the inventory source.</summary>
    public class RateDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The rate type. Acceptable values are `INVENTORY_SOURCE_RATE_TYPE_CPM_FIXED`,
        /// `INVENTORY_SOURCE_RATE_TYPE_CPM_FLOOR`, and `INVENTORY_SOURCE_RATE_TYPE_CPD`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inventorySourceRateType")]
        public virtual string InventorySourceRateType { get; set; } 

        /// <summary>Output only. The amount that the buyer has committed to spending on the inventory source up front.
        /// Only applicable for guaranteed inventory sources.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minimumSpend")]
        public virtual Money MinimumSpend { get; set; } 

        /// <summary>The rate for the inventory source.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rate")]
        public virtual Money Rate { get; set; } 

        /// <summary>Required for guaranteed inventory sources. The number of impressions guaranteed by the
        /// seller.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unitsPurchased")]
        public virtual System.Nullable<long> UnitsPurchased { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Targeting details for regional location list. This will be populated in the details field of an
    /// AssignedTargetingOption when targeting_type is `TARGETING_TYPE_REGIONAL_LOCATION_LIST`.</summary>
    public class RegionalLocationListAssignedTargetingOptionDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Indicates if this option is being negatively targeted.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("negative")]
        public virtual System.Nullable<bool> Negative { get; set; } 

        /// <summary>Required. ID of the regional location list. Should refer to the location_list_id field of a
        /// LocationList resource whose type is `TARGETING_LOCATION_TYPE_REGIONAL`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("regionalLocationListId")]
        public virtual System.Nullable<long> RegionalLocationListId { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Review statuses for the creative.</summary>
    public class ReviewStatusInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Represents the basic approval needed for a creative to begin serving. Summary of
        /// creative_and_landing_page_review_status and content_and_policy_review_status.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("approvalStatus")]
        public virtual string ApprovalStatus { get; set; } 

        /// <summary>Content and policy review status for the creative.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contentAndPolicyReviewStatus")]
        public virtual string ContentAndPolicyReviewStatus { get; set; } 

        /// <summary>Creative and landing page review status for the creative.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("creativeAndLandingPageReviewStatus")]
        public virtual string CreativeAndLandingPageReviewStatus { get; set; } 

        /// <summary>Exchange review statuses for the creative.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exchangeReviewStatuses")]
        public virtual System.Collections.Generic.IList<ExchangeReviewStatus> ExchangeReviewStatuses { get; set; } 

        /// <summary>Publisher review statuses for the creative.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("publisherReviewStatuses")]
        public virtual System.Collections.Generic.IList<PublisherReviewStatus> PublisherReviewStatuses { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Structured Data File (SDF) related settings.</summary>
    public class SdfConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>An administrator email address to which the SDF processing status reports will be sent.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("adminEmail")]
        public virtual string AdminEmail { get; set; } 

        /// <summary>Required. The version of SDF being used.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual string Version { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Type for the response returned by [SdfDownloadTaskService.CreateSdfDownloadTask].</summary>
    public class SdfDownloadTask : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A resource name to be used in media.download to Download the prepared files. Resource names have
        /// the format `download/sdfdownloadtasks/media/{media_id}`. `media_id` will be made available by the long
        /// running operation service once the task status is done.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceName")]
        public virtual string ResourceName { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Type for the metadata returned by [SdfDownloadTaskService.CreateSdfDownloadTask].</summary>
    public class SdfDownloadTaskMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The time when the operation was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; } 

        /// <summary>The time when execution was completed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endTime")]
        public virtual object EndTime { get; set; } 

        /// <summary>The SDF version used to execute this download task.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual string Version { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Targeting details for sensitive category. This will be populated in the details field of an
    /// AssignedTargetingOption when targeting_type is `TARGETING_TYPE_SENSITIVE_CATEGORY_EXCLUSION`.</summary>
    public class SensitiveCategoryAssignedTargetingOptionDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. ID of the sensitive category to be EXCLUDED.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("excludedTargetingOptionId")]
        public virtual string ExcludedTargetingOptionId { get; set; } 

        /// <summary>Output only. An enum for the DV360 Sensitive category content classifier.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sensitiveCategory")]
        public virtual string SensitiveCategory { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Represents a targetable sensitive category. This will be populated in the sensitive_category_details
    /// field of the TargetingOption when targeting_type is `TARGETING_TYPE_SENSITIVE_CATEGORY_EXCLUSION`.</summary>
    public class SensitiveCategoryTargetingOptionDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. An enum for the DV360 Sensitive category content classifier.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sensitiveCategory")]
        public virtual string SensitiveCategory { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A single site. Sites are apps or websites belonging to a channel.</summary>
    public class Site : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The resource name of the site.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; } 

        /// <summary>Required. The URL or app ID of the site. Must be UTF-8 encoded with a maximum length of 240
        /// bytes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("urlOrAppId")]
        public virtual string UrlOrAppId { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>The `Status` type defines a logical error model that is suitable for different programming
    /// environments, including REST APIs and RPC APIs. It is used by [gRPC](https://github.com/grpc). Each `Status`
    /// message contains three pieces of data: error code, error message, and error details. You can find out more about
    /// this error model and how to work with it in the [API Design
    /// Guide](https://cloud.google.com/apis/design/errors).</summary>
    public class Status : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The status code, which should be an enum value of google.rpc.Code.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("code")]
        public virtual System.Nullable<int> Code { get; set; } 

        /// <summary>A list of messages that carry the error details. There is a common set of message types for APIs to
        /// use.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("details")]
        public virtual System.Collections.Generic.IList<System.Collections.Generic.IDictionary<string,object>> Details { get; set; } 

        /// <summary>A developer-facing error message, which should be in English. Any user-facing error message should
        /// be localized and sent in the google.rpc.Status.details field, or localized by the client.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("message")]
        public virtual string Message { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Details for assigned sub-exchange targeting option. This will be populated in the details field of an
    /// AssignedTargetingOption when targeting_type is `TARGETING_TYPE_SUB_EXCHANGE`.</summary>
    public class SubExchangeAssignedTargetingOptionDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The targeting_option_id of a TargetingOption of type
        /// `TARGETING_TYPE_SUB_EXCHANGE`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetingOptionId")]
        public virtual string TargetingOptionId { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Represents a targetable sub-exchange. This will be populated in the sub_exchange_details field of a
    /// TargetingOption when targeting_type is `TARGETING_TYPE_SUB_EXCHANGE`.</summary>
    public class SubExchangeTargetingOptionDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The display name of the sub-exchange.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Represents a single targeting option, which is a targetable concept in DV360.</summary>
    public class TargetingOption : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Age range details.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ageRangeDetails")]
        public virtual AgeRangeTargetingOptionDetails AgeRangeDetails { get; set; } 

        /// <summary>App category details.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("appCategoryDetails")]
        public virtual AppCategoryTargetingOptionDetails AppCategoryDetails { get; set; } 

        /// <summary>Authorized seller status resource details.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("authorizedSellerStatusDetails")]
        public virtual AuthorizedSellerStatusTargetingOptionDetails AuthorizedSellerStatusDetails { get; set; } 

        /// <summary>Browser details.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("browserDetails")]
        public virtual BrowserTargetingOptionDetails BrowserDetails { get; set; } 

        /// <summary>Carrier and ISP details.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("carrierAndIspDetails")]
        public virtual CarrierAndIspTargetingOptionDetails CarrierAndIspDetails { get; set; } 

        /// <summary>Category resource details.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("categoryDetails")]
        public virtual CategoryTargetingOptionDetails CategoryDetails { get; set; } 

        /// <summary>Content instream position details.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contentInstreamPositionDetails")]
        public virtual ContentInstreamPositionTargetingOptionDetails ContentInstreamPositionDetails { get; set; } 

        /// <summary>Content outstream position details.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contentOutstreamPositionDetails")]
        public virtual ContentOutstreamPositionTargetingOptionDetails ContentOutstreamPositionDetails { get; set; } 

        /// <summary>Device make and model resource details.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deviceMakeModelDetails")]
        public virtual DeviceMakeModelTargetingOptionDetails DeviceMakeModelDetails { get; set; } 

        /// <summary>Device type details.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deviceTypeDetails")]
        public virtual DeviceTypeTargetingOptionDetails DeviceTypeDetails { get; set; } 

        /// <summary>Digital content label details.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("digitalContentLabelDetails")]
        public virtual DigitalContentLabelTargetingOptionDetails DigitalContentLabelDetails { get; set; } 

        /// <summary>Environment details.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("environmentDetails")]
        public virtual EnvironmentTargetingOptionDetails EnvironmentDetails { get; set; } 

        /// <summary>Exchange details.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exchangeDetails")]
        public virtual ExchangeTargetingOptionDetails ExchangeDetails { get; set; } 

        /// <summary>Gender details.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("genderDetails")]
        public virtual GenderTargetingOptionDetails GenderDetails { get; set; } 

        /// <summary>Geographic region resource details.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("geoRegionDetails")]
        public virtual GeoRegionTargetingOptionDetails GeoRegionDetails { get; set; } 

        /// <summary>Household income details.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("householdIncomeDetails")]
        public virtual HouseholdIncomeTargetingOptionDetails HouseholdIncomeDetails { get; set; } 

        /// <summary>Language resource details.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("languageDetails")]
        public virtual LanguageTargetingOptionDetails LanguageDetails { get; set; } 

        /// <summary>Output only. The resource name for this targeting option.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; } 

        /// <summary>On screen position details.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("onScreenPositionDetails")]
        public virtual OnScreenPositionTargetingOptionDetails OnScreenPositionDetails { get; set; } 

        /// <summary>Operating system resources details.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operatingSystemDetails")]
        public virtual OperatingSystemTargetingOptionDetails OperatingSystemDetails { get; set; } 

        /// <summary>Parental status details.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parentalStatusDetails")]
        public virtual ParentalStatusTargetingOptionDetails ParentalStatusDetails { get; set; } 

        /// <summary>Sensitive Category details.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sensitiveCategoryDetails")]
        public virtual SensitiveCategoryTargetingOptionDetails SensitiveCategoryDetails { get; set; } 

        /// <summary>Sub-exchange details.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subExchangeDetails")]
        public virtual SubExchangeTargetingOptionDetails SubExchangeDetails { get; set; } 

        /// <summary>Output only. A unique identifier for this targeting option. The tuple {`targeting_type`,
        /// `targeting_option_id`} will be unique.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetingOptionId")]
        public virtual string TargetingOptionId { get; set; } 

        /// <summary>Output only. The type of this targeting option.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetingType")]
        public virtual string TargetingType { get; set; } 

        /// <summary>User rewarded content details.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userRewardedContentDetails")]
        public virtual UserRewardedContentTargetingOptionDetails UserRewardedContentDetails { get; set; } 

        /// <summary>Video player size details.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("videoPlayerSizeDetails")]
        public virtual VideoPlayerSizeTargetingOptionDetails VideoPlayerSizeDetails { get; set; } 

        /// <summary>Viewability resource details.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("viewabilityDetails")]
        public virtual ViewabilityTargetingOptionDetails ViewabilityDetails { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Settings for advertisers that use third-party ad servers only.</summary>
    public class ThirdPartyOnlyConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Whether or not order ID reporting for pixels is enabled. This value cannot be changed once set to
        /// `true`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pixelOrderIdReportingEnabled")]
        public virtual System.Nullable<bool> PixelOrderIdReportingEnabled { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Tracking URLs from third parties to track interactions with an audio or a video creative.</summary>
    public class ThirdPartyUrl : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The type of interaction needs to be tracked by the tracking URL</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; } 

        /// <summary>Tracking URL used to track the interaction. Provide a URL with optional path or query string,
        /// beginning with `https:`. For example, https://www.example.com/path</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("url")]
        public virtual string Url { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Assigned third party verifier targeting option details. This will be populated in the details field of
    /// an AssignedTargetingOption when targeting_type is `TARGETING_TYPE_THIRD_PARTY_VERIFIER`.</summary>
    public class ThirdPartyVerifierAssignedTargetingOptionDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Third party brand verifier -- Adloox.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("adloox")]
        public virtual Adloox Adloox { get; set; } 

        /// <summary>Third party brand verifier -- DoubleVerify.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("doubleVerify")]
        public virtual DoubleVerify DoubleVerify { get; set; } 

        /// <summary>Third party brand verifier -- Integral Ad Science.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("integralAdScience")]
        public virtual IntegralAdScience IntegralAdScience { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A time range.</summary>
    public class TimeRange : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The upper bound of a time range, inclusive.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endTime")]
        public virtual object EndTime { get; set; } 

        /// <summary>Required. The lower bound of a time range, inclusive.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTime")]
        public virtual object StartTime { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Timer event of the creative.</summary>
    public class TimerEvent : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The name of the timer event.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; } 

        /// <summary>Required. The name used to identify this timer event in reports.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reportingName")]
        public virtual string ReportingName { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Settings that control the behavior of a single Floodlight activity config.</summary>
    public class TrackingFloodlightActivityConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The ID of the Floodlight activity.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("floodlightActivityId")]
        public virtual System.Nullable<long> FloodlightActivityId { get; set; } 

        /// <summary>Required. The number of days after an ad has been clicked in which a conversion may be counted.
        /// Must be between 0 and 90 inclusive.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("postClickLookbackWindowDays")]
        public virtual System.Nullable<int> PostClickLookbackWindowDays { get; set; } 

        /// <summary>Required. The number of days after an ad has been viewed in which a conversion may be counted. Must
        /// be between 0 and 90 inclusive.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("postViewLookbackWindowDays")]
        public virtual System.Nullable<int> PostViewLookbackWindowDays { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Represents information about the transcoded audio or video file.</summary>
    public class Transcode : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The bit rate for the audio stream of the transcoded video, or the bit rate for the transcoded
        /// audio, in kilobits per second.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("audioBitRateKbps")]
        public virtual System.Nullable<long> AudioBitRateKbps { get; set; } 

        /// <summary>The sample rate for the audio stream of the transcoded video, or the sample rate for the transcoded
        /// audio, in hertz.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("audioSampleRateHz")]
        public virtual System.Nullable<long> AudioSampleRateHz { get; set; } 

        /// <summary>The transcoding bit rate of the transcoded video, in kilobits per second.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bitRateKbps")]
        public virtual System.Nullable<long> BitRateKbps { get; set; } 

        /// <summary>The dimensions of the transcoded video.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dimensions")]
        public virtual Dimensions Dimensions { get; set; } 

        /// <summary>The size of the transcoded file, in bytes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fileSizeBytes")]
        public virtual System.Nullable<long> FileSizeBytes { get; set; } 

        /// <summary>The frame rate of the transcoded video, in frames per second.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("frameRate")]
        public virtual System.Nullable<float> FrameRate { get; set; } 

        /// <summary>The MIME type of the transcoded file.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mimeType")]
        public virtual string MimeType { get; set; } 

        /// <summary>The name of the transcoded file.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; } 

        /// <summary>Indicates if the transcoding was successful.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("transcoded")]
        public virtual System.Nullable<bool> Transcoded { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A creative identifier provided by a registry that is unique across all platforms. This is part of the
    /// VAST 4.0 standard.</summary>
    public class UniversalAdId : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The unique creative identifier.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; } 

        /// <summary>The registry provides unique creative identifiers.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("registry")]
        public virtual string Registry { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Details for assigned URL targeting option. This will be populated in the details field of an
    /// AssignedTargetingOption when targeting_type is `TARGETING_TYPE_URL`.</summary>
    public class UrlAssignedTargetingOptionDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Indicates if this option is being negatively targeted.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("negative")]
        public virtual System.Nullable<bool> Negative { get; set; } 

        /// <summary>Required. The URL, for example `example.com`. DV360 supports two levels of subdirectory targeting,
        /// for example `www.example.com/one-subdirectory-level/second-level`, and five levels of subdomain targeting,
        /// for example `five.four.three.two.one.example.com`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("url")]
        public virtual string Url { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A single user in Display & Video 360.</summary>
    public class User : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The assigned user roles. Required in CreateUser. Output only in UpdateUser. Can only be updated
        /// through BulkEditAssignedUserRoles.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("assignedUserRoles")]
        public virtual System.Collections.Generic.IList<AssignedUserRole> AssignedUserRoles { get; set; } 

        /// <summary>Required. The display name of the user. Must be UTF-8 encoded with a maximum size of 240
        /// bytes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; } 

        /// <summary>Required. Immutable. The email address used to identify the user.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("email")]
        public virtual string Email { get; set; } 

        /// <summary>Output only. The resource name of the user.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; } 

        /// <summary>Output only. The unique ID of the user. Assigned by the system.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userId")]
        public virtual System.Nullable<long> UserId { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>User rewarded content targeting option details. This will be populated in the
    /// user_rewarded_content_details field when targeting_type is `TARGETING_TYPE_USER_REWARDED_CONTENT`.</summary>
    public class UserRewardedContentAssignedTargetingOptionDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The targeting_option_id field when targeting_type is
        /// `TARGETING_TYPE_USER_REWARDED_CONTENT`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetingOptionId")]
        public virtual string TargetingOptionId { get; set; } 

        /// <summary>Output only. User rewarded content status for video ads.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userRewardedContent")]
        public virtual string UserRewardedContent { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Represents a targetable user rewarded content status for video ads only. This will be populated in the
    /// user_rewarded_content_details field when targeting_type is `TARGETING_TYPE_USER_REWARDED_CONTENT`.</summary>
    public class UserRewardedContentTargetingOptionDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. User rewarded content status for video ads.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userRewardedContent")]
        public virtual string UserRewardedContent { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Video player size targeting option details. This will be populated in the video_player_size_details
    /// field when targeting_type is `TARGETING_TYPE_VIDEO_PLAYER_SIZE`. Explicitly targeting all options is not
    /// supported. Remove all video player size targeting options to achieve this effect.</summary>
    public class VideoPlayerSizeAssignedTargetingOptionDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The targeting_option_id field when targeting_type is
        /// `TARGETING_TYPE_VIDEO_PLAYER_SIZE`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetingOptionId")]
        public virtual string TargetingOptionId { get; set; } 

        /// <summary>Output only. The video player size.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("videoPlayerSize")]
        public virtual string VideoPlayerSize { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Represents a targetable video player size. This will be populated in the video_player_size_details
    /// field when targeting_type is `TARGETING_TYPE_VIDEO_PLAYER_SIZE`.</summary>
    public class VideoPlayerSizeTargetingOptionDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The video player size.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("videoPlayerSize")]
        public virtual string VideoPlayerSize { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Assigned viewability targeting option details. This will be populated in the viewability_details field
    /// of an AssignedTargetingOption when targeting_type is `TARGETING_TYPE_VIEWABILITY`.</summary>
    public class ViewabilityAssignedTargetingOptionDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The targeting_option_id of a TargetingOption of type `TARGETING_TYPE_VIEWABILITY` (e.g.,
        /// "509010" for targeting the `VIEWABILITY_10_PERCENT_OR_MORE` option).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetingOptionId")]
        public virtual string TargetingOptionId { get; set; } 

        /// <summary>Output only. The predicted viewability percentage.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("viewability")]
        public virtual string Viewability { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Represents a targetable viewability. This will be populated in the viewability_details field of a
    /// TargetingOption when targeting_type is `TARGETING_TYPE_VIEWABILITY`.</summary>
    public class ViewabilityTargetingOptionDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The predicted viewability percentage.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("viewability")]
        public virtual string Viewability { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
