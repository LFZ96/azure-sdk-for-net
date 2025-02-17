// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    [JsonConverter(typeof(MediaLiveEventIncomingVideoStreamsOutOfSyncEventDataConverter))]
    public partial class MediaLiveEventIncomingVideoStreamsOutOfSyncEventData
    {
        internal static MediaLiveEventIncomingVideoStreamsOutOfSyncEventData DeserializeMediaLiveEventIncomingVideoStreamsOutOfSyncEventData(JsonElement element)
        {
            Optional<string> firstTimestamp = default;
            Optional<string> firstDuration = default;
            Optional<string> secondTimestamp = default;
            Optional<string> secondDuration = default;
            Optional<string> timescale = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("firstTimestamp"u8))
                {
                    firstTimestamp = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("firstDuration"u8))
                {
                    firstDuration = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("secondTimestamp"u8))
                {
                    secondTimestamp = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("secondDuration"u8))
                {
                    secondDuration = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("timescale"u8))
                {
                    timescale = property.Value.GetString();
                    continue;
                }
            }
            return new MediaLiveEventIncomingVideoStreamsOutOfSyncEventData(firstTimestamp.Value, firstDuration.Value, secondTimestamp.Value, secondDuration.Value, timescale.Value);
        }

        internal partial class MediaLiveEventIncomingVideoStreamsOutOfSyncEventDataConverter : JsonConverter<MediaLiveEventIncomingVideoStreamsOutOfSyncEventData>
        {
            public override void Write(Utf8JsonWriter writer, MediaLiveEventIncomingVideoStreamsOutOfSyncEventData model, JsonSerializerOptions options)
            {
                throw new NotImplementedException();
            }
            public override MediaLiveEventIncomingVideoStreamsOutOfSyncEventData Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeMediaLiveEventIncomingVideoStreamsOutOfSyncEventData(document.RootElement);
            }
        }
    }
}
