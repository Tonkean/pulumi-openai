// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Openai
{
    public static class GetFinetuningJob
    {
        /// <summary>
        /// Fine-Tuning Job data source
        /// </summary>
        public static Task<GetFinetuningJobResult> InvokeAsync(GetFinetuningJobArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetFinetuningJobResult>("openai:index/getFinetuningJob:getFinetuningJob", args ?? new GetFinetuningJobArgs(), options.WithDefaults());

        /// <summary>
        /// Fine-Tuning Job data source
        /// </summary>
        public static Output<GetFinetuningJobResult> Invoke(GetFinetuningJobInvokeArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetFinetuningJobResult>("openai:index/getFinetuningJob:getFinetuningJob", args ?? new GetFinetuningJobInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetFinetuningJobArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// Fine Tuning Job Identifier
        /// </summary>
        [Input("id", required: true)]
        public string Id { get; set; } = null!;

        public GetFinetuningJobArgs()
        {
        }
        public static new GetFinetuningJobArgs Empty => new GetFinetuningJobArgs();
    }

    public sealed class GetFinetuningJobInvokeArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// Fine Tuning Job Identifier
        /// </summary>
        [Input("id", required: true)]
        public Input<string> Id { get; set; } = null!;

        public GetFinetuningJobInvokeArgs()
        {
        }
        public static new GetFinetuningJobInvokeArgs Empty => new GetFinetuningJobInvokeArgs();
    }


    [OutputType]
    public sealed class GetFinetuningJobResult
    {
        /// <summary>
        /// Created Time
        /// </summary>
        public readonly int CreatedAt;
        /// <summary>
        /// Fine-Tuned Model ID
        /// </summary>
        public readonly string FineTunedModel;
        /// <summary>
        /// Finished Time
        /// </summary>
        public readonly int FinishedAt;
        /// <summary>
        /// Hyperparams
        /// </summary>
        public readonly Outputs.GetFinetuningJobHyperparamsResult Hyperparams;
        /// <summary>
        /// Fine Tuning Job Identifier
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// Model ID
        /// </summary>
        public readonly string Model;
        /// <summary>
        /// Object Type
        /// </summary>
        public readonly string Object;
        /// <summary>
        /// Organization ID
        /// </summary>
        public readonly string OrganizationId;
        /// <summary>
        /// Result Files
        /// </summary>
        public readonly ImmutableArray<string> ResultFiles;
        /// <summary>
        /// Status
        /// </summary>
        public readonly string Status;
        /// <summary>
        /// Trained Tokens
        /// </summary>
        public readonly int TrainedTokens;
        /// <summary>
        /// Training File
        /// </summary>
        public readonly string TrainingFile;
        /// <summary>
        /// Validation File
        /// </summary>
        public readonly string ValidationFile;

        [OutputConstructor]
        private GetFinetuningJobResult(
            int createdAt,

            string fineTunedModel,

            int finishedAt,

            Outputs.GetFinetuningJobHyperparamsResult hyperparams,

            string id,

            string model,

            string @object,

            string organizationId,

            ImmutableArray<string> resultFiles,

            string status,

            int trainedTokens,

            string trainingFile,

            string validationFile)
        {
            CreatedAt = createdAt;
            FineTunedModel = fineTunedModel;
            FinishedAt = finishedAt;
            Hyperparams = hyperparams;
            Id = id;
            Model = model;
            Object = @object;
            OrganizationId = organizationId;
            ResultFiles = resultFiles;
            Status = status;
            TrainedTokens = trainedTokens;
            TrainingFile = trainingFile;
            ValidationFile = validationFile;
        }
    }
}
