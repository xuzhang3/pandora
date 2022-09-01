using Pandora.Definitions.Attributes;
using Pandora.Definitions.CustomTypes;
using Pandora.Definitions.Interfaces;
using Pandora.Definitions.Operations;
using System;
using System.Collections.Generic;
using System.Net;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.NetApp.v2021_10_01.VolumesReplication;

internal class VolumesReplicationStatusOperation : Operations.GetOperation
{
    public override ResourceID? ResourceId() => new VolumeId();

    public override Type? ResponseObject() => typeof(ReplicationStatusModel);

    public override string? UriSuffix() => "/replicationStatus";


}
