// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ProviderHub.Models
{
    public partial class NotificationRegistrationProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(NotificationMode))
            {
                writer.WritePropertyName("notificationMode"u8);
                writer.WriteStringValue(NotificationMode.Value.ToString());
            }
            if (Optional.IsDefined(MessageScope))
            {
                writer.WritePropertyName("messageScope"u8);
                writer.WriteStringValue(MessageScope.Value.ToString());
            }
            if (Optional.IsCollectionDefined(IncludedEvents))
            {
                writer.WritePropertyName("includedEvents"u8);
                writer.WriteStartArray();
                foreach (var item in IncludedEvents)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(NotificationEndpoints))
            {
                writer.WritePropertyName("notificationEndpoints"u8);
                writer.WriteStartArray();
                foreach (var item in NotificationEndpoints)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            writer.WriteEndObject();
        }

        internal static NotificationRegistrationProperties DeserializeNotificationRegistrationProperties(JsonElement element)
        {
            Optional<NotificationMode> notificationMode = default;
            Optional<MessageScope> messageScope = default;
            Optional<IList<string>> includedEvents = default;
            Optional<IList<NotificationEndpoint>> notificationEndpoints = default;
            Optional<ProvisioningState> provisioningState = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("notificationMode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    notificationMode = new NotificationMode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("messageScope"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    messageScope = new MessageScope(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("includedEvents"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    includedEvents = array;
                    continue;
                }
                if (property.NameEquals("notificationEndpoints"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<NotificationEndpoint> array = new List<NotificationEndpoint>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(NotificationEndpoint.DeserializeNotificationEndpoint(item));
                    }
                    notificationEndpoints = array;
                    continue;
                }
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    provisioningState = new ProvisioningState(property.Value.GetString());
                    continue;
                }
            }
            return new NotificationRegistrationProperties(Optional.ToNullable(notificationMode), Optional.ToNullable(messageScope), Optional.ToList(includedEvents), Optional.ToList(notificationEndpoints), Optional.ToNullable(provisioningState));
        }
    }
}
