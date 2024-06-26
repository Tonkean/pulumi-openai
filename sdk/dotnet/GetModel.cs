// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Openai
{
    public static class GetModel
    {
        /// <summary>
        /// Model data source
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
        ///     var test = Openai.GetModel.Invoke(new()
        ///     {
        ///         Id = "whisper-1",
        ///     });
        /// 
        /// });
        /// ```
        /// </summary>
        public static Task<GetModelResult> InvokeAsync(GetModelArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetModelResult>("openai:index/getModel:getModel", args ?? new GetModelArgs(), options.WithDefaults());

        /// <summary>
        /// Model data source
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
        ///     var test = Openai.GetModel.Invoke(new()
        ///     {
        ///         Id = "whisper-1",
        ///     });
        /// 
        /// });
        /// ```
        /// </summary>
        public static Output<GetModelResult> Invoke(GetModelInvokeArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetModelResult>("openai:index/getModel:getModel", args ?? new GetModelInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetModelArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// Model Identifier
        /// </summary>
        [Input("id", required: true)]
        public string Id { get; set; } = null!;

        public GetModelArgs()
        {
        }
        public static new GetModelArgs Empty => new GetModelArgs();
    }

    public sealed class GetModelInvokeArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// Model Identifier
        /// </summary>
        [Input("id", required: true)]
        public Input<string> Id { get; set; } = null!;

        public GetModelInvokeArgs()
        {
        }
        public static new GetModelInvokeArgs Empty => new GetModelInvokeArgs();
    }


    [OutputType]
    public sealed class GetModelResult
    {
        /// <summary>
        /// Created Time
        /// </summary>
        public readonly int Created;
        /// <summary>
        /// Model Identifier
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// Object Type
        /// </summary>
        public readonly string Object;
        /// <summary>
        /// Model Owner
        /// </summary>
        public readonly string OwnedBy;
        /// <summary>
        /// Parent
        /// </summary>
        public readonly string Parent;
        /// <summary>
        /// Permissions
        /// </summary>
        public readonly ImmutableArray<Outputs.GetModelPermissionResult> Permissions;
        /// <summary>
        /// Root
        /// </summary>
        public readonly string Root;

        [OutputConstructor]
        private GetModelResult(
            int created,

            string id,

            string @object,

            string ownedBy,

            string parent,

            ImmutableArray<Outputs.GetModelPermissionResult> permissions,

            string root)
        {
            Created = created;
            Id = id;
            Object = @object;
            OwnedBy = ownedBy;
            Parent = parent;
            Permissions = permissions;
            Root = root;
        }
    }
}
