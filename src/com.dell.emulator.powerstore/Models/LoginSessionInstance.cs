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
    /// 
    /// </summary>
    [DataContract]
    public partial class LoginSessionInstance : IEquatable<LoginSessionInstance>
    { 
        /// <summary>
        /// Unique identifier of the login session.
        /// </summary>
        /// <value>Unique identifier of the login session.</value>

        [DataMember(Name="id")]
        public string Id { get; set; }

        /// <summary>
        /// Fully qualified user account name being used to log in.
        /// </summary>
        /// <value>Fully qualified user account name being used to log in.</value>

        [DataMember(Name="user")]
        public string User { get; set; }

        /// <summary>
        /// Roles to which the logged-in user is mapped.
        /// </summary>
        /// <value>Roles to which the logged-in user is mapped.</value>

        [DataMember(Name="role_ids")]
        public List<string> RoleIds { get; set; }

        /// <summary>
        /// Remaining idle time until the session will expire, in seconds.
        /// </summary>
        /// <value>Remaining idle time until the session will expire, in seconds.</value>

        [Range(0, 2147483647)]
        [DataMember(Name="idle_timeout")]
        public int? IdleTimeout { get; set; }

        /// <summary>
        /// Indicates whether the logged-in user requires a password change.
        /// </summary>
        /// <value>Indicates whether the logged-in user requires a password change.</value>

        [DataMember(Name="is_password_change_required")]
        public bool? IsPasswordChangeRequired { get; set; }

        /// <summary>
        /// Indicates whether the logged-in user is predefined.
        /// </summary>
        /// <value>Indicates whether the logged-in user is predefined.</value>

        [DataMember(Name="is_built_in_user")]
        public bool? IsBuiltInUser { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LoginSessionInstance {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  RoleIds: ").Append(RoleIds).Append("\n");
            sb.Append("  IdleTimeout: ").Append(IdleTimeout).Append("\n");
            sb.Append("  IsPasswordChangeRequired: ").Append(IsPasswordChangeRequired).Append("\n");
            sb.Append("  IsBuiltInUser: ").Append(IsBuiltInUser).Append("\n");
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
            return obj.GetType() == GetType() && Equals((LoginSessionInstance)obj);
        }

        /// <summary>
        /// Returns true if LoginSessionInstance instances are equal
        /// </summary>
        /// <param name="other">Instance of LoginSessionInstance to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LoginSessionInstance other)
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
                    User == other.User ||
                    User != null &&
                    User.Equals(other.User)
                ) && 
                (
                    RoleIds == other.RoleIds ||
                    RoleIds != null &&
                    RoleIds.SequenceEqual(other.RoleIds)
                ) && 
                (
                    IdleTimeout == other.IdleTimeout ||
                    IdleTimeout != null &&
                    IdleTimeout.Equals(other.IdleTimeout)
                ) && 
                (
                    IsPasswordChangeRequired == other.IsPasswordChangeRequired ||
                    IsPasswordChangeRequired != null &&
                    IsPasswordChangeRequired.Equals(other.IsPasswordChangeRequired)
                ) && 
                (
                    IsBuiltInUser == other.IsBuiltInUser ||
                    IsBuiltInUser != null &&
                    IsBuiltInUser.Equals(other.IsBuiltInUser)
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
                    if (User != null)
                    hashCode = hashCode * 59 + User.GetHashCode();
                    if (RoleIds != null)
                    hashCode = hashCode * 59 + RoleIds.GetHashCode();
                    if (IdleTimeout != null)
                    hashCode = hashCode * 59 + IdleTimeout.GetHashCode();
                    if (IsPasswordChangeRequired != null)
                    hashCode = hashCode * 59 + IsPasswordChangeRequired.GetHashCode();
                    if (IsBuiltInUser != null)
                    hashCode = hashCode * 59 + IsBuiltInUser.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(LoginSessionInstance left, LoginSessionInstance right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(LoginSessionInstance left, LoginSessionInstance right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
