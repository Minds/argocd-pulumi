// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Argocd.Inputs
{

    public sealed class ApplicationSetSpecGeneratorMatrixGeneratorMatrixGeneratorGitTemplateArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Kubernetes object metadata for templated Application.
        /// </summary>
        [Input("metadata")]
        public Input<Inputs.ApplicationSetSpecGeneratorMatrixGeneratorMatrixGeneratorGitTemplateMetadataArgs>? Metadata { get; set; }

        /// <summary>
        /// The application specification.
        /// </summary>
        [Input("spec")]
        public Input<Inputs.ApplicationSetSpecGeneratorMatrixGeneratorMatrixGeneratorGitTemplateSpecArgs>? Spec { get; set; }

        public ApplicationSetSpecGeneratorMatrixGeneratorMatrixGeneratorGitTemplateArgs()
        {
        }
        public static new ApplicationSetSpecGeneratorMatrixGeneratorMatrixGeneratorGitTemplateArgs Empty => new ApplicationSetSpecGeneratorMatrixGeneratorMatrixGeneratorGitTemplateArgs();
    }
}