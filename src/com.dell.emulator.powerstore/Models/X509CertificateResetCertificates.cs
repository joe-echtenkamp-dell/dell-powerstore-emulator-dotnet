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
    /// x509 certificate reset operation request body. Was added in version 2.0.0.0.
    /// </summary>
    [DataContract]
    public partial class X509CertificateResetCertificates : IEquatable<X509CertificateResetCertificates>
    { 
        /// <summary>
        /// Gets or Sets Service
        /// </summary>
        [Required]
        
        [DataMember(Name="service")]
        public X509CertificateServiceEnum? Service { get; set; }

        /// <summary>
        /// Scope defines a subset of certificates belonging to one Service. Scope has different meanings from different Services and types. For example, in Replication_HTTP, CA type certificates will use scope to indicate the origin of these certificates. Service, type and scope mapping are listed as here - - Certificate with Service Management_HTTP and Type of Server, Scope value can be null(unused and optional); Certificate with Service Replication_HTTP and Type of Client, Scope value can be null(unused and optional); Certificate with Service Replication_HTTP and Type of CA, Scope value has to be the serial number of remote cluster; Certificate with Service VASA_HTTP and Type of Server, Scope value can be null(unused and optional); Certificate with Service VASA_HTTP and Type of CA, Scope value can be null(unused and optional); Certificate with Service Import_HTTP and Type of CA, Scope value has to be the management address of external storage system; Certificate with Service LDAP_HTTP and Type of CA, Scope value is LDAP Domain Name; Certificate with Service KMIP_HTTP and Type of Server, Scope value can be null(unused and optional); Certificate with Service SecurID_HTTP and Type of CA, Scope value can be null(unused and optional); Certificate with Service Remote_Backup_HTTP and Type of CA, Scope value has to be the management address of Power Protect/Data Domain system; Was added in version 3.0.0.0.
        /// </summary>
        /// <value>Scope defines a subset of certificates belonging to one Service. Scope has different meanings from different Services and types. For example, in Replication_HTTP, CA type certificates will use scope to indicate the origin of these certificates. Service, type and scope mapping are listed as here - - Certificate with Service Management_HTTP and Type of Server, Scope value can be null(unused and optional); Certificate with Service Replication_HTTP and Type of Client, Scope value can be null(unused and optional); Certificate with Service Replication_HTTP and Type of CA, Scope value has to be the serial number of remote cluster; Certificate with Service VASA_HTTP and Type of Server, Scope value can be null(unused and optional); Certificate with Service VASA_HTTP and Type of CA, Scope value can be null(unused and optional); Certificate with Service Import_HTTP and Type of CA, Scope value has to be the management address of external storage system; Certificate with Service LDAP_HTTP and Type of CA, Scope value is LDAP Domain Name; Certificate with Service KMIP_HTTP and Type of Server, Scope value can be null(unused and optional); Certificate with Service SecurID_HTTP and Type of CA, Scope value can be null(unused and optional); Certificate with Service Remote_Backup_HTTP and Type of CA, Scope value has to be the management address of Power Protect/Data Domain system; Was added in version 3.0.0.0.</value>

        [DataMember(Name="scope")]
        public string Scope { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class X509CertificateResetCertificates {\n");
            sb.Append("  Service: ").Append(Service).Append("\n");
            sb.Append("  Scope: ").Append(Scope).Append("\n");
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
            return obj.GetType() == GetType() && Equals((X509CertificateResetCertificates)obj);
        }

        /// <summary>
        /// Returns true if X509CertificateResetCertificates instances are equal
        /// </summary>
        /// <param name="other">Instance of X509CertificateResetCertificates to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(X509CertificateResetCertificates other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Service == other.Service ||
                    Service != null &&
                    Service.Equals(other.Service)
                ) && 
                (
                    Scope == other.Scope ||
                    Scope != null &&
                    Scope.Equals(other.Scope)
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
                    if (Service != null)
                    hashCode = hashCode * 59 + Service.GetHashCode();
                    if (Scope != null)
                    hashCode = hashCode * 59 + Scope.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(X509CertificateResetCertificates left, X509CertificateResetCertificates right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(X509CertificateResetCertificates left, X509CertificateResetCertificates right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
