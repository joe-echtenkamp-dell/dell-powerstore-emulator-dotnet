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
    /// The SMB server configuration for File Import NAS server. Was added in version 3.0.0.0.  Filtering on the fields of this embedded resource is not supported.
    /// </summary>
    [DataContract]
    public partial class FileImportSmbConfiguration : IEquatable<FileImportSmbConfiguration>
    { 
        /// <summary>
        /// Indicates whether the source SMB server is standalone. A &#39;true&#39; value indicated the SMB server is standalone and &#39;false&#39; value indicates the SMB server is joined to an Active Directory. 
        /// </summary>
        /// <value>Indicates whether the source SMB server is standalone. A &#39;true&#39; value indicated the SMB server is standalone and &#39;false&#39; value indicates the SMB server is joined to an Active Directory. </value>

        [DataMember(Name="is_standalone")]
        public bool? IsStandalone { get; set; }

        /// <summary>
        /// DNS name of the associated computer account when the source SMB server is joined to an Active Directory domain. 
        /// </summary>
        /// <value>DNS name of the associated computer account when the source SMB server is joined to an Active Directory domain. </value>

        [StringLength(63, MinimumLength=1)]
        [DataMember(Name="computer_name")]
        public string ComputerName { get; set; }

        /// <summary>
        /// Domain name where the source SMB server is registered in Active Directory, if applicable. 
        /// </summary>
        /// <value>Domain name where the source SMB server is registered in Active Directory, if applicable. </value>

        [StringLength(255, MinimumLength=1)]
        [DataMember(Name="domain")]
        public string Domain { get; set; }

        /// <summary>
        /// Organizational unit of the source SMB server in Active Directory, if applicable. 
        /// </summary>
        /// <value>Organizational unit of the source SMB server in Active Directory, if applicable. </value>

        [MinLength(1)]
        [DataMember(Name="organizational_unit")]
        public string OrganizationalUnit { get; set; }

        /// <summary>
        /// NetBIOS or network name of the standalone source SMB server. SMB server joined to Active Directory also has a NetBIOS Name, defaulted to the first 15 characters of the computer name attribute. Administrators can specify a custom NetBIOS name for a SMB server using this attribute. 
        /// </summary>
        /// <value>NetBIOS or network name of the standalone source SMB server. SMB server joined to Active Directory also has a NetBIOS Name, defaulted to the first 15 characters of the computer name attribute. Administrators can specify a custom NetBIOS name for a SMB server using this attribute. </value>

        [StringLength(15, MinimumLength=1)]
        [DataMember(Name="netbios_name")]
        public string NetbiosName { get; set; }

        /// <summary>
        /// Windows network workgroup for the source SMB server. This is applicable to stand-alone SMB servers only. 
        /// </summary>
        /// <value>Windows network workgroup for the source SMB server. This is applicable to stand-alone SMB servers only. </value>

        [StringLength(15, MinimumLength=1)]
        [DataMember(Name="workgroup")]
        public string Workgroup { get; set; }

        /// <summary>
        /// Description of the source SMB server.  Was deprecated in version 3.2.0.0.
        /// </summary>
        /// <value>Description of the source SMB server.  Was deprecated in version 3.2.0.0.</value>

        [DataMember(Name="description")]
        public string Description { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FileImportSmbConfiguration {\n");
            sb.Append("  IsStandalone: ").Append(IsStandalone).Append("\n");
            sb.Append("  ComputerName: ").Append(ComputerName).Append("\n");
            sb.Append("  Domain: ").Append(Domain).Append("\n");
            sb.Append("  OrganizationalUnit: ").Append(OrganizationalUnit).Append("\n");
            sb.Append("  NetbiosName: ").Append(NetbiosName).Append("\n");
            sb.Append("  Workgroup: ").Append(Workgroup).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
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
            return obj.GetType() == GetType() && Equals((FileImportSmbConfiguration)obj);
        }

        /// <summary>
        /// Returns true if FileImportSmbConfiguration instances are equal
        /// </summary>
        /// <param name="other">Instance of FileImportSmbConfiguration to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FileImportSmbConfiguration other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    IsStandalone == other.IsStandalone ||
                    IsStandalone != null &&
                    IsStandalone.Equals(other.IsStandalone)
                ) && 
                (
                    ComputerName == other.ComputerName ||
                    ComputerName != null &&
                    ComputerName.Equals(other.ComputerName)
                ) && 
                (
                    Domain == other.Domain ||
                    Domain != null &&
                    Domain.Equals(other.Domain)
                ) && 
                (
                    OrganizationalUnit == other.OrganizationalUnit ||
                    OrganizationalUnit != null &&
                    OrganizationalUnit.Equals(other.OrganizationalUnit)
                ) && 
                (
                    NetbiosName == other.NetbiosName ||
                    NetbiosName != null &&
                    NetbiosName.Equals(other.NetbiosName)
                ) && 
                (
                    Workgroup == other.Workgroup ||
                    Workgroup != null &&
                    Workgroup.Equals(other.Workgroup)
                ) && 
                (
                    Description == other.Description ||
                    Description != null &&
                    Description.Equals(other.Description)
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
                    if (IsStandalone != null)
                    hashCode = hashCode * 59 + IsStandalone.GetHashCode();
                    if (ComputerName != null)
                    hashCode = hashCode * 59 + ComputerName.GetHashCode();
                    if (Domain != null)
                    hashCode = hashCode * 59 + Domain.GetHashCode();
                    if (OrganizationalUnit != null)
                    hashCode = hashCode * 59 + OrganizationalUnit.GetHashCode();
                    if (NetbiosName != null)
                    hashCode = hashCode * 59 + NetbiosName.GetHashCode();
                    if (Workgroup != null)
                    hashCode = hashCode * 59 + Workgroup.GetHashCode();
                    if (Description != null)
                    hashCode = hashCode * 59 + Description.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(FileImportSmbConfiguration left, FileImportSmbConfiguration right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(FileImportSmbConfiguration left, FileImportSmbConfiguration right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
