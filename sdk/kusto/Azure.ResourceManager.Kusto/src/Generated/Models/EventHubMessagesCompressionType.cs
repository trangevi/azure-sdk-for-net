// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Kusto.Models
{
    /// <summary> The compression type. </summary>
    public readonly partial struct EventHubMessagesCompressionType : IEquatable<EventHubMessagesCompressionType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="EventHubMessagesCompressionType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public EventHubMessagesCompressionType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NoneValue = "None";
        private const string GZipValue = "GZip";

        /// <summary> None. </summary>
        public static EventHubMessagesCompressionType None { get; } = new EventHubMessagesCompressionType(NoneValue);
        /// <summary> GZip. </summary>
        public static EventHubMessagesCompressionType GZip { get; } = new EventHubMessagesCompressionType(GZipValue);
        /// <summary> Determines if two <see cref="EventHubMessagesCompressionType"/> values are the same. </summary>
        public static bool operator ==(EventHubMessagesCompressionType left, EventHubMessagesCompressionType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="EventHubMessagesCompressionType"/> values are not the same. </summary>
        public static bool operator !=(EventHubMessagesCompressionType left, EventHubMessagesCompressionType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="EventHubMessagesCompressionType"/>. </summary>
        public static implicit operator EventHubMessagesCompressionType(string value) => new EventHubMessagesCompressionType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is EventHubMessagesCompressionType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(EventHubMessagesCompressionType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
