using System.Collections.Generic;
using Pandora.Definitions.Interfaces;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.EventHub.v2021_11_01.Namespaces;

internal class Definition : ResourceDefinition
{
    public string Name => "Namespaces";
    public IEnumerable<Interfaces.ApiOperation> Operations => new List<Interfaces.ApiOperation>
    {
        new CreateOrUpdateOperation(),
        new DeleteOperation(),
        new GetOperation(),
        new ListOperation(),
        new ListByResourceGroupOperation(),
        new UpdateOperation(),
    };
    public IEnumerable<System.Type> Constants => new List<System.Type>
    {
        typeof(EndPointProvisioningStateConstant),
        typeof(KeySourceConstant),
        typeof(PrivateLinkConnectionStatusConstant),
        typeof(SkuNameConstant),
        typeof(SkuTierConstant),
    };
    public IEnumerable<System.Type> Models => new List<System.Type>
    {
        typeof(ConnectionStateModel),
        typeof(EHNamespaceModel),
        typeof(EHNamespacePropertiesModel),
        typeof(EncryptionModel),
        typeof(KeyVaultPropertiesModel),
        typeof(PrivateEndpointModel),
        typeof(PrivateEndpointConnectionModel),
        typeof(PrivateEndpointConnectionPropertiesModel),
        typeof(SkuModel),
        typeof(UserAssignedIdentityPropertiesModel),
    };
}
