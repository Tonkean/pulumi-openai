// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "./utilities";

/**
 * File data source
 *
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as openai from "@pulumi/openai";
 *
 * const test = openai.getFile({
 *     id: "1",
 * });
 * ```
 */
export function getFile(args: GetFileArgs, opts?: pulumi.InvokeOptions): Promise<GetFileResult> {

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts || {});
    return pulumi.runtime.invoke("openai:index/getFile:getFile", {
        "id": args.id,
    }, opts);
}

/**
 * A collection of arguments for invoking getFile.
 */
export interface GetFileArgs {
    /**
     * File Identifier
     */
    id: string;
}

/**
 * A collection of values returned by getFile.
 */
export interface GetFileResult {
    /**
     * File size in bytes
     */
    readonly bytes: number;
    /**
     * Created Time
     */
    readonly created: number;
    /**
     * Filename
     */
    readonly filename: string;
    /**
     * Filepath
     */
    readonly filepath: string;
    /**
     * File Identifier
     */
    readonly id: string;
    /**
     * Object Type
     */
    readonly object: string;
    /**
     * Intended use of file. Use 'fine-tune' for Fine-tuning
     */
    readonly purpose: string;
}
/**
 * File data source
 *
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as openai from "@pulumi/openai";
 *
 * const test = openai.getFile({
 *     id: "1",
 * });
 * ```
 */
export function getFileOutput(args: GetFileOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetFileResult> {
    return pulumi.output(args).apply((a: any) => getFile(a, opts))
}

/**
 * A collection of arguments for invoking getFile.
 */
export interface GetFileOutputArgs {
    /**
     * File Identifier
     */
    id: pulumi.Input<string>;
}