// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.OracleDatabase.Models
{
    /// <summary> Host format type enum. </summary>
    public readonly partial struct ConnectionHostFormatType : IEquatable<ConnectionHostFormatType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ConnectionHostFormatType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ConnectionHostFormatType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string FqdnValue = "Fqdn";
        private const string IPValue = "Ip";

        /// <summary> FQDN format. </summary>
        public static ConnectionHostFormatType Fqdn { get; } = new ConnectionHostFormatType(FqdnValue);
        /// <summary> IP format. </summary>
        public static ConnectionHostFormatType IP { get; } = new ConnectionHostFormatType(IPValue);
        /// <summary> Determines if two <see cref="ConnectionHostFormatType"/> values are the same. </summary>
        public static bool operator ==(ConnectionHostFormatType left, ConnectionHostFormatType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ConnectionHostFormatType"/> values are not the same. </summary>
        public static bool operator !=(ConnectionHostFormatType left, ConnectionHostFormatType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="ConnectionHostFormatType"/>. </summary>
        public static implicit operator ConnectionHostFormatType(string value) => new ConnectionHostFormatType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ConnectionHostFormatType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ConnectionHostFormatType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
