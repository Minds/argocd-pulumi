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
    public sealed class ApplicationSetSpecGeneratorMergeGeneratorScmProviderFilter
    {
        /// <summary>
        /// A regex which must match the branch name.
        /// </summary>
        public readonly string? BranchMatch;
        /// <summary>
        /// A regex which must match at least one label.
        /// </summary>
        public readonly string? LabelMatch;
        /// <summary>
        /// An array of paths, all of which must not exist.
        /// </summary>
        public readonly ImmutableArray<string> PathsDoNotExists;
        /// <summary>
        /// An array of paths, all of which must exist.
        /// </summary>
        public readonly ImmutableArray<string> PathsExists;
        /// <summary>
        /// A regex for repo names.
        /// </summary>
        public readonly string? RepositoryMatch;

        [OutputConstructor]
        private ApplicationSetSpecGeneratorMergeGeneratorScmProviderFilter(
            string? branchMatch,

            string? labelMatch,

            ImmutableArray<string> pathsDoNotExists,

            ImmutableArray<string> pathsExists,

            string? repositoryMatch)
        {
            BranchMatch = branchMatch;
            LabelMatch = labelMatch;
            PathsDoNotExists = pathsDoNotExists;
            PathsExists = pathsExists;
            RepositoryMatch = repositoryMatch;
        }
    }
}