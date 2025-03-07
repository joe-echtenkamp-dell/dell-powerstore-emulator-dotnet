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
    /// Validate the hardware upgrade process to determine whether an upgrade can be performed on this hardware component. The response includes any detected issues.  Was added in version 3.6.0.0.
    /// </summary>
    [DataContract]
    public partial class HardwareValidateUpgrade : IEquatable<HardwareValidateUpgrade>
    { 
        /// <summary>
        /// Gets or Sets ModelName
        /// </summary>
        [Required]
        
        [DataMember(Name="model_name")]
        public HardwareModelTypeEnum? ModelName { get; set; }

        /// <summary>
        /// Gets or Sets UpgradeType
        /// </summary>
        [Required]
        
        [DataMember(Name="upgrade_type")]
        public HardwareUpgradeTypeEnum? UpgradeType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HardwareValidateUpgrade {\n");
            sb.Append("  ModelName: ").Append(ModelName).Append("\n");
            sb.Append("  UpgradeType: ").Append(UpgradeType).Append("\n");
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
            return obj.GetType() == GetType() && Equals((HardwareValidateUpgrade)obj);
        }

        /// <summary>
        /// Returns true if HardwareValidateUpgrade instances are equal
        /// </summary>
        /// <param name="other">Instance of HardwareValidateUpgrade to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HardwareValidateUpgrade other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    ModelName == other.ModelName ||
                    ModelName != null &&
                    ModelName.Equals(other.ModelName)
                ) && 
                (
                    UpgradeType == other.UpgradeType ||
                    UpgradeType != null &&
                    UpgradeType.Equals(other.UpgradeType)
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
                    if (ModelName != null)
                    hashCode = hashCode * 59 + ModelName.GetHashCode();
                    if (UpgradeType != null)
                    hashCode = hashCode * 59 + UpgradeType.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(HardwareValidateUpgrade left, HardwareValidateUpgrade right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(HardwareValidateUpgrade left, HardwareValidateUpgrade right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
