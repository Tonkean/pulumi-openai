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
    public sealed class GetFilesFileResult
    {
        /// <summary>
        /// File size in bytes
        /// </summary>
        public readonly int Bytes;
        /// <summary>
        /// Created Time
        /// </summary>
        public readonly int Created;
        /// <summary>
        /// Filename
        /// </summary>
        public readonly string Filename;
        /// <summary>
        /// Filepath
        /// </summary>
        public readonly string Filepath;
        /// <summary>
        /// File Identifier
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// Object Type
        /// </summary>
        public readonly string Object;
        /// <summary>
        /// Intended use of file. Use 'fine-tune' for Fine-tuning
        /// </summary>
        public readonly string Purpose;

        [OutputConstructor]
        private GetFilesFileResult(
            int bytes,

            int created,

            string filename,

            string filepath,

            string id,

            string @object,

            string purpose)
        {
            Bytes = bytes;
            Created = created;
            Filename = filename;
            Filepath = filepath;
            Id = id;
            Object = @object;
            Purpose = purpose;
        }
    }
}
