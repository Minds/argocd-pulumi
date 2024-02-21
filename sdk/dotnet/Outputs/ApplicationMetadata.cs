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
    public sealed class ApplicationMetadata
    {
        /// <summary>
        /// An unstructured key value map stored with the applications.argoproj.io that may be used to store arbitrary metadata. More info: http://kubernetes.io/docs/user-guide/annotations
        /// </summary>
        public readonly ImmutableDictionary<string, string>? Annotations;
        /// <summary>
        /// A sequence number representing a specific generation of the desired state.
        /// </summary>
        public readonly int? Generation;
        /// <summary>
        /// Map of string keys and values that can be used to organize and categorize (scope and select) the applications.argoproj.io. May match selectors of replication controllers and services. More info: http://kubernetes.io/docs/user-guide/labels
        /// </summary>
        public readonly ImmutableDictionary<string, string>? Labels;
        /// <summary>
        /// Name of the applications.argoproj.io, must be unique. Cannot be updated. More info: http://kubernetes.io/docs/user-guide/identifiers#names
        /// </summary>
        public readonly string? Name;
        /// <summary>
        /// Namespace of the applications.argoproj.io, must be unique. Cannot be updated. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/
        /// </summary>
        public readonly string? Namespace;
        /// <summary>
        /// An opaque value that represents the internal version of this applications.argoproj.io that can be used by clients to determine when applications.argoproj.io has changed. Read more: https://github.com/kubernetes/community/blob/master/contributors/devel/sig-architecture/api-conventions.md#concurrency-control-and-consistency
        /// </summary>
        public readonly string? ResourceVersion;
        /// <summary>
        /// The unique in time and space value for this applications.argoproj.io. More info: http://kubernetes.io/docs/user-guide/identifiers#uids
        /// </summary>
        public readonly string? Uid;

        [OutputConstructor]
        private ApplicationMetadata(
            ImmutableDictionary<string, string>? annotations,

            int? generation,

            ImmutableDictionary<string, string>? labels,

            string? name,

            string? @namespace,

            string? resourceVersion,

            string? uid)
        {
            Annotations = annotations;
            Generation = generation;
            Labels = labels;
            Name = name;
            Namespace = @namespace;
            ResourceVersion = resourceVersion;
            Uid = uid;
        }
    }
}