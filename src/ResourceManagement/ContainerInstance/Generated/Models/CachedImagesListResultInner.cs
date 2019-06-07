// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.ContainerInstance.Fluent.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The response containing cached images.
    /// </summary>
    public partial class CachedImagesListResultInner
    {
        /// <summary>
        /// Initializes a new instance of the CachedImagesListResultInner
        /// class.
        /// </summary>
        public CachedImagesListResultInner()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CachedImagesListResultInner
        /// class.
        /// </summary>
        /// <param name="value">The list of cached images.</param>
        /// <param name="nextLink">The URI to fetch the next page of cached
        /// images.</param>
        public CachedImagesListResultInner(IList<CachedImages> value = default(IList<CachedImages>), string nextLink = default(string))
        {
            Value = value;
            NextLink = nextLink;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the list of cached images.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public IList<CachedImages> Value { get; set; }

        /// <summary>
        /// Gets or sets the URI to fetch the next page of cached images.
        /// </summary>
        [JsonProperty(PropertyName = "nextLink")]
        public string NextLink { get; set; }

    }
}
