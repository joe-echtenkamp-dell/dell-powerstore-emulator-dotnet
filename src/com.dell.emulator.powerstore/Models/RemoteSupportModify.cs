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
    /// Remote support modify parameters. Was added in version 2.0.0.0.
    /// </summary>
    [DataContract]
    public partial class RemoteSupportModify : IEquatable<RemoteSupportModify>
    { 
        /// <summary>
        /// Gets or Sets Type
        /// </summary>

        [DataMember(Name="type")]
        public RemoteSupportTypeEnum? Type { get; set; }

        /// <summary>
        /// One or two remote support servers. If specified, this list will replace the existing list.
        /// </summary>
        /// <value>One or two remote support servers. If specified, this list will replace the existing list.</value>

        [DataMember(Name="remote_support_servers")]
        public List<RemoteSupportServerModify> RemoteSupportServers { get; set; }

        /// <summary>
        /// indicates whether user has accepted remote support license agreement before enabling the Support Assist on the system for the first time.
        /// </summary>
        /// <value>indicates whether user has accepted remote support license agreement before enabling the Support Assist on the system for the first time.</value>

        [DataMember(Name="is_support_assist_license_accepted")]
        public bool? IsSupportAssistLicenseAccepted { get; set; }

        /// <summary>
        /// Indicates whether support for CloudIQ is enabled.
        /// </summary>
        /// <value>Indicates whether support for CloudIQ is enabled.</value>

        [DataMember(Name="is_cloudiq_enabled")]
        public bool? IsCloudiqEnabled { get; set; }

        /// <summary>
        /// Indicates whether support for Remote Service Credentials is enabled.
        /// </summary>
        /// <value>Indicates whether support for Remote Service Credentials is enabled.</value>

        [DataMember(Name="is_rsc_enabled")]
        public bool? IsRscEnabled { get; set; }

        /// <summary>
        /// Proxy server IP address (IPv4).
        /// </summary>
        /// <value>Proxy server IP address (IPv4).</value>

        [DataMember(Name="proxy_address")]
        public string ProxyAddress { get; set; }

        /// <summary>
        /// Proxy server port number.
        /// </summary>
        /// <value>Proxy server port number.</value>

        [Range(0, 65635)]
        [DataMember(Name="proxy_port")]
        public int? ProxyPort { get; set; }

        /// <summary>
        /// User name for proxy server access.
        /// </summary>
        /// <value>User name for proxy server access.</value>

        [DataMember(Name="proxy_username")]
        public string ProxyUsername { get; set; }

        /// <summary>
        /// Password for proxy server access.
        /// </summary>
        /// <value>Password for proxy server access.</value>

        [DataMember(Name="proxy_password")]
        public string ProxyPassword { get; set; }

        /// <summary>
        /// Whether automatic software downloads are enabled. When enabled, new software packages that are valid for this PowerStore system will be automatically downloaded through the remote support connection, and an alert will be raised. Was added in version 3.0.0.0.
        /// </summary>
        /// <value>Whether automatic software downloads are enabled. When enabled, new software packages that are valid for this PowerStore system will be automatically downloaded through the remote support connection, and an alert will be raised. Was added in version 3.0.0.0.</value>

        [DataMember(Name="is_software_autodownload_enabled")]
        public bool? IsSoftwareAutodownloadEnabled { get; set; }

        /// <summary>
        ///  Was added in version 4.0.0.0.
        /// </summary>
        /// <value> Was added in version 4.0.0.0.</value>

        [DataMember(Name="classification_choice")]
        public SoftwarePackageClassificationChoiceEnum? ClassificationChoice { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RemoteSupportModify {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  RemoteSupportServers: ").Append(RemoteSupportServers).Append("\n");
            sb.Append("  IsSupportAssistLicenseAccepted: ").Append(IsSupportAssistLicenseAccepted).Append("\n");
            sb.Append("  IsCloudiqEnabled: ").Append(IsCloudiqEnabled).Append("\n");
            sb.Append("  IsRscEnabled: ").Append(IsRscEnabled).Append("\n");
            sb.Append("  ProxyAddress: ").Append(ProxyAddress).Append("\n");
            sb.Append("  ProxyPort: ").Append(ProxyPort).Append("\n");
            sb.Append("  ProxyUsername: ").Append(ProxyUsername).Append("\n");
            sb.Append("  ProxyPassword: ").Append(ProxyPassword).Append("\n");
            sb.Append("  IsSoftwareAutodownloadEnabled: ").Append(IsSoftwareAutodownloadEnabled).Append("\n");
            sb.Append("  ClassificationChoice: ").Append(ClassificationChoice).Append("\n");
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
            return obj.GetType() == GetType() && Equals((RemoteSupportModify)obj);
        }

        /// <summary>
        /// Returns true if RemoteSupportModify instances are equal
        /// </summary>
        /// <param name="other">Instance of RemoteSupportModify to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RemoteSupportModify other)
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
                    RemoteSupportServers == other.RemoteSupportServers ||
                    RemoteSupportServers != null &&
                    RemoteSupportServers.SequenceEqual(other.RemoteSupportServers)
                ) && 
                (
                    IsSupportAssistLicenseAccepted == other.IsSupportAssistLicenseAccepted ||
                    IsSupportAssistLicenseAccepted != null &&
                    IsSupportAssistLicenseAccepted.Equals(other.IsSupportAssistLicenseAccepted)
                ) && 
                (
                    IsCloudiqEnabled == other.IsCloudiqEnabled ||
                    IsCloudiqEnabled != null &&
                    IsCloudiqEnabled.Equals(other.IsCloudiqEnabled)
                ) && 
                (
                    IsRscEnabled == other.IsRscEnabled ||
                    IsRscEnabled != null &&
                    IsRscEnabled.Equals(other.IsRscEnabled)
                ) && 
                (
                    ProxyAddress == other.ProxyAddress ||
                    ProxyAddress != null &&
                    ProxyAddress.Equals(other.ProxyAddress)
                ) && 
                (
                    ProxyPort == other.ProxyPort ||
                    ProxyPort != null &&
                    ProxyPort.Equals(other.ProxyPort)
                ) && 
                (
                    ProxyUsername == other.ProxyUsername ||
                    ProxyUsername != null &&
                    ProxyUsername.Equals(other.ProxyUsername)
                ) && 
                (
                    ProxyPassword == other.ProxyPassword ||
                    ProxyPassword != null &&
                    ProxyPassword.Equals(other.ProxyPassword)
                ) && 
                (
                    IsSoftwareAutodownloadEnabled == other.IsSoftwareAutodownloadEnabled ||
                    IsSoftwareAutodownloadEnabled != null &&
                    IsSoftwareAutodownloadEnabled.Equals(other.IsSoftwareAutodownloadEnabled)
                ) && 
                (
                    ClassificationChoice == other.ClassificationChoice ||
                    ClassificationChoice != null &&
                    ClassificationChoice.Equals(other.ClassificationChoice)
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
                    if (RemoteSupportServers != null)
                    hashCode = hashCode * 59 + RemoteSupportServers.GetHashCode();
                    if (IsSupportAssistLicenseAccepted != null)
                    hashCode = hashCode * 59 + IsSupportAssistLicenseAccepted.GetHashCode();
                    if (IsCloudiqEnabled != null)
                    hashCode = hashCode * 59 + IsCloudiqEnabled.GetHashCode();
                    if (IsRscEnabled != null)
                    hashCode = hashCode * 59 + IsRscEnabled.GetHashCode();
                    if (ProxyAddress != null)
                    hashCode = hashCode * 59 + ProxyAddress.GetHashCode();
                    if (ProxyPort != null)
                    hashCode = hashCode * 59 + ProxyPort.GetHashCode();
                    if (ProxyUsername != null)
                    hashCode = hashCode * 59 + ProxyUsername.GetHashCode();
                    if (ProxyPassword != null)
                    hashCode = hashCode * 59 + ProxyPassword.GetHashCode();
                    if (IsSoftwareAutodownloadEnabled != null)
                    hashCode = hashCode * 59 + IsSoftwareAutodownloadEnabled.GetHashCode();
                    if (ClassificationChoice != null)
                    hashCode = hashCode * 59 + ClassificationChoice.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(RemoteSupportModify left, RemoteSupportModify right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(RemoteSupportModify left, RemoteSupportModify right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
