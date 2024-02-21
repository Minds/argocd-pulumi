// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "./utilities";

/**
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as argocd from "@mindsorg/argocd-pulumi";
 *
 * const _private = new argocd.RepositoryCredentials("private", {
 *     sshPrivateKey: `-----BEGIN OPENSSH PRIVATE KEY-----
 * foo
 * bar
 * -----END OPENSSH PRIVATE KEY-----
 * `,
 *     url: "git@private-git-repository.local",
 *     username: "git",
 * });
 * ```
 *
 * ## Import
 *
 * Repository credentials can be imported using the repository URL.
 *
 *  Note: as the ArgoCD API does not return any sensitive information, a
 *
 *  subsequent `pulumi up` should be executed to make the `password`,
 *
 *  `ssh_private_key` and `tls_client_cert_key` attributes converge to their
 *
 *  expected values defined within the plan.
 *
 *  Example:
 *
 * ```sh
 * $ pulumi import argocd:index/repositoryCredentials:RepositoryCredentials myrepocreds git@private-git-repository.local:somerepo.git
 * ```
 */
export class RepositoryCredentials extends pulumi.CustomResource {
    /**
     * Get an existing RepositoryCredentials resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: RepositoryCredentialsState, opts?: pulumi.CustomResourceOptions): RepositoryCredentials {
        return new RepositoryCredentials(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'argocd:index/repositoryCredentials:RepositoryCredentials';

    /**
     * Returns true if the given object is an instance of RepositoryCredentials.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is RepositoryCredentials {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === RepositoryCredentials.__pulumiType;
    }

    /**
     * Whether `helm-oci` support should be enabled for this repo.
     */
    public readonly enableOci!: pulumi.Output<boolean | undefined>;
    /**
     * GitHub API URL for GitHub app authentication.
     */
    public readonly githubappEnterpriseBaseUrl!: pulumi.Output<string | undefined>;
    /**
     * Github App ID of the app used to access the repo for GitHub app authentication.
     */
    public readonly githubappId!: pulumi.Output<string | undefined>;
    /**
     * ID of the installed GitHub App for GitHub app authentication.
     */
    public readonly githubappInstallationId!: pulumi.Output<string | undefined>;
    /**
     * Private key data (PEM) for authentication via GitHub app.
     */
    public readonly githubappPrivateKey!: pulumi.Output<string | undefined>;
    /**
     * Password for authenticating at the repo server.
     */
    public readonly password!: pulumi.Output<string | undefined>;
    /**
     * Private key data for authenticating at the repo server using SSH (only Git repos).
     */
    public readonly sshPrivateKey!: pulumi.Output<string | undefined>;
    /**
     * TLS client cert data for authenticating at the repo server.
     */
    public readonly tlsClientCertData!: pulumi.Output<string | undefined>;
    /**
     * TLS client cert key for authenticating at the repo server.
     */
    public readonly tlsClientCertKey!: pulumi.Output<string | undefined>;
    /**
     * URL that these credentials matches to.
     */
    public readonly url!: pulumi.Output<string>;
    /**
     * Username for authenticating at the repo server.
     */
    public readonly username!: pulumi.Output<string | undefined>;

    /**
     * Create a RepositoryCredentials resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: RepositoryCredentialsArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: RepositoryCredentialsArgs | RepositoryCredentialsState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as RepositoryCredentialsState | undefined;
            resourceInputs["enableOci"] = state ? state.enableOci : undefined;
            resourceInputs["githubappEnterpriseBaseUrl"] = state ? state.githubappEnterpriseBaseUrl : undefined;
            resourceInputs["githubappId"] = state ? state.githubappId : undefined;
            resourceInputs["githubappInstallationId"] = state ? state.githubappInstallationId : undefined;
            resourceInputs["githubappPrivateKey"] = state ? state.githubappPrivateKey : undefined;
            resourceInputs["password"] = state ? state.password : undefined;
            resourceInputs["sshPrivateKey"] = state ? state.sshPrivateKey : undefined;
            resourceInputs["tlsClientCertData"] = state ? state.tlsClientCertData : undefined;
            resourceInputs["tlsClientCertKey"] = state ? state.tlsClientCertKey : undefined;
            resourceInputs["url"] = state ? state.url : undefined;
            resourceInputs["username"] = state ? state.username : undefined;
        } else {
            const args = argsOrState as RepositoryCredentialsArgs | undefined;
            if ((!args || args.url === undefined) && !opts.urn) {
                throw new Error("Missing required property 'url'");
            }
            resourceInputs["enableOci"] = args ? args.enableOci : undefined;
            resourceInputs["githubappEnterpriseBaseUrl"] = args ? args.githubappEnterpriseBaseUrl : undefined;
            resourceInputs["githubappId"] = args ? args.githubappId : undefined;
            resourceInputs["githubappInstallationId"] = args ? args.githubappInstallationId : undefined;
            resourceInputs["githubappPrivateKey"] = args?.githubappPrivateKey ? pulumi.secret(args.githubappPrivateKey) : undefined;
            resourceInputs["password"] = args?.password ? pulumi.secret(args.password) : undefined;
            resourceInputs["sshPrivateKey"] = args?.sshPrivateKey ? pulumi.secret(args.sshPrivateKey) : undefined;
            resourceInputs["tlsClientCertData"] = args ? args.tlsClientCertData : undefined;
            resourceInputs["tlsClientCertKey"] = args?.tlsClientCertKey ? pulumi.secret(args.tlsClientCertKey) : undefined;
            resourceInputs["url"] = args ? args.url : undefined;
            resourceInputs["username"] = args ? args.username : undefined;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        const secretOpts = { additionalSecretOutputs: ["githubappPrivateKey", "password", "sshPrivateKey", "tlsClientCertKey"] };
        opts = pulumi.mergeOptions(opts, secretOpts);
        super(RepositoryCredentials.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering RepositoryCredentials resources.
 */
export interface RepositoryCredentialsState {
    /**
     * Whether `helm-oci` support should be enabled for this repo.
     */
    enableOci?: pulumi.Input<boolean>;
    /**
     * GitHub API URL for GitHub app authentication.
     */
    githubappEnterpriseBaseUrl?: pulumi.Input<string>;
    /**
     * Github App ID of the app used to access the repo for GitHub app authentication.
     */
    githubappId?: pulumi.Input<string>;
    /**
     * ID of the installed GitHub App for GitHub app authentication.
     */
    githubappInstallationId?: pulumi.Input<string>;
    /**
     * Private key data (PEM) for authentication via GitHub app.
     */
    githubappPrivateKey?: pulumi.Input<string>;
    /**
     * Password for authenticating at the repo server.
     */
    password?: pulumi.Input<string>;
    /**
     * Private key data for authenticating at the repo server using SSH (only Git repos).
     */
    sshPrivateKey?: pulumi.Input<string>;
    /**
     * TLS client cert data for authenticating at the repo server.
     */
    tlsClientCertData?: pulumi.Input<string>;
    /**
     * TLS client cert key for authenticating at the repo server.
     */
    tlsClientCertKey?: pulumi.Input<string>;
    /**
     * URL that these credentials matches to.
     */
    url?: pulumi.Input<string>;
    /**
     * Username for authenticating at the repo server.
     */
    username?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a RepositoryCredentials resource.
 */
export interface RepositoryCredentialsArgs {
    /**
     * Whether `helm-oci` support should be enabled for this repo.
     */
    enableOci?: pulumi.Input<boolean>;
    /**
     * GitHub API URL for GitHub app authentication.
     */
    githubappEnterpriseBaseUrl?: pulumi.Input<string>;
    /**
     * Github App ID of the app used to access the repo for GitHub app authentication.
     */
    githubappId?: pulumi.Input<string>;
    /**
     * ID of the installed GitHub App for GitHub app authentication.
     */
    githubappInstallationId?: pulumi.Input<string>;
    /**
     * Private key data (PEM) for authentication via GitHub app.
     */
    githubappPrivateKey?: pulumi.Input<string>;
    /**
     * Password for authenticating at the repo server.
     */
    password?: pulumi.Input<string>;
    /**
     * Private key data for authenticating at the repo server using SSH (only Git repos).
     */
    sshPrivateKey?: pulumi.Input<string>;
    /**
     * TLS client cert data for authenticating at the repo server.
     */
    tlsClientCertData?: pulumi.Input<string>;
    /**
     * TLS client cert key for authenticating at the repo server.
     */
    tlsClientCertKey?: pulumi.Input<string>;
    /**
     * URL that these credentials matches to.
     */
    url: pulumi.Input<string>;
    /**
     * Username for authenticating at the repo server.
     */
    username?: pulumi.Input<string>;
}