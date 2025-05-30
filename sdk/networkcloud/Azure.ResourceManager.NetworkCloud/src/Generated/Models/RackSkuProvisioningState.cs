// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.NetworkCloud.Models
{
    /// <summary> The provisioning state of the rack SKU resource. </summary>
    public readonly partial struct RackSkuProvisioningState : IEquatable<RackSkuProvisioningState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="RackSkuProvisioningState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public RackSkuProvisioningState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string CanceledValue = "Canceled";
        private const string FailedValue = "Failed";
        private const string SucceededValue = "Succeeded";

        /// <summary> Canceled. </summary>
        public static RackSkuProvisioningState Canceled { get; } = new RackSkuProvisioningState(CanceledValue);
        /// <summary> Failed. </summary>
        public static RackSkuProvisioningState Failed { get; } = new RackSkuProvisioningState(FailedValue);
        /// <summary> Succeeded. </summary>
        public static RackSkuProvisioningState Succeeded { get; } = new RackSkuProvisioningState(SucceededValue);
        /// <summary> Determines if two <see cref="RackSkuProvisioningState"/> values are the same. </summary>
        public static bool operator ==(RackSkuProvisioningState left, RackSkuProvisioningState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="RackSkuProvisioningState"/> values are not the same. </summary>
        public static bool operator !=(RackSkuProvisioningState left, RackSkuProvisioningState right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="RackSkuProvisioningState"/>. </summary>
        public static implicit operator RackSkuProvisioningState(string value) => new RackSkuProvisioningState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is RackSkuProvisioningState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(RackSkuProvisioningState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
