// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Openai.Outputs
{

    [OutputType]
    public sealed class AssistantToolResourcesFileSearchVectorStores
    {
        /// <summary>
        /// A list of file IDs attached to this assistant. There can be a maximum of 20 files attached to the assistant. Files are ordered by their creation date in ascending order.
        /// </summary>
        public readonly ImmutableArray<string> FileIds;
        /// <summary>
        /// Set of 16 key-value pairs that can be attached to a vector store. This can be useful for storing additional information about the vector store in a structured format. Keys can be a maximum of 64 characters long and values can be a maxium of 512 characters long.
        /// </summary>
        public readonly ImmutableDictionary<string, string>? Metadata;

        [OutputConstructor]
        private AssistantToolResourcesFileSearchVectorStores(
            ImmutableArray<string> fileIds,

            ImmutableDictionary<string, string>? metadata)
        {
            FileIds = fileIds;
            Metadata = metadata;
        }
    }
}
