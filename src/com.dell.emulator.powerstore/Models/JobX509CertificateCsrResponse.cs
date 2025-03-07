/*
 * PowerStore REST API
 *
 * Storage cluster REST API definition. ( For \"Try It Out\", use the cluster management IP address to load this swaggerui interface. )
 *
 * OpenAPI spec version: 4.0.0.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Com.Dell.Emulator.Powerstore.Models
{ 
    /// <summary>
    /// CSR response. Was added in version 2.0.0.0.
    /// </summary>
    [DataContract]
    public partial class JobX509CertificateCsrResponse : BaseResponse, IEquatable<JobX509CertificateCsrResponse>
    { 
        /// <summary>
        /// Unique ID of x509_certificate.
        /// </summary>
        /// <value>Unique ID of x509_certificate.</value>

        [DataMember(Name="id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>

        [DataMember(Name="type")]
        public X509CertificateUsageTypeEnum? Type { get; set; }

        /// <summary>
        /// Gets or Sets Service
        /// </summary>

        [DataMember(Name="service")]
        public X509CertificateServiceEnum? Service { get; set; }

        /// <summary>
        /// Scope defines a subset of certificates belonging to one service. Scope here defines what Certificate Signing Request (CSR) can be generated. The scope for CSR Response only includes: - Certificate with Service Management_HTTP and Type of Server, Scope value can only be External - Certificate with Service VASA_HTTP and Type of Server, Scope value can be null(unused and optional) - Certificate with Service KMIP_HTTP and Type of Client, Scope value can be null(unused and optional) - Certificate with Service Syslog_HTTP and Type of Client, Scope value can be null(unused and optional) 
        /// </summary>
        /// <value>Scope defines a subset of certificates belonging to one service. Scope here defines what Certificate Signing Request (CSR) can be generated. The scope for CSR Response only includes: - Certificate with Service Management_HTTP and Type of Server, Scope value can only be External - Certificate with Service VASA_HTTP and Type of Server, Scope value can be null(unused and optional) - Certificate with Service KMIP_HTTP and Type of Client, Scope value can be null(unused and optional) - Certificate with Service Syslog_HTTP and Type of Client, Scope value can be null(unused and optional) </value>

        [DataMember(Name="scope")]
        public string Scope { get; set; }

        /// <summary>
        /// Indicates whether this is the current X509 certificate to be used by the service or this X509 certificate will be used in the future. When is_current is false for a X509 Certificate, this X509 Certificate will not be picked up by the service. Potential usage of this attribute is to prepare for the certificate roll-over/rotation.
        /// </summary>
        /// <value>Indicates whether this is the current X509 certificate to be used by the service or this X509 certificate will be used in the future. When is_current is false for a X509 Certificate, this X509 Certificate will not be picked up by the service. Potential usage of this attribute is to prepare for the certificate roll-over/rotation.</value>

        [DataMember(Name="is_current")]
        public bool? IsCurrent { get; set; }

        /// <summary>
        /// Indicate whether this is a valid X509 Certificate. When X509 certificate is expired or X509 Certificate of server type missing either a private key or a valid certificate entry, it will be false.
        /// </summary>
        /// <value>Indicate whether this is a valid X509 Certificate. When X509 certificate is expired or X509 Certificate of server type missing either a private key or a valid certificate entry, it will be false.</value>

        [DataMember(Name="is_valid")]
        public bool? IsValid { get; set; }

        /// <summary>
        /// Member certificates included in this x509_certificate. It will be empty in csr creation response.
        /// </summary>
        /// <value>Member certificates included in this x509_certificate. It will be empty in csr creation response.</value>

        [DataMember(Name="members")]
        public List<MemberCertificateInstance> Members { get; set; }

        /// <summary>
        /// PEM encoded certificate signing request.
        /// </summary>
        /// <value>PEM encoded certificate signing request.</value>

        [DataMember(Name="certificate_request")]
        public string CertificateRequest { get; set; }

        /// <summary>
        /// Localized message string corresponding to type Was added in version 2.0.0.0.
        /// </summary>
        /// <value>Localized message string corresponding to type Was added in version 2.0.0.0.</value>

        [DataMember(Name="type_l10n")]
        public string TypeL10n { get; set; }

        /// <summary>
        /// Localized message string corresponding to service Was added in version 2.0.0.0.
        /// </summary>
        /// <value>Localized message string corresponding to service Was added in version 2.0.0.0.</value>

        [DataMember(Name="service_l10n")]
        public string ServiceL10n { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JobX509CertificateCsrResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Service: ").Append(Service).Append("\n");
            sb.Append("  Scope: ").Append(Scope).Append("\n");
            sb.Append("  IsCurrent: ").Append(IsCurrent).Append("\n");
            sb.Append("  IsValid: ").Append(IsValid).Append("\n");
            sb.Append("  Members: ").Append(Members).Append("\n");
            sb.Append("  CertificateRequest: ").Append(CertificateRequest).Append("\n");
            sb.Append("  TypeL10n: ").Append(TypeL10n).Append("\n");
            sb.Append("  ServiceL10n: ").Append(ServiceL10n).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public  new string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((JobX509CertificateCsrResponse)obj);
        }

        /// <summary>
        /// Returns true if JobX509CertificateCsrResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of JobX509CertificateCsrResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JobX509CertificateCsrResponse other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Id == other.Id ||
                    Id != null &&
                    Id.Equals(other.Id)
                ) && 
                (
                    Type == other.Type ||
                    Type != null &&
                    Type.Equals(other.Type)
                ) && 
                (
                    Service == other.Service ||
                    Service != null &&
                    Service.Equals(other.Service)
                ) && 
                (
                    Scope == other.Scope ||
                    Scope != null &&
                    Scope.Equals(other.Scope)
                ) && 
                (
                    IsCurrent == other.IsCurrent ||
                    IsCurrent != null &&
                    IsCurrent.Equals(other.IsCurrent)
                ) && 
                (
                    IsValid == other.IsValid ||
                    IsValid != null &&
                    IsValid.Equals(other.IsValid)
                ) && 
                (
                    Members == other.Members ||
                    Members != null &&
                    Members.SequenceEqual(other.Members)
                ) && 
                (
                    CertificateRequest == other.CertificateRequest ||
                    CertificateRequest != null &&
                    CertificateRequest.Equals(other.CertificateRequest)
                ) && 
                (
                    TypeL10n == other.TypeL10n ||
                    TypeL10n != null &&
                    TypeL10n.Equals(other.TypeL10n)
                ) && 
                (
                    ServiceL10n == other.ServiceL10n ||
                    ServiceL10n != null &&
                    ServiceL10n.Equals(other.ServiceL10n)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                // Suitable nullity checks etc, of course :)
                    if (Id != null)
                    hashCode = hashCode * 59 + Id.GetHashCode();
                    if (Type != null)
                    hashCode = hashCode * 59 + Type.GetHashCode();
                    if (Service != null)
                    hashCode = hashCode * 59 + Service.GetHashCode();
                    if (Scope != null)
                    hashCode = hashCode * 59 + Scope.GetHashCode();
                    if (IsCurrent != null)
                    hashCode = hashCode * 59 + IsCurrent.GetHashCode();
                    if (IsValid != null)
                    hashCode = hashCode * 59 + IsValid.GetHashCode();
                    if (Members != null)
                    hashCode = hashCode * 59 + Members.GetHashCode();
                    if (CertificateRequest != null)
                    hashCode = hashCode * 59 + CertificateRequest.GetHashCode();
                    if (TypeL10n != null)
                    hashCode = hashCode * 59 + TypeL10n.GetHashCode();
                    if (ServiceL10n != null)
                    hashCode = hashCode * 59 + ServiceL10n.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(JobX509CertificateCsrResponse left, JobX509CertificateCsrResponse right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(JobX509CertificateCsrResponse left, JobX509CertificateCsrResponse right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
