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
    public sealed class ApplicationSetSpecGeneratorMatrixGeneratorMatrixGeneratorGitFile
    {
        /// <summary>
        /// Path to the file containing the values for the Helm parameter.
        /// </summary>
        public readonly string Path;

        [OutputConstructor]
        private ApplicationSetSpecGeneratorMatrixGeneratorMatrixGeneratorGitFile(string path)
        {
            Path = path;
        }
    }
}