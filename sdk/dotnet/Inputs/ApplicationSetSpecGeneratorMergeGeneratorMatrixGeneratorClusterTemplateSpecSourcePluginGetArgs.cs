// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Argocd.Inputs
{

    public sealed class ApplicationSetSpecGeneratorMergeGeneratorMatrixGeneratorClusterTemplateSpecSourcePluginGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("envs")]
        private InputList<Inputs.ApplicationSetSpecGeneratorMergeGeneratorMatrixGeneratorClusterTemplateSpecSourcePluginEnvGetArgs>? _envs;

        /// <summary>
        /// Environment variables passed to the plugin.
        /// </summary>
        public InputList<Inputs.ApplicationSetSpecGeneratorMergeGeneratorMatrixGeneratorClusterTemplateSpecSourcePluginEnvGetArgs> Envs
        {
            get => _envs ?? (_envs = new InputList<Inputs.ApplicationSetSpecGeneratorMergeGeneratorMatrixGeneratorClusterTemplateSpecSourcePluginEnvGetArgs>());
            set => _envs = value;
        }

        /// <summary>
        /// Name of the applicationsets.argoproj.io, must be unique. Cannot be updated. More info: http://kubernetes.io/docs/user-guide/identifiers#names
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        public ApplicationSetSpecGeneratorMergeGeneratorMatrixGeneratorClusterTemplateSpecSourcePluginGetArgs()
        {
        }
        public static new ApplicationSetSpecGeneratorMergeGeneratorMatrixGeneratorClusterTemplateSpecSourcePluginGetArgs Empty => new ApplicationSetSpecGeneratorMergeGeneratorMatrixGeneratorClusterTemplateSpecSourcePluginGetArgs();
    }
}
