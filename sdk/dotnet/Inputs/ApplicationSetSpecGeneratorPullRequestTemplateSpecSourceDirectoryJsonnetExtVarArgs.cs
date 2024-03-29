// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Argocd.Inputs
{

    public sealed class ApplicationSetSpecGeneratorPullRequestTemplateSpecSourceDirectoryJsonnetExtVarArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Determines whether the variable should be evaluated as jsonnet code or treated as string.
        /// </summary>
        [Input("code")]
        public Input<bool>? Code { get; set; }

        /// <summary>
        /// Name of the applicationsets.argoproj.io, must be unique. Cannot be updated. More info: http://kubernetes.io/docs/user-guide/identifiers#names
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// Value of the information.
        /// </summary>
        [Input("value")]
        public Input<string>? Value { get; set; }

        public ApplicationSetSpecGeneratorPullRequestTemplateSpecSourceDirectoryJsonnetExtVarArgs()
        {
        }
        public static new ApplicationSetSpecGeneratorPullRequestTemplateSpecSourceDirectoryJsonnetExtVarArgs Empty => new ApplicationSetSpecGeneratorPullRequestTemplateSpecSourceDirectoryJsonnetExtVarArgs();
    }
}
