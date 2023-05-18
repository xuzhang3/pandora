using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.CostManagement.v2023_03_01.Forecast;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum FunctionNameConstant
{
    [Description("Cost")]
    Cost,

    [Description("CostUSD")]
    CostUSD,

    [Description("PreTaxCost")]
    PreTaxCost,

    [Description("PreTaxCostUSD")]
    PreTaxCostUSD,
}
