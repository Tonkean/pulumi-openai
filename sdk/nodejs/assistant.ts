// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "./types/input";
import * as outputs from "./types/output";
import * as utilities from "./utilities";

/**
 * Assistant resource
 *
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as openai from "@pulumi/openai";
 *
 * const test = new openai.Assistant("test", {
 *     description: "tf-test-sample",
 *     instructions: "You are a personal math tutor. When asked a question, write and run Python code to answer the question.",
 *     model: "gpt-4",
 *     tools: [{
 *         type: "code_interpreter",
 *     }],
 * });
 * ```
 */
export class Assistant extends pulumi.CustomResource {
    /**
     * Get an existing Assistant resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: AssistantState, opts?: pulumi.CustomResourceOptions): Assistant {
        return new Assistant(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'openai:index/assistant:Assistant';

    /**
     * Returns true if the given object is an instance of Assistant.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is Assistant {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === Assistant.__pulumiType;
    }

    /**
     * The Unix timestamp (in seconds) for when the assistant was created.
     */
    public /*out*/ readonly createdAt!: pulumi.Output<number>;
    /**
     * The description of the assistant. The maximum length is 512 characters.
     */
    public readonly description!: pulumi.Output<string | undefined>;
    /**
     * The system instructions that the assistant uses. The maximum length is 32768 characters.
     */
    public readonly instructions!: pulumi.Output<string | undefined>;
    /**
     * Set of 16 key-value pairs that can be attached to an object. This can be useful for storing additional information about the object in a structured format. Keys can be a maximum of 64 characters long and values can be a maxium of 512 characters long.
     */
    public readonly metadata!: pulumi.Output<{[key: string]: string} | undefined>;
    /**
     * ID of the model to use. You can use the List models API to see all of your available models.
     */
    public readonly model!: pulumi.Output<string>;
    /**
     * The name of the assistant. The maximum length is 256 characters.
     */
    public readonly name!: pulumi.Output<string>;
    /**
     * The object type, which is always assistant.
     */
    public /*out*/ readonly object!: pulumi.Output<string>;
    /**
     * What sampling temperature to use, between 0 and 2. Higher values like 0.8 will make the output more random, while lower values like 0.2 will make it more focused and deterministic.
     */
    public readonly temperature!: pulumi.Output<number | undefined>;
    /**
     * A set of resources that are used by the assistant's tools. The resources are specific to the type of tool. For example, the code*interpreter tool requires a list of file IDs, while the file*search tool requires a list of vector store IDs.
     */
    public readonly toolResources!: pulumi.Output<outputs.AssistantToolResources | undefined>;
    /**
     * A list of tool enabled on the assistant. There can be a maximum of 128 tools per assistant. Tools can be of types code_interpreter, retrieval, or function.
     */
    public readonly tools!: pulumi.Output<outputs.AssistantTool[] | undefined>;
    /**
     * An alternative to sampling with temperature, called nucleus sampling, where the model considers the results of the tokens with topP probability mass. So 0.1 means only the tokens comprising the top 10% probability mass are considered.
     */
    public readonly topP!: pulumi.Output<number | undefined>;

    /**
     * Create a Assistant resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: AssistantArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: AssistantArgs | AssistantState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as AssistantState | undefined;
            resourceInputs["createdAt"] = state ? state.createdAt : undefined;
            resourceInputs["description"] = state ? state.description : undefined;
            resourceInputs["instructions"] = state ? state.instructions : undefined;
            resourceInputs["metadata"] = state ? state.metadata : undefined;
            resourceInputs["model"] = state ? state.model : undefined;
            resourceInputs["name"] = state ? state.name : undefined;
            resourceInputs["object"] = state ? state.object : undefined;
            resourceInputs["temperature"] = state ? state.temperature : undefined;
            resourceInputs["toolResources"] = state ? state.toolResources : undefined;
            resourceInputs["tools"] = state ? state.tools : undefined;
            resourceInputs["topP"] = state ? state.topP : undefined;
        } else {
            const args = argsOrState as AssistantArgs | undefined;
            if ((!args || args.model === undefined) && !opts.urn) {
                throw new Error("Missing required property 'model'");
            }
            resourceInputs["description"] = args ? args.description : undefined;
            resourceInputs["instructions"] = args ? args.instructions : undefined;
            resourceInputs["metadata"] = args ? args.metadata : undefined;
            resourceInputs["model"] = args ? args.model : undefined;
            resourceInputs["name"] = args ? args.name : undefined;
            resourceInputs["temperature"] = args ? args.temperature : undefined;
            resourceInputs["toolResources"] = args ? args.toolResources : undefined;
            resourceInputs["tools"] = args ? args.tools : undefined;
            resourceInputs["topP"] = args ? args.topP : undefined;
            resourceInputs["createdAt"] = undefined /*out*/;
            resourceInputs["object"] = undefined /*out*/;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(Assistant.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering Assistant resources.
 */
export interface AssistantState {
    /**
     * The Unix timestamp (in seconds) for when the assistant was created.
     */
    createdAt?: pulumi.Input<number>;
    /**
     * The description of the assistant. The maximum length is 512 characters.
     */
    description?: pulumi.Input<string>;
    /**
     * The system instructions that the assistant uses. The maximum length is 32768 characters.
     */
    instructions?: pulumi.Input<string>;
    /**
     * Set of 16 key-value pairs that can be attached to an object. This can be useful for storing additional information about the object in a structured format. Keys can be a maximum of 64 characters long and values can be a maxium of 512 characters long.
     */
    metadata?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    /**
     * ID of the model to use. You can use the List models API to see all of your available models.
     */
    model?: pulumi.Input<string>;
    /**
     * The name of the assistant. The maximum length is 256 characters.
     */
    name?: pulumi.Input<string>;
    /**
     * The object type, which is always assistant.
     */
    object?: pulumi.Input<string>;
    /**
     * What sampling temperature to use, between 0 and 2. Higher values like 0.8 will make the output more random, while lower values like 0.2 will make it more focused and deterministic.
     */
    temperature?: pulumi.Input<number>;
    /**
     * A set of resources that are used by the assistant's tools. The resources are specific to the type of tool. For example, the code*interpreter tool requires a list of file IDs, while the file*search tool requires a list of vector store IDs.
     */
    toolResources?: pulumi.Input<inputs.AssistantToolResources>;
    /**
     * A list of tool enabled on the assistant. There can be a maximum of 128 tools per assistant. Tools can be of types code_interpreter, retrieval, or function.
     */
    tools?: pulumi.Input<pulumi.Input<inputs.AssistantTool>[]>;
    /**
     * An alternative to sampling with temperature, called nucleus sampling, where the model considers the results of the tokens with topP probability mass. So 0.1 means only the tokens comprising the top 10% probability mass are considered.
     */
    topP?: pulumi.Input<number>;
}

/**
 * The set of arguments for constructing a Assistant resource.
 */
export interface AssistantArgs {
    /**
     * The description of the assistant. The maximum length is 512 characters.
     */
    description?: pulumi.Input<string>;
    /**
     * The system instructions that the assistant uses. The maximum length is 32768 characters.
     */
    instructions?: pulumi.Input<string>;
    /**
     * Set of 16 key-value pairs that can be attached to an object. This can be useful for storing additional information about the object in a structured format. Keys can be a maximum of 64 characters long and values can be a maxium of 512 characters long.
     */
    metadata?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    /**
     * ID of the model to use. You can use the List models API to see all of your available models.
     */
    model: pulumi.Input<string>;
    /**
     * The name of the assistant. The maximum length is 256 characters.
     */
    name?: pulumi.Input<string>;
    /**
     * What sampling temperature to use, between 0 and 2. Higher values like 0.8 will make the output more random, while lower values like 0.2 will make it more focused and deterministic.
     */
    temperature?: pulumi.Input<number>;
    /**
     * A set of resources that are used by the assistant's tools. The resources are specific to the type of tool. For example, the code*interpreter tool requires a list of file IDs, while the file*search tool requires a list of vector store IDs.
     */
    toolResources?: pulumi.Input<inputs.AssistantToolResources>;
    /**
     * A list of tool enabled on the assistant. There can be a maximum of 128 tools per assistant. Tools can be of types code_interpreter, retrieval, or function.
     */
    tools?: pulumi.Input<pulumi.Input<inputs.AssistantTool>[]>;
    /**
     * An alternative to sampling with temperature, called nucleus sampling, where the model considers the results of the tokens with topP probability mass. So 0.1 means only the tokens comprising the top 10% probability mass are considered.
     */
    topP?: pulumi.Input<number>;
}
