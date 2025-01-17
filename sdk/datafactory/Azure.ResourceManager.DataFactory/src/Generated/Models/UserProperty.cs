// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> User property. </summary>
    public partial class UserProperty
    {
        /// <summary> Initializes a new instance of UserProperty. </summary>
        /// <param name="name"> User property name. </param>
        /// <param name="value"> User property value. Type: string (or Expression with resultType string). </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="value"/> is null. </exception>
        public UserProperty(string name, BinaryData value)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            Name = name;
            Value = value;
        }

        /// <summary> User property name. </summary>
        public string Name { get; set; }
        /// <summary> User property value. Type: string (or Expression with resultType string). </summary>
        public BinaryData Value { get; set; }
    }
}
