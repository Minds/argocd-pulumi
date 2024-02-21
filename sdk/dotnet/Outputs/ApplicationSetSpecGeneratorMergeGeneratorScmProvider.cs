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
    public sealed class ApplicationSetSpecGeneratorMergeGeneratorScmProvider
    {
        /// <summary>
        /// Uses the Azure DevOps API to look up eligible repositories based on a team project within an Azure DevOps organization.
        /// </summary>
        public readonly Outputs.ApplicationSetSpecGeneratorMergeGeneratorScmProviderAzureDevops? AzureDevops;
        /// <summary>
        /// Uses the Bitbucket API V2 to scan a workspace in bitbucket.org.
        /// </summary>
        public readonly Outputs.ApplicationSetSpecGeneratorMergeGeneratorScmProviderBitbucketCloud? BitbucketCloud;
        /// <summary>
        /// Fetch pull requests from a repo hosted on a Bitbucket Server.
        /// </summary>
        public readonly Outputs.ApplicationSetSpecGeneratorMergeGeneratorScmProviderBitbucketServer? BitbucketServer;
        /// <summary>
        /// Which protocol to use for the SCM URL. Default is provider-specific but ssh if possible. Not all providers necessarily support all protocols.
        /// </summary>
        public readonly string? CloneProtocol;
        /// <summary>
        /// Filters allow selecting which pull requests to generate for.
        /// </summary>
        public readonly ImmutableArray<Outputs.ApplicationSetSpecGeneratorMergeGeneratorScmProviderFilter> Filters;
        /// <summary>
        /// Specify the repository from which to fetch the Gitea Pull requests.
        /// </summary>
        public readonly Outputs.ApplicationSetSpecGeneratorMergeGeneratorScmProviderGitea? Gitea;
        /// <summary>
        /// Specify the repository from which to fetch the GitHub Pull requests.
        /// </summary>
        public readonly Outputs.ApplicationSetSpecGeneratorMergeGeneratorScmProviderGithub? Github;
        /// <summary>
        /// Specify the project from which to fetch the GitLab merge requests.
        /// </summary>
        public readonly Outputs.ApplicationSetSpecGeneratorMergeGeneratorScmProviderGitlab? Gitlab;
        /// <summary>
        /// How often to check for changes (in seconds). Default: 3min.
        /// </summary>
        public readonly string? RequeueAfterSeconds;
        /// <summary>
        /// Generator template. Used to override the values of the spec-level template.
        /// </summary>
        public readonly Outputs.ApplicationSetSpecGeneratorMergeGeneratorScmProviderTemplate? Template;

        [OutputConstructor]
        private ApplicationSetSpecGeneratorMergeGeneratorScmProvider(
            Outputs.ApplicationSetSpecGeneratorMergeGeneratorScmProviderAzureDevops? azureDevops,

            Outputs.ApplicationSetSpecGeneratorMergeGeneratorScmProviderBitbucketCloud? bitbucketCloud,

            Outputs.ApplicationSetSpecGeneratorMergeGeneratorScmProviderBitbucketServer? bitbucketServer,

            string? cloneProtocol,

            ImmutableArray<Outputs.ApplicationSetSpecGeneratorMergeGeneratorScmProviderFilter> filters,

            Outputs.ApplicationSetSpecGeneratorMergeGeneratorScmProviderGitea? gitea,

            Outputs.ApplicationSetSpecGeneratorMergeGeneratorScmProviderGithub? github,

            Outputs.ApplicationSetSpecGeneratorMergeGeneratorScmProviderGitlab? gitlab,

            string? requeueAfterSeconds,

            Outputs.ApplicationSetSpecGeneratorMergeGeneratorScmProviderTemplate? template)
        {
            AzureDevops = azureDevops;
            BitbucketCloud = bitbucketCloud;
            BitbucketServer = bitbucketServer;
            CloneProtocol = cloneProtocol;
            Filters = filters;
            Gitea = gitea;
            Github = github;
            Gitlab = gitlab;
            RequeueAfterSeconds = requeueAfterSeconds;
            Template = template;
        }
    }
}