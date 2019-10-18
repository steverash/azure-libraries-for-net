// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.Batch.Fluent.Models
{
    using Microsoft.Azure.Management.ResourceManager;
    using Microsoft.Azure.Management.ResourceManager.Fluent;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Contains information about a certificate.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class CertificateInner : Management.ResourceManager.Fluent.Resource
    {
        /// <summary>
        /// Initializes a new instance of the CertificateInner class.
        /// </summary>
        public CertificateInner()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CertificateInner class.
        /// </summary>
        /// <param name="thumbprintAlgorithm">The algorithm of the certificate
        /// thumbprint</param>
        /// <param name="thumbprint">The thumbprint of the certificate</param>
        /// <param name="format">The format of the certificate - either Pfx or
        /// Cer. If omitted, the default is Pfx. Possible values include:
        /// 'Pfx', 'Cer'</param>
        /// <param name="provisioningState">The provisioned state of the
        /// resource</param>
        /// <param name="provisioningStateTransitionTime">The time at which the
        /// certificate entered its current state.</param>
        /// <param name="previousProvisioningState">The previous provisioned
        /// state of the resource. Possible values include: 'Succeeded',
        /// 'Deleting', 'Failed'</param>
        /// <param name="previousProvisioningStateTransitionTime">The time at
        /// which the certificate entered its previous state.</param>
        /// <param name="publicData">The public key of the certificate.</param>
        /// <param name="deleteCertificateError">The error which occurred while
        /// deleting the certificate</param>
        /// <param name="etag">The ETag of the resource, used for concurrency
        /// statements.</param>
        public CertificateInner(string id = default(string), string name = default(string), string type = default(string), string thumbprintAlgorithm = default(string), string thumbprint = default(string), CertificateFormat format = default(CertificateFormat), CertificateProvisioningState provisioningState = default(CertificateProvisioningState), System.DateTime? provisioningStateTransitionTime = default(System.DateTime?), CertificateProvisioningState previousProvisioningState = default(CertificateProvisioningState), System.DateTime? previousProvisioningStateTransitionTime = default(System.DateTime?), string publicData = default(string), DeleteCertificateError deleteCertificateError = default(DeleteCertificateError), string etag = default(string))
            : base(id, name, type)
        {
            ThumbprintAlgorithm = thumbprintAlgorithm;
            Thumbprint = thumbprint;
            Format = format;
            ProvisioningState = provisioningState;
            ProvisioningStateTransitionTime = provisioningStateTransitionTime;
            PreviousProvisioningState = previousProvisioningState;
            PreviousProvisioningStateTransitionTime = previousProvisioningStateTransitionTime;
            PublicData = publicData;
            DeleteCertificateError = deleteCertificateError;
            Etag = etag;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the algorithm of the certificate thumbprint
        /// </summary>
        /// <remarks>
        /// This must match the first portion of the certificate name.
        /// Currently required to be 'SHA1'.
        /// </remarks>
        [JsonProperty(PropertyName = "properties.thumbprintAlgorithm")]
        public string ThumbprintAlgorithm { get; set; }

        /// <summary>
        /// Gets or sets the thumbprint of the certificate
        /// </summary>
        /// <remarks>
        /// This must match the thumbprint from the name.
        /// </remarks>
        [JsonProperty(PropertyName = "properties.thumbprint")]
        public string Thumbprint { get; set; }

        /// <summary>
        /// Gets or sets the format of the certificate - either Pfx or Cer. If
        /// omitted, the default is Pfx. Possible values include: 'Pfx', 'Cer'
        /// </summary>
        [JsonProperty(PropertyName = "properties.format")]
        public CertificateFormat Format { get; set; }

        /// <summary>
        /// Gets the provisioned state of the resource
        /// </summary>
        /// <remarks>
        /// Possible values include: 'Succeeded', 'Deleting', 'Failed'
        /// </remarks>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public CertificateProvisioningState ProvisioningState { get; private set; }

        /// <summary>
        /// Gets the time at which the certificate entered its current state.
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningStateTransitionTime")]
        public System.DateTime? ProvisioningStateTransitionTime { get; private set; }

        /// <summary>
        /// Gets the previous provisioned state of the resource. Possible
        /// values include: 'Succeeded', 'Deleting', 'Failed'
        /// </summary>
        [JsonProperty(PropertyName = "properties.previousProvisioningState")]
        public CertificateProvisioningState PreviousProvisioningState { get; private set; }

        /// <summary>
        /// Gets the time at which the certificate entered its previous state.
        /// </summary>
        [JsonProperty(PropertyName = "properties.previousProvisioningStateTransitionTime")]
        public System.DateTime? PreviousProvisioningStateTransitionTime { get; private set; }

        /// <summary>
        /// Gets the public key of the certificate.
        /// </summary>
        [JsonProperty(PropertyName = "properties.publicData")]
        public string PublicData { get; private set; }

        /// <summary>
        /// Gets the error which occurred while deleting the certificate
        /// </summary>
        /// <remarks>
        /// This is only returned when the certificate provisioningState is
        /// 'Failed'.
        /// </remarks>
        [JsonProperty(PropertyName = "properties.deleteCertificateError")]
        public DeleteCertificateError DeleteCertificateError { get; private set; }

        /// <summary>
        /// Gets the ETag of the resource, used for concurrency statements.
        /// </summary>
        [JsonProperty(PropertyName = "etag")]
        public string Etag { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (DeleteCertificateError != null)
            {
                DeleteCertificateError.Validate();
            }
        }
    }
}