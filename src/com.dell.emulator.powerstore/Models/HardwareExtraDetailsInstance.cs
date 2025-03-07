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
    /// Additional hardware details that are specific to each hardware type.  Filtering on the fields of this embedded resource is not supported.
    /// </summary>
    [DataContract]
    public partial class HardwareExtraDetailsInstance : IEquatable<HardwareExtraDetailsInstance>
    { 
        /// <summary>
        /// CPU model name. Available on Node hardware type.
        /// </summary>
        /// <value>CPU model name. Available on Node hardware type.</value>

        [DataMember(Name="cpu_model")]
        public string CpuModel { get; set; }

        /// <summary>
        /// Total amount of physical memory in gigabytes. Available on the Node hardware type.
        /// </summary>
        /// <value>Total amount of physical memory in gigabytes. Available on the Node hardware type.</value>

        [Range(0, 2147483647)]
        [DataMember(Name="physical_memory_size_gb")]
        public int? PhysicalMemorySizeGb { get; set; }

        /// <summary>
        /// Total number of physical cores. Available on the Node hardware type.
        /// </summary>
        /// <value>Total number of physical cores. Available on the Node hardware type.</value>

        [Range(0, 2147483647)]
        [DataMember(Name="cpu_cores")]
        public int? CpuCores { get; set; }

        /// <summary>
        /// Total number of physical sockets. Available on the Node hardware type.
        /// </summary>
        /// <value>Total number of physical sockets. Available on the Node hardware type.</value>

        [Range(0, 2147483647)]
        [DataMember(Name="cpu_sockets")]
        public int? CpuSockets { get; set; }

        /// <summary>
        /// Bus number of the Expansion_Shelf. Available on the Expansion_Shelf hardware type.
        /// </summary>
        /// <value>Bus number of the Expansion_Shelf. Available on the Expansion_Shelf hardware type.</value>

        [Range(0, 2147483647)]
        [DataMember(Name="bus_number")]
        public int? BusNumber { get; set; }

        /// <summary>
        /// Enclosure number of the Expansion_Shelf. Available on the Expansion_Shelf hardware type.
        /// </summary>
        /// <value>Enclosure number of the Expansion_Shelf. Available on the Expansion_Shelf hardware type.</value>

        [Range(0, 2147483647)]
        [DataMember(Name="enclosure_number")]
        public int? EnclosureNumber { get; set; }

        /// <summary>
        /// Model name of the hardware.  Available on the IO_Module and M2_Drive hardware types.
        /// </summary>
        /// <value>Model name of the hardware.  Available on the IO_Module and M2_Drive hardware types.</value>

        [DataMember(Name="model_name")]
        public string ModelName { get; set; }

        /// <summary>
        /// rpm_reading. Was added in version 2.0.0.0.
        /// </summary>
        /// <value>rpm_reading. Was added in version 2.0.0.0.</value>

        [DataMember(Name="rpm_reading")]
        public string RpmReading { get; set; }

        /// <summary>
        /// Firmware version of the hardware. Available on the Drive hardware type.
        /// </summary>
        /// <value>Firmware version of the hardware. Available on the Drive hardware type.</value>

        [DataMember(Name="firmware_version")]
        public string FirmwareVersion { get; set; }

        /// <summary>
        /// Gets or Sets Mode
        /// </summary>

        [DataMember(Name="mode")]
        public HardwareSFPModeEnum? Mode { get; set; }

        /// <summary>
        /// Gets or Sets SupportedSpeeds
        /// </summary>

        [DataMember(Name="supported_speeds")]
        public List<HardwareSFPSpeedEnum> SupportedSpeeds { get; set; }

        /// <summary>
        /// Gets or Sets SupportedProtocol
        /// </summary>

        [DataMember(Name="supported_protocol")]
        public HardwareSFPSupportedProtocolEnum? SupportedProtocol { get; set; }

        /// <summary>
        /// Gets or Sets ConnectorType
        /// </summary>

        [DataMember(Name="connector_type")]
        public HardwareSFPConnectorTypeEnum? ConnectorType { get; set; }

        /// <summary>
        /// Gets or Sets DriveType
        /// </summary>

        [DataMember(Name="drive_type")]
        public HardwareDriveTypeEnum? DriveType { get; set; }

        /// <summary>
        /// Size of the drive in bytes. Available on the Drive hardware type.
        /// </summary>
        /// <value>Size of the drive in bytes. Available on the Drive hardware type.</value>

        [Range(0, -9223372036854775616)]
        [DataMember(Name="size")]
        public long? Size { get; set; }

        /// <summary>
        /// Gets or Sets EncryptionStatus
        /// </summary>

        [DataMember(Name="encryption_status")]
        public HardwareDriveEncryptionStatusEnum? EncryptionStatus { get; set; }

        /// <summary>
        /// Gets or Sets FipsStatus
        /// </summary>

        [DataMember(Name="fips_status")]
        public HardwareDriveFIPSStatusEnum? FipsStatus { get; set; }

        /// <summary>
        /// Dell service tag of the hardware. Available on the Base_Enclosure and Expansion_Enclosure hardware types.
        /// </summary>
        /// <value>Dell service tag of the hardware. Available on the Base_Enclosure and Expansion_Enclosure hardware types.</value>

        [DataMember(Name="dell_service_tag")]
        public string DellServiceTag { get; set; }

        /// <summary>
        /// Express service code of the hardware. Available on the Base_Enclosure and Expansion_Enclosure hardware types.
        /// </summary>
        /// <value>Express service code of the hardware. Available on the Base_Enclosure and Expansion_Enclosure hardware types.</value>

        [DataMember(Name="express_service_code")]
        public string ExpressServiceCode { get; set; }

        /// <summary>
        ///  Was added in version 3.0.0.0.
        /// </summary>
        /// <value> Was added in version 3.0.0.0.</value>

        [DataMember(Name="enclosure_model_description")]
        public HardwareEnclosureModelDescriptionEnum? EnclosureModelDescription { get; set; }

        /// <summary>
        ///  Was added in version 4.0.0.0.
        /// </summary>
        /// <value> Was added in version 4.0.0.0.</value>

        [DataMember(Name="storage_class")]
        public ApplianceStorageClassEnum? StorageClass { get; set; }

        /// <summary>
        /// Localized message string corresponding to mode
        /// </summary>
        /// <value>Localized message string corresponding to mode</value>

        [DataMember(Name="mode_l10n")]
        public string ModeL10n { get; set; }

        /// <summary>
        /// Localized message array corresponding to supported_speeds
        /// </summary>
        /// <value>Localized message array corresponding to supported_speeds</value>

        [DataMember(Name="supported_speeds_l10n")]
        public List<string> SupportedSpeedsL10n { get; set; }

        /// <summary>
        /// Localized message string corresponding to supported_protocol
        /// </summary>
        /// <value>Localized message string corresponding to supported_protocol</value>

        [DataMember(Name="supported_protocol_l10n")]
        public string SupportedProtocolL10n { get; set; }

        /// <summary>
        /// Localized message string corresponding to connector_type
        /// </summary>
        /// <value>Localized message string corresponding to connector_type</value>

        [DataMember(Name="connector_type_l10n")]
        public string ConnectorTypeL10n { get; set; }

        /// <summary>
        /// Localized message string corresponding to drive_type
        /// </summary>
        /// <value>Localized message string corresponding to drive_type</value>

        [DataMember(Name="drive_type_l10n")]
        public string DriveTypeL10n { get; set; }

        /// <summary>
        /// Localized message string corresponding to encryption_status
        /// </summary>
        /// <value>Localized message string corresponding to encryption_status</value>

        [DataMember(Name="encryption_status_l10n")]
        public string EncryptionStatusL10n { get; set; }

        /// <summary>
        /// Localized message string corresponding to fips_status
        /// </summary>
        /// <value>Localized message string corresponding to fips_status</value>

        [DataMember(Name="fips_status_l10n")]
        public string FipsStatusL10n { get; set; }

        /// <summary>
        /// Localized message string corresponding to enclosure_model_description Was added in version 3.0.0.0.
        /// </summary>
        /// <value>Localized message string corresponding to enclosure_model_description Was added in version 3.0.0.0.</value>

        [DataMember(Name="enclosure_model_description_l10n")]
        public string EnclosureModelDescriptionL10n { get; set; }

        /// <summary>
        /// Localized message string corresponding to storage_class Was added in version 4.0.0.0.
        /// </summary>
        /// <value>Localized message string corresponding to storage_class Was added in version 4.0.0.0.</value>

        [DataMember(Name="storage_class_l10n")]
        public string StorageClassL10n { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HardwareExtraDetailsInstance {\n");
            sb.Append("  CpuModel: ").Append(CpuModel).Append("\n");
            sb.Append("  PhysicalMemorySizeGb: ").Append(PhysicalMemorySizeGb).Append("\n");
            sb.Append("  CpuCores: ").Append(CpuCores).Append("\n");
            sb.Append("  CpuSockets: ").Append(CpuSockets).Append("\n");
            sb.Append("  BusNumber: ").Append(BusNumber).Append("\n");
            sb.Append("  EnclosureNumber: ").Append(EnclosureNumber).Append("\n");
            sb.Append("  ModelName: ").Append(ModelName).Append("\n");
            sb.Append("  RpmReading: ").Append(RpmReading).Append("\n");
            sb.Append("  FirmwareVersion: ").Append(FirmwareVersion).Append("\n");
            sb.Append("  Mode: ").Append(Mode).Append("\n");
            sb.Append("  SupportedSpeeds: ").Append(SupportedSpeeds).Append("\n");
            sb.Append("  SupportedProtocol: ").Append(SupportedProtocol).Append("\n");
            sb.Append("  ConnectorType: ").Append(ConnectorType).Append("\n");
            sb.Append("  DriveType: ").Append(DriveType).Append("\n");
            sb.Append("  Size: ").Append(Size).Append("\n");
            sb.Append("  EncryptionStatus: ").Append(EncryptionStatus).Append("\n");
            sb.Append("  FipsStatus: ").Append(FipsStatus).Append("\n");
            sb.Append("  DellServiceTag: ").Append(DellServiceTag).Append("\n");
            sb.Append("  ExpressServiceCode: ").Append(ExpressServiceCode).Append("\n");
            sb.Append("  EnclosureModelDescription: ").Append(EnclosureModelDescription).Append("\n");
            sb.Append("  StorageClass: ").Append(StorageClass).Append("\n");
            sb.Append("  ModeL10n: ").Append(ModeL10n).Append("\n");
            sb.Append("  SupportedSpeedsL10n: ").Append(SupportedSpeedsL10n).Append("\n");
            sb.Append("  SupportedProtocolL10n: ").Append(SupportedProtocolL10n).Append("\n");
            sb.Append("  ConnectorTypeL10n: ").Append(ConnectorTypeL10n).Append("\n");
            sb.Append("  DriveTypeL10n: ").Append(DriveTypeL10n).Append("\n");
            sb.Append("  EncryptionStatusL10n: ").Append(EncryptionStatusL10n).Append("\n");
            sb.Append("  FipsStatusL10n: ").Append(FipsStatusL10n).Append("\n");
            sb.Append("  EnclosureModelDescriptionL10n: ").Append(EnclosureModelDescriptionL10n).Append("\n");
            sb.Append("  StorageClassL10n: ").Append(StorageClassL10n).Append("\n");
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
            return obj.GetType() == GetType() && Equals((HardwareExtraDetailsInstance)obj);
        }

        /// <summary>
        /// Returns true if HardwareExtraDetailsInstance instances are equal
        /// </summary>
        /// <param name="other">Instance of HardwareExtraDetailsInstance to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HardwareExtraDetailsInstance other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    CpuModel == other.CpuModel ||
                    CpuModel != null &&
                    CpuModel.Equals(other.CpuModel)
                ) && 
                (
                    PhysicalMemorySizeGb == other.PhysicalMemorySizeGb ||
                    PhysicalMemorySizeGb != null &&
                    PhysicalMemorySizeGb.Equals(other.PhysicalMemorySizeGb)
                ) && 
                (
                    CpuCores == other.CpuCores ||
                    CpuCores != null &&
                    CpuCores.Equals(other.CpuCores)
                ) && 
                (
                    CpuSockets == other.CpuSockets ||
                    CpuSockets != null &&
                    CpuSockets.Equals(other.CpuSockets)
                ) && 
                (
                    BusNumber == other.BusNumber ||
                    BusNumber != null &&
                    BusNumber.Equals(other.BusNumber)
                ) && 
                (
                    EnclosureNumber == other.EnclosureNumber ||
                    EnclosureNumber != null &&
                    EnclosureNumber.Equals(other.EnclosureNumber)
                ) && 
                (
                    ModelName == other.ModelName ||
                    ModelName != null &&
                    ModelName.Equals(other.ModelName)
                ) && 
                (
                    RpmReading == other.RpmReading ||
                    RpmReading != null &&
                    RpmReading.Equals(other.RpmReading)
                ) && 
                (
                    FirmwareVersion == other.FirmwareVersion ||
                    FirmwareVersion != null &&
                    FirmwareVersion.Equals(other.FirmwareVersion)
                ) && 
                (
                    Mode == other.Mode ||
                    Mode != null &&
                    Mode.Equals(other.Mode)
                ) && 
                (
                    SupportedSpeeds == other.SupportedSpeeds ||
                    SupportedSpeeds != null &&
                    SupportedSpeeds.SequenceEqual(other.SupportedSpeeds)
                ) && 
                (
                    SupportedProtocol == other.SupportedProtocol ||
                    SupportedProtocol != null &&
                    SupportedProtocol.Equals(other.SupportedProtocol)
                ) && 
                (
                    ConnectorType == other.ConnectorType ||
                    ConnectorType != null &&
                    ConnectorType.Equals(other.ConnectorType)
                ) && 
                (
                    DriveType == other.DriveType ||
                    DriveType != null &&
                    DriveType.Equals(other.DriveType)
                ) && 
                (
                    Size == other.Size ||
                    Size != null &&
                    Size.Equals(other.Size)
                ) && 
                (
                    EncryptionStatus == other.EncryptionStatus ||
                    EncryptionStatus != null &&
                    EncryptionStatus.Equals(other.EncryptionStatus)
                ) && 
                (
                    FipsStatus == other.FipsStatus ||
                    FipsStatus != null &&
                    FipsStatus.Equals(other.FipsStatus)
                ) && 
                (
                    DellServiceTag == other.DellServiceTag ||
                    DellServiceTag != null &&
                    DellServiceTag.Equals(other.DellServiceTag)
                ) && 
                (
                    ExpressServiceCode == other.ExpressServiceCode ||
                    ExpressServiceCode != null &&
                    ExpressServiceCode.Equals(other.ExpressServiceCode)
                ) && 
                (
                    EnclosureModelDescription == other.EnclosureModelDescription ||
                    EnclosureModelDescription != null &&
                    EnclosureModelDescription.Equals(other.EnclosureModelDescription)
                ) && 
                (
                    StorageClass == other.StorageClass ||
                    StorageClass != null &&
                    StorageClass.Equals(other.StorageClass)
                ) && 
                (
                    ModeL10n == other.ModeL10n ||
                    ModeL10n != null &&
                    ModeL10n.Equals(other.ModeL10n)
                ) && 
                (
                    SupportedSpeedsL10n == other.SupportedSpeedsL10n ||
                    SupportedSpeedsL10n != null &&
                    SupportedSpeedsL10n.SequenceEqual(other.SupportedSpeedsL10n)
                ) && 
                (
                    SupportedProtocolL10n == other.SupportedProtocolL10n ||
                    SupportedProtocolL10n != null &&
                    SupportedProtocolL10n.Equals(other.SupportedProtocolL10n)
                ) && 
                (
                    ConnectorTypeL10n == other.ConnectorTypeL10n ||
                    ConnectorTypeL10n != null &&
                    ConnectorTypeL10n.Equals(other.ConnectorTypeL10n)
                ) && 
                (
                    DriveTypeL10n == other.DriveTypeL10n ||
                    DriveTypeL10n != null &&
                    DriveTypeL10n.Equals(other.DriveTypeL10n)
                ) && 
                (
                    EncryptionStatusL10n == other.EncryptionStatusL10n ||
                    EncryptionStatusL10n != null &&
                    EncryptionStatusL10n.Equals(other.EncryptionStatusL10n)
                ) && 
                (
                    FipsStatusL10n == other.FipsStatusL10n ||
                    FipsStatusL10n != null &&
                    FipsStatusL10n.Equals(other.FipsStatusL10n)
                ) && 
                (
                    EnclosureModelDescriptionL10n == other.EnclosureModelDescriptionL10n ||
                    EnclosureModelDescriptionL10n != null &&
                    EnclosureModelDescriptionL10n.Equals(other.EnclosureModelDescriptionL10n)
                ) && 
                (
                    StorageClassL10n == other.StorageClassL10n ||
                    StorageClassL10n != null &&
                    StorageClassL10n.Equals(other.StorageClassL10n)
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
                    if (CpuModel != null)
                    hashCode = hashCode * 59 + CpuModel.GetHashCode();
                    if (PhysicalMemorySizeGb != null)
                    hashCode = hashCode * 59 + PhysicalMemorySizeGb.GetHashCode();
                    if (CpuCores != null)
                    hashCode = hashCode * 59 + CpuCores.GetHashCode();
                    if (CpuSockets != null)
                    hashCode = hashCode * 59 + CpuSockets.GetHashCode();
                    if (BusNumber != null)
                    hashCode = hashCode * 59 + BusNumber.GetHashCode();
                    if (EnclosureNumber != null)
                    hashCode = hashCode * 59 + EnclosureNumber.GetHashCode();
                    if (ModelName != null)
                    hashCode = hashCode * 59 + ModelName.GetHashCode();
                    if (RpmReading != null)
                    hashCode = hashCode * 59 + RpmReading.GetHashCode();
                    if (FirmwareVersion != null)
                    hashCode = hashCode * 59 + FirmwareVersion.GetHashCode();
                    if (Mode != null)
                    hashCode = hashCode * 59 + Mode.GetHashCode();
                    if (SupportedSpeeds != null)
                    hashCode = hashCode * 59 + SupportedSpeeds.GetHashCode();
                    if (SupportedProtocol != null)
                    hashCode = hashCode * 59 + SupportedProtocol.GetHashCode();
                    if (ConnectorType != null)
                    hashCode = hashCode * 59 + ConnectorType.GetHashCode();
                    if (DriveType != null)
                    hashCode = hashCode * 59 + DriveType.GetHashCode();
                    if (Size != null)
                    hashCode = hashCode * 59 + Size.GetHashCode();
                    if (EncryptionStatus != null)
                    hashCode = hashCode * 59 + EncryptionStatus.GetHashCode();
                    if (FipsStatus != null)
                    hashCode = hashCode * 59 + FipsStatus.GetHashCode();
                    if (DellServiceTag != null)
                    hashCode = hashCode * 59 + DellServiceTag.GetHashCode();
                    if (ExpressServiceCode != null)
                    hashCode = hashCode * 59 + ExpressServiceCode.GetHashCode();
                    if (EnclosureModelDescription != null)
                    hashCode = hashCode * 59 + EnclosureModelDescription.GetHashCode();
                    if (StorageClass != null)
                    hashCode = hashCode * 59 + StorageClass.GetHashCode();
                    if (ModeL10n != null)
                    hashCode = hashCode * 59 + ModeL10n.GetHashCode();
                    if (SupportedSpeedsL10n != null)
                    hashCode = hashCode * 59 + SupportedSpeedsL10n.GetHashCode();
                    if (SupportedProtocolL10n != null)
                    hashCode = hashCode * 59 + SupportedProtocolL10n.GetHashCode();
                    if (ConnectorTypeL10n != null)
                    hashCode = hashCode * 59 + ConnectorTypeL10n.GetHashCode();
                    if (DriveTypeL10n != null)
                    hashCode = hashCode * 59 + DriveTypeL10n.GetHashCode();
                    if (EncryptionStatusL10n != null)
                    hashCode = hashCode * 59 + EncryptionStatusL10n.GetHashCode();
                    if (FipsStatusL10n != null)
                    hashCode = hashCode * 59 + FipsStatusL10n.GetHashCode();
                    if (EnclosureModelDescriptionL10n != null)
                    hashCode = hashCode * 59 + EnclosureModelDescriptionL10n.GetHashCode();
                    if (StorageClassL10n != null)
                    hashCode = hashCode * 59 + StorageClassL10n.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(HardwareExtraDetailsInstance left, HardwareExtraDetailsInstance right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(HardwareExtraDetailsInstance left, HardwareExtraDetailsInstance right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
