# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import copy
import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from . import _utilities

__all__ = ['FileArgs', 'File']

@pulumi.input_type
class FileArgs:
    def __init__(__self__, *,
                 filepath: pulumi.Input[str]):
        """
        The set of arguments for constructing a File resource.
        :param pulumi.Input[str] filepath: Filename
        """
        pulumi.set(__self__, "filepath", filepath)

    @property
    @pulumi.getter
    def filepath(self) -> pulumi.Input[str]:
        """
        Filename
        """
        return pulumi.get(self, "filepath")

    @filepath.setter
    def filepath(self, value: pulumi.Input[str]):
        pulumi.set(self, "filepath", value)


@pulumi.input_type
class _FileState:
    def __init__(__self__, *,
                 bytes: Optional[pulumi.Input[int]] = None,
                 created: Optional[pulumi.Input[int]] = None,
                 filename: Optional[pulumi.Input[str]] = None,
                 filepath: Optional[pulumi.Input[str]] = None,
                 object: Optional[pulumi.Input[str]] = None,
                 purpose: Optional[pulumi.Input[str]] = None):
        """
        Input properties used for looking up and filtering File resources.
        :param pulumi.Input[int] bytes: File size in bytes
        :param pulumi.Input[int] created: Created Time
        :param pulumi.Input[str] filename: Filename
        :param pulumi.Input[str] filepath: Filename
        :param pulumi.Input[str] object: Object Type
        :param pulumi.Input[str] purpose: Intended use of file. Use 'fine-tune' for Fine-tuning
        """
        if bytes is not None:
            pulumi.set(__self__, "bytes", bytes)
        if created is not None:
            pulumi.set(__self__, "created", created)
        if filename is not None:
            pulumi.set(__self__, "filename", filename)
        if filepath is not None:
            pulumi.set(__self__, "filepath", filepath)
        if object is not None:
            pulumi.set(__self__, "object", object)
        if purpose is not None:
            pulumi.set(__self__, "purpose", purpose)

    @property
    @pulumi.getter
    def bytes(self) -> Optional[pulumi.Input[int]]:
        """
        File size in bytes
        """
        return pulumi.get(self, "bytes")

    @bytes.setter
    def bytes(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "bytes", value)

    @property
    @pulumi.getter
    def created(self) -> Optional[pulumi.Input[int]]:
        """
        Created Time
        """
        return pulumi.get(self, "created")

    @created.setter
    def created(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "created", value)

    @property
    @pulumi.getter
    def filename(self) -> Optional[pulumi.Input[str]]:
        """
        Filename
        """
        return pulumi.get(self, "filename")

    @filename.setter
    def filename(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "filename", value)

    @property
    @pulumi.getter
    def filepath(self) -> Optional[pulumi.Input[str]]:
        """
        Filename
        """
        return pulumi.get(self, "filepath")

    @filepath.setter
    def filepath(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "filepath", value)

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
    @pulumi.getter
    def purpose(self) -> Optional[pulumi.Input[str]]:
        """
        Intended use of file. Use 'fine-tune' for Fine-tuning
        """
        return pulumi.get(self, "purpose")

    @purpose.setter
    def purpose(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "purpose", value)


class File(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 filepath: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        """
        File resource

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] filepath: Filename
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: FileArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        File resource

        :param str resource_name: The name of the resource.
        :param FileArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(FileArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 filepath: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        opts = pulumi.ResourceOptions.merge(_utilities.get_resource_opts_defaults(), opts)
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = FileArgs.__new__(FileArgs)

            if filepath is None and not opts.urn:
                raise TypeError("Missing required property 'filepath'")
            __props__.__dict__["filepath"] = filepath
            __props__.__dict__["bytes"] = None
            __props__.__dict__["created"] = None
            __props__.__dict__["filename"] = None
            __props__.__dict__["object"] = None
            __props__.__dict__["purpose"] = None
        super(File, __self__).__init__(
            'openai:index/file:File',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            bytes: Optional[pulumi.Input[int]] = None,
            created: Optional[pulumi.Input[int]] = None,
            filename: Optional[pulumi.Input[str]] = None,
            filepath: Optional[pulumi.Input[str]] = None,
            object: Optional[pulumi.Input[str]] = None,
            purpose: Optional[pulumi.Input[str]] = None) -> 'File':
        """
        Get an existing File resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[int] bytes: File size in bytes
        :param pulumi.Input[int] created: Created Time
        :param pulumi.Input[str] filename: Filename
        :param pulumi.Input[str] filepath: Filename
        :param pulumi.Input[str] object: Object Type
        :param pulumi.Input[str] purpose: Intended use of file. Use 'fine-tune' for Fine-tuning
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _FileState.__new__(_FileState)

        __props__.__dict__["bytes"] = bytes
        __props__.__dict__["created"] = created
        __props__.__dict__["filename"] = filename
        __props__.__dict__["filepath"] = filepath
        __props__.__dict__["object"] = object
        __props__.__dict__["purpose"] = purpose
        return File(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter
    def bytes(self) -> pulumi.Output[int]:
        """
        File size in bytes
        """
        return pulumi.get(self, "bytes")

    @property
    @pulumi.getter
    def created(self) -> pulumi.Output[int]:
        """
        Created Time
        """
        return pulumi.get(self, "created")

    @property
    @pulumi.getter
    def filename(self) -> pulumi.Output[str]:
        """
        Filename
        """
        return pulumi.get(self, "filename")

    @property
    @pulumi.getter
    def filepath(self) -> pulumi.Output[str]:
        """
        Filename
        """
        return pulumi.get(self, "filepath")

    @property
    @pulumi.getter
    def object(self) -> pulumi.Output[str]:
        """
        Object Type
        """
        return pulumi.get(self, "object")

    @property
    @pulumi.getter
    def purpose(self) -> pulumi.Output[str]:
        """
        Intended use of file. Use 'fine-tune' for Fine-tuning
        """
        return pulumi.get(self, "purpose")
