// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.Language.Text.Authoring.Models
{
    /// <summary> Represents the exported assets for a entity recognition project. </summary>
    public partial class ExportedCustomEntityRecognitionProjectAssets : ExportedProjectAssets
    {
        /// <summary> Initializes a new instance of <see cref="ExportedCustomEntityRecognitionProjectAssets"/>. </summary>
        public ExportedCustomEntityRecognitionProjectAssets()
        {
            ProjectKind = ProjectKind.CustomEntityRecognition;
            Entities = new ChangeTrackingList<ExportedEntity>();
            Documents = new ChangeTrackingList<ExportedCustomEntityRecognitionDocument>();
        }

        /// <summary> Initializes a new instance of <see cref="ExportedCustomEntityRecognitionProjectAssets"/>. </summary>
        /// <param name="projectKind"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="entities"> The list of entities belonging to the project. </param>
        /// <param name="documents"> The list of documents belonging to the project. </param>
        internal ExportedCustomEntityRecognitionProjectAssets(ProjectKind projectKind, IDictionary<string, BinaryData> serializedAdditionalRawData, IList<ExportedEntity> entities, IList<ExportedCustomEntityRecognitionDocument> documents) : base(projectKind, serializedAdditionalRawData)
        {
            Entities = entities;
            Documents = documents;
        }

        /// <summary> The list of entities belonging to the project. </summary>
        public IList<ExportedEntity> Entities { get; }
        /// <summary> The list of documents belonging to the project. </summary>
        public IList<ExportedCustomEntityRecognitionDocument> Documents { get; }
    }
}
