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
    /// Snapshot volume group request.
    /// </summary>
    [DataContract]
    public partial class VolumeGroupSnapshot : IEquatable<VolumeGroupSnapshot>
    { 
        /// <summary>
        /// Unique name of the snapshot set to be created.
        /// </summary>
        /// <value>Unique name of the snapshot set to be created.</value>
        [Required]
        
        [StringLength(128, MinimumLength=1)]
        [DataMember(Name="name")]
        public string Name { get; set; }

        /// <summary>
        /// Optional description for the snapshot set.  If description is not specified, the description for the snapshot set will not be set. 
        /// </summary>
        /// <value>Optional description for the snapshot set.  If description is not specified, the description for the snapshot set will not be set. </value>

        [DataMember(Name="description")]
        public string Description { get; set; }

        /// <summary>
        /// Time after which the snapshot set can be auto-purged. Time must be specified in Zulu time zone. Expiration time cannot be prior to current time.  Use a maximum timestamp value to set an expiration to never expire.  Valid format is yyyy-MM-dd&#39;T&#39;HH:mm:ssZ or yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ.  By default, expiration time will not be set.  Was added in version 2.0.0.0.
        /// </summary>
        /// <value>Time after which the snapshot set can be auto-purged. Time must be specified in Zulu time zone. Expiration time cannot be prior to current time.  Use a maximum timestamp value to set an expiration to never expire.  Valid format is yyyy-MM-dd&#39;T&#39;HH:mm:ssZ or yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ.  By default, expiration time will not be set.  Was added in version 2.0.0.0.</value>

        [DataMember(Name="expiration_timestamp")]
        public DateTime? ExpirationTimestamp { get; set; }

        /// <summary>
        /// Create a secure snapshot. This parameter requires a valid expiration_timestamp to be set in the request.  Was added in version 3.5.0.0.
        /// </summary>
        /// <value>Create a secure snapshot. This parameter requires a valid expiration_timestamp to be set in the request.  Was added in version 3.5.0.0.</value>

        [DataMember(Name="is_secure")]
        public bool? IsSecure { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VolumeGroupSnapshot {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  ExpirationTimestamp: ").Append(ExpirationTimestamp).Append("\n");
            sb.Append("  IsSecure: ").Append(IsSecure).Append("\n");
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
            return obj.GetType() == GetType() && Equals((VolumeGroupSnapshot)obj);
        }

        /// <summary>
        /// Returns true if VolumeGroupSnapshot instances are equal
        /// </summary>
        /// <param name="other">Instance of VolumeGroupSnapshot to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VolumeGroupSnapshot other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Name == other.Name ||
                    Name != null &&
                    Name.Equals(other.Name)
                ) && 
                (
                    Description == other.Description ||
                    Description != null &&
                    Description.Equals(other.Description)
                ) && 
                (
                    ExpirationTimestamp == other.ExpirationTimestamp ||
                    ExpirationTimestamp != null &&
                    ExpirationTimestamp.Equals(other.ExpirationTimestamp)
                ) && 
                (
                    IsSecure == other.IsSecure ||
                    IsSecure != null &&
                    IsSecure.Equals(other.IsSecure)
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
                    if (Name != null)
                    hashCode = hashCode * 59 + Name.GetHashCode();
                    if (Description != null)
                    hashCode = hashCode * 59 + Description.GetHashCode();
                    if (ExpirationTimestamp != null)
                    hashCode = hashCode * 59 + ExpirationTimestamp.GetHashCode();
                    if (IsSecure != null)
                    hashCode = hashCode * 59 + IsSecure.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(VolumeGroupSnapshot left, VolumeGroupSnapshot right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(VolumeGroupSnapshot left, VolumeGroupSnapshot right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
