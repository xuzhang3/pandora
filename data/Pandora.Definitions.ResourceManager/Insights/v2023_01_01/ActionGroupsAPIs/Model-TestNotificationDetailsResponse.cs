using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.Insights.v2023_01_01.ActionGroupsAPIs;


internal class TestNotificationDetailsResponseModel
{
    [JsonPropertyName("actionDetails")]
    public List<ActionDetailModel>? ActionDetails { get; set; }

    [JsonPropertyName("completedTime")]
    public string? CompletedTime { get; set; }

    [JsonPropertyName("context")]
    public ContextModel? Context { get; set; }

    [JsonPropertyName("createdTime")]
    public string? CreatedTime { get; set; }

    [JsonPropertyName("state")]
    [Required]
    public string State { get; set; }
}
