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
    public sealed class ApplicationSetSpecGeneratorMatrixGeneratorPullRequestTemplate
    {
        /// <summary>
        /// Kubernetes object metadata for templated Application.
        /// </summary>
        public readonly Outputs.ApplicationSetSpecGeneratorMatrixGeneratorPullRequestTemplateMetadata? Metadata;
        /// <summary>
        /// The application specification.
        /// </summary>
        public readonly Outputs.ApplicationSetSpecGeneratorMatrixGeneratorPullRequestTemplateSpec? Spec;

        [OutputConstructor]
        private ApplicationSetSpecGeneratorMatrixGeneratorPullRequestTemplate(
            Outputs.ApplicationSetSpecGeneratorMatrixGeneratorPullRequestTemplateMetadata? metadata,

            Outputs.ApplicationSetSpecGeneratorMatrixGeneratorPullRequestTemplateSpec? spec)
        {
            Metadata = metadata;
            Spec = spec;
        }
    }
}