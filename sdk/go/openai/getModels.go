// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package openai

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
	"github.com/tonkean/pulumi-openai/sdk/go/openai/internal"
)

// Models data source
//
// ## Example Usage
//
// ```go
// package main
//
// import (
//
//	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
//	"github.com/tonkean/pulumi-openai/sdk/go/openai"
//
// )
//
//	func main() {
//		pulumi.Run(func(ctx *pulumi.Context) error {
//			models, err := openai.GetModels(ctx, nil, nil)
//			if err != nil {
//				return err
//			}
//			ctx.Export("modelCount", len(models.Models))
//			return nil
//		})
//	}
//
// ```
func GetModels(ctx *pulumi.Context, opts ...pulumi.InvokeOption) (*GetModelsResult, error) {
	opts = internal.PkgInvokeDefaultOpts(opts)
	var rv GetModelsResult
	err := ctx.Invoke("openai:index/getModels:getModels", nil, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of values returned by getModels.
type GetModelsResult struct {
	// Models identifier
	Id string `pulumi:"id"`
	// Models
	Models []GetModelsModel `pulumi:"models"`
}

func GetModelsOutput(ctx *pulumi.Context, opts ...pulumi.InvokeOption) GetModelsResultOutput {
	return pulumi.ToOutput(0).ApplyT(func(int) (GetModelsResult, error) {
		r, err := GetModels(ctx, opts...)
		var s GetModelsResult
		if r != nil {
			s = *r
		}
		return s, err
	}).(GetModelsResultOutput)
}

// A collection of values returned by getModels.
type GetModelsResultOutput struct{ *pulumi.OutputState }

func (GetModelsResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*GetModelsResult)(nil)).Elem()
}

func (o GetModelsResultOutput) ToGetModelsResultOutput() GetModelsResultOutput {
	return o
}

func (o GetModelsResultOutput) ToGetModelsResultOutputWithContext(ctx context.Context) GetModelsResultOutput {
	return o
}

// Models identifier
func (o GetModelsResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v GetModelsResult) string { return v.Id }).(pulumi.StringOutput)
}

// Models
func (o GetModelsResultOutput) Models() GetModelsModelArrayOutput {
	return o.ApplyT(func(v GetModelsResult) []GetModelsModel { return v.Models }).(GetModelsModelArrayOutput)
}

func init() {
	pulumi.RegisterOutputType(GetModelsResultOutput{})
}
