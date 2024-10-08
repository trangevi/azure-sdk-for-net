// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> The JitNetworkAccessPortProtocol. </summary>
    public readonly partial struct JitNetworkAccessPortProtocol : IEquatable<JitNetworkAccessPortProtocol>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="JitNetworkAccessPortProtocol"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public JitNetworkAccessPortProtocol(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string TcpValue = "TCP";
        private const string UdpValue = "UDP";
        private const string AllValue = "*";

        /// <summary> TCP. </summary>
        public static JitNetworkAccessPortProtocol Tcp { get; } = new JitNetworkAccessPortProtocol(TcpValue);
        /// <summary> UDP. </summary>
        public static JitNetworkAccessPortProtocol Udp { get; } = new JitNetworkAccessPortProtocol(UdpValue);
        /// <summary> *. </summary>
        public static JitNetworkAccessPortProtocol All { get; } = new JitNetworkAccessPortProtocol(AllValue);
        /// <summary> Determines if two <see cref="JitNetworkAccessPortProtocol"/> values are the same. </summary>
        public static bool operator ==(JitNetworkAccessPortProtocol left, JitNetworkAccessPortProtocol right) => left.Equals(right);
        /// <summary> Determines if two <see cref="JitNetworkAccessPortProtocol"/> values are not the same. </summary>
        public static bool operator !=(JitNetworkAccessPortProtocol left, JitNetworkAccessPortProtocol right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="JitNetworkAccessPortProtocol"/>. </summary>
        public static implicit operator JitNetworkAccessPortProtocol(string value) => new JitNetworkAccessPortProtocol(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is JitNetworkAccessPortProtocol other && Equals(other);
        /// <inheritdoc />
        public bool Equals(JitNetworkAccessPortProtocol other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
