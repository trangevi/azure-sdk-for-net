// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Blueprint.Models
{
    /// <summary> Lock mode. </summary>
    public readonly partial struct AssignmentLockMode : IEquatable<AssignmentLockMode>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="AssignmentLockMode"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public AssignmentLockMode(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NoneValue = "None";
        private const string AllResourcesReadOnlyValue = "AllResourcesReadOnly";
        private const string AllResourcesDoNotDeleteValue = "AllResourcesDoNotDelete";

        /// <summary> None. </summary>
        public static AssignmentLockMode None { get; } = new AssignmentLockMode(NoneValue);
        /// <summary> AllResourcesReadOnly. </summary>
        public static AssignmentLockMode AllResourcesReadOnly { get; } = new AssignmentLockMode(AllResourcesReadOnlyValue);
        /// <summary> AllResourcesDoNotDelete. </summary>
        public static AssignmentLockMode AllResourcesDoNotDelete { get; } = new AssignmentLockMode(AllResourcesDoNotDeleteValue);
        /// <summary> Determines if two <see cref="AssignmentLockMode"/> values are the same. </summary>
        public static bool operator ==(AssignmentLockMode left, AssignmentLockMode right) => left.Equals(right);
        /// <summary> Determines if two <see cref="AssignmentLockMode"/> values are not the same. </summary>
        public static bool operator !=(AssignmentLockMode left, AssignmentLockMode right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="AssignmentLockMode"/>. </summary>
        public static implicit operator AssignmentLockMode(string value) => new AssignmentLockMode(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AssignmentLockMode other && Equals(other);
        /// <inheritdoc />
        public bool Equals(AssignmentLockMode other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
