// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Monitor.Models
{
    public partial class MonitorLogicAppReceiver : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            writer.WritePropertyName("resourceId"u8);
            writer.WriteStringValue(ResourceId);
            writer.WritePropertyName("callbackUrl"u8);
            writer.WriteStringValue(CallbackUri.AbsoluteUri);
            if (Optional.IsDefined(UseCommonAlertSchema))
            {
                writer.WritePropertyName("useCommonAlertSchema"u8);
                writer.WriteBooleanValue(UseCommonAlertSchema.Value);
            }
            writer.WriteEndObject();
        }

        internal static MonitorLogicAppReceiver DeserializeMonitorLogicAppReceiver(JsonElement element)
        {
            string name = default;
            ResourceIdentifier resourceId = default;
            Uri callbackUrl = default;
            Optional<bool> useCommonAlertSchema = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resourceId"u8))
                {
                    resourceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("callbackUrl"u8))
                {
                    callbackUrl = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("useCommonAlertSchema"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    useCommonAlertSchema = property.Value.GetBoolean();
                    continue;
                }
            }
            return new MonitorLogicAppReceiver(name, resourceId, callbackUrl, Optional.ToNullable(useCommonAlertSchema));
        }
    }
}
