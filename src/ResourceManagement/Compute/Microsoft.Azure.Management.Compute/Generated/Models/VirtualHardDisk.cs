// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Compute.Models
{
    using System.Linq;

    /// <summary>
    /// Describes the uri of a disk.
    /// </summary>
    public partial class VirtualHardDisk
    {
        /// <summary>
        /// Initializes a new instance of the VirtualHardDisk class.
        /// </summary>
        public VirtualHardDisk() { }

        /// <summary>
        /// Initializes a new instance of the VirtualHardDisk class.
        /// </summary>
        /// <param name="uri">the virtual hard disk's uri. It should be a
        /// valid Uri to a virtual hard disk.</param>
        public VirtualHardDisk(string uri = default(string))
        {
            Uri = uri;
        }

        /// <summary>
        /// Gets or sets the virtual hard disk's uri. It should be a valid Uri
        /// to a virtual hard disk.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "uri")]
        public string Uri { get; set; }

    }
}
