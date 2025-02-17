// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.OperationalInsights.Models
{
    internal partial class SearchMetadataSchema
    {
        internal static SearchMetadataSchema DeserializeSearchMetadataSchema(JsonElement element)
        {
            Optional<string> name = default;
            Optional<int> version = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("version"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    version = property.Value.GetInt32();
                    continue;
                }
            }
            return new SearchMetadataSchema(name.Value, Optional.ToNullable(version));
        }
    }
}
