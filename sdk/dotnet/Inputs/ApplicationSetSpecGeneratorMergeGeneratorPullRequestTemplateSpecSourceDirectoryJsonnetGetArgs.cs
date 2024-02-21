// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Argocd.Inputs
{

    public sealed class ApplicationSetSpecGeneratorMergeGeneratorPullRequestTemplateSpecSourceDirectoryJsonnetGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("extVars")]
        private InputList<Inputs.ApplicationSetSpecGeneratorMergeGeneratorPullRequestTemplateSpecSourceDirectoryJsonnetExtVarGetArgs>? _extVars;

        /// <summary>
        /// List of Jsonnet External Variables.
        /// </summary>
        public InputList<Inputs.ApplicationSetSpecGeneratorMergeGeneratorPullRequestTemplateSpecSourceDirectoryJsonnetExtVarGetArgs> ExtVars
        {
            get => _extVars ?? (_extVars = new InputList<Inputs.ApplicationSetSpecGeneratorMergeGeneratorPullRequestTemplateSpecSourceDirectoryJsonnetExtVarGetArgs>());
            set => _extVars = value;
        }

        [Input("libs")]
        private InputList<string>? _libs;

        /// <summary>
        /// Additional library search dirs.
        /// </summary>
        public InputList<string> Libs
        {
            get => _libs ?? (_libs = new InputList<string>());
            set => _libs = value;
        }

        [Input("tlas")]
        private InputList<Inputs.ApplicationSetSpecGeneratorMergeGeneratorPullRequestTemplateSpecSourceDirectoryJsonnetTlaGetArgs>? _tlas;

        /// <summary>
        /// List of Jsonnet Top-level Arguments
        /// </summary>
        public InputList<Inputs.ApplicationSetSpecGeneratorMergeGeneratorPullRequestTemplateSpecSourceDirectoryJsonnetTlaGetArgs> Tlas
        {
            get => _tlas ?? (_tlas = new InputList<Inputs.ApplicationSetSpecGeneratorMergeGeneratorPullRequestTemplateSpecSourceDirectoryJsonnetTlaGetArgs>());
            set => _tlas = value;
        }

        public ApplicationSetSpecGeneratorMergeGeneratorPullRequestTemplateSpecSourceDirectoryJsonnetGetArgs()
        {
        }
        public static new ApplicationSetSpecGeneratorMergeGeneratorPullRequestTemplateSpecSourceDirectoryJsonnetGetArgs Empty => new ApplicationSetSpecGeneratorMergeGeneratorPullRequestTemplateSpecSourceDirectoryJsonnetGetArgs();
    }
}