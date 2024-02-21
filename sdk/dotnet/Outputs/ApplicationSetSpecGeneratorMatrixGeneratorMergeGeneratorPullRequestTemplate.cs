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
    public sealed class ApplicationSetSpecGeneratorMatrixGeneratorMergeGeneratorPullRequestTemplate
    {
        /// <summary>
        /// Kubernetes object metadata for templated Application.
        /// </summary>
        public readonly Outputs.ApplicationSetSpecGeneratorMatrixGeneratorMergeGeneratorPullRequestTemplateMetadata? Metadata;
        /// <summary>
        /// The application specification.
        /// </summary>
        public readonly Outputs.ApplicationSetSpecGeneratorMatrixGeneratorMergeGeneratorPullRequestTemplateSpec? Spec;

        [OutputConstructor]
        private ApplicationSetSpecGeneratorMatrixGeneratorMergeGeneratorPullRequestTemplate(
            Outputs.ApplicationSetSpecGeneratorMatrixGeneratorMergeGeneratorPullRequestTemplateMetadata? metadata,

            Outputs.ApplicationSetSpecGeneratorMatrixGeneratorMergeGeneratorPullRequestTemplateSpec? spec)
        {
            Metadata = metadata;
            Spec = spec;
        }
    }
}