// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Express Route Circuit connection state. </summary>
    public readonly partial struct CircuitConnectionStatus : IEquatable<CircuitConnectionStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="CircuitConnectionStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public CircuitConnectionStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ConnectedValue = "Connected";
        private const string ConnectingValue = "Connecting";
        private const string DisconnectedValue = "Disconnected";

        /// <summary> Connected. </summary>
        public static CircuitConnectionStatus Connected { get; } = new CircuitConnectionStatus(ConnectedValue);
        /// <summary> Connecting. </summary>
        public static CircuitConnectionStatus Connecting { get; } = new CircuitConnectionStatus(ConnectingValue);
        /// <summary> Disconnected. </summary>
        public static CircuitConnectionStatus Disconnected { get; } = new CircuitConnectionStatus(DisconnectedValue);
        /// <summary> Determines if two <see cref="CircuitConnectionStatus"/> values are the same. </summary>
        public static bool operator ==(CircuitConnectionStatus left, CircuitConnectionStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="CircuitConnectionStatus"/> values are not the same. </summary>
        public static bool operator !=(CircuitConnectionStatus left, CircuitConnectionStatus right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="CircuitConnectionStatus"/>. </summary>
        public static implicit operator CircuitConnectionStatus(string value) => new CircuitConnectionStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is CircuitConnectionStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(CircuitConnectionStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
