// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ProviderHub.Models
{
    /// <summary> The LinkedAction. </summary>
    public readonly partial struct LinkedAction : IEquatable<LinkedAction>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="LinkedAction"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public LinkedAction(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NotSpecifiedValue = "NotSpecified";
        private const string BlockedValue = "Blocked";
        private const string ValidateValue = "Validate";
        private const string EnabledValue = "Enabled";

        /// <summary> NotSpecified. </summary>
        public static LinkedAction NotSpecified { get; } = new LinkedAction(NotSpecifiedValue);
        /// <summary> Blocked. </summary>
        public static LinkedAction Blocked { get; } = new LinkedAction(BlockedValue);
        /// <summary> Validate. </summary>
        public static LinkedAction Validate { get; } = new LinkedAction(ValidateValue);
        /// <summary> Enabled. </summary>
        public static LinkedAction Enabled { get; } = new LinkedAction(EnabledValue);
        /// <summary> Determines if two <see cref="LinkedAction"/> values are the same. </summary>
        public static bool operator ==(LinkedAction left, LinkedAction right) => left.Equals(right);
        /// <summary> Determines if two <see cref="LinkedAction"/> values are not the same. </summary>
        public static bool operator !=(LinkedAction left, LinkedAction right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="LinkedAction"/>. </summary>
        public static implicit operator LinkedAction(string value) => new LinkedAction(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is LinkedAction other && Equals(other);
        /// <inheritdoc />
        public bool Equals(LinkedAction other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
