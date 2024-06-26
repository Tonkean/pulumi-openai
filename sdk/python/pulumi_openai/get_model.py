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

__all__ = [
    'GetModelResult',
    'AwaitableGetModelResult',
    'get_model',
    'get_model_output',
]

@pulumi.output_type
class GetModelResult:
    """
    A collection of values returned by getModel.
    """
    def __init__(__self__, created=None, id=None, object=None, owned_by=None, parent=None, permissions=None, root=None):
        if created and not isinstance(created, int):
            raise TypeError("Expected argument 'created' to be a int")
        pulumi.set(__self__, "created", created)
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        pulumi.set(__self__, "id", id)
        if object and not isinstance(object, str):
            raise TypeError("Expected argument 'object' to be a str")
        pulumi.set(__self__, "object", object)
        if owned_by and not isinstance(owned_by, str):
            raise TypeError("Expected argument 'owned_by' to be a str")
        pulumi.set(__self__, "owned_by", owned_by)
        if parent and not isinstance(parent, str):
            raise TypeError("Expected argument 'parent' to be a str")
        pulumi.set(__self__, "parent", parent)
        if permissions and not isinstance(permissions, list):
            raise TypeError("Expected argument 'permissions' to be a list")
        pulumi.set(__self__, "permissions", permissions)
        if root and not isinstance(root, str):
            raise TypeError("Expected argument 'root' to be a str")
        pulumi.set(__self__, "root", root)

    @property
    @pulumi.getter
    def created(self) -> int:
        """
        Created Time
        """
        return pulumi.get(self, "created")

    @property
    @pulumi.getter
    def id(self) -> str:
        """
        Model Identifier
        """
        return pulumi.get(self, "id")

    @property
    @pulumi.getter
    def object(self) -> str:
        """
        Object Type
        """
        return pulumi.get(self, "object")

    @property
    @pulumi.getter(name="ownedBy")
    def owned_by(self) -> str:
        """
        Model Owner
        """
        return pulumi.get(self, "owned_by")

    @property
    @pulumi.getter
    def parent(self) -> str:
        """
        Parent
        """
        return pulumi.get(self, "parent")

    @property
    @pulumi.getter
    def permissions(self) -> Sequence['outputs.GetModelPermissionResult']:
        """
        Permissions
        """
        return pulumi.get(self, "permissions")

    @property
    @pulumi.getter
    def root(self) -> str:
        """
        Root
        """
        return pulumi.get(self, "root")


class AwaitableGetModelResult(GetModelResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetModelResult(
            created=self.created,
            id=self.id,
            object=self.object,
            owned_by=self.owned_by,
            parent=self.parent,
            permissions=self.permissions,
            root=self.root)


def get_model(id: Optional[str] = None,
              opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetModelResult:
    """
    Model data source

    ## Example Usage

    ```python
    import pulumi
    import pulumi_openai as openai

    test = openai.get_model(id="whisper-1")
    ```


    :param str id: Model Identifier
    """
    __args__ = dict()
    __args__['id'] = id
    opts = pulumi.InvokeOptions.merge(_utilities.get_invoke_opts_defaults(), opts)
    __ret__ = pulumi.runtime.invoke('openai:index/getModel:getModel', __args__, opts=opts, typ=GetModelResult).value

    return AwaitableGetModelResult(
        created=pulumi.get(__ret__, 'created'),
        id=pulumi.get(__ret__, 'id'),
        object=pulumi.get(__ret__, 'object'),
        owned_by=pulumi.get(__ret__, 'owned_by'),
        parent=pulumi.get(__ret__, 'parent'),
        permissions=pulumi.get(__ret__, 'permissions'),
        root=pulumi.get(__ret__, 'root'))


@_utilities.lift_output_func(get_model)
def get_model_output(id: Optional[pulumi.Input[str]] = None,
                     opts: Optional[pulumi.InvokeOptions] = None) -> pulumi.Output[GetModelResult]:
    """
    Model data source

    ## Example Usage

    ```python
    import pulumi
    import pulumi_openai as openai

    test = openai.get_model(id="whisper-1")
    ```


    :param str id: Model Identifier
    """
    ...
