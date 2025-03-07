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
    /// Request arguments for the NFS server join operation.
    /// </summary>
    [DataContract]
    public partial class NfsServerJoin : IEquatable<NfsServerJoin>
    { 
        /// <summary>
        /// Name of a domain-user with privileges to join the Active Directory domain.
        /// </summary>
        /// <value>Name of a domain-user with privileges to join the Active Directory domain.</value>
        [Required]
        
        [DataMember(Name="domain_user_name")]
        public string DomainUserName { get; set; }

        /// <summary>
        /// Password of the domain-user specified to join the Active Directory domain.
        /// </summary>
        /// <value>Password of the domain-user specified to join the Active Directory domain.</value>
        [Required]
        
        [DataMember(Name="domain_password")]
        public string DomainPassword { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NfsServerJoin {\n");
            sb.Append("  DomainUserName: ").Append(DomainUserName).Append("\n");
            sb.Append("  DomainPassword: ").Append(DomainPassword).Append("\n");
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
            return obj.GetType() == GetType() && Equals((NfsServerJoin)obj);
        }

        /// <summary>
        /// Returns true if NfsServerJoin instances are equal
        /// </summary>
        /// <param name="other">Instance of NfsServerJoin to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NfsServerJoin other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    DomainUserName == other.DomainUserName ||
                    DomainUserName != null &&
                    DomainUserName.Equals(other.DomainUserName)
                ) && 
                (
                    DomainPassword == other.DomainPassword ||
                    DomainPassword != null &&
                    DomainPassword.Equals(other.DomainPassword)
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
                    if (DomainUserName != null)
                    hashCode = hashCode * 59 + DomainUserName.GetHashCode();
                    if (DomainPassword != null)
                    hashCode = hashCode * 59 + DomainPassword.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(NfsServerJoin left, NfsServerJoin right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(NfsServerJoin left, NfsServerJoin right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
