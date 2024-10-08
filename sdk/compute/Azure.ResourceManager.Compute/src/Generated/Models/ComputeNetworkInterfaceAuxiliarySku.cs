// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Specifies whether the Auxiliary sku is enabled for the Network Interface resource. </summary>
    public readonly partial struct ComputeNetworkInterfaceAuxiliarySku : IEquatable<ComputeNetworkInterfaceAuxiliarySku>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ComputeNetworkInterfaceAuxiliarySku"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ComputeNetworkInterfaceAuxiliarySku(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NoneValue = "None";
        private const string A1Value = "A1";
        private const string A2Value = "A2";
        private const string A4Value = "A4";
        private const string A8Value = "A8";

        /// <summary> None. </summary>
        public static ComputeNetworkInterfaceAuxiliarySku None { get; } = new ComputeNetworkInterfaceAuxiliarySku(NoneValue);
        /// <summary> A1. </summary>
        public static ComputeNetworkInterfaceAuxiliarySku A1 { get; } = new ComputeNetworkInterfaceAuxiliarySku(A1Value);
        /// <summary> A2. </summary>
        public static ComputeNetworkInterfaceAuxiliarySku A2 { get; } = new ComputeNetworkInterfaceAuxiliarySku(A2Value);
        /// <summary> A4. </summary>
        public static ComputeNetworkInterfaceAuxiliarySku A4 { get; } = new ComputeNetworkInterfaceAuxiliarySku(A4Value);
        /// <summary> A8. </summary>
        public static ComputeNetworkInterfaceAuxiliarySku A8 { get; } = new ComputeNetworkInterfaceAuxiliarySku(A8Value);
        /// <summary> Determines if two <see cref="ComputeNetworkInterfaceAuxiliarySku"/> values are the same. </summary>
        public static bool operator ==(ComputeNetworkInterfaceAuxiliarySku left, ComputeNetworkInterfaceAuxiliarySku right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ComputeNetworkInterfaceAuxiliarySku"/> values are not the same. </summary>
        public static bool operator !=(ComputeNetworkInterfaceAuxiliarySku left, ComputeNetworkInterfaceAuxiliarySku right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="ComputeNetworkInterfaceAuxiliarySku"/>. </summary>
        public static implicit operator ComputeNetworkInterfaceAuxiliarySku(string value) => new ComputeNetworkInterfaceAuxiliarySku(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ComputeNetworkInterfaceAuxiliarySku other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ComputeNetworkInterfaceAuxiliarySku other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
