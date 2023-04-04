using System.Collections.Generic;
using Pandora.Definitions.Interfaces;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.Logic.v2019_05_01.IntegrationAccountCertificates;

internal class Definition : ResourceDefinition
{
    public string Name => "IntegrationAccountCertificates";
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
        typeof(IntegrationAccountCertificateModel),
        typeof(IntegrationAccountCertificatePropertiesModel),
        typeof(KeyVaultKeyReferenceModel),
        typeof(KeyVaultKeyReferenceKeyVaultModel),
    };
}
