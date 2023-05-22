using System.Collections.Generic;
using Pandora.Definitions.Interfaces;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.NewRelic.v2022_07_01.Plan;

internal class Definition : ResourceDefinition
{
    public string Name => "Plan";
    public IEnumerable<Interfaces.ApiOperation> Operations => new List<Interfaces.ApiOperation>
    {
        new ListOperation(),
    };
    public IEnumerable<System.Type> Constants => new List<System.Type>
    {
        typeof(AccountCreationSourceConstant),
        typeof(BillingCycleConstant),
        typeof(OrgCreationSourceConstant),
        typeof(UsageTypeConstant),
    };
    public IEnumerable<System.Type> Models => new List<System.Type>
    {
        typeof(PlanDataModel),
        typeof(PlanDataPropertiesModel),
        typeof(PlanDataResourceModel),
    };
}
