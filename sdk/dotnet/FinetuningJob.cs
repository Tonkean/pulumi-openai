// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Openai
{
    /// <summary>
    /// Fine Tuning Job resource
    /// </summary>
    [OpenaiResourceType("openai:index/finetuningJob:FinetuningJob")]
    public partial class FinetuningJob : global::Pulumi.CustomResource
    {
        /// <summary>
        /// Created Time
        /// </summary>
        [Output("createdAt")]
        public Output<int> CreatedAt { get; private set; } = null!;

        /// <summary>
        /// Fine Tuned Model
        /// </summary>
        [Output("fineTunedModel")]
        public Output<string> FineTunedModel { get; private set; } = null!;

        /// <summary>
        /// Finished Time
        /// </summary>
        [Output("finishedAt")]
        public Output<int> FinishedAt { get; private set; } = null!;

        /// <summary>
        /// Hyperparams
        /// </summary>
        [Output("hyperparams")]
        public Output<Outputs.FinetuningJobHyperparams> Hyperparams { get; private set; } = null!;

        /// <summary>
        /// Model Identifier
        /// </summary>
        [Output("model")]
        public Output<string?> Model { get; private set; } = null!;

        /// <summary>
        /// Object Type
        /// </summary>
        [Output("object")]
        public Output<string> Object { get; private set; } = null!;

        /// <summary>
        /// Organization Id
        /// </summary>
        [Output("organizationId")]
        public Output<string> OrganizationId { get; private set; } = null!;

        /// <summary>
        /// Result Files
        /// </summary>
        [Output("resultFiles")]
        public Output<ImmutableArray<string>> ResultFiles { get; private set; } = null!;

        /// <summary>
        /// Status
        /// </summary>
        [Output("status")]
        public Output<string> Status { get; private set; } = null!;

        /// <summary>
        /// Suffix
        /// </summary>
        [Output("suffix")]
        public Output<string> Suffix { get; private set; } = null!;

        /// <summary>
        /// Trained Tokens
        /// </summary>
        [Output("trainedTokens")]
        public Output<int> TrainedTokens { get; private set; } = null!;

        /// <summary>
        /// Training File Identifier
        /// </summary>
        [Output("trainingFile")]
        public Output<string?> TrainingFile { get; private set; } = null!;

        /// <summary>
        /// Validation File Identifier
        /// </summary>
        [Output("validationFile")]
        public Output<string?> ValidationFile { get; private set; } = null!;

        /// <summary>
        /// Wait for Fine Tuning Job completion
        /// </summary>
        [Output("wait")]
        public Output<bool?> Wait { get; private set; } = null!;


        /// <summary>
        /// Create a FinetuningJob resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public FinetuningJob(string name, FinetuningJobArgs? args = null, CustomResourceOptions? options = null)
            : base("openai:index/finetuningJob:FinetuningJob", name, args ?? new FinetuningJobArgs(), MakeResourceOptions(options, ""))
        {
        }

        private FinetuningJob(string name, Input<string> id, FinetuningJobState? state = null, CustomResourceOptions? options = null)
            : base("openai:index/finetuningJob:FinetuningJob", name, state, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                PluginDownloadURL = "github://api.github.com/Tonkean/pulumi-openai",
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing FinetuningJob resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static FinetuningJob Get(string name, Input<string> id, FinetuningJobState? state = null, CustomResourceOptions? options = null)
        {
            return new FinetuningJob(name, id, state, options);
        }
    }

    public sealed class FinetuningJobArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Model Identifier
        /// </summary>
        [Input("model")]
        public Input<string>? Model { get; set; }

        /// <summary>
        /// Training File Identifier
        /// </summary>
        [Input("trainingFile")]
        public Input<string>? TrainingFile { get; set; }

        /// <summary>
        /// Validation File Identifier
        /// </summary>
        [Input("validationFile")]
        public Input<string>? ValidationFile { get; set; }

        /// <summary>
        /// Wait for Fine Tuning Job completion
        /// </summary>
        [Input("wait")]
        public Input<bool>? Wait { get; set; }

        public FinetuningJobArgs()
        {
        }
        public static new FinetuningJobArgs Empty => new FinetuningJobArgs();
    }

    public sealed class FinetuningJobState : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Created Time
        /// </summary>
        [Input("createdAt")]
        public Input<int>? CreatedAt { get; set; }

        /// <summary>
        /// Fine Tuned Model
        /// </summary>
        [Input("fineTunedModel")]
        public Input<string>? FineTunedModel { get; set; }

        /// <summary>
        /// Finished Time
        /// </summary>
        [Input("finishedAt")]
        public Input<int>? FinishedAt { get; set; }

        /// <summary>
        /// Hyperparams
        /// </summary>
        [Input("hyperparams")]
        public Input<Inputs.FinetuningJobHyperparamsGetArgs>? Hyperparams { get; set; }

        /// <summary>
        /// Model Identifier
        /// </summary>
        [Input("model")]
        public Input<string>? Model { get; set; }

        /// <summary>
        /// Object Type
        /// </summary>
        [Input("object")]
        public Input<string>? Object { get; set; }

        /// <summary>
        /// Organization Id
        /// </summary>
        [Input("organizationId")]
        public Input<string>? OrganizationId { get; set; }

        [Input("resultFiles")]
        private InputList<string>? _resultFiles;

        /// <summary>
        /// Result Files
        /// </summary>
        public InputList<string> ResultFiles
        {
            get => _resultFiles ?? (_resultFiles = new InputList<string>());
            set => _resultFiles = value;
        }

        /// <summary>
        /// Status
        /// </summary>
        [Input("status")]
        public Input<string>? Status { get; set; }

        /// <summary>
        /// Suffix
        /// </summary>
        [Input("suffix")]
        public Input<string>? Suffix { get; set; }

        /// <summary>
        /// Trained Tokens
        /// </summary>
        [Input("trainedTokens")]
        public Input<int>? TrainedTokens { get; set; }

        /// <summary>
        /// Training File Identifier
        /// </summary>
        [Input("trainingFile")]
        public Input<string>? TrainingFile { get; set; }

        /// <summary>
        /// Validation File Identifier
        /// </summary>
        [Input("validationFile")]
        public Input<string>? ValidationFile { get; set; }

        /// <summary>
        /// Wait for Fine Tuning Job completion
        /// </summary>
        [Input("wait")]
        public Input<bool>? Wait { get; set; }

        public FinetuningJobState()
        {
        }
        public static new FinetuningJobState Empty => new FinetuningJobState();
    }
}
