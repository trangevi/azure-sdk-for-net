// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Developer.LoadTesting
{
    /// <summary> Category of Recommendation. </summary>
    public readonly partial struct RecommendationCategory : IEquatable<RecommendationCategory>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="RecommendationCategory"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public RecommendationCategory(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ThroughputOptimizedValue = "ThroughputOptimized";
        private const string CostOptimizedValue = "CostOptimized";

        /// <summary> The recommendation for this category optimizes the throughput/RPS (Requests per Second) of the app. </summary>
        public static RecommendationCategory ThroughputOptimized { get; } = new RecommendationCategory(ThroughputOptimizedValue);
        /// <summary> The recommendation for this category optimizes the cost of the app. </summary>
        public static RecommendationCategory CostOptimized { get; } = new RecommendationCategory(CostOptimizedValue);
        /// <summary> Determines if two <see cref="RecommendationCategory"/> values are the same. </summary>
        public static bool operator ==(RecommendationCategory left, RecommendationCategory right) => left.Equals(right);
        /// <summary> Determines if two <see cref="RecommendationCategory"/> values are not the same. </summary>
        public static bool operator !=(RecommendationCategory left, RecommendationCategory right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="RecommendationCategory"/>. </summary>
        public static implicit operator RecommendationCategory(string value) => new RecommendationCategory(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is RecommendationCategory other && Equals(other);
        /// <inheritdoc />
        public bool Equals(RecommendationCategory other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
