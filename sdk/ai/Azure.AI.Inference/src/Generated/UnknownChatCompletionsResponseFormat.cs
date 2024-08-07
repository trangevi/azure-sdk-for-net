// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.Inference
{
    /// <summary> Unknown version of ChatCompletionsResponseFormat. </summary>
    internal partial class UnknownChatCompletionsResponseFormat : ChatCompletionsResponseFormat
    {
        /// <summary> Initializes a new instance of <see cref="UnknownChatCompletionsResponseFormat"/>. </summary>
        /// <param name="type"> The response format type to use for chat completions. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal UnknownChatCompletionsResponseFormat(string type, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(type, serializedAdditionalRawData)
        {
        }

        /// <summary> Initializes a new instance of <see cref="UnknownChatCompletionsResponseFormat"/> for deserialization. </summary>
        internal UnknownChatCompletionsResponseFormat()
        {
        }
    }
}
