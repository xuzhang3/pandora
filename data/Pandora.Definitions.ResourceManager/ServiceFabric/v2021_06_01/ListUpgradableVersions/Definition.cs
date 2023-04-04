using System.Collections.Generic;
using Pandora.Definitions.Interfaces;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.ServiceFabric.v2021_06_01.ListUpgradableVersions;

internal class Definition : ResourceDefinition
{
    public string Name => "ListUpgradableVersions";
    public IEnumerable<Interfaces.ApiOperation> Operations => new List<Interfaces.ApiOperation>
    {
        new ClustersListUpgradableVersionsOperation(),
    };
    public IEnumerable<System.Type> Constants => new List<System.Type>
    {
        typeof(ClusterVersionsEnvironmentConstant),
    };
    public IEnumerable<System.Type> Models => new List<System.Type>
    {
        typeof(UpgradableVersionPathResultModel),
        typeof(UpgradableVersionsDescriptionModel),
    };
}
