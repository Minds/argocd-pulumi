// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Argocd.Inputs
{

    public sealed class ClusterConfigTlsClientConfigArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// PEM-encoded bytes (typically read from a root certificates bundle).
        /// </summary>
        [Input("caData")]
        public Input<string>? CaData { get; set; }

        /// <summary>
        /// PEM-encoded bytes (typically read from a client certificate file).
        /// </summary>
        [Input("certData")]
        public Input<string>? CertData { get; set; }

        /// <summary>
        /// Whether server should be accessed without verifying the TLS certificate.
        /// </summary>
        [Input("insecure")]
        public Input<bool>? Insecure { get; set; }

        [Input("keyData")]
        private Input<string>? _keyData;

        /// <summary>
        /// PEM-encoded bytes (typically read from a client certificate key file).
        /// </summary>
        public Input<string>? KeyData
        {
            get => _keyData;
            set
            {
                var emptySecret = Output.CreateSecret(0);
                _keyData = Output.Tuple<Input<string>?, int>(value, emptySecret).Apply(t => t.Item1);
            }
        }

        /// <summary>
        /// Name to pass to the server for SNI and used in the client to check server certificates against. If empty, the hostname used to contact the server is used.
        /// </summary>
        [Input("serverName")]
        public Input<string>? ServerName { get; set; }

        public ClusterConfigTlsClientConfigArgs()
        {
        }
        public static new ClusterConfigTlsClientConfigArgs Empty => new ClusterConfigTlsClientConfigArgs();
    }
}