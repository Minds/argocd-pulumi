// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Argocd.Inputs
{

    public sealed class ApplicationSetSpecGeneratorMergeGeneratorMergeGeneratorScmProviderTemplateArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Kubernetes object metadata for templated Application.
        /// </summary>
        [Input("metadata")]
        public Input<Inputs.ApplicationSetSpecGeneratorMergeGeneratorMergeGeneratorScmProviderTemplateMetadataArgs>? Metadata { get; set; }

        /// <summary>
        /// The application specification.
        /// </summary>
        [Input("spec")]
        public Input<Inputs.ApplicationSetSpecGeneratorMergeGeneratorMergeGeneratorScmProviderTemplateSpecArgs>? Spec { get; set; }

        public ApplicationSetSpecGeneratorMergeGeneratorMergeGeneratorScmProviderTemplateArgs()
        {
        }
        public static new ApplicationSetSpecGeneratorMergeGeneratorMergeGeneratorScmProviderTemplateArgs Empty => new ApplicationSetSpecGeneratorMergeGeneratorMergeGeneratorScmProviderTemplateArgs();
    }
}