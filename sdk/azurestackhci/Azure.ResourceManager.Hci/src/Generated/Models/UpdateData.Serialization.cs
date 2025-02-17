// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Hci.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Hci
{
    public partial class UpdateData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Location))
            {
                writer.WritePropertyName("location"u8);
                writer.WriteStringValue(Location.Value);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(InstalledOn))
            {
                writer.WritePropertyName("installedDate"u8);
                writer.WriteStringValue(InstalledOn.Value, "O");
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(State))
            {
                writer.WritePropertyName("state"u8);
                writer.WriteStringValue(State.Value.ToString());
            }
            if (Optional.IsCollectionDefined(Prerequisites))
            {
                writer.WritePropertyName("prerequisites"u8);
                writer.WriteStartArray();
                foreach (var item in Prerequisites)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(ComponentVersions))
            {
                writer.WritePropertyName("componentVersions"u8);
                writer.WriteStartArray();
                foreach (var item in ComponentVersions)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(RebootRequired))
            {
                writer.WritePropertyName("rebootRequired"u8);
                writer.WriteStringValue(RebootRequired.Value.ToString());
            }
            if (Optional.IsDefined(HealthState))
            {
                writer.WritePropertyName("healthState"u8);
                writer.WriteStringValue(HealthState.Value.ToString());
            }
            if (Optional.IsCollectionDefined(HealthCheckResult))
            {
                writer.WritePropertyName("healthCheckResult"u8);
                writer.WriteStartArray();
                foreach (var item in HealthCheckResult)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(HealthCheckOn))
            {
                writer.WritePropertyName("healthCheckDate"u8);
                writer.WriteStringValue(HealthCheckOn.Value, "O");
            }
            if (Optional.IsDefined(PackagePath))
            {
                writer.WritePropertyName("packagePath"u8);
                writer.WriteStringValue(PackagePath);
            }
            if (Optional.IsDefined(PackageSizeInMb))
            {
                writer.WritePropertyName("packageSizeInMb"u8);
                writer.WriteNumberValue(PackageSizeInMb.Value);
            }
            if (Optional.IsDefined(DisplayName))
            {
                writer.WritePropertyName("displayName"u8);
                writer.WriteStringValue(DisplayName);
            }
            if (Optional.IsDefined(Version))
            {
                writer.WritePropertyName("version"u8);
                writer.WriteStringValue(Version);
            }
            if (Optional.IsDefined(Publisher))
            {
                writer.WritePropertyName("publisher"u8);
                writer.WriteStringValue(Publisher);
            }
            if (Optional.IsDefined(ReleaseLink))
            {
                writer.WritePropertyName("releaseLink"u8);
                writer.WriteStringValue(ReleaseLink);
            }
            if (Optional.IsDefined(AvailabilityType))
            {
                writer.WritePropertyName("availabilityType"u8);
                writer.WriteStringValue(AvailabilityType.Value.ToString());
            }
            if (Optional.IsDefined(PackageType))
            {
                writer.WritePropertyName("packageType"u8);
                writer.WriteStringValue(PackageType);
            }
            if (Optional.IsDefined(AdditionalProperties))
            {
                writer.WritePropertyName("additionalProperties"u8);
                writer.WriteStringValue(AdditionalProperties);
            }
            writer.WritePropertyName("updateStateProperties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(ProgressPercentage))
            {
                writer.WritePropertyName("progressPercentage"u8);
                writer.WriteNumberValue(ProgressPercentage.Value);
            }
            if (Optional.IsDefined(NotifyMessage))
            {
                writer.WritePropertyName("notifyMessage"u8);
                writer.WriteStringValue(NotifyMessage);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static UpdateData DeserializeUpdateData(JsonElement element)
        {
            Optional<AzureLocation> location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<HciProvisioningState> provisioningState = default;
            Optional<DateTimeOffset> installedDate = default;
            Optional<string> description = default;
            Optional<HciUpdateState> state = default;
            Optional<IList<UpdatePrerequisite>> prerequisites = default;
            Optional<IList<HciPackageVersionInfo>> componentVersions = default;
            Optional<HciNodeRebootRequirement> rebootRequired = default;
            Optional<HciHealthState> healthState = default;
            Optional<IList<HciPrecheckResult>> healthCheckResult = default;
            Optional<DateTimeOffset> healthCheckDate = default;
            Optional<string> packagePath = default;
            Optional<float> packageSizeInMb = default;
            Optional<string> displayName = default;
            Optional<string> version = default;
            Optional<string> publisher = default;
            Optional<string> releaseLink = default;
            Optional<HciAvailabilityType> availabilityType = default;
            Optional<string> packageType = default;
            Optional<string> additionalProperties = default;
            Optional<float> progressPercentage = default;
            Optional<string> notifyMessage = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("location"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
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
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            provisioningState = new HciProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("installedDate"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            installedDate = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("description"u8))
                        {
                            description = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("state"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            state = new HciUpdateState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("prerequisites"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<UpdatePrerequisite> array = new List<UpdatePrerequisite>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(UpdatePrerequisite.DeserializeUpdatePrerequisite(item));
                            }
                            prerequisites = array;
                            continue;
                        }
                        if (property0.NameEquals("componentVersions"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<HciPackageVersionInfo> array = new List<HciPackageVersionInfo>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(HciPackageVersionInfo.DeserializeHciPackageVersionInfo(item));
                            }
                            componentVersions = array;
                            continue;
                        }
                        if (property0.NameEquals("rebootRequired"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            rebootRequired = new HciNodeRebootRequirement(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("healthState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            healthState = new HciHealthState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("healthCheckResult"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<HciPrecheckResult> array = new List<HciPrecheckResult>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(HciPrecheckResult.DeserializeHciPrecheckResult(item));
                            }
                            healthCheckResult = array;
                            continue;
                        }
                        if (property0.NameEquals("healthCheckDate"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            healthCheckDate = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("packagePath"u8))
                        {
                            packagePath = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("packageSizeInMb"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            packageSizeInMb = property0.Value.GetSingle();
                            continue;
                        }
                        if (property0.NameEquals("displayName"u8))
                        {
                            displayName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("version"u8))
                        {
                            version = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("publisher"u8))
                        {
                            publisher = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("releaseLink"u8))
                        {
                            releaseLink = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("availabilityType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            availabilityType = new HciAvailabilityType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("packageType"u8))
                        {
                            packageType = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("additionalProperties"u8))
                        {
                            additionalProperties = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("updateStateProperties"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                if (property1.NameEquals("progressPercentage"u8))
                                {
                                    if (property1.Value.ValueKind == JsonValueKind.Null)
                                    {
                                        property1.ThrowNonNullablePropertyIsNull();
                                        continue;
                                    }
                                    progressPercentage = property1.Value.GetSingle();
                                    continue;
                                }
                                if (property1.NameEquals("notifyMessage"u8))
                                {
                                    notifyMessage = property1.Value.GetString();
                                    continue;
                                }
                            }
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new UpdateData(id, name, type, systemData.Value, Optional.ToNullable(location), Optional.ToNullable(provisioningState), Optional.ToNullable(installedDate), description.Value, Optional.ToNullable(state), Optional.ToList(prerequisites), Optional.ToList(componentVersions), Optional.ToNullable(rebootRequired), Optional.ToNullable(healthState), Optional.ToList(healthCheckResult), Optional.ToNullable(healthCheckDate), packagePath.Value, Optional.ToNullable(packageSizeInMb), displayName.Value, version.Value, publisher.Value, releaseLink.Value, Optional.ToNullable(availabilityType), packageType.Value, additionalProperties.Value, Optional.ToNullable(progressPercentage), notifyMessage.Value);
        }
    }
}
