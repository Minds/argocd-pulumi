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
    public sealed class ApplicationSetSpecGeneratorMatrixGeneratorMergeGeneratorClusterDecisionResourceTemplateSpecSourceDirectoryJsonnet
    {
        /// <summary>
        /// List of Jsonnet External Variables.
        /// </summary>
        public readonly ImmutableArray<Outputs.ApplicationSetSpecGeneratorMatrixGeneratorMergeGeneratorClusterDecisionResourceTemplateSpecSourceDirectoryJsonnetExtVar> ExtVars;
        /// <summary>
        /// Additional library search dirs.
        /// </summary>
        public readonly ImmutableArray<string> Libs;
        /// <summary>
        /// List of Jsonnet Top-level Arguments
        /// </summary>
        public readonly ImmutableArray<Outputs.ApplicationSetSpecGeneratorMatrixGeneratorMergeGeneratorClusterDecisionResourceTemplateSpecSourceDirectoryJsonnetTla> Tlas;

        [OutputConstructor]
        private ApplicationSetSpecGeneratorMatrixGeneratorMergeGeneratorClusterDecisionResourceTemplateSpecSourceDirectoryJsonnet(
            ImmutableArray<Outputs.ApplicationSetSpecGeneratorMatrixGeneratorMergeGeneratorClusterDecisionResourceTemplateSpecSourceDirectoryJsonnetExtVar> extVars,

            ImmutableArray<string> libs,

            ImmutableArray<Outputs.ApplicationSetSpecGeneratorMatrixGeneratorMergeGeneratorClusterDecisionResourceTemplateSpecSourceDirectoryJsonnetTla> tlas)
        {
            ExtVars = extVars;
            Libs = libs;
            Tlas = tlas;
        }
    }
}