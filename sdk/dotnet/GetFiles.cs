// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Openai
{
    public static class GetFiles
    {
        /// <summary>
        /// Files data source
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
        ///     var test = Openai.GetFiles.Invoke();
        /// 
        /// });
        /// ```
        /// </summary>
        public static Task<GetFilesResult> InvokeAsync(InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetFilesResult>("openai:index/getFiles:getFiles", InvokeArgs.Empty, options.WithDefaults());

        /// <summary>
        /// Files data source
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
        ///     var test = Openai.GetFiles.Invoke();
        /// 
        /// });
        /// ```
        /// </summary>
        public static Output<GetFilesResult> Invoke(InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetFilesResult>("openai:index/getFiles:getFiles", InvokeArgs.Empty, options.WithDefaults());
    }


    [OutputType]
    public sealed class GetFilesResult
    {
        /// <summary>
        /// Files
        /// </summary>
        public readonly ImmutableArray<Outputs.GetFilesFileResult> Files;
        /// <summary>
        /// Files identifier
        /// </summary>
        public readonly string Id;

        [OutputConstructor]
        private GetFilesResult(
            ImmutableArray<Outputs.GetFilesFileResult> files,

            string id)
        {
            Files = files;
            Id = id;
        }
    }
}
