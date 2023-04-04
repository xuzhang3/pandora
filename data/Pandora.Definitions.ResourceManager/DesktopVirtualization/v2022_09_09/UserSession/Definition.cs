using System.Collections.Generic;
using Pandora.Definitions.Interfaces;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.DesktopVirtualization.v2022_09_09.UserSession;

internal class Definition : ResourceDefinition
{
    public string Name => "UserSession";
    public IEnumerable<Interfaces.ApiOperation> Operations => new List<Interfaces.ApiOperation>
    {
        new DeleteOperation(),
        new DisconnectOperation(),
        new GetOperation(),
        new ListOperation(),
        new ListByHostPoolOperation(),
        new SendMessageOperation(),
    };
    public IEnumerable<System.Type> Constants => new List<System.Type>
    {
        typeof(ApplicationTypeConstant),
        typeof(SessionStateConstant),
    };
    public IEnumerable<System.Type> Models => new List<System.Type>
    {
        typeof(SendMessageModel),
        typeof(UserSessionModel),
        typeof(UserSessionPropertiesModel),
    };
}
