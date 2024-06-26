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
    public sealed class AssistantToolResourcesFileSearch
    {
        /// <summary>
        /// A list of file IDs attached to this assistant. There can be a maximum of 20 files attached to the assistant. Files are ordered by their creation date in ascending order.
        /// </summary>
        public readonly ImmutableArray<string> VectorStoreIds;
        /// <summary>
        /// Function definition for tools of type function.
        /// </summary>
        public readonly Outputs.AssistantToolResourcesFileSearchVectorStores? VectorStores;

        [OutputConstructor]
        private AssistantToolResourcesFileSearch(
            ImmutableArray<string> vectorStoreIds,

            Outputs.AssistantToolResourcesFileSearchVectorStores? vectorStores)
        {
            VectorStoreIds = vectorStoreIds;
            VectorStores = vectorStores;
        }
    }
}
