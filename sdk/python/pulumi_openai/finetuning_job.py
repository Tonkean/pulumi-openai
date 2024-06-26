# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import copy
import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from . import _utilities
from . import outputs
from ._inputs import *

__all__ = ['FinetuningJobArgs', 'FinetuningJob']

@pulumi.input_type
class FinetuningJobArgs:
    def __init__(__self__, *,
                 model: Optional[pulumi.Input[str]] = None,
                 training_file: Optional[pulumi.Input[str]] = None,
                 validation_file: Optional[pulumi.Input[str]] = None,
                 wait: Optional[pulumi.Input[bool]] = None):
        """
        The set of arguments for constructing a FinetuningJob resource.
        :param pulumi.Input[str] model: Model Identifier
        :param pulumi.Input[str] training_file: Training File Identifier
        :param pulumi.Input[str] validation_file: Validation File Identifier
        :param pulumi.Input[bool] wait: Wait for Fine Tuning Job completion
        """
        if model is not None:
            pulumi.set(__self__, "model", model)
        if training_file is not None:
            pulumi.set(__self__, "training_file", training_file)
        if validation_file is not None:
            pulumi.set(__self__, "validation_file", validation_file)
        if wait is not None:
            pulumi.set(__self__, "wait", wait)

    @property
    @pulumi.getter
    def model(self) -> Optional[pulumi.Input[str]]:
        """
        Model Identifier
        """
        return pulumi.get(self, "model")

    @model.setter
    def model(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "model", value)

    @property
    @pulumi.getter(name="trainingFile")
    def training_file(self) -> Optional[pulumi.Input[str]]:
        """
        Training File Identifier
        """
        return pulumi.get(self, "training_file")

    @training_file.setter
    def training_file(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "training_file", value)

    @property
    @pulumi.getter(name="validationFile")
    def validation_file(self) -> Optional[pulumi.Input[str]]:
        """
        Validation File Identifier
        """
        return pulumi.get(self, "validation_file")

    @validation_file.setter
    def validation_file(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "validation_file", value)

    @property
    @pulumi.getter
    def wait(self) -> Optional[pulumi.Input[bool]]:
        """
        Wait for Fine Tuning Job completion
        """
        return pulumi.get(self, "wait")

    @wait.setter
    def wait(self, value: Optional[pulumi.Input[bool]]):
        pulumi.set(self, "wait", value)


@pulumi.input_type
class _FinetuningJobState:
    def __init__(__self__, *,
                 created_at: Optional[pulumi.Input[int]] = None,
                 fine_tuned_model: Optional[pulumi.Input[str]] = None,
                 finished_at: Optional[pulumi.Input[int]] = None,
                 hyperparams: Optional[pulumi.Input['FinetuningJobHyperparamsArgs']] = None,
                 model: Optional[pulumi.Input[str]] = None,
                 object: Optional[pulumi.Input[str]] = None,
                 organization_id: Optional[pulumi.Input[str]] = None,
                 result_files: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 status: Optional[pulumi.Input[str]] = None,
                 suffix: Optional[pulumi.Input[str]] = None,
                 trained_tokens: Optional[pulumi.Input[int]] = None,
                 training_file: Optional[pulumi.Input[str]] = None,
                 validation_file: Optional[pulumi.Input[str]] = None,
                 wait: Optional[pulumi.Input[bool]] = None):
        """
        Input properties used for looking up and filtering FinetuningJob resources.
        :param pulumi.Input[int] created_at: Created Time
        :param pulumi.Input[str] fine_tuned_model: Fine Tuned Model
        :param pulumi.Input[int] finished_at: Finished Time
        :param pulumi.Input['FinetuningJobHyperparamsArgs'] hyperparams: Hyperparams
        :param pulumi.Input[str] model: Model Identifier
        :param pulumi.Input[str] object: Object Type
        :param pulumi.Input[str] organization_id: Organization Id
        :param pulumi.Input[Sequence[pulumi.Input[str]]] result_files: Result Files
        :param pulumi.Input[str] status: Status
        :param pulumi.Input[str] suffix: Suffix
        :param pulumi.Input[int] trained_tokens: Trained Tokens
        :param pulumi.Input[str] training_file: Training File Identifier
        :param pulumi.Input[str] validation_file: Validation File Identifier
        :param pulumi.Input[bool] wait: Wait for Fine Tuning Job completion
        """
        if created_at is not None:
            pulumi.set(__self__, "created_at", created_at)
        if fine_tuned_model is not None:
            pulumi.set(__self__, "fine_tuned_model", fine_tuned_model)
        if finished_at is not None:
            pulumi.set(__self__, "finished_at", finished_at)
        if hyperparams is not None:
            pulumi.set(__self__, "hyperparams", hyperparams)
        if model is not None:
            pulumi.set(__self__, "model", model)
        if object is not None:
            pulumi.set(__self__, "object", object)
        if organization_id is not None:
            pulumi.set(__self__, "organization_id", organization_id)
        if result_files is not None:
            pulumi.set(__self__, "result_files", result_files)
        if status is not None:
            pulumi.set(__self__, "status", status)
        if suffix is not None:
            pulumi.set(__self__, "suffix", suffix)
        if trained_tokens is not None:
            pulumi.set(__self__, "trained_tokens", trained_tokens)
        if training_file is not None:
            pulumi.set(__self__, "training_file", training_file)
        if validation_file is not None:
            pulumi.set(__self__, "validation_file", validation_file)
        if wait is not None:
            pulumi.set(__self__, "wait", wait)

    @property
    @pulumi.getter(name="createdAt")
    def created_at(self) -> Optional[pulumi.Input[int]]:
        """
        Created Time
        """
        return pulumi.get(self, "created_at")

    @created_at.setter
    def created_at(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "created_at", value)

    @property
    @pulumi.getter(name="fineTunedModel")
    def fine_tuned_model(self) -> Optional[pulumi.Input[str]]:
        """
        Fine Tuned Model
        """
        return pulumi.get(self, "fine_tuned_model")

    @fine_tuned_model.setter
    def fine_tuned_model(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "fine_tuned_model", value)

    @property
    @pulumi.getter(name="finishedAt")
    def finished_at(self) -> Optional[pulumi.Input[int]]:
        """
        Finished Time
        """
        return pulumi.get(self, "finished_at")

    @finished_at.setter
    def finished_at(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "finished_at", value)

    @property
    @pulumi.getter
    def hyperparams(self) -> Optional[pulumi.Input['FinetuningJobHyperparamsArgs']]:
        """
        Hyperparams
        """
        return pulumi.get(self, "hyperparams")

    @hyperparams.setter
    def hyperparams(self, value: Optional[pulumi.Input['FinetuningJobHyperparamsArgs']]):
        pulumi.set(self, "hyperparams", value)

    @property
    @pulumi.getter
    def model(self) -> Optional[pulumi.Input[str]]:
        """
        Model Identifier
        """
        return pulumi.get(self, "model")

    @model.setter
    def model(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "model", value)

    @property
    @pulumi.getter
    def object(self) -> Optional[pulumi.Input[str]]:
        """
        Object Type
        """
        return pulumi.get(self, "object")

    @object.setter
    def object(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "object", value)

    @property
    @pulumi.getter(name="organizationId")
    def organization_id(self) -> Optional[pulumi.Input[str]]:
        """
        Organization Id
        """
        return pulumi.get(self, "organization_id")

    @organization_id.setter
    def organization_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "organization_id", value)

    @property
    @pulumi.getter(name="resultFiles")
    def result_files(self) -> Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]:
        """
        Result Files
        """
        return pulumi.get(self, "result_files")

    @result_files.setter
    def result_files(self, value: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]):
        pulumi.set(self, "result_files", value)

    @property
    @pulumi.getter
    def status(self) -> Optional[pulumi.Input[str]]:
        """
        Status
        """
        return pulumi.get(self, "status")

    @status.setter
    def status(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "status", value)

    @property
    @pulumi.getter
    def suffix(self) -> Optional[pulumi.Input[str]]:
        """
        Suffix
        """
        return pulumi.get(self, "suffix")

    @suffix.setter
    def suffix(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "suffix", value)

    @property
    @pulumi.getter(name="trainedTokens")
    def trained_tokens(self) -> Optional[pulumi.Input[int]]:
        """
        Trained Tokens
        """
        return pulumi.get(self, "trained_tokens")

    @trained_tokens.setter
    def trained_tokens(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "trained_tokens", value)

    @property
    @pulumi.getter(name="trainingFile")
    def training_file(self) -> Optional[pulumi.Input[str]]:
        """
        Training File Identifier
        """
        return pulumi.get(self, "training_file")

    @training_file.setter
    def training_file(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "training_file", value)

    @property
    @pulumi.getter(name="validationFile")
    def validation_file(self) -> Optional[pulumi.Input[str]]:
        """
        Validation File Identifier
        """
        return pulumi.get(self, "validation_file")

    @validation_file.setter
    def validation_file(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "validation_file", value)

    @property
    @pulumi.getter
    def wait(self) -> Optional[pulumi.Input[bool]]:
        """
        Wait for Fine Tuning Job completion
        """
        return pulumi.get(self, "wait")

    @wait.setter
    def wait(self, value: Optional[pulumi.Input[bool]]):
        pulumi.set(self, "wait", value)


class FinetuningJob(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 model: Optional[pulumi.Input[str]] = None,
                 training_file: Optional[pulumi.Input[str]] = None,
                 validation_file: Optional[pulumi.Input[str]] = None,
                 wait: Optional[pulumi.Input[bool]] = None,
                 __props__=None):
        """
        Fine Tuning Job resource

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] model: Model Identifier
        :param pulumi.Input[str] training_file: Training File Identifier
        :param pulumi.Input[str] validation_file: Validation File Identifier
        :param pulumi.Input[bool] wait: Wait for Fine Tuning Job completion
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: Optional[FinetuningJobArgs] = None,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Fine Tuning Job resource

        :param str resource_name: The name of the resource.
        :param FinetuningJobArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(FinetuningJobArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 model: Optional[pulumi.Input[str]] = None,
                 training_file: Optional[pulumi.Input[str]] = None,
                 validation_file: Optional[pulumi.Input[str]] = None,
                 wait: Optional[pulumi.Input[bool]] = None,
                 __props__=None):
        opts = pulumi.ResourceOptions.merge(_utilities.get_resource_opts_defaults(), opts)
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = FinetuningJobArgs.__new__(FinetuningJobArgs)

            __props__.__dict__["model"] = model
            __props__.__dict__["training_file"] = training_file
            __props__.__dict__["validation_file"] = validation_file
            __props__.__dict__["wait"] = wait
            __props__.__dict__["created_at"] = None
            __props__.__dict__["fine_tuned_model"] = None
            __props__.__dict__["finished_at"] = None
            __props__.__dict__["hyperparams"] = None
            __props__.__dict__["object"] = None
            __props__.__dict__["organization_id"] = None
            __props__.__dict__["result_files"] = None
            __props__.__dict__["status"] = None
            __props__.__dict__["suffix"] = None
            __props__.__dict__["trained_tokens"] = None
        super(FinetuningJob, __self__).__init__(
            'openai:index/finetuningJob:FinetuningJob',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            created_at: Optional[pulumi.Input[int]] = None,
            fine_tuned_model: Optional[pulumi.Input[str]] = None,
            finished_at: Optional[pulumi.Input[int]] = None,
            hyperparams: Optional[pulumi.Input[pulumi.InputType['FinetuningJobHyperparamsArgs']]] = None,
            model: Optional[pulumi.Input[str]] = None,
            object: Optional[pulumi.Input[str]] = None,
            organization_id: Optional[pulumi.Input[str]] = None,
            result_files: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
            status: Optional[pulumi.Input[str]] = None,
            suffix: Optional[pulumi.Input[str]] = None,
            trained_tokens: Optional[pulumi.Input[int]] = None,
            training_file: Optional[pulumi.Input[str]] = None,
            validation_file: Optional[pulumi.Input[str]] = None,
            wait: Optional[pulumi.Input[bool]] = None) -> 'FinetuningJob':
        """
        Get an existing FinetuningJob resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[int] created_at: Created Time
        :param pulumi.Input[str] fine_tuned_model: Fine Tuned Model
        :param pulumi.Input[int] finished_at: Finished Time
        :param pulumi.Input[pulumi.InputType['FinetuningJobHyperparamsArgs']] hyperparams: Hyperparams
        :param pulumi.Input[str] model: Model Identifier
        :param pulumi.Input[str] object: Object Type
        :param pulumi.Input[str] organization_id: Organization Id
        :param pulumi.Input[Sequence[pulumi.Input[str]]] result_files: Result Files
        :param pulumi.Input[str] status: Status
        :param pulumi.Input[str] suffix: Suffix
        :param pulumi.Input[int] trained_tokens: Trained Tokens
        :param pulumi.Input[str] training_file: Training File Identifier
        :param pulumi.Input[str] validation_file: Validation File Identifier
        :param pulumi.Input[bool] wait: Wait for Fine Tuning Job completion
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _FinetuningJobState.__new__(_FinetuningJobState)

        __props__.__dict__["created_at"] = created_at
        __props__.__dict__["fine_tuned_model"] = fine_tuned_model
        __props__.__dict__["finished_at"] = finished_at
        __props__.__dict__["hyperparams"] = hyperparams
        __props__.__dict__["model"] = model
        __props__.__dict__["object"] = object
        __props__.__dict__["organization_id"] = organization_id
        __props__.__dict__["result_files"] = result_files
        __props__.__dict__["status"] = status
        __props__.__dict__["suffix"] = suffix
        __props__.__dict__["trained_tokens"] = trained_tokens
        __props__.__dict__["training_file"] = training_file
        __props__.__dict__["validation_file"] = validation_file
        __props__.__dict__["wait"] = wait
        return FinetuningJob(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="createdAt")
    def created_at(self) -> pulumi.Output[int]:
        """
        Created Time
        """
        return pulumi.get(self, "created_at")

    @property
    @pulumi.getter(name="fineTunedModel")
    def fine_tuned_model(self) -> pulumi.Output[str]:
        """
        Fine Tuned Model
        """
        return pulumi.get(self, "fine_tuned_model")

    @property
    @pulumi.getter(name="finishedAt")
    def finished_at(self) -> pulumi.Output[int]:
        """
        Finished Time
        """
        return pulumi.get(self, "finished_at")

    @property
    @pulumi.getter
    def hyperparams(self) -> pulumi.Output['outputs.FinetuningJobHyperparams']:
        """
        Hyperparams
        """
        return pulumi.get(self, "hyperparams")

    @property
    @pulumi.getter
    def model(self) -> pulumi.Output[Optional[str]]:
        """
        Model Identifier
        """
        return pulumi.get(self, "model")

    @property
    @pulumi.getter
    def object(self) -> pulumi.Output[str]:
        """
        Object Type
        """
        return pulumi.get(self, "object")

    @property
    @pulumi.getter(name="organizationId")
    def organization_id(self) -> pulumi.Output[str]:
        """
        Organization Id
        """
        return pulumi.get(self, "organization_id")

    @property
    @pulumi.getter(name="resultFiles")
    def result_files(self) -> pulumi.Output[Sequence[str]]:
        """
        Result Files
        """
        return pulumi.get(self, "result_files")

    @property
    @pulumi.getter
    def status(self) -> pulumi.Output[str]:
        """
        Status
        """
        return pulumi.get(self, "status")

    @property
    @pulumi.getter
    def suffix(self) -> pulumi.Output[str]:
        """
        Suffix
        """
        return pulumi.get(self, "suffix")

    @property
    @pulumi.getter(name="trainedTokens")
    def trained_tokens(self) -> pulumi.Output[int]:
        """
        Trained Tokens
        """
        return pulumi.get(self, "trained_tokens")

    @property
    @pulumi.getter(name="trainingFile")
    def training_file(self) -> pulumi.Output[Optional[str]]:
        """
        Training File Identifier
        """
        return pulumi.get(self, "training_file")

    @property
    @pulumi.getter(name="validationFile")
    def validation_file(self) -> pulumi.Output[Optional[str]]:
        """
        Validation File Identifier
        """
        return pulumi.get(self, "validation_file")

    @property
    @pulumi.getter
    def wait(self) -> pulumi.Output[Optional[bool]]:
        """
        Wait for Fine Tuning Job completion
        """
        return pulumi.get(self, "wait")

