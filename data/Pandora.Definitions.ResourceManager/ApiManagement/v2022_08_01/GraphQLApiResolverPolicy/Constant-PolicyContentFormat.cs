using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.ApiManagement.v2022_08_01.GraphQLApiResolverPolicy;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum PolicyContentFormatConstant
{
    [Description("rawxml")]
    Rawxml,

    [Description("rawxml-link")]
    RawxmlNegativelink,

    [Description("xml")]
    Xml,

    [Description("xml-link")]
    XmlNegativelink,
}
