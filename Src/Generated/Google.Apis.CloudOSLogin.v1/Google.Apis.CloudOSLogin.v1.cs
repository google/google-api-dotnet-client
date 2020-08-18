// Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file except in compliance with
// the License. You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software distributed under the License is distributed on
// an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the License for the
// specific language governing permissions and limitations under the License.

// Generated code. DO NOT EDIT!

namespace Google.Apis.CloudOSLogin.v1
{
    /// <summary>The CloudOSLogin Service.</summary>
    public class CloudOSLoginService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed =
            Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public CloudOSLoginService() :
            this(new Google.Apis.Services.BaseClientService.Initializer()) {}

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public CloudOSLoginService(Google.Apis.Services.BaseClientService.Initializer initializer)
            : base(initializer)
        {
            Users = new UsersResource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "oslogin";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri =>
        #if NETSTANDARD1_3 || NETSTANDARD2_0 || NET45
            BaseUriOverride ?? "https://oslogin.googleapis.com/";
        #else
            "https://oslogin.googleapis.com/";
        #endif

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        #if !NET40
        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri => "https://oslogin.googleapis.com/batch";

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";
        #endif

        /// <summary>Available OAuth 2.0 scopes for use with the Cloud OS Login API.</summary>
        public class Scope
        {
            /// <summary>View and manage your data across Google Cloud Platform services</summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";

            /// <summary>View and manage your Google Compute Engine resources</summary>
            public static string Compute = "https://www.googleapis.com/auth/compute";

        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Cloud OS Login API.</summary>
        public static class ScopeConstants
        {
            /// <summary>View and manage your data across Google Cloud Platform services</summary>
            public const string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";

            /// <summary>View and manage your Google Compute Engine resources</summary>
            public const string Compute = "https://www.googleapis.com/auth/compute";

        }



        /// <summary>Gets the Users resource.</summary>
        public virtual UsersResource Users { get; }
    }

    ///<summary>A base abstract class for CloudOSLogin requests.</summary>
    public abstract class CloudOSLoginBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        ///<summary>Constructs a new CloudOSLoginBaseServiceRequest instance.</summary>
        protected CloudOSLoginBaseServiceRequest(Google.Apis.Services.IClientService service)
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

        /// <summary>Initializes CloudOSLogin parameter list.</summary>
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
            Projects = new ProjectsResource(service);
            SshPublicKeys = new SshPublicKeysResource(service);

        }

        /// <summary>Gets the Projects resource.</summary>
        public virtual ProjectsResource Projects { get; }

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


            /// <summary>Deletes a POSIX account.</summary>
            /// <param name="name">Required. A reference to the POSIX account to update. POSIX accounts are identified by the
            /// project ID they are associated with. A reference to the POSIX account is in format
            /// `users/{user}/projects/{project}`.</param>
            public virtual DeleteRequest Delete(string name)
            {
                return new DeleteRequest(service, name);
            }

            /// <summary>Deletes a POSIX account.</summary>
            public class DeleteRequest : CloudOSLoginBaseServiceRequest<Google.Apis.CloudOSLogin.v1.Data.Empty>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string name)
                    : base(service)
                {
                    Name = name;
                    InitParameters();
                }


                /// <summary>Required. A reference to the POSIX account to update. POSIX accounts are identified by the
                /// project ID they are associated with. A reference to the POSIX account is in format
                /// `users/{user}/projects/{project}`.</summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }


                ///<summary>Gets the method name.</summary>
                public override string MethodName => "delete";

                ///<summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "DELETE";

                ///<summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+name}";

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
                            Pattern = @"^users/[^/]+/projects/[^/]+$",
                        });
                }

            }
        }
        /// <summary>Gets the SshPublicKeys resource.</summary>
        public virtual SshPublicKeysResource SshPublicKeys { get; }

        /// <summary>The "sshPublicKeys" collection of methods.</summary>
        public class SshPublicKeysResource
        {
            private const string Resource = "sshPublicKeys";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public SshPublicKeysResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;

            }


            /// <summary>Deletes an SSH public key.</summary>
            /// <param name="name">Required. The fingerprint of the public key to update. Public keys are identified by their
            /// SHA-256 fingerprint. The fingerprint of the public key is in format
            /// `users/{user}/sshPublicKeys/{fingerprint}`.</param>
            public virtual DeleteRequest Delete(string name)
            {
                return new DeleteRequest(service, name);
            }

            /// <summary>Deletes an SSH public key.</summary>
            public class DeleteRequest : CloudOSLoginBaseServiceRequest<Google.Apis.CloudOSLogin.v1.Data.Empty>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string name)
                    : base(service)
                {
                    Name = name;
                    InitParameters();
                }


                /// <summary>Required. The fingerprint of the public key to update. Public keys are identified by their
                /// SHA-256 fingerprint. The fingerprint of the public key is in format
                /// `users/{user}/sshPublicKeys/{fingerprint}`.</summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }


                ///<summary>Gets the method name.</summary>
                public override string MethodName => "delete";

                ///<summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "DELETE";

                ///<summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+name}";

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
                            Pattern = @"^users/[^/]+/sshPublicKeys/[^/]+$",
                        });
                }

            }

            /// <summary>Retrieves an SSH public key.</summary>
            /// <param name="name">Required. The fingerprint of the public key to retrieve. Public keys are identified by their
            /// SHA-256 fingerprint. The fingerprint of the public key is in format
            /// `users/{user}/sshPublicKeys/{fingerprint}`.</param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(service, name);
            }

            /// <summary>Retrieves an SSH public key.</summary>
            public class GetRequest : CloudOSLoginBaseServiceRequest<Google.Apis.CloudOSLogin.v1.Data.SshPublicKey>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name)
                    : base(service)
                {
                    Name = name;
                    InitParameters();
                }


                /// <summary>Required. The fingerprint of the public key to retrieve. Public keys are identified by
                /// their SHA-256 fingerprint. The fingerprint of the public key is in format
                /// `users/{user}/sshPublicKeys/{fingerprint}`.</summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }


                ///<summary>Gets the method name.</summary>
                public override string MethodName => "get";

                ///<summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                ///<summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+name}";

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
                            Pattern = @"^users/[^/]+/sshPublicKeys/[^/]+$",
                        });
                }

            }

            /// <summary>Updates an SSH public key and returns the profile information. This method supports patch
            /// semantics.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">Required. The fingerprint of the public key to update. Public keys are identified by their
            /// SHA-256 fingerprint. The fingerprint of the public key is in format
            /// `users/{user}/sshPublicKeys/{fingerprint}`.</param>
            public virtual PatchRequest Patch(Google.Apis.CloudOSLogin.v1.Data.SshPublicKey body, string name)
            {
                return new PatchRequest(service, body, name);
            }

            /// <summary>Updates an SSH public key and returns the profile information. This method supports patch
            /// semantics.</summary>
            public class PatchRequest : CloudOSLoginBaseServiceRequest<Google.Apis.CloudOSLogin.v1.Data.SshPublicKey>
            {
                /// <summary>Constructs a new Patch request.</summary>
                public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudOSLogin.v1.Data.SshPublicKey body, string name)
                    : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }


                /// <summary>Required. The fingerprint of the public key to update. Public keys are identified by their
                /// SHA-256 fingerprint. The fingerprint of the public key is in format
                /// `users/{user}/sshPublicKeys/{fingerprint}`.</summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Mask to control which fields get updated. Updates all if not present.</summary>
                [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                public virtual object UpdateMask { get; set; }


                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.CloudOSLogin.v1.Data.SshPublicKey Body { get; set; }

                ///<summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                ///<summary>Gets the method name.</summary>
                public override string MethodName => "patch";

                ///<summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PATCH";

                ///<summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+name}";

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
                            Pattern = @"^users/[^/]+/sshPublicKeys/[^/]+$",
                        });
                    RequestParameters.Add(
                        "updateMask", new Google.Apis.Discovery.Parameter
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

        /// <summary>Retrieves the profile information used for logging in to a virtual machine on Google Compute
        /// Engine.</summary>
        /// <param name="name">Required. The unique ID for the user in format `users/{user}`.</param>
        public virtual GetLoginProfileRequest GetLoginProfile(string name)
        {
            return new GetLoginProfileRequest(service, name);
        }

        /// <summary>Retrieves the profile information used for logging in to a virtual machine on Google Compute
        /// Engine.</summary>
        public class GetLoginProfileRequest : CloudOSLoginBaseServiceRequest<Google.Apis.CloudOSLogin.v1.Data.LoginProfile>
        {
            /// <summary>Constructs a new GetLoginProfile request.</summary>
            public GetLoginProfileRequest(Google.Apis.Services.IClientService service, string name)
                : base(service)
            {
                Name = name;
                InitParameters();
            }


            /// <summary>Required. The unique ID for the user in format `users/{user}`.</summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>The project ID of the Google Cloud Platform project.</summary>
            [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string ProjectId { get; set; }

            /// <summary>A system ID for filtering the results of the request.</summary>
            [Google.Apis.Util.RequestParameterAttribute("systemId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string SystemId { get; set; }


            ///<summary>Gets the method name.</summary>
            public override string MethodName => "getLoginProfile";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "v1/{+name}/loginProfile";

            /// <summary>Initializes GetLoginProfile parameter list.</summary>
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
                        Pattern = @"^users/[^/]+$",
                    });
                RequestParameters.Add(
                    "projectId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "projectId",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "systemId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "systemId",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }

        /// <summary>Adds an SSH public key and returns the profile information. Default POSIX account information is
        /// set when no username and UID exist as part of the login profile.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="parent">Required. The unique ID for the user in format `users/{user}`.</param>
        public virtual ImportSshPublicKeyRequest ImportSshPublicKey(Google.Apis.CloudOSLogin.v1.Data.SshPublicKey body, string parent)
        {
            return new ImportSshPublicKeyRequest(service, body, parent);
        }

        /// <summary>Adds an SSH public key and returns the profile information. Default POSIX account information is
        /// set when no username and UID exist as part of the login profile.</summary>
        public class ImportSshPublicKeyRequest : CloudOSLoginBaseServiceRequest<Google.Apis.CloudOSLogin.v1.Data.ImportSshPublicKeyResponse>
        {
            /// <summary>Constructs a new ImportSshPublicKey request.</summary>
            public ImportSshPublicKeyRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudOSLogin.v1.Data.SshPublicKey body, string parent)
                : base(service)
            {
                Parent = parent;
                Body = body;
                InitParameters();
            }


            /// <summary>Required. The unique ID for the user in format `users/{user}`.</summary>
            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Parent { get; private set; }

            /// <summary>The project ID of the Google Cloud Platform project.</summary>
            [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string ProjectId { get; set; }


            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.CloudOSLogin.v1.Data.SshPublicKey Body { get; set; }

            ///<summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            ///<summary>Gets the method name.</summary>
            public override string MethodName => "importSshPublicKey";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "v1/{+parent}:importSshPublicKey";

            /// <summary>Initializes ImportSshPublicKey parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "parent", new Google.Apis.Discovery.Parameter
                    {
                        Name = "parent",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^users/[^/]+$",
                    });
                RequestParameters.Add(
                    "projectId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "projectId",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }
    }
}

namespace Google.Apis.CloudOSLogin.v1.Data
{    

    /// <summary>A generic empty message that you can re-use to avoid defining duplicated empty messages in your APIs. A
    /// typical example is to use it as the request or the response type of an API method. For instance: service Foo {
    /// rpc Bar(google.protobuf.Empty) returns (google.protobuf.Empty); } The JSON representation for `Empty` is empty
    /// JSON object `{}`.</summary>
    public class Empty : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A response message for importing an SSH public key.</summary>
    public class ImportSshPublicKeyResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The login profile information for the user.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("loginProfile")]
        public virtual LoginProfile LoginProfile { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>The user profile information used for logging in to a virtual machine on Google Compute
    /// Engine.</summary>
    public class LoginProfile : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. A unique user ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; } 

        /// <summary>The list of POSIX accounts associated with the user.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("posixAccounts")]
        public virtual System.Collections.Generic.IList<PosixAccount> PosixAccounts { get; set; } 

        /// <summary>A map from SSH public key fingerprint to the associated key object.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sshPublicKeys")]
        public virtual System.Collections.Generic.IDictionary<string,SshPublicKey> SshPublicKeys { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>The POSIX account information associated with a Google account.</summary>
    public class PosixAccount : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. A POSIX account identifier.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accountId")]
        public virtual string AccountId { get; set; } 

        /// <summary>The GECOS (user information) entry for this account.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gecos")]
        public virtual string Gecos { get; set; } 

        /// <summary>The default group ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gid")]
        public virtual System.Nullable<long> Gid { get; set; } 

        /// <summary>The path to the home directory for this account.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("homeDirectory")]
        public virtual string HomeDirectory { get; set; } 

        /// <summary>Output only. The canonical resource name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; } 

        /// <summary>The operating system type where this account applies.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operatingSystemType")]
        public virtual string OperatingSystemType { get; set; } 

        /// <summary>Only one POSIX account can be marked as primary.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("primary")]
        public virtual System.Nullable<bool> Primary { get; set; } 

        /// <summary>The path to the logic shell for this account.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shell")]
        public virtual string Shell { get; set; } 

        /// <summary>System identifier for which account the username or uid applies to. By default, the empty value is
        /// used.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("systemId")]
        public virtual string SystemId { get; set; } 

        /// <summary>The user ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uid")]
        public virtual System.Nullable<long> Uid { get; set; } 

        /// <summary>The username of the POSIX account.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("username")]
        public virtual string Username { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>The SSH public key information associated with a Google account.</summary>
    public class SshPublicKey : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>An expiration time in microseconds since epoch.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expirationTimeUsec")]
        public virtual System.Nullable<long> ExpirationTimeUsec { get; set; } 

        /// <summary>Output only. The SHA-256 fingerprint of the SSH public key.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fingerprint")]
        public virtual string Fingerprint { get; set; } 

        /// <summary>Public key text in SSH format, defined by RFC4253 section 6.6.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("key")]
        public virtual string Key { get; set; } 

        /// <summary>Output only. The canonical resource name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
