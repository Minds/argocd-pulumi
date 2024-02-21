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
    public sealed class ApplicationSetSpecSyncPolicy
    {
        /// <summary>
        /// Represents the policy applied on the generated applications. Possible values are create-only, create-update, create-delete, and sync.
        /// </summary>
        public readonly string? ApplicationsSync;
        /// <summary>
        /// Label selector used to narrow the scope of targeted clusters.
        /// </summary>
        public readonly bool? PreserveResourcesOnDeletion;

        [OutputConstructor]
        private ApplicationSetSpecSyncPolicy(
            string? applicationsSync,

            bool? preserveResourcesOnDeletion)
        {
            ApplicationsSync = applicationsSync;
            PreserveResourcesOnDeletion = preserveResourcesOnDeletion;
        }
    }
}