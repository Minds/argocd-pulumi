// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Argocd.Inputs
{

    public sealed class ApplicationSetSpecGeneratorMatrixGeneratorMatrixGeneratorGitTemplateMetadataGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("annotations")]
        private InputMap<string>? _annotations;

        /// <summary>
        /// An unstructured key value map stored with the applicationsets.argoproj.io that may be used to store arbitrary metadata. More info: http://kubernetes.io/docs/user-guide/annotations
        /// </summary>
        public InputMap<string> Annotations
        {
            get => _annotations ?? (_annotations = new InputMap<string>());
            set => _annotations = value;
        }

        [Input("finalizers")]
        private InputList<string>? _finalizers;

        /// <summary>
        /// List of finalizers to apply to the resulting Application.
        /// </summary>
        public InputList<string> Finalizers
        {
            get => _finalizers ?? (_finalizers = new InputList<string>());
            set => _finalizers = value;
        }

        [Input("labels")]
        private InputMap<string>? _labels;

        /// <summary>
        /// Map of string keys and values that can be used to organize and categorize (scope and select) the applicationsets.argoproj.io. May match selectors of replication controllers and services. More info: http://kubernetes.io/docs/user-guide/labels
        /// </summary>
        public InputMap<string> Labels
        {
            get => _labels ?? (_labels = new InputMap<string>());
            set => _labels = value;
        }

        /// <summary>
        /// Name of the applicationsets.argoproj.io, must be unique. Cannot be updated. More info: http://kubernetes.io/docs/user-guide/identifiers#names
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// Namespace of the applicationsets.argoproj.io, must be unique. Cannot be updated. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/
        /// </summary>
        [Input("namespace")]
        public Input<string>? Namespace { get; set; }

        public ApplicationSetSpecGeneratorMatrixGeneratorMatrixGeneratorGitTemplateMetadataGetArgs()
        {
        }
        public static new ApplicationSetSpecGeneratorMatrixGeneratorMatrixGeneratorGitTemplateMetadataGetArgs Empty => new ApplicationSetSpecGeneratorMatrixGeneratorMatrixGeneratorGitTemplateMetadataGetArgs();
    }
}
