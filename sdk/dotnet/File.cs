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
    /// File resource
    /// </summary>
    [OpenaiResourceType("openai:index/file:File")]
    public partial class File : global::Pulumi.CustomResource
    {
        /// <summary>
        /// File size in bytes
        /// </summary>
        [Output("bytes")]
        public Output<int> Bytes { get; private set; } = null!;

        /// <summary>
        /// Created Time
        /// </summary>
        [Output("created")]
        public Output<int> Created { get; private set; } = null!;

        /// <summary>
        /// Filename
        /// </summary>
        [Output("filename")]
        public Output<string> Filename { get; private set; } = null!;

        /// <summary>
        /// Filename
        /// </summary>
        [Output("filepath")]
        public Output<string> Filepath { get; private set; } = null!;

        /// <summary>
        /// Object Type
        /// </summary>
        [Output("object")]
        public Output<string> Object { get; private set; } = null!;

        /// <summary>
        /// Intended use of file. Use 'fine-tune' for Fine-tuning
        /// </summary>
        [Output("purpose")]
        public Output<string> Purpose { get; private set; } = null!;


        /// <summary>
        /// Create a File resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public File(string name, FileArgs args, CustomResourceOptions? options = null)
            : base("openai:index/file:File", name, args ?? new FileArgs(), MakeResourceOptions(options, ""))
        {
        }

        private File(string name, Input<string> id, FileState? state = null, CustomResourceOptions? options = null)
            : base("openai:index/file:File", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing File resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static File Get(string name, Input<string> id, FileState? state = null, CustomResourceOptions? options = null)
        {
            return new File(name, id, state, options);
        }
    }

    public sealed class FileArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Filename
        /// </summary>
        [Input("filepath", required: true)]
        public Input<string> Filepath { get; set; } = null!;

        public FileArgs()
        {
        }
        public static new FileArgs Empty => new FileArgs();
    }

    public sealed class FileState : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// File size in bytes
        /// </summary>
        [Input("bytes")]
        public Input<int>? Bytes { get; set; }

        /// <summary>
        /// Created Time
        /// </summary>
        [Input("created")]
        public Input<int>? Created { get; set; }

        /// <summary>
        /// Filename
        /// </summary>
        [Input("filename")]
        public Input<string>? Filename { get; set; }

        /// <summary>
        /// Filename
        /// </summary>
        [Input("filepath")]
        public Input<string>? Filepath { get; set; }

        /// <summary>
        /// Object Type
        /// </summary>
        [Input("object")]
        public Input<string>? Object { get; set; }

        /// <summary>
        /// Intended use of file. Use 'fine-tune' for Fine-tuning
        /// </summary>
        [Input("purpose")]
        public Input<string>? Purpose { get; set; }

        public FileState()
        {
        }
        public static new FileState Empty => new FileState();
    }
}
