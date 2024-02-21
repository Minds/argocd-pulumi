// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Argocd.Inputs
{

    public sealed class ApplicationSetSpecTemplateSpecSyncPolicyGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Whether to automatically keep an application synced to the target revision.
        /// </summary>
        [Input("automated")]
        public Input<Inputs.ApplicationSetSpecTemplateSpecSyncPolicyAutomatedGetArgs>? Automated { get; set; }

        /// <summary>
        /// Controls metadata in the given namespace (if `CreateNamespace=true`).
        /// </summary>
        [Input("managedNamespaceMetadata")]
        public Input<Inputs.ApplicationSetSpecTemplateSpecSyncPolicyManagedNamespaceMetadataGetArgs>? ManagedNamespaceMetadata { get; set; }

        /// <summary>
        /// Controls failed sync retry behavior.
        /// </summary>
        [Input("retry")]
        public Input<Inputs.ApplicationSetSpecTemplateSpecSyncPolicyRetryGetArgs>? Retry { get; set; }

        [Input("syncOptions")]
        private InputList<string>? _syncOptions;

        /// <summary>
        /// List of sync options. More info: https://argo-cd.readthedocs.io/en/stable/user-guide/sync-options/.
        /// </summary>
        public InputList<string> SyncOptions
        {
            get => _syncOptions ?? (_syncOptions = new InputList<string>());
            set => _syncOptions = value;
        }

        public ApplicationSetSpecTemplateSpecSyncPolicyGetArgs()
        {
        }
        public static new ApplicationSetSpecTemplateSpecSyncPolicyGetArgs Empty => new ApplicationSetSpecTemplateSpecSyncPolicyGetArgs();
    }
}