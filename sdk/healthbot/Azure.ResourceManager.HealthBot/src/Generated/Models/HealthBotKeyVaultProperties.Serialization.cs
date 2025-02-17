// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HealthBot.Models
{
    public partial class HealthBotKeyVaultProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("keyName"u8);
            writer.WriteStringValue(KeyName);
            if (Optional.IsDefined(KeyVersion))
            {
                writer.WritePropertyName("keyVersion"u8);
                writer.WriteStringValue(KeyVersion);
            }
            writer.WritePropertyName("keyVaultUri"u8);
            writer.WriteStringValue(KeyVaultUri.AbsoluteUri);
            if (Optional.IsDefined(UserIdentity))
            {
                writer.WritePropertyName("userIdentity"u8);
                writer.WriteStringValue(UserIdentity);
            }
            writer.WriteEndObject();
        }

        internal static HealthBotKeyVaultProperties DeserializeHealthBotKeyVaultProperties(JsonElement element)
        {
            string keyName = default;
            Optional<string> keyVersion = default;
            Uri keyVaultUri = default;
            Optional<string> userIdentity = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("keyName"u8))
                {
                    keyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("keyVersion"u8))
                {
                    keyVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("keyVaultUri"u8))
                {
                    keyVaultUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("userIdentity"u8))
                {
                    userIdentity = property.Value.GetString();
                    continue;
                }
            }
            return new HealthBotKeyVaultProperties(keyName, keyVersion.Value, keyVaultUri, userIdentity.Value);
        }
    }
}
