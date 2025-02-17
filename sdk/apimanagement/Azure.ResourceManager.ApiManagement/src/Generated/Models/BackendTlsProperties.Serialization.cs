// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ApiManagement.Models
{
    public partial class BackendTlsProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ShouldValidateCertificateChain))
            {
                writer.WritePropertyName("validateCertificateChain"u8);
                writer.WriteBooleanValue(ShouldValidateCertificateChain.Value);
            }
            if (Optional.IsDefined(ShouldValidateCertificateName))
            {
                writer.WritePropertyName("validateCertificateName"u8);
                writer.WriteBooleanValue(ShouldValidateCertificateName.Value);
            }
            writer.WriteEndObject();
        }

        internal static BackendTlsProperties DeserializeBackendTlsProperties(JsonElement element)
        {
            Optional<bool> validateCertificateChain = default;
            Optional<bool> validateCertificateName = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("validateCertificateChain"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    validateCertificateChain = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("validateCertificateName"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    validateCertificateName = property.Value.GetBoolean();
                    continue;
                }
            }
            return new BackendTlsProperties(Optional.ToNullable(validateCertificateChain), Optional.ToNullable(validateCertificateName));
        }
    }
}
