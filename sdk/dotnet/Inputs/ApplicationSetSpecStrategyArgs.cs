// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Argocd.Inputs
{

    public sealed class ApplicationSetSpecStrategyArgs : global::Pulumi.ResourceArgs
    {
        [Input("rollingSyncs")]
        private InputList<Inputs.ApplicationSetSpecStrategyRollingSyncArgs>? _rollingSyncs;

        /// <summary>
        /// Update strategy allowing you to group Applications by labels present on the generated Application resources. When the ApplicationSet changes, the changes will be applied to each group of Application resources sequentially.
        /// </summary>
        public InputList<Inputs.ApplicationSetSpecStrategyRollingSyncArgs> RollingSyncs
        {
            get => _rollingSyncs ?? (_rollingSyncs = new InputList<Inputs.ApplicationSetSpecStrategyRollingSyncArgs>());
            set => _rollingSyncs = value;
        }

        /// <summary>
        /// Type of progressive sync.
        /// </summary>
        [Input("type", required: true)]
        public Input<string> Type { get; set; } = null!;

        public ApplicationSetSpecStrategyArgs()
        {
        }
        public static new ApplicationSetSpecStrategyArgs Empty => new ApplicationSetSpecStrategyArgs();
    }
}