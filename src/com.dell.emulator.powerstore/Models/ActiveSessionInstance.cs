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
    /// Properties of an active session.
    /// </summary>
    [DataContract]
    public partial class ActiveSessionInstance : IEquatable<ActiveSessionInstance>
    { 
        /// <summary>
        /// IQN or WWN of the target port that the initiator is logged into.
        /// </summary>
        /// <value>IQN or WWN of the target port that the initiator is logged into.</value>

        [DataMember(Name="port_name")]
        public string PortName { get; set; }

        /// <summary>
        /// Unique identifier of the appliance containing the session.
        /// </summary>
        /// <value>Unique identifier of the appliance containing the session.</value>

        [DataMember(Name="appliance_id")]
        public string ApplianceId { get; set; }

        /// <summary>
        /// Unique identifier of node on the appliance on which active session is created. 
        /// </summary>
        /// <value>Unique identifier of node on the appliance on which active session is created. </value>

        [DataMember(Name="node_id")]
        public string NodeId { get; set; }

        /// <summary>
        /// Unique identifier of the bond the initiator is logged into.  Null if one of the following is non-null: veth_id, eth_port_id or fc_port_id. 
        /// </summary>
        /// <value>Unique identifier of the bond the initiator is logged into.  Null if one of the following is non-null: veth_id, eth_port_id or fc_port_id. </value>

        [DataMember(Name="bond_id")]
        public string BondId { get; set; }

        /// <summary>
        /// Unique identifier of the FC port the initiator is logged into.  Null if one of the following is non-null: bond_id, veth_id or eth_port_id 
        /// </summary>
        /// <value>Unique identifier of the FC port the initiator is logged into.  Null if one of the following is non-null: bond_id, veth_id or eth_port_id </value>

        [DataMember(Name="fc_port_id")]
        public string FcPortId { get; set; }

        /// <summary>
        /// Unique identifier of the virtual Ethernet port the initiator is logged into.  Null if one of the following is non-null: bond, eth_port_id or fc_port_id. 
        /// </summary>
        /// <value>Unique identifier of the virtual Ethernet port the initiator is logged into.  Null if one of the following is non-null: bond, eth_port_id or fc_port_id. </value>

        [DataMember(Name="veth_id")]
        public string VethId { get; set; }

        /// <summary>
        /// Unique identifier of the Ethernet port the initiator is logged into. Null if one of the following is non-null: bond_id, veth_id or fc_port_id. 
        /// </summary>
        /// <value>Unique identifier of the Ethernet port the initiator is logged into. Null if one of the following is non-null: bond_id, veth_id or fc_port_id. </value>

        [DataMember(Name="eth_port_id")]
        public string EthPortId { get; set; }

        /// <summary>
        /// List of addresses of the NVMe/NVMe-vVol initiator. These can either be the IPs of the endpoints for NVMe over TCP, or they can be the WWNs if using NVMe over FC. It may be that the same NQN will be applied to multiple WWNs or IP addresses, since NQNs are unique per host sub-system, and not unique per port. This field is null for FC(SCSI) and iSCSI initiators.  Was added in version 3.0.0.0.
        /// </summary>
        /// <value>List of addresses of the NVMe/NVMe-vVol initiator. These can either be the IPs of the endpoints for NVMe over TCP, or they can be the WWNs if using NVMe over FC. It may be that the same NQN will be applied to multiple WWNs or IP addresses, since NQNs are unique per host sub-system, and not unique per port. This field is null for FC(SCSI) and iSCSI initiators.  Was added in version 3.0.0.0.</value>

        [DataMember(Name="nvme_transport_addresses")]
        public List<string> NvmeTransportAddresses { get; set; }

        /// <summary>
        ///  Was added in version 3.0.0.0.
        /// </summary>
        /// <value> Was added in version 3.0.0.0.</value>

        [DataMember(Name="nvme_transport_type")]
        public NvmeTransportTypeEnum? NvmeTransportType { get; set; }

        /// <summary>
        /// Localized message string corresponding to nvme_transport_type Was added in version 3.0.0.0.
        /// </summary>
        /// <value>Localized message string corresponding to nvme_transport_type Was added in version 3.0.0.0.</value>

        [DataMember(Name="nvme_transport_type_l10n")]
        public string NvmeTransportTypeL10n { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ActiveSessionInstance {\n");
            sb.Append("  PortName: ").Append(PortName).Append("\n");
            sb.Append("  ApplianceId: ").Append(ApplianceId).Append("\n");
            sb.Append("  NodeId: ").Append(NodeId).Append("\n");
            sb.Append("  BondId: ").Append(BondId).Append("\n");
            sb.Append("  FcPortId: ").Append(FcPortId).Append("\n");
            sb.Append("  VethId: ").Append(VethId).Append("\n");
            sb.Append("  EthPortId: ").Append(EthPortId).Append("\n");
            sb.Append("  NvmeTransportAddresses: ").Append(NvmeTransportAddresses).Append("\n");
            sb.Append("  NvmeTransportType: ").Append(NvmeTransportType).Append("\n");
            sb.Append("  NvmeTransportTypeL10n: ").Append(NvmeTransportTypeL10n).Append("\n");
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
            return obj.GetType() == GetType() && Equals((ActiveSessionInstance)obj);
        }

        /// <summary>
        /// Returns true if ActiveSessionInstance instances are equal
        /// </summary>
        /// <param name="other">Instance of ActiveSessionInstance to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ActiveSessionInstance other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    PortName == other.PortName ||
                    PortName != null &&
                    PortName.Equals(other.PortName)
                ) && 
                (
                    ApplianceId == other.ApplianceId ||
                    ApplianceId != null &&
                    ApplianceId.Equals(other.ApplianceId)
                ) && 
                (
                    NodeId == other.NodeId ||
                    NodeId != null &&
                    NodeId.Equals(other.NodeId)
                ) && 
                (
                    BondId == other.BondId ||
                    BondId != null &&
                    BondId.Equals(other.BondId)
                ) && 
                (
                    FcPortId == other.FcPortId ||
                    FcPortId != null &&
                    FcPortId.Equals(other.FcPortId)
                ) && 
                (
                    VethId == other.VethId ||
                    VethId != null &&
                    VethId.Equals(other.VethId)
                ) && 
                (
                    EthPortId == other.EthPortId ||
                    EthPortId != null &&
                    EthPortId.Equals(other.EthPortId)
                ) && 
                (
                    NvmeTransportAddresses == other.NvmeTransportAddresses ||
                    NvmeTransportAddresses != null &&
                    NvmeTransportAddresses.SequenceEqual(other.NvmeTransportAddresses)
                ) && 
                (
                    NvmeTransportType == other.NvmeTransportType ||
                    NvmeTransportType != null &&
                    NvmeTransportType.Equals(other.NvmeTransportType)
                ) && 
                (
                    NvmeTransportTypeL10n == other.NvmeTransportTypeL10n ||
                    NvmeTransportTypeL10n != null &&
                    NvmeTransportTypeL10n.Equals(other.NvmeTransportTypeL10n)
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
                    if (PortName != null)
                    hashCode = hashCode * 59 + PortName.GetHashCode();
                    if (ApplianceId != null)
                    hashCode = hashCode * 59 + ApplianceId.GetHashCode();
                    if (NodeId != null)
                    hashCode = hashCode * 59 + NodeId.GetHashCode();
                    if (BondId != null)
                    hashCode = hashCode * 59 + BondId.GetHashCode();
                    if (FcPortId != null)
                    hashCode = hashCode * 59 + FcPortId.GetHashCode();
                    if (VethId != null)
                    hashCode = hashCode * 59 + VethId.GetHashCode();
                    if (EthPortId != null)
                    hashCode = hashCode * 59 + EthPortId.GetHashCode();
                    if (NvmeTransportAddresses != null)
                    hashCode = hashCode * 59 + NvmeTransportAddresses.GetHashCode();
                    if (NvmeTransportType != null)
                    hashCode = hashCode * 59 + NvmeTransportType.GetHashCode();
                    if (NvmeTransportTypeL10n != null)
                    hashCode = hashCode * 59 + NvmeTransportTypeL10n.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(ActiveSessionInstance left, ActiveSessionInstance right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(ActiveSessionInstance left, ActiveSessionInstance right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
