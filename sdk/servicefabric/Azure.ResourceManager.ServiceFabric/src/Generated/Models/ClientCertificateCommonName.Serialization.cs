// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ServiceFabric.Models
{
    public partial class ClientCertificateCommonName : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("isAdmin");
            writer.WriteBooleanValue(IsAdmin);
            writer.WritePropertyName("certificateCommonName");
            writer.WriteStringValue(CertificateCommonName);
            writer.WritePropertyName("certificateIssuerThumbprint");
            writer.WriteStringValue(CertificateIssuerThumbprint);
            writer.WriteEndObject();
        }

        internal static ClientCertificateCommonName DeserializeClientCertificateCommonName(JsonElement element)
        {
            bool isAdmin = default;
            string certificateCommonName = default;
            string certificateIssuerThumbprint = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("isAdmin"))
                {
                    isAdmin = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("certificateCommonName"))
                {
                    certificateCommonName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("certificateIssuerThumbprint"))
                {
                    certificateIssuerThumbprint = property.Value.GetString();
                    continue;
                }
            }
            return new ClientCertificateCommonName(isAdmin, certificateCommonName, certificateIssuerThumbprint);
        }
    }
}
