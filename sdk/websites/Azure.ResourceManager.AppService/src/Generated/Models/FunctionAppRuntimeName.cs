// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> Function app runtime name. Available options: dotnet-isolated, node, java, powershell, python, custom. </summary>
    public readonly partial struct FunctionAppRuntimeName : IEquatable<FunctionAppRuntimeName>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="FunctionAppRuntimeName"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public FunctionAppRuntimeName(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string DotnetIsolatedValue = "dotnet-isolated";
        private const string NodeValue = "node";
        private const string JavaValue = "java";
        private const string PowershellValue = "powershell";
        private const string PythonValue = "python";
        private const string CustomValue = "custom";

        /// <summary> dotnet-isolated. </summary>
        public static FunctionAppRuntimeName DotnetIsolated { get; } = new FunctionAppRuntimeName(DotnetIsolatedValue);
        /// <summary> node. </summary>
        public static FunctionAppRuntimeName Node { get; } = new FunctionAppRuntimeName(NodeValue);
        /// <summary> java. </summary>
        public static FunctionAppRuntimeName Java { get; } = new FunctionAppRuntimeName(JavaValue);
        /// <summary> powershell. </summary>
        public static FunctionAppRuntimeName Powershell { get; } = new FunctionAppRuntimeName(PowershellValue);
        /// <summary> python. </summary>
        public static FunctionAppRuntimeName Python { get; } = new FunctionAppRuntimeName(PythonValue);
        /// <summary> custom. </summary>
        public static FunctionAppRuntimeName Custom { get; } = new FunctionAppRuntimeName(CustomValue);
        /// <summary> Determines if two <see cref="FunctionAppRuntimeName"/> values are the same. </summary>
        public static bool operator ==(FunctionAppRuntimeName left, FunctionAppRuntimeName right) => left.Equals(right);
        /// <summary> Determines if two <see cref="FunctionAppRuntimeName"/> values are not the same. </summary>
        public static bool operator !=(FunctionAppRuntimeName left, FunctionAppRuntimeName right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="FunctionAppRuntimeName"/>. </summary>
        public static implicit operator FunctionAppRuntimeName(string value) => new FunctionAppRuntimeName(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is FunctionAppRuntimeName other && Equals(other);
        /// <inheritdoc />
        public bool Equals(FunctionAppRuntimeName other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
