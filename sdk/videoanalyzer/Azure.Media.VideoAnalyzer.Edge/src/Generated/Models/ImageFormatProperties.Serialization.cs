// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Media.VideoAnalyzer.Edge.Models
{
    public partial class ImageFormatProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("@type"u8);
            writer.WriteStringValue(Type);
            writer.WriteEndObject();
        }

        internal static ImageFormatProperties DeserializeImageFormatProperties(JsonElement element)
        {
            if (element.TryGetProperty("@type", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "#Microsoft.VideoAnalyzer.ImageFormatBmp": return ImageFormatBmp.DeserializeImageFormatBmp(element);
                    case "#Microsoft.VideoAnalyzer.ImageFormatJpeg": return ImageFormatJpeg.DeserializeImageFormatJpeg(element);
                    case "#Microsoft.VideoAnalyzer.ImageFormatPng": return ImageFormatPng.DeserializeImageFormatPng(element);
                    case "#Microsoft.VideoAnalyzer.ImageFormatRaw": return ImageFormatRaw.DeserializeImageFormatRaw(element);
                }
            }
            return UnknownImageFormatProperties.DeserializeUnknownImageFormatProperties(element);
        }
    }
}
