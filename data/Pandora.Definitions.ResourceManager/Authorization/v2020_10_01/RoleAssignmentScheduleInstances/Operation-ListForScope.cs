using Pandora.Definitions.Attributes;
using Pandora.Definitions.CustomTypes;
using Pandora.Definitions.Interfaces;
using Pandora.Definitions.Operations;
using System;
using System.Collections.Generic;
using System.Net;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.Authorization.v2020_10_01.RoleAssignmentScheduleInstances;

internal class ListForScopeOperation : Operations.ListOperation
{
    public override string? FieldContainingPaginationDetails() => "nextLink";

    public override ResourceID? ResourceId() => new ScopeId();

    public override Type NestedItemType() => typeof(RoleAssignmentScheduleInstanceModel);

    public override Type? OptionsObject() => typeof(ListForScopeOperation.ListForScopeOptions);

    public override string? UriSuffix() => "/providers/Microsoft.Authorization/roleAssignmentScheduleInstances";

    internal class ListForScopeOptions
    {
        [QueryStringName("$filter")]
        [Optional]
        public string Filter { get; set; }
    }
}