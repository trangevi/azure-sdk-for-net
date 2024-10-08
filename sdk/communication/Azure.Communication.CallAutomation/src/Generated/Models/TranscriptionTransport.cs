// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Communication.CallAutomation
{
    /// <summary> The type of transport to be used for live transcription, eg. Websocket. </summary>
    public readonly partial struct TranscriptionTransport : IEquatable<TranscriptionTransport>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="TranscriptionTransport"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public TranscriptionTransport(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string WebsocketValue = "websocket";

        /// <summary> websocket. </summary>
        public static TranscriptionTransport Websocket { get; } = new TranscriptionTransport(WebsocketValue);
        /// <summary> Determines if two <see cref="TranscriptionTransport"/> values are the same. </summary>
        public static bool operator ==(TranscriptionTransport left, TranscriptionTransport right) => left.Equals(right);
        /// <summary> Determines if two <see cref="TranscriptionTransport"/> values are not the same. </summary>
        public static bool operator !=(TranscriptionTransport left, TranscriptionTransport right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="TranscriptionTransport"/>. </summary>
        public static implicit operator TranscriptionTransport(string value) => new TranscriptionTransport(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is TranscriptionTransport other && Equals(other);
        /// <inheritdoc />
        public bool Equals(TranscriptionTransport other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
