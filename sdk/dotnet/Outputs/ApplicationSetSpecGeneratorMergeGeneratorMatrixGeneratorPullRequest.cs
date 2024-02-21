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
    public sealed class ApplicationSetSpecGeneratorMergeGeneratorMatrixGeneratorPullRequest
    {
        /// <summary>
        /// Fetch pull requests from a repo hosted on a Bitbucket Server.
        /// </summary>
        public readonly Outputs.ApplicationSetSpecGeneratorMergeGeneratorMatrixGeneratorPullRequestBitbucketServer? BitbucketServer;
        /// <summary>
        /// Filters allow selecting which pull requests to generate for.
        /// </summary>
        public readonly ImmutableArray<Outputs.ApplicationSetSpecGeneratorMergeGeneratorMatrixGeneratorPullRequestFilter> Filters;
        /// <summary>
        /// Specify the repository from which to fetch the Gitea Pull requests.
        /// </summary>
        public readonly Outputs.ApplicationSetSpecGeneratorMergeGeneratorMatrixGeneratorPullRequestGitea? Gitea;
        /// <summary>
        /// Specify the repository from which to fetch the GitHub Pull requests.
        /// </summary>
        public readonly Outputs.ApplicationSetSpecGeneratorMergeGeneratorMatrixGeneratorPullRequestGithub? Github;
        /// <summary>
        /// Specify the project from which to fetch the GitLab merge requests.
        /// </summary>
        public readonly Outputs.ApplicationSetSpecGeneratorMergeGeneratorMatrixGeneratorPullRequestGitlab? Gitlab;
        /// <summary>
        /// How often to check for changes (in seconds). Default: 3min.
        /// </summary>
        public readonly string? RequeueAfterSeconds;
        /// <summary>
        /// Generator template. Used to override the values of the spec-level template.
        /// </summary>
        public readonly Outputs.ApplicationSetSpecGeneratorMergeGeneratorMatrixGeneratorPullRequestTemplate? Template;

        [OutputConstructor]
        private ApplicationSetSpecGeneratorMergeGeneratorMatrixGeneratorPullRequest(
            Outputs.ApplicationSetSpecGeneratorMergeGeneratorMatrixGeneratorPullRequestBitbucketServer? bitbucketServer,

            ImmutableArray<Outputs.ApplicationSetSpecGeneratorMergeGeneratorMatrixGeneratorPullRequestFilter> filters,

            Outputs.ApplicationSetSpecGeneratorMergeGeneratorMatrixGeneratorPullRequestGitea? gitea,

            Outputs.ApplicationSetSpecGeneratorMergeGeneratorMatrixGeneratorPullRequestGithub? github,

            Outputs.ApplicationSetSpecGeneratorMergeGeneratorMatrixGeneratorPullRequestGitlab? gitlab,

            string? requeueAfterSeconds,

            Outputs.ApplicationSetSpecGeneratorMergeGeneratorMatrixGeneratorPullRequestTemplate? template)
        {
            BitbucketServer = bitbucketServer;
            Filters = filters;
            Gitea = gitea;
            Github = github;
            Gitlab = gitlab;
            RequeueAfterSeconds = requeueAfterSeconds;
            Template = template;
        }
    }
}