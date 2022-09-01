using System.Collections.Generic;
using Pandora.Definitions.Interfaces;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.DataProtection.v2022_04_01.AzureBackupJob;

internal class Definition : ResourceDefinition
{
    public string Name => "AzureBackupJob";
    public IEnumerable<Interfaces.ApiOperation> Operations => new List<Interfaces.ApiOperation>
    {
        new ExportJobsOperationResultGetOperation(),
        new ExportJobsTriggerOperation(),
        new JobsGetOperation(),
    };
}
