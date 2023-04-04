using System.Collections.Generic;
using Pandora.Definitions.Interfaces;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.Storage.v2022_05_01.ObjectReplicationPolicies;

internal class Definition : ResourceDefinition
{
    public string Name => "ObjectReplicationPolicies";
    public IEnumerable<Interfaces.ApiOperation> Operations => new List<Interfaces.ApiOperation>
    {
        new CreateOrUpdateOperation(),
        new DeleteOperation(),
        new GetOperation(),
        new ListOperation(),
    };
    public IEnumerable<System.Type> Constants => new List<System.Type>
    {

    };
    public IEnumerable<System.Type> Models => new List<System.Type>
    {
        typeof(ObjectReplicationPoliciesModel),
        typeof(ObjectReplicationPolicyModel),
        typeof(ObjectReplicationPolicyFilterModel),
        typeof(ObjectReplicationPolicyPropertiesModel),
        typeof(ObjectReplicationPolicyRuleModel),
    };
}
