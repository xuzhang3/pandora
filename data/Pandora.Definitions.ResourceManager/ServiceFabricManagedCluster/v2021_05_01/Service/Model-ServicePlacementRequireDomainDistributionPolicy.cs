using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.ServiceFabricManagedCluster.v2021_05_01.Service;

[ValueForType("RequiredDomainDistribution")]
internal class ServicePlacementRequireDomainDistributionPolicyModel : ServicePlacementPolicyModel
{
    [JsonPropertyName("domainName")]
    [Required]
    public string DomainName { get; set; }
}
