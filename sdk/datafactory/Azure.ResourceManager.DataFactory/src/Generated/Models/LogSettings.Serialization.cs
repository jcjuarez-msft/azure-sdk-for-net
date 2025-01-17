// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataFactory.Models
{
    public partial class LogSettings : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(EnableCopyActivityLog))
            {
                writer.WritePropertyName("enableCopyActivityLog");
#if NET6_0_OR_GREATER
				writer.WriteRawValue(EnableCopyActivityLog);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(EnableCopyActivityLog.ToString()).RootElement);
#endif
            }
            if (Optional.IsDefined(CopyActivityLogSettings))
            {
                writer.WritePropertyName("copyActivityLogSettings");
                writer.WriteObjectValue(CopyActivityLogSettings);
            }
            writer.WritePropertyName("logLocationSettings");
            writer.WriteObjectValue(LogLocationSettings);
            writer.WriteEndObject();
        }

        internal static LogSettings DeserializeLogSettings(JsonElement element)
        {
            Optional<BinaryData> enableCopyActivityLog = default;
            Optional<CopyActivityLogSettings> copyActivityLogSettings = default;
            LogLocationSettings logLocationSettings = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("enableCopyActivityLog"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    enableCopyActivityLog = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("copyActivityLogSettings"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    copyActivityLogSettings = CopyActivityLogSettings.DeserializeCopyActivityLogSettings(property.Value);
                    continue;
                }
                if (property.NameEquals("logLocationSettings"))
                {
                    logLocationSettings = LogLocationSettings.DeserializeLogLocationSettings(property.Value);
                    continue;
                }
            }
            return new LogSettings(enableCopyActivityLog.Value, copyActivityLogSettings.Value, logLocationSettings);
        }
    }
}
