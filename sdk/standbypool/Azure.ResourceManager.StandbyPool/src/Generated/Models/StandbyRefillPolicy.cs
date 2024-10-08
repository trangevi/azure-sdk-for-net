// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.StandbyPool.Models
{
    /// <summary> Refill policy of standby pool. </summary>
    public readonly partial struct StandbyRefillPolicy : IEquatable<StandbyRefillPolicy>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="StandbyRefillPolicy"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public StandbyRefillPolicy(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AlwaysValue = "always";

        /// <summary> A refill policy that standby pool is automatically refilled to maintain maxReadyCapacity. </summary>
        public static StandbyRefillPolicy Always { get; } = new StandbyRefillPolicy(AlwaysValue);
        /// <summary> Determines if two <see cref="StandbyRefillPolicy"/> values are the same. </summary>
        public static bool operator ==(StandbyRefillPolicy left, StandbyRefillPolicy right) => left.Equals(right);
        /// <summary> Determines if two <see cref="StandbyRefillPolicy"/> values are not the same. </summary>
        public static bool operator !=(StandbyRefillPolicy left, StandbyRefillPolicy right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="StandbyRefillPolicy"/>. </summary>
        public static implicit operator StandbyRefillPolicy(string value) => new StandbyRefillPolicy(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is StandbyRefillPolicy other && Equals(other);
        /// <inheritdoc />
        public bool Equals(StandbyRefillPolicy other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
