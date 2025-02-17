// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Storage.Models
{
    public partial class StorageAccountSkuConversionStatus : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(TargetSkuName))
            {
                writer.WritePropertyName("targetSkuName"u8);
                writer.WriteStringValue(TargetSkuName.Value.ToString());
            }
            writer.WriteEndObject();
        }

        internal static StorageAccountSkuConversionStatus DeserializeStorageAccountSkuConversionStatus(JsonElement element)
        {
            Optional<StorageAccountSkuConversionState> skuConversionStatus = default;
            Optional<StorageSkuName> targetSkuName = default;
            Optional<DateTimeOffset> startTime = default;
            Optional<DateTimeOffset> endTime = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("skuConversionStatus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    skuConversionStatus = new StorageAccountSkuConversionState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("targetSkuName"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    targetSkuName = new StorageSkuName(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("startTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    startTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("endTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    endTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
            }
            return new StorageAccountSkuConversionStatus(Optional.ToNullable(skuConversionStatus), Optional.ToNullable(targetSkuName), Optional.ToNullable(startTime), Optional.ToNullable(endTime));
        }
    }
}
