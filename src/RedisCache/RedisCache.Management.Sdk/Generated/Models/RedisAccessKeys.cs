// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.RedisCache.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Redis cache access keys.
    /// </summary>
    public partial class RedisAccessKeys
    {
        /// <summary>
        /// Initializes a new instance of the RedisAccessKeys class.
        /// </summary>
        public RedisAccessKeys()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RedisAccessKeys class.
        /// </summary>
        /// <param name="primaryKey">The current primary key that clients can
        /// use to authenticate with Redis cache.</param>
        /// <param name="secondaryKey">The current secondary key that clients
        /// can use to authenticate with Redis cache.</param>
        public RedisAccessKeys(string primaryKey = default(string), string secondaryKey = default(string))
        {
            PrimaryKey = primaryKey;
            SecondaryKey = secondaryKey;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the current primary key that clients can use to authenticate
        /// with Redis cache.
        /// </summary>
        [JsonProperty(PropertyName = "primaryKey")]
        public string PrimaryKey { get; private set; }

        /// <summary>
        /// Gets the current secondary key that clients can use to authenticate
        /// with Redis cache.
        /// </summary>
        [JsonProperty(PropertyName = "secondaryKey")]
        public string SecondaryKey { get; private set; }

    }
}
