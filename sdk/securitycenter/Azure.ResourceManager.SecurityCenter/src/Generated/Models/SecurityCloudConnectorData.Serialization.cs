// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.SecurityCenter.Models;

namespace Azure.ResourceManager.SecurityCenter
{
    public partial class SecurityCloudConnectorData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(HybridComputeSettings))
            {
                writer.WritePropertyName("hybridComputeSettings"u8);
                writer.WriteObjectValue(HybridComputeSettings);
            }
            if (Optional.IsDefined(AuthenticationDetails))
            {
                writer.WritePropertyName("authenticationDetails"u8);
                writer.WriteObjectValue(AuthenticationDetails);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static SecurityCloudConnectorData DeserializeSecurityCloudConnectorData(JsonElement element)
        {
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<HybridComputeSettingsProperties> hybridComputeSettings = default;
            Optional<AuthenticationDetailsProperties> authenticationDetails = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("hybridComputeSettings"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            hybridComputeSettings = HybridComputeSettingsProperties.DeserializeHybridComputeSettingsProperties(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("authenticationDetails"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            authenticationDetails = AuthenticationDetailsProperties.DeserializeAuthenticationDetailsProperties(property0.Value);
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new SecurityCloudConnectorData(id, name, type, systemData.Value, hybridComputeSettings.Value, authenticationDetails.Value);
        }
    }
}
