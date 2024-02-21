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
    public sealed class ApplicationSetSpecGeneratorMergeGeneratorListTemplateSpec
    {
        /// <summary>
        /// Reference to the Kubernetes server and namespace in which the application will be deployed.
        /// </summary>
        public readonly Outputs.ApplicationSetSpecGeneratorMergeGeneratorListTemplateSpecDestination? Destination;
        /// <summary>
        /// Resources and their fields which should be ignored during comparison. More info: https://argo-cd.readthedocs.io/en/stable/user-guide/diffing/#application-level-configuration.
        /// </summary>
        public readonly ImmutableArray<Outputs.ApplicationSetSpecGeneratorMergeGeneratorListTemplateSpecIgnoreDifference> IgnoreDifferences;
        /// <summary>
        /// List of information (URLs, email addresses, and plain text) that relates to the application.
        /// </summary>
        public readonly ImmutableArray<Outputs.ApplicationSetSpecGeneratorMergeGeneratorListTemplateSpecInfo> Infos;
        /// <summary>
        /// The project the application belongs to. Defaults to `default`.
        /// </summary>
        public readonly string? Project;
        /// <summary>
        /// Limits the number of items kept in the application's revision history, which is used for informational purposes as well as for rollbacks to previous versions. This should only be changed in exceptional circumstances. Setting to zero will store no history. This will reduce storage used. Increasing will increase the space used to store the history, so we do not recommend increasing it. Default is 10.
        /// </summary>
        public readonly int? RevisionHistoryLimit;
        /// <summary>
        /// Location of the application's manifests or chart.
        /// </summary>
        public readonly ImmutableArray<Outputs.ApplicationSetSpecGeneratorMergeGeneratorListTemplateSpecSource> Sources;
        /// <summary>
        /// Application Set [sync policy](https://argo-cd.readthedocs.io/en/stable/operator-manual/applicationset/Controlling-Resource-Modification/).
        /// </summary>
        public readonly Outputs.ApplicationSetSpecGeneratorMergeGeneratorListTemplateSpecSyncPolicy? SyncPolicy;

        [OutputConstructor]
        private ApplicationSetSpecGeneratorMergeGeneratorListTemplateSpec(
            Outputs.ApplicationSetSpecGeneratorMergeGeneratorListTemplateSpecDestination? destination,

            ImmutableArray<Outputs.ApplicationSetSpecGeneratorMergeGeneratorListTemplateSpecIgnoreDifference> ignoreDifferences,

            ImmutableArray<Outputs.ApplicationSetSpecGeneratorMergeGeneratorListTemplateSpecInfo> infos,

            string? project,

            int? revisionHistoryLimit,

            ImmutableArray<Outputs.ApplicationSetSpecGeneratorMergeGeneratorListTemplateSpecSource> sources,

            Outputs.ApplicationSetSpecGeneratorMergeGeneratorListTemplateSpecSyncPolicy? syncPolicy)
        {
            Destination = destination;
            IgnoreDifferences = ignoreDifferences;
            Infos = infos;
            Project = project;
            RevisionHistoryLimit = revisionHistoryLimit;
            Sources = sources;
            SyncPolicy = syncPolicy;
        }
    }
}