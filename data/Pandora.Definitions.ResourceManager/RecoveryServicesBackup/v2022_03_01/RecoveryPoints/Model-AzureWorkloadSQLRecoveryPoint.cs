using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.RecoveryServicesBackup.v2022_03_01.RecoveryPoints;

[ValueForType("AzureWorkloadSQLRecoveryPoint")]
internal class AzureWorkloadSQLRecoveryPointModel : RecoveryPointModel
{
    [JsonPropertyName("extendedInfo")]
    public AzureWorkloadSQLRecoveryPointExtendedInfoModel? ExtendedInfo { get; set; }

    [JsonPropertyName("recoveryPointMoveReadinessInfo")]
    public Dictionary<string, RecoveryPointMoveReadinessInfoModel>? RecoveryPointMoveReadinessInfo { get; set; }

    [JsonPropertyName("recoveryPointTierDetails")]
    public List<RecoveryPointTierInformationV2Model>? RecoveryPointTierDetails { get; set; }

    [DateFormat(DateFormatAttribute.DateFormat.RFC3339)]
    [JsonPropertyName("recoveryPointTimeInUTC")]
    public DateTime? RecoveryPointTimeInUTC { get; set; }

    [JsonPropertyName("type")]
    public RestorePointTypeConstant? Type { get; set; }
}
