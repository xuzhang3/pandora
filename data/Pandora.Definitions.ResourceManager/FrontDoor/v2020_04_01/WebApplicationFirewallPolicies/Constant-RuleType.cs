using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.FrontDoor.v2020_04_01.WebApplicationFirewallPolicies;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum RuleTypeConstant
{
    [Description("MatchRule")]
    MatchRule,

    [Description("RateLimitRule")]
    RateLimitRule,
}
