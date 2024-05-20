// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Openai
{
    public static class GetFile
    {
        /// <summary>
        /// File data source
        /// 
        /// ## Example Usage
        /// 
        /// ```csharp
        /// using System.Collections.Generic;
        /// using System.Linq;
        /// using Pulumi;
        /// using Openai = Pulumi.Openai;
        /// 
        /// return await Deployment.RunAsync(() =&gt; 
        /// {
        ///     var test = Openai.GetFile.Invoke(new()
        ///     {
        ///         Id = "1",
        ///     });
        /// 
        /// });
        /// ```
        /// </summary>
        public static Task<GetFileResult> InvokeAsync(GetFileArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetFileResult>("openai:index/getFile:getFile", args ?? new GetFileArgs(), options.WithDefaults());

        /// <summary>
        /// File data source
        /// 
        /// ## Example Usage
        /// 
        /// ```csharp
        /// using System.Collections.Generic;
        /// using System.Linq;
        /// using Pulumi;
        /// using Openai = Pulumi.Openai;
        /// 
        /// return await Deployment.RunAsync(() =&gt; 
        /// {
        ///     var test = Openai.GetFile.Invoke(new()
        ///     {
        ///         Id = "1",
        ///     });
        /// 
        /// });
        /// ```
        /// </summary>
        public static Output<GetFileResult> Invoke(GetFileInvokeArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetFileResult>("openai:index/getFile:getFile", args ?? new GetFileInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetFileArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// File Identifier
        /// </summary>
        [Input("id", required: true)]
        public string Id { get; set; } = null!;

        public GetFileArgs()
        {
        }
        public static new GetFileArgs Empty => new GetFileArgs();
    }

    public sealed class GetFileInvokeArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// File Identifier
        /// </summary>
        [Input("id", required: true)]
        public Input<string> Id { get; set; } = null!;

        public GetFileInvokeArgs()
        {
        }
        public static new GetFileInvokeArgs Empty => new GetFileInvokeArgs();
    }


    [OutputType]
    public sealed class GetFileResult
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
        private GetFileResult(
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
