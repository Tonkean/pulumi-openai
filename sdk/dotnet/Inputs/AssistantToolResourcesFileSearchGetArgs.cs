// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Openai.Inputs
{

    public sealed class AssistantToolResourcesFileSearchGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("vectorStoreIds")]
        private InputList<string>? _vectorStoreIds;

        /// <summary>
        /// A list of file IDs attached to this assistant. There can be a maximum of 20 files attached to the assistant. Files are ordered by their creation date in ascending order.
        /// </summary>
        public InputList<string> VectorStoreIds
        {
            get => _vectorStoreIds ?? (_vectorStoreIds = new InputList<string>());
            set => _vectorStoreIds = value;
        }

        /// <summary>
        /// Function definition for tools of type function.
        /// </summary>
        [Input("vectorStores")]
        public Input<Inputs.AssistantToolResourcesFileSearchVectorStoresGetArgs>? VectorStores { get; set; }

        public AssistantToolResourcesFileSearchGetArgs()
        {
        }
        public static new AssistantToolResourcesFileSearchGetArgs Empty => new AssistantToolResourcesFileSearchGetArgs();
    }
}
