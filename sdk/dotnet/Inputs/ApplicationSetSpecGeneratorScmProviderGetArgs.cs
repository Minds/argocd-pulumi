// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Argocd.Inputs
{

    public sealed class ApplicationSetSpecGeneratorScmProviderGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Uses the Azure DevOps API to look up eligible repositories based on a team project within an Azure DevOps organization.
        /// </summary>
        [Input("azureDevops")]
        public Input<Inputs.ApplicationSetSpecGeneratorScmProviderAzureDevopsGetArgs>? AzureDevops { get; set; }

        /// <summary>
        /// Uses the Bitbucket API V2 to scan a workspace in bitbucket.org.
        /// </summary>
        [Input("bitbucketCloud")]
        public Input<Inputs.ApplicationSetSpecGeneratorScmProviderBitbucketCloudGetArgs>? BitbucketCloud { get; set; }

        /// <summary>
        /// Fetch pull requests from a repo hosted on a Bitbucket Server.
        /// </summary>
        [Input("bitbucketServer")]
        public Input<Inputs.ApplicationSetSpecGeneratorScmProviderBitbucketServerGetArgs>? BitbucketServer { get; set; }

        /// <summary>
        /// Which protocol to use for the SCM URL. Default is provider-specific but ssh if possible. Not all providers necessarily support all protocols.
        /// </summary>
        [Input("cloneProtocol")]
        public Input<string>? CloneProtocol { get; set; }

        [Input("filters")]
        private InputList<Inputs.ApplicationSetSpecGeneratorScmProviderFilterGetArgs>? _filters;

        /// <summary>
        /// Filters allow selecting which pull requests to generate for.
        /// </summary>
        public InputList<Inputs.ApplicationSetSpecGeneratorScmProviderFilterGetArgs> Filters
        {
            get => _filters ?? (_filters = new InputList<Inputs.ApplicationSetSpecGeneratorScmProviderFilterGetArgs>());
            set => _filters = value;
        }

        /// <summary>
        /// Specify the repository from which to fetch the Gitea Pull requests.
        /// </summary>
        [Input("gitea")]
        public Input<Inputs.ApplicationSetSpecGeneratorScmProviderGiteaGetArgs>? Gitea { get; set; }

        /// <summary>
        /// Specify the repository from which to fetch the GitHub Pull requests.
        /// </summary>
        [Input("github")]
        public Input<Inputs.ApplicationSetSpecGeneratorScmProviderGithubGetArgs>? Github { get; set; }

        /// <summary>
        /// Specify the project from which to fetch the GitLab merge requests.
        /// </summary>
        [Input("gitlab")]
        public Input<Inputs.ApplicationSetSpecGeneratorScmProviderGitlabGetArgs>? Gitlab { get; set; }

        /// <summary>
        /// How often to check for changes (in seconds). Default: 3min.
        /// </summary>
        [Input("requeueAfterSeconds")]
        public Input<string>? RequeueAfterSeconds { get; set; }

        /// <summary>
        /// Generator template. Used to override the values of the spec-level template.
        /// </summary>
        [Input("template")]
        public Input<Inputs.ApplicationSetSpecGeneratorScmProviderTemplateGetArgs>? Template { get; set; }

        public ApplicationSetSpecGeneratorScmProviderGetArgs()
        {
        }
        public static new ApplicationSetSpecGeneratorScmProviderGetArgs Empty => new ApplicationSetSpecGeneratorScmProviderGetArgs();
    }
}