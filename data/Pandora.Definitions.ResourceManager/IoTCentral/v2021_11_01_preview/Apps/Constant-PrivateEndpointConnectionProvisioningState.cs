using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.IoTCentral.v2021_11_01_preview.Apps;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum PrivateEndpointConnectionProvisioningStateConstant
{
    [Description("Creating")]
    Creating,

    [Description("Deleting")]
    Deleting,

    [Description("Failed")]
    Failed,

    [Description("Succeeded")]
    Succeeded,
}
