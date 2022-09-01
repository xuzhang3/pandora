using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.SecurityInsights.v2021_09_01_preview.AlertRules;


internal class AlertDetailsOverrideModel
{
    [JsonPropertyName("alertDescriptionFormat")]
    public string? AlertDescriptionFormat { get; set; }

    [JsonPropertyName("alertDisplayNameFormat")]
    public string? AlertDisplayNameFormat { get; set; }

    [JsonPropertyName("alertSeverityColumnName")]
    public string? AlertSeverityColumnName { get; set; }

    [JsonPropertyName("alertTacticsColumnName")]
    public string? AlertTacticsColumnName { get; set; }
}
