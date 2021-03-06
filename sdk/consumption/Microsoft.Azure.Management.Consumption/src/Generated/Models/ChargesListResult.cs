// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Consumption.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Result of listing charge summary.
    /// </summary>
    public partial class ChargesListResult
    {
        /// <summary>
        /// Initializes a new instance of the ChargesListResult class.
        /// </summary>
        public ChargesListResult()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ChargesListResult class.
        /// </summary>
        /// <param name="value">The list of charge summary</param>
        public ChargesListResult(IList<ChargeSummary> value = default(IList<ChargeSummary>))
        {
            Value = value;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the list of charge summary
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public IList<ChargeSummary> Value { get; private set; }

    }
}
