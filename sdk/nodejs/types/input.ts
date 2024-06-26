// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";

export interface AssistantTool {
    /**
     * Function definition for tools of type function.
     */
    function?: pulumi.Input<inputs.AssistantToolFunction>;
    /**
     * Tools can be of types code_interpreter, retrieval, or function.
     */
    type: pulumi.Input<string>;
}

export interface AssistantToolFunction {
    /**
     * A description of what the function does, used by the model to choose when and how to call the function.
     */
    description?: pulumi.Input<string>;
    /**
     * The name of the function to be called. Must be a-z, A-Z, 0-9, or contain underscores and dashes, with a maximum length of 64.
     */
    name: pulumi.Input<string>;
    /**
     * The parameters the functions accepts, described as a JSON Schema object.
     */
    parameters: pulumi.Input<string>;
}

export interface AssistantToolResources {
    /**
     * Function definition for tools of type function.
     */
    codeInterpreter?: pulumi.Input<inputs.AssistantToolResourcesCodeInterpreter>;
    /**
     * Function definition for tools of type function.
     */
    fileSearch?: pulumi.Input<inputs.AssistantToolResourcesFileSearch>;
}

export interface AssistantToolResourcesCodeInterpreter {
    /**
     * A list of file IDs attached to this assistant. There can be a maximum of 20 files attached to the assistant. Files are ordered by their creation date in ascending order.
     */
    fileIds?: pulumi.Input<pulumi.Input<string>[]>;
}

export interface AssistantToolResourcesFileSearch {
    /**
     * A list of file IDs attached to this assistant. There can be a maximum of 20 files attached to the assistant. Files are ordered by their creation date in ascending order.
     */
    vectorStoreIds?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * Function definition for tools of type function.
     */
    vectorStores?: pulumi.Input<inputs.AssistantToolResourcesFileSearchVectorStores>;
}

export interface AssistantToolResourcesFileSearchVectorStores {
    /**
     * A list of file IDs attached to this assistant. There can be a maximum of 20 files attached to the assistant. Files are ordered by their creation date in ascending order.
     */
    fileIds?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * Set of 16 key-value pairs that can be attached to a vector store. This can be useful for storing additional information about the vector store in a structured format. Keys can be a maximum of 64 characters long and values can be a maxium of 512 characters long.
     */
    metadata?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
}

export interface FinetuningJobHyperparams {
    /**
     * N Epochs
     */
    nEpochs?: pulumi.Input<number>;
}

