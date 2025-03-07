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
    /// Error message for an operation.
    /// </summary>
    [DataContract]
    public partial class ErrorMessage : IEquatable<ErrorMessage>
    { 
        /// <summary>
        /// Hexadecimal error code of the message.
        /// </summary>
        /// <value>Hexadecimal error code of the message.</value>

        [DataMember(Name="code")]
        public string Code { get; set; }

        /// <summary>
        /// Gets or Sets Severity
        /// </summary>

        [DataMember(Name="severity")]
        public MessageSeverityEnum? Severity { get; set; }

        /// <summary>
        /// The message description in the specified locale with arguments substituted. 
        /// </summary>
        /// <value>The message description in the specified locale with arguments substituted. </value>

        [DataMember(Name="message_l10n")]
        public string MessageL10n { get; set; }

        /// <summary>
        /// Arguments (if applicable) for the error message.
        /// </summary>
        /// <value>Arguments (if applicable) for the error message.</value>

        [DataMember(Name="arguments")]
        public List<string> Arguments { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ErrorMessage {\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Severity: ").Append(Severity).Append("\n");
            sb.Append("  MessageL10n: ").Append(MessageL10n).Append("\n");
            sb.Append("  Arguments: ").Append(Arguments).Append("\n");
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
            return obj.GetType() == GetType() && Equals((ErrorMessage)obj);
        }

        /// <summary>
        /// Returns true if ErrorMessage instances are equal
        /// </summary>
        /// <param name="other">Instance of ErrorMessage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ErrorMessage other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Code == other.Code ||
                    Code != null &&
                    Code.Equals(other.Code)
                ) && 
                (
                    Severity == other.Severity ||
                    Severity != null &&
                    Severity.Equals(other.Severity)
                ) && 
                (
                    MessageL10n == other.MessageL10n ||
                    MessageL10n != null &&
                    MessageL10n.Equals(other.MessageL10n)
                ) && 
                (
                    Arguments == other.Arguments ||
                    Arguments != null &&
                    Arguments.SequenceEqual(other.Arguments)
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
                    if (Code != null)
                    hashCode = hashCode * 59 + Code.GetHashCode();
                    if (Severity != null)
                    hashCode = hashCode * 59 + Severity.GetHashCode();
                    if (MessageL10n != null)
                    hashCode = hashCode * 59 + MessageL10n.GetHashCode();
                    if (Arguments != null)
                    hashCode = hashCode * 59 + Arguments.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(ErrorMessage left, ErrorMessage right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(ErrorMessage left, ErrorMessage right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
