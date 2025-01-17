// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ServiceFabric.Models
{
    /// <summary> The kind of service (Stateless or Stateful). </summary>
    internal readonly partial struct ServiceKind : IEquatable<ServiceKind>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ServiceKind"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ServiceKind(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string InvalidValue = "Invalid";
        private const string StatelessValue = "Stateless";
        private const string StatefulValue = "Stateful";

        /// <summary> Indicates the service kind is invalid. All Service Fabric enumerations have the invalid type. The value is zero. </summary>
        public static ServiceKind Invalid { get; } = new ServiceKind(InvalidValue);
        /// <summary> Does not use Service Fabric to make its state highly available or reliable. The value is 1. </summary>
        public static ServiceKind Stateless { get; } = new ServiceKind(StatelessValue);
        /// <summary> Uses Service Fabric to make its state or part of its state highly available and reliable. The value is 2. </summary>
        public static ServiceKind Stateful { get; } = new ServiceKind(StatefulValue);
        /// <summary> Determines if two <see cref="ServiceKind"/> values are the same. </summary>
        public static bool operator ==(ServiceKind left, ServiceKind right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ServiceKind"/> values are not the same. </summary>
        public static bool operator !=(ServiceKind left, ServiceKind right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ServiceKind"/>. </summary>
        public static implicit operator ServiceKind(string value) => new ServiceKind(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ServiceKind other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ServiceKind other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
