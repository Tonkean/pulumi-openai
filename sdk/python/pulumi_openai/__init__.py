# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

from . import _utilities
import typing
# Export this package's modules as members:
from .assistant import *
from .file import *
from .finetuning_job import *
from .get_file import *
from .get_files import *
from .get_finetuning_job import *
from .get_finetuning_jobs import *
from .get_model import *
from .get_models import *
from .provider import *
from ._inputs import *
from . import outputs

# Make subpackages available:
if typing.TYPE_CHECKING:
    import pulumi_openai.config as __config
    config = __config
else:
    config = _utilities.lazy_import('pulumi_openai.config')

_utilities.register(
    resource_modules="""
[
 {
  "pkg": "openai",
  "mod": "index/assistant",
  "fqn": "pulumi_openai",
  "classes": {
   "openai:index/assistant:Assistant": "Assistant"
  }
 },
 {
  "pkg": "openai",
  "mod": "index/file",
  "fqn": "pulumi_openai",
  "classes": {
   "openai:index/file:File": "File"
  }
 },
 {
  "pkg": "openai",
  "mod": "index/finetuningJob",
  "fqn": "pulumi_openai",
  "classes": {
   "openai:index/finetuningJob:FinetuningJob": "FinetuningJob"
  }
 }
]
""",
    resource_packages="""
[
 {
  "pkg": "openai",
  "token": "pulumi:providers:openai",
  "fqn": "pulumi_openai",
  "class": "Provider"
 }
]
"""
)
