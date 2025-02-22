// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Automation.Models
{
    public partial class DscConfigurationParameter : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(DscConfigurationParameterType))
            {
                writer.WritePropertyName("type");
                writer.WriteStringValue(DscConfigurationParameterType);
            }
            if (Optional.IsDefined(IsMandatory))
            {
                writer.WritePropertyName("isMandatory");
                writer.WriteBooleanValue(IsMandatory.Value);
            }
            if (Optional.IsDefined(Position))
            {
                writer.WritePropertyName("position");
                writer.WriteNumberValue(Position.Value);
            }
            if (Optional.IsDefined(DefaultValue))
            {
                writer.WritePropertyName("defaultValue");
                writer.WriteStringValue(DefaultValue);
            }
            writer.WriteEndObject();
        }

        internal static DscConfigurationParameter DeserializeDscConfigurationParameter(JsonElement element)
        {
            Optional<string> type = default;
            Optional<bool> isMandatory = default;
            Optional<int> position = default;
            Optional<string> defaultValue = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("isMandatory"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    isMandatory = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("position"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    position = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("defaultValue"))
                {
                    defaultValue = property.Value.GetString();
                    continue;
                }
            }
            return new DscConfigurationParameter(type.Value, Optional.ToNullable(isMandatory), Optional.ToNullable(position), defaultValue.Value);
        }
    }
}
