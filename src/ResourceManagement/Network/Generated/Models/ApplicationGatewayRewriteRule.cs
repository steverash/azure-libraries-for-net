// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.Network.Fluent.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Rewrite rule of an application gateway.
    /// </summary>
    public partial class ApplicationGatewayRewriteRule
    {
        /// <summary>
        /// Initializes a new instance of the ApplicationGatewayRewriteRule
        /// class.
        /// </summary>
        public ApplicationGatewayRewriteRule()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ApplicationGatewayRewriteRule
        /// class.
        /// </summary>
        /// <param name="name">Name of the rewrite rule that is unique within
        /// an Application Gateway.</param>
        /// <param name="ruleSequence">Rule Sequence of the rewrite rule that
        /// determines the order of execution of a particular rule in a
        /// RewriteRuleSet.</param>
        /// <param name="conditions">Conditions based on which the action set
        /// execution will be evaluated.</param>
        /// <param name="actionSet">Set of actions to be done as part of the
        /// rewrite Rule.</param>
        public ApplicationGatewayRewriteRule(string name = default(string), int? ruleSequence = default(int?), IList<ApplicationGatewayRewriteRuleCondition> conditions = default(IList<ApplicationGatewayRewriteRuleCondition>), ApplicationGatewayRewriteRuleActionSet actionSet = default(ApplicationGatewayRewriteRuleActionSet))
        {
            Name = name;
            RuleSequence = ruleSequence;
            Conditions = conditions;
            ActionSet = actionSet;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets name of the rewrite rule that is unique within an
        /// Application Gateway.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets rule Sequence of the rewrite rule that determines the
        /// order of execution of a particular rule in a RewriteRuleSet.
        /// </summary>
        [JsonProperty(PropertyName = "ruleSequence")]
        public int? RuleSequence { get; set; }

        /// <summary>
        /// Gets or sets conditions based on which the action set execution
        /// will be evaluated.
        /// </summary>
        [JsonProperty(PropertyName = "conditions")]
        public IList<ApplicationGatewayRewriteRuleCondition> Conditions { get; set; }

        /// <summary>
        /// Gets or sets set of actions to be done as part of the rewrite Rule.
        /// </summary>
        [JsonProperty(PropertyName = "actionSet")]
        public ApplicationGatewayRewriteRuleActionSet ActionSet { get; set; }

    }
}