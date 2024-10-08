// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.AppPlatform.Models
{
    /// <summary> Provisioning state of the Certificate. </summary>
    public readonly partial struct AppPlatformCertificateProvisioningState : IEquatable<AppPlatformCertificateProvisioningState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="AppPlatformCertificateProvisioningState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public AppPlatformCertificateProvisioningState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string CreatingValue = "Creating";
        private const string UpdatingValue = "Updating";
        private const string SucceededValue = "Succeeded";
        private const string FailedValue = "Failed";
        private const string DeletingValue = "Deleting";

        /// <summary> Creating. </summary>
        public static AppPlatformCertificateProvisioningState Creating { get; } = new AppPlatformCertificateProvisioningState(CreatingValue);
        /// <summary> Updating. </summary>
        public static AppPlatformCertificateProvisioningState Updating { get; } = new AppPlatformCertificateProvisioningState(UpdatingValue);
        /// <summary> Succeeded. </summary>
        public static AppPlatformCertificateProvisioningState Succeeded { get; } = new AppPlatformCertificateProvisioningState(SucceededValue);
        /// <summary> Failed. </summary>
        public static AppPlatformCertificateProvisioningState Failed { get; } = new AppPlatformCertificateProvisioningState(FailedValue);
        /// <summary> Deleting. </summary>
        public static AppPlatformCertificateProvisioningState Deleting { get; } = new AppPlatformCertificateProvisioningState(DeletingValue);
        /// <summary> Determines if two <see cref="AppPlatformCertificateProvisioningState"/> values are the same. </summary>
        public static bool operator ==(AppPlatformCertificateProvisioningState left, AppPlatformCertificateProvisioningState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="AppPlatformCertificateProvisioningState"/> values are not the same. </summary>
        public static bool operator !=(AppPlatformCertificateProvisioningState left, AppPlatformCertificateProvisioningState right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="AppPlatformCertificateProvisioningState"/>. </summary>
        public static implicit operator AppPlatformCertificateProvisioningState(string value) => new AppPlatformCertificateProvisioningState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AppPlatformCertificateProvisioningState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(AppPlatformCertificateProvisioningState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
