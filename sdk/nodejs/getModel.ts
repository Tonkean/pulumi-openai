// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "./types/input";
import * as outputs from "./types/output";
import * as utilities from "./utilities";

/**
 * Model data source
 *
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as openai from "@pulumi/openai";
 *
 * const test = openai.getModel({
 *     id: "whisper-1",
 * });
 * ```
 */
export function getModel(args: GetModelArgs, opts?: pulumi.InvokeOptions): Promise<GetModelResult> {

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts || {});
    return pulumi.runtime.invoke("openai:index/getModel:getModel", {
        "id": args.id,
    }, opts);
}

/**
 * A collection of arguments for invoking getModel.
 */
export interface GetModelArgs {
    /**
     * Model Identifier
     */
    id: string;
}

/**
 * A collection of values returned by getModel.
 */
export interface GetModelResult {
    /**
     * Created Time
     */
    readonly created: number;
    /**
     * Model Identifier
     */
    readonly id: string;
    /**
     * Object Type
     */
    readonly object: string;
    /**
     * Model Owner
     */
    readonly ownedBy: string;
    /**
     * Parent
     */
    readonly parent: string;
    /**
     * Permissions
     */
    readonly permissions: outputs.GetModelPermission[];
    /**
     * Root
     */
    readonly root: string;
}
/**
 * Model data source
 *
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as openai from "@pulumi/openai";
 *
 * const test = openai.getModel({
 *     id: "whisper-1",
 * });
 * ```
 */
export function getModelOutput(args: GetModelOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetModelResult> {
    return pulumi.output(args).apply((a: any) => getModel(a, opts))
}

/**
 * A collection of arguments for invoking getModel.
 */
export interface GetModelOutputArgs {
    /**
     * Model Identifier
     */
    id: pulumi.Input<string>;
}
