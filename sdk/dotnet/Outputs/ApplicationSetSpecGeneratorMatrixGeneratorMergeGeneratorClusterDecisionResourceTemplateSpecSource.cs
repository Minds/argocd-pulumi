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
    public sealed class ApplicationSetSpecGeneratorMatrixGeneratorMergeGeneratorClusterDecisionResourceTemplateSpecSource
    {
        /// <summary>
        /// Helm chart name. Must be specified for applications sourced from a Helm repo.
        /// </summary>
        public readonly string? Chart;
        /// <summary>
        /// Path/directory specific options.
        /// </summary>
        public readonly Outputs.ApplicationSetSpecGeneratorMatrixGeneratorMergeGeneratorClusterDecisionResourceTemplateSpecSourceDirectory? Directory;
        /// <summary>
        /// Helm specific options.
        /// </summary>
        public readonly Outputs.ApplicationSetSpecGeneratorMatrixGeneratorMergeGeneratorClusterDecisionResourceTemplateSpecSourceHelm? Helm;
        /// <summary>
        /// Kustomize specific options.
        /// </summary>
        public readonly Outputs.ApplicationSetSpecGeneratorMatrixGeneratorMergeGeneratorClusterDecisionResourceTemplateSpecSourceKustomize? Kustomize;
        /// <summary>
        /// Path to the file containing the values for the Helm parameter.
        /// </summary>
        public readonly string? Path;
        /// <summary>
        /// Config management plugin specific options.
        /// </summary>
        public readonly Outputs.ApplicationSetSpecGeneratorMatrixGeneratorMergeGeneratorClusterDecisionResourceTemplateSpecSourcePlugin? Plugin;
        /// <summary>
        /// Reference to another `source` within defined sources. See associated documentation on [Helm value files from external Git repository](https://argo-cd.readthedocs.io/en/stable/user-guide/multiple_sources/#helm-value-files-from-external-git-repository) regarding combining `ref` with `path` and/or `chart`.
        /// </summary>
        public readonly string? Ref;
        /// <summary>
        /// URL to the repository (Git or Helm) that contains the application manifests.
        /// </summary>
        public readonly string? RepoUrl;
        /// <summary>
        /// Revision of the source to sync the application to. In case of Git, this can be commit, tag, or branch. If omitted, will equal to HEAD. In case of Helm, this is a semver tag for the Chart's version.
        /// </summary>
        public readonly string? TargetRevision;

        [OutputConstructor]
        private ApplicationSetSpecGeneratorMatrixGeneratorMergeGeneratorClusterDecisionResourceTemplateSpecSource(
            string? chart,

            Outputs.ApplicationSetSpecGeneratorMatrixGeneratorMergeGeneratorClusterDecisionResourceTemplateSpecSourceDirectory? directory,

            Outputs.ApplicationSetSpecGeneratorMatrixGeneratorMergeGeneratorClusterDecisionResourceTemplateSpecSourceHelm? helm,

            Outputs.ApplicationSetSpecGeneratorMatrixGeneratorMergeGeneratorClusterDecisionResourceTemplateSpecSourceKustomize? kustomize,

            string? path,

            Outputs.ApplicationSetSpecGeneratorMatrixGeneratorMergeGeneratorClusterDecisionResourceTemplateSpecSourcePlugin? plugin,

            string? @ref,

            string? repoUrl,

            string? targetRevision)
        {
            Chart = chart;
            Directory = directory;
            Helm = helm;
            Kustomize = kustomize;
            Path = path;
            Plugin = plugin;
            Ref = @ref;
            RepoUrl = repoUrl;
            TargetRevision = targetRevision;
        }
    }
}