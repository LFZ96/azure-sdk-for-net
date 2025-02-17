// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataBox.Models
{
    public partial class ManagedDiskDetails : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("resourceGroupId"u8);
            writer.WriteStringValue(ResourceGroupId);
            writer.WritePropertyName("stagingStorageAccountId"u8);
            writer.WriteStringValue(StagingStorageAccountId);
            writer.WritePropertyName("dataAccountType"u8);
            writer.WriteStringValue(DataAccountType.ToSerialString());
            if (Optional.IsDefined(SharePassword))
            {
                writer.WritePropertyName("sharePassword"u8);
                writer.WriteStringValue(SharePassword);
            }
            writer.WriteEndObject();
        }

        internal static ManagedDiskDetails DeserializeManagedDiskDetails(JsonElement element)
        {
            ResourceIdentifier resourceGroupId = default;
            ResourceIdentifier stagingStorageAccountId = default;
            DataAccountType dataAccountType = default;
            Optional<string> sharePassword = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("resourceGroupId"u8))
                {
                    resourceGroupId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("stagingStorageAccountId"u8))
                {
                    stagingStorageAccountId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("dataAccountType"u8))
                {
                    dataAccountType = property.Value.GetString().ToDataAccountType();
                    continue;
                }
                if (property.NameEquals("sharePassword"u8))
                {
                    sharePassword = property.Value.GetString();
                    continue;
                }
            }
            return new ManagedDiskDetails(dataAccountType, sharePassword.Value, resourceGroupId, stagingStorageAccountId);
        }
    }
}
