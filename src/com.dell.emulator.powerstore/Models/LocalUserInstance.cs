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
    /// Information about a local user.
    /// </summary>
    [DataContract]
    public partial class LocalUserInstance : IEquatable<LocalUserInstance>
    { 
        /// <summary>
        /// Unique identifier of the local user account.
        /// </summary>
        /// <value>Unique identifier of the local user account.</value>

        [DataMember(Name="id")]
        public string Id { get; set; }

        /// <summary>
        /// Name of the local user account.
        /// </summary>
        /// <value>Name of the local user account.</value>

        [DataMember(Name="name")]
        public string Name { get; set; }

        /// <summary>
        /// Whether the user account is built-in or not.
        /// </summary>
        /// <value>Whether the user account is built-in or not.</value>

        [DataMember(Name="is_built_in")]
        public bool? IsBuiltIn { get; set; }

        /// <summary>
        /// Whether the user account is locked or not. Defaults to false at creation time.
        /// </summary>
        /// <value>Whether the user account is locked or not. Defaults to false at creation time.</value>

        [DataMember(Name="is_locked")]
        public bool? IsLocked { get; set; }

        /// <summary>
        /// Whether the user account has a default password or not. Only applies to default user accounts.
        /// </summary>
        /// <value>Whether the user account has a default password or not. Only applies to default user accounts.</value>

        [DataMember(Name="is_default_password")]
        public bool? IsDefaultPassword { get; set; }

        /// <summary>
        /// If true, multi-factor authentication (MFA) will not apply to this account. Only applies when MFA is enabled. Was added in version 3.5.0.0.
        /// </summary>
        /// <value>If true, multi-factor authentication (MFA) will not apply to this account. Only applies when MFA is enabled. Was added in version 3.5.0.0.</value>

        [DataMember(Name="is_mfa_bypass")]
        public bool? IsMfaBypass { get; set; }

        /// <summary>
        /// Unique identifier of the role local user account is mapped to.
        /// </summary>
        /// <value>Unique identifier of the role local user account is mapped to.</value>

        [DataMember(Name="role_id")]
        public string RoleId { get; set; }

        /// <summary>
        /// Timestamp when the password will expire. Was added in version 3.0.0.0.
        /// </summary>
        /// <value>Timestamp when the password will expire. Was added in version 3.0.0.0.</value>

        [DataMember(Name="password_expiration_timestamp")]
        public DateTime? PasswordExpirationTimestamp { get; set; }

        /// <summary>
        /// This is the user name that will be transmitted to the MFA service to identify this local user. The field is constructed with local username and the cluster&#39;s unique identifier. It is immutable and has the following format localUserName@clusterGlobalID. The clusterGlobalID value is available in the global_id property of the cluster resource.  Was added in version 3.5.0.0.
        /// </summary>
        /// <value>This is the user name that will be transmitted to the MFA service to identify this local user. The field is constructed with local username and the cluster&#39;s unique identifier. It is immutable and has the following format localUserName@clusterGlobalID. The clusterGlobalID value is available in the global_id property of the cluster resource.  Was added in version 3.5.0.0.</value>

        [DataMember(Name="mfa_alias")]
        public string MfaAlias { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LocalUserInstance {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  IsBuiltIn: ").Append(IsBuiltIn).Append("\n");
            sb.Append("  IsLocked: ").Append(IsLocked).Append("\n");
            sb.Append("  IsDefaultPassword: ").Append(IsDefaultPassword).Append("\n");
            sb.Append("  IsMfaBypass: ").Append(IsMfaBypass).Append("\n");
            sb.Append("  RoleId: ").Append(RoleId).Append("\n");
            sb.Append("  PasswordExpirationTimestamp: ").Append(PasswordExpirationTimestamp).Append("\n");
            sb.Append("  MfaAlias: ").Append(MfaAlias).Append("\n");
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
            return obj.GetType() == GetType() && Equals((LocalUserInstance)obj);
        }

        /// <summary>
        /// Returns true if LocalUserInstance instances are equal
        /// </summary>
        /// <param name="other">Instance of LocalUserInstance to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LocalUserInstance other)
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
                    Name == other.Name ||
                    Name != null &&
                    Name.Equals(other.Name)
                ) && 
                (
                    IsBuiltIn == other.IsBuiltIn ||
                    IsBuiltIn != null &&
                    IsBuiltIn.Equals(other.IsBuiltIn)
                ) && 
                (
                    IsLocked == other.IsLocked ||
                    IsLocked != null &&
                    IsLocked.Equals(other.IsLocked)
                ) && 
                (
                    IsDefaultPassword == other.IsDefaultPassword ||
                    IsDefaultPassword != null &&
                    IsDefaultPassword.Equals(other.IsDefaultPassword)
                ) && 
                (
                    IsMfaBypass == other.IsMfaBypass ||
                    IsMfaBypass != null &&
                    IsMfaBypass.Equals(other.IsMfaBypass)
                ) && 
                (
                    RoleId == other.RoleId ||
                    RoleId != null &&
                    RoleId.Equals(other.RoleId)
                ) && 
                (
                    PasswordExpirationTimestamp == other.PasswordExpirationTimestamp ||
                    PasswordExpirationTimestamp != null &&
                    PasswordExpirationTimestamp.Equals(other.PasswordExpirationTimestamp)
                ) && 
                (
                    MfaAlias == other.MfaAlias ||
                    MfaAlias != null &&
                    MfaAlias.Equals(other.MfaAlias)
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
                    if (Name != null)
                    hashCode = hashCode * 59 + Name.GetHashCode();
                    if (IsBuiltIn != null)
                    hashCode = hashCode * 59 + IsBuiltIn.GetHashCode();
                    if (IsLocked != null)
                    hashCode = hashCode * 59 + IsLocked.GetHashCode();
                    if (IsDefaultPassword != null)
                    hashCode = hashCode * 59 + IsDefaultPassword.GetHashCode();
                    if (IsMfaBypass != null)
                    hashCode = hashCode * 59 + IsMfaBypass.GetHashCode();
                    if (RoleId != null)
                    hashCode = hashCode * 59 + RoleId.GetHashCode();
                    if (PasswordExpirationTimestamp != null)
                    hashCode = hashCode * 59 + PasswordExpirationTimestamp.GetHashCode();
                    if (MfaAlias != null)
                    hashCode = hashCode * 59 + MfaAlias.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(LocalUserInstance left, LocalUserInstance right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(LocalUserInstance left, LocalUserInstance right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
