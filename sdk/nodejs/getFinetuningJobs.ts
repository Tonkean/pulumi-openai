// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "./types/input";
import * as outputs from "./types/output";
import * as utilities from "./utilities";

/**
 * Fine-Tuning Jobs data source
 *
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as openai from "@pulumi/openai";
 *
 * const test = openai.getFinetuningJobs({});
 * ```
 */
export function getFinetuningJobs(opts?: pulumi.InvokeOptions): Promise<GetFinetuningJobsResult> {

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts || {});
    return pulumi.runtime.invoke("openai:index/getFinetuningJobs:getFinetuningJobs", {
    }, opts);
}

/**
 * A collection of values returned by getFinetuningJobs.
 */
export interface GetFinetuningJobsResult {
    /**
     * Fine-Tuning Jobs identifier
     */
    readonly id: string;
    /**
     * Fine Tuning Jobs
     */
    readonly jobs: outputs.GetFinetuningJobsJob[];
}
/**
 * Fine-Tuning Jobs data source
 *
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as openai from "@pulumi/openai";
 *
 * const test = openai.getFinetuningJobs({});
 * ```
 */
export function getFinetuningJobsOutput(opts?: pulumi.InvokeOptions): pulumi.Output<GetFinetuningJobsResult> {
    return pulumi.output(getFinetuningJobs(opts))
}
