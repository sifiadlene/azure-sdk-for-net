// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Compute.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class VirtualMachineIdentityUserAssignedIdentitiesValue
    {
        /// <summary>
        /// Initializes a new instance of the
        /// VirtualMachineIdentityUserAssignedIdentitiesValue class.
        /// </summary>
        public VirtualMachineIdentityUserAssignedIdentitiesValue()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// VirtualMachineIdentityUserAssignedIdentitiesValue class.
        /// </summary>
        /// <param name="principalId">The principal id of user assigned
        /// identity.</param>
        /// <param name="clientId">The client id of user assigned
        /// identity.</param>
        public VirtualMachineIdentityUserAssignedIdentitiesValue(string principalId = default(string), string clientId = default(string))
        {
            PrincipalId = principalId;
            ClientId = clientId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the principal id of user assigned identity.
        /// </summary>
        [JsonProperty(PropertyName = "principalId")]
        public string PrincipalId { get; private set; }

        /// <summary>
        /// Gets the client id of user assigned identity.
        /// </summary>
        [JsonProperty(PropertyName = "clientId")]
        public string ClientId { get; private set; }

    }
}
