// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Communication.JobRouter
{
    public partial class WeightedAllocationWorkerSelectorAttachment : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("allocations"u8);
            writer.WriteStartArray();
            foreach (var item in Allocations)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            writer.WritePropertyName("kind"u8);
            writer.WriteStringValue(Kind);
            writer.WriteEndObject();
        }

        internal static WeightedAllocationWorkerSelectorAttachment DeserializeWeightedAllocationWorkerSelectorAttachment(JsonElement element)
        {
            IList<WorkerWeightedAllocation> allocations = default;
            string kind = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("allocations"u8))
                {
                    List<WorkerWeightedAllocation> array = new List<WorkerWeightedAllocation>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(WorkerWeightedAllocation.DeserializeWorkerWeightedAllocation(item));
                    }
                    allocations = array;
                    continue;
                }
                if (property.NameEquals("kind"u8))
                {
                    kind = property.Value.GetString();
                    continue;
                }
            }
            return new WeightedAllocationWorkerSelectorAttachment(kind, allocations);
        }
    }
}
