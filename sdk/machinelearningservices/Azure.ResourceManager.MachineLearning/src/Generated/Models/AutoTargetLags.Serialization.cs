// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class AutoTargetLags : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("mode"u8);
            writer.WriteStringValue(Mode.ToString());
            writer.WriteEndObject();
        }

        internal static AutoTargetLags DeserializeAutoTargetLags(JsonElement element)
        {
            TargetLagsMode mode = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("mode"u8))
                {
                    mode = new TargetLagsMode(property.Value.GetString());
                    continue;
                }
            }
            return new AutoTargetLags(mode);
        }
    }
}
