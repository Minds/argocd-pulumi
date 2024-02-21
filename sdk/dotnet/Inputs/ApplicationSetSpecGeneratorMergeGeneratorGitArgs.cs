// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Argocd.Inputs
{

    public sealed class ApplicationSetSpecGeneratorMergeGeneratorGitArgs : global::Pulumi.ResourceArgs
    {
        [Input("directories")]
        private InputList<Inputs.ApplicationSetSpecGeneratorMergeGeneratorGitDirectoryArgs>? _directories;

        /// <summary>
        /// Path/directory specific options.
        /// </summary>
        public InputList<Inputs.ApplicationSetSpecGeneratorMergeGeneratorGitDirectoryArgs> Directories
        {
            get => _directories ?? (_directories = new InputList<Inputs.ApplicationSetSpecGeneratorMergeGeneratorGitDirectoryArgs>());
            set => _directories = value;
        }

        [Input("files")]
        private InputList<Inputs.ApplicationSetSpecGeneratorMergeGeneratorGitFileArgs>? _files;

        /// <summary>
        /// List of files in the source repository to use when template the Application.
        /// </summary>
        public InputList<Inputs.ApplicationSetSpecGeneratorMergeGeneratorGitFileArgs> Files
        {
            get => _files ?? (_files = new InputList<Inputs.ApplicationSetSpecGeneratorMergeGeneratorGitFileArgs>());
            set => _files = value;
        }

        /// <summary>
        /// Prefix for all path-related parameter names.
        /// </summary>
        [Input("pathParamPrefix")]
        public Input<string>? PathParamPrefix { get; set; }

        /// <summary>
        /// URL to the repository (Git or Helm) that contains the application manifests.
        /// </summary>
        [Input("repoUrl", required: true)]
        public Input<string> RepoUrl { get; set; } = null!;

        /// <summary>
        /// Revision of the source repository to use.
        /// </summary>
        [Input("revision")]
        public Input<string>? Revision { get; set; }

        /// <summary>
        /// Generator template. Used to override the values of the spec-level template.
        /// </summary>
        [Input("template")]
        public Input<Inputs.ApplicationSetSpecGeneratorMergeGeneratorGitTemplateArgs>? Template { get; set; }

        public ApplicationSetSpecGeneratorMergeGeneratorGitArgs()
        {
        }
        public static new ApplicationSetSpecGeneratorMergeGeneratorGitArgs Empty => new ApplicationSetSpecGeneratorMergeGeneratorGitArgs();
    }
}