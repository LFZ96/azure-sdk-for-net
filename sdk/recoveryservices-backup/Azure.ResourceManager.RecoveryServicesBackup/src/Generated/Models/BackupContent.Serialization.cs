// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    public partial class BackupContent : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("objectType"u8);
            writer.WriteStringValue(ObjectType);
            writer.WriteEndObject();
        }

        internal static BackupContent DeserializeBackupContent(JsonElement element)
        {
            if (element.TryGetProperty("objectType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "AzureFileShareBackupRequest": return FileShareBackupContent.DeserializeFileShareBackupContent(element);
                    case "AzureWorkloadBackupRequest": return WorkloadBackupContent.DeserializeWorkloadBackupContent(element);
                    case "IaasVMBackupRequest": return IaasVmBackupContent.DeserializeIaasVmBackupContent(element);
                }
            }
            return UnknownBackupRequest.DeserializeUnknownBackupRequest(element);
        }
    }
}
