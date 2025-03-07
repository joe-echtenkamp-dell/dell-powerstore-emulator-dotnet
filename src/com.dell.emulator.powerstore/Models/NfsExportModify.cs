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
    public partial class NfsExportModify : IEquatable<NfsExportModify>
    { 
        /// <summary>
        /// NFS Export description.
        /// </summary>
        /// <value>NFS Export description.</value>

        [StringLength(511, MinimumLength=0)]
        [DataMember(Name="description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets DefaultAccess
        /// </summary>

        [DataMember(Name="default_access")]
        public NFSExportDefaultAccessEnum? DefaultAccess { get; set; }

        /// <summary>
        /// Gets or Sets MinSecurity
        /// </summary>

        [DataMember(Name="min_security")]
        public NFSExportMinSecurityEnum? MinSecurity { get; set; }

        /// <summary>
        /// Hosts with no access to the NFS export or its snapshots. Hosts can be entered by Hostname, IP addresses (IPv4, IPv6, IPv4/PrefixLength, IPv6/PrefixLenght, or IPv4/subnetmask), or Netgroups prefixed with @. The maximum length of an Host name is 255 bytes, and the sum of lengths of all the items in the list is limited to 4096 bytes.
        /// </summary>
        /// <value>Hosts with no access to the NFS export or its snapshots. Hosts can be entered by Hostname, IP addresses (IPv4, IPv6, IPv4/PrefixLength, IPv6/PrefixLenght, or IPv4/subnetmask), or Netgroups prefixed with @. The maximum length of an Host name is 255 bytes, and the sum of lengths of all the items in the list is limited to 4096 bytes.</value>

        [DataMember(Name="no_access_hosts")]
        public List<string> NoAccessHosts { get; set; }

        /// <summary>
        /// Hosts to add to the no_access_host list. Hosts can be entered by Hostname, IP addresses (IPv4, IPv6, IPv4/PrefixLength, IPv6/PrefixLenght, or IPv4/subnetmask), or Netgroups prefixed with @. Error if the host already exists in the list. Cannot be combined with no_access_hosts. The maximum length of an Host name is 255 bytes, and the sum of lengths of all the items in the list is limited to 4096 bytes.
        /// </summary>
        /// <value>Hosts to add to the no_access_host list. Hosts can be entered by Hostname, IP addresses (IPv4, IPv6, IPv4/PrefixLength, IPv6/PrefixLenght, or IPv4/subnetmask), or Netgroups prefixed with @. Error if the host already exists in the list. Cannot be combined with no_access_hosts. The maximum length of an Host name is 255 bytes, and the sum of lengths of all the items in the list is limited to 4096 bytes.</value>

        [DataMember(Name="add_no_access_hosts")]
        public List<string> AddNoAccessHosts { get; set; }

        /// <summary>
        /// Hosts to remove from the current no_access_hosts list. Hosts can be entered by Hostname, IP addresses (IPv4, IPv6, IPv4/PrefixLength, IPv6/PrefixLenght, or IPv4/subnetmask), or Netgroups prefixed with @. Error if the host is not present. Cannot combine with no_access_hosts.
        /// </summary>
        /// <value>Hosts to remove from the current no_access_hosts list. Hosts can be entered by Hostname, IP addresses (IPv4, IPv6, IPv4/PrefixLength, IPv6/PrefixLenght, or IPv4/subnetmask), or Netgroups prefixed with @. Error if the host is not present. Cannot combine with no_access_hosts.</value>

        [DataMember(Name="remove_no_access_hosts")]
        public List<string> RemoveNoAccessHosts { get; set; }

        /// <summary>
        /// Hosts with read-only access to the NFS export and its snapshots. Hosts can be entered by Hostname, IP addresses (IPv4, IPv6, IPv4/PrefixLength, IPv6/PrefixLenght, or IPv4/subnetmask), or Netgroups prefixed with @. The maximum length of an Host name is 255 bytes, and the sum of lengths of all the items in the list is limited to 4096 bytes.
        /// </summary>
        /// <value>Hosts with read-only access to the NFS export and its snapshots. Hosts can be entered by Hostname, IP addresses (IPv4, IPv6, IPv4/PrefixLength, IPv6/PrefixLenght, or IPv4/subnetmask), or Netgroups prefixed with @. The maximum length of an Host name is 255 bytes, and the sum of lengths of all the items in the list is limited to 4096 bytes.</value>

        [DataMember(Name="read_only_hosts")]
        public List<string> ReadOnlyHosts { get; set; }

        /// <summary>
        /// Hosts to add to the current read_only_hosts list. Hosts can be entered by Hostname, IP addresses (IPv4, IPv6, IPv4/PrefixLength, IPv6/PrefixLenght, or IPv4/subnetmask), or Netgroups prefixed with @. Error if the host already exists. Cannot combine with read_only_hosts. The maximum length of an Host name is 255 bytes, and the sum of lengths of all the items in the list is limited to 4096 bytes.
        /// </summary>
        /// <value>Hosts to add to the current read_only_hosts list. Hosts can be entered by Hostname, IP addresses (IPv4, IPv6, IPv4/PrefixLength, IPv6/PrefixLenght, or IPv4/subnetmask), or Netgroups prefixed with @. Error if the host already exists. Cannot combine with read_only_hosts. The maximum length of an Host name is 255 bytes, and the sum of lengths of all the items in the list is limited to 4096 bytes.</value>

        [DataMember(Name="add_read_only_hosts")]
        public List<string> AddReadOnlyHosts { get; set; }

        /// <summary>
        /// Hosts to remove from the current read_only_hosts list. Hosts can be entered by Hostname, IP addresses (IPv4, IPv6, IPv4/PrefixLength, IPv6/PrefixLenght, or IPv4/subnetmask), or Netgroups prefixed with @. Error if the host is not present. Cannot combine with read_only_hosts.
        /// </summary>
        /// <value>Hosts to remove from the current read_only_hosts list. Hosts can be entered by Hostname, IP addresses (IPv4, IPv6, IPv4/PrefixLength, IPv6/PrefixLenght, or IPv4/subnetmask), or Netgroups prefixed with @. Error if the host is not present. Cannot combine with read_only_hosts.</value>

        [DataMember(Name="remove_read_only_hosts")]
        public List<string> RemoveReadOnlyHosts { get; set; }

        /// <summary>
        /// Hosts with read-only and ready-only for root user access to the NFS Export and its snapshots. Hosts can be entered by Hostname, IP addresses (IPv4, IPv6, IPv4/PrefixLength, IPv6/PrefixLenght, or IPv4/subnetmask), Netgroups prefixed with @. The maximum length of an Host name is 255 bytes, and the sum of lengths of all the items in the list is limited to 4096 bytes.
        /// </summary>
        /// <value>Hosts with read-only and ready-only for root user access to the NFS Export and its snapshots. Hosts can be entered by Hostname, IP addresses (IPv4, IPv6, IPv4/PrefixLength, IPv6/PrefixLenght, or IPv4/subnetmask), Netgroups prefixed with @. The maximum length of an Host name is 255 bytes, and the sum of lengths of all the items in the list is limited to 4096 bytes.</value>

        [DataMember(Name="read_only_root_hosts")]
        public List<string> ReadOnlyRootHosts { get; set; }

        /// <summary>
        /// Hosts to add to the current read_only_root_hosts list. Hosts can be entered by Hostname, IP addresses (IPv4, IPv6, IPv4/PrefixLength, IPv6/PrefixLenght, or IPv4/subnetmask), or Netgroups prefixed with @. Error if the host already exists. Cannot combine with read_only_root_hosts. The maximum length of an Host name is 255 bytes, and the sum of lengths of all the items in the list is limited to 4096 bytes.
        /// </summary>
        /// <value>Hosts to add to the current read_only_root_hosts list. Hosts can be entered by Hostname, IP addresses (IPv4, IPv6, IPv4/PrefixLength, IPv6/PrefixLenght, or IPv4/subnetmask), or Netgroups prefixed with @. Error if the host already exists. Cannot combine with read_only_root_hosts. The maximum length of an Host name is 255 bytes, and the sum of lengths of all the items in the list is limited to 4096 bytes.</value>

        [DataMember(Name="add_read_only_root_hosts")]
        public List<string> AddReadOnlyRootHosts { get; set; }

        /// <summary>
        /// Hosts to remove from the current read_only_root_hosts list. Hosts can be entered by Hostname, IP addresses (IPv4, IPv6, IPv4/PrefixLength, IPv6/PrefixLenght, or IPv4/subnetmask), or Netgroups prefixed with @. Error if The host is not present. Cannot combine with read_only_root_hosts.
        /// </summary>
        /// <value>Hosts to remove from the current read_only_root_hosts list. Hosts can be entered by Hostname, IP addresses (IPv4, IPv6, IPv4/PrefixLength, IPv6/PrefixLenght, or IPv4/subnetmask), or Netgroups prefixed with @. Error if The host is not present. Cannot combine with read_only_root_hosts.</value>

        [DataMember(Name="remove_read_only_root_hosts")]
        public List<string> RemoveReadOnlyRootHosts { get; set; }

        /// <summary>
        /// Hosts with read and write access to the NFS export and its snapshots. Hosts can be entered by Hostname, IP addresses (IPv4, IPv6, IPv4/PrefixLength, IPv6/PrefixLenght, or IPv4/subnetmask) or, Netgroups prefixed with @. The maximum length of an Host name is 255 bytes, and the sum of lengths of all the items in the list is limited to 4096 bytes.
        /// </summary>
        /// <value>Hosts with read and write access to the NFS export and its snapshots. Hosts can be entered by Hostname, IP addresses (IPv4, IPv6, IPv4/PrefixLength, IPv6/PrefixLenght, or IPv4/subnetmask) or, Netgroups prefixed with @. The maximum length of an Host name is 255 bytes, and the sum of lengths of all the items in the list is limited to 4096 bytes.</value>

        [DataMember(Name="read_write_hosts")]
        public List<string> ReadWriteHosts { get; set; }

        /// <summary>
        /// Hosts to add to the current read_write_hosts list. Hosts can be entered by Hostname, IP addresses (IPv4, IPv6, IPv4/PrefixLength, IPv6/PrefixLenght, or IPv4/subnetmask), or Netgroups prefixed with @. Error if Host is already exists. Cannot combine with read_write_hosts. The maximum length of an Host name is 255 bytes, and the sum of lengths of all the items in the list is limited to 4096 bytes.
        /// </summary>
        /// <value>Hosts to add to the current read_write_hosts list. Hosts can be entered by Hostname, IP addresses (IPv4, IPv6, IPv4/PrefixLength, IPv6/PrefixLenght, or IPv4/subnetmask), or Netgroups prefixed with @. Error if Host is already exists. Cannot combine with read_write_hosts. The maximum length of an Host name is 255 bytes, and the sum of lengths of all the items in the list is limited to 4096 bytes.</value>

        [DataMember(Name="add_read_write_hosts")]
        public List<string> AddReadWriteHosts { get; set; }

        /// <summary>
        /// Hosts to remove from the current read_write_hosts list. Hosts can be entered by Hostname, IP addresses (IPv4, IPv6, IPv4/PrefixLength, IPv6/PrefixLenght, or IPv4/subnetmask), or Netgroups prefixed with @. Error if Host is not present. Cannot combine with read_write_hosts.
        /// </summary>
        /// <value>Hosts to remove from the current read_write_hosts list. Hosts can be entered by Hostname, IP addresses (IPv4, IPv6, IPv4/PrefixLength, IPv6/PrefixLenght, or IPv4/subnetmask), or Netgroups prefixed with @. Error if Host is not present. Cannot combine with read_write_hosts.</value>

        [DataMember(Name="remove_read_write_hosts")]
        public List<string> RemoveReadWriteHosts { get; set; }

        /// <summary>
        /// Hosts with read and write and read and write for root user access to the NFS Export and its snapshots. Hosts can be entered by Hostname, IP addresses (IPv4, IPv6, IPv4/PrefixLength, IPv6/PrefixLenght, or IPv4/subnetmask), or Netgroups prefixed with @. The maximum length of an Host name is 255 bytes, and the sum of lengths of all the items in the list is limited to 4096 bytes.
        /// </summary>
        /// <value>Hosts with read and write and read and write for root user access to the NFS Export and its snapshots. Hosts can be entered by Hostname, IP addresses (IPv4, IPv6, IPv4/PrefixLength, IPv6/PrefixLenght, or IPv4/subnetmask), or Netgroups prefixed with @. The maximum length of an Host name is 255 bytes, and the sum of lengths of all the items in the list is limited to 4096 bytes.</value>

        [DataMember(Name="read_write_root_hosts")]
        public List<string> ReadWriteRootHosts { get; set; }

        /// <summary>
        /// Hosts to add to the current read_write_root_hosts list. Hosts can be entered by Hostname, IP addresses (IPv4, IPv6, IPv4/PrefixLength, IPv6/PrefixLenght, or IPv4/subnetmask), or Netgroups prefixed with @. Error if the host already exists. Cannot combine with read_write_root_hosts. The maximum length of an Host name is 255 bytes, and the sum of lengths of all the items in the list is limited to 4096 bytes.
        /// </summary>
        /// <value>Hosts to add to the current read_write_root_hosts list. Hosts can be entered by Hostname, IP addresses (IPv4, IPv6, IPv4/PrefixLength, IPv6/PrefixLenght, or IPv4/subnetmask), or Netgroups prefixed with @. Error if the host already exists. Cannot combine with read_write_root_hosts. The maximum length of an Host name is 255 bytes, and the sum of lengths of all the items in the list is limited to 4096 bytes.</value>

        [DataMember(Name="add_read_write_root_hosts")]
        public List<string> AddReadWriteRootHosts { get; set; }

        /// <summary>
        /// Hosts to remove from the current read_write_root_hosts list. Hosts can be entered by Hostname, IP addresses (IPv4, IPv6, IPv4/PrefixLength, IPv6/PrefixLenght, or IPv4/subnetmask), or Netgroups prefixed with @. Error if the host is not present. Cannot combine with read_write_root_hosts.
        /// </summary>
        /// <value>Hosts to remove from the current read_write_root_hosts list. Hosts can be entered by Hostname, IP addresses (IPv4, IPv6, IPv4/PrefixLength, IPv6/PrefixLenght, or IPv4/subnetmask), or Netgroups prefixed with @. Error if the host is not present. Cannot combine with read_write_root_hosts.</value>

        [DataMember(Name="remove_read_write_root_hosts")]
        public List<string> RemoveReadWriteRootHosts { get; set; }

        /// <summary>
        /// Specifies the user ID of the anonymous account.
        /// </summary>
        /// <value>Specifies the user ID of the anonymous account.</value>

        [Range(-2147483648, 2147483647)]
        [DataMember(Name="anonymous_UID")]
        public int? AnonymousUID { get; set; }

        /// <summary>
        /// Specifies the group ID of the anonymous account.
        /// </summary>
        /// <value>Specifies the group ID of the anonymous account.</value>

        [Range(-2147483648, 2147483647)]
        [DataMember(Name="anonymous_GID")]
        public int? AnonymousGID { get; set; }

        /// <summary>
        /// If set, do not allow access to set SUID. Otherwise, allow access.
        /// </summary>
        /// <value>If set, do not allow access to set SUID. Otherwise, allow access.</value>

        [DataMember(Name="is_no_SUID")]
        public bool? IsNoSUID { get; set; }

        /// <summary>
        /// (*Applies to NFS shares of VMware NFS storage resources.*) Default owner of the NFS Export associated with the datastore. Required if secure NFS enabled. For NFSv3 or NFSv4 without Kerberos, the default owner is root. Was added in version 3.0.0.0.
        /// </summary>
        /// <value>(*Applies to NFS shares of VMware NFS storage resources.*) Default owner of the NFS Export associated with the datastore. Required if secure NFS enabled. For NFSv3 or NFSv4 without Kerberos, the default owner is root. Was added in version 3.0.0.0.</value>

        [StringLength(32, MinimumLength=0)]
        [DataMember(Name="nfs_owner_username")]
        public string NfsOwnerUsername { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NfsExportModify {\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  DefaultAccess: ").Append(DefaultAccess).Append("\n");
            sb.Append("  MinSecurity: ").Append(MinSecurity).Append("\n");
            sb.Append("  NoAccessHosts: ").Append(NoAccessHosts).Append("\n");
            sb.Append("  AddNoAccessHosts: ").Append(AddNoAccessHosts).Append("\n");
            sb.Append("  RemoveNoAccessHosts: ").Append(RemoveNoAccessHosts).Append("\n");
            sb.Append("  ReadOnlyHosts: ").Append(ReadOnlyHosts).Append("\n");
            sb.Append("  AddReadOnlyHosts: ").Append(AddReadOnlyHosts).Append("\n");
            sb.Append("  RemoveReadOnlyHosts: ").Append(RemoveReadOnlyHosts).Append("\n");
            sb.Append("  ReadOnlyRootHosts: ").Append(ReadOnlyRootHosts).Append("\n");
            sb.Append("  AddReadOnlyRootHosts: ").Append(AddReadOnlyRootHosts).Append("\n");
            sb.Append("  RemoveReadOnlyRootHosts: ").Append(RemoveReadOnlyRootHosts).Append("\n");
            sb.Append("  ReadWriteHosts: ").Append(ReadWriteHosts).Append("\n");
            sb.Append("  AddReadWriteHosts: ").Append(AddReadWriteHosts).Append("\n");
            sb.Append("  RemoveReadWriteHosts: ").Append(RemoveReadWriteHosts).Append("\n");
            sb.Append("  ReadWriteRootHosts: ").Append(ReadWriteRootHosts).Append("\n");
            sb.Append("  AddReadWriteRootHosts: ").Append(AddReadWriteRootHosts).Append("\n");
            sb.Append("  RemoveReadWriteRootHosts: ").Append(RemoveReadWriteRootHosts).Append("\n");
            sb.Append("  AnonymousUID: ").Append(AnonymousUID).Append("\n");
            sb.Append("  AnonymousGID: ").Append(AnonymousGID).Append("\n");
            sb.Append("  IsNoSUID: ").Append(IsNoSUID).Append("\n");
            sb.Append("  NfsOwnerUsername: ").Append(NfsOwnerUsername).Append("\n");
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
            return obj.GetType() == GetType() && Equals((NfsExportModify)obj);
        }

        /// <summary>
        /// Returns true if NfsExportModify instances are equal
        /// </summary>
        /// <param name="other">Instance of NfsExportModify to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NfsExportModify other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Description == other.Description ||
                    Description != null &&
                    Description.Equals(other.Description)
                ) && 
                (
                    DefaultAccess == other.DefaultAccess ||
                    DefaultAccess != null &&
                    DefaultAccess.Equals(other.DefaultAccess)
                ) && 
                (
                    MinSecurity == other.MinSecurity ||
                    MinSecurity != null &&
                    MinSecurity.Equals(other.MinSecurity)
                ) && 
                (
                    NoAccessHosts == other.NoAccessHosts ||
                    NoAccessHosts != null &&
                    NoAccessHosts.SequenceEqual(other.NoAccessHosts)
                ) && 
                (
                    AddNoAccessHosts == other.AddNoAccessHosts ||
                    AddNoAccessHosts != null &&
                    AddNoAccessHosts.SequenceEqual(other.AddNoAccessHosts)
                ) && 
                (
                    RemoveNoAccessHosts == other.RemoveNoAccessHosts ||
                    RemoveNoAccessHosts != null &&
                    RemoveNoAccessHosts.SequenceEqual(other.RemoveNoAccessHosts)
                ) && 
                (
                    ReadOnlyHosts == other.ReadOnlyHosts ||
                    ReadOnlyHosts != null &&
                    ReadOnlyHosts.SequenceEqual(other.ReadOnlyHosts)
                ) && 
                (
                    AddReadOnlyHosts == other.AddReadOnlyHosts ||
                    AddReadOnlyHosts != null &&
                    AddReadOnlyHosts.SequenceEqual(other.AddReadOnlyHosts)
                ) && 
                (
                    RemoveReadOnlyHosts == other.RemoveReadOnlyHosts ||
                    RemoveReadOnlyHosts != null &&
                    RemoveReadOnlyHosts.SequenceEqual(other.RemoveReadOnlyHosts)
                ) && 
                (
                    ReadOnlyRootHosts == other.ReadOnlyRootHosts ||
                    ReadOnlyRootHosts != null &&
                    ReadOnlyRootHosts.SequenceEqual(other.ReadOnlyRootHosts)
                ) && 
                (
                    AddReadOnlyRootHosts == other.AddReadOnlyRootHosts ||
                    AddReadOnlyRootHosts != null &&
                    AddReadOnlyRootHosts.SequenceEqual(other.AddReadOnlyRootHosts)
                ) && 
                (
                    RemoveReadOnlyRootHosts == other.RemoveReadOnlyRootHosts ||
                    RemoveReadOnlyRootHosts != null &&
                    RemoveReadOnlyRootHosts.SequenceEqual(other.RemoveReadOnlyRootHosts)
                ) && 
                (
                    ReadWriteHosts == other.ReadWriteHosts ||
                    ReadWriteHosts != null &&
                    ReadWriteHosts.SequenceEqual(other.ReadWriteHosts)
                ) && 
                (
                    AddReadWriteHosts == other.AddReadWriteHosts ||
                    AddReadWriteHosts != null &&
                    AddReadWriteHosts.SequenceEqual(other.AddReadWriteHosts)
                ) && 
                (
                    RemoveReadWriteHosts == other.RemoveReadWriteHosts ||
                    RemoveReadWriteHosts != null &&
                    RemoveReadWriteHosts.SequenceEqual(other.RemoveReadWriteHosts)
                ) && 
                (
                    ReadWriteRootHosts == other.ReadWriteRootHosts ||
                    ReadWriteRootHosts != null &&
                    ReadWriteRootHosts.SequenceEqual(other.ReadWriteRootHosts)
                ) && 
                (
                    AddReadWriteRootHosts == other.AddReadWriteRootHosts ||
                    AddReadWriteRootHosts != null &&
                    AddReadWriteRootHosts.SequenceEqual(other.AddReadWriteRootHosts)
                ) && 
                (
                    RemoveReadWriteRootHosts == other.RemoveReadWriteRootHosts ||
                    RemoveReadWriteRootHosts != null &&
                    RemoveReadWriteRootHosts.SequenceEqual(other.RemoveReadWriteRootHosts)
                ) && 
                (
                    AnonymousUID == other.AnonymousUID ||
                    AnonymousUID != null &&
                    AnonymousUID.Equals(other.AnonymousUID)
                ) && 
                (
                    AnonymousGID == other.AnonymousGID ||
                    AnonymousGID != null &&
                    AnonymousGID.Equals(other.AnonymousGID)
                ) && 
                (
                    IsNoSUID == other.IsNoSUID ||
                    IsNoSUID != null &&
                    IsNoSUID.Equals(other.IsNoSUID)
                ) && 
                (
                    NfsOwnerUsername == other.NfsOwnerUsername ||
                    NfsOwnerUsername != null &&
                    NfsOwnerUsername.Equals(other.NfsOwnerUsername)
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
                    if (Description != null)
                    hashCode = hashCode * 59 + Description.GetHashCode();
                    if (DefaultAccess != null)
                    hashCode = hashCode * 59 + DefaultAccess.GetHashCode();
                    if (MinSecurity != null)
                    hashCode = hashCode * 59 + MinSecurity.GetHashCode();
                    if (NoAccessHosts != null)
                    hashCode = hashCode * 59 + NoAccessHosts.GetHashCode();
                    if (AddNoAccessHosts != null)
                    hashCode = hashCode * 59 + AddNoAccessHosts.GetHashCode();
                    if (RemoveNoAccessHosts != null)
                    hashCode = hashCode * 59 + RemoveNoAccessHosts.GetHashCode();
                    if (ReadOnlyHosts != null)
                    hashCode = hashCode * 59 + ReadOnlyHosts.GetHashCode();
                    if (AddReadOnlyHosts != null)
                    hashCode = hashCode * 59 + AddReadOnlyHosts.GetHashCode();
                    if (RemoveReadOnlyHosts != null)
                    hashCode = hashCode * 59 + RemoveReadOnlyHosts.GetHashCode();
                    if (ReadOnlyRootHosts != null)
                    hashCode = hashCode * 59 + ReadOnlyRootHosts.GetHashCode();
                    if (AddReadOnlyRootHosts != null)
                    hashCode = hashCode * 59 + AddReadOnlyRootHosts.GetHashCode();
                    if (RemoveReadOnlyRootHosts != null)
                    hashCode = hashCode * 59 + RemoveReadOnlyRootHosts.GetHashCode();
                    if (ReadWriteHosts != null)
                    hashCode = hashCode * 59 + ReadWriteHosts.GetHashCode();
                    if (AddReadWriteHosts != null)
                    hashCode = hashCode * 59 + AddReadWriteHosts.GetHashCode();
                    if (RemoveReadWriteHosts != null)
                    hashCode = hashCode * 59 + RemoveReadWriteHosts.GetHashCode();
                    if (ReadWriteRootHosts != null)
                    hashCode = hashCode * 59 + ReadWriteRootHosts.GetHashCode();
                    if (AddReadWriteRootHosts != null)
                    hashCode = hashCode * 59 + AddReadWriteRootHosts.GetHashCode();
                    if (RemoveReadWriteRootHosts != null)
                    hashCode = hashCode * 59 + RemoveReadWriteRootHosts.GetHashCode();
                    if (AnonymousUID != null)
                    hashCode = hashCode * 59 + AnonymousUID.GetHashCode();
                    if (AnonymousGID != null)
                    hashCode = hashCode * 59 + AnonymousGID.GetHashCode();
                    if (IsNoSUID != null)
                    hashCode = hashCode * 59 + IsNoSUID.GetHashCode();
                    if (NfsOwnerUsername != null)
                    hashCode = hashCode * 59 + NfsOwnerUsername.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(NfsExportModify left, NfsExportModify right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(NfsExportModify left, NfsExportModify right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
