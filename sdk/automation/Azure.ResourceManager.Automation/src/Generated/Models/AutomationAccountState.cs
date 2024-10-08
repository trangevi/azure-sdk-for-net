// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Automation.Models
{
    /// <summary> Gets status of account. </summary>
    public readonly partial struct AutomationAccountState : IEquatable<AutomationAccountState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="AutomationAccountState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public AutomationAccountState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string OkValue = "Ok";
        private const string UnavailableValue = "Unavailable";
        private const string SuspendedValue = "Suspended";

        /// <summary> Ok. </summary>
        public static AutomationAccountState Ok { get; } = new AutomationAccountState(OkValue);
        /// <summary> Unavailable. </summary>
        public static AutomationAccountState Unavailable { get; } = new AutomationAccountState(UnavailableValue);
        /// <summary> Suspended. </summary>
        public static AutomationAccountState Suspended { get; } = new AutomationAccountState(SuspendedValue);
        /// <summary> Determines if two <see cref="AutomationAccountState"/> values are the same. </summary>
        public static bool operator ==(AutomationAccountState left, AutomationAccountState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="AutomationAccountState"/> values are not the same. </summary>
        public static bool operator !=(AutomationAccountState left, AutomationAccountState right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="AutomationAccountState"/>. </summary>
        public static implicit operator AutomationAccountState(string value) => new AutomationAccountState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AutomationAccountState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(AutomationAccountState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
