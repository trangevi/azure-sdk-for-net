// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> The IotSecuritySolutionExportOption. </summary>
    public readonly partial struct IotSecuritySolutionExportOption : IEquatable<IotSecuritySolutionExportOption>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="IotSecuritySolutionExportOption"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public IotSecuritySolutionExportOption(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string RawEventsValue = "RawEvents";

        /// <summary> Agent raw events. </summary>
        public static IotSecuritySolutionExportOption RawEvents { get; } = new IotSecuritySolutionExportOption(RawEventsValue);
        /// <summary> Determines if two <see cref="IotSecuritySolutionExportOption"/> values are the same. </summary>
        public static bool operator ==(IotSecuritySolutionExportOption left, IotSecuritySolutionExportOption right) => left.Equals(right);
        /// <summary> Determines if two <see cref="IotSecuritySolutionExportOption"/> values are not the same. </summary>
        public static bool operator !=(IotSecuritySolutionExportOption left, IotSecuritySolutionExportOption right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="IotSecuritySolutionExportOption"/>. </summary>
        public static implicit operator IotSecuritySolutionExportOption(string value) => new IotSecuritySolutionExportOption(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is IotSecuritySolutionExportOption other && Equals(other);
        /// <inheritdoc />
        public bool Equals(IotSecuritySolutionExportOption other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
