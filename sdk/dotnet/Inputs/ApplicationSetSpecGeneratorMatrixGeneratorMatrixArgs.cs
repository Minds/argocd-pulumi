// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Argocd.Inputs
{

    public sealed class ApplicationSetSpecGeneratorMatrixGeneratorMatrixArgs : global::Pulumi.ResourceArgs
    {
        [Input("generators", required: true)]
        private InputList<Inputs.ApplicationSetSpecGeneratorMatrixGeneratorMatrixGeneratorArgs>? _generators;

        /// <summary>
        /// Application set generators. Generators are responsible for generating parameters, which are then rendered into the template: fields of the ApplicationSet resource.
        /// </summary>
        public InputList<Inputs.ApplicationSetSpecGeneratorMatrixGeneratorMatrixGeneratorArgs> Generators
        {
            get => _generators ?? (_generators = new InputList<Inputs.ApplicationSetSpecGeneratorMatrixGeneratorMatrixGeneratorArgs>());
            set => _generators = value;
        }

        /// <summary>
        /// Generator template. Used to override the values of the spec-level template.
        /// </summary>
        [Input("template")]
        public Input<Inputs.ApplicationSetSpecGeneratorMatrixGeneratorMatrixTemplateArgs>? Template { get; set; }

        public ApplicationSetSpecGeneratorMatrixGeneratorMatrixArgs()
        {
        }
        public static new ApplicationSetSpecGeneratorMatrixGeneratorMatrixArgs Empty => new ApplicationSetSpecGeneratorMatrixGeneratorMatrixArgs();
    }
}