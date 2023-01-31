using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.DataBoxEdge.v2022_03_01.Shares;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum RoleTypesConstant
{
    [Description("ASA")]
    ASA,

    [Description("CloudEdgeManagement")]
    CloudEdgeManagement,

    [Description("Cognitive")]
    Cognitive,

    [Description("Functions")]
    Functions,

    [Description("IOT")]
    IOT,

    [Description("Kubernetes")]
    Kubernetes,

    [Description("MEC")]
    MEC,
}