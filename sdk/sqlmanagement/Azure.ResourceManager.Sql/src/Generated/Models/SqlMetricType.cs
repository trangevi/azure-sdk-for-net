// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> The SqlMetricType. </summary>
    public readonly partial struct SqlMetricType : IEquatable<SqlMetricType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SqlMetricType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SqlMetricType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string CpuValue = "cpu";
        private const string IoValue = "io";
        private const string LogIoValue = "logIo";
        private const string DurationValue = "duration";
        private const string DtuValue = "dtu";

        /// <summary> cpu. </summary>
        public static SqlMetricType Cpu { get; } = new SqlMetricType(CpuValue);
        /// <summary> io. </summary>
        public static SqlMetricType Io { get; } = new SqlMetricType(IoValue);
        /// <summary> logIo. </summary>
        public static SqlMetricType LogIo { get; } = new SqlMetricType(LogIoValue);
        /// <summary> duration. </summary>
        public static SqlMetricType Duration { get; } = new SqlMetricType(DurationValue);
        /// <summary> dtu. </summary>
        public static SqlMetricType Dtu { get; } = new SqlMetricType(DtuValue);
        /// <summary> Determines if two <see cref="SqlMetricType"/> values are the same. </summary>
        public static bool operator ==(SqlMetricType left, SqlMetricType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SqlMetricType"/> values are not the same. </summary>
        public static bool operator !=(SqlMetricType left, SqlMetricType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="SqlMetricType"/>. </summary>
        public static implicit operator SqlMetricType(string value) => new SqlMetricType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SqlMetricType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SqlMetricType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
