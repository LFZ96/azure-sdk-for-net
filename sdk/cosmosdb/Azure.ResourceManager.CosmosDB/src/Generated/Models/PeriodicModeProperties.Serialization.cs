// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    public partial class PeriodicModeProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(BackupIntervalInMinutes))
            {
                writer.WritePropertyName("backupIntervalInMinutes"u8);
                writer.WriteNumberValue(BackupIntervalInMinutes.Value);
            }
            if (Optional.IsDefined(BackupRetentionIntervalInHours))
            {
                writer.WritePropertyName("backupRetentionIntervalInHours"u8);
                writer.WriteNumberValue(BackupRetentionIntervalInHours.Value);
            }
            if (Optional.IsDefined(BackupStorageRedundancy))
            {
                writer.WritePropertyName("backupStorageRedundancy"u8);
                writer.WriteStringValue(BackupStorageRedundancy.Value.ToString());
            }
            writer.WriteEndObject();
        }

        internal static PeriodicModeProperties DeserializePeriodicModeProperties(JsonElement element)
        {
            Optional<int> backupIntervalInMinutes = default;
            Optional<int> backupRetentionIntervalInHours = default;
            Optional<CosmosDBBackupStorageRedundancy> backupStorageRedundancy = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("backupIntervalInMinutes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    backupIntervalInMinutes = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("backupRetentionIntervalInHours"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    backupRetentionIntervalInHours = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("backupStorageRedundancy"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    backupStorageRedundancy = new CosmosDBBackupStorageRedundancy(property.Value.GetString());
                    continue;
                }
            }
            return new PeriodicModeProperties(Optional.ToNullable(backupIntervalInMinutes), Optional.ToNullable(backupRetentionIntervalInHours), Optional.ToNullable(backupStorageRedundancy));
        }
    }
}
