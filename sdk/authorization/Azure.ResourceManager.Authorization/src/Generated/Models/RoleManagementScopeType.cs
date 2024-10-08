// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Authorization.Models
{
    /// <summary> Type of the scope. </summary>
    public readonly partial struct RoleManagementScopeType : IEquatable<RoleManagementScopeType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="RoleManagementScopeType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public RoleManagementScopeType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string SubscriptionValue = "subscription";
        private const string ManagementGroupValue = "managementgroup";
        private const string ResourceGroupValue = "resourcegroup";

        /// <summary> subscription. </summary>
        public static RoleManagementScopeType Subscription { get; } = new RoleManagementScopeType(SubscriptionValue);
        /// <summary> managementgroup. </summary>
        public static RoleManagementScopeType ManagementGroup { get; } = new RoleManagementScopeType(ManagementGroupValue);
        /// <summary> resourcegroup. </summary>
        public static RoleManagementScopeType ResourceGroup { get; } = new RoleManagementScopeType(ResourceGroupValue);
        /// <summary> Determines if two <see cref="RoleManagementScopeType"/> values are the same. </summary>
        public static bool operator ==(RoleManagementScopeType left, RoleManagementScopeType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="RoleManagementScopeType"/> values are not the same. </summary>
        public static bool operator !=(RoleManagementScopeType left, RoleManagementScopeType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="RoleManagementScopeType"/>. </summary>
        public static implicit operator RoleManagementScopeType(string value) => new RoleManagementScopeType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is RoleManagementScopeType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(RoleManagementScopeType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
