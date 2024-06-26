// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Openai
{
    public static class GetFinetuningJobs
    {
        /// <summary>
        /// Fine-Tuning Jobs data source
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
        ///     var test = Openai.GetFinetuningJobs.Invoke();
        /// 
        /// });
        /// ```
        /// </summary>
        public static Task<GetFinetuningJobsResult> InvokeAsync(InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetFinetuningJobsResult>("openai:index/getFinetuningJobs:getFinetuningJobs", InvokeArgs.Empty, options.WithDefaults());

        /// <summary>
        /// Fine-Tuning Jobs data source
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
        ///     var test = Openai.GetFinetuningJobs.Invoke();
        /// 
        /// });
        /// ```
        /// </summary>
        public static Output<GetFinetuningJobsResult> Invoke(InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetFinetuningJobsResult>("openai:index/getFinetuningJobs:getFinetuningJobs", InvokeArgs.Empty, options.WithDefaults());
    }


    [OutputType]
    public sealed class GetFinetuningJobsResult
    {
        /// <summary>
        /// Fine-Tuning Jobs identifier
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// Fine Tuning Jobs
        /// </summary>
        public readonly ImmutableArray<Outputs.GetFinetuningJobsJobResult> Jobs;

        [OutputConstructor]
        private GetFinetuningJobsResult(
            string id,

            ImmutableArray<Outputs.GetFinetuningJobsJobResult> jobs)
        {
            Id = id;
            Jobs = jobs;
        }
    }
}
