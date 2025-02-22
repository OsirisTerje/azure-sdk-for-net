// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.SignalR.Models;

namespace Azure.ResourceManager.SignalR
{
    public partial class SignalRData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Sku))
            {
                writer.WritePropertyName("sku");
                writer.WriteObjectValue(Sku);
            }
            if (Optional.IsDefined(Kind))
            {
                writer.WritePropertyName("kind");
                writer.WriteStringValue(Kind.Value.ToString());
            }
            if (Optional.IsDefined(Identity))
            {
                writer.WritePropertyName("identity");
                JsonSerializer.Serialize(writer, Identity);
            }
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags");
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("location");
            writer.WriteStringValue(Location);
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(Tls))
            {
                writer.WritePropertyName("tls");
                writer.WriteObjectValue(Tls);
            }
            if (Optional.IsCollectionDefined(Features))
            {
                writer.WritePropertyName("features");
                writer.WriteStartArray();
                foreach (var item in Features)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(LiveTraceConfiguration))
            {
                writer.WritePropertyName("liveTraceConfiguration");
                writer.WriteObjectValue(LiveTraceConfiguration);
            }
            if (Optional.IsDefined(ResourceLogConfiguration))
            {
                writer.WritePropertyName("resourceLogConfiguration");
                writer.WriteObjectValue(ResourceLogConfiguration);
            }
            if (Optional.IsDefined(Cors))
            {
                writer.WritePropertyName("cors");
                writer.WriteObjectValue(Cors);
            }
            if (Optional.IsDefined(Upstream))
            {
                writer.WritePropertyName("upstream");
                writer.WriteObjectValue(Upstream);
            }
            if (Optional.IsDefined(NetworkACLs))
            {
                writer.WritePropertyName("networkACLs");
                writer.WriteObjectValue(NetworkACLs);
            }
            if (Optional.IsDefined(PublicNetworkAccess))
            {
                writer.WritePropertyName("publicNetworkAccess");
                writer.WriteStringValue(PublicNetworkAccess);
            }
            if (Optional.IsDefined(DisableLocalAuth))
            {
                writer.WritePropertyName("disableLocalAuth");
                writer.WriteBooleanValue(DisableLocalAuth.Value);
            }
            if (Optional.IsDefined(DisableAadAuth))
            {
                writer.WritePropertyName("disableAadAuth");
                writer.WriteBooleanValue(DisableAadAuth.Value);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static SignalRData DeserializeSignalRData(JsonElement element)
        {
            Optional<ResourceSku> sku = default;
            Optional<ServiceKind> kind = default;
            Optional<ManagedServiceIdentity> identity = default;
            Optional<IDictionary<string, string>> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<ProvisioningState> provisioningState = default;
            Optional<string> externalIP = default;
            Optional<string> hostName = default;
            Optional<int> publicPort = default;
            Optional<int> serverPort = default;
            Optional<string> version = default;
            Optional<IReadOnlyList<SignalRPrivateEndpointConnectionData>> privateEndpointConnections = default;
            Optional<IReadOnlyList<SharedPrivateLinkResourceData>> sharedPrivateLinkResources = default;
            Optional<SignalRTlsSettings> tls = default;
            Optional<string> hostNamePrefix = default;
            Optional<IList<SignalRFeature>> features = default;
            Optional<LiveTraceConfiguration> liveTraceConfiguration = default;
            Optional<ResourceLogConfiguration> resourceLogConfiguration = default;
            Optional<SignalRCorsSettings> cors = default;
            Optional<ServerlessUpstreamSettings> upstream = default;
            Optional<SignalRNetworkACLs> networkACLs = default;
            Optional<string> publicNetworkAccess = default;
            Optional<bool> disableLocalAuth = default;
            Optional<bool> disableAadAuth = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sku"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    sku = ResourceSku.DeserializeResourceSku(property.Value);
                    continue;
                }
                if (property.NameEquals("kind"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    kind = new ServiceKind(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("identity"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    identity = JsonSerializer.Deserialize<ManagedServiceIdentity>(property.Value.ToString());
                    continue;
                }
                if (property.NameEquals("tags"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("location"))
                {
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.ToString());
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("provisioningState"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            provisioningState = new ProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("externalIP"))
                        {
                            externalIP = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("hostName"))
                        {
                            hostName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("publicPort"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            publicPort = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("serverPort"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            serverPort = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("version"))
                        {
                            version = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("privateEndpointConnections"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<SignalRPrivateEndpointConnectionData> array = new List<SignalRPrivateEndpointConnectionData>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(SignalRPrivateEndpointConnectionData.DeserializeSignalRPrivateEndpointConnectionData(item));
                            }
                            privateEndpointConnections = array;
                            continue;
                        }
                        if (property0.NameEquals("sharedPrivateLinkResources"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<SharedPrivateLinkResourceData> array = new List<SharedPrivateLinkResourceData>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(SharedPrivateLinkResourceData.DeserializeSharedPrivateLinkResourceData(item));
                            }
                            sharedPrivateLinkResources = array;
                            continue;
                        }
                        if (property0.NameEquals("tls"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            tls = SignalRTlsSettings.DeserializeSignalRTlsSettings(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("hostNamePrefix"))
                        {
                            hostNamePrefix = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("features"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<SignalRFeature> array = new List<SignalRFeature>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(SignalRFeature.DeserializeSignalRFeature(item));
                            }
                            features = array;
                            continue;
                        }
                        if (property0.NameEquals("liveTraceConfiguration"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            liveTraceConfiguration = LiveTraceConfiguration.DeserializeLiveTraceConfiguration(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("resourceLogConfiguration"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            resourceLogConfiguration = ResourceLogConfiguration.DeserializeResourceLogConfiguration(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("cors"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            cors = SignalRCorsSettings.DeserializeSignalRCorsSettings(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("upstream"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            upstream = ServerlessUpstreamSettings.DeserializeServerlessUpstreamSettings(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("networkACLs"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            networkACLs = SignalRNetworkACLs.DeserializeSignalRNetworkACLs(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("publicNetworkAccess"))
                        {
                            publicNetworkAccess = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("disableLocalAuth"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            disableLocalAuth = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("disableAadAuth"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            disableAadAuth = property0.Value.GetBoolean();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new SignalRData(id, name, type, systemData.Value, Optional.ToDictionary(tags), location, sku.Value, Optional.ToNullable(kind), identity, Optional.ToNullable(provisioningState), externalIP.Value, hostName.Value, Optional.ToNullable(publicPort), Optional.ToNullable(serverPort), version.Value, Optional.ToList(privateEndpointConnections), Optional.ToList(sharedPrivateLinkResources), tls.Value, hostNamePrefix.Value, Optional.ToList(features), liveTraceConfiguration.Value, resourceLogConfiguration.Value, cors.Value, upstream.Value, networkACLs.Value, publicNetworkAccess.Value, Optional.ToNullable(disableLocalAuth), Optional.ToNullable(disableAadAuth));
        }
    }
}
