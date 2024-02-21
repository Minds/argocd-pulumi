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
    public sealed class ApplicationStatusSync
    {
        /// <summary>
        /// Information about the revision the comparison has been performed to.
        /// </summary>
        public readonly string? Revision;
        /// <summary>
        /// Information about the revision(s) the comparison has been performed to.
        /// </summary>
        public readonly ImmutableArray<object> Revisions;
        /// <summary>
        /// Sync state of the comparison.
        /// </summary>
        public readonly string? Status;

        [OutputConstructor]
        private ApplicationStatusSync(
            string? revision,

            ImmutableArray<object> revisions,

            string? status)
        {
            Revision = revision;
            Revisions = revisions;
            Status = status;
        }
    }
}