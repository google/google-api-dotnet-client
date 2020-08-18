// Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file except in compliance with
// the License. You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software distributed under the License is distributed on
// an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the License for the
// specific language governing permissions and limitations under the License.

// Generated code. DO NOT EDIT!

namespace Google.Apis.CloudTalentSolution.v2
{
    /// <summary>The CloudTalentSolution Service.</summary>
    public class CloudTalentSolutionService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v2";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed =
            Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public CloudTalentSolutionService() :
            this(new Google.Apis.Services.BaseClientService.Initializer()) {}

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public CloudTalentSolutionService(Google.Apis.Services.BaseClientService.Initializer initializer)
            : base(initializer)
        {
            Companies = new CompaniesResource(this);
            Jobs = new JobsResource(this);
            V2 = new V2Resource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "jobs";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri =>
        #if NETSTANDARD1_3 || NETSTANDARD2_0 || NET45
            BaseUriOverride ?? "https://jobs.googleapis.com/";
        #else
            "https://jobs.googleapis.com/";
        #endif

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        #if !NET40
        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri => "https://jobs.googleapis.com/batch";

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";
        #endif

        /// <summary>Available OAuth 2.0 scopes for use with the Cloud Talent Solution API.</summary>
        public class Scope
        {
            /// <summary>View and manage your data across Google Cloud Platform services</summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";

            /// <summary>Manage job postings</summary>
            public static string Jobs = "https://www.googleapis.com/auth/jobs";

        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Cloud Talent Solution API.</summary>
        public static class ScopeConstants
        {
            /// <summary>View and manage your data across Google Cloud Platform services</summary>
            public const string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";

            /// <summary>Manage job postings</summary>
            public const string Jobs = "https://www.googleapis.com/auth/jobs";

        }



        /// <summary>Gets the Companies resource.</summary>
        public virtual CompaniesResource Companies { get; }

        /// <summary>Gets the Jobs resource.</summary>
        public virtual JobsResource Jobs { get; }

        /// <summary>Gets the V2 resource.</summary>
        public virtual V2Resource V2 { get; }
    }

    ///<summary>A base abstract class for CloudTalentSolution requests.</summary>
    public abstract class CloudTalentSolutionBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        ///<summary>Constructs a new CloudTalentSolutionBaseServiceRequest instance.</summary>
        protected CloudTalentSolutionBaseServiceRequest(Google.Apis.Services.IClientService service)
            : base(service)
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
        /// [default: json]
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
        /// [default: true]
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

        /// <summary>Initializes CloudTalentSolution parameter list.</summary>
        protected override void InitParameters()
        {
            base.InitParameters();

            RequestParameters.Add(
                "$.xgafv", new Google.Apis.Discovery.Parameter
                {
                    Name = "$.xgafv",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            RequestParameters.Add(
                "access_token", new Google.Apis.Discovery.Parameter
                {
                    Name = "access_token",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
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
                "callback", new Google.Apis.Discovery.Parameter
                {
                    Name = "callback",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
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
                "uploadType", new Google.Apis.Discovery.Parameter
                {
                    Name = "uploadType",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            RequestParameters.Add(
                "upload_protocol", new Google.Apis.Discovery.Parameter
                {
                    Name = "upload_protocol",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
        }
    }

    /// <summary>The "companies" collection of methods.</summary>
    public class CompaniesResource
    {
        private const string Resource = "companies";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public CompaniesResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
            Jobs = new JobsResource(service);

        }

        /// <summary>Gets the Jobs resource.</summary>
        public virtual JobsResource Jobs { get; }

        /// <summary>The "jobs" collection of methods.</summary>
        public class JobsResource
        {
            private const string Resource = "jobs";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public JobsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;

            }


            /// <summary>Deprecated. Use ListJobs instead.
            ///
            /// Lists all jobs associated with a company.</summary>
            /// <param name="companyName">Required. The resource name of the company that owns the jobs to be listed, such as,
            /// "companies/0000aaaa-1111-bbbb-2222-cccc3333dddd".</param>
            public virtual ListRequest List(string companyName)
            {
                return new ListRequest(service, companyName);
            }

            /// <summary>Deprecated. Use ListJobs instead.
            ///
            /// Lists all jobs associated with a company.</summary>
            public class ListRequest : CloudTalentSolutionBaseServiceRequest<Google.Apis.CloudTalentSolution.v2.Data.ListCompanyJobsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string companyName)
                    : base(service)
                {
                    CompanyName = companyName;
                    InitParameters();
                }


                /// <summary>Required. The resource name of the company that owns the jobs to be listed, such as,
                /// "companies/0000aaaa-1111-bbbb-2222-cccc3333dddd".</summary>
                [Google.Apis.Util.RequestParameterAttribute("companyName", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string CompanyName { get; private set; }

                /// <summary>Optional. If set to `true`, only job ID, job requisition ID and language code will be
                /// returned.
                ///
                /// A typical use is to synchronize job repositories.
                ///
                /// Defaults to false.</summary>
                [Google.Apis.Util.RequestParameterAttribute("idsOnly", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<bool> IdsOnly { get; set; }

                /// <summary>Deprecated. Please DO NOT use this field except for small companies. Suggest counting jobs
                /// page by page instead.
                ///
                /// Optional.
                ///
                /// Set to true if the total number of open jobs is to be returned.
                ///
                /// Defaults to false.</summary>
                [Google.Apis.Util.RequestParameterAttribute("includeJobsCount", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<bool> IncludeJobsCount { get; set; }

                /// <summary>Optional. The requisition ID, also known as posting ID, assigned by the company to the job.
                ///
                /// The maximum number of allowable characters is 225.</summary>
                [Google.Apis.Util.RequestParameterAttribute("jobRequisitionId", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string JobRequisitionId { get; set; }

                /// <summary>Optional. The maximum number of jobs to be returned per page of results.
                ///
                /// If ids_only is set to true, the maximum allowed page size is 1000. Otherwise, the maximum allowed
                /// page size is 100.
                ///
                /// Default is 100 if empty or a number < 1 is specified.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>Optional. The starting point of a query result.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }


                ///<summary>Gets the method name.</summary>
                public override string MethodName => "list";

                ///<summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                ///<summary>Gets the REST path.</summary>
                public override string RestPath => "v2/{+companyName}/jobs";

                /// <summary>Initializes List parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();

                    RequestParameters.Add(
                        "companyName", new Google.Apis.Discovery.Parameter
                        {
                            Name = "companyName",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^companies/[^/]+$",
                        });
                    RequestParameters.Add(
                        "idsOnly", new Google.Apis.Discovery.Parameter
                        {
                            Name = "idsOnly",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    RequestParameters.Add(
                        "includeJobsCount", new Google.Apis.Discovery.Parameter
                        {
                            Name = "includeJobsCount",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    RequestParameters.Add(
                        "jobRequisitionId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "jobRequisitionId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    RequestParameters.Add(
                        "pageSize", new Google.Apis.Discovery.Parameter
                        {
                            Name = "pageSize",
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
                }

            }
        }

        /// <summary>Creates a new company entity.</summary>
        /// <param name="body">The body of the request.</param>
        public virtual CreateRequest Create(Google.Apis.CloudTalentSolution.v2.Data.Company body)
        {
            return new CreateRequest(service, body);
        }

        /// <summary>Creates a new company entity.</summary>
        public class CreateRequest : CloudTalentSolutionBaseServiceRequest<Google.Apis.CloudTalentSolution.v2.Data.Company>
        {
            /// <summary>Constructs a new Create request.</summary>
            public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudTalentSolution.v2.Data.Company body)
                : base(service)
            {
                Body = body;
                InitParameters();
            }



            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.CloudTalentSolution.v2.Data.Company Body { get; set; }

            ///<summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            ///<summary>Gets the method name.</summary>
            public override string MethodName => "create";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "v2/companies";

            /// <summary>Initializes Create parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

            }

        }

        /// <summary>Deletes the specified company.</summary>
        /// <param name="name">Required. The resource name of the company to be deleted, such as,
        /// "companies/0000aaaa-1111-bbbb-2222-cccc3333dddd".</param>
        public virtual DeleteRequest Delete(string name)
        {
            return new DeleteRequest(service, name);
        }

        /// <summary>Deletes the specified company.</summary>
        public class DeleteRequest : CloudTalentSolutionBaseServiceRequest<Google.Apis.CloudTalentSolution.v2.Data.Empty>
        {
            /// <summary>Constructs a new Delete request.</summary>
            public DeleteRequest(Google.Apis.Services.IClientService service, string name)
                : base(service)
            {
                Name = name;
                InitParameters();
            }


            /// <summary>Required. The resource name of the company to be deleted, such as,
            /// "companies/0000aaaa-1111-bbbb-2222-cccc3333dddd".</summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }


            ///<summary>Gets the method name.</summary>
            public override string MethodName => "delete";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "DELETE";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "v2/{+name}";

            /// <summary>Initializes Delete parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^companies/[^/]+$",
                    });
            }

        }

        /// <summary>Retrieves the specified company.</summary>
        /// <param name="name">Required. Resource name of the company to retrieve, such as
        /// "companies/0000aaaa-1111-bbbb-2222-cccc3333dddd".</param>
        public virtual GetRequest Get(string name)
        {
            return new GetRequest(service, name);
        }

        /// <summary>Retrieves the specified company.</summary>
        public class GetRequest : CloudTalentSolutionBaseServiceRequest<Google.Apis.CloudTalentSolution.v2.Data.Company>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string name)
                : base(service)
            {
                Name = name;
                InitParameters();
            }


            /// <summary>Required. Resource name of the company to retrieve, such as
            /// "companies/0000aaaa-1111-bbbb-2222-cccc3333dddd".</summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }


            ///<summary>Gets the method name.</summary>
            public override string MethodName => "get";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "v2/{+name}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^companies/[^/]+$",
                    });
            }

        }

        /// <summary>Lists all companies associated with a Cloud Talent Solution account.</summary>
        public virtual ListRequest List()
        {
            return new ListRequest(service);
        }

        /// <summary>Lists all companies associated with a Cloud Talent Solution account.</summary>
        public class ListRequest : CloudTalentSolutionBaseServiceRequest<Google.Apis.CloudTalentSolution.v2.Data.ListCompaniesResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service)
                : base(service)
            {
                InitParameters();
            }


            /// <summary>Optional. Set to true if the companies request must have open jobs.
            ///
            /// Defaults to false.
            ///
            /// If true, at most page_size of companies are fetched, among which only those with open jobs are
            /// returned.</summary>
            [Google.Apis.Util.RequestParameterAttribute("mustHaveOpenJobs", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> MustHaveOpenJobs { get; set; }

            /// <summary>Optional. The maximum number of companies to be returned, at most 100. Default is 100 if a non-
            /// positive number is provided.</summary>
            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> PageSize { get; set; }

            /// <summary>Optional. The starting indicator from which to return results.</summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }


            ///<summary>Gets the method name.</summary>
            public override string MethodName => "list";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "v2/companies";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "mustHaveOpenJobs", new Google.Apis.Discovery.Parameter
                    {
                        Name = "mustHaveOpenJobs",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "pageSize", new Google.Apis.Discovery.Parameter
                    {
                        Name = "pageSize",
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
            }

        }

        /// <summary>Updates the specified company. Company names can't be updated. To update a company name, delete the
        /// company and all jobs associated with it, and only then re-create them.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="name">Required during company update.
        ///
        /// The resource name for a company. This is generated by the service when a company is created, for example,
        /// "companies/0000aaaa-1111-bbbb-2222-cccc3333dddd".</param>
        public virtual PatchRequest Patch(Google.Apis.CloudTalentSolution.v2.Data.Company body, string name)
        {
            return new PatchRequest(service, body, name);
        }

        /// <summary>Updates the specified company. Company names can't be updated. To update a company name, delete the
        /// company and all jobs associated with it, and only then re-create them.</summary>
        public class PatchRequest : CloudTalentSolutionBaseServiceRequest<Google.Apis.CloudTalentSolution.v2.Data.Company>
        {
            /// <summary>Constructs a new Patch request.</summary>
            public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudTalentSolution.v2.Data.Company body, string name)
                : base(service)
            {
                Name = name;
                Body = body;
                InitParameters();
            }


            /// <summary>Required during company update.
            ///
            /// The resource name for a company. This is generated by the service when a company is created, for
            /// example, "companies/0000aaaa-1111-bbbb-2222-cccc3333dddd".</summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Optional but strongly recommended to be provided for the best service experience.
            ///
            /// If update_company_fields is provided, only the specified fields in company are updated. Otherwise all
            /// the fields are updated.
            ///
            /// A field mask to specify the company fields to update. Valid values are:
            ///
            /// * displayName * website * imageUrl * companySize * distributorBillingCompanyId * companyInfoSources *
            /// careerPageLink * hiringAgency * hqLocation * eeoText * keywordSearchableCustomAttributes * title
            /// (deprecated) * keywordSearchableCustomFields (deprecated)</summary>
            [Google.Apis.Util.RequestParameterAttribute("updateCompanyFields", Google.Apis.Util.RequestParameterType.Query)]
            public virtual object UpdateCompanyFields { get; set; }


            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.CloudTalentSolution.v2.Data.Company Body { get; set; }

            ///<summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            ///<summary>Gets the method name.</summary>
            public override string MethodName => "patch";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PATCH";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "v2/{+name}";

            /// <summary>Initializes Patch parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^companies/[^/]+$",
                    });
                RequestParameters.Add(
                    "updateCompanyFields", new Google.Apis.Discovery.Parameter
                    {
                        Name = "updateCompanyFields",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }
    }

    /// <summary>The "jobs" collection of methods.</summary>
    public class JobsResource
    {
        private const string Resource = "jobs";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public JobsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;

        }


        /// <summary>Deletes a list of Job postings by filter.</summary>
        /// <param name="body">The body of the request.</param>
        public virtual BatchDeleteRequest BatchDelete(Google.Apis.CloudTalentSolution.v2.Data.BatchDeleteJobsRequest body)
        {
            return new BatchDeleteRequest(service, body);
        }

        /// <summary>Deletes a list of Job postings by filter.</summary>
        public class BatchDeleteRequest : CloudTalentSolutionBaseServiceRequest<Google.Apis.CloudTalentSolution.v2.Data.Empty>
        {
            /// <summary>Constructs a new BatchDelete request.</summary>
            public BatchDeleteRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudTalentSolution.v2.Data.BatchDeleteJobsRequest body)
                : base(service)
            {
                Body = body;
                InitParameters();
            }



            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.CloudTalentSolution.v2.Data.BatchDeleteJobsRequest Body { get; set; }

            ///<summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            ///<summary>Gets the method name.</summary>
            public override string MethodName => "batchDelete";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "v2/jobs:batchDelete";

            /// <summary>Initializes BatchDelete parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

            }

        }

        /// <summary>Creates a new job.
        ///
        /// Typically, the job becomes searchable within 10 seconds, but it may take up to 5 minutes.</summary>
        /// <param name="body">The body of the request.</param>
        public virtual CreateRequest Create(Google.Apis.CloudTalentSolution.v2.Data.CreateJobRequest body)
        {
            return new CreateRequest(service, body);
        }

        /// <summary>Creates a new job.
        ///
        /// Typically, the job becomes searchable within 10 seconds, but it may take up to 5 minutes.</summary>
        public class CreateRequest : CloudTalentSolutionBaseServiceRequest<Google.Apis.CloudTalentSolution.v2.Data.Job>
        {
            /// <summary>Constructs a new Create request.</summary>
            public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudTalentSolution.v2.Data.CreateJobRequest body)
                : base(service)
            {
                Body = body;
                InitParameters();
            }



            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.CloudTalentSolution.v2.Data.CreateJobRequest Body { get; set; }

            ///<summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            ///<summary>Gets the method name.</summary>
            public override string MethodName => "create";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "v2/jobs";

            /// <summary>Initializes Create parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

            }

        }

        /// <summary>Deletes the specified job.
        ///
        /// Typically, the job becomes unsearchable within 10 seconds, but it may take up to 5 minutes.</summary>
        /// <param name="name">Required. The resource name of the job to be deleted, such as "jobs/11111111".</param>
        public virtual DeleteRequest Delete(string name)
        {
            return new DeleteRequest(service, name);
        }

        /// <summary>Deletes the specified job.
        ///
        /// Typically, the job becomes unsearchable within 10 seconds, but it may take up to 5 minutes.</summary>
        public class DeleteRequest : CloudTalentSolutionBaseServiceRequest<Google.Apis.CloudTalentSolution.v2.Data.Empty>
        {
            /// <summary>Constructs a new Delete request.</summary>
            public DeleteRequest(Google.Apis.Services.IClientService service, string name)
                : base(service)
            {
                Name = name;
                InitParameters();
            }


            /// <summary>Required. The resource name of the job to be deleted, such as "jobs/11111111".</summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Deprecated. This field is not working anymore.
            ///
            /// Optional.
            ///
            /// If set to true, this call waits for all processing steps to complete before the job is cleaned up.
            /// Otherwise, the call returns while some steps are still taking place asynchronously, hence
            /// faster.</summary>
            [Google.Apis.Util.RequestParameterAttribute("disableFastProcess", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> DisableFastProcess { get; set; }


            ///<summary>Gets the method name.</summary>
            public override string MethodName => "delete";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "DELETE";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "v2/{+name}";

            /// <summary>Initializes Delete parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^jobs/[^/]+$",
                    });
                RequestParameters.Add(
                    "disableFastProcess", new Google.Apis.Discovery.Parameter
                    {
                        Name = "disableFastProcess",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }

        /// <summary>Deprecated. Use BatchDeleteJobs instead.
        ///
        /// Deletes the specified job by filter. You can specify whether to synchronously wait for validation, indexing,
        /// and general processing to be completed before the response is returned.</summary>
        /// <param name="body">The body of the request.</param>
        public virtual DeleteByFilterRequest DeleteByFilter(Google.Apis.CloudTalentSolution.v2.Data.DeleteJobsByFilterRequest body)
        {
            return new DeleteByFilterRequest(service, body);
        }

        /// <summary>Deprecated. Use BatchDeleteJobs instead.
        ///
        /// Deletes the specified job by filter. You can specify whether to synchronously wait for validation, indexing,
        /// and general processing to be completed before the response is returned.</summary>
        public class DeleteByFilterRequest : CloudTalentSolutionBaseServiceRequest<Google.Apis.CloudTalentSolution.v2.Data.Empty>
        {
            /// <summary>Constructs a new DeleteByFilter request.</summary>
            public DeleteByFilterRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudTalentSolution.v2.Data.DeleteJobsByFilterRequest body)
                : base(service)
            {
                Body = body;
                InitParameters();
            }



            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.CloudTalentSolution.v2.Data.DeleteJobsByFilterRequest Body { get; set; }

            ///<summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            ///<summary>Gets the method name.</summary>
            public override string MethodName => "deleteByFilter";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "v2/jobs:deleteByFilter";

            /// <summary>Initializes DeleteByFilter parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

            }

        }

        /// <summary>Retrieves the specified job, whose status is OPEN or recently EXPIRED within the last 90
        /// days.</summary>
        /// <param name="name">Required. The resource name of the job to retrieve, such as "jobs/11111111".</param>
        public virtual GetRequest Get(string name)
        {
            return new GetRequest(service, name);
        }

        /// <summary>Retrieves the specified job, whose status is OPEN or recently EXPIRED within the last 90
        /// days.</summary>
        public class GetRequest : CloudTalentSolutionBaseServiceRequest<Google.Apis.CloudTalentSolution.v2.Data.Job>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string name)
                : base(service)
            {
                Name = name;
                InitParameters();
            }


            /// <summary>Required. The resource name of the job to retrieve, such as "jobs/11111111".</summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }


            ///<summary>Gets the method name.</summary>
            public override string MethodName => "get";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "v2/{+name}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^jobs/[^/]+$",
                    });
            }

        }

        /// <summary>Deprecated. Use SearchJobsRequest.histogram_facets instead to make a single call with both search
        /// and histogram.
        ///
        /// Retrieves a histogram for the given GetHistogramRequest. This call provides a structured count of jobs that
        /// match against the search query, grouped by specified facets.
        ///
        /// This call constrains the visibility of jobs present in the database, and only counts jobs the caller has
        /// permission to search against.
        ///
        /// For example, use this call to generate the number of jobs in the U.S. by state.</summary>
        /// <param name="body">The body of the request.</param>
        public virtual HistogramRequest Histogram(Google.Apis.CloudTalentSolution.v2.Data.GetHistogramRequest body)
        {
            return new HistogramRequest(service, body);
        }

        /// <summary>Deprecated. Use SearchJobsRequest.histogram_facets instead to make a single call with both search
        /// and histogram.
        ///
        /// Retrieves a histogram for the given GetHistogramRequest. This call provides a structured count of jobs that
        /// match against the search query, grouped by specified facets.
        ///
        /// This call constrains the visibility of jobs present in the database, and only counts jobs the caller has
        /// permission to search against.
        ///
        /// For example, use this call to generate the number of jobs in the U.S. by state.</summary>
        public class HistogramRequest : CloudTalentSolutionBaseServiceRequest<Google.Apis.CloudTalentSolution.v2.Data.GetHistogramResponse>
        {
            /// <summary>Constructs a new Histogram request.</summary>
            public HistogramRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudTalentSolution.v2.Data.GetHistogramRequest body)
                : base(service)
            {
                Body = body;
                InitParameters();
            }



            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.CloudTalentSolution.v2.Data.GetHistogramRequest Body { get; set; }

            ///<summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            ///<summary>Gets the method name.</summary>
            public override string MethodName => "histogram";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "v2/jobs:histogram";

            /// <summary>Initializes Histogram parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

            }

        }

        /// <summary>Lists jobs by filter.</summary>
        public virtual ListRequest List()
        {
            return new ListRequest(service);
        }

        /// <summary>Lists jobs by filter.</summary>
        public class ListRequest : CloudTalentSolutionBaseServiceRequest<Google.Apis.CloudTalentSolution.v2.Data.ListJobsResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service)
                : base(service)
            {
                InitParameters();
            }


            /// <summary>Required. The filter string specifies the jobs to be enumerated.
            ///
            /// Supported operator: =, AND
            ///
            /// The fields eligible for filtering are:
            ///
            /// * `companyName` (Required) * `requisitionId` (Optional)
            ///
            /// Sample Query:
            ///
            /// * companyName = "companies/123" * companyName = "companies/123" AND requisitionId = "req-1"</summary>
            [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Filter { get; set; }

            /// <summary>Optional. If set to `true`, only Job.name, Job.requisition_id and Job.language_code will be
            /// returned.
            ///
            /// A typical use case is to synchronize job repositories.
            ///
            /// Defaults to false.</summary>
            [Google.Apis.Util.RequestParameterAttribute("idsOnly", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> IdsOnly { get; set; }

            /// <summary>Optional. The maximum number of jobs to be returned per page of results.
            ///
            /// If ids_only is set to true, the maximum allowed page size is 1000. Otherwise, the maximum allowed page
            /// size is 100.
            ///
            /// Default is 100 if empty or a number < 1 is specified.</summary>
            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> PageSize { get; set; }

            /// <summary>Optional. The starting point of a query result.</summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }


            ///<summary>Gets the method name.</summary>
            public override string MethodName => "list";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "v2/jobs";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "filter", new Google.Apis.Discovery.Parameter
                    {
                        Name = "filter",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "idsOnly", new Google.Apis.Discovery.Parameter
                    {
                        Name = "idsOnly",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "pageSize", new Google.Apis.Discovery.Parameter
                    {
                        Name = "pageSize",
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
            }

        }

        /// <summary>Updates specified job.
        ///
        /// Typically, updated contents become visible in search results within 10 seconds, but it may take up to 5
        /// minutes.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="name">Required during job update.
        ///
        /// Resource name assigned to a job by the API, for example, "/jobs/foo". Use of this field in job queries and API calls
        /// is preferred over the use of requisition_id since this value is unique.</param>
        public virtual PatchRequest Patch(Google.Apis.CloudTalentSolution.v2.Data.UpdateJobRequest body, string name)
        {
            return new PatchRequest(service, body, name);
        }

        /// <summary>Updates specified job.
        ///
        /// Typically, updated contents become visible in search results within 10 seconds, but it may take up to 5
        /// minutes.</summary>
        public class PatchRequest : CloudTalentSolutionBaseServiceRequest<Google.Apis.CloudTalentSolution.v2.Data.Job>
        {
            /// <summary>Constructs a new Patch request.</summary>
            public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudTalentSolution.v2.Data.UpdateJobRequest body, string name)
                : base(service)
            {
                Name = name;
                Body = body;
                InitParameters();
            }


            /// <summary>Required during job update.
            ///
            /// Resource name assigned to a job by the API, for example, "/jobs/foo". Use of this field in job queries
            /// and API calls is preferred over the use of requisition_id since this value is unique.</summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }


            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.CloudTalentSolution.v2.Data.UpdateJobRequest Body { get; set; }

            ///<summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            ///<summary>Gets the method name.</summary>
            public override string MethodName => "patch";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PATCH";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "v2/{+name}";

            /// <summary>Initializes Patch parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^jobs/[^/]+$",
                    });
            }

        }

        /// <summary>Searches for jobs using the provided SearchJobsRequest.
        ///
        /// This call constrains the visibility of jobs present in the database, and only returns jobs that the caller
        /// has permission to search against.</summary>
        /// <param name="body">The body of the request.</param>
        public virtual SearchRequest Search(Google.Apis.CloudTalentSolution.v2.Data.SearchJobsRequest body)
        {
            return new SearchRequest(service, body);
        }

        /// <summary>Searches for jobs using the provided SearchJobsRequest.
        ///
        /// This call constrains the visibility of jobs present in the database, and only returns jobs that the caller
        /// has permission to search against.</summary>
        public class SearchRequest : CloudTalentSolutionBaseServiceRequest<Google.Apis.CloudTalentSolution.v2.Data.SearchJobsResponse>
        {
            /// <summary>Constructs a new Search request.</summary>
            public SearchRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudTalentSolution.v2.Data.SearchJobsRequest body)
                : base(service)
            {
                Body = body;
                InitParameters();
            }



            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.CloudTalentSolution.v2.Data.SearchJobsRequest Body { get; set; }

            ///<summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            ///<summary>Gets the method name.</summary>
            public override string MethodName => "search";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "v2/jobs:search";

            /// <summary>Initializes Search parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

            }

        }

        /// <summary>Searches for jobs using the provided SearchJobsRequest.
        ///
        /// This API call is intended for the use case of targeting passive job seekers (for example, job seekers who
        /// have signed up to receive email alerts about potential job opportunities), and has different algorithmic
        /// adjustments that are targeted to passive job seekers.
        ///
        /// This call constrains the visibility of jobs present in the database, and only returns jobs the caller has
        /// permission to search against.</summary>
        /// <param name="body">The body of the request.</param>
        public virtual SearchForAlertRequest SearchForAlert(Google.Apis.CloudTalentSolution.v2.Data.SearchJobsRequest body)
        {
            return new SearchForAlertRequest(service, body);
        }

        /// <summary>Searches for jobs using the provided SearchJobsRequest.
        ///
        /// This API call is intended for the use case of targeting passive job seekers (for example, job seekers who
        /// have signed up to receive email alerts about potential job opportunities), and has different algorithmic
        /// adjustments that are targeted to passive job seekers.
        ///
        /// This call constrains the visibility of jobs present in the database, and only returns jobs the caller has
        /// permission to search against.</summary>
        public class SearchForAlertRequest : CloudTalentSolutionBaseServiceRequest<Google.Apis.CloudTalentSolution.v2.Data.SearchJobsResponse>
        {
            /// <summary>Constructs a new SearchForAlert request.</summary>
            public SearchForAlertRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudTalentSolution.v2.Data.SearchJobsRequest body)
                : base(service)
            {
                Body = body;
                InitParameters();
            }



            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.CloudTalentSolution.v2.Data.SearchJobsRequest Body { get; set; }

            ///<summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            ///<summary>Gets the method name.</summary>
            public override string MethodName => "searchForAlert";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "v2/jobs:searchForAlert";

            /// <summary>Initializes SearchForAlert parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

            }

        }
    }

    /// <summary>The "v2" collection of methods.</summary>
    public class V2Resource
    {
        private const string Resource = "v2";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public V2Resource(Google.Apis.Services.IClientService service)
        {
            this.service = service;

        }


        /// <summary>Completes the specified prefix with job keyword suggestions. Intended for use by a job search auto-
        /// complete search box.</summary>
        public virtual CompleteRequest Complete()
        {
            return new CompleteRequest(service);
        }

        /// <summary>Completes the specified prefix with job keyword suggestions. Intended for use by a job search auto-
        /// complete search box.</summary>
        public class CompleteRequest : CloudTalentSolutionBaseServiceRequest<Google.Apis.CloudTalentSolution.v2.Data.CompleteQueryResponse>
        {
            /// <summary>Constructs a new Complete request.</summary>
            public CompleteRequest(Google.Apis.Services.IClientService service)
                : base(service)
            {
                InitParameters();
            }


            /// <summary>Optional. If provided, restricts completion to the specified company.</summary>
            [Google.Apis.Util.RequestParameterAttribute("companyName", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string CompanyName { get; set; }

            /// <summary>Required. The language of the query. This is the BCP-47 language code, such as "en-US" or "sr-
            /// Latn". For more information, see [Tags for Identifying Languages](https://tools.ietf.org/html/bcp47).
            ///
            /// For CompletionType.JOB_TITLE type, only open jobs with same language_code are returned.
            ///
            /// For CompletionType.COMPANY_NAME type, only companies having open jobs with same language_code are
            /// returned.
            ///
            /// For CompletionType.COMBINED type, only open jobs with same language_code or companies having open jobs
            /// with same language_code are returned.</summary>
            [Google.Apis.Util.RequestParameterAttribute("languageCode", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string LanguageCode { get; set; }

            /// <summary>Required. Completion result count. The maximum allowed page size is 10.</summary>
            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> PageSize { get; set; }

            /// <summary>Required. The query used to generate suggestions.</summary>
            [Google.Apis.Util.RequestParameterAttribute("query", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Query { get; set; }

            /// <summary>Optional. The scope of the completion. The defaults is CompletionScope.PUBLIC.</summary>
            [Google.Apis.Util.RequestParameterAttribute("scope", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<ScopeEnum> Scope { get; set; }

            /// <summary>Optional. The scope of the completion. The defaults is CompletionScope.PUBLIC.</summary>
            public enum ScopeEnum
            {
                [Google.Apis.Util.StringValueAttribute("COMPLETION_SCOPE_UNSPECIFIED")]
                COMPLETIONSCOPEUNSPECIFIED,
                [Google.Apis.Util.StringValueAttribute("TENANT")]
                TENANT,
                [Google.Apis.Util.StringValueAttribute("PUBLIC")]
                PUBLIC__,
            }

            /// <summary>Optional. The completion topic. The default is CompletionType.COMBINED.</summary>
            [Google.Apis.Util.RequestParameterAttribute("type", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<TypeEnum> Type { get; set; }

            /// <summary>Optional. The completion topic. The default is CompletionType.COMBINED.</summary>
            public enum TypeEnum
            {
                [Google.Apis.Util.StringValueAttribute("COMPLETION_TYPE_UNSPECIFIED")]
                COMPLETIONTYPEUNSPECIFIED,
                [Google.Apis.Util.StringValueAttribute("JOB_TITLE")]
                JOBTITLE,
                [Google.Apis.Util.StringValueAttribute("COMPANY_NAME")]
                COMPANYNAME,
                [Google.Apis.Util.StringValueAttribute("COMBINED")]
                COMBINED,
            }


            ///<summary>Gets the method name.</summary>
            public override string MethodName => "complete";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "v2:complete";

            /// <summary>Initializes Complete parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "companyName", new Google.Apis.Discovery.Parameter
                    {
                        Name = "companyName",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "languageCode", new Google.Apis.Discovery.Parameter
                    {
                        Name = "languageCode",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "pageSize", new Google.Apis.Discovery.Parameter
                    {
                        Name = "pageSize",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "query", new Google.Apis.Discovery.Parameter
                    {
                        Name = "query",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "scope", new Google.Apis.Discovery.Parameter
                    {
                        Name = "scope",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "type", new Google.Apis.Discovery.Parameter
                    {
                        Name = "type",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }
    }
}

namespace Google.Apis.CloudTalentSolution.v2.Data
{    

    /// <summary>Input only.
    ///
    /// Batch delete jobs request.</summary>
    public class BatchDeleteJobsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The filter string specifies the jobs to be deleted.
        ///
        /// Supported operator: =, AND
        ///
        /// The fields eligible for filtering are:
        ///
        /// * `companyName` (Required) * `requisitionId` (Required)
        ///
        /// Sample Query: companyName = "companies/123" AND requisitionId = "req-1"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filter")]
        public virtual string Filter { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Represents starting and ending value of a range in double.</summary>
    public class BucketRange : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Starting value of the bucket range.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("from")]
        public virtual System.Nullable<double> From { get; set; } 

        /// <summary>Ending value of the bucket range.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("to")]
        public virtual System.Nullable<double> To { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Represents count of jobs within one bucket.</summary>
    public class BucketizedCount : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Number of jobs whose numeric field value fall into `range`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("count")]
        public virtual System.Nullable<int> Count { get; set; } 

        /// <summary>Bucket range on which histogram was performed for the numeric field, that is, the count represents
        /// number of jobs in this range.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("range")]
        public virtual BucketRange Range { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Output only.
    ///
    /// Commute details related to this job.</summary>
    public class CommuteInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Location used as the destination in the commute calculation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("jobLocation")]
        public virtual JobLocation JobLocation { get; set; } 

        /// <summary>The number of seconds required to travel to the job location from the query location. A duration of
        /// 0 seconds indicates that the job is not reachable within the requested duration, but was returned as part of
        /// an expanded query.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("travelDuration")]
        public virtual object TravelDuration { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Input only.
    ///
    /// Parameters needed for commute search.</summary>
    public class CommutePreference : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. If `true`, jobs without street level addresses may also be returned. For city level
        /// addresses, the city center is used. For state and coarser level addresses, text matching is used. If this
        /// field is set to `false` or is not specified, only jobs that include street level addresses will be returned
        /// by commute search.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowNonStreetLevelAddress")]
        public virtual System.Nullable<bool> AllowNonStreetLevelAddress { get; set; } 

        /// <summary>Optional. The departure hour to use to calculate traffic impact. Accepts an integer between 0 and
        /// 23, representing the hour in the time zone of the start_location. Must not be present if road_traffic is
        /// specified.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("departureHourLocal")]
        public virtual System.Nullable<int> DepartureHourLocal { get; set; } 

        /// <summary>Required. The method of transportation for which to calculate the commute time.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("method")]
        public virtual string Method { get; set; } 

        /// <summary>Optional. Specifies the traffic density to use when calculating commute time. Must not be present
        /// if departure_hour_local is specified.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("roadTraffic")]
        public virtual string RoadTraffic { get; set; } 

        /// <summary>Required. The latitude and longitude of the location from which to calculate the commute
        /// time.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startLocation")]
        public virtual LatLng StartLocation { get; set; } 

        /// <summary>Required. The maximum travel time in seconds. The maximum allowed value is `3600s` (one hour).
        /// Format is `123s`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("travelTime")]
        public virtual object TravelTime { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A Company resource represents a company in the service. A company is the entity that owns job listings,
    /// that is, the hiring entity responsible for employing applicants for the job position.</summary>
    public class Company : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The URL to employer's career site or careers page on the employer's web site.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("careerPageLink")]
        public virtual string CareerPageLink { get; set; } 

        /// <summary>Optional. Identifiers external to the application that help to further identify the
        /// employer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("companyInfoSources")]
        public virtual System.Collections.Generic.IList<CompanyInfoSource> CompanyInfoSources { get; set; } 

        /// <summary>Optional. The employer's company size.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("companySize")]
        public virtual string CompanySize { get; set; } 

        /// <summary>Deprecated. Do not use this field.
        ///
        /// Optional.
        ///
        /// This field is no longer used. Any value set to it is ignored.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disableLocationOptimization")]
        public virtual System.Nullable<bool> DisableLocationOptimization { get; set; } 

        /// <summary>Required. The name of the employer to be displayed with the job, for example, "Google,
        /// LLC.".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; } 

        /// <summary>Optional. The unique company identifier provided by the client to identify an employer for billing
        /// purposes. Recommended practice is to use the distributor_company_id.
        ///
        /// Defaults to same value as distributor_company_id when a value is not provided.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("distributorBillingCompanyId")]
        public virtual string DistributorBillingCompanyId { get; set; } 

        /// <summary>Required. A client's company identifier, used to uniquely identify the company. If an employer has
        /// a subsidiary or sub-brand, such as "Alphabet" and "Google", which the client wishes to use as the company
        /// displayed on the job. Best practice is to create a distinct company identifier for each distinct brand
        /// displayed.
        ///
        /// The maximum number of allowed characters is 255.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("distributorCompanyId")]
        public virtual string DistributorCompanyId { get; set; } 

        /// <summary>Optional. Equal Employment Opportunity legal disclaimer text to be associated with all jobs, and
        /// typically to be displayed in all roles.
        ///
        /// The maximum number of allowed characters is 500.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eeoText")]
        public virtual string EeoText { get; set; } 

        /// <summary>Optional. Set to true if it is the hiring agency that post jobs for other employers.
        ///
        /// Defaults to false if not provided.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hiringAgency")]
        public virtual System.Nullable<bool> HiringAgency { get; set; } 

        /// <summary>Optional. The street address of the company's main headquarters, which may be different from the
        /// job location. The service attempts to geolocate the provided address, and populates a more specific location
        /// wherever possible in structured_company_hq_location.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hqLocation")]
        public virtual string HqLocation { get; set; } 

        /// <summary>Optional. A URL that hosts the employer's company logo. If provided, the logo image should be
        /// squared at 80x80 pixels.
        ///
        /// The url must be a Google Photos or Google Album url. Only images in these Google sub-domains are
        /// accepted.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imageUrl")]
        public virtual string ImageUrl { get; set; } 

        /// <summary>Optional. A list of keys of filterable Job.custom_attributes, whose corresponding `string_values`
        /// are used in keyword search. Jobs with `string_values` under these specified field keys are returned if any
        /// of the values matches the search keyword. Custom field values with parenthesis, brackets and special symbols
        /// might not be properly searchable, and those keyword queries need to be surrounded by quotes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("keywordSearchableCustomAttributes")]
        public virtual System.Collections.Generic.IList<string> KeywordSearchableCustomAttributes { get; set; } 

        /// <summary>Deprecated. Use keyword_searchable_custom_attributes instead.
        ///
        /// Optional.
        ///
        /// A list of filterable custom fields that should be used in keyword search. The jobs of this company are
        /// returned if any of these custom fields matches the search keyword. Custom field values with parenthesis,
        /// brackets and special symbols might not be properly searchable, and those keyword queries need to be
        /// surrounded by quotes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("keywordSearchableCustomFields")]
        public virtual System.Collections.Generic.IList<System.Nullable<int>> KeywordSearchableCustomFields { get; set; } 

        /// <summary>Required during company update.
        ///
        /// The resource name for a company. This is generated by the service when a company is created, for example,
        /// "companies/0000aaaa-1111-bbbb-2222-cccc3333dddd".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; } 

        /// <summary>Output only. A structured headquarters location of the company, resolved from hq_location if
        /// possible.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("structuredCompanyHqLocation")]
        public virtual JobLocation StructuredCompanyHqLocation { get; set; } 

        /// <summary>Output only. Indicates whether a company is flagged to be suspended from public availability by the
        /// service when job content appears suspicious, abusive, or spammy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("suspended")]
        public virtual System.Nullable<bool> Suspended { get; set; } 

        /// <summary>Deprecated. Use display_name instead.
        ///
        /// Required.
        ///
        /// The name of the employer to be displayed with the job, for example, "Google, LLC.".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; } 

        /// <summary>Optional. The URL representing the company's primary web site or home page, such as,
        /// "www.google.com".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("website")]
        public virtual string Website { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A resource that represents an external  Google identifier for a company, for example, a Google+
    /// business page or a Google Maps business page. For unsupported types, use `unknown_type_id`.</summary>
    public class CompanyInfoSource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The Google's Knowledge Graph value for the employer's company.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("freebaseMid")]
        public virtual string FreebaseMid { get; set; } 

        /// <summary>Optional. The numeric identifier for the employer's Google+ business page.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gplusId")]
        public virtual string GplusId { get; set; } 

        /// <summary>Optional. The numeric identifier for the employer's headquarters on Google Maps, namely, the Google
        /// Maps CID (cell id).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mapsCid")]
        public virtual string MapsCid { get; set; } 

        /// <summary>Optional. A Google identifier that does not match any of the other types.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unknownTypeId")]
        public virtual string UnknownTypeId { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A compensation entry that represents one component of compensation, such as base pay, bonus, or other
    /// compensation type.
    ///
    /// Annualization: One compensation entry can be annualized if - it contains valid amount or range. - and its
    /// expected_units_per_year is set or can be derived. Its annualized range is determined as (amount or range) times
    /// expected_units_per_year.</summary>
    public class CompensationEntry : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Compensation amount.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("amount")]
        public virtual Money Amount { get; set; } 

        /// <summary>Optional. Compensation description.  For example, could indicate equity terms or provide additional
        /// context to an estimated bonus.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; } 

        /// <summary>Optional. Expected number of units paid each year. If not specified, when Job.employment_types is
        /// FULLTIME, a default value is inferred based on unit. Default values: - HOURLY: 2080 - DAILY: 260 - WEEKLY:
        /// 52 - MONTHLY: 12 - ANNUAL: 1</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expectedUnitsPerYear")]
        public virtual System.Nullable<double> ExpectedUnitsPerYear { get; set; } 

        /// <summary>Optional. Compensation range.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("range")]
        public virtual CompensationRange Range { get; set; } 

        /// <summary>Required. Compensation type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; } 

        /// <summary>Optional. Frequency of the specified amount.
        ///
        /// Default is CompensationUnit.COMPENSATION_UNIT_UNSPECIFIED.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unit")]
        public virtual string Unit { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Input only.
    ///
    /// Filter on job compensation type and amount.</summary>
    public class CompensationFilter : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Whether to include jobs whose compensation range is unspecified.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("includeJobsWithUnspecifiedCompensationRange")]
        public virtual System.Nullable<bool> IncludeJobsWithUnspecifiedCompensationRange { get; set; } 

        /// <summary>Optional. Compensation range.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("range")]
        public virtual CompensationRange Range { get; set; } 

        /// <summary>Required. Type of filter.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; } 

        /// <summary>Required. Specify desired `base compensation entry's` CompensationInfo.CompensationUnit.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("units")]
        public virtual System.Collections.Generic.IList<string> Units { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Input only.
    ///
    /// Compensation based histogram request.</summary>
    public class CompensationHistogramRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Numeric histogram options, like buckets, whether include min or max value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bucketingOption")]
        public virtual NumericBucketingOption BucketingOption { get; set; } 

        /// <summary>Required. Type of the request, representing which field the histogramming should be performed over.
        /// A single request can only specify one histogram of each `CompensationHistogramRequestType`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Output only.
    ///
    /// Compensation based histogram result.</summary>
    public class CompensationHistogramResult : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Histogram result.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("result")]
        public virtual NumericBucketingResult Result { get; set; } 

        /// <summary>Type of the request, corresponding to CompensationHistogramRequest.type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Job compensation details.</summary>
    public class CompensationInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Deprecated. Use entries instead.
        ///
        /// Optional.
        ///
        /// The amount of compensation or pay for the job. As an alternative, compensation_amount_min and
        /// compensation_amount_max may be used to define a range of compensation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("amount")]
        public virtual Money Amount { get; set; } 

        /// <summary>Output only. Annualized base compensation range. Computed as base compensation entry's
        /// CompensationEntry.compensation times CompensationEntry.expected_units_per_year.
        ///
        /// See CompensationEntry for explanation on compensation annualization.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("annualizedBaseCompensationRange")]
        public virtual CompensationRange AnnualizedBaseCompensationRange { get; set; } 

        /// <summary>Output only. Annualized total compensation range. Computed as all compensation entries'
        /// CompensationEntry.compensation times CompensationEntry.expected_units_per_year.
        ///
        /// See CompensationEntry for explanation on compensation annualization.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("annualizedTotalCompensationRange")]
        public virtual CompensationRange AnnualizedTotalCompensationRange { get; set; } 

        /// <summary>Optional. Job compensation information.
        ///
        /// At most one entry can be of type CompensationInfo.CompensationType.BASE, which is referred as ** base
        /// compensation entry ** for the job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entries")]
        public virtual System.Collections.Generic.IList<CompensationEntry> Entries { get; set; } 

        /// <summary>Deprecated. Use entries instead.
        ///
        /// Optional.
        ///
        /// An upper bound on a range for compensation or pay for the job. The currency type is specified in
        /// compensation_amount.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("max")]
        public virtual Money Max { get; set; } 

        /// <summary>Deprecated. Use entries instead.
        ///
        /// Optional.
        ///
        /// A lower bound on a range for compensation or pay for the job. The currency type is specified in
        /// compensation_amount.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("min")]
        public virtual Money Min { get; set; } 

        /// <summary>Deprecated. Use entries instead.
        ///
        /// Optional.
        ///
        /// Type of job compensation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Compensation range.</summary>
    public class CompensationRange : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The maximum amount of compensation. If left empty, the value is set to a maximal
        /// compensation value and the currency code is set to match the currency code of min_compensation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("max")]
        public virtual Money Max { get; set; } 

        /// <summary>Optional. The minimum amount of compensation. If left empty, the value is set to zero and the
        /// currency code is set to match the currency code of max_compensation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("min")]
        public virtual Money Min { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Output only.
    ///
    /// Response of auto-complete query.</summary>
    public class CompleteQueryResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Results of the matching job/company candidates.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("completionResults")]
        public virtual System.Collections.Generic.IList<CompletionResult> CompletionResults { get; set; } 

        /// <summary>Additional information for the API invocation, such as the request tracking id.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual ResponseMetadata Metadata { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Output only.
    ///
    /// Resource that represents completion results.</summary>
    public class CompletionResult : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The URL for the company logo if `type=COMPANY_NAME`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imageUrl")]
        public virtual string ImageUrl { get; set; } 

        /// <summary>The suggestion for the query.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("suggestion")]
        public virtual string Suggestion { get; set; } 

        /// <summary>The completion topic.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Input only.
    ///
    /// Create job request.</summary>
    public class CreateJobRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Deprecated. Please use processing_options. This flag is ignored if processing_options is set.
        ///
        /// Optional.
        ///
        /// If set to `true`, the service does not attempt to resolve a more precise address for the job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disableStreetAddressResolution")]
        public virtual System.Nullable<bool> DisableStreetAddressResolution { get; set; } 

        /// <summary>Required. The Job to be created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("job")]
        public virtual Job Job { get; set; } 

        /// <summary>Optional. Options for job processing.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("processingOptions")]
        public virtual JobProcessingOptions ProcessingOptions { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Custom attribute values that are either filterable or non-filterable.</summary>
    public class CustomAttribute : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. If the `filterable` flag is true, custom field values are searchable. If false, values
        /// are not searchable.
        ///
        /// Default is false.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filterable")]
        public virtual System.Nullable<bool> Filterable { get; set; } 

        /// <summary>Optional but at least one of string_values or long_value must be specified.
        ///
        /// This field is used to perform number range search. (`EQ`, `GT`, `GE`, `LE`, `LT`) over filterable
        /// `long_value`. For `long_value`, a value between Long.MIN and Long.MAX is allowed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("longValue")]
        public virtual System.Nullable<long> LongValue { get; set; } 

        /// <summary>Optional but at least one of string_values or long_value must be specified.
        ///
        /// This field is used to perform a string match (`CASE_SENSITIVE_MATCH` or `CASE_INSENSITIVE_MATCH`) search.
        /// For filterable `string_values`, a maximum total number of 200 values is allowed, with each `string_value`
        /// has a byte size of no more than 255B. For unfilterable `string_values`, the maximum total byte size of
        /// unfilterable `string_values` is 50KB.
        ///
        /// Empty strings are not allowed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stringValues")]
        public virtual StringValues StringValues { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Custom attributes histogram request. An error will be thrown if neither string_value_histogram or
    /// long_value_histogram_bucketing_option has been defined.</summary>
    public class CustomAttributeHistogramRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Specifies the custom field key to perform a histogram on. If specified without
        /// `long_value_histogram_bucketing_option`, histogram on string values of the given `key` is triggered,
        /// otherwise histogram is performed on long values.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("key")]
        public virtual string Key { get; set; } 

        /// <summary>Optional. Specifies buckets used to perform a range histogram on Job's filterable long custom field
        /// values, or min/max value requirements.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("longValueHistogramBucketingOption")]
        public virtual NumericBucketingOption LongValueHistogramBucketingOption { get; set; } 

        /// <summary>Optional. If set to true, the response will include the histogram value for each key as a
        /// string.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stringValueHistogram")]
        public virtual System.Nullable<bool> StringValueHistogram { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Output only.
    ///
    /// Custom attribute histogram result.</summary>
    public class CustomAttributeHistogramResult : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Stores the key of custom attribute the histogram is performed on.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("key")]
        public virtual string Key { get; set; } 

        /// <summary>Stores bucketed histogram counting result or min/max values for custom attribute long values
        /// associated with `key`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("longValueHistogramResult")]
        public virtual NumericBucketingResult LongValueHistogramResult { get; set; } 

        /// <summary>Stores a map from the values of string custom field associated with `key` to the number of jobs
        /// with that value in this histogram result.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stringValueHistogramResult")]
        public virtual System.Collections.Generic.IDictionary<string,System.Nullable<int>> StringValueHistogramResult { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Resource that represents the custom data not captured by the standard fields.</summary>
    public class CustomField : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The values of the custom data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("values")]
        public virtual System.Collections.Generic.IList<string> Values { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Input only.
    ///
    /// Custom field filter of the search.</summary>
    public class CustomFieldFilter : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The query strings for the filter.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("queries")]
        public virtual System.Collections.Generic.IList<string> Queries { get; set; } 

        /// <summary>Optional. The type of filter. Defaults to FilterType.OR.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Represents a whole or partial calendar date, e.g. a birthday. The time of day and time zone are either
    /// specified elsewhere or are not significant. The date is relative to the Proleptic Gregorian Calendar. This can
    /// represent:
    ///
    /// * A full date, with non-zero year, month and day values * A month and day value, with a zero year, e.g. an
    /// anniversary * A year on its own, with zero month and day values * A year and month value, with a zero day, e.g.
    /// a credit card expiration date
    ///
    /// Related types are google.type.TimeOfDay and `google.protobuf.Timestamp`.</summary>
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

    /// <summary>Deprecated. Use BatchDeleteJobsRequest instead.
    ///
    /// Input only.
    ///
    /// Delete job by filter request.
    ///
    /// The job typically becomes unsearchable within 10 seconds, but it may take up to 5 minutes.</summary>
    public class DeleteJobsByFilterRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. If set to true, this call waits for all processing steps to complete before the job is
        /// cleaned up. Otherwise, the call returns while some steps are still taking place asynchronously, hence
        /// faster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disableFastProcess")]
        public virtual System.Nullable<bool> DisableFastProcess { get; set; } 

        /// <summary>Required. Restrictions on the scope of the delete request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filter")]
        public virtual Filter Filter { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Input only.
    ///
    /// Device information collected from the job seeker, candidate, or other entity conducting the job search.
    /// Providing this information improves the quality of the search results across devices.</summary>
    public class DeviceInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Type of the device.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deviceType")]
        public virtual string DeviceType { get; set; } 

        /// <summary>Optional. A device-specific ID. The ID must be a unique identifier that distinguishes the device
        /// from other devices.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A generic empty message that you can re-use to avoid defining duplicated empty messages in your APIs. A
    /// typical example is to use it as the request or the response type of an API method. For instance:
    ///
    /// service Foo { rpc Bar(google.protobuf.Empty) returns (google.protobuf.Empty); }
    ///
    /// The JSON representation for `Empty` is empty JSON object `{}`.</summary>
    public class Empty : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Deprecated. Always use CompensationFilter.
    ///
    /// Input only.
    ///
    /// Filter on job compensation type and amount.</summary>
    public class ExtendedCompensationFilter : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Compensation range.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("compensationRange")]
        public virtual ExtendedCompensationInfoCompensationRange CompensationRange { get; set; } 

        /// <summary>Required. Specify desired `base compensation entry's`
        /// ExtendedCompensationInfo.CompensationUnit.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("compensationUnits")]
        public virtual System.Collections.Generic.IList<string> CompensationUnits { get; set; } 

        /// <summary>Optional. Specify currency in 3-letter [ISO 4217](https://www.iso.org/iso-4217-currency-codes.html)
        /// format. If unspecified, jobs are returned regardless of currency.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("currency")]
        public virtual string Currency { get; set; } 

        /// <summary>Optional. Whether to include jobs whose compensation range is unspecified.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("includeJobWithUnspecifiedCompensationRange")]
        public virtual System.Nullable<bool> IncludeJobWithUnspecifiedCompensationRange { get; set; } 

        /// <summary>Required. Type of filter.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Deprecated. Use CompensationInfo.
    ///
    /// Describes job compensation.</summary>
    public class ExtendedCompensationInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Annualized base compensation range.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("annualizedBaseCompensationRange")]
        public virtual ExtendedCompensationInfoCompensationRange AnnualizedBaseCompensationRange { get; set; } 

        /// <summary>Output only. Indicates annualized base compensation range cannot be derived, due to the job's base
        /// compensation entry cannot be annualized. See CompensationEntry for explanation on annualization and base
        /// compensation entry.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("annualizedBaseCompensationUnspecified")]
        public virtual System.Nullable<bool> AnnualizedBaseCompensationUnspecified { get; set; } 

        /// <summary>Output only. Annualized total compensation range.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("annualizedTotalCompensationRange")]
        public virtual ExtendedCompensationInfoCompensationRange AnnualizedTotalCompensationRange { get; set; } 

        /// <summary>Output only. Indicates annualized total compensation range cannot be derived, due to the job's all
        /// CompensationEntry cannot be annualized. See CompensationEntry for explanation on annualization and base
        /// compensation entry.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("annualizedTotalCompensationUnspecified")]
        public virtual System.Nullable<bool> AnnualizedTotalCompensationUnspecified { get; set; } 

        /// <summary>Optional. A 3-letter [ISO 4217](https://www.iso.org/iso-4217-currency-codes.html) currency
        /// code.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("currency")]
        public virtual string Currency { get; set; } 

        /// <summary>Optional. Job compensation information.
        ///
        /// At most one entry can be of type ExtendedCompensationInfo.CompensationType.BASE, which is referred as **
        /// base compensation entry ** for the job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entries")]
        public virtual System.Collections.Generic.IList<ExtendedCompensationInfoCompensationEntry> Entries { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Deprecated. See CompensationInfo.
    ///
    /// A compensation entry that represents one component of compensation, such as base pay, bonus, or other
    /// compensation type.
    ///
    /// Annualization: One compensation entry can be annualized if - it contains valid amount or range. - and its
    /// expected_units_per_year is set or can be derived. Its annualized range is determined as (amount or range) times
    /// expected_units_per_year.</summary>
    public class ExtendedCompensationInfoCompensationEntry : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Monetary amount.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("amount")]
        public virtual ExtendedCompensationInfoDecimal Amount { get; set; } 

        /// <summary>Optional. Compensation description.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; } 

        /// <summary>Optional. Expected number of units paid each year. If not specified, when Job.employment_types is
        /// FULLTIME, a default value is inferred based on unit. Default values: - HOURLY: 2080 - DAILY: 260 - WEEKLY:
        /// 52 - MONTHLY: 12 - ANNUAL: 1</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expectedUnitsPerYear")]
        public virtual ExtendedCompensationInfoDecimal ExpectedUnitsPerYear { get; set; } 

        /// <summary>Optional. Compensation range.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("range")]
        public virtual ExtendedCompensationInfoCompensationRange Range { get; set; } 

        /// <summary>Required. Compensation type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; } 

        /// <summary>Optional. Frequency of the specified amount.
        ///
        /// Default is CompensationUnit.COMPENSATION_UNIT_UNSPECIFIED.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unit")]
        public virtual string Unit { get; set; } 

        /// <summary>Optional. Indicates compensation amount and range are unset.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unspecified")]
        public virtual System.Nullable<bool> Unspecified { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Deprecated. See CompensationInfo.
    ///
    /// Compensation range.</summary>
    public class ExtendedCompensationInfoCompensationRange : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Maximum value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("max")]
        public virtual ExtendedCompensationInfoDecimal Max { get; set; } 

        /// <summary>Required. Minimum value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("min")]
        public virtual ExtendedCompensationInfoDecimal Min { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Deprecated. See CompensationInfo.
    ///
    /// Decimal number.</summary>
    public class ExtendedCompensationInfoDecimal : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Micro (10^-6) units. The value must be between -999,999 and +999,999 inclusive. If `units` is
        /// positive, `micros` must be positive or zero. If `units` is zero, `micros` can be positive, zero, or
        /// negative. If `units` is negative, `micros` must be negative or zero. For example -1.75 is represented as
        /// `units`=-1 and `micros`=-750,000.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("micros")]
        public virtual System.Nullable<int> Micros { get; set; } 

        /// <summary>Whole units.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("units")]
        public virtual System.Nullable<long> Units { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Deprecated. Use BatchDeleteJobsRequest instead.
    ///
    /// Input only.
    ///
    /// Filter for jobs to be deleted.</summary>
    public class Filter : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The requisition ID (or posting ID) assigned by the client to identify a job. This is
        /// intended for client identification and tracking of listings. name takes precedence over this field The
        /// maximum number of allowed characters is 225.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requisitionId")]
        public virtual string RequisitionId { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Deprecated. Use SearchJobsRequest.histogram_facets instead to make a single call with both search and
    /// histogram.
    ///
    /// Input only.
    ///
    /// A request for the `GetHistogram` method.</summary>
    public class GetHistogramRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Controls whether to broaden the search to avoid too few results for a given query in
        /// instances where a search has sparse results. Results from a broadened query is a superset of the results
        /// from the original query.
        ///
        /// Defaults to false.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowBroadening")]
        public virtual System.Nullable<bool> AllowBroadening { get; set; } 

        /// <summary>Deprecated. Use query instead.
        ///
        /// Optional.
        ///
        /// Restrictions on the scope of the histogram.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filters")]
        public virtual JobFilters Filters { get; set; } 

        /// <summary>Optional. Query used to search against jobs, such as keyword, location filters, etc.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("query")]
        public virtual JobQuery Query { get; set; } 

        /// <summary>Meta information, such as `user_id`, collected from the job searcher or other entity conducting a
        /// job search, is used to improve the service's search quality. Users determine identifier values, which must
        /// be unique and consist.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestMetadata")]
        public virtual RequestMetadata RequestMetadata { get; set; } 

        /// <summary>Required. A list of facets that specify the histogram data to be calculated against and returned.
        ///
        /// Histogram response times can be slow, and counts can be approximations. This call may be temporarily or
        /// permanently removed prior to the production release of Cloud Talent Solution.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("searchTypes")]
        public virtual System.Collections.Generic.IList<string> SearchTypes { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Deprecated. Use SearchJobsRequest.histogram_facets instead to make a single call with both search and
    /// histogram.
    ///
    /// Output only.
    ///
    /// The response of the GetHistogram method.</summary>
    public class GetHistogramResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Additional information for the API invocation, such as the request tracking id.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual ResponseMetadata Metadata { get; set; } 

        /// <summary>The Histogram results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("results")]
        public virtual System.Collections.Generic.IList<HistogramResult> Results { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Input only.
    ///
    /// Histogram facets to be specified in SearchJobsRequest.</summary>
    public class HistogramFacets : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Specifies compensation field-based histogram requests. Duplicate values of
        /// CompensationHistogramRequest.type are not allowed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("compensationHistogramFacets")]
        public virtual System.Collections.Generic.IList<CompensationHistogramRequest> CompensationHistogramFacets { get; set; } 

        /// <summary>Optional. Specifies the custom attributes histogram requests. Duplicate values of
        /// CustomAttributeHistogramRequest.key are not allowed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customAttributeHistogramFacets")]
        public virtual System.Collections.Generic.IList<CustomAttributeHistogramRequest> CustomAttributeHistogramFacets { get; set; } 

        /// <summary>Optional. Specifies the simple type of histogram facets, for example, `COMPANY_SIZE`,
        /// `EMPLOYMENT_TYPE` etc. This field is equivalent to GetHistogramRequest.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("simpleHistogramFacets")]
        public virtual System.Collections.Generic.IList<string> SimpleHistogramFacets { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Output only.
    ///
    /// Result of a histogram call. The response contains the histogram map for the search type specified by
    /// HistogramResult.field. The response is a map of each filter value to the corresponding count of jobs for that
    /// filter.</summary>
    public class HistogramResult : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The Histogram search filters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("searchType")]
        public virtual string SearchType { get; set; } 

        /// <summary>A map from the values of field to the number of jobs with that value in this search result.
        ///
        /// Key: search type (filter names, such as the companyName).
        ///
        /// Values: the count of jobs that match the filter for this search.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("values")]
        public virtual System.Collections.Generic.IDictionary<string,System.Nullable<int>> Values { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Output only.
    ///
    /// Histogram results that matches HistogramFacets specified in SearchJobsRequest.</summary>
    public class HistogramResults : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Specifies compensation field-based histogram results that matches
        /// HistogramFacets.compensation_histogram_requests.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("compensationHistogramResults")]
        public virtual System.Collections.Generic.IList<CompensationHistogramResult> CompensationHistogramResults { get; set; } 

        /// <summary>Specifies histogram results for custom attributes that matches
        /// HistogramFacets.custom_attribute_histogram_facets.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customAttributeHistogramResults")]
        public virtual System.Collections.Generic.IList<CustomAttributeHistogramResult> CustomAttributeHistogramResults { get; set; } 

        /// <summary>Specifies histogram results that matches HistogramFacets.simple_histogram_facets.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("simpleHistogramResults")]
        public virtual System.Collections.Generic.IList<HistogramResult> SimpleHistogramResults { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A Job resource represents a job posting (also referred to as a "job listing" or "job requisition"). A
    /// job belongs to a Company, which is the hiring entity responsible for the job.</summary>
    public class Job : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional but at least one of application_urls, application_email_list or application_instruction
        /// must be specified.
        ///
        /// Use this field to specify email address(es) to which resumes or applications can be sent.
        ///
        /// The maximum number of allowed characters is 255.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("applicationEmailList")]
        public virtual System.Collections.Generic.IList<string> ApplicationEmailList { get; set; } 

        /// <summary>Optional but at least one of application_urls, application_email_list or application_instruction
        /// must be specified.
        ///
        /// Use this field to provide instructions, such as "Mail your application to ...", that a candidate can follow
        /// to apply for the job.
        ///
        /// This field accepts and sanitizes HTML input, and also accepts bold, italic, ordered list, and unordered list
        /// markup tags.
        ///
        /// The maximum number of allowed characters is 3,000.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("applicationInstruction")]
        public virtual string ApplicationInstruction { get; set; } 

        /// <summary>Optional but at least one of application_urls, application_email_list or application_instruction
        /// must be specified.
        ///
        /// Use this URL field to direct an applicant to a website, for example to link to an online application form.
        ///
        /// The maximum number of allowed characters is 2,000.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("applicationUrls")]
        public virtual System.Collections.Generic.IList<string> ApplicationUrls { get; set; } 

        /// <summary>Optional. The benefits included with the job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("benefits")]
        public virtual System.Collections.Generic.IList<string> Benefits { get; set; } 

        /// <summary>Output only. The name of the company listing the job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("companyDisplayName")]
        public virtual string CompanyDisplayName { get; set; } 

        /// <summary>Optional but one of company_name or distributor_company_id must be provided.
        ///
        /// The resource name of the company listing the job, such as /companies/foo. This field takes precedence over
        /// the distributor-assigned company identifier, distributor_company_id.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("companyName")]
        public virtual string CompanyName { get; set; } 

        /// <summary>Deprecated. Use company_display_name instead.
        ///
        /// Output only.
        ///
        /// The name of the company listing the job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("companyTitle")]
        public virtual string CompanyTitle { get; set; } 

        /// <summary>Optional. Job compensation information.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("compensationInfo")]
        public virtual CompensationInfo CompensationInfo { get; set; } 

        /// <summary>Output only. The timestamp when this job was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; } 

        /// <summary>Optional. A map of fields to hold both filterable and non-filterable custom job attributes that are
        /// not covered by the provided structured fields.
        ///
        /// This field is a more general combination of the deprecated id-based filterable_custom_fields and string-
        /// based non_filterable_custom_fields.
        ///
        /// The keys of the map are strings up to 64 bytes and must match the pattern: a-zA-Z*.
        ///
        /// At most 100 filterable and at most 100 unfilterable keys are supported. For filterable `string_values`,
        /// across all keys at most 200 values are allowed, with each string no more than 255 characters. For
        /// unfilterable `string_values`, the maximum total size of `string_values` across all keys is 50KB.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customAttributes")]
        public virtual System.Collections.Generic.IDictionary<string,CustomAttribute> CustomAttributes { get; set; } 

        /// <summary>Optional. The department or functional area within the company with the open position.
        ///
        /// The maximum number of allowed characters is 255.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("department")]
        public virtual string Department { get; set; } 

        /// <summary>Required. The description of the job, which typically includes a multi-paragraph description of the
        /// company and related information. Separate fields are provided on the job object for responsibilities,
        /// qualifications, and other job characteristics. Use of these separate job fields is recommended.
        ///
        /// This field accepts and sanitizes HTML input, and also accepts bold, italic, ordered list, and unordered list
        /// markup tags.
        ///
        /// The maximum number of allowed characters is 100,000.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; } 

        /// <summary>Optional but one of company_name or distributor_company_id must be provided.
        ///
        /// A unique company identifier used by job distributors to identify an employer's company entity. company_name
        /// takes precedence over this field, and is the recommended field to use to identify companies.
        ///
        /// The maximum number of allowed characters is 255.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("distributorCompanyId")]
        public virtual string DistributorCompanyId { get; set; } 

        /// <summary>Optional. The desired education level for the job, such as "Bachelors", "Masters",
        /// "Doctorate".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("educationLevels")]
        public virtual System.Collections.Generic.IList<string> EducationLevels { get; set; } 

        /// <summary>Optional. The employment type(s) of a job, for example, full time or part time.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("employmentTypes")]
        public virtual System.Collections.Generic.IList<string> EmploymentTypes { get; set; } 

        /// <summary>Optional. The end date of the job in UTC time zone. Typically this field is used for contracting
        /// engagements. Dates prior to 1970/1/1 and invalid date formats are ignored.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endDate")]
        public virtual Date EndDate { get; set; } 

        /// <summary>Optional but strongly recommended for the best service experience.
        ///
        /// The expiration timestamp of the job. After this timestamp, the job is marked as expired, and it no longer
        /// appears in search results. The expired job can't be deleted or listed by the DeleteJob and ListJobs APIs,
        /// but it can be retrieved with the GetJob API or updated with the UpdateJob API. An expired job can be updated
        /// and opened again by using a future expiration timestamp. Updating an expired job fails if there is another
        /// existing open job with same requisition_id, company_name and language_code.
        ///
        /// The expired jobs are retained in our system for 90 days. However, the overall expired job count cannot
        /// exceed 3 times the maximum of open jobs count over the past week, otherwise jobs with earlier expire time
        /// are cleaned first. Expired jobs are no longer accessible after they are cleaned out. The format of this
        /// field is RFC 3339 date strings. Example: 2000-01-01T00:00:00.999999999Z See
        /// [https://www.ietf.org/rfc/rfc3339.txt](https://www.ietf.org/rfc/rfc3339.txt).
        ///
        /// A valid date range is between 1970-01-01T00:00:00.0Z and 2100-12-31T23:59:59.999Z. Invalid dates are ignored
        /// and treated as expire time not provided.
        ///
        /// If this value is not provided at the time of job creation or is invalid, the job posting expires after 30
        /// days from the job's creation time. For example, if the job was created on 2017/01/01 13:00AM UTC with an
        /// unspecified expiration date, the job expires after 2017/01/31 13:00AM UTC.
        ///
        /// If this value is not provided but expiry_date is, expiry_date is used.
        ///
        /// If this value is not provided on job update, it depends on the field masks set by
        /// UpdateJobRequest.update_job_fields. If the field masks include expiry_time, or the masks are empty meaning
        /// that every field is updated, the job posting expires after 30 days from the job's last update time.
        /// Otherwise the expiration date isn't updated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expireTime")]
        public virtual object ExpireTime { get; set; } 

        /// <summary>Deprecated. Use expire_time instead.
        ///
        /// Optional but strongly recommended to be provided for the best service experience.
        ///
        /// The expiration date of the job in UTC time. After 12 am on this date, the job is marked as expired, and it
        /// no longer appears in search results. The expired job can't be deleted or listed by the DeleteJob and
        /// ListJobs APIs, but it can be retrieved with the GetJob API or updated with the UpdateJob API. An expired job
        /// can be updated and opened again by using a future expiration date. It can also remain expired. Updating an
        /// expired job to be open fails if there is another existing open job with same requisition_id, company_name
        /// and language_code.
        ///
        /// The expired jobs are retained in our system for 90 days. However, the overall expired job count cannot
        /// exceed 3 times the maximum of open jobs count over the past week, otherwise jobs with earlier expire time
        /// are removed first. Expired jobs are no longer accessible after they are cleaned out.
        ///
        /// A valid date range is between 1970/1/1 and 2100/12/31. Invalid dates are ignored and treated as expiry date
        /// not provided.
        ///
        /// If this value is not provided on job creation or is invalid, the job posting expires after 30 days from the
        /// job's creation time. For example, if the job was created on 2017/01/01 13:00AM UTC with an unspecified
        /// expiration date, the job expires after 2017/01/31 13:00AM UTC.
        ///
        /// If this value is not provided on job update, it depends on the field masks set by
        /// UpdateJobRequest.update_job_fields. If the field masks include expiry_date, or the masks are empty meaning
        /// that every field is updated, the job expires after 30 days from the job's last update time. Otherwise the
        /// expiration date isn't updated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expiryDate")]
        public virtual Date ExpiryDate { get; set; } 

        /// <summary>Deprecated. Always use compensation_info.
        ///
        /// Optional.
        ///
        /// Job compensation information.
        ///
        /// This field replaces compensation_info. Only CompensationInfo.entries or extended_compensation_info can be
        /// set, otherwise an exception is thrown.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("extendedCompensationInfo")]
        public virtual ExtendedCompensationInfo ExtendedCompensationInfo { get; set; } 

        /// <summary>Deprecated. Use custom_attributes instead.
        ///
        /// Optional.
        ///
        /// A map of fields to hold filterable custom job attributes not captured by the standard fields such as
        /// job_title, company_name, or level. These custom fields store arbitrary string values, and can be used for
        /// purposes not covered by the structured fields. For the best search experience, use of the structured rather
        /// than custom fields is recommended.
        ///
        /// Data stored in these custom fields fields are indexed and searched against by keyword searches (see
        /// SearchJobsRequest.custom_field_filters][]).
        ///
        /// The map key must be a number between 1-20. If an invalid key is provided on job create or update, an error
        /// is returned.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filterableCustomFields")]
        public virtual System.Collections.Generic.IDictionary<string,CustomField> FilterableCustomFields { get; set; } 

        /// <summary>Optional. A description of bonus, commission, and other compensation incentives associated with the
        /// job not including salary or pay.
        ///
        /// The maximum number of allowed characters is 10,000.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("incentives")]
        public virtual string Incentives { get; set; } 

        /// <summary>Output only. Structured locations of the job, resolved from locations.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("jobLocations")]
        public virtual System.Collections.Generic.IList<JobLocation> JobLocations { get; set; } 

        /// <summary>Required. The title of the job, such as "Software Engineer"
        ///
        /// The maximum number of allowed characters is 500.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("jobTitle")]
        public virtual string JobTitle { get; set; } 

        /// <summary>Optional. The language of the posting. This field is distinct from any requirements for fluency
        /// that are associated with the job.
        ///
        /// Language codes must be in BCP-47 format, such as "en-US" or "sr-Latn". For more information, see [Tags for
        /// Identifying Languages](https://tools.ietf.org/html/bcp47){: class="external" target="_blank" }.
        ///
        /// If this field is unspecified and Job.description is present, detected language code based on Job.description
        /// is assigned, otherwise defaults to 'en_US'.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("languageCode")]
        public virtual string LanguageCode { get; set; } 

        /// <summary>Optional. The experience level associated with the job, such as "Entry Level".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("level")]
        public virtual string Level { get; set; } 

        /// <summary>Optional but strongly recommended for the best service experience.
        ///
        /// Location(s) where the emploeyer is looking to hire for this job posting.
        ///
        /// Specifying the full street address(es) of the hiring location enables better API results, especially job
        /// searches by commute time.
        ///
        /// At most 50 locations are allowed for best search performance. If a job has more locations, it is suggested
        /// to split it into multiple jobs with unique requisition_ids (e.g. 'ReqA' becomes 'ReqA-1', 'ReqA-2', etc.) as
        /// multiple jobs with the same requisition_id, company_name and language_code are not allowed. If the original
        /// requisition_id must be preserved, a custom field should be used for storage. It is also suggested to group
        /// the locations that close to each other in the same job for better search experience.
        ///
        /// The maximum number of allowed characters is 500.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locations")]
        public virtual System.Collections.Generic.IList<string> Locations { get; set; } 

        /// <summary>Required during job update.
        ///
        /// Resource name assigned to a job by the API, for example, "/jobs/foo". Use of this field in job queries and
        /// API calls is preferred over the use of requisition_id since this value is unique.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; } 

        /// <summary>Optional. A promotion value of the job, as determined by the client. The value determines the sort
        /// order of the jobs returned when searching for jobs using the featured jobs search call, with higher
        /// promotional values being returned first and ties being resolved by relevance sort. Only the jobs with a
        /// promotionValue >0 are returned in a FEATURED_JOB_SEARCH.
        ///
        /// Default value is 0, and negative values are treated as 0.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("promotionValue")]
        public virtual System.Nullable<int> PromotionValue { get; set; } 

        /// <summary>Optional. The date this job was most recently published in UTC format. The default value is the
        /// time the request arrives at the server.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("publishDate")]
        public virtual Date PublishDate { get; set; } 

        /// <summary>Optional. A description of the qualifications required to perform the job. The use of this field is
        /// recommended as an alternative to using the more general description field.
        ///
        /// This field accepts and sanitizes HTML input, and also accepts bold, italic, ordered list, and unordered list
        /// markup tags.
        ///
        /// The maximum number of allowed characters is 10,000.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("qualifications")]
        public virtual string Qualifications { get; set; } 

        /// <summary>Output only. The URL of a web page that displays job details.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("referenceUrl")]
        public virtual string ReferenceUrl { get; set; } 

        /// <summary>Optional. The job Region (for example, state, country) throughout which the job is available. If
        /// this field is set, a LocationFilter in a search query within the job region finds this job if an exact
        /// location match is not specified. If this field is set, setting job locations to the same location level as
        /// this field is strongly recommended.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("region")]
        public virtual string Region { get; set; } 

        /// <summary>Required. The requisition ID, also referred to as the posting ID, assigned by the client to
        /// identify a job. This field is intended to be used by clients for client identification and tracking of
        /// listings. A job is not allowed to be created if there is another job with the same requisition_id,
        /// company_name and language_code.
        ///
        /// The maximum number of allowed characters is 255.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requisitionId")]
        public virtual string RequisitionId { get; set; } 

        /// <summary>Optional. A description of job responsibilities. The use of this field is recommended as an
        /// alternative to using the more general description field.
        ///
        /// This field accepts and sanitizes HTML input, and also accepts bold, italic, ordered list, and unordered list
        /// markup tags.
        ///
        /// The maximum number of allowed characters is 10,000.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("responsibilities")]
        public virtual string Responsibilities { get; set; } 

        /// <summary>Optional. The start date of the job in UTC time zone. Typically this field is used for contracting
        /// engagements. Dates prior to 1970/1/1 and invalid date formats are ignored.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startDate")]
        public virtual Date StartDate { get; set; } 

        /// <summary>Deprecated. Use custom_attributes instead.
        ///
        /// Optional.
        ///
        /// A map of fields to hold non-filterable custom job attributes, similar to filterable_custom_fields. These
        /// fields are distinct in that the data in these fields are not indexed. Therefore, the client cannot search
        /// against them, nor can the client use them to list jobs.
        ///
        /// The key of the map can be any valid string.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unindexedCustomFields")]
        public virtual System.Collections.Generic.IDictionary<string,CustomField> UnindexedCustomFields { get; set; } 

        /// <summary>Output only. The timestamp when this job was last updated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; } 

        /// <summary>Optional. The visibility of the job. Defaults to JobVisibility.PRIVATE if not specified. Currently
        /// only JobVisibility.PRIVATE is supported.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("visibility")]
        public virtual string Visibility { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Input only.
    ///
    /// Deprecated. Use JobQuery instead.
    ///
    /// The filters required to perform a search query or histogram.</summary>
    public class JobFilters : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The category filter specifies the categories of jobs to search against. See Category for
        /// more information.
        ///
        /// If a value is not specified, jobs from any category are searched against.
        ///
        /// If multiple values are specified, jobs from any of the specified categories are searched against.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("categories")]
        public virtual System.Collections.Generic.IList<string> Categories { get; set; } 

        /// <summary>Optional. Allows filtering jobs by commute time with different travel methods (e.g. driving or
        /// public transit). Note: this only works with COMMUTE MODE. When specified, [JobFilters.location_filters] will
        /// be ignored.
        ///
        /// Currently we do not support sorting by commute time.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("commuteFilter")]
        public virtual CommutePreference CommuteFilter { get; set; } 

        /// <summary>Optional. The company names filter specifies the company entities to search against.
        ///
        /// If a value is not specified, jobs are searched for against all companies.
        ///
        /// If multiple values are specified, jobs are searched against the specified companies.
        ///
        /// At most 20 company filters are allowed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("companyNames")]
        public virtual System.Collections.Generic.IList<string> CompanyNames { get; set; } 

        /// <summary>Optional. This filter specifies the exact company titles of jobs to search against.
        ///
        /// If a value is not specified, jobs within the search results can be associated with any company.
        ///
        /// If multiple values are specified, jobs within the search results may be associated with any of the specified
        /// companies.
        ///
        /// At most 20 company title filters are allowed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("companyTitles")]
        public virtual System.Collections.Generic.IList<string> CompanyTitles { get; set; } 

        /// <summary>Optional. This search filter is applied only to Job.compensation_info. For example, if the filter
        /// is specified as "Hourly job with per-hour compensation > $15", only jobs that meet this criteria are
        /// searched. If a filter is not defined, all open jobs are searched.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("compensationFilter")]
        public virtual CompensationFilter CompensationFilter { get; set; } 

        /// <summary>Optional. This filter specifies a structured syntax to match against the Job.custom_attributes that
        /// are marked as `filterable`.
        ///
        /// The syntax for this expression is a subset of Google SQL syntax.
        ///
        /// Supported operators are: =, !=, <, <=, >, >= where the left of the operator is a custom field key and the
        /// right of the operator is a number or string (surrounded by quotes) value.
        ///
        /// Supported functions are LOWER() to perform case insensitive match and EMPTY() to filter on the existence of
        /// a key.
        ///
        /// Boolean expressions (AND/OR/NOT) are supported up to 3 levels of nesting (For example, "((A AND B AND C) OR
        /// NOT D) AND E"), and there can be a maximum of 100 comparisons/functions in the expression. The expression
        /// must be < 3000 bytes in length.
        ///
        /// Sample Query: (key1 = "TEST" OR LOWER(key1)="test" OR NOT EMPTY(key1)) AND key2 > 100</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customAttributeFilter")]
        public virtual string CustomAttributeFilter { get; set; } 

        /// <summary>Deprecated. Use custom_attribute_filter instead.
        ///
        /// Optional.
        ///
        /// This filter specifies searching against custom field values. See Job.filterable_custom_fields for
        /// information. The key value specifies a number between 1-20 (the service supports 20 custom fields)
        /// corresponding to the desired custom field map value. If an invalid key is provided or specified together
        /// with custom_attribute_filter, an error is thrown.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customFieldFilters")]
        public virtual System.Collections.Generic.IDictionary<string,CustomFieldFilter> CustomFieldFilters { get; set; } 

        /// <summary>Optional. This flag controls the spell-check feature. If false, the service attempts to correct a
        /// misspelled query, for example, "enginee" is corrected to "engineer".
        ///
        /// Defaults to false: a spell check is performed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disableSpellCheck")]
        public virtual System.Nullable<bool> DisableSpellCheck { get; set; } 

        /// <summary>Optional. The employment type filter specifies the employment type of jobs to search against, such
        /// as EmploymentType.FULL_TIME.
        ///
        /// If a value is not specified, jobs in the search results include any employment type.
        ///
        /// If multiple values are specified, jobs in the search results include any of the specified employment
        /// types.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("employmentTypes")]
        public virtual System.Collections.Generic.IList<string> EmploymentTypes { get; set; } 

        /// <summary>Deprecated. Always use compensation_filter.
        ///
        /// Optional.
        ///
        /// This search filter is applied only to Job.extended_compensation_info. For example, if the filter is
        /// specified as "Hourly job with per-hour compensation > $15", only jobs that meet these criteria are searched.
        /// If a filter is not defined, all open jobs are searched.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("extendedCompensationFilter")]
        public virtual ExtendedCompensationFilter ExtendedCompensationFilter { get; set; } 

        /// <summary>Optional. This filter specifies the locale of jobs to search against, for example, "en-US".
        ///
        /// If a value is not specified, the search results may contain jobs in any locale.
        ///
        /// Language codes should be in BCP-47 format, for example, "en-US" or "sr-Latn". For more information, see
        /// [Tags for Identifying Languages](https://tools.ietf.org/html/bcp47).
        ///
        /// At most 10 language code filters are allowed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("languageCodes")]
        public virtual System.Collections.Generic.IList<string> LanguageCodes { get; set; } 

        /// <summary>Optional. The location filter specifies geo-regions containing the jobs to search against. See
        /// LocationFilter for more information.
        ///
        /// If a location value is not specified, jobs are retrieved from all locations.
        ///
        /// If multiple values are specified, jobs are retrieved from any of the specified locations. If different
        /// values are specified for the LocationFilter.distance_in_miles parameter, the maximum provided distance is
        /// used for all locations.
        ///
        /// At most 5 location filters are allowed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locationFilters")]
        public virtual System.Collections.Generic.IList<LocationFilter> LocationFilters { get; set; } 

        /// <summary>Optional. Jobs published within a range specified by this filter are searched against, for example,
        /// DateRange.PAST_MONTH. If a value is not specified, all open jobs are searched against regardless of the date
        /// they were published.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("publishDateRange")]
        public virtual string PublishDateRange { get; set; } 

        /// <summary>Optional. The query filter contains the keywords that match against the job title, description, and
        /// location fields.
        ///
        /// The maximum query size is 255 bytes/characters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("query")]
        public virtual string Query { get; set; } 

        /// <summary>Deprecated. Do not use this field.
        ///
        /// This flag controls whether the job search should be restricted to jobs owned by the current user.
        ///
        /// Defaults to false where all jobs accessible to the user are searched against.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tenantJobOnly")]
        public virtual System.Nullable<bool> TenantJobOnly { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Output only.
    ///
    /// A resource that represents a location with full geographic information.</summary>
    public class JobLocation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>An object representing a latitude/longitude pair.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("latLng")]
        public virtual LatLng LatLng { get; set; } 

        /// <summary>The type of a location, which corresponds to the address lines field of PostalAddress. For example,
        /// "Downtown, Atlanta, GA, USA" has a type of LocationType#NEIGHBORHOOD, and "Kansas City, KS, USA" has a type
        /// of LocationType#LOCALITY.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locationType")]
        public virtual string LocationType { get; set; } 

        /// <summary>Postal address of the location that includes human readable information, such as postal delivery
        /// and payments addresses. Given a postal address, a postal service can deliver items to a premises, P.O. Box,
        /// or other delivery location.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("postalAddress")]
        public virtual PostalAddress PostalAddress { get; set; } 

        /// <summary>Radius in meters of the job location. This value is derived from the location bounding box in which
        /// a circle with the specified radius centered from LatLng coves the area associated with the job location. For
        /// example, currently, "Mountain View, CA, USA" has a radius of 7885.79 meters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("radiusMeters")]
        public virtual System.Nullable<double> RadiusMeters { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Input only.
    ///
    /// Options for job processing.</summary>
    public class JobProcessingOptions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. If set to `true`, the service does not attempt to resolve a more precise address for the
        /// job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disableStreetAddressResolution")]
        public virtual System.Nullable<bool> DisableStreetAddressResolution { get; set; } 

        /// <summary>Optional. Option for job HTML content sanitization. Applied fields are:
        ///
        /// * description * applicationInstruction * incentives * qualifications * responsibilities
        ///
        /// HTML tags in these fields may be stripped if sanitiazation is not disabled.
        ///
        /// Defaults to HtmlSanitization.SIMPLE_FORMATTING_ONLY.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("htmlSanitization")]
        public virtual string HtmlSanitization { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Input only.
    ///
    /// The query required to perform a search query or histogram.</summary>
    public class JobQuery : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The category filter specifies the categories of jobs to search against. See Category for
        /// more information.
        ///
        /// If a value is not specified, jobs from any category are searched against.
        ///
        /// If multiple values are specified, jobs from any of the specified categories are searched against.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("categories")]
        public virtual System.Collections.Generic.IList<string> Categories { get; set; } 

        /// <summary>Optional. Allows filtering jobs by commute time with different travel methods (for example, driving
        /// or public transit). Note: This only works with COMMUTE MODE. When specified, [JobQuery.location_filters] is
        /// ignored.
        ///
        /// Currently we don't support sorting by commute time.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("commuteFilter")]
        public virtual CommutePreference CommuteFilter { get; set; } 

        /// <summary>Optional. This filter specifies the exact company display name of the jobs to search against.
        ///
        /// If a value isn't specified, jobs within the search results are associated with any company.
        ///
        /// If multiple values are specified, jobs within the search results may be associated with any of the specified
        /// companies.
        ///
        /// At most 20 company display name filters are allowed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("companyDisplayNames")]
        public virtual System.Collections.Generic.IList<string> CompanyDisplayNames { get; set; } 

        /// <summary>Optional. This filter specifies the company entities to search against.
        ///
        /// If a value isn't specified, jobs are searched for against all companies.
        ///
        /// If multiple values are specified, jobs are searched against the companies specified.
        ///
        /// At most 20 company filters are allowed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("companyNames")]
        public virtual System.Collections.Generic.IList<string> CompanyNames { get; set; } 

        /// <summary>Optional. This search filter is applied only to Job.compensation_info. For example, if the filter
        /// is specified as "Hourly job with per-hour compensation > $15", only jobs meeting these criteria are
        /// searched. If a filter isn't defined, all open jobs are searched.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("compensationFilter")]
        public virtual CompensationFilter CompensationFilter { get; set; } 

        /// <summary>Optional. This filter specifies a structured syntax to match against the Job.custom_attributes
        /// marked as `filterable`.
        ///
        /// The syntax for this expression is a subset of Google SQL syntax.
        ///
        /// Supported operators are: =, !=, <, <=, >, >= where the left of the operator is a custom field key and the
        /// right of the operator is a number or string (surrounded by quotes) value.
        ///
        /// Supported functions are LOWER() to perform case insensitive match and EMPTY() to filter on the existence of
        /// a key.
        ///
        /// Boolean expressions (AND/OR/NOT) are supported up to 3 levels of nesting (for example, "((A AND B AND C) OR
        /// NOT D) AND E"), a maximum of 50 comparisons/functions are allowed in the expression. The expression must be
        /// < 2000 characters in length.
        ///
        /// Sample Query: (key1 = "TEST" OR LOWER(key1)="test" OR NOT EMPTY(key1)) AND key2 > 100</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customAttributeFilter")]
        public virtual string CustomAttributeFilter { get; set; } 

        /// <summary>Optional. This flag controls the spell-check feature. If false, the service attempts to correct a
        /// misspelled query, for example, "enginee" is corrected to "engineer".
        ///
        /// Defaults to false: a spell check is performed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disableSpellCheck")]
        public virtual System.Nullable<bool> DisableSpellCheck { get; set; } 

        /// <summary>Optional. The employment type filter specifies the employment type of jobs to search against, such
        /// as EmploymentType.FULL_TIME.
        ///
        /// If a value is not specified, jobs in the search results include any employment type.
        ///
        /// If multiple values are specified, jobs in the search results include any of the specified employment
        /// types.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("employmentTypes")]
        public virtual System.Collections.Generic.IList<string> EmploymentTypes { get; set; } 

        /// <summary>Optional. This filter specifies the locale of jobs to search against, for example, "en-US".
        ///
        /// If a value isn't specified, the search results can contain jobs in any locale.
        ///
        /// Language codes should be in BCP-47 format, such as "en-US" or "sr-Latn". For more information, see [Tags for
        /// Identifying Languages](https://tools.ietf.org/html/bcp47).
        ///
        /// At most 10 language code filters are allowed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("languageCodes")]
        public virtual System.Collections.Generic.IList<string> LanguageCodes { get; set; } 

        /// <summary>Optional. The location filter specifies geo-regions containing the jobs to search against. See
        /// LocationFilter for more information.
        ///
        /// If a location value isn't specified, jobs fitting the other search criteria are retrieved regardless of
        /// where they're located.
        ///
        /// If multiple values are specified, jobs are retrieved from any of the specified locations. If different
        /// values are specified for the LocationFilter.distance_in_miles parameter, the maximum provided distance is
        /// used for all locations.
        ///
        /// At most 5 location filters are allowed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locationFilters")]
        public virtual System.Collections.Generic.IList<LocationFilter> LocationFilters { get; set; } 

        /// <summary>Optional. Jobs published within a range specified by this filter are searched against, for example,
        /// DateRange.PAST_MONTH. If a value isn't specified, all open jobs are searched against regardless of their
        /// published date.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("publishDateRange")]
        public virtual string PublishDateRange { get; set; } 

        /// <summary>Optional. The query string that matches against the job title, description, and location fields.
        ///
        /// The maximum query size is 255 bytes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("query")]
        public virtual string Query { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>An object representing a latitude/longitude pair. This is expressed as a pair of doubles representing
    /// degrees latitude and degrees longitude. Unless specified otherwise, this must conform to the WGS84 standard.
    /// Values must be within normalized ranges.</summary>
    public class LatLng : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The latitude in degrees. It must be in the range [-90.0, +90.0].</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("latitude")]
        public virtual System.Nullable<double> Latitude { get; set; } 

        /// <summary>The longitude in degrees. It must be in the range [-180.0, +180.0].</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("longitude")]
        public virtual System.Nullable<double> Longitude { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Output only.
    ///
    /// The List companies response object.</summary>
    public class ListCompaniesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Companies for the current client.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("companies")]
        public virtual System.Collections.Generic.IList<Company> Companies { get; set; } 

        /// <summary>Additional information for the API invocation, such as the request tracking id.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual ResponseMetadata Metadata { get; set; } 

        /// <summary>A token to retrieve the next page of results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Deprecated. Use ListJobsResponse instead.
    ///
    /// Output only.
    ///
    /// The List jobs response object.</summary>
    public class ListCompanyJobsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The Jobs for a given company.
        ///
        /// The maximum number of items returned is based on the limit field provided in the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("jobs")]
        public virtual System.Collections.Generic.IList<Job> Jobs { get; set; } 

        /// <summary>Additional information for the API invocation, such as the request tracking id.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual ResponseMetadata Metadata { get; set; } 

        /// <summary>A token to retrieve the next page of results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; } 

        /// <summary>The total number of open jobs. The result will be empty if
        /// ListCompanyJobsRequest.include_jobs_count is not enabled or if no open jobs are available.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalSize")]
        public virtual System.Nullable<long> TotalSize { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Output only.
    ///
    /// List jobs response.</summary>
    public class ListJobsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The Jobs for a given company.
        ///
        /// The maximum number of items returned is based on the limit field provided in the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("jobs")]
        public virtual System.Collections.Generic.IList<Job> Jobs { get; set; } 

        /// <summary>Additional information for the API invocation, such as the request tracking id.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual ResponseMetadata Metadata { get; set; } 

        /// <summary>A token to retrieve the next page of results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Input only.
    ///
    /// Geographic region of the search.</summary>
    public class LocationFilter : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The distance_in_miles is applied when the location being searched for is identified as a
        /// city or smaller. When the location being searched for is a state or larger, this field is ignored.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("distanceInMiles")]
        public virtual System.Nullable<double> DistanceInMiles { get; set; } 

        /// <summary>Optional. Allows the client to return jobs without a set location, specifically, telecommuting jobs
        /// (telecomuting is considered by the service as a special location. Job.allow_telecommute indicates if a job
        /// permits telecommuting. If this field is true, telecommuting jobs are searched, and name and lat_lng are
        /// ignored. This filter can be used by itself to search exclusively for telecommuting jobs, or it can be
        /// combined with another location filter to search for a combination of job locations, such as "Mountain View"
        /// or "telecommuting" jobs. However, when used in combination with other location filters, telecommuting jobs
        /// can be treated as less relevant than other jobs in the search response.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isTelecommute")]
        public virtual System.Nullable<bool> IsTelecommute { get; set; } 

        /// <summary>Optional. The latitude and longitude of the geographic center from which to search. This field is
        /// ignored if `location_name` is provided.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("latLng")]
        public virtual LatLng LatLng { get; set; } 

        /// <summary>Optional. The address name, such as "Mountain View" or "Bay Area".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; } 

        /// <summary>Optional. CLDR region code of the country/region of the address. This will be used to address
        /// ambiguity of the user-input location, e.g. "Liverpool" against "Liverpool, NY, US" or "Liverpool, UK".
        ///
        /// Set this field if all the jobs to search against are from a same region, or jobs are world-wide but the job
        /// seeker is from a specific region.
        ///
        /// See http://cldr.unicode.org/ and
        /// http://www.unicode.org/cldr/charts/30/supplemental/territory_information.html for details. Example: "CH" for
        /// Switzerland.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("regionCode")]
        public virtual string RegionCode { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Output only.
    ///
    /// Job entry with metadata inside SearchJobsResponse.</summary>
    public class MatchingJob : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Commute information which is generated based on specified CommutePreference.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("commuteInfo")]
        public virtual CommuteInfo CommuteInfo { get; set; } 

        /// <summary>Job resource that matches the specified SearchJobsRequest.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("job")]
        public virtual Job Job { get; set; } 

        /// <summary>A summary of the job with core information that's displayed on the search results listing
        /// page.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("jobSummary")]
        public virtual string JobSummary { get; set; } 

        /// <summary>Contains snippets of text from the Job.job_title field most closely matching a search query's
        /// keywords, if available. The matching query keywords are enclosed in HTML bold tags.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("jobTitleSnippet")]
        public virtual string JobTitleSnippet { get; set; } 

        /// <summary>Contains snippets of text from the Job.description and similar fields that most closely match a
        /// search query's keywords, if available. All HTML tags in the original fields are stripped when returned in
        /// this field, and matching query keywords are enclosed in HTML bold tags.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("searchTextSnippet")]
        public virtual string SearchTextSnippet { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Message representing input to a Mendel server for debug forcing. See go/mendel-debug-forcing for more
    /// details. Next ID: 2</summary>
    public class MendelDebugInput : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>When a request spans multiple servers, a MendelDebugInput may travel with the request and take
        /// effect in all the servers. This field is a map of namespaces to NamespacedMendelDebugInput protos. In a
        /// single server, up to two NamespacedMendelDebugInput protos are applied: 1. NamespacedMendelDebugInput with
        /// the global namespace (key == ""). 2. NamespacedMendelDebugInput with the server's namespace. When both
        /// NamespacedMendelDebugInput protos are present, they are merged. See go/mendel-debug-forcing for more
        /// details.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("namespacedDebugInput")]
        public virtual System.Collections.Generic.IDictionary<string,NamespacedDebugInput> NamespacedDebugInput { get; set; } 

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

    /// <summary>Next ID: 15</summary>
    public class NamespacedDebugInput : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Set of experiment names to be absolutely forced. These experiments will be forced without
        /// evaluating the conditions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("absolutelyForcedExpNames")]
        public virtual System.Collections.Generic.IList<string> AbsolutelyForcedExpNames { get; set; } 

        /// <summary>Set of experiment tags to be absolutely forced. The experiments with these tags will be forced
        /// without evaluating the conditions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("absolutelyForcedExpTags")]
        public virtual System.Collections.Generic.IList<string> AbsolutelyForcedExpTags { get; set; } 

        /// <summary>Set of experiment ids to be absolutely forced. These ids will be forced without evaluating the
        /// conditions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("absolutelyForcedExps")]
        public virtual System.Collections.Generic.IList<System.Nullable<int>> AbsolutelyForcedExps { get; set; } 

        /// <summary>Set of experiment names to be conditionally forced. These experiments will be forced only if their
        /// conditions and their parent domain's conditions are true.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("conditionallyForcedExpNames")]
        public virtual System.Collections.Generic.IList<string> ConditionallyForcedExpNames { get; set; } 

        /// <summary>Set of experiment tags to be conditionally forced. The experiments with these tags will be forced
        /// only if their conditions and their parent domain's conditions are true.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("conditionallyForcedExpTags")]
        public virtual System.Collections.Generic.IList<string> ConditionallyForcedExpTags { get; set; } 

        /// <summary>Set of experiment ids to be conditionally forced. These ids will be forced only if their conditions
        /// and their parent domain's conditions are true.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("conditionallyForcedExps")]
        public virtual System.Collections.Generic.IList<System.Nullable<int>> ConditionallyForcedExps { get; set; } 

        /// <summary>If true, disable automatic enrollment selection (at all diversion points). Automatic enrollment
        /// selection means experiment selection process based on the experiment's automatic enrollment condition. This
        /// does not disable selection of forced experiments.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disableAutomaticEnrollmentSelection")]
        public virtual System.Nullable<bool> DisableAutomaticEnrollmentSelection { get; set; } 

        /// <summary>Set of experiment names to be disabled. If an experiment is disabled, it is never selected nor
        /// forced. If an aggregate experiment is disabled, its partitions are disabled together. If an experiment with
        /// an enrollment is disabled, the enrollment is disabled together. If a name corresponds to a domain, the
        /// domain itself and all descendant experiments and domains are disabled together.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disableExpNames")]
        public virtual System.Collections.Generic.IList<string> DisableExpNames { get; set; } 

        /// <summary>Set of experiment tags to be disabled. All experiments that are tagged with one or more of these
        /// tags are disabled. If an experiment is disabled, it is never selected nor forced. If an aggregate experiment
        /// is disabled, its partitions are disabled together. If an experiment with an enrollment is disabled, the
        /// enrollment is disabled together.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disableExpTags")]
        public virtual System.Collections.Generic.IList<string> DisableExpTags { get; set; } 

        /// <summary>Set of experiment ids to be disabled. If an experiment is disabled, it is never selected nor
        /// forced. If an aggregate experiment is disabled, its partitions are disabled together. If an experiment with
        /// an enrollment is disabled, the enrollment is disabled together. If an ID corresponds to a domain, the domain
        /// itself and all descendant experiments and domains are disabled together.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disableExps")]
        public virtual System.Collections.Generic.IList<System.Nullable<int>> DisableExps { get; set; } 

        /// <summary>If true, disable manual enrollment selection (at all diversion points). Manual enrollment selection
        /// means experiment selection process based on the request's manual enrollment states (a.k.a. opt-in
        /// experiments). This does not disable selection of forced experiments.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disableManualEnrollmentSelection")]
        public virtual System.Nullable<bool> DisableManualEnrollmentSelection { get; set; } 

        /// <summary>If true, disable organic experiment selection (at all diversion points). Organic selection means
        /// experiment selection process based on traffic allocation and diversion condition evaluation. This does not
        /// disable selection of forced experiments.
        ///
        /// This is useful in cases when it is not known whether experiment selection behavior is responsible for a
        /// error or breakage. Disabling organic selection may help to isolate the cause of a given problem.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disableOrganicSelection")]
        public virtual System.Nullable<bool> DisableOrganicSelection { get; set; } 

        /// <summary>Flags to force in a particular experiment state. Map from flag name to flag value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("forcedFlags")]
        public virtual System.Collections.Generic.IDictionary<string,string> ForcedFlags { get; set; } 

        /// <summary>Rollouts to force in a particular experiment state. Map from rollout name to rollout
        /// value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("forcedRollouts")]
        public virtual System.Collections.Generic.IDictionary<string,System.Nullable<bool>> ForcedRollouts { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Input only.
    ///
    /// Use this field to specify bucketing option for the histogram search response.</summary>
    public class NumericBucketingOption : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Two adjacent values form a histogram bucket. Values should be in ascending order. For
        /// example, if [5, 10, 15] are provided, four buckets are created: (-inf, 5), 5, 10), [10, 15), [15, inf). At
        /// most 20 [buckets_bound is supported.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bucketBounds")]
        public virtual System.Collections.Generic.IList<System.Nullable<double>> BucketBounds { get; set; } 

        /// <summary>Optional. If set to true, the histogram result includes minimum/maximum value of the numeric
        /// field.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requiresMinMax")]
        public virtual System.Nullable<bool> RequiresMinMax { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Output only.
    ///
    /// Custom numeric bucketing result.</summary>
    public class NumericBucketingResult : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Count within each bucket. Its size is the length of NumericBucketingOption.bucket_bounds plus
        /// 1.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("counts")]
        public virtual System.Collections.Generic.IList<BucketizedCount> Counts { get; set; } 

        /// <summary>Stores the maximum value of the numeric field. Will be populated only if
        /// [NumericBucketingOption.requires_min_max] is set to true.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxValue")]
        public virtual System.Nullable<double> MaxValue { get; set; } 

        /// <summary>Stores the minimum value of the numeric field. Will be populated only if
        /// [NumericBucketingOption.requires_min_max] is set to true.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minValue")]
        public virtual System.Nullable<double> MinValue { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Represents a postal address, e.g. for postal delivery or payments addresses. Given a postal address, a
    /// postal service can deliver items to a premise, P.O. Box or similar. It is not intended to model geographical
    /// locations (roads, towns, mountains).
    ///
    /// In typical usage an address would be created via user input or from importing existing data, depending on the
    /// type of process.
    ///
    /// Advice on address input / editing: - Use an i18n-ready address widget such as
    /// https://github.com/google/libaddressinput) - Users should not be presented with UI elements for input or editing
    /// of fields outside countries where that field is used.
    ///
    /// For more guidance on how to use this schema, please see:
    /// https://support.google.com/business/answer/6397478</summary>
    public class PostalAddress : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Unstructured address lines describing the lower levels of an address.
        ///
        /// Because values in address_lines do not have type information and may sometimes contain multiple values in a
        /// single field (e.g. "Austin, TX"), it is important that the line order is clear. The order of address lines
        /// should be "envelope order" for the country/region of the address. In places where this can vary (e.g.
        /// Japan), address_language is used to make it explicit (e.g. "ja" for large-to-small ordering and "ja-Latn" or
        /// "en" for small-to-large). This way, the most specific line of an address can be selected based on the
        /// language.
        ///
        /// The minimum permitted structural representation of an address consists of a region_code with all remaining
        /// information placed in the address_lines. It would be possible to format such an address very approximately
        /// without geocoding, but no semantic reasoning could be made about any of the address components until it was
        /// at least partially resolved.
        ///
        /// Creating an address only containing a region_code and address_lines, and then geocoding is the recommended
        /// way to handle completely unstructured addresses (as opposed to guessing which parts of the address should be
        /// localities or administrative areas).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("addressLines")]
        public virtual System.Collections.Generic.IList<string> AddressLines { get; set; } 

        /// <summary>Optional. Highest administrative subdivision which is used for postal addresses of a country or
        /// region. For example, this can be a state, a province, an oblast, or a prefecture. Specifically, for Spain
        /// this is the province and not the autonomous community (e.g. "Barcelona" and not "Catalonia"). Many countries
        /// don't use an administrative area in postal addresses. E.g. in Switzerland this should be left
        /// unpopulated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("administrativeArea")]
        public virtual string AdministrativeArea { get; set; } 

        /// <summary>Optional. BCP-47 language code of the contents of this address (if known). This is often the UI
        /// language of the input form or is expected to match one of the languages used in the address' country/region,
        /// or their transliterated equivalents. This can affect formatting in certain countries, but is not critical to
        /// the correctness of the data and will never affect any validation or other non-formatting related operations.
        ///
        /// If this value is not known, it should be omitted (rather than specifying a possibly incorrect default).
        ///
        /// Examples: "zh-Hant", "ja", "ja-Latn", "en".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("languageCode")]
        public virtual string LanguageCode { get; set; } 

        /// <summary>Optional. Generally refers to the city/town portion of the address. Examples: US city, IT comune,
        /// UK post town. In regions of the world where localities are not well defined or do not fit into this
        /// structure well, leave locality empty and use address_lines.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locality")]
        public virtual string Locality { get; set; } 

        /// <summary>Optional. The name of the organization at the address.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("organization")]
        public virtual string Organization { get; set; } 

        /// <summary>Optional. Postal code of the address. Not all countries use or require postal codes to be present,
        /// but where they are used, they may trigger additional validation with other parts of the address (e.g.
        /// state/zip validation in the U.S.A.).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("postalCode")]
        public virtual string PostalCode { get; set; } 

        /// <summary>Optional. The recipient at the address. This field may, under certain circumstances, contain
        /// multiline information. For example, it might contain "care of" information.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("recipients")]
        public virtual System.Collections.Generic.IList<string> Recipients { get; set; } 

        /// <summary>Required. CLDR region code of the country/region of the address. This is never inferred and it is
        /// up to the user to ensure the value is correct. See http://cldr.unicode.org/ and
        /// http://www.unicode.org/cldr/charts/30/supplemental/territory_information.html for details. Example: "CH" for
        /// Switzerland.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("regionCode")]
        public virtual string RegionCode { get; set; } 

        /// <summary>The schema revision of the `PostalAddress`. This must be set to 0, which is the latest revision.
        ///
        /// All new revisions **must** be backward compatible with old revisions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("revision")]
        public virtual System.Nullable<int> Revision { get; set; } 

        /// <summary>Optional. Additional, country-specific, sorting code. This is not used in most regions. Where it is
        /// used, the value is either a string like "CEDEX", optionally followed by a number (e.g. "CEDEX 7"), or just a
        /// number alone, representing the "sector code" (Jamaica), "delivery area indicator" (Malawi) or "post office
        /// indicator" (e.g. Côte d'Ivoire).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sortingCode")]
        public virtual string SortingCode { get; set; } 

        /// <summary>Optional. Sublocality of the address. For example, this can be neighborhoods, boroughs,
        /// districts.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sublocality")]
        public virtual string Sublocality { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Input only.
    ///
    /// Meta information related to the job searcher or entity conducting the job search. This information is used to
    /// improve the performance of the service.</summary>
    public class RequestMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The type of device used by the job seeker at the time of the call to the
        /// service.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deviceInfo")]
        public virtual DeviceInfo DeviceInfo { get; set; } 

        /// <summary>Required. The client-defined scope or source of the service call, which typically is the domain on
        /// which the service has been implemented and is currently being run.
        ///
        /// For example, if the service is being run by client Foo, Inc., on job board www.foo.com and career site
        /// www.bar.com, then this field is set to "foo.com" for use on the job board, and "bar.com" for use on the
        /// career site.
        ///
        /// If this field is not available for some reason, send "UNKNOWN". Note that any improvements to the service
        /// model for a particular tenant site rely on this field being set correctly to some domain.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("domain")]
        public virtual string Domain { get; set; } 

        /// <summary>Required. A unique session identification string. A session is defined as the duration of an end
        /// user's interaction with the service over a period. Obfuscate this field for privacy concerns before
        /// providing it to the API.
        ///
        /// If this field is not available for some reason, please send "UNKNOWN". Note that any improvements to the
        /// service model for a particular tenant site, rely on this field being set correctly to some unique
        /// session_id.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sessionId")]
        public virtual string SessionId { get; set; } 

        /// <summary>Required. A unique user identification string, as determined by the client. The client is
        /// responsible for ensuring client-level uniqueness of this value in order to have the strongest positive
        /// impact on search quality. Obfuscate this field for privacy concerns before providing it to the service.
        ///
        /// If this field is not available for some reason, please send "UNKNOWN". Note that any improvements to the
        /// service model for a particular tenant site, rely on this field being set correctly to some unique
        /// user_id.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userId")]
        public virtual string UserId { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Output only.
    ///
    /// Additional information returned to client, such as debugging information.</summary>
    public class ResponseMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Identifiers for the versions of the search algorithm used during this API invocation if multiple
        /// algorithms are used. The default value is empty. For search response only.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("experimentIdList")]
        public virtual System.Collections.Generic.IList<System.Nullable<int>> ExperimentIdList { get; set; } 

        /// <summary>For search response only. Indicates the mode of a performed search.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mode")]
        public virtual string Mode { get; set; } 

        /// <summary>A unique id associated with this call. This id is logged for tracking purposes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestId")]
        public virtual string RequestId { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Input only.
    ///
    /// The Request body of the `SearchJobs` call.</summary>
    public class SearchJobsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Controls whether to disable relevance thresholding. Relevance thresholding removes jobs
        /// that have low relevance in search results, for example, removing "Assistant to the CEO" positions from the
        /// search results of a search for "CEO".
        ///
        /// Disabling relevance thresholding improves the accuracy of subsequent search requests.
        ///
        /// Defaults to false.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disableRelevanceThresholding")]
        public virtual System.Nullable<bool> DisableRelevanceThresholding { get; set; } 

        /// <summary>Optional. Controls whether to broaden the search when it produces sparse results. Broadened queries
        /// append results to the end of the matching results list.
        ///
        /// Defaults to false.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enableBroadening")]
        public virtual System.Nullable<bool> EnableBroadening { get; set; } 

        /// <summary>Optional. Controls if the search job request requires the return of a precise count of the first
        /// 300 results. Setting this to `true` ensures consistency in the number of results per page. Best practice is
        /// to set this value to true if a client allows users to jump directly to a non-sequential search results page.
        ///
        /// Enabling this flag may adversely impact performance.
        ///
        /// Defaults to false.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enablePreciseResultSize")]
        public virtual System.Nullable<bool> EnablePreciseResultSize { get; set; } 

        /// <summary>Deprecated. Use query instead.
        ///
        /// Optional.
        ///
        /// Restrictions on the scope of the search request, such as filtering by location.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filters")]
        public virtual JobFilters Filters { get; set; } 

        /// <summary>Optional. Restrictions on what fields to perform histogram on, such as `COMPANY_SIZE`
        /// etc.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("histogramFacets")]
        public virtual HistogramFacets HistogramFacets { get; set; } 

        /// <summary>Optional. The number of job attributes returned for jobs in the search response. Defaults to
        /// JobView.SMALL if no value is specified.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("jobView")]
        public virtual string JobView { get; set; } 

        /// <summary>Required. Mode of a search.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mode")]
        public virtual string Mode { get; set; } 

        /// <summary>Optional. An integer that specifies the current offset (that is, starting result location, amongst
        /// the jobs deemed by the API as relevant) in search results. This field is only considered if page_token is
        /// unset.
        ///
        /// For example, 0 means to  return results starting from the first matching job, and 10 means to return from
        /// the 11th job. This can be used for pagination, (for example, pageSize = 10 and offset = 10 means to return
        /// from the second page).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("offset")]
        public virtual System.Nullable<int> Offset { get; set; } 

        /// <summary>Deprecated. Use sort_by instead.
        ///
        /// Optional.
        ///
        /// The criteria determining how search results are sorted. Defaults to SortBy.RELEVANCE_DESC if no value is
        /// specified.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("orderBy")]
        public virtual string OrderBy { get; set; } 

        /// <summary>Optional. A limit on the number of jobs returned in the search results. Increasing this value above
        /// the default value of 10 can increase search response time. The value can be between 1 and 100.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageSize")]
        public virtual System.Nullable<int> PageSize { get; set; } 

        /// <summary>Optional. The token specifying the current offset within search results. See
        /// SearchJobsResponse.next_page_token for an explanation of how to obtain the next set of query
        /// results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageToken")]
        public virtual string PageToken { get; set; } 

        /// <summary>Optional. Query used to search against jobs, such as keyword, location filters, etc.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("query")]
        public virtual JobQuery Query { get; set; } 

        /// <summary>Required. The meta information collected about the job searcher, used to improve the search quality
        /// of the service. The identifiers, (such as `user_id`) are provided by users, and must be unique and
        /// consistent.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestMetadata")]
        public virtual RequestMetadata RequestMetadata { get; set; } 

        /// <summary>Optional. The criteria determining how search results are sorted. Defaults to SortBy.RELEVANCE_DESC
        /// if no value is specified.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sortBy")]
        public virtual string SortBy { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Output only.
    ///
    /// Response for SearchJob method.</summary>
    public class SearchJobsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The commute filter the service applied to the specified query. This information is only available
        /// when query has a valid CommutePreference.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("appliedCommuteFilter")]
        public virtual CommutePreference AppliedCommuteFilter { get; set; } 

        /// <summary>The location filters that the service applied to the specified query. If any filters are lat-lng
        /// based, the JobLocation.location_type is JobLocation.LocationType#LOCATION_TYPE_UNSPECIFIED.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("appliedJobLocationFilters")]
        public virtual System.Collections.Generic.IList<JobLocation> AppliedJobLocationFilters { get; set; } 

        /// <summary>An estimation of the number of jobs that match the specified query.
        ///
        /// This number is not guaranteed to be accurate. For accurate results,
        /// seenenable_precise_result_size.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("estimatedTotalSize")]
        public virtual System.Nullable<long> EstimatedTotalSize { get; set; } 

        /// <summary>The histogram results that match specified SearchJobsRequest.HistogramFacets.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("histogramResults")]
        public virtual HistogramResults HistogramResults { get; set; } 

        /// <summary>Corresponds to SearchJobsRequest.job_view.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("jobView")]
        public virtual string JobView { get; set; } 

        /// <summary>The Job entities that match the specified SearchJobsRequest.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("matchingJobs")]
        public virtual System.Collections.Generic.IList<MatchingJob> MatchingJobs { get; set; } 

        /// <summary>Additional information for the API invocation, such as the request tracking id.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual ResponseMetadata Metadata { get; set; } 

        /// <summary>The token that specifies the starting position of the next page of results. This field is empty if
        /// there are no more results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; } 

        /// <summary>If query broadening is enabled, we may append additional results from the broadened query. This
        /// number indicates how many of the jobs returned in the jobs field are from the broadened query. These results
        /// are always at the end of the jobs list. In particular, a value of 0 means all the jobs in the jobs list are
        /// from the original (without broadening) query. If this field is non-zero, subsequent requests with offset
        /// after this result set should contain all broadened results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("numJobsFromBroadenedQuery")]
        public virtual System.Nullable<int> NumJobsFromBroadenedQuery { get; set; } 

        /// <summary>The spell checking result, and correction.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("spellResult")]
        public virtual SpellingCorrection SpellResult { get; set; } 

        /// <summary>The precise result count, which is available only if the client set enable_precise_result_size to
        /// `true` or if the response is the last page of results. Otherwise, the value will be `-1`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalSize")]
        public virtual System.Nullable<long> TotalSize { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Output only.
    ///
    /// Spell check result.</summary>
    public class SpellingCorrection : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Indicates if the query was corrected by the spell checker.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("corrected")]
        public virtual System.Nullable<bool> Corrected { get; set; } 

        /// <summary>Correction output consisting of the corrected keyword string.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("correctedText")]
        public virtual string CorrectedText { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Represents array of string values.</summary>
    public class StringValues : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. String values.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("values")]
        public virtual System.Collections.Generic.IList<string> Values { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Input only.
    ///
    /// Update job request.</summary>
    public class UpdateJobRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Deprecated. Please use processing_options. This flag is ignored if processing_options is set.
        ///
        /// Optional.
        ///
        /// If set to `true`, the service does not attempt resolve a more precise address for the job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disableStreetAddressResolution")]
        public virtual System.Nullable<bool> DisableStreetAddressResolution { get; set; } 

        /// <summary>Required. The Job to be updated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("job")]
        public virtual Job Job { get; set; } 

        /// <summary>Optional. Options for job processing.
        ///
        /// UpdateJobRequest.disable_street_address_resolution is ignored if this flag is set.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("processingOptions")]
        public virtual JobProcessingOptions ProcessingOptions { get; set; } 

        /// <summary>Optional but strongly recommended to be provided for the best service experience.
        ///
        /// If update_job_fields is provided, only the specified fields in job are updated. Otherwise all the fields are
        /// updated.
        ///
        /// A field mask to restrict the fields that are updated. Valid values are:
        ///
        /// * jobTitle * employmentTypes * description * applicationUrls * applicationEmailList * applicationInstruction
        /// * responsibilities * qualifications * educationLevels * level * department * startDate * endDate *
        /// compensationInfo * incentives * languageCode * benefits * expireTime * customAttributes * visibility *
        /// publishDate * promotionValue * locations * region * expiryDate (deprecated) * filterableCustomFields
        /// (deprecated) * unindexedCustomFields (deprecated)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateJobFields")]
        public virtual object UpdateJobFields { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
