using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.CostManagement.v2021_10_01.Views;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum MetricTypeConstant
{
    [Description("AHUB")]
    AHUB,

    [Description("ActualCost")]
    ActualCost,

    [Description("AmortizedCost")]
    AmortizedCost,
}
