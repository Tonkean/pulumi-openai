// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Openai.Inputs
{

    public sealed class AssistantToolGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Function definition for tools of type function.
        /// </summary>
        [Input("function")]
        public Input<Inputs.AssistantToolFunctionGetArgs>? Function { get; set; }

        /// <summary>
        /// Tools can be of types code_interpreter, retrieval, or function.
        /// </summary>
        [Input("type", required: true)]
        public Input<string> Type { get; set; } = null!;

        public AssistantToolGetArgs()
        {
        }
        public static new AssistantToolGetArgs Empty => new AssistantToolGetArgs();
    }
}