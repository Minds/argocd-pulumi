// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Argocd.Inputs
{

    public sealed class ApplicationSetSpecGeneratorMergeGeneratorMatrixGeneratorGitTemplateSpecSourceDirectoryJsonnetGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("extVars")]
        private InputList<Inputs.ApplicationSetSpecGeneratorMergeGeneratorMatrixGeneratorGitTemplateSpecSourceDirectoryJsonnetExtVarGetArgs>? _extVars;

        /// <summary>
        /// List of Jsonnet External Variables.
        /// </summary>
        public InputList<Inputs.ApplicationSetSpecGeneratorMergeGeneratorMatrixGeneratorGitTemplateSpecSourceDirectoryJsonnetExtVarGetArgs> ExtVars
        {
            get => _extVars ?? (_extVars = new InputList<Inputs.ApplicationSetSpecGeneratorMergeGeneratorMatrixGeneratorGitTemplateSpecSourceDirectoryJsonnetExtVarGetArgs>());
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
        private InputList<Inputs.ApplicationSetSpecGeneratorMergeGeneratorMatrixGeneratorGitTemplateSpecSourceDirectoryJsonnetTlaGetArgs>? _tlas;

        /// <summary>
        /// List of Jsonnet Top-level Arguments
        /// </summary>
        public InputList<Inputs.ApplicationSetSpecGeneratorMergeGeneratorMatrixGeneratorGitTemplateSpecSourceDirectoryJsonnetTlaGetArgs> Tlas
        {
            get => _tlas ?? (_tlas = new InputList<Inputs.ApplicationSetSpecGeneratorMergeGeneratorMatrixGeneratorGitTemplateSpecSourceDirectoryJsonnetTlaGetArgs>());
            set => _tlas = value;
        }

        public ApplicationSetSpecGeneratorMergeGeneratorMatrixGeneratorGitTemplateSpecSourceDirectoryJsonnetGetArgs()
        {
        }
        public static new ApplicationSetSpecGeneratorMergeGeneratorMatrixGeneratorGitTemplateSpecSourceDirectoryJsonnetGetArgs Empty => new ApplicationSetSpecGeneratorMergeGeneratorMatrixGeneratorGitTemplateSpecSourceDirectoryJsonnetGetArgs();
    }
}