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
    /// Parameters for x509 Certificate create operation. Was added in version 2.0.0.0.
    /// </summary>
    [DataContract]
    public partial class X509CertificateCreate : IEquatable<X509CertificateCreate>
    { 
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [Required]
        
        [DataMember(Name="type")]
        public X509CertificateUsageTypeEnum? Type { get; set; }

        /// <summary>
        /// Gets or Sets Service
        /// </summary>
        [Required]
        
        [DataMember(Name="service")]
        public X509CertificateServiceEnum? Service { get; set; }

        /// <summary>
        /// Scope defines a subset of certificates belonging to one Service. Scope has different meanings from different Services and types. For example, in Replication_HTTP, CA type certificates will use scope to indicate the origin of these certificates. Service, type and scope mapping are listed as below. - Certificate with Service Management_HTTP and Type of Server, Scope value can only be &#39;External&#39;. - Certificate with Service Replication_HTTP and Type of Client, Scope value can be null(unused and optional). - Certificate with Service Replication_HTTP and Type of CA, Scope value has to be the serial number of remote cluster. - Certificate with Service VASA_HTTP and Type of Server, Scope value can be null(unused and optional). - Certificate with Service VASA_HTTP and Type of CA, Scope value can be null(unused and optional). - Certificate with Service Import_HTTP and Type of CA, Scope value has to be the management address of external storage system. - Certificate with Service LDAP_HTTP and Type of CA, Scope value is LDAP Domain Name. - Certificate with Service KMIP_HTTP and Type of Client, Scope value can be null(unused and optional). - Certificate with Service Syslog_HTTP and Type of Client, Scope value can be null(unused and optional) - Certificate with Service SecurID_HTTP and Type of CA, scope has to be the unique ID of the MFA service. - Certificate with Service Witness_HTTP and Type of Client, Scope value can be null(unused and optional). - Certificate with Service Remote_Backup_HTTP and Type of CA, Scope value has to be the management address of Power Protect/Data Domain system. 
        /// </summary>
        /// <value>Scope defines a subset of certificates belonging to one Service. Scope has different meanings from different Services and types. For example, in Replication_HTTP, CA type certificates will use scope to indicate the origin of these certificates. Service, type and scope mapping are listed as below. - Certificate with Service Management_HTTP and Type of Server, Scope value can only be &#39;External&#39;. - Certificate with Service Replication_HTTP and Type of Client, Scope value can be null(unused and optional). - Certificate with Service Replication_HTTP and Type of CA, Scope value has to be the serial number of remote cluster. - Certificate with Service VASA_HTTP and Type of Server, Scope value can be null(unused and optional). - Certificate with Service VASA_HTTP and Type of CA, Scope value can be null(unused and optional). - Certificate with Service Import_HTTP and Type of CA, Scope value has to be the management address of external storage system. - Certificate with Service LDAP_HTTP and Type of CA, Scope value is LDAP Domain Name. - Certificate with Service KMIP_HTTP and Type of Client, Scope value can be null(unused and optional). - Certificate with Service Syslog_HTTP and Type of Client, Scope value can be null(unused and optional) - Certificate with Service SecurID_HTTP and Type of CA, scope has to be the unique ID of the MFA service. - Certificate with Service Witness_HTTP and Type of Client, Scope value can be null(unused and optional). - Certificate with Service Remote_Backup_HTTP and Type of CA, Scope value has to be the management address of Power Protect/Data Domain system. </value>

        [DataMember(Name="scope")]
        public string Scope { get; set; }

        /// <summary>
        /// Concatenated PEM encoded (including header, footer and line break) X509 certificate string from end-entity certificate to root certificate. End-entity certificate has to be put at the top and the sequence should be maintained as the certificate chain from end-entity certificate to the root certificate.
        /// </summary>
        /// <value>Concatenated PEM encoded (including header, footer and line break) X509 certificate string from end-entity certificate to root certificate. End-entity certificate has to be put at the top and the sequence should be maintained as the certificate chain from end-entity certificate to the root certificate.</value>
        [Required]
        
        [DataMember(Name="certificate")]
        public string Certificate { get; set; }

        /// <summary>
        /// PEM encoded (including header, footer and line break) private key following encrypted PKCS8.
        /// </summary>
        /// <value>PEM encoded (including header, footer and line break) private key following encrypted PKCS8.</value>

        [DataMember(Name="private_key")]
        public string PrivateKey { get; set; }

        /// <summary>
        /// Passphrase used to encrypt private key.
        /// </summary>
        /// <value>Passphrase used to encrypt private key.</value>

        [DataMember(Name="passphrase")]
        public string Passphrase { get; set; }

        /// <summary>
        /// Indicates whether this is the current X509 certificate to be used by the service or this X509 certificate will be used in the future. When is_current is false for a X509 certificate, this X509 certificate will not be picked up by the service. Potential usage of this attribute is to prepare for the certificate roll-over/rotation.
        /// </summary>
        /// <value>Indicates whether this is the current X509 certificate to be used by the service or this X509 certificate will be used in the future. When is_current is false for a X509 certificate, this X509 certificate will not be picked up by the service. Potential usage of this attribute is to prepare for the certificate roll-over/rotation.</value>

        [DataMember(Name="is_current")]
        public bool? IsCurrent { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class X509CertificateCreate {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Service: ").Append(Service).Append("\n");
            sb.Append("  Scope: ").Append(Scope).Append("\n");
            sb.Append("  Certificate: ").Append(Certificate).Append("\n");
            sb.Append("  PrivateKey: ").Append(PrivateKey).Append("\n");
            sb.Append("  Passphrase: ").Append(Passphrase).Append("\n");
            sb.Append("  IsCurrent: ").Append(IsCurrent).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
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
            return obj.GetType() == GetType() && Equals((X509CertificateCreate)obj);
        }

        /// <summary>
        /// Returns true if X509CertificateCreate instances are equal
        /// </summary>
        /// <param name="other">Instance of X509CertificateCreate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(X509CertificateCreate other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
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
                    Certificate == other.Certificate ||
                    Certificate != null &&
                    Certificate.Equals(other.Certificate)
                ) && 
                (
                    PrivateKey == other.PrivateKey ||
                    PrivateKey != null &&
                    PrivateKey.Equals(other.PrivateKey)
                ) && 
                (
                    Passphrase == other.Passphrase ||
                    Passphrase != null &&
                    Passphrase.Equals(other.Passphrase)
                ) && 
                (
                    IsCurrent == other.IsCurrent ||
                    IsCurrent != null &&
                    IsCurrent.Equals(other.IsCurrent)
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
                    if (Type != null)
                    hashCode = hashCode * 59 + Type.GetHashCode();
                    if (Service != null)
                    hashCode = hashCode * 59 + Service.GetHashCode();
                    if (Scope != null)
                    hashCode = hashCode * 59 + Scope.GetHashCode();
                    if (Certificate != null)
                    hashCode = hashCode * 59 + Certificate.GetHashCode();
                    if (PrivateKey != null)
                    hashCode = hashCode * 59 + PrivateKey.GetHashCode();
                    if (Passphrase != null)
                    hashCode = hashCode * 59 + Passphrase.GetHashCode();
                    if (IsCurrent != null)
                    hashCode = hashCode * 59 + IsCurrent.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(X509CertificateCreate left, X509CertificateCreate right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(X509CertificateCreate left, X509CertificateCreate right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
