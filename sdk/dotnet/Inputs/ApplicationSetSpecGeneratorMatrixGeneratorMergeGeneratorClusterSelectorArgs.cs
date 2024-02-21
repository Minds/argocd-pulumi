// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Argocd.Inputs
{

    public sealed class ApplicationSetSpecGeneratorMatrixGeneratorMergeGeneratorClusterSelectorArgs : global::Pulumi.ResourceArgs
    {
        [Input("matchExpressions")]
        private InputList<Inputs.ApplicationSetSpecGeneratorMatrixGeneratorMergeGeneratorClusterSelectorMatchExpressionArgs>? _matchExpressions;

        /// <summary>
        /// A list of label selector requirements. The requirements are ANDed.
        /// </summary>
        public InputList<Inputs.ApplicationSetSpecGeneratorMatrixGeneratorMergeGeneratorClusterSelectorMatchExpressionArgs> MatchExpressions
        {
            get => _matchExpressions ?? (_matchExpressions = new InputList<Inputs.ApplicationSetSpecGeneratorMatrixGeneratorMergeGeneratorClusterSelectorMatchExpressionArgs>());
            set => _matchExpressions = value;
        }

        [Input("matchLabels")]
        private InputMap<object>? _matchLabels;

        /// <summary>
        /// A map of {key,value} pairs. A single {key,value} in the matchLabels map is equivalent to an element of `match_expressions`, whose key field is "key", the operator is "In", and the values array contains only "value". The requirements are ANDed.
        /// </summary>
        public InputMap<object> MatchLabels
        {
            get => _matchLabels ?? (_matchLabels = new InputMap<object>());
            set => _matchLabels = value;
        }

        public ApplicationSetSpecGeneratorMatrixGeneratorMergeGeneratorClusterSelectorArgs()
        {
        }
        public static new ApplicationSetSpecGeneratorMatrixGeneratorMergeGeneratorClusterSelectorArgs Empty => new ApplicationSetSpecGeneratorMatrixGeneratorMergeGeneratorClusterSelectorArgs();
    }
}