// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Argocd.Outputs
{

    [OutputType]
    public sealed class ApplicationSetSpecGeneratorMatrixGeneratorMatrixGeneratorScmProviderBitbucketServer
    {
        /// <summary>
        /// Scan all branches instead of just the default branch.
        /// </summary>
        public readonly bool? AllBranches;
        /// <summary>
        /// The Bitbucket REST API URL to talk to e.g. https://bitbucket.org/rest.
        /// </summary>
        public readonly string Api;
        /// <summary>
        /// Credentials for Basic auth.
        /// </summary>
        public readonly Outputs.ApplicationSetSpecGeneratorMatrixGeneratorMatrixGeneratorScmProviderBitbucketServerBasicAuth? BasicAuth;
        /// <summary>
        /// The project the application belongs to. Defaults to `default`.
        /// </summary>
        public readonly string Project;

        [OutputConstructor]
        private ApplicationSetSpecGeneratorMatrixGeneratorMatrixGeneratorScmProviderBitbucketServer(
            bool? allBranches,

            string api,

            Outputs.ApplicationSetSpecGeneratorMatrixGeneratorMatrixGeneratorScmProviderBitbucketServerBasicAuth? basicAuth,

            string project)
        {
            AllBranches = allBranches;
            Api = api;
            BasicAuth = basicAuth;
            Project = project;
        }
    }
}