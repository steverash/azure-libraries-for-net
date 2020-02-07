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
    /// IP addresses associated with azure firewall.
    /// </summary>
    public partial class HubIPAddresses
    {
        /// <summary>
        /// Initializes a new instance of the HubIPAddresses class.
        /// </summary>
        public HubIPAddresses()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the HubIPAddresses class.
        /// </summary>
        /// <param name="publicIPAddresses">List of Public IP addresses
        /// associated with azure firewall.</param>
        /// <param name="privateIPAddress">Private IP Address associated with
        /// azure firewall.</param>
        public HubIPAddresses(IList<AzureFirewallPublicIPAddress> publicIPAddresses = default(IList<AzureFirewallPublicIPAddress>), string privateIPAddress = default(string))
        {
            PublicIPAddresses = publicIPAddresses;
            PrivateIPAddress = privateIPAddress;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets list of Public IP addresses associated with azure
        /// firewall.
        /// </summary>
        [JsonProperty(PropertyName = "publicIPAddresses")]
        public IList<AzureFirewallPublicIPAddress> PublicIPAddresses { get; set; }

        /// <summary>
        /// Gets or sets private IP Address associated with azure firewall.
        /// </summary>
        [JsonProperty(PropertyName = "privateIPAddress")]
        public string PrivateIPAddress { get; set; }

    }
}