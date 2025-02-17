// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Media.VideoAnalyzer.Edge.Models
{
    public partial class VideoResolution : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Width))
            {
                writer.WritePropertyName("width"u8);
                writer.WriteNumberValue(Width.Value);
            }
            if (Optional.IsDefined(Height))
            {
                writer.WritePropertyName("height"u8);
                writer.WriteNumberValue(Height.Value);
            }
            writer.WriteEndObject();
        }

        internal static VideoResolution DeserializeVideoResolution(JsonElement element)
        {
            Optional<float> width = default;
            Optional<float> height = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("width"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    width = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("height"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    height = property.Value.GetSingle();
                    continue;
                }
            }
            return new VideoResolution(Optional.ToNullable(width), Optional.ToNullable(height));
        }
    }
}
