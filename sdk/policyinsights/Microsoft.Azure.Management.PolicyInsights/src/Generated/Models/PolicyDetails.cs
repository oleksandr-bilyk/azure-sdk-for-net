// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.PolicyInsights.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The policy details.
    /// </summary>
    public partial class PolicyDetails
    {
        /// <summary>
        /// Initializes a new instance of the PolicyDetails class.
        /// </summary>
        public PolicyDetails()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PolicyDetails class.
        /// </summary>
        /// <param name="policyDefinitionId">The ID of the policy
        /// definition.</param>
        /// <param name="policyAssignmentId">The ID of the policy
        /// assignment.</param>
        /// <param name="policyAssignmentDisplayName">The display name of the
        /// policy assignment.</param>
        /// <param name="policyAssignmentScope">The scope of the policy
        /// assignment.</param>
        /// <param name="policySetDefinitionId">The ID of the policy set
        /// definition.</param>
        /// <param name="policyDefinitionReferenceId">The policy definition
        /// reference ID within the policy set definition.</param>
        public PolicyDetails(string policyDefinitionId = default(string), string policyAssignmentId = default(string), string policyAssignmentDisplayName = default(string), string policyAssignmentScope = default(string), string policySetDefinitionId = default(string), string policyDefinitionReferenceId = default(string))
        {
            PolicyDefinitionId = policyDefinitionId;
            PolicyAssignmentId = policyAssignmentId;
            PolicyAssignmentDisplayName = policyAssignmentDisplayName;
            PolicyAssignmentScope = policyAssignmentScope;
            PolicySetDefinitionId = policySetDefinitionId;
            PolicyDefinitionReferenceId = policyDefinitionReferenceId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the ID of the policy definition.
        /// </summary>
        [JsonProperty(PropertyName = "policyDefinitionId")]
        public string PolicyDefinitionId { get; private set; }

        /// <summary>
        /// Gets the ID of the policy assignment.
        /// </summary>
        [JsonProperty(PropertyName = "policyAssignmentId")]
        public string PolicyAssignmentId { get; private set; }

        /// <summary>
        /// Gets the display name of the policy assignment.
        /// </summary>
        [JsonProperty(PropertyName = "policyAssignmentDisplayName")]
        public string PolicyAssignmentDisplayName { get; private set; }

        /// <summary>
        /// Gets the scope of the policy assignment.
        /// </summary>
        [JsonProperty(PropertyName = "policyAssignmentScope")]
        public string PolicyAssignmentScope { get; private set; }

        /// <summary>
        /// Gets the ID of the policy set definition.
        /// </summary>
        [JsonProperty(PropertyName = "policySetDefinitionId")]
        public string PolicySetDefinitionId { get; private set; }

        /// <summary>
        /// Gets the policy definition reference ID within the policy set
        /// definition.
        /// </summary>
        [JsonProperty(PropertyName = "policyDefinitionReferenceId")]
        public string PolicyDefinitionReferenceId { get; private set; }

    }
}