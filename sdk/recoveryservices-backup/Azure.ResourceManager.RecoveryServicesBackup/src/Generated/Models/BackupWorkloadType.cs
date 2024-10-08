// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    /// <summary> Type of workload for the backup management. </summary>
    public readonly partial struct BackupWorkloadType : IEquatable<BackupWorkloadType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="BackupWorkloadType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public BackupWorkloadType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string InvalidValue = "Invalid";
        private const string VmValue = "VM";
        private const string FileFolderValue = "FileFolder";
        private const string AzureSqlDBValue = "AzureSqlDb";
        private const string SqlDBValue = "SQLDB";
        private const string ExchangeValue = "Exchange";
        private const string SharepointValue = "Sharepoint";
        private const string VMwareVmValue = "VMwareVM";
        private const string SystemStateValue = "SystemState";
        private const string ClientValue = "Client";
        private const string GenericDataSourceValue = "GenericDataSource";
        private const string SqlDatabaseValue = "SQLDataBase";
        private const string AzureFileShareValue = "AzureFileShare";
        private const string SapHanaDatabaseValue = "SAPHanaDatabase";
        private const string SapAseDatabaseValue = "SAPAseDatabase";
        private const string SapHanaDBInstanceValue = "SAPHanaDBInstance";

        /// <summary> Invalid. </summary>
        public static BackupWorkloadType Invalid { get; } = new BackupWorkloadType(InvalidValue);
        /// <summary> VM. </summary>
        public static BackupWorkloadType Vm { get; } = new BackupWorkloadType(VmValue);
        /// <summary> FileFolder. </summary>
        public static BackupWorkloadType FileFolder { get; } = new BackupWorkloadType(FileFolderValue);
        /// <summary> AzureSqlDb. </summary>
        public static BackupWorkloadType AzureSqlDB { get; } = new BackupWorkloadType(AzureSqlDBValue);
        /// <summary> SQLDB. </summary>
        public static BackupWorkloadType SqlDB { get; } = new BackupWorkloadType(SqlDBValue);
        /// <summary> Exchange. </summary>
        public static BackupWorkloadType Exchange { get; } = new BackupWorkloadType(ExchangeValue);
        /// <summary> Sharepoint. </summary>
        public static BackupWorkloadType Sharepoint { get; } = new BackupWorkloadType(SharepointValue);
        /// <summary> VMwareVM. </summary>
        public static BackupWorkloadType VMwareVm { get; } = new BackupWorkloadType(VMwareVmValue);
        /// <summary> SystemState. </summary>
        public static BackupWorkloadType SystemState { get; } = new BackupWorkloadType(SystemStateValue);
        /// <summary> Client. </summary>
        public static BackupWorkloadType Client { get; } = new BackupWorkloadType(ClientValue);
        /// <summary> GenericDataSource. </summary>
        public static BackupWorkloadType GenericDataSource { get; } = new BackupWorkloadType(GenericDataSourceValue);
        /// <summary> SQLDataBase. </summary>
        public static BackupWorkloadType SqlDatabase { get; } = new BackupWorkloadType(SqlDatabaseValue);
        /// <summary> AzureFileShare. </summary>
        public static BackupWorkloadType AzureFileShare { get; } = new BackupWorkloadType(AzureFileShareValue);
        /// <summary> SAPHanaDatabase. </summary>
        public static BackupWorkloadType SapHanaDatabase { get; } = new BackupWorkloadType(SapHanaDatabaseValue);
        /// <summary> SAPAseDatabase. </summary>
        public static BackupWorkloadType SapAseDatabase { get; } = new BackupWorkloadType(SapAseDatabaseValue);
        /// <summary> SAPHanaDBInstance. </summary>
        public static BackupWorkloadType SapHanaDBInstance { get; } = new BackupWorkloadType(SapHanaDBInstanceValue);
        /// <summary> Determines if two <see cref="BackupWorkloadType"/> values are the same. </summary>
        public static bool operator ==(BackupWorkloadType left, BackupWorkloadType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="BackupWorkloadType"/> values are not the same. </summary>
        public static bool operator !=(BackupWorkloadType left, BackupWorkloadType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="BackupWorkloadType"/>. </summary>
        public static implicit operator BackupWorkloadType(string value) => new BackupWorkloadType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is BackupWorkloadType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(BackupWorkloadType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
