using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.SecurityInsights.v2022_07_01_preview.Incidents;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum IncidentLabelTypeConstant
{
    [Description("AutoAssigned")]
    AutoAssigned,

    [Description("User")]
    User,
}
