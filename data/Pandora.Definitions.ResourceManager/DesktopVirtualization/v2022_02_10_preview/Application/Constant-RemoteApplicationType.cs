using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.DesktopVirtualization.v2022_02_10_preview.Application;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum RemoteApplicationTypeConstant
{
    [Description("InBuilt")]
    InBuilt,

    [Description("MsixApplication")]
    MsixApplication,
}
