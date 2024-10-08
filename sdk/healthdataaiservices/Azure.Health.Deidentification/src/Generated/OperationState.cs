// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Health.Deidentification
{
    /// <summary> Enum describing allowed operation states. </summary>
    public readonly partial struct OperationState : IEquatable<OperationState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="OperationState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public OperationState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NotStartedValue = "NotStarted";
        private const string RunningValue = "Running";
        private const string SucceededValue = "Succeeded";
        private const string FailedValue = "Failed";
        private const string CanceledValue = "Canceled";

        /// <summary> The operation has not started. </summary>
        public static OperationState NotStarted { get; } = new OperationState(NotStartedValue);
        /// <summary> The operation is in progress. </summary>
        public static OperationState Running { get; } = new OperationState(RunningValue);
        /// <summary> The operation has completed successfully. </summary>
        public static OperationState Succeeded { get; } = new OperationState(SucceededValue);
        /// <summary> The operation has failed. </summary>
        public static OperationState Failed { get; } = new OperationState(FailedValue);
        /// <summary> The operation has been canceled by the user. </summary>
        public static OperationState Canceled { get; } = new OperationState(CanceledValue);
        /// <summary> Determines if two <see cref="OperationState"/> values are the same. </summary>
        public static bool operator ==(OperationState left, OperationState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="OperationState"/> values are not the same. </summary>
        public static bool operator !=(OperationState left, OperationState right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="OperationState"/>. </summary>
        public static implicit operator OperationState(string value) => new OperationState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is OperationState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(OperationState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
