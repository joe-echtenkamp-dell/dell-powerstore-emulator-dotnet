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
    /// This resource type has queriable associations from appliance, ip_pool_address, veth_port
    /// </summary>
    [DataContract]
    public partial class NodeInstance : IEquatable<NodeInstance>
    { 
        /// <summary>
        /// Unique identifier of the node.
        /// </summary>
        /// <value>Unique identifier of the node.</value>

        [DataMember(Name="id")]
        public string Id { get; set; }

        /// <summary>
        /// Slot number of the node.
        /// </summary>
        /// <value>Slot number of the node.</value>

        [Range(0, 2147483647)]
        [DataMember(Name="slot")]
        public int? Slot { get; set; }

        /// <summary>
        /// Unique identifier of the appliance to which the node belongs.
        /// </summary>
        /// <value>Unique identifier of the appliance to which the node belongs.</value>

        [DataMember(Name="appliance_id")]
        public string ApplianceId { get; set; }

        /// <summary>
        /// This is the embeddable reference form of appliance_id attribute.
        /// </summary>
        /// <value>This is the embeddable reference form of appliance_id attribute.</value>

        [DataMember(Name="appliance")]
        public ApplianceInstance Appliance { get; set; }

        /// <summary>
        /// This is the inverse of the resource type ip_pool_address association.
        /// </summary>
        /// <value>This is the inverse of the resource type ip_pool_address association.</value>

        [DataMember(Name="ip_pool_addresses")]
        public List<IpPoolAddressInstance> IpPoolAddresses { get; set; }

        /// <summary>
        /// This is the inverse of the resource type veth_port association.
        /// </summary>
        /// <value>This is the inverse of the resource type veth_port association.</value>

        [DataMember(Name="veth_ports")]
        public List<VethPortInstance> VethPorts { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NodeInstance {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Slot: ").Append(Slot).Append("\n");
            sb.Append("  ApplianceId: ").Append(ApplianceId).Append("\n");
            sb.Append("  Appliance: ").Append(Appliance).Append("\n");
            sb.Append("  IpPoolAddresses: ").Append(IpPoolAddresses).Append("\n");
            sb.Append("  VethPorts: ").Append(VethPorts).Append("\n");
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
            return obj.GetType() == GetType() && Equals((NodeInstance)obj);
        }

        /// <summary>
        /// Returns true if NodeInstance instances are equal
        /// </summary>
        /// <param name="other">Instance of NodeInstance to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NodeInstance other)
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
                    Slot == other.Slot ||
                    Slot != null &&
                    Slot.Equals(other.Slot)
                ) && 
                (
                    ApplianceId == other.ApplianceId ||
                    ApplianceId != null &&
                    ApplianceId.Equals(other.ApplianceId)
                ) && 
                (
                    Appliance == other.Appliance ||
                    Appliance != null &&
                    Appliance.Equals(other.Appliance)
                ) && 
                (
                    IpPoolAddresses == other.IpPoolAddresses ||
                    IpPoolAddresses != null &&
                    IpPoolAddresses.SequenceEqual(other.IpPoolAddresses)
                ) && 
                (
                    VethPorts == other.VethPorts ||
                    VethPorts != null &&
                    VethPorts.SequenceEqual(other.VethPorts)
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
                    if (Slot != null)
                    hashCode = hashCode * 59 + Slot.GetHashCode();
                    if (ApplianceId != null)
                    hashCode = hashCode * 59 + ApplianceId.GetHashCode();
                    if (Appliance != null)
                    hashCode = hashCode * 59 + Appliance.GetHashCode();
                    if (IpPoolAddresses != null)
                    hashCode = hashCode * 59 + IpPoolAddresses.GetHashCode();
                    if (VethPorts != null)
                    hashCode = hashCode * 59 + VethPorts.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(NodeInstance left, NodeInstance right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(NodeInstance left, NodeInstance right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
