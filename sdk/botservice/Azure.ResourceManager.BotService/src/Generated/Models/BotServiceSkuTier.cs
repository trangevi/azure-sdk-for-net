// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.BotService.Models
{
    /// <summary> Gets the sku tier. This is based on the SKU name. </summary>
    public readonly partial struct BotServiceSkuTier : IEquatable<BotServiceSkuTier>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="BotServiceSkuTier"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public BotServiceSkuTier(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string FreeValue = "Free";
        private const string StandardValue = "Standard";

        /// <summary> Free. </summary>
        public static BotServiceSkuTier Free { get; } = new BotServiceSkuTier(FreeValue);
        /// <summary> Standard. </summary>
        public static BotServiceSkuTier Standard { get; } = new BotServiceSkuTier(StandardValue);
        /// <summary> Determines if two <see cref="BotServiceSkuTier"/> values are the same. </summary>
        public static bool operator ==(BotServiceSkuTier left, BotServiceSkuTier right) => left.Equals(right);
        /// <summary> Determines if two <see cref="BotServiceSkuTier"/> values are not the same. </summary>
        public static bool operator !=(BotServiceSkuTier left, BotServiceSkuTier right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="BotServiceSkuTier"/>. </summary>
        public static implicit operator BotServiceSkuTier(string value) => new BotServiceSkuTier(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is BotServiceSkuTier other && Equals(other);
        /// <inheritdoc />
        public bool Equals(BotServiceSkuTier other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
