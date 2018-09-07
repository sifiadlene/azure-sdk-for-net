// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataFactory.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Pipeline resource type.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class PipelineResource : SubResource
    {
        /// <summary>
        /// Initializes a new instance of the PipelineResource class.
        /// </summary>
        public PipelineResource()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PipelineResource class.
        /// </summary>
        /// <param name="id">The resource identifier.</param>
        /// <param name="name">The resource name.</param>
        /// <param name="type">The resource type.</param>
        /// <param name="etag">Etag identifies change in the resource.</param>
        /// <param name="additionalProperties">Unmatched properties from the
        /// message are deserialized this collection</param>
        /// <param name="description">The description of the pipeline.</param>
        /// <param name="activities">List of activities in pipeline.</param>
        /// <param name="parameters">List of parameters for pipeline.</param>
        /// <param name="concurrency">The max number of concurrent runs for the
        /// pipeline.</param>
        /// <param name="annotations">List of tags that can be used for
        /// describing the Pipeline.</param>
        /// <param name="folder">The folder that this Pipeline is in. If not
        /// specified, Pipeline will appear at the root level.</param>
        public PipelineResource(string id = default(string), string name = default(string), string type = default(string), string etag = default(string), IDictionary<string, object> additionalProperties = default(IDictionary<string, object>), string description = default(string), IList<Activity> activities = default(IList<Activity>), IDictionary<string, ParameterSpecification> parameters = default(IDictionary<string, ParameterSpecification>), int? concurrency = default(int?), IList<object> annotations = default(IList<object>), PipelineFolder folder = default(PipelineFolder))
            : base(id, name, type, etag)
        {
            AdditionalProperties = additionalProperties;
            Description = description;
            Activities = activities;
            Parameters = parameters;
            Concurrency = concurrency;
            Annotations = annotations;
            Folder = folder;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets unmatched properties from the message are deserialized
        /// this collection
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; }

        /// <summary>
        /// Gets or sets the description of the pipeline.
        /// </summary>
        [JsonProperty(PropertyName = "properties.description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets list of activities in pipeline.
        /// </summary>
        [JsonProperty(PropertyName = "properties.activities")]
        public IList<Activity> Activities { get; set; }

        /// <summary>
        /// Gets or sets list of parameters for pipeline.
        /// </summary>
        [JsonProperty(PropertyName = "properties.parameters")]
        public IDictionary<string, ParameterSpecification> Parameters { get; set; }

        /// <summary>
        /// Gets or sets the max number of concurrent runs for the pipeline.
        /// </summary>
        [JsonProperty(PropertyName = "properties.concurrency")]
        public int? Concurrency { get; set; }

        /// <summary>
        /// Gets or sets list of tags that can be used for describing the
        /// Pipeline.
        /// </summary>
        [JsonProperty(PropertyName = "properties.annotations")]
        public IList<object> Annotations { get; set; }

        /// <summary>
        /// Gets or sets the folder that this Pipeline is in. If not specified,
        /// Pipeline will appear at the root level.
        /// </summary>
        [JsonProperty(PropertyName = "properties.folder")]
        public PipelineFolder Folder { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Activities != null)
            {
                foreach (var element in Activities)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
            if (Parameters != null)
            {
                foreach (var valueElement in Parameters.Values)
                {
                    if (valueElement != null)
                    {
                        valueElement.Validate();
                    }
                }
            }
            if (Concurrency < 1)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "Concurrency", 1);
            }
        }
    }
}
