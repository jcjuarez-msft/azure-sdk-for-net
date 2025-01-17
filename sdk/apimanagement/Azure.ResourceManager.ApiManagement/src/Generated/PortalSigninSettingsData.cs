// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ApiManagement
{
    /// <summary> A class representing the PortalSigninSettings data model. </summary>
    public partial class PortalSigninSettingsData : ResourceData
    {
        /// <summary> Initializes a new instance of PortalSigninSettingsData. </summary>
        public PortalSigninSettingsData()
        {
        }

        /// <summary> Initializes a new instance of PortalSigninSettingsData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="enabled"> Redirect Anonymous users to the Sign-In page. </param>
        internal PortalSigninSettingsData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, bool? enabled) : base(id, name, resourceType, systemData)
        {
            Enabled = enabled;
        }

        /// <summary> Redirect Anonymous users to the Sign-In page. </summary>
        public bool? Enabled { get; set; }
    }
}
