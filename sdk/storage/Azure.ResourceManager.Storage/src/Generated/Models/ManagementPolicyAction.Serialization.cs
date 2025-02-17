// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Storage.Models
{
    public partial class ManagementPolicyAction : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(BaseBlob))
            {
                writer.WritePropertyName("baseBlob"u8);
                writer.WriteObjectValue(BaseBlob);
            }
            if (Optional.IsDefined(Snapshot))
            {
                writer.WritePropertyName("snapshot"u8);
                writer.WriteObjectValue(Snapshot);
            }
            if (Optional.IsDefined(Version))
            {
                writer.WritePropertyName("version"u8);
                writer.WriteObjectValue(Version);
            }
            writer.WriteEndObject();
        }

        internal static ManagementPolicyAction DeserializeManagementPolicyAction(JsonElement element)
        {
            Optional<ManagementPolicyBaseBlob> baseBlob = default;
            Optional<ManagementPolicySnapShot> snapshot = default;
            Optional<ManagementPolicyVersion> version = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("baseBlob"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    baseBlob = ManagementPolicyBaseBlob.DeserializeManagementPolicyBaseBlob(property.Value);
                    continue;
                }
                if (property.NameEquals("snapshot"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    snapshot = ManagementPolicySnapShot.DeserializeManagementPolicySnapShot(property.Value);
                    continue;
                }
                if (property.NameEquals("version"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    version = ManagementPolicyVersion.DeserializeManagementPolicyVersion(property.Value);
                    continue;
                }
            }
            return new ManagementPolicyAction(baseBlob.Value, snapshot.Value, version.Value);
        }
    }
}
