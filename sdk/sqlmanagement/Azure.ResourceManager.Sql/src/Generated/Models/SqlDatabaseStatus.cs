// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> The status of the database. </summary>
    public readonly partial struct SqlDatabaseStatus : IEquatable<SqlDatabaseStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SqlDatabaseStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SqlDatabaseStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string OnlineValue = "Online";
        private const string RestoringValue = "Restoring";
        private const string RecoveryPendingValue = "RecoveryPending";
        private const string RecoveringValue = "Recovering";
        private const string SuspectValue = "Suspect";
        private const string OfflineValue = "Offline";
        private const string StandbyValue = "Standby";
        private const string ShutdownValue = "Shutdown";
        private const string EmergencyModeValue = "EmergencyMode";
        private const string AutoClosedValue = "AutoClosed";
        private const string CopyingValue = "Copying";
        private const string CreatingValue = "Creating";
        private const string InaccessibleValue = "Inaccessible";
        private const string OfflineSecondaryValue = "OfflineSecondary";
        private const string PausingValue = "Pausing";
        private const string PausedValue = "Paused";
        private const string ResumingValue = "Resuming";
        private const string ScalingValue = "Scaling";
        private const string OfflineChangingDwPerformanceTiersValue = "OfflineChangingDwPerformanceTiers";
        private const string OnlineChangingDwPerformanceTiersValue = "OnlineChangingDwPerformanceTiers";
        private const string DisabledValue = "Disabled";
        private const string StoppingValue = "Stopping";
        private const string StoppedValue = "Stopped";
        private const string StartingValue = "Starting";

        /// <summary> Online. </summary>
        public static SqlDatabaseStatus Online { get; } = new SqlDatabaseStatus(OnlineValue);
        /// <summary> Restoring. </summary>
        public static SqlDatabaseStatus Restoring { get; } = new SqlDatabaseStatus(RestoringValue);
        /// <summary> RecoveryPending. </summary>
        public static SqlDatabaseStatus RecoveryPending { get; } = new SqlDatabaseStatus(RecoveryPendingValue);
        /// <summary> Recovering. </summary>
        public static SqlDatabaseStatus Recovering { get; } = new SqlDatabaseStatus(RecoveringValue);
        /// <summary> Suspect. </summary>
        public static SqlDatabaseStatus Suspect { get; } = new SqlDatabaseStatus(SuspectValue);
        /// <summary> Offline. </summary>
        public static SqlDatabaseStatus Offline { get; } = new SqlDatabaseStatus(OfflineValue);
        /// <summary> Standby. </summary>
        public static SqlDatabaseStatus Standby { get; } = new SqlDatabaseStatus(StandbyValue);
        /// <summary> Shutdown. </summary>
        public static SqlDatabaseStatus Shutdown { get; } = new SqlDatabaseStatus(ShutdownValue);
        /// <summary> EmergencyMode. </summary>
        public static SqlDatabaseStatus EmergencyMode { get; } = new SqlDatabaseStatus(EmergencyModeValue);
        /// <summary> AutoClosed. </summary>
        public static SqlDatabaseStatus AutoClosed { get; } = new SqlDatabaseStatus(AutoClosedValue);
        /// <summary> Copying. </summary>
        public static SqlDatabaseStatus Copying { get; } = new SqlDatabaseStatus(CopyingValue);
        /// <summary> Creating. </summary>
        public static SqlDatabaseStatus Creating { get; } = new SqlDatabaseStatus(CreatingValue);
        /// <summary> Inaccessible. </summary>
        public static SqlDatabaseStatus Inaccessible { get; } = new SqlDatabaseStatus(InaccessibleValue);
        /// <summary> OfflineSecondary. </summary>
        public static SqlDatabaseStatus OfflineSecondary { get; } = new SqlDatabaseStatus(OfflineSecondaryValue);
        /// <summary> Pausing. </summary>
        public static SqlDatabaseStatus Pausing { get; } = new SqlDatabaseStatus(PausingValue);
        /// <summary> Paused. </summary>
        public static SqlDatabaseStatus Paused { get; } = new SqlDatabaseStatus(PausedValue);
        /// <summary> Resuming. </summary>
        public static SqlDatabaseStatus Resuming { get; } = new SqlDatabaseStatus(ResumingValue);
        /// <summary> Scaling. </summary>
        public static SqlDatabaseStatus Scaling { get; } = new SqlDatabaseStatus(ScalingValue);
        /// <summary> OfflineChangingDwPerformanceTiers. </summary>
        public static SqlDatabaseStatus OfflineChangingDwPerformanceTiers { get; } = new SqlDatabaseStatus(OfflineChangingDwPerformanceTiersValue);
        /// <summary> OnlineChangingDwPerformanceTiers. </summary>
        public static SqlDatabaseStatus OnlineChangingDwPerformanceTiers { get; } = new SqlDatabaseStatus(OnlineChangingDwPerformanceTiersValue);
        /// <summary> Disabled. </summary>
        public static SqlDatabaseStatus Disabled { get; } = new SqlDatabaseStatus(DisabledValue);
        /// <summary> Stopping. </summary>
        public static SqlDatabaseStatus Stopping { get; } = new SqlDatabaseStatus(StoppingValue);
        /// <summary> Stopped. </summary>
        public static SqlDatabaseStatus Stopped { get; } = new SqlDatabaseStatus(StoppedValue);
        /// <summary> Starting. </summary>
        public static SqlDatabaseStatus Starting { get; } = new SqlDatabaseStatus(StartingValue);
        /// <summary> Determines if two <see cref="SqlDatabaseStatus"/> values are the same. </summary>
        public static bool operator ==(SqlDatabaseStatus left, SqlDatabaseStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SqlDatabaseStatus"/> values are not the same. </summary>
        public static bool operator !=(SqlDatabaseStatus left, SqlDatabaseStatus right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="SqlDatabaseStatus"/>. </summary>
        public static implicit operator SqlDatabaseStatus(string value) => new SqlDatabaseStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SqlDatabaseStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SqlDatabaseStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
