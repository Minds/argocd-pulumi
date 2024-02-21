// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Argocd.Inputs
{

    public sealed class ApplicationSetSpecGeneratorClusterSelectorMatchExpressionArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The label key that the selector applies to.
        /// </summary>
        [Input("key")]
        public Input<string>? Key { get; set; }

        /// <summary>
        /// A key's relationship to a set of values. Valid operators ard `In`, `NotIn`, `Exists` and `DoesNotExist`.
        /// </summary>
        [Input("operator")]
        public Input<string>? Operator { get; set; }

        [Input("values")]
        private InputList<string>? _values;

        /// <summary>
        /// An array of string values. If the operator is `In` or `NotIn`, the values array must be non-empty. If the operator is `Exists` or `DoesNotExist`, the values array must be empty. This array is replaced during a strategic merge patch.
        /// </summary>
        public InputList<string> Values
        {
            get => _values ?? (_values = new InputList<string>());
            set => _values = value;
        }

        public ApplicationSetSpecGeneratorClusterSelectorMatchExpressionArgs()
        {
        }
        public static new ApplicationSetSpecGeneratorClusterSelectorMatchExpressionArgs Empty => new ApplicationSetSpecGeneratorClusterSelectorMatchExpressionArgs();
    }
}