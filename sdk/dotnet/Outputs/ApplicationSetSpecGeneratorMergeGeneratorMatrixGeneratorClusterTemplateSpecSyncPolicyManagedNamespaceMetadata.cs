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
    public sealed class ApplicationSetSpecGeneratorMergeGeneratorMatrixGeneratorClusterTemplateSpecSyncPolicyManagedNamespaceMetadata
    {
        /// <summary>
        /// An unstructured key value map stored with the applicationsets.argoproj.io that may be used to store arbitrary metadata. More info: http://kubernetes.io/docs/user-guide/annotations
        /// </summary>
        public readonly ImmutableDictionary<string, string>? Annotations;
        /// <summary>
        /// Map of string keys and values that can be used to organize and categorize (scope and select) the applicationsets.argoproj.io. May match selectors of replication controllers and services. More info: http://kubernetes.io/docs/user-guide/labels
        /// </summary>
        public readonly ImmutableDictionary<string, string>? Labels;

        [OutputConstructor]
        private ApplicationSetSpecGeneratorMergeGeneratorMatrixGeneratorClusterTemplateSpecSyncPolicyManagedNamespaceMetadata(
            ImmutableDictionary<string, string>? annotations,

            ImmutableDictionary<string, string>? labels)
        {
            Annotations = annotations;
            Labels = labels;
        }
    }
}
