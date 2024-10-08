// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> The kind of nodes that the Big Data pool provides. </summary>
    public readonly partial struct NodeSizeFamily : IEquatable<NodeSizeFamily>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="NodeSizeFamily"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public NodeSizeFamily(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NoneValue = "None";
        private const string MemoryOptimizedValue = "MemoryOptimized";

        /// <summary> None. </summary>
        public static NodeSizeFamily None { get; } = new NodeSizeFamily(NoneValue);
        /// <summary> MemoryOptimized. </summary>
        public static NodeSizeFamily MemoryOptimized { get; } = new NodeSizeFamily(MemoryOptimizedValue);
        /// <summary> Determines if two <see cref="NodeSizeFamily"/> values are the same. </summary>
        public static bool operator ==(NodeSizeFamily left, NodeSizeFamily right) => left.Equals(right);
        /// <summary> Determines if two <see cref="NodeSizeFamily"/> values are not the same. </summary>
        public static bool operator !=(NodeSizeFamily left, NodeSizeFamily right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="NodeSizeFamily"/>. </summary>
        public static implicit operator NodeSizeFamily(string value) => new NodeSizeFamily(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is NodeSizeFamily other && Equals(other);
        /// <inheritdoc />
        public bool Equals(NodeSizeFamily other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
