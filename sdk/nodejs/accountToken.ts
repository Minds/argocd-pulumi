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
 * // Token for account configured on the `provider`
 * const _this = new argocd.AccountToken("this", {renewAfter: "168h"});
 * // renew after 7 days
 * // Token for ac count `foo`
 * const foo = new argocd.AccountToken("foo", {
 *     account: "foo",
 *     expiresIn: "168h",
 *     renewBefore: "84h",
 * });
 * // renew when less than 3.5 days remain until expiry
 * ```
 */
export class AccountToken extends pulumi.CustomResource {
    /**
     * Get an existing AccountToken resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: AccountTokenState, opts?: pulumi.CustomResourceOptions): AccountToken {
        return new AccountToken(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'argocd:index/accountToken:AccountToken';

    /**
     * Returns true if the given object is an instance of AccountToken.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is AccountToken {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === AccountToken.__pulumiType;
    }

    /**
     * Account name. Defaults to the current account. I.e. the account configured on the `provider` block.
     */
    public readonly account!: pulumi.Output<string | undefined>;
    /**
     * If `expiresIn` is set, Unix timestamp upon which the token will expire.
     */
    public /*out*/ readonly expiresAt!: pulumi.Output<string>;
    /**
     * Duration before the token will expire. Valid time units are `ns`, `us` (or `µs`), `ms`, `s`, `m`, `h`. E.g. `12h`, `7d`. Default: No expiration.
     */
    public readonly expiresIn!: pulumi.Output<string | undefined>;
    /**
     * Unix timestamp at which the token was issued.
     */
    public /*out*/ readonly issuedAt!: pulumi.Output<string>;
    /**
     * The raw JWT.
     */
    public /*out*/ readonly jwt!: pulumi.Output<string>;
    /**
     * Duration to control token silent regeneration based on token age. Valid time units are `ns`, `us` (or `µs`), `ms`, `s`, `m`, `h`. If set, then the token will be regenerated if it is older than `renewAfter`. I.e. if `currentDate - issuedAt > renewAfter`.
     */
    public readonly renewAfter!: pulumi.Output<string | undefined>;
    /**
     * Duration to control token silent regeneration based on remaining token lifetime. If `expires_in` is set, Terraform will
     * regenerate the token if `expires_at - currentDate < renew_before`. Valid time units are `ns`, `us` (or `µs`), `ms`,
     * `s`, `m`, `h`.
     */
    public readonly renewBefore!: pulumi.Output<string | undefined>;

    /**
     * Create a AccountToken resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args?: AccountTokenArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: AccountTokenArgs | AccountTokenState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as AccountTokenState | undefined;
            resourceInputs["account"] = state ? state.account : undefined;
            resourceInputs["expiresAt"] = state ? state.expiresAt : undefined;
            resourceInputs["expiresIn"] = state ? state.expiresIn : undefined;
            resourceInputs["issuedAt"] = state ? state.issuedAt : undefined;
            resourceInputs["jwt"] = state ? state.jwt : undefined;
            resourceInputs["renewAfter"] = state ? state.renewAfter : undefined;
            resourceInputs["renewBefore"] = state ? state.renewBefore : undefined;
        } else {
            const args = argsOrState as AccountTokenArgs | undefined;
            resourceInputs["account"] = args ? args.account : undefined;
            resourceInputs["expiresIn"] = args ? args.expiresIn : undefined;
            resourceInputs["renewAfter"] = args ? args.renewAfter : undefined;
            resourceInputs["renewBefore"] = args ? args.renewBefore : undefined;
            resourceInputs["expiresAt"] = undefined /*out*/;
            resourceInputs["issuedAt"] = undefined /*out*/;
            resourceInputs["jwt"] = undefined /*out*/;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        const secretOpts = { additionalSecretOutputs: ["jwt"] };
        opts = pulumi.mergeOptions(opts, secretOpts);
        super(AccountToken.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering AccountToken resources.
 */
export interface AccountTokenState {
    /**
     * Account name. Defaults to the current account. I.e. the account configured on the `provider` block.
     */
    account?: pulumi.Input<string>;
    /**
     * If `expiresIn` is set, Unix timestamp upon which the token will expire.
     */
    expiresAt?: pulumi.Input<string>;
    /**
     * Duration before the token will expire. Valid time units are `ns`, `us` (or `µs`), `ms`, `s`, `m`, `h`. E.g. `12h`, `7d`. Default: No expiration.
     */
    expiresIn?: pulumi.Input<string>;
    /**
     * Unix timestamp at which the token was issued.
     */
    issuedAt?: pulumi.Input<string>;
    /**
     * The raw JWT.
     */
    jwt?: pulumi.Input<string>;
    /**
     * Duration to control token silent regeneration based on token age. Valid time units are `ns`, `us` (or `µs`), `ms`, `s`, `m`, `h`. If set, then the token will be regenerated if it is older than `renewAfter`. I.e. if `currentDate - issuedAt > renewAfter`.
     */
    renewAfter?: pulumi.Input<string>;
    /**
     * Duration to control token silent regeneration based on remaining token lifetime. If `expires_in` is set, Terraform will
     * regenerate the token if `expires_at - currentDate < renew_before`. Valid time units are `ns`, `us` (or `µs`), `ms`,
     * `s`, `m`, `h`.
     */
    renewBefore?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a AccountToken resource.
 */
export interface AccountTokenArgs {
    /**
     * Account name. Defaults to the current account. I.e. the account configured on the `provider` block.
     */
    account?: pulumi.Input<string>;
    /**
     * Duration before the token will expire. Valid time units are `ns`, `us` (or `µs`), `ms`, `s`, `m`, `h`. E.g. `12h`, `7d`. Default: No expiration.
     */
    expiresIn?: pulumi.Input<string>;
    /**
     * Duration to control token silent regeneration based on token age. Valid time units are `ns`, `us` (or `µs`), `ms`, `s`, `m`, `h`. If set, then the token will be regenerated if it is older than `renewAfter`. I.e. if `currentDate - issuedAt > renewAfter`.
     */
    renewAfter?: pulumi.Input<string>;
    /**
     * Duration to control token silent regeneration based on remaining token lifetime. If `expires_in` is set, Terraform will
     * regenerate the token if `expires_at - currentDate < renew_before`. Valid time units are `ns`, `us` (or `µs`), `ms`,
     * `s`, `m`, `h`.
     */
    renewBefore?: pulumi.Input<string>;
}