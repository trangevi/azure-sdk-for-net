// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.DataBoxEdge.Models
{
    /// <summary> Remote application type. </summary>
    public readonly partial struct EdgeRemoteApplicationType : IEquatable<EdgeRemoteApplicationType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="EdgeRemoteApplicationType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public EdgeRemoteApplicationType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string PowershellValue = "Powershell";
        private const string WacValue = "WAC";
        private const string LocalUIValue = "LocalUI";
        private const string AllApplicationsValue = "AllApplications";

        /// <summary> Powershell. </summary>
        public static EdgeRemoteApplicationType Powershell { get; } = new EdgeRemoteApplicationType(PowershellValue);
        /// <summary> WAC. </summary>
        public static EdgeRemoteApplicationType Wac { get; } = new EdgeRemoteApplicationType(WacValue);
        /// <summary> LocalUI. </summary>
        public static EdgeRemoteApplicationType LocalUI { get; } = new EdgeRemoteApplicationType(LocalUIValue);
        /// <summary> AllApplications. </summary>
        public static EdgeRemoteApplicationType AllApplications { get; } = new EdgeRemoteApplicationType(AllApplicationsValue);
        /// <summary> Determines if two <see cref="EdgeRemoteApplicationType"/> values are the same. </summary>
        public static bool operator ==(EdgeRemoteApplicationType left, EdgeRemoteApplicationType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="EdgeRemoteApplicationType"/> values are not the same. </summary>
        public static bool operator !=(EdgeRemoteApplicationType left, EdgeRemoteApplicationType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="EdgeRemoteApplicationType"/>. </summary>
        public static implicit operator EdgeRemoteApplicationType(string value) => new EdgeRemoteApplicationType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is EdgeRemoteApplicationType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(EdgeRemoteApplicationType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
