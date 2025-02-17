// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    public partial class GitHubActionWebAppStackSettings
    {
        internal static GitHubActionWebAppStackSettings DeserializeGitHubActionWebAppStackSettings(JsonElement element)
        {
            Optional<bool> isSupported = default;
            Optional<string> supportedVersion = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("isSupported"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    isSupported = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("supportedVersion"u8))
                {
                    supportedVersion = property.Value.GetString();
                    continue;
                }
            }
            return new GitHubActionWebAppStackSettings(Optional.ToNullable(isSupported), supportedVersion.Value);
        }
    }
}
