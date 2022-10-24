using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.SecurityInsights.v2022_07_01_preview.Entities;


internal class TimelineErrorModel
{
    [JsonPropertyName("errorMessage")]
    [Required]
    public string ErrorMessage { get; set; }

    [JsonPropertyName("kind")]
    [Required]
    public EntityTimelineKindConstant Kind { get; set; }

    [JsonPropertyName("queryId")]
    public string? QueryId { get; set; }
}
