// Copyright 2021 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

// Generated code. DO NOT EDIT!

namespace Google.Apis.CloudResourceManager.v1
{
    /// <summary>The CloudResourceManager Service.</summary>
    public class CloudResourceManagerService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public CloudResourceManagerService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public CloudResourceManagerService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Folders = new FoldersResource(this);
            Liens = new LiensResource(this);
            Operations = new OperationsResource(this);
            Organizations = new OrganizationsResource(this);
            Projects = new ProjectsResource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "cloudresourcemanager";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri =>
        #if NETSTANDARD1_3 || NETSTANDARD2_0 || NET45
            BaseUriOverride ?? "https://cloudresourcemanager.googleapis.com/";
        #else
            "https://cloudresourcemanager.googleapis.com/";
        #endif

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        #if !NET40
        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri => "https://cloudresourcemanager.googleapis.com/batch";

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";
        #endif

        /// <summary>Available OAuth 2.0 scopes for use with the Cloud Resource Manager API.</summary>
        public class Scope
        {
            /// <summary>See, edit, configure, and delete your Google Cloud Platform data</summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";

            /// <summary>View your data across Google Cloud Platform services</summary>
            public static string CloudPlatformReadOnly = "https://www.googleapis.com/auth/cloud-platform.read-only";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Cloud Resource Manager API.</summary>
        public static class ScopeConstants
        {
            /// <summary>See, edit, configure, and delete your Google Cloud Platform data</summary>
            public const string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";

            /// <summary>View your data across Google Cloud Platform services</summary>
            public const string CloudPlatformReadOnly = "https://www.googleapis.com/auth/cloud-platform.read-only";
        }

        /// <summary>Gets the Folders resource.</summary>
        public virtual FoldersResource Folders { get; }

        /// <summary>Gets the Liens resource.</summary>
        public virtual LiensResource Liens { get; }

        /// <summary>Gets the Operations resource.</summary>
        public virtual OperationsResource Operations { get; }

        /// <summary>Gets the Organizations resource.</summary>
        public virtual OrganizationsResource Organizations { get; }

        /// <summary>Gets the Projects resource.</summary>
        public virtual ProjectsResource Projects { get; }
    }

    /// <summary>A base abstract class for CloudResourceManager requests.</summary>
    public abstract class CloudResourceManagerBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new CloudResourceManagerBaseServiceRequest instance.</summary>
        protected CloudResourceManagerBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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
            Value1 = 0,

            /// <summary>v2 error format</summary>
            [Google.Apis.Util.StringValueAttribute("2")]
            Value2 = 1,
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
            Json = 0,

            /// <summary>Media download with context-dependent Content-Type</summary>
            [Google.Apis.Util.StringValueAttribute("media")]
            Media = 1,

            /// <summary>Responses with Content-Type of application/x-protobuf</summary>
            [Google.Apis.Util.StringValueAttribute("proto")]
            Proto = 2,
        }

        /// <summary>JSONP</summary>
        [Google.Apis.Util.RequestParameterAttribute("callback", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string Callback { get; set; }

        /// <summary>Selector specifying which fields to include in a partial response.</summary>
        [Google.Apis.Util.RequestParameterAttribute("fields", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string Fields { get; set; }

        /// <summary>
        /// API key. Your API key identifies your project and provides you with API access, quota, and reports. Required
        /// unless you provide an OAuth 2.0 token.
        /// </summary>
        [Google.Apis.Util.RequestParameterAttribute("key", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string Key { get; set; }

        /// <summary>OAuth 2.0 token for the current user.</summary>
        [Google.Apis.Util.RequestParameterAttribute("oauth_token", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string OauthToken { get; set; }

        /// <summary>Returns response with indentations and line breaks.</summary>
        [Google.Apis.Util.RequestParameterAttribute("prettyPrint", Google.Apis.Util.RequestParameterType.Query)]
        public virtual System.Nullable<bool> PrettyPrint { get; set; }

        /// <summary>
        /// Available to use for quota purposes for server-side applications. Can be any arbitrary string assigned to a
        /// user, but should not exceed 40 characters.
        /// </summary>
        [Google.Apis.Util.RequestParameterAttribute("quotaUser", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string QuotaUser { get; set; }

        /// <summary>Legacy upload protocol for media (e.g. "media", "multipart").</summary>
        [Google.Apis.Util.RequestParameterAttribute("uploadType", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string UploadType { get; set; }

        /// <summary>Upload protocol for media (e.g. "raw", "multipart").</summary>
        [Google.Apis.Util.RequestParameterAttribute("upload_protocol", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string UploadProtocol { get; set; }

        /// <summary>Initializes CloudResourceManager parameter list.</summary>
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

    /// <summary>The "folders" collection of methods.</summary>
    public class FoldersResource
    {
        private const string Resource = "folders";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public FoldersResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Clears a `Policy` from a resource.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="resource">Name of the resource for the `Policy` to clear.</param>
        public virtual ClearOrgPolicyRequest ClearOrgPolicy(Google.Apis.CloudResourceManager.v1.Data.ClearOrgPolicyRequest body, string resource)
        {
            return new ClearOrgPolicyRequest(service, body, resource);
        }

        /// <summary>Clears a `Policy` from a resource.</summary>
        public class ClearOrgPolicyRequest : CloudResourceManagerBaseServiceRequest<Google.Apis.CloudResourceManager.v1.Data.Empty>
        {
            /// <summary>Constructs a new ClearOrgPolicy request.</summary>
            public ClearOrgPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudResourceManager.v1.Data.ClearOrgPolicyRequest body, string resource) : base(service)
            {
                Resource = resource;
                Body = body;
                InitParameters();
            }

            /// <summary>Name of the resource for the `Policy` to clear.</summary>
            [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Resource { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.CloudResourceManager.v1.Data.ClearOrgPolicyRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "clearOrgPolicy";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/{+resource}:clearOrgPolicy";

            /// <summary>Initializes ClearOrgPolicy parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("resource", new Google.Apis.Discovery.Parameter
                {
                    Name = "resource",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^folders/[^/]+$",
                });
            }
        }

        /// <summary>
        /// Gets the effective `Policy` on a resource. This is the result of merging `Policies` in the resource
        /// hierarchy. The returned `Policy` will not have an `etag`set because it is a computed `Policy` across
        /// multiple resources. Subtrees of Resource Manager resource hierarchy with 'under:' prefix will not be
        /// expanded.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="resource">The name of the resource to start computing the effective `Policy`.</param>
        public virtual GetEffectiveOrgPolicyRequest GetEffectiveOrgPolicy(Google.Apis.CloudResourceManager.v1.Data.GetEffectiveOrgPolicyRequest body, string resource)
        {
            return new GetEffectiveOrgPolicyRequest(service, body, resource);
        }

        /// <summary>
        /// Gets the effective `Policy` on a resource. This is the result of merging `Policies` in the resource
        /// hierarchy. The returned `Policy` will not have an `etag`set because it is a computed `Policy` across
        /// multiple resources. Subtrees of Resource Manager resource hierarchy with 'under:' prefix will not be
        /// expanded.
        /// </summary>
        public class GetEffectiveOrgPolicyRequest : CloudResourceManagerBaseServiceRequest<Google.Apis.CloudResourceManager.v1.Data.OrgPolicy>
        {
            /// <summary>Constructs a new GetEffectiveOrgPolicy request.</summary>
            public GetEffectiveOrgPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudResourceManager.v1.Data.GetEffectiveOrgPolicyRequest body, string resource) : base(service)
            {
                Resource = resource;
                Body = body;
                InitParameters();
            }

            /// <summary>The name of the resource to start computing the effective `Policy`.</summary>
            [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Resource { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.CloudResourceManager.v1.Data.GetEffectiveOrgPolicyRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "getEffectiveOrgPolicy";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/{+resource}:getEffectiveOrgPolicy";

            /// <summary>Initializes GetEffectiveOrgPolicy parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("resource", new Google.Apis.Discovery.Parameter
                {
                    Name = "resource",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^folders/[^/]+$",
                });
            }
        }

        /// <summary>
        /// Gets a `Policy` on a resource. If no `Policy` is set on the resource, a `Policy` is returned with default
        /// values including `POLICY_TYPE_NOT_SET` for the `policy_type oneof`. The `etag` value can be used with
        /// `SetOrgPolicy()` to create or update a `Policy` during read-modify-write.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="resource">Name of the resource the `Policy` is set on.</param>
        public virtual GetOrgPolicyRequest GetOrgPolicy(Google.Apis.CloudResourceManager.v1.Data.GetOrgPolicyRequest body, string resource)
        {
            return new GetOrgPolicyRequest(service, body, resource);
        }

        /// <summary>
        /// Gets a `Policy` on a resource. If no `Policy` is set on the resource, a `Policy` is returned with default
        /// values including `POLICY_TYPE_NOT_SET` for the `policy_type oneof`. The `etag` value can be used with
        /// `SetOrgPolicy()` to create or update a `Policy` during read-modify-write.
        /// </summary>
        public class GetOrgPolicyRequest : CloudResourceManagerBaseServiceRequest<Google.Apis.CloudResourceManager.v1.Data.OrgPolicy>
        {
            /// <summary>Constructs a new GetOrgPolicy request.</summary>
            public GetOrgPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudResourceManager.v1.Data.GetOrgPolicyRequest body, string resource) : base(service)
            {
                Resource = resource;
                Body = body;
                InitParameters();
            }

            /// <summary>Name of the resource the `Policy` is set on.</summary>
            [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Resource { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.CloudResourceManager.v1.Data.GetOrgPolicyRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "getOrgPolicy";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/{+resource}:getOrgPolicy";

            /// <summary>Initializes GetOrgPolicy parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("resource", new Google.Apis.Discovery.Parameter
                {
                    Name = "resource",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^folders/[^/]+$",
                });
            }
        }

        /// <summary>Lists `Constraints` that could be applied on the specified resource.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="resource">Name of the resource to list `Constraints` for.</param>
        public virtual ListAvailableOrgPolicyConstraintsRequest ListAvailableOrgPolicyConstraints(Google.Apis.CloudResourceManager.v1.Data.ListAvailableOrgPolicyConstraintsRequest body, string resource)
        {
            return new ListAvailableOrgPolicyConstraintsRequest(service, body, resource);
        }

        /// <summary>Lists `Constraints` that could be applied on the specified resource.</summary>
        public class ListAvailableOrgPolicyConstraintsRequest : CloudResourceManagerBaseServiceRequest<Google.Apis.CloudResourceManager.v1.Data.ListAvailableOrgPolicyConstraintsResponse>
        {
            /// <summary>Constructs a new ListAvailableOrgPolicyConstraints request.</summary>
            public ListAvailableOrgPolicyConstraintsRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudResourceManager.v1.Data.ListAvailableOrgPolicyConstraintsRequest body, string resource) : base(service)
            {
                Resource = resource;
                Body = body;
                InitParameters();
            }

            /// <summary>Name of the resource to list `Constraints` for.</summary>
            [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Resource { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.CloudResourceManager.v1.Data.ListAvailableOrgPolicyConstraintsRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "listAvailableOrgPolicyConstraints";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/{+resource}:listAvailableOrgPolicyConstraints";

            /// <summary>Initializes ListAvailableOrgPolicyConstraints parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("resource", new Google.Apis.Discovery.Parameter
                {
                    Name = "resource",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^folders/[^/]+$",
                });
            }
        }

        /// <summary>Lists all the `Policies` set for a particular resource.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="resource">Name of the resource to list Policies for.</param>
        public virtual ListOrgPoliciesRequest ListOrgPolicies(Google.Apis.CloudResourceManager.v1.Data.ListOrgPoliciesRequest body, string resource)
        {
            return new ListOrgPoliciesRequest(service, body, resource);
        }

        /// <summary>Lists all the `Policies` set for a particular resource.</summary>
        public class ListOrgPoliciesRequest : CloudResourceManagerBaseServiceRequest<Google.Apis.CloudResourceManager.v1.Data.ListOrgPoliciesResponse>
        {
            /// <summary>Constructs a new ListOrgPolicies request.</summary>
            public ListOrgPoliciesRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudResourceManager.v1.Data.ListOrgPoliciesRequest body, string resource) : base(service)
            {
                Resource = resource;
                Body = body;
                InitParameters();
            }

            /// <summary>Name of the resource to list Policies for.</summary>
            [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Resource { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.CloudResourceManager.v1.Data.ListOrgPoliciesRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "listOrgPolicies";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/{+resource}:listOrgPolicies";

            /// <summary>Initializes ListOrgPolicies parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("resource", new Google.Apis.Discovery.Parameter
                {
                    Name = "resource",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^folders/[^/]+$",
                });
            }
        }

        /// <summary>
        /// Updates the specified `Policy` on the resource. Creates a new `Policy` for that `Constraint` on the resource
        /// if one does not exist. Not supplying an `etag` on the request `Policy` results in an unconditional write of
        /// the `Policy`.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="resource">Resource name of the resource to attach the `Policy`.</param>
        public virtual SetOrgPolicyRequest SetOrgPolicy(Google.Apis.CloudResourceManager.v1.Data.SetOrgPolicyRequest body, string resource)
        {
            return new SetOrgPolicyRequest(service, body, resource);
        }

        /// <summary>
        /// Updates the specified `Policy` on the resource. Creates a new `Policy` for that `Constraint` on the resource
        /// if one does not exist. Not supplying an `etag` on the request `Policy` results in an unconditional write of
        /// the `Policy`.
        /// </summary>
        public class SetOrgPolicyRequest : CloudResourceManagerBaseServiceRequest<Google.Apis.CloudResourceManager.v1.Data.OrgPolicy>
        {
            /// <summary>Constructs a new SetOrgPolicy request.</summary>
            public SetOrgPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudResourceManager.v1.Data.SetOrgPolicyRequest body, string resource) : base(service)
            {
                Resource = resource;
                Body = body;
                InitParameters();
            }

            /// <summary>Resource name of the resource to attach the `Policy`.</summary>
            [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Resource { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.CloudResourceManager.v1.Data.SetOrgPolicyRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "setOrgPolicy";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/{+resource}:setOrgPolicy";

            /// <summary>Initializes SetOrgPolicy parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("resource", new Google.Apis.Discovery.Parameter
                {
                    Name = "resource",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^folders/[^/]+$",
                });
            }
        }
    }

    /// <summary>The "liens" collection of methods.</summary>
    public class LiensResource
    {
        private const string Resource = "liens";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public LiensResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>
        /// Create a Lien which applies to the resource denoted by the `parent` field. Callers of this method will
        /// require permission on the `parent` resource. For example, applying to `projects/1234` requires permission
        /// `resourcemanager.projects.updateLiens`. NOTE: Some resources may limit the number of Liens which may be
        /// applied.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        public virtual CreateRequest Create(Google.Apis.CloudResourceManager.v1.Data.Lien body)
        {
            return new CreateRequest(service, body);
        }

        /// <summary>
        /// Create a Lien which applies to the resource denoted by the `parent` field. Callers of this method will
        /// require permission on the `parent` resource. For example, applying to `projects/1234` requires permission
        /// `resourcemanager.projects.updateLiens`. NOTE: Some resources may limit the number of Liens which may be
        /// applied.
        /// </summary>
        public class CreateRequest : CloudResourceManagerBaseServiceRequest<Google.Apis.CloudResourceManager.v1.Data.Lien>
        {
            /// <summary>Constructs a new Create request.</summary>
            public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudResourceManager.v1.Data.Lien body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.CloudResourceManager.v1.Data.Lien Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "create";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/liens";

            /// <summary>Initializes Create parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
            }
        }

        /// <summary>
        /// Delete a Lien by `name`. Callers of this method will require permission on the `parent` resource. For
        /// example, a Lien with a `parent` of `projects/1234` requires permission
        /// `resourcemanager.projects.updateLiens`.
        /// </summary>
        /// <param name="name">Required. The name/identifier of the Lien to delete.</param>
        public virtual DeleteRequest Delete(string name)
        {
            return new DeleteRequest(service, name);
        }

        /// <summary>
        /// Delete a Lien by `name`. Callers of this method will require permission on the `parent` resource. For
        /// example, a Lien with a `parent` of `projects/1234` requires permission
        /// `resourcemanager.projects.updateLiens`.
        /// </summary>
        public class DeleteRequest : CloudResourceManagerBaseServiceRequest<Google.Apis.CloudResourceManager.v1.Data.Empty>
        {
            /// <summary>Constructs a new Delete request.</summary>
            public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

            /// <summary>Required. The name/identifier of the Lien to delete.</summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "delete";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "DELETE";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/{+name}";

            /// <summary>Initializes Delete parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^liens/.*$",
                });
            }
        }

        /// <summary>
        /// Retrieve a Lien by `name`. Callers of this method will require permission on the `parent` resource. For
        /// example, a Lien with a `parent` of `projects/1234` requires permission `resourcemanager.projects.get`
        /// </summary>
        /// <param name="name">Required. The name/identifier of the Lien.</param>
        public virtual GetRequest Get(string name)
        {
            return new GetRequest(service, name);
        }

        /// <summary>
        /// Retrieve a Lien by `name`. Callers of this method will require permission on the `parent` resource. For
        /// example, a Lien with a `parent` of `projects/1234` requires permission `resourcemanager.projects.get`
        /// </summary>
        public class GetRequest : CloudResourceManagerBaseServiceRequest<Google.Apis.CloudResourceManager.v1.Data.Lien>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

            /// <summary>Required. The name/identifier of the Lien.</summary>
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
                    Pattern = @"^liens/.*$",
                });
            }
        }

        /// <summary>
        /// List all Liens applied to the `parent` resource. Callers of this method will require permission on the
        /// `parent` resource. For example, a Lien with a `parent` of `projects/1234` requires permission
        /// `resourcemanager.projects.get`.
        /// </summary>
        public virtual ListRequest List()
        {
            return new ListRequest(service);
        }

        /// <summary>
        /// List all Liens applied to the `parent` resource. Callers of this method will require permission on the
        /// `parent` resource. For example, a Lien with a `parent` of `projects/1234` requires permission
        /// `resourcemanager.projects.get`.
        /// </summary>
        public class ListRequest : CloudResourceManagerBaseServiceRequest<Google.Apis.CloudResourceManager.v1.Data.ListLiensResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>The maximum number of items to return. This is a suggestion for the server.</summary>
            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> PageSize { get; set; }

            /// <summary>The `next_page_token` value returned from a previous List request, if any.</summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>
            /// Required. The name of the resource to list all attached Liens. For example, `projects/1234`.
            /// (google.api.field_policy).resource_type annotation is not set since the parent depends on the meta api
            /// implementation. This field could be a project or other sub project resources.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Parent { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/liens";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
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
                RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                {
                    Name = "parent",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }

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

        /// <summary>
        /// Gets the latest state of a long-running operation. Clients can use this method to poll the operation result
        /// at intervals as recommended by the API service.
        /// </summary>
        /// <param name="name">The name of the operation resource.</param>
        public virtual GetRequest Get(string name)
        {
            return new GetRequest(service, name);
        }

        /// <summary>
        /// Gets the latest state of a long-running operation. Clients can use this method to poll the operation result
        /// at intervals as recommended by the API service.
        /// </summary>
        public class GetRequest : CloudResourceManagerBaseServiceRequest<Google.Apis.CloudResourceManager.v1.Data.Operation>
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
                    Pattern = @"^operations/.*$",
                });
            }
        }
    }

    /// <summary>The "organizations" collection of methods.</summary>
    public class OrganizationsResource
    {
        private const string Resource = "organizations";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public OrganizationsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Clears a `Policy` from a resource.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="resource">Name of the resource for the `Policy` to clear.</param>
        public virtual ClearOrgPolicyRequest ClearOrgPolicy(Google.Apis.CloudResourceManager.v1.Data.ClearOrgPolicyRequest body, string resource)
        {
            return new ClearOrgPolicyRequest(service, body, resource);
        }

        /// <summary>Clears a `Policy` from a resource.</summary>
        public class ClearOrgPolicyRequest : CloudResourceManagerBaseServiceRequest<Google.Apis.CloudResourceManager.v1.Data.Empty>
        {
            /// <summary>Constructs a new ClearOrgPolicy request.</summary>
            public ClearOrgPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudResourceManager.v1.Data.ClearOrgPolicyRequest body, string resource) : base(service)
            {
                Resource = resource;
                Body = body;
                InitParameters();
            }

            /// <summary>Name of the resource for the `Policy` to clear.</summary>
            [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Resource { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.CloudResourceManager.v1.Data.ClearOrgPolicyRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "clearOrgPolicy";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/{+resource}:clearOrgPolicy";

            /// <summary>Initializes ClearOrgPolicy parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("resource", new Google.Apis.Discovery.Parameter
                {
                    Name = "resource",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^organizations/[^/]+$",
                });
            }
        }

        /// <summary>Fetches an Organization resource identified by the specified resource name.</summary>
        /// <param name="name">
        /// The resource name of the Organization to fetch. This is the organization's relative path in the API,
        /// formatted as "organizations/[organizationId]". For example, "organizations/1234".
        /// </param>
        public virtual GetRequest Get(string name)
        {
            return new GetRequest(service, name);
        }

        /// <summary>Fetches an Organization resource identified by the specified resource name.</summary>
        public class GetRequest : CloudResourceManagerBaseServiceRequest<Google.Apis.CloudResourceManager.v1.Data.Organization>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

            /// <summary>
            /// The resource name of the Organization to fetch. This is the organization's relative path in the API,
            /// formatted as "organizations/[organizationId]". For example, "organizations/1234".
            /// </summary>
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
                    Pattern = @"^organizations/[^/]+$",
                });
            }
        }

        /// <summary>
        /// Gets the effective `Policy` on a resource. This is the result of merging `Policies` in the resource
        /// hierarchy. The returned `Policy` will not have an `etag`set because it is a computed `Policy` across
        /// multiple resources. Subtrees of Resource Manager resource hierarchy with 'under:' prefix will not be
        /// expanded.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="resource">The name of the resource to start computing the effective `Policy`.</param>
        public virtual GetEffectiveOrgPolicyRequest GetEffectiveOrgPolicy(Google.Apis.CloudResourceManager.v1.Data.GetEffectiveOrgPolicyRequest body, string resource)
        {
            return new GetEffectiveOrgPolicyRequest(service, body, resource);
        }

        /// <summary>
        /// Gets the effective `Policy` on a resource. This is the result of merging `Policies` in the resource
        /// hierarchy. The returned `Policy` will not have an `etag`set because it is a computed `Policy` across
        /// multiple resources. Subtrees of Resource Manager resource hierarchy with 'under:' prefix will not be
        /// expanded.
        /// </summary>
        public class GetEffectiveOrgPolicyRequest : CloudResourceManagerBaseServiceRequest<Google.Apis.CloudResourceManager.v1.Data.OrgPolicy>
        {
            /// <summary>Constructs a new GetEffectiveOrgPolicy request.</summary>
            public GetEffectiveOrgPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudResourceManager.v1.Data.GetEffectiveOrgPolicyRequest body, string resource) : base(service)
            {
                Resource = resource;
                Body = body;
                InitParameters();
            }

            /// <summary>The name of the resource to start computing the effective `Policy`.</summary>
            [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Resource { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.CloudResourceManager.v1.Data.GetEffectiveOrgPolicyRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "getEffectiveOrgPolicy";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/{+resource}:getEffectiveOrgPolicy";

            /// <summary>Initializes GetEffectiveOrgPolicy parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("resource", new Google.Apis.Discovery.Parameter
                {
                    Name = "resource",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^organizations/[^/]+$",
                });
            }
        }

        /// <summary>
        /// Gets the access control policy for an Organization resource. May be empty if no such policy or resource
        /// exists. The `resource` field should be the organization's resource name, e.g. "organizations/123".
        /// Authorization requires the Google IAM permission `resourcemanager.organizations.getIamPolicy` on the
        /// specified organization
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being requested. See the operation documentation for the
        /// appropriate value for this field.
        /// </param>
        public virtual GetIamPolicyRequest GetIamPolicy(Google.Apis.CloudResourceManager.v1.Data.GetIamPolicyRequest body, string resource)
        {
            return new GetIamPolicyRequest(service, body, resource);
        }

        /// <summary>
        /// Gets the access control policy for an Organization resource. May be empty if no such policy or resource
        /// exists. The `resource` field should be the organization's resource name, e.g. "organizations/123".
        /// Authorization requires the Google IAM permission `resourcemanager.organizations.getIamPolicy` on the
        /// specified organization
        /// </summary>
        public class GetIamPolicyRequest : CloudResourceManagerBaseServiceRequest<Google.Apis.CloudResourceManager.v1.Data.Policy>
        {
            /// <summary>Constructs a new GetIamPolicy request.</summary>
            public GetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudResourceManager.v1.Data.GetIamPolicyRequest body, string resource) : base(service)
            {
                Resource = resource;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// REQUIRED: The resource for which the policy is being requested. See the operation documentation for the
            /// appropriate value for this field.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Resource { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.CloudResourceManager.v1.Data.GetIamPolicyRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "getIamPolicy";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/{+resource}:getIamPolicy";

            /// <summary>Initializes GetIamPolicy parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("resource", new Google.Apis.Discovery.Parameter
                {
                    Name = "resource",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^organizations/[^/]+$",
                });
            }
        }

        /// <summary>
        /// Gets a `Policy` on a resource. If no `Policy` is set on the resource, a `Policy` is returned with default
        /// values including `POLICY_TYPE_NOT_SET` for the `policy_type oneof`. The `etag` value can be used with
        /// `SetOrgPolicy()` to create or update a `Policy` during read-modify-write.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="resource">Name of the resource the `Policy` is set on.</param>
        public virtual GetOrgPolicyRequest GetOrgPolicy(Google.Apis.CloudResourceManager.v1.Data.GetOrgPolicyRequest body, string resource)
        {
            return new GetOrgPolicyRequest(service, body, resource);
        }

        /// <summary>
        /// Gets a `Policy` on a resource. If no `Policy` is set on the resource, a `Policy` is returned with default
        /// values including `POLICY_TYPE_NOT_SET` for the `policy_type oneof`. The `etag` value can be used with
        /// `SetOrgPolicy()` to create or update a `Policy` during read-modify-write.
        /// </summary>
        public class GetOrgPolicyRequest : CloudResourceManagerBaseServiceRequest<Google.Apis.CloudResourceManager.v1.Data.OrgPolicy>
        {
            /// <summary>Constructs a new GetOrgPolicy request.</summary>
            public GetOrgPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudResourceManager.v1.Data.GetOrgPolicyRequest body, string resource) : base(service)
            {
                Resource = resource;
                Body = body;
                InitParameters();
            }

            /// <summary>Name of the resource the `Policy` is set on.</summary>
            [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Resource { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.CloudResourceManager.v1.Data.GetOrgPolicyRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "getOrgPolicy";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/{+resource}:getOrgPolicy";

            /// <summary>Initializes GetOrgPolicy parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("resource", new Google.Apis.Discovery.Parameter
                {
                    Name = "resource",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^organizations/[^/]+$",
                });
            }
        }

        /// <summary>Lists `Constraints` that could be applied on the specified resource.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="resource">Name of the resource to list `Constraints` for.</param>
        public virtual ListAvailableOrgPolicyConstraintsRequest ListAvailableOrgPolicyConstraints(Google.Apis.CloudResourceManager.v1.Data.ListAvailableOrgPolicyConstraintsRequest body, string resource)
        {
            return new ListAvailableOrgPolicyConstraintsRequest(service, body, resource);
        }

        /// <summary>Lists `Constraints` that could be applied on the specified resource.</summary>
        public class ListAvailableOrgPolicyConstraintsRequest : CloudResourceManagerBaseServiceRequest<Google.Apis.CloudResourceManager.v1.Data.ListAvailableOrgPolicyConstraintsResponse>
        {
            /// <summary>Constructs a new ListAvailableOrgPolicyConstraints request.</summary>
            public ListAvailableOrgPolicyConstraintsRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudResourceManager.v1.Data.ListAvailableOrgPolicyConstraintsRequest body, string resource) : base(service)
            {
                Resource = resource;
                Body = body;
                InitParameters();
            }

            /// <summary>Name of the resource to list `Constraints` for.</summary>
            [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Resource { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.CloudResourceManager.v1.Data.ListAvailableOrgPolicyConstraintsRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "listAvailableOrgPolicyConstraints";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/{+resource}:listAvailableOrgPolicyConstraints";

            /// <summary>Initializes ListAvailableOrgPolicyConstraints parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("resource", new Google.Apis.Discovery.Parameter
                {
                    Name = "resource",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^organizations/[^/]+$",
                });
            }
        }

        /// <summary>Lists all the `Policies` set for a particular resource.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="resource">Name of the resource to list Policies for.</param>
        public virtual ListOrgPoliciesRequest ListOrgPolicies(Google.Apis.CloudResourceManager.v1.Data.ListOrgPoliciesRequest body, string resource)
        {
            return new ListOrgPoliciesRequest(service, body, resource);
        }

        /// <summary>Lists all the `Policies` set for a particular resource.</summary>
        public class ListOrgPoliciesRequest : CloudResourceManagerBaseServiceRequest<Google.Apis.CloudResourceManager.v1.Data.ListOrgPoliciesResponse>
        {
            /// <summary>Constructs a new ListOrgPolicies request.</summary>
            public ListOrgPoliciesRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudResourceManager.v1.Data.ListOrgPoliciesRequest body, string resource) : base(service)
            {
                Resource = resource;
                Body = body;
                InitParameters();
            }

            /// <summary>Name of the resource to list Policies for.</summary>
            [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Resource { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.CloudResourceManager.v1.Data.ListOrgPoliciesRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "listOrgPolicies";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/{+resource}:listOrgPolicies";

            /// <summary>Initializes ListOrgPolicies parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("resource", new Google.Apis.Discovery.Parameter
                {
                    Name = "resource",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^organizations/[^/]+$",
                });
            }
        }

        /// <summary>
        /// Searches Organization resources that are visible to the user and satisfy the specified filter. This method
        /// returns Organizations in an unspecified order. New Organizations do not necessarily appear at the end of the
        /// results. Search will only return organizations on which the user has the permission
        /// `resourcemanager.organizations.get`
        /// </summary>
        /// <param name="body">The body of the request.</param>
        public virtual SearchRequest Search(Google.Apis.CloudResourceManager.v1.Data.SearchOrganizationsRequest body)
        {
            return new SearchRequest(service, body);
        }

        /// <summary>
        /// Searches Organization resources that are visible to the user and satisfy the specified filter. This method
        /// returns Organizations in an unspecified order. New Organizations do not necessarily appear at the end of the
        /// results. Search will only return organizations on which the user has the permission
        /// `resourcemanager.organizations.get`
        /// </summary>
        public class SearchRequest : CloudResourceManagerBaseServiceRequest<Google.Apis.CloudResourceManager.v1.Data.SearchOrganizationsResponse>
        {
            /// <summary>Constructs a new Search request.</summary>
            public SearchRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudResourceManager.v1.Data.SearchOrganizationsRequest body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.CloudResourceManager.v1.Data.SearchOrganizationsRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "search";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/organizations:search";

            /// <summary>Initializes Search parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
            }
        }

        /// <summary>
        /// Sets the access control policy on an Organization resource. Replaces any existing policy. The `resource`
        /// field should be the organization's resource name, e.g. "organizations/123". Authorization requires the
        /// Google IAM permission `resourcemanager.organizations.setIamPolicy` on the specified organization
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being specified. See the operation documentation for the
        /// appropriate value for this field.
        /// </param>
        public virtual SetIamPolicyRequest SetIamPolicy(Google.Apis.CloudResourceManager.v1.Data.SetIamPolicyRequest body, string resource)
        {
            return new SetIamPolicyRequest(service, body, resource);
        }

        /// <summary>
        /// Sets the access control policy on an Organization resource. Replaces any existing policy. The `resource`
        /// field should be the organization's resource name, e.g. "organizations/123". Authorization requires the
        /// Google IAM permission `resourcemanager.organizations.setIamPolicy` on the specified organization
        /// </summary>
        public class SetIamPolicyRequest : CloudResourceManagerBaseServiceRequest<Google.Apis.CloudResourceManager.v1.Data.Policy>
        {
            /// <summary>Constructs a new SetIamPolicy request.</summary>
            public SetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudResourceManager.v1.Data.SetIamPolicyRequest body, string resource) : base(service)
            {
                Resource = resource;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// REQUIRED: The resource for which the policy is being specified. See the operation documentation for the
            /// appropriate value for this field.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Resource { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.CloudResourceManager.v1.Data.SetIamPolicyRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "setIamPolicy";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/{+resource}:setIamPolicy";

            /// <summary>Initializes SetIamPolicy parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("resource", new Google.Apis.Discovery.Parameter
                {
                    Name = "resource",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^organizations/[^/]+$",
                });
            }
        }

        /// <summary>
        /// Updates the specified `Policy` on the resource. Creates a new `Policy` for that `Constraint` on the resource
        /// if one does not exist. Not supplying an `etag` on the request `Policy` results in an unconditional write of
        /// the `Policy`.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="resource">Resource name of the resource to attach the `Policy`.</param>
        public virtual SetOrgPolicyRequest SetOrgPolicy(Google.Apis.CloudResourceManager.v1.Data.SetOrgPolicyRequest body, string resource)
        {
            return new SetOrgPolicyRequest(service, body, resource);
        }

        /// <summary>
        /// Updates the specified `Policy` on the resource. Creates a new `Policy` for that `Constraint` on the resource
        /// if one does not exist. Not supplying an `etag` on the request `Policy` results in an unconditional write of
        /// the `Policy`.
        /// </summary>
        public class SetOrgPolicyRequest : CloudResourceManagerBaseServiceRequest<Google.Apis.CloudResourceManager.v1.Data.OrgPolicy>
        {
            /// <summary>Constructs a new SetOrgPolicy request.</summary>
            public SetOrgPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudResourceManager.v1.Data.SetOrgPolicyRequest body, string resource) : base(service)
            {
                Resource = resource;
                Body = body;
                InitParameters();
            }

            /// <summary>Resource name of the resource to attach the `Policy`.</summary>
            [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Resource { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.CloudResourceManager.v1.Data.SetOrgPolicyRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "setOrgPolicy";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/{+resource}:setOrgPolicy";

            /// <summary>Initializes SetOrgPolicy parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("resource", new Google.Apis.Discovery.Parameter
                {
                    Name = "resource",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^organizations/[^/]+$",
                });
            }
        }

        /// <summary>
        /// Returns permissions that a caller has on the specified Organization. The `resource` field should be the
        /// organization's resource name, e.g. "organizations/123". There are no permissions required for making this
        /// API call.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy detail is being requested. See the operation documentation for
        /// the appropriate value for this field.
        /// </param>
        public virtual TestIamPermissionsRequest TestIamPermissions(Google.Apis.CloudResourceManager.v1.Data.TestIamPermissionsRequest body, string resource)
        {
            return new TestIamPermissionsRequest(service, body, resource);
        }

        /// <summary>
        /// Returns permissions that a caller has on the specified Organization. The `resource` field should be the
        /// organization's resource name, e.g. "organizations/123". There are no permissions required for making this
        /// API call.
        /// </summary>
        public class TestIamPermissionsRequest : CloudResourceManagerBaseServiceRequest<Google.Apis.CloudResourceManager.v1.Data.TestIamPermissionsResponse>
        {
            /// <summary>Constructs a new TestIamPermissions request.</summary>
            public TestIamPermissionsRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudResourceManager.v1.Data.TestIamPermissionsRequest body, string resource) : base(service)
            {
                Resource = resource;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// REQUIRED: The resource for which the policy detail is being requested. See the operation documentation
            /// for the appropriate value for this field.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Resource { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.CloudResourceManager.v1.Data.TestIamPermissionsRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "testIamPermissions";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/{+resource}:testIamPermissions";

            /// <summary>Initializes TestIamPermissions parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("resource", new Google.Apis.Discovery.Parameter
                {
                    Name = "resource",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^organizations/[^/]+$",
                });
            }
        }
    }

    /// <summary>The "projects" collection of methods.</summary>
    public class ProjectsResource
    {
        private const string Resource = "projects";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public ProjectsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Clears a `Policy` from a resource.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="resource">Name of the resource for the `Policy` to clear.</param>
        public virtual ClearOrgPolicyRequest ClearOrgPolicy(Google.Apis.CloudResourceManager.v1.Data.ClearOrgPolicyRequest body, string resource)
        {
            return new ClearOrgPolicyRequest(service, body, resource);
        }

        /// <summary>Clears a `Policy` from a resource.</summary>
        public class ClearOrgPolicyRequest : CloudResourceManagerBaseServiceRequest<Google.Apis.CloudResourceManager.v1.Data.Empty>
        {
            /// <summary>Constructs a new ClearOrgPolicy request.</summary>
            public ClearOrgPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudResourceManager.v1.Data.ClearOrgPolicyRequest body, string resource) : base(service)
            {
                Resource = resource;
                Body = body;
                InitParameters();
            }

            /// <summary>Name of the resource for the `Policy` to clear.</summary>
            [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Resource { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.CloudResourceManager.v1.Data.ClearOrgPolicyRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "clearOrgPolicy";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/{+resource}:clearOrgPolicy";

            /// <summary>Initializes ClearOrgPolicy parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("resource", new Google.Apis.Discovery.Parameter
                {
                    Name = "resource",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^projects/[^/]+$",
                });
            }
        }

        /// <summary>
        /// Request that a new Project be created. The result is an Operation which can be used to track the creation
        /// process. This process usually takes a few seconds, but can sometimes take much longer. The tracking
        /// Operation is automatically deleted after a few hours, so there is no need to call DeleteOperation.
        /// Authorization requires the Google IAM permission `resourcemanager.projects.create` on the specified parent
        /// for the new project. The parent is identified by a specified ResourceId, which must include both an ID and a
        /// type, such as organization. This method does not associate the new project with a billing account. You can
        /// set or update the billing account associated with a project using the [`projects.updateBillingInfo`]
        /// (/billing/reference/rest/v1/projects/updateBillingInfo) method.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        public virtual CreateRequest Create(Google.Apis.CloudResourceManager.v1.Data.Project body)
        {
            return new CreateRequest(service, body);
        }

        /// <summary>
        /// Request that a new Project be created. The result is an Operation which can be used to track the creation
        /// process. This process usually takes a few seconds, but can sometimes take much longer. The tracking
        /// Operation is automatically deleted after a few hours, so there is no need to call DeleteOperation.
        /// Authorization requires the Google IAM permission `resourcemanager.projects.create` on the specified parent
        /// for the new project. The parent is identified by a specified ResourceId, which must include both an ID and a
        /// type, such as organization. This method does not associate the new project with a billing account. You can
        /// set or update the billing account associated with a project using the [`projects.updateBillingInfo`]
        /// (/billing/reference/rest/v1/projects/updateBillingInfo) method.
        /// </summary>
        public class CreateRequest : CloudResourceManagerBaseServiceRequest<Google.Apis.CloudResourceManager.v1.Data.Operation>
        {
            /// <summary>Constructs a new Create request.</summary>
            public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudResourceManager.v1.Data.Project body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.CloudResourceManager.v1.Data.Project Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "create";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/projects";

            /// <summary>Initializes Create parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
            }
        }

        /// <summary>
        /// Marks the Project identified by the specified `project_id` (for example, `my-project-123`) for deletion.
        /// This method will only affect the Project if it has a lifecycle state of ACTIVE. This method changes the
        /// Project's lifecycle state from ACTIVE to DELETE_REQUESTED. The deletion starts at an unspecified time, at
        /// which point the Project is no longer accessible. Until the deletion completes, you can check the lifecycle
        /// state checked by retrieving the Project with GetProject, and the Project remains visible to ListProjects.
        /// However, you cannot update the project. After the deletion completes, the Project is not retrievable by the
        /// GetProject and ListProjects methods. The caller must have delete permissions for this Project.
        /// </summary>
        /// <param name="projectId">The Project ID (for example, `foo-bar-123`). Required.</param>
        public virtual DeleteRequest Delete(string projectId)
        {
            return new DeleteRequest(service, projectId);
        }

        /// <summary>
        /// Marks the Project identified by the specified `project_id` (for example, `my-project-123`) for deletion.
        /// This method will only affect the Project if it has a lifecycle state of ACTIVE. This method changes the
        /// Project's lifecycle state from ACTIVE to DELETE_REQUESTED. The deletion starts at an unspecified time, at
        /// which point the Project is no longer accessible. Until the deletion completes, you can check the lifecycle
        /// state checked by retrieving the Project with GetProject, and the Project remains visible to ListProjects.
        /// However, you cannot update the project. After the deletion completes, the Project is not retrievable by the
        /// GetProject and ListProjects methods. The caller must have delete permissions for this Project.
        /// </summary>
        public class DeleteRequest : CloudResourceManagerBaseServiceRequest<Google.Apis.CloudResourceManager.v1.Data.Empty>
        {
            /// <summary>Constructs a new Delete request.</summary>
            public DeleteRequest(Google.Apis.Services.IClientService service, string projectId) : base(service)
            {
                ProjectId = projectId;
                InitParameters();
            }

            /// <summary>The Project ID (for example, `foo-bar-123`). Required.</summary>
            [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ProjectId { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "delete";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "DELETE";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/projects/{projectId}";

            /// <summary>Initializes Delete parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("projectId", new Google.Apis.Discovery.Parameter
                {
                    Name = "projectId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Retrieves the Project identified by the specified `project_id` (for example, `my-project-123`). The caller
        /// must have read permissions for this Project.
        /// </summary>
        /// <param name="projectId">Required. The Project ID (for example, `my-project-123`).</param>
        public virtual GetRequest Get(string projectId)
        {
            return new GetRequest(service, projectId);
        }

        /// <summary>
        /// Retrieves the Project identified by the specified `project_id` (for example, `my-project-123`). The caller
        /// must have read permissions for this Project.
        /// </summary>
        public class GetRequest : CloudResourceManagerBaseServiceRequest<Google.Apis.CloudResourceManager.v1.Data.Project>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string projectId) : base(service)
            {
                ProjectId = projectId;
                InitParameters();
            }

            /// <summary>Required. The Project ID (for example, `my-project-123`).</summary>
            [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ProjectId { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/projects/{projectId}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("projectId", new Google.Apis.Discovery.Parameter
                {
                    Name = "projectId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Gets a list of ancestors in the resource hierarchy for the Project identified by the specified `project_id`
        /// (for example, `my-project-123`). The caller must have read permissions for this Project.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="projectId">Required. The Project ID (for example, `my-project-123`).</param>
        public virtual GetAncestryRequest GetAncestry(Google.Apis.CloudResourceManager.v1.Data.GetAncestryRequest body, string projectId)
        {
            return new GetAncestryRequest(service, body, projectId);
        }

        /// <summary>
        /// Gets a list of ancestors in the resource hierarchy for the Project identified by the specified `project_id`
        /// (for example, `my-project-123`). The caller must have read permissions for this Project.
        /// </summary>
        public class GetAncestryRequest : CloudResourceManagerBaseServiceRequest<Google.Apis.CloudResourceManager.v1.Data.GetAncestryResponse>
        {
            /// <summary>Constructs a new GetAncestry request.</summary>
            public GetAncestryRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudResourceManager.v1.Data.GetAncestryRequest body, string projectId) : base(service)
            {
                ProjectId = projectId;
                Body = body;
                InitParameters();
            }

            /// <summary>Required. The Project ID (for example, `my-project-123`).</summary>
            [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ProjectId { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.CloudResourceManager.v1.Data.GetAncestryRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "getAncestry";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/projects/{projectId}:getAncestry";

            /// <summary>Initializes GetAncestry parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("projectId", new Google.Apis.Discovery.Parameter
                {
                    Name = "projectId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Gets the effective `Policy` on a resource. This is the result of merging `Policies` in the resource
        /// hierarchy. The returned `Policy` will not have an `etag`set because it is a computed `Policy` across
        /// multiple resources. Subtrees of Resource Manager resource hierarchy with 'under:' prefix will not be
        /// expanded.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="resource">The name of the resource to start computing the effective `Policy`.</param>
        public virtual GetEffectiveOrgPolicyRequest GetEffectiveOrgPolicy(Google.Apis.CloudResourceManager.v1.Data.GetEffectiveOrgPolicyRequest body, string resource)
        {
            return new GetEffectiveOrgPolicyRequest(service, body, resource);
        }

        /// <summary>
        /// Gets the effective `Policy` on a resource. This is the result of merging `Policies` in the resource
        /// hierarchy. The returned `Policy` will not have an `etag`set because it is a computed `Policy` across
        /// multiple resources. Subtrees of Resource Manager resource hierarchy with 'under:' prefix will not be
        /// expanded.
        /// </summary>
        public class GetEffectiveOrgPolicyRequest : CloudResourceManagerBaseServiceRequest<Google.Apis.CloudResourceManager.v1.Data.OrgPolicy>
        {
            /// <summary>Constructs a new GetEffectiveOrgPolicy request.</summary>
            public GetEffectiveOrgPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudResourceManager.v1.Data.GetEffectiveOrgPolicyRequest body, string resource) : base(service)
            {
                Resource = resource;
                Body = body;
                InitParameters();
            }

            /// <summary>The name of the resource to start computing the effective `Policy`.</summary>
            [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Resource { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.CloudResourceManager.v1.Data.GetEffectiveOrgPolicyRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "getEffectiveOrgPolicy";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/{+resource}:getEffectiveOrgPolicy";

            /// <summary>Initializes GetEffectiveOrgPolicy parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("resource", new Google.Apis.Discovery.Parameter
                {
                    Name = "resource",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^projects/[^/]+$",
                });
            }
        }

        /// <summary>
        /// Returns the IAM access control policy for the specified Project. Permission is denied if the policy or the
        /// resource does not exist. Authorization requires the Google IAM permission
        /// `resourcemanager.projects.getIamPolicy` on the project. For additional information about `resource` (e.g.
        /// my-project-id) structure and identification, see [Resource
        /// Names](https://cloud.google.com/apis/design/resource_names).
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being requested. See the operation documentation for the
        /// appropriate value for this field.
        /// </param>
        public virtual GetIamPolicyRequest GetIamPolicy(Google.Apis.CloudResourceManager.v1.Data.GetIamPolicyRequest body, string resource)
        {
            return new GetIamPolicyRequest(service, body, resource);
        }

        /// <summary>
        /// Returns the IAM access control policy for the specified Project. Permission is denied if the policy or the
        /// resource does not exist. Authorization requires the Google IAM permission
        /// `resourcemanager.projects.getIamPolicy` on the project. For additional information about `resource` (e.g.
        /// my-project-id) structure and identification, see [Resource
        /// Names](https://cloud.google.com/apis/design/resource_names).
        /// </summary>
        public class GetIamPolicyRequest : CloudResourceManagerBaseServiceRequest<Google.Apis.CloudResourceManager.v1.Data.Policy>
        {
            /// <summary>Constructs a new GetIamPolicy request.</summary>
            public GetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudResourceManager.v1.Data.GetIamPolicyRequest body, string resource) : base(service)
            {
                Resource = resource;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// REQUIRED: The resource for which the policy is being requested. See the operation documentation for the
            /// appropriate value for this field.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Resource { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.CloudResourceManager.v1.Data.GetIamPolicyRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "getIamPolicy";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/projects/{resource}:getIamPolicy";

            /// <summary>Initializes GetIamPolicy parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("resource", new Google.Apis.Discovery.Parameter
                {
                    Name = "resource",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Gets a `Policy` on a resource. If no `Policy` is set on the resource, a `Policy` is returned with default
        /// values including `POLICY_TYPE_NOT_SET` for the `policy_type oneof`. The `etag` value can be used with
        /// `SetOrgPolicy()` to create or update a `Policy` during read-modify-write.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="resource">Name of the resource the `Policy` is set on.</param>
        public virtual GetOrgPolicyRequest GetOrgPolicy(Google.Apis.CloudResourceManager.v1.Data.GetOrgPolicyRequest body, string resource)
        {
            return new GetOrgPolicyRequest(service, body, resource);
        }

        /// <summary>
        /// Gets a `Policy` on a resource. If no `Policy` is set on the resource, a `Policy` is returned with default
        /// values including `POLICY_TYPE_NOT_SET` for the `policy_type oneof`. The `etag` value can be used with
        /// `SetOrgPolicy()` to create or update a `Policy` during read-modify-write.
        /// </summary>
        public class GetOrgPolicyRequest : CloudResourceManagerBaseServiceRequest<Google.Apis.CloudResourceManager.v1.Data.OrgPolicy>
        {
            /// <summary>Constructs a new GetOrgPolicy request.</summary>
            public GetOrgPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudResourceManager.v1.Data.GetOrgPolicyRequest body, string resource) : base(service)
            {
                Resource = resource;
                Body = body;
                InitParameters();
            }

            /// <summary>Name of the resource the `Policy` is set on.</summary>
            [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Resource { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.CloudResourceManager.v1.Data.GetOrgPolicyRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "getOrgPolicy";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/{+resource}:getOrgPolicy";

            /// <summary>Initializes GetOrgPolicy parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("resource", new Google.Apis.Discovery.Parameter
                {
                    Name = "resource",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^projects/[^/]+$",
                });
            }
        }

        /// <summary>
        /// Lists Projects that the caller has the `resourcemanager.projects.get` permission on and satisfy the
        /// specified filter. This method returns Projects in an unspecified order. This method is eventually consistent
        /// with project mutations; this means that a newly created project may not appear in the results or recent
        /// updates to an existing project may not be reflected in the results. To retrieve the latest state of a
        /// project, use the GetProject method. NOTE: If the request filter contains a `parent.type` and `parent.id` and
        /// the caller has the `resourcemanager.projects.list` permission on the parent, the results will be drawn from
        /// an alternate index which provides more consistent results. In future versions of this API, this List method
        /// will be split into List and Search to properly capture the behavioral difference.
        /// </summary>
        public virtual ListRequest List()
        {
            return new ListRequest(service);
        }

        /// <summary>
        /// Lists Projects that the caller has the `resourcemanager.projects.get` permission on and satisfy the
        /// specified filter. This method returns Projects in an unspecified order. This method is eventually consistent
        /// with project mutations; this means that a newly created project may not appear in the results or recent
        /// updates to an existing project may not be reflected in the results. To retrieve the latest state of a
        /// project, use the GetProject method. NOTE: If the request filter contains a `parent.type` and `parent.id` and
        /// the caller has the `resourcemanager.projects.list` permission on the parent, the results will be drawn from
        /// an alternate index which provides more consistent results. In future versions of this API, this List method
        /// will be split into List and Search to properly capture the behavioral difference.
        /// </summary>
        public class ListRequest : CloudResourceManagerBaseServiceRequest<Google.Apis.CloudResourceManager.v1.Data.ListProjectsResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>
            /// Optional. An expression for filtering the results of the request. Filter rules are case insensitive. If
            /// multiple fields are included in a filter query, the query will return results that match any of the
            /// fields. Some eligible fields for filtering are: + `name` + `id` + `labels.` (where *key* is the name of
            /// a label) + `parent.type` + `parent.id` + `lifecycleState` Some examples of filter strings: | Filter |
            /// Description | |------------------|-----------------------------------------------------| | name:how* |
            /// The project's name starts with "how". | | name:Howl | The project's name is `Howl` or `howl`. | |
            /// name:HOWL | Equivalent to above. | | NAME:howl | Equivalent to above. | | labels.color:* | The project
            /// has the label `color`. | | labels.color:red | The project's label `color` has the value `red`. | |
            /// labels.color:red labels.size:big | The project's label `color` | : : has the value `red` and its : : :
            /// label`size` has the value : : : `big`. : | lifecycleState:DELETE_REQUESTED | Only show projects that are
            /// | : : pending deletion. : If no filter is specified, the call will return projects for which the user
            /// has the `resourcemanager.projects.get` permission. NOTE: To perform a by-parent query (eg., what
            /// projects are directly in a Folder), the caller must have the `resourcemanager.projects.list` permission
            /// on the parent and the filter must contain both a `parent.type` and a `parent.id` restriction (example:
            /// "parent.type:folder parent.id:123"). In this case an alternate search index is used which provides more
            /// consistent results.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Filter { get; set; }

            /// <summary>
            /// Optional. The maximum number of Projects to return in the response. The server can return fewer Projects
            /// than requested. If unspecified, server picks an appropriate default.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> PageSize { get; set; }

            /// <summary>
            /// Optional. A pagination token returned from a previous call to ListProjects that indicates from where
            /// listing should continue.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/projects";

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

        /// <summary>Lists `Constraints` that could be applied on the specified resource.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="resource">Name of the resource to list `Constraints` for.</param>
        public virtual ListAvailableOrgPolicyConstraintsRequest ListAvailableOrgPolicyConstraints(Google.Apis.CloudResourceManager.v1.Data.ListAvailableOrgPolicyConstraintsRequest body, string resource)
        {
            return new ListAvailableOrgPolicyConstraintsRequest(service, body, resource);
        }

        /// <summary>Lists `Constraints` that could be applied on the specified resource.</summary>
        public class ListAvailableOrgPolicyConstraintsRequest : CloudResourceManagerBaseServiceRequest<Google.Apis.CloudResourceManager.v1.Data.ListAvailableOrgPolicyConstraintsResponse>
        {
            /// <summary>Constructs a new ListAvailableOrgPolicyConstraints request.</summary>
            public ListAvailableOrgPolicyConstraintsRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudResourceManager.v1.Data.ListAvailableOrgPolicyConstraintsRequest body, string resource) : base(service)
            {
                Resource = resource;
                Body = body;
                InitParameters();
            }

            /// <summary>Name of the resource to list `Constraints` for.</summary>
            [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Resource { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.CloudResourceManager.v1.Data.ListAvailableOrgPolicyConstraintsRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "listAvailableOrgPolicyConstraints";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/{+resource}:listAvailableOrgPolicyConstraints";

            /// <summary>Initializes ListAvailableOrgPolicyConstraints parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("resource", new Google.Apis.Discovery.Parameter
                {
                    Name = "resource",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^projects/[^/]+$",
                });
            }
        }

        /// <summary>Lists all the `Policies` set for a particular resource.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="resource">Name of the resource to list Policies for.</param>
        public virtual ListOrgPoliciesRequest ListOrgPolicies(Google.Apis.CloudResourceManager.v1.Data.ListOrgPoliciesRequest body, string resource)
        {
            return new ListOrgPoliciesRequest(service, body, resource);
        }

        /// <summary>Lists all the `Policies` set for a particular resource.</summary>
        public class ListOrgPoliciesRequest : CloudResourceManagerBaseServiceRequest<Google.Apis.CloudResourceManager.v1.Data.ListOrgPoliciesResponse>
        {
            /// <summary>Constructs a new ListOrgPolicies request.</summary>
            public ListOrgPoliciesRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudResourceManager.v1.Data.ListOrgPoliciesRequest body, string resource) : base(service)
            {
                Resource = resource;
                Body = body;
                InitParameters();
            }

            /// <summary>Name of the resource to list Policies for.</summary>
            [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Resource { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.CloudResourceManager.v1.Data.ListOrgPoliciesRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "listOrgPolicies";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/{+resource}:listOrgPolicies";

            /// <summary>Initializes ListOrgPolicies parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("resource", new Google.Apis.Discovery.Parameter
                {
                    Name = "resource",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^projects/[^/]+$",
                });
            }
        }

        /// <summary>
        /// Sets the IAM access control policy for the specified Project. CAUTION: This method will replace the existing
        /// policy, and cannot be used to append additional IAM settings. NOTE: Removing service accounts from policies
        /// or changing their roles can render services completely inoperable. It is important to understand how the
        /// service account is being used before removing or updating its roles. For additional information about
        /// `resource` (e.g. my-project-id) structure and identification, see [Resource
        /// Names](https://cloud.google.com/apis/design/resource_names). The following constraints apply when using
        /// `setIamPolicy()`: + Project does not support `allUsers` and `allAuthenticatedUsers` as `members` in a
        /// `Binding` of a `Policy`. + The owner role can be granted to a `user`, `serviceAccount`, or a group that is
        /// part of an organization. For example, group@myownpersonaldomain.com could be added as an owner to a project
        /// in the myownpersonaldomain.com organization, but not the examplepetstore.com organization. + Service
        /// accounts can be made owners of a project directly without any restrictions. However, to be added as an
        /// owner, a user must be invited via Cloud Platform console and must accept the invitation. + A user cannot be
        /// granted the owner role using `setIamPolicy()`. The user must be granted the owner role using the Cloud
        /// Platform Console and must explicitly accept the invitation. + You can only grant ownership of a project to a
        /// member by using the GCP Console. Inviting a member will deliver an invitation email that they must accept.
        /// An invitation email is not generated if you are granting a role other than owner, or if both the member you
        /// are inviting and the project are part of your organization. + Membership changes that leave the project
        /// without any owners that have accepted the Terms of Service (ToS) will be rejected. + If the project is not
        /// part of an organization, there must be at least one owner who has accepted the Terms of Service (ToS)
        /// agreement in the policy. Calling `setIamPolicy()` to remove the last ToS-accepted owner from the policy will
        /// fail. This restriction also applies to legacy projects that no longer have owners who have accepted the ToS.
        /// Edits to IAM policies will be rejected until the lack of a ToS-accepting owner is rectified. Authorization
        /// requires the Google IAM permission `resourcemanager.projects.setIamPolicy` on the project
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being specified. See the operation documentation for the
        /// appropriate value for this field.
        /// </param>
        public virtual SetIamPolicyRequest SetIamPolicy(Google.Apis.CloudResourceManager.v1.Data.SetIamPolicyRequest body, string resource)
        {
            return new SetIamPolicyRequest(service, body, resource);
        }

        /// <summary>
        /// Sets the IAM access control policy for the specified Project. CAUTION: This method will replace the existing
        /// policy, and cannot be used to append additional IAM settings. NOTE: Removing service accounts from policies
        /// or changing their roles can render services completely inoperable. It is important to understand how the
        /// service account is being used before removing or updating its roles. For additional information about
        /// `resource` (e.g. my-project-id) structure and identification, see [Resource
        /// Names](https://cloud.google.com/apis/design/resource_names). The following constraints apply when using
        /// `setIamPolicy()`: + Project does not support `allUsers` and `allAuthenticatedUsers` as `members` in a
        /// `Binding` of a `Policy`. + The owner role can be granted to a `user`, `serviceAccount`, or a group that is
        /// part of an organization. For example, group@myownpersonaldomain.com could be added as an owner to a project
        /// in the myownpersonaldomain.com organization, but not the examplepetstore.com organization. + Service
        /// accounts can be made owners of a project directly without any restrictions. However, to be added as an
        /// owner, a user must be invited via Cloud Platform console and must accept the invitation. + A user cannot be
        /// granted the owner role using `setIamPolicy()`. The user must be granted the owner role using the Cloud
        /// Platform Console and must explicitly accept the invitation. + You can only grant ownership of a project to a
        /// member by using the GCP Console. Inviting a member will deliver an invitation email that they must accept.
        /// An invitation email is not generated if you are granting a role other than owner, or if both the member you
        /// are inviting and the project are part of your organization. + Membership changes that leave the project
        /// without any owners that have accepted the Terms of Service (ToS) will be rejected. + If the project is not
        /// part of an organization, there must be at least one owner who has accepted the Terms of Service (ToS)
        /// agreement in the policy. Calling `setIamPolicy()` to remove the last ToS-accepted owner from the policy will
        /// fail. This restriction also applies to legacy projects that no longer have owners who have accepted the ToS.
        /// Edits to IAM policies will be rejected until the lack of a ToS-accepting owner is rectified. Authorization
        /// requires the Google IAM permission `resourcemanager.projects.setIamPolicy` on the project
        /// </summary>
        public class SetIamPolicyRequest : CloudResourceManagerBaseServiceRequest<Google.Apis.CloudResourceManager.v1.Data.Policy>
        {
            /// <summary>Constructs a new SetIamPolicy request.</summary>
            public SetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudResourceManager.v1.Data.SetIamPolicyRequest body, string resource) : base(service)
            {
                Resource = resource;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// REQUIRED: The resource for which the policy is being specified. See the operation documentation for the
            /// appropriate value for this field.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Resource { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.CloudResourceManager.v1.Data.SetIamPolicyRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "setIamPolicy";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/projects/{resource}:setIamPolicy";

            /// <summary>Initializes SetIamPolicy parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("resource", new Google.Apis.Discovery.Parameter
                {
                    Name = "resource",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Updates the specified `Policy` on the resource. Creates a new `Policy` for that `Constraint` on the resource
        /// if one does not exist. Not supplying an `etag` on the request `Policy` results in an unconditional write of
        /// the `Policy`.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="resource">Resource name of the resource to attach the `Policy`.</param>
        public virtual SetOrgPolicyRequest SetOrgPolicy(Google.Apis.CloudResourceManager.v1.Data.SetOrgPolicyRequest body, string resource)
        {
            return new SetOrgPolicyRequest(service, body, resource);
        }

        /// <summary>
        /// Updates the specified `Policy` on the resource. Creates a new `Policy` for that `Constraint` on the resource
        /// if one does not exist. Not supplying an `etag` on the request `Policy` results in an unconditional write of
        /// the `Policy`.
        /// </summary>
        public class SetOrgPolicyRequest : CloudResourceManagerBaseServiceRequest<Google.Apis.CloudResourceManager.v1.Data.OrgPolicy>
        {
            /// <summary>Constructs a new SetOrgPolicy request.</summary>
            public SetOrgPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudResourceManager.v1.Data.SetOrgPolicyRequest body, string resource) : base(service)
            {
                Resource = resource;
                Body = body;
                InitParameters();
            }

            /// <summary>Resource name of the resource to attach the `Policy`.</summary>
            [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Resource { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.CloudResourceManager.v1.Data.SetOrgPolicyRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "setOrgPolicy";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/{+resource}:setOrgPolicy";

            /// <summary>Initializes SetOrgPolicy parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("resource", new Google.Apis.Discovery.Parameter
                {
                    Name = "resource",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^projects/[^/]+$",
                });
            }
        }

        /// <summary>
        /// Returns permissions that a caller has on the specified Project. For additional information about `resource`
        /// (e.g. my-project-id) structure and identification, see [Resource
        /// Names](https://cloud.google.com/apis/design/resource_names). There are no permissions required for making
        /// this API call.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy detail is being requested. See the operation documentation for
        /// the appropriate value for this field.
        /// </param>
        public virtual TestIamPermissionsRequest TestIamPermissions(Google.Apis.CloudResourceManager.v1.Data.TestIamPermissionsRequest body, string resource)
        {
            return new TestIamPermissionsRequest(service, body, resource);
        }

        /// <summary>
        /// Returns permissions that a caller has on the specified Project. For additional information about `resource`
        /// (e.g. my-project-id) structure and identification, see [Resource
        /// Names](https://cloud.google.com/apis/design/resource_names). There are no permissions required for making
        /// this API call.
        /// </summary>
        public class TestIamPermissionsRequest : CloudResourceManagerBaseServiceRequest<Google.Apis.CloudResourceManager.v1.Data.TestIamPermissionsResponse>
        {
            /// <summary>Constructs a new TestIamPermissions request.</summary>
            public TestIamPermissionsRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudResourceManager.v1.Data.TestIamPermissionsRequest body, string resource) : base(service)
            {
                Resource = resource;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// REQUIRED: The resource for which the policy detail is being requested. See the operation documentation
            /// for the appropriate value for this field.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Resource { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.CloudResourceManager.v1.Data.TestIamPermissionsRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "testIamPermissions";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/projects/{resource}:testIamPermissions";

            /// <summary>Initializes TestIamPermissions parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("resource", new Google.Apis.Discovery.Parameter
                {
                    Name = "resource",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Restores the Project identified by the specified `project_id` (for example, `my-project-123`). You can only
        /// use this method for a Project that has a lifecycle state of DELETE_REQUESTED. After deletion starts, the
        /// Project cannot be restored. The caller must have undelete permissions for this Project.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="projectId">Required. The project ID (for example, `foo-bar-123`).</param>
        public virtual UndeleteRequest Undelete(Google.Apis.CloudResourceManager.v1.Data.UndeleteProjectRequest body, string projectId)
        {
            return new UndeleteRequest(service, body, projectId);
        }

        /// <summary>
        /// Restores the Project identified by the specified `project_id` (for example, `my-project-123`). You can only
        /// use this method for a Project that has a lifecycle state of DELETE_REQUESTED. After deletion starts, the
        /// Project cannot be restored. The caller must have undelete permissions for this Project.
        /// </summary>
        public class UndeleteRequest : CloudResourceManagerBaseServiceRequest<Google.Apis.CloudResourceManager.v1.Data.Empty>
        {
            /// <summary>Constructs a new Undelete request.</summary>
            public UndeleteRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudResourceManager.v1.Data.UndeleteProjectRequest body, string projectId) : base(service)
            {
                ProjectId = projectId;
                Body = body;
                InitParameters();
            }

            /// <summary>Required. The project ID (for example, `foo-bar-123`).</summary>
            [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ProjectId { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.CloudResourceManager.v1.Data.UndeleteProjectRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "undelete";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/projects/{projectId}:undelete";

            /// <summary>Initializes Undelete parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("projectId", new Google.Apis.Discovery.Parameter
                {
                    Name = "projectId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Updates the attributes of the Project identified by the specified `project_id` (for example,
        /// `my-project-123`). The caller must have modify permissions for this Project.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="projectId">The project ID (for example, `my-project-123`). Required.</param>
        public virtual UpdateRequest Update(Google.Apis.CloudResourceManager.v1.Data.Project body, string projectId)
        {
            return new UpdateRequest(service, body, projectId);
        }

        /// <summary>
        /// Updates the attributes of the Project identified by the specified `project_id` (for example,
        /// `my-project-123`). The caller must have modify permissions for this Project.
        /// </summary>
        public class UpdateRequest : CloudResourceManagerBaseServiceRequest<Google.Apis.CloudResourceManager.v1.Data.Project>
        {
            /// <summary>Constructs a new Update request.</summary>
            public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudResourceManager.v1.Data.Project body, string projectId) : base(service)
            {
                ProjectId = projectId;
                Body = body;
                InitParameters();
            }

            /// <summary>The project ID (for example, `my-project-123`). Required.</summary>
            [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ProjectId { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.CloudResourceManager.v1.Data.Project Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "update";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PUT";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/projects/{projectId}";

            /// <summary>Initializes Update parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("projectId", new Google.Apis.Discovery.Parameter
                {
                    Name = "projectId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }
}
namespace Google.Apis.CloudResourceManager.v1.Data
{
    /// <summary>Identifying information for a single ancestor of a project.</summary>
    public class Ancestor : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Resource id of the ancestor.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceId")]
        public virtual ResourceId ResourceId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Specifies the audit configuration for a service. The configuration determines which permission types are logged,
    /// and what identities, if any, are exempted from logging. An AuditConfig must have one or more AuditLogConfigs. If
    /// there are AuditConfigs for both `allServices` and a specific service, the union of the two AuditConfigs is used
    /// for that service: the log_types specified in each AuditConfig are enabled, and the exempted_members in each
    /// AuditLogConfig are exempted. Example Policy with multiple AuditConfigs: { "audit_configs": [ { "service":
    /// "allServices", "audit_log_configs": [ { "log_type": "DATA_READ", "exempted_members": [ "user:jose@example.com" ]
    /// }, { "log_type": "DATA_WRITE" }, { "log_type": "ADMIN_READ" } ] }, { "service": "sampleservice.googleapis.com",
    /// "audit_log_configs": [ { "log_type": "DATA_READ" }, { "log_type": "DATA_WRITE", "exempted_members": [
    /// "user:aliya@example.com" ] } ] } ] } For sampleservice, this policy enables DATA_READ, DATA_WRITE and ADMIN_READ
    /// logging. It also exempts jose@example.com from DATA_READ logging, and aliya@example.com from DATA_WRITE logging.
    /// </summary>
    public class AuditConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The configuration for logging of each type of permission.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("auditLogConfigs")]
        public virtual System.Collections.Generic.IList<AuditLogConfig> AuditLogConfigs { get; set; }

        /// <summary>
        /// Specifies a service that will be enabled for audit logging. For example, `storage.googleapis.com`,
        /// `cloudsql.googleapis.com`. `allServices` is a special value that covers all services.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("service")]
        public virtual string Service { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Provides the configuration for logging a type of permissions. Example: { "audit_log_configs": [ { "log_type":
    /// "DATA_READ", "exempted_members": [ "user:jose@example.com" ] }, { "log_type": "DATA_WRITE" } ] } This enables
    /// 'DATA_READ' and 'DATA_WRITE' logging, while exempting jose@example.com from DATA_READ logging.
    /// </summary>
    public class AuditLogConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Specifies the identities that do not cause logging for this type of permission. Follows the same format of
        /// Binding.members.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exemptedMembers")]
        public virtual System.Collections.Generic.IList<string> ExemptedMembers { get; set; }

        /// <summary>The log type that this config enables.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("logType")]
        public virtual string LogType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Associates `members` with a `role`.</summary>
    public class Binding : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The condition that is associated with this binding. If the condition evaluates to `true`, then this binding
        /// applies to the current request. If the condition evaluates to `false`, then this binding does not apply to
        /// the current request. However, a different role binding might grant the same role to one or more of the
        /// members in this binding. To learn which resources support conditions in their IAM policies, see the [IAM
        /// documentation](https://cloud.google.com/iam/help/conditions/resource-policies).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("condition")]
        public virtual Expr Condition { get; set; }

        /// <summary>
        /// Specifies the identities requesting access for a Cloud Platform resource. `members` can have the following
        /// values: * `allUsers`: A special identifier that represents anyone who is on the internet; with or without a
        /// Google account. * `allAuthenticatedUsers`: A special identifier that represents anyone who is authenticated
        /// with a Google account or a service account. * `user:{emailid}`: An email address that represents a specific
        /// Google account. For example, `alice@example.com` . * `serviceAccount:{emailid}`: An email address that
        /// represents a service account. For example, `my-other-app@appspot.gserviceaccount.com`. * `group:{emailid}`:
        /// An email address that represents a Google group. For example, `admins@example.com`. *
        /// `deleted:user:{emailid}?uid={uniqueid}`: An email address (plus unique identifier) representing a user that
        /// has been recently deleted. For example, `alice@example.com?uid=123456789012345678901`. If the user is
        /// recovered, this value reverts to `user:{emailid}` and the recovered user retains the role in the binding. *
        /// `deleted:serviceAccount:{emailid}?uid={uniqueid}`: An email address (plus unique identifier) representing a
        /// service account that has been recently deleted. For example,
        /// `my-other-app@appspot.gserviceaccount.com?uid=123456789012345678901`. If the service account is undeleted,
        /// this value reverts to `serviceAccount:{emailid}` and the undeleted service account retains the role in the
        /// binding. * `deleted:group:{emailid}?uid={uniqueid}`: An email address (plus unique identifier) representing
        /// a Google group that has been recently deleted. For example, `admins@example.com?uid=123456789012345678901`.
        /// If the group is recovered, this value reverts to `group:{emailid}` and the recovered group retains the role
        /// in the binding. * `domain:{domain}`: The G Suite domain (primary) that represents all the users of that
        /// domain. For example, `google.com` or `example.com`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("members")]
        public virtual System.Collections.Generic.IList<string> Members { get; set; }

        /// <summary>
        /// Role that is assigned to `members`. For example, `roles/viewer`, `roles/editor`, or `roles/owner`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("role")]
        public virtual string Role { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A `Constraint` that is either enforced or not. For example a constraint
    /// `constraints/compute.disableSerialPortAccess`. If it is enforced on a VM instance, serial port connections will
    /// not be opened to that instance.
    /// </summary>
    public class BooleanConstraint : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Used in `policy_type` to specify how `boolean_policy` will behave at this resource.</summary>
    public class BooleanPolicy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// If `true`, then the `Policy` is enforced. If `false`, then any configuration is acceptable. Suppose you have
        /// a `Constraint` `constraints/compute.disableSerialPortAccess` with `constraint_default` set to `ALLOW`. A
        /// `Policy` for that `Constraint` exhibits the following behavior: - If the `Policy` at this resource has
        /// enforced set to `false`, serial port connection attempts will be allowed. - If the `Policy` at this resource
        /// has enforced set to `true`, serial port connection attempts will be refused. - If the `Policy` at this
        /// resource is `RestoreDefault`, serial port connection attempts will be allowed. - If no `Policy` is set at
        /// this resource or anywhere higher in the resource hierarchy, serial port connection attempts will be allowed.
        /// - If no `Policy` is set at this resource, but one exists higher in the resource hierarchy, the behavior is
        /// as if the`Policy` were set at this resource. The following examples demonstrate the different possible
        /// layerings: Example 1 (nearest `Constraint` wins): `organizations/foo` has a `Policy` with: {enforced: false}
        /// `projects/bar` has no `Policy` set. The constraint at `projects/bar` and `organizations/foo` will not be
        /// enforced. Example 2 (enforcement gets replaced): `organizations/foo` has a `Policy` with: {enforced: false}
        /// `projects/bar` has a `Policy` with: {enforced: true} The constraint at `organizations/foo` is not enforced.
        /// The constraint at `projects/bar` is enforced. Example 3 (RestoreDefault): `organizations/foo` has a `Policy`
        /// with: {enforced: true} `projects/bar` has a `Policy` with: {RestoreDefault: {}} The constraint at
        /// `organizations/foo` is enforced. The constraint at `projects/bar` is not enforced, because
        /// `constraint_default` for the `Constraint` is `ALLOW`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enforced")]
        public virtual System.Nullable<bool> Enforced { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request sent to the ClearOrgPolicy method.</summary>
    public class ClearOrgPolicyRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Name of the `Constraint` of the `Policy` to clear.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("constraint")]
        public virtual string Constraint { get; set; }

        /// <summary>
        /// The current version, for concurrency control. Not sending an `etag` will cause the `Policy` to be cleared
        /// blindly.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata describing a long running folder operation</summary>
    public class CloudresourcemanagerGoogleCloudResourcemanagerV2alpha1FolderOperation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The resource name of the folder or organization we are either creating the folder under or moving the folder
        /// to.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("destinationParent")]
        public virtual string DestinationParent { get; set; }

        /// <summary>The display name of the folder.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>The type of this operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operationType")]
        public virtual string OperationType { get; set; }

        /// <summary>
        /// The resource name of the folder's parent. Only applicable when the operation_type is MOVE.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceParent")]
        public virtual string SourceParent { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata describing a long running folder operation</summary>
    public class CloudresourcemanagerGoogleCloudResourcemanagerV2beta1FolderOperation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The resource name of the folder or organization we are either creating the folder under or moving the folder
        /// to.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("destinationParent")]
        public virtual string DestinationParent { get; set; }

        /// <summary>The display name of the folder.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>The type of this operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operationType")]
        public virtual string OperationType { get; set; }

        /// <summary>
        /// The resource name of the folder's parent. Only applicable when the operation_type is MOVE.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceParent")]
        public virtual string SourceParent { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A `Constraint` describes a way in which a resource's configuration can be restricted. For example, it controls
    /// which cloud services can be activated across an organization, or whether a Compute Engine instance can have
    /// serial port connections established. `Constraints` can be configured by the organization's policy administrator
    /// to fit the needs of the organzation by setting Policies for `Constraints` at different locations in the
    /// organization's resource hierarchy. Policies are inherited down the resource hierarchy from higher levels, but
    /// can also be overridden. For details about the inheritance rules please read about
    /// [Policies](/resource-manager/reference/rest/v1/Policy). `Constraints` have a default behavior determined by the
    /// `constraint_default` field, which is the enforcement behavior that is used in the absence of a `Policy` being
    /// defined or inherited for the resource in question.
    /// </summary>
    public class Constraint : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Defines this constraint as being a BooleanConstraint.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("booleanConstraint")]
        public virtual BooleanConstraint BooleanConstraint { get; set; }

        /// <summary>The evaluation behavior of this constraint in the absence of 'Policy'.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("constraintDefault")]
        public virtual string ConstraintDefault { get; set; }

        /// <summary>
        /// Detailed description of what this `Constraint` controls as well as how and where it is enforced. Mutable.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>The human readable name. Mutable.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>Defines this constraint as being a ListConstraint.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("listConstraint")]
        public virtual ListConstraint ListConstraint { get; set; }

        /// <summary>
        /// Immutable value, required to globally be unique. For example, `constraints/serviceuser.services`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Version of the `Constraint`. Default version is 0;</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual System.Nullable<int> Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata pertaining to the Folder creation process.</summary>
    public class CreateFolderMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The display name of the folder.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>The resource name of the folder or organization we are creating the folder under.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parent")]
        public virtual string Parent { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A status object which is used as the `metadata` field for the Operation returned by CreateProject. It provides
    /// insight for when significant phases of Project creation have completed.
    /// </summary>
    public class CreateProjectMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Creation time of the project creation workflow.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>
        /// True if the project can be retrieved using `GetProject`. No other operations on the project are guaranteed
        /// to work until the project creation is complete.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gettable")]
        public virtual System.Nullable<bool> Gettable { get; set; }

        /// <summary>True if the project creation process is complete.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ready")]
        public virtual System.Nullable<bool> Ready { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Runtime operation information for creating a TagKey.</summary>
    public class CreateTagKeyMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Runtime operation information for creating a TagValue.</summary>
    public class CreateTagValueMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A status object which is used as the `metadata` field for the `Operation` returned by `DeleteFolder`.
    /// </summary>
    public class DeleteFolderMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A status object which is used as the `metadata` field for the operation returned by DeleteOrganization.
    /// </summary>
    public class DeleteOrganizationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A status object which is used as the `metadata` field for the Operation returned by `DeleteProject`.
    /// </summary>
    public class DeleteProjectMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Runtime operation information for deleting a TagKey.</summary>
    public class DeleteTagKeyMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Runtime operation information for deleting a TagValue.</summary>
    public class DeleteTagValueMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A generic empty message that you can re-use to avoid defining duplicated empty messages in your APIs. A typical
    /// example is to use it as the request or the response type of an API method. For instance: service Foo { rpc
    /// Bar(google.protobuf.Empty) returns (google.protobuf.Empty); } The JSON representation for `Empty` is empty JSON
    /// object `{}`.
    /// </summary>
    public class Empty : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents a textual expression in the Common Expression Language (CEL) syntax. CEL is a C-like expression
    /// language. The syntax and semantics of CEL are documented at https://github.com/google/cel-spec. Example
    /// (Comparison): title: "Summary size limit" description: "Determines if a summary is less than 100 chars"
    /// expression: "document.summary.size() &amp;lt; 100" Example (Equality): title: "Requestor is owner" description:
    /// "Determines if requestor is the document owner" expression: "document.owner == request.auth.claims.email"
    /// Example (Logic): title: "Public documents" description: "Determine whether the document should be publicly
    /// visible" expression: "document.type != 'private' &amp;amp;&amp;amp; document.type != 'internal'" Example (Data
    /// Manipulation): title: "Notification string" description: "Create a notification string with a timestamp."
    /// expression: "'New message received at ' + string(document.create_time)" The exact variables and functions that
    /// may be referenced within an expression are determined by the service that evaluates it. See the service
    /// documentation for additional information.
    /// </summary>
    public class Expr : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Description of the expression. This is a longer text which describes the expression, e.g. when
        /// hovered over it in a UI.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Textual representation of an expression in Common Expression Language syntax.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expression")]
        public virtual string Expression { get; set; }

        /// <summary>
        /// Optional. String indicating the location of the expression for error reporting, e.g. a file name and a
        /// position in the file.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("location")]
        public virtual string Location { get; set; }

        /// <summary>
        /// Optional. Title for the expression, i.e. a short string describing its purpose. This can be used e.g. in UIs
        /// which allow to enter the expression.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata describing a long running folder operation</summary>
    public class FolderOperation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The resource name of the folder or organization we are either creating the folder under or moving the folder
        /// to.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("destinationParent")]
        public virtual string DestinationParent { get; set; }

        /// <summary>The display name of the folder.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>The type of this operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operationType")]
        public virtual string OperationType { get; set; }

        /// <summary>
        /// The resource name of the folder's parent. Only applicable when the operation_type is MOVE.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceParent")]
        public virtual string SourceParent { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A classification of the Folder Operation error.</summary>
    public class FolderOperationError : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The type of operation error experienced.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errorMessageId")]
        public virtual string ErrorMessageId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request sent to the GetAncestry method.</summary>
    public class GetAncestryRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response from the projects.getAncestry method.</summary>
    public class GetAncestryResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Ancestors are ordered from bottom to top of the resource hierarchy. The first ancestor is the project
        /// itself, followed by the project's parent, etc..
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ancestor")]
        public virtual System.Collections.Generic.IList<Ancestor> Ancestor { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request sent to the GetEffectiveOrgPolicy method.</summary>
    public class GetEffectiveOrgPolicyRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The name of the `Constraint` to compute the effective `Policy`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("constraint")]
        public virtual string Constraint { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for `GetIamPolicy` method.</summary>
    public class GetIamPolicyRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>OPTIONAL: A `GetPolicyOptions` object for specifying options to `GetIamPolicy`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("options")]
        public virtual GetPolicyOptions Options { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request sent to the GetOrgPolicy method.</summary>
    public class GetOrgPolicyRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Name of the `Constraint` to get the `Policy`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("constraint")]
        public virtual string Constraint { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Encapsulates settings provided to GetIamPolicy.</summary>
    public class GetPolicyOptions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The policy format version to be returned. Valid values are 0, 1, and 3. Requests specifying an
        /// invalid value will be rejected. Requests for policies with any conditional bindings must specify version 3.
        /// Policies without any conditional bindings may specify any valid value or leave the field unset. To learn
        /// which resources support conditions in their IAM policies, see the [IAM
        /// documentation](https://cloud.google.com/iam/help/conditions/resource-policies).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestedPolicyVersion")]
        public virtual System.Nullable<int> RequestedPolicyVersion { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A Lien represents an encumbrance on the actions that can be performed on a resource.</summary>
    public class Lien : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The creation time of this Lien.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>A system-generated unique identifier for this Lien. Example: `liens/1234abcd`</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// A stable, user-visible/meaningful string identifying the origin of the Lien, intended to be inspected
        /// programmatically. Maximum length of 200 characters. Example: 'compute.googleapis.com'
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("origin")]
        public virtual string Origin { get; set; }

        /// <summary>
        /// A reference to the resource this Lien is attached to. The server will validate the parent against those for
        /// which Liens are supported. Example: `projects/1234`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parent")]
        public virtual string Parent { get; set; }

        /// <summary>
        /// Concise user-visible strings indicating why an action cannot be performed on a resource. Maximum length of
        /// 200 characters. Example: 'Holds production API key'
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reason")]
        public virtual string Reason { get; set; }

        /// <summary>
        /// The types of operations which should be blocked as a result of this Lien. Each value should correspond to an
        /// IAM permission. The server will validate the permissions against those for which Liens are supported. An
        /// empty list is meaningless and will be rejected. Example: ['resourcemanager.projects.delete']
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("restrictions")]
        public virtual System.Collections.Generic.IList<string> Restrictions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The request sent to the `ListAvailableOrgPolicyConstraints` method on the project, folder, or organization.
    /// </summary>
    public class ListAvailableOrgPolicyConstraintsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Size of the pages to be returned. This is currently unsupported and will be ignored. The server may at any
        /// point start using this field to limit page size.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageSize")]
        public virtual System.Nullable<int> PageSize { get; set; }

        /// <summary>
        /// Page token used to retrieve the next page. This is currently unsupported and will be ignored. The server may
        /// at any point start using this field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageToken")]
        public virtual string PageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The response returned from the `ListAvailableOrgPolicyConstraints` method. Returns all `Constraints` that could
    /// be set at this level of the hierarchy (contrast with the response from `ListPolicies`, which returns all
    /// policies which are set).
    /// </summary>
    public class ListAvailableOrgPolicyConstraintsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The collection of constraints that are settable on the request resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("constraints")]
        public virtual System.Collections.Generic.IList<Constraint> Constraints { get; set; }

        /// <summary>Page token used to retrieve the next page. This is currently not used.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A `Constraint` that allows or disallows a list of string values, which are configured by an Organization's
    /// policy administrator with a `Policy`.
    /// </summary>
    public class ListConstraint : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The Google Cloud Console will try to default to a configuration that matches the value specified
        /// in this `Constraint`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("suggestedValue")]
        public virtual string SuggestedValue { get; set; }

        /// <summary>
        /// Indicates whether subtrees of Cloud Resource Manager resource hierarchy can be used in
        /// `Policy.allowed_values` and `Policy.denied_values`. For example, `"under:folders/123"` would match any
        /// resource under the 'folders/123' folder.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("supportsUnder")]
        public virtual System.Nullable<bool> SupportsUnder { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response message for Liens.ListLiens.</summary>
    public class ListLiensResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of Liens.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("liens")]
        public virtual System.Collections.Generic.IList<Lien> Liens { get; set; }

        /// <summary>
        /// Token to retrieve the next page of results, or empty if there are no more results in the list.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request sent to the ListOrgPolicies method.</summary>
    public class ListOrgPoliciesRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Size of the pages to be returned. This is currently unsupported and will be ignored. The server may at any
        /// point start using this field to limit page size.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageSize")]
        public virtual System.Nullable<int> PageSize { get; set; }

        /// <summary>
        /// Page token used to retrieve the next page. This is currently unsupported and will be ignored. The server may
        /// at any point start using this field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageToken")]
        public virtual string PageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The response returned from the `ListOrgPolicies` method. It will be empty if no `Policies` are set on the
    /// resource.
    /// </summary>
    public class ListOrgPoliciesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Page token used to retrieve the next page. This is currently not used, but the server may at any point start
        /// supplying a valid token.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The `Policies` that are set on the resource. It will be empty if no `Policies` are set.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("policies")]
        public virtual System.Collections.Generic.IList<OrgPolicy> Policies { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Used in `policy_type` to specify how `list_policy` behaves at this resource. `ListPolicy` can define specific
    /// values and subtrees of Cloud Resource Manager resource hierarchy (`Organizations`, `Folders`, `Projects`) that
    /// are allowed or denied by setting the `allowed_values` and `denied_values` fields. This is achieved by using the
    /// `under:` and optional `is:` prefixes. The `under:` prefix is used to denote resource subtree values. The `is:`
    /// prefix is used to denote specific values, and is required only if the value contains a ":". Values prefixed with
    /// "is:" are treated the same as values with no prefix. Ancestry subtrees must be in one of the following formats:
    /// - "projects/", e.g. "projects/tokyo-rain-123" - "folders/", e.g. "folders/1234" - "organizations/", e.g.
    /// "organizations/1234" The `supports_under` field of the associated `Constraint` defines whether ancestry prefixes
    /// can be used. You can set `allowed_values` and `denied_values` in the same `Policy` if `all_values` is
    /// `ALL_VALUES_UNSPECIFIED`. `ALLOW` or `DENY` are used to allow or deny all values. If `all_values` is set to
    /// either `ALLOW` or `DENY`, `allowed_values` and `denied_values` must be unset.
    /// </summary>
    public class ListPolicy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The policy all_values state.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allValues")]
        public virtual string AllValues { get; set; }

        /// <summary>
        /// List of values allowed at this resource. Can only be set if `all_values` is set to `ALL_VALUES_UNSPECIFIED`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowedValues")]
        public virtual System.Collections.Generic.IList<string> AllowedValues { get; set; }

        /// <summary>
        /// List of values denied at this resource. Can only be set if `all_values` is set to `ALL_VALUES_UNSPECIFIED`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deniedValues")]
        public virtual System.Collections.Generic.IList<string> DeniedValues { get; set; }

        /// <summary>
        /// Determines the inheritance behavior for this `Policy`. By default, a `ListPolicy` set at a resource
        /// supersedes any `Policy` set anywhere up the resource hierarchy. However, if `inherit_from_parent` is set to
        /// `true`, then the values from the effective `Policy` of the parent resource are inherited, meaning the values
        /// set in this `Policy` are added to the values inherited up the hierarchy. Setting `Policy` hierarchies that
        /// inherit both allowed values and denied values isn't recommended in most circumstances to keep the
        /// configuration simple and understandable. However, it is possible to set a `Policy` with `allowed_values` set
        /// that inherits a `Policy` with `denied_values` set. In this case, the values that are allowed must be in
        /// `allowed_values` and not present in `denied_values`. For example, suppose you have a `Constraint`
        /// `constraints/serviceuser.services`, which has a `constraint_type` of `list_constraint`, and with
        /// `constraint_default` set to `ALLOW`. Suppose that at the Organization level, a `Policy` is applied that
        /// restricts the allowed API activations to {`E1`, `E2`}. Then, if a `Policy` is applied to a project below the
        /// Organization that has `inherit_from_parent` set to `false` and field all_values set to DENY, then an attempt
        /// to activate any API will be denied. The following examples demonstrate different possible layerings for
        /// `projects/bar` parented by `organizations/foo`: Example 1 (no inherited values): `organizations/foo` has a
        /// `Policy` with values: {allowed_values: "E1" allowed_values:"E2"} `projects/bar` has `inherit_from_parent`
        /// `false` and values: {allowed_values: "E3" allowed_values: "E4"} The accepted values at `organizations/foo`
        /// are `E1`, `E2`. The accepted values at `projects/bar` are `E3`, and `E4`. Example 2 (inherited values):
        /// `organizations/foo` has a `Policy` with values: {allowed_values: "E1" allowed_values:"E2"} `projects/bar`
        /// has a `Policy` with values: {value: "E3" value: "E4" inherit_from_parent: true} The accepted values at
        /// `organizations/foo` are `E1`, `E2`. The accepted values at `projects/bar` are `E1`, `E2`, `E3`, and `E4`.
        /// Example 3 (inheriting both allowed and denied values): `organizations/foo` has a `Policy` with values:
        /// {allowed_values: "E1" allowed_values: "E2"} `projects/bar` has a `Policy` with: {denied_values: "E1"} The
        /// accepted values at `organizations/foo` are `E1`, `E2`. The value accepted at `projects/bar` is `E2`. Example
        /// 4 (RestoreDefault): `organizations/foo` has a `Policy` with values: {allowed_values: "E1"
        /// allowed_values:"E2"} `projects/bar` has a `Policy` with values: {RestoreDefault: {}} The accepted values at
        /// `organizations/foo` are `E1`, `E2`. The accepted values at `projects/bar` are either all or none depending
        /// on the value of `constraint_default` (if `ALLOW`, all; if `DENY`, none). Example 5 (no policy inherits
        /// parent policy): `organizations/foo` has no `Policy` set. `projects/bar` has no `Policy` set. The accepted
        /// values at both levels are either all or none depending on the value of `constraint_default` (if `ALLOW`,
        /// all; if `DENY`, none). Example 6 (ListConstraint allowing all): `organizations/foo` has a `Policy` with
        /// values: {allowed_values: "E1" allowed_values: "E2"} `projects/bar` has a `Policy` with: {all: ALLOW} The
        /// accepted values at `organizations/foo` are `E1`, E2`. Any value is accepted at `projects/bar`. Example 7
        /// (ListConstraint allowing none): `organizations/foo` has a `Policy` with values: {allowed_values: "E1"
        /// allowed_values: "E2"} `projects/bar` has a `Policy` with: {all: DENY} The accepted values at
        /// `organizations/foo` are `E1`, E2`. No value is accepted at `projects/bar`. Example 10 (allowed and denied
        /// subtrees of Resource Manager hierarchy): Given the following resource hierarchy O1-&amp;gt;{F1, F2};
        /// F1-&amp;gt;{P1}; F2-&amp;gt;{P2, P3}, `organizations/foo` has a `Policy` with values: {allowed_values:
        /// "under:organizations/O1"} `projects/bar` has a `Policy` with: {allowed_values: "under:projects/P3"}
        /// {denied_values: "under:folders/F2"} The accepted values at `organizations/foo` are `organizations/O1`,
        /// `folders/F1`, `folders/F2`, `projects/P1`, `projects/P2`, `projects/P3`. The accepted values at
        /// `projects/bar` are `organizations/O1`, `folders/F1`, `projects/P1`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inheritFromParent")]
        public virtual System.Nullable<bool> InheritFromParent { get; set; }

        /// <summary>
        /// Optional. The Google Cloud Console will try to default to a configuration that matches the value specified
        /// in this `Policy`. If `suggested_value` is not set, it will inherit the value specified higher in the
        /// hierarchy, unless `inherit_from_parent` is `false`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("suggestedValue")]
        public virtual string SuggestedValue { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A page of the response received from the ListProjects method. A paginated response where more pages are
    /// available has `next_page_token` set. This token can be used in a subsequent request to retrieve the next request
    /// page.
    /// </summary>
    public class ListProjectsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Pagination token. If the result set is too large to fit in a single response, this token is returned. It
        /// encodes the position of the current result cursor. Feeding this value into a new list request with the
        /// `page_token` parameter gives the next page of the results. When `next_page_token` is not filled in, there is
        /// no next page and the list returned is the last page in the result set. Pagination tokens have a limited
        /// lifetime.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The list of Projects that matched the list filter. This list can be paginated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("projects")]
        public virtual System.Collections.Generic.IList<Project> Projects { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata pertaining to the folder move process.</summary>
    public class MoveFolderMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The resource name of the folder or organization to move the folder to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("destinationParent")]
        public virtual string DestinationParent { get; set; }

        /// <summary>The display name of the folder.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>The resource name of the folder's parent.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceParent")]
        public virtual string SourceParent { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A status object which is used as the `metadata` field for the Operation returned by MoveProject.
    /// </summary>
    public class MoveProjectMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>This resource represents a long-running operation that is the result of a network API call.</summary>
    public class Operation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// If the value is `false`, it means the operation is still in progress. If `true`, the operation is completed,
        /// and either `error` or `response` is available.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("done")]
        public virtual System.Nullable<bool> Done { get; set; }

        /// <summary>The error result of the operation in case of failure or cancellation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("error")]
        public virtual Status Error { get; set; }

        /// <summary>
        /// Service-specific metadata associated with the operation. It typically contains progress information and
        /// common metadata such as create time. Some services might not provide such metadata. Any method that returns
        /// a long-running operation should document the metadata type, if any.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual System.Collections.Generic.IDictionary<string, object> Metadata { get; set; }

        /// <summary>
        /// The server-assigned name, which is only unique within the same service that originally returns it. If you
        /// use the default HTTP mapping, the `name` should be a resource name ending with `operations/{unique_id}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// The normal response of the operation in case of success. If the original method returns no data on success,
        /// such as `Delete`, the response is `google.protobuf.Empty`. If the original method is standard
        /// `Get`/`Create`/`Update`, the response should be the resource. For other methods, the response should have
        /// the type `XxxResponse`, where `Xxx` is the original method name. For example, if the original method name is
        /// `TakeSnapshot()`, the inferred response type is `TakeSnapshotResponse`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("response")]
        public virtual System.Collections.Generic.IDictionary<string, object> Response { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Defines a Cloud Organization `Policy` which is used to specify `Constraints` for configurations of Cloud
    /// Platform resources.
    /// </summary>
    public class OrgPolicy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>For boolean `Constraints`, whether to enforce the `Constraint` or not.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("booleanPolicy")]
        public virtual BooleanPolicy BooleanPolicy { get; set; }

        /// <summary>
        /// The name of the `Constraint` the `Policy` is configuring, for example, `constraints/serviceuser.services`. A
        /// [list of available constraints](/resource-manager/docs/organization-policy/org-policy-constraints) is
        /// available. Immutable after creation.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("constraint")]
        public virtual string Constraint { get; set; }

        /// <summary>
        /// An opaque tag indicating the current version of the `Policy`, used for concurrency control. When the
        /// `Policy` is returned from either a `GetPolicy` or a `ListOrgPolicy` request, this `etag` indicates the
        /// version of the current `Policy` to use when executing a read-modify-write loop. When the `Policy` is
        /// returned from a `GetEffectivePolicy` request, the `etag` will be unset. When the `Policy` is used in a
        /// `SetOrgPolicy` method, use the `etag` value that was returned from a `GetOrgPolicy` request as part of a
        /// read-modify-write loop for concurrency control. Not setting the `etag`in a `SetOrgPolicy` request will
        /// result in an unconditional write of the `Policy`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>List of values either allowed or disallowed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("listPolicy")]
        public virtual ListPolicy ListPolicy { get; set; }

        /// <summary>Restores the default behavior of the constraint; independent of `Constraint` type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("restoreDefault")]
        public virtual RestoreDefault RestoreDefault { get; set; }

        /// <summary>
        /// The time stamp the `Policy` was previously updated. This is set by the server, not specified by the caller,
        /// and represents the last time a call to `SetOrgPolicy` was made for that `Policy`. Any value set by the
        /// client will be ignored.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }

        /// <summary>Version of the `Policy`. Default version is 0;</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual System.Nullable<int> Version { get; set; }
    }

    /// <summary>
    /// The root node in the resource hierarchy to which a particular entity's (e.g., company) resources belong.
    /// </summary>
    public class Organization : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Timestamp when the Organization was created. Assigned by the server.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("creationTime")]
        public virtual object CreationTime { get; set; }

        /// <summary>
        /// A human-readable string that refers to the Organization in the GCP Console UI. This string is set by the
        /// server and cannot be changed. The string will be set to the primary domain (for example, "google.com") of
        /// the G Suite customer that owns the organization.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>The organization's current lifecycle state. Assigned by the server.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lifecycleState")]
        public virtual string LifecycleState { get; set; }

        /// <summary>
        /// Output only. The resource name of the organization. This is the organization's relative path in the API. Its
        /// format is "organizations/[organization_id]". For example, "organizations/1234".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// The owner of this Organization. The owner should be specified on creation. Once set, it cannot be changed.
        /// This field is required.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("owner")]
        public virtual OrganizationOwner Owner { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The entity that owns an Organization. The lifetime of the Organization and all of its descendants are bound to
    /// the `OrganizationOwner`. If the `OrganizationOwner` is deleted, the Organization and all its descendants will be
    /// deleted.
    /// </summary>
    public class OrganizationOwner : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The G Suite customer id used in the Directory API.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("directoryCustomerId")]
        public virtual string DirectoryCustomerId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An Identity and Access Management (IAM) policy, which specifies access controls for Google Cloud resources. A
    /// `Policy` is a collection of `bindings`. A `binding` binds one or more `members` to a single `role`. Members can
    /// be user accounts, service accounts, Google groups, and domains (such as G Suite). A `role` is a named list of
    /// permissions; each `role` can be an IAM predefined role or a user-created custom role. For some types of Google
    /// Cloud resources, a `binding` can also specify a `condition`, which is a logical expression that allows access to
    /// a resource only if the expression evaluates to `true`. A condition can add constraints based on attributes of
    /// the request, the resource, or both. To learn which resources support conditions in their IAM policies, see the
    /// [IAM documentation](https://cloud.google.com/iam/help/conditions/resource-policies). **JSON example:** {
    /// "bindings": [ { "role": "roles/resourcemanager.organizationAdmin", "members": [ "user:mike@example.com",
    /// "group:admins@example.com", "domain:google.com", "serviceAccount:my-project-id@appspot.gserviceaccount.com" ] },
    /// { "role": "roles/resourcemanager.organizationViewer", "members": [ "user:eve@example.com" ], "condition": {
    /// "title": "expirable access", "description": "Does not grant access after Sep 2020", "expression": "request.time
    /// &amp;lt; timestamp('2020-10-01T00:00:00.000Z')", } } ], "etag": "BwWWja0YfJA=", "version": 3 } **YAML example:**
    /// bindings: - members: - user:mike@example.com - group:admins@example.com - domain:google.com -
    /// serviceAccount:my-project-id@appspot.gserviceaccount.com role: roles/resourcemanager.organizationAdmin -
    /// members: - user:eve@example.com role: roles/resourcemanager.organizationViewer condition: title: expirable
    /// access description: Does not grant access after Sep 2020 expression: request.time &amp;lt;
    /// timestamp('2020-10-01T00:00:00.000Z') - etag: BwWWja0YfJA= - version: 3 For a description of IAM and its
    /// features, see the [IAM documentation](https://cloud.google.com/iam/docs/).
    /// </summary>
    public class Policy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Specifies cloud audit logging configuration for this policy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("auditConfigs")]
        public virtual System.Collections.Generic.IList<AuditConfig> AuditConfigs { get; set; }

        /// <summary>
        /// Associates a list of `members` to a `role`. Optionally, may specify a `condition` that determines how and
        /// when the `bindings` are applied. Each of the `bindings` must contain at least one member.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bindings")]
        public virtual System.Collections.Generic.IList<Binding> Bindings { get; set; }

        /// <summary>
        /// `etag` is used for optimistic concurrency control as a way to help prevent simultaneous updates of a policy
        /// from overwriting each other. It is strongly suggested that systems make use of the `etag` in the
        /// read-modify-write cycle to perform policy updates in order to avoid race conditions: An `etag` is returned
        /// in the response to `getIamPolicy`, and systems are expected to put that etag in the request to
        /// `setIamPolicy` to ensure that their change will be applied to the same version of the policy. **Important:**
        /// If you use IAM Conditions, you must include the `etag` field whenever you call `setIamPolicy`. If you omit
        /// this field, then IAM allows you to overwrite a version `3` policy with a version `1` policy, and all of the
        /// conditions in the version `3` policy are lost.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>
        /// Specifies the format of the policy. Valid values are `0`, `1`, and `3`. Requests that specify an invalid
        /// value are rejected. Any operation that affects conditional role bindings must specify version `3`. This
        /// requirement applies to the following operations: * Getting a policy that includes a conditional role binding
        /// * Adding a conditional role binding to a policy * Changing a conditional role binding in a policy * Removing
        /// any role binding, with or without a condition, from a policy that includes conditions **Important:** If you
        /// use IAM Conditions, you must include the `etag` field whenever you call `setIamPolicy`. If you omit this
        /// field, then IAM allows you to overwrite a version `3` policy with a version `1` policy, and all of the
        /// conditions in the version `3` policy are lost. If a policy does not include any conditions, operations on
        /// that policy may specify any valid version or leave the field unset. To learn which resources support
        /// conditions in their IAM policies, see the [IAM
        /// documentation](https://cloud.google.com/iam/help/conditions/resource-policies).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual System.Nullable<int> Version { get; set; }
    }

    /// <summary>
    /// A Project is a high-level Google Cloud Platform entity. It is a container for ACLs, APIs, App Engine Apps, VMs,
    /// and other Google Cloud Platform resources.
    /// </summary>
    public class Project : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Creation time. Read-only.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>
        /// The labels associated with this Project. Label keys must be between 1 and 63 characters long and must
        /// conform to the following regular expression: a-z{0,62}. Label values must be between 0 and 63 characters
        /// long and must conform to the regular expression [a-z0-9_-]{0,63}. A label value can be empty. No more than
        /// 256 labels can be associated with a given resource. Clients should store labels in a representation such as
        /// JSON that does not depend on specific characters being disallowed. Example: "environment" : "dev"
        /// Read-write.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>The Project lifecycle state. Read-only.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lifecycleState")]
        public virtual string LifecycleState { get; set; }

        /// <summary>
        /// The optional user-assigned display name of the Project. When present it must be between 4 to 30 characters.
        /// Allowed characters are: lowercase and uppercase letters, numbers, hyphen, single-quote, double-quote, space,
        /// and exclamation point. Example: `My Project` Read-write.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// An optional reference to a parent Resource. Supported parent types include "organization" and "folder". Once
        /// set, the parent cannot be cleared. The `parent` can be set on creation or using the `UpdateProject` method;
        /// the end user must have the `resourcemanager.projects.create` permission on the parent.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parent")]
        public virtual ResourceId Parent { get; set; }

        /// <summary>
        /// The unique, user-assigned ID of the Project. It must be 6 to 30 lowercase letters, digits, or hyphens. It
        /// must start with a letter. Trailing hyphens are prohibited. Example: `tokyo-rain-123` Read-only after
        /// creation.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("projectId")]
        public virtual string ProjectId { get; set; }

        /// <summary>The number uniquely identifying the project. Example: `415104041262` Read-only.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("projectNumber")]
        public virtual System.Nullable<long> ProjectNumber { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A status object which is used as the `metadata` field for the Operation returned by CreateProject. It provides
    /// insight for when significant phases of Project creation have completed.
    /// </summary>
    public class ProjectCreationStatus : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Creation time of the project creation workflow.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>
        /// True if the project can be retrieved using GetProject. No other operations on the project are guaranteed to
        /// work until the project creation is complete.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gettable")]
        public virtual System.Nullable<bool> Gettable { get; set; }

        /// <summary>True if the project creation process is complete.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ready")]
        public virtual System.Nullable<bool> Ready { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A container to reference an id for any resource type. A `resource` in Google Cloud Platform is a generic term
    /// for something you (a developer) may want to interact with through one of our API's. Some examples are an App
    /// Engine app, a Compute Engine instance, a Cloud SQL database, and so on.
    /// </summary>
    public class ResourceId : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The type-specific id. This should correspond to the id used in the type-specific API's.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>
        /// The resource type this id is for. At present, the valid types are: "organization", "folder", and "project".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Ignores policies set above this resource and restores the `constraint_default` enforcement behavior of the
    /// specific `Constraint` at this resource. Suppose that `constraint_default` is set to `ALLOW` for the `Constraint`
    /// `constraints/serviceuser.services`. Suppose that organization foo.com sets a `Policy` at their Organization
    /// resource node that restricts the allowed service activations to deny all service activations. They could then
    /// set a `Policy` with the `policy_type` `restore_default` on several experimental projects, restoring the
    /// `constraint_default` enforcement of the `Constraint` for only those projects, allowing those projects to have
    /// all services activated.
    /// </summary>
    public class RestoreDefault : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request sent to the `SearchOrganizations` method.</summary>
    public class SearchOrganizationsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// An optional query string used to filter the Organizations to return in the response. Filter rules are
        /// case-insensitive. Organizations may be filtered by `owner.directoryCustomerId` or by `domain`, where the
        /// domain is a G Suite domain, for example: * Filter `owner.directorycustomerid:123456789` returns Organization
        /// resources with `owner.directory_customer_id` equal to `123456789`. * Filter `domain:google.com` returns
        /// Organization resources corresponding to the domain `google.com`. This field is optional.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filter")]
        public virtual string Filter { get; set; }

        /// <summary>The maximum number of Organizations to return in the response. This field is optional.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageSize")]
        public virtual System.Nullable<int> PageSize { get; set; }

        /// <summary>
        /// A pagination token returned from a previous call to `SearchOrganizations` that indicates from where listing
        /// should continue. This field is optional.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageToken")]
        public virtual string PageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response returned from the `SearchOrganizations` method.</summary>
    public class SearchOrganizationsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A pagination token to be used to retrieve the next page of results. If the result is too large to fit within
        /// the page size specified in the request, this field will be set with a token that can be used to fetch the
        /// next page of results. If this field is empty, it indicates that this response contains the last page of
        /// results.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The list of Organizations that matched the search query, possibly paginated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("organizations")]
        public virtual System.Collections.Generic.IList<Organization> Organizations { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for `SetIamPolicy` method.</summary>
    public class SetIamPolicyRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// REQUIRED: The complete policy to be applied to the `resource`. The size of the policy is limited to a few
        /// 10s of KB. An empty policy is a valid policy but certain Cloud Platform services (such as Projects) might
        /// reject them.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("policy")]
        public virtual Policy Policy { get; set; }

        /// <summary>
        /// OPTIONAL: A FieldMask specifying which fields of the policy to modify. Only the fields in the mask will be
        /// modified. If no mask is provided, the following default mask is used: `paths: "bindings, etag"`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateMask")]
        public virtual object UpdateMask { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request sent to the SetOrgPolicyRequest method.</summary>
    public class SetOrgPolicyRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>`Policy` to set on the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("policy")]
        public virtual OrgPolicy Policy { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The `Status` type defines a logical error model that is suitable for different programming environments,
    /// including REST APIs and RPC APIs. It is used by [gRPC](https://github.com/grpc). Each `Status` message contains
    /// three pieces of data: error code, error message, and error details. You can find out more about this error model
    /// and how to work with it in the [API Design Guide](https://cloud.google.com/apis/design/errors).
    /// </summary>
    public class Status : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The status code, which should be an enum value of google.rpc.Code.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("code")]
        public virtual System.Nullable<int> Code { get; set; }

        /// <summary>
        /// A list of messages that carry the error details. There is a common set of message types for APIs to use.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("details")]
        public virtual System.Collections.Generic.IList<System.Collections.Generic.IDictionary<string, object>> Details { get; set; }

        /// <summary>
        /// A developer-facing error message, which should be in English. Any user-facing error message should be
        /// localized and sent in the google.rpc.Status.details field, or localized by the client.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("message")]
        public virtual string Message { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for `TestIamPermissions` method.</summary>
    public class TestIamPermissionsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The set of permissions to check for the `resource`. Permissions with wildcards (such as '*' or 'storage.*')
        /// are not allowed. For more information see [IAM
        /// Overview](https://cloud.google.com/iam/docs/overview#permissions).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("permissions")]
        public virtual System.Collections.Generic.IList<string> Permissions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for `TestIamPermissions` method.</summary>
    public class TestIamPermissionsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A subset of `TestPermissionsRequest.permissions` that the caller is allowed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("permissions")]
        public virtual System.Collections.Generic.IList<string> Permissions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A status object which is used as the `metadata` field for the `Operation` returned by `UndeleteFolder`.
    /// </summary>
    public class UndeleteFolderMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A status object which is used as the `metadata` field for the Operation returned by UndeleteOrganization.
    /// </summary>
    public class UndeleteOrganizationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A status object which is used as the `metadata` field for the Operation returned by `UndeleteProject`.
    /// </summary>
    public class UndeleteProjectMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request sent to the UndeleteProject method.</summary>
    public class UndeleteProjectRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A status object which is used as the `metadata` field for the Operation returned by UpdateFolder.
    /// </summary>
    public class UpdateFolderMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A status object which is used as the `metadata` field for the Operation returned by UpdateProject.
    /// </summary>
    public class UpdateProjectMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Runtime operation information for updating a TagKey.</summary>
    public class UpdateTagKeyMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Runtime operation information for updating a TagValue.</summary>
    public class UpdateTagValueMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
