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
        ///  An enum describing the various entities supported by metrics.   * performance_metrics_by_appliance - Appliance performance metrics.   * performance_metrics_by_node - Node performance metrics.   * performance_metrics_by_volume - Volume performance metrics.   * performance_metrics_by_cluster - Cluster performance metrics.   * performance_metrics_by_vm - Virtual Machine performance metrics.   * performance_metrics_by_vg - Storage performance metrics for all volumes in a volume group   * performance_metrics_by_fe_fc_port - Frontend fibre channel port performance metrics.   * performance_metrics_by_fe_eth_port - Frontend ethernet port performance metrics.   * performance_metrics_by_fe_eth_node - Frontend ethernet performance metrics for node.   * performance_metrics_by_fe_fc_node - Frontend fibre channel performance metrics for node.   * vsphere_metrics_by_vm - Virtual Machine performance metrics directly from vSphere.   * vsphere_appson_metrics_by_node - Usage of CPU/Memory resources on the node by user Virtual machines.   * vsphere_appson_metrics_by_appliance - Usage of CPU/Memory resources on the appliance by user Virtual machines.   * wear_metrics_by_drive - Drive wear metrics.   * wear_metrics_by_drive_daily   * space_metrics_by_cluster - Cluster space metrics   * space_metrics_by_appliance - Appliance space metrics   * space_metrics_by_volume - Volume space metrics   * space_metrics_by_volume_family - Volume family space metrics   * space_metrics_by_vm - Virtual Machine space metrics   * space_metrics_by_storage_container - Storage Container space metrics   * space_metrics_by_vg - Volume space metrics in a volume group   * copy_metrics_by_appliance - Appliance copy metrics   * copy_metrics_by_cluster - Cluster copy metrics   * copy_metrics_by_vg - Copy metrics for each volume group   * copy_metrics_by_rg - Copy metrics for each replication group   * copy_metrics_by_remote_system - Copy metrics for each remote system   * copy_metrics_by_volume - Copy metrics for each volume   * performance_metrics_by_file_system - Performance metrics for the file system.   * performance_metrics_smb_by_node - Performance metrics for the SMB protocol global   * performance_metrics_smb_builtinclient_by_node - Performance metrics for the SMB protocol built-in client   * performance_metrics_smb_branch_cache_by_node - Performance metrics for the SMB protocol Branch-Cache   * performance_metrics_smb1_by_node - Performance metrics for the SMB1 protocol basic   * performance_metrics_smb1_builtinclient_by_node - Performance metrics for the SMB1 protocol built-in client   * performance_metrics_smb2_by_node - Performance metrics for the SMB2 protocol basic   * performance_metrics_smb2_builtinclient_by_node - Performance metrics for the SMB2 protocol built-in client   * performance_metrics_nfs_by_node - Performance metrics for the NFS protocol   * performance_metrics_nfsv3_by_node - Performance metrics for the NFSv3 protocol   * performance_metrics_nfsv4_by_node - Performance metrics for the NFSv4 protocol   * performance_metrics_file_by_node - Performance metrics for file by node.   * performance_metrics_file_by_appliance - Performance metrics for file by appliance.   * performance_metrics_file_by_cluster - Performance metrics for file by cluster.   * performance_metrics_by_ip_port - Performance metrics for the ip port (total)   * performance_metrics_by_ip_port_iscsi - Performance metrics for the ip port (iSCSI)   * performance_metrics_by_nas_server - Performance metrics for the Nas Server   * space_metrics_by_file_system - Space metrics for the File System.   * performance_metrics_by_initiator - Performance metrics for the initiator   * performance_metrics_by_host - Performance metrics for the host   * performance_metrics_by_hg - Performance metrics for all hosts in a host group   * space_metrics_by_remote_system - Remote system space metrics. Currently this is supported only for the PowerProtect DD remote systems.   * copy_metrics_by_file_system - Copy metrics for each file system   * copy_metrics_by_nas_server - Copy metrics for each nas server  Values was deprecated in 2.0.0.0: wear_metrics_by_drive. Values was added in 2.0.0.0: performance_metrics_by_ip_port, performance_metrics_file_by_node, performance_metrics_file_by_appliance, performance_metrics_file_by_cluster. Values was added in 3.0.0.0: performance_metrics_by_nas_server, space_metrics_by_file_system, performance_metrics_by_initiator, performance_metrics_by_host, performance_metrics_by_hg, vsphere_metrics_by_vm, vsphere_appson_metrics_by_node, vsphere_appson_metrics_by_appliance, copy_metrics_by_rg, performance_metrics_by_ip_port_iscsi. Values was added in 3.5.0.0: space_metrics_by_remote_system. Values was added in 4.0.0.0: copy_metrics_by_file_system, copy_metrics_by_nas_server.
        /// </summary>
        /// <value> An enum describing the various entities supported by metrics.   * performance_metrics_by_appliance - Appliance performance metrics.   * performance_metrics_by_node - Node performance metrics.   * performance_metrics_by_volume - Volume performance metrics.   * performance_metrics_by_cluster - Cluster performance metrics.   * performance_metrics_by_vm - Virtual Machine performance metrics.   * performance_metrics_by_vg - Storage performance metrics for all volumes in a volume group   * performance_metrics_by_fe_fc_port - Frontend fibre channel port performance metrics.   * performance_metrics_by_fe_eth_port - Frontend ethernet port performance metrics.   * performance_metrics_by_fe_eth_node - Frontend ethernet performance metrics for node.   * performance_metrics_by_fe_fc_node - Frontend fibre channel performance metrics for node.   * vsphere_metrics_by_vm - Virtual Machine performance metrics directly from vSphere.   * vsphere_appson_metrics_by_node - Usage of CPU/Memory resources on the node by user Virtual machines.   * vsphere_appson_metrics_by_appliance - Usage of CPU/Memory resources on the appliance by user Virtual machines.   * wear_metrics_by_drive - Drive wear metrics.   * wear_metrics_by_drive_daily   * space_metrics_by_cluster - Cluster space metrics   * space_metrics_by_appliance - Appliance space metrics   * space_metrics_by_volume - Volume space metrics   * space_metrics_by_volume_family - Volume family space metrics   * space_metrics_by_vm - Virtual Machine space metrics   * space_metrics_by_storage_container - Storage Container space metrics   * space_metrics_by_vg - Volume space metrics in a volume group   * copy_metrics_by_appliance - Appliance copy metrics   * copy_metrics_by_cluster - Cluster copy metrics   * copy_metrics_by_vg - Copy metrics for each volume group   * copy_metrics_by_rg - Copy metrics for each replication group   * copy_metrics_by_remote_system - Copy metrics for each remote system   * copy_metrics_by_volume - Copy metrics for each volume   * performance_metrics_by_file_system - Performance metrics for the file system.   * performance_metrics_smb_by_node - Performance metrics for the SMB protocol global   * performance_metrics_smb_builtinclient_by_node - Performance metrics for the SMB protocol built-in client   * performance_metrics_smb_branch_cache_by_node - Performance metrics for the SMB protocol Branch-Cache   * performance_metrics_smb1_by_node - Performance metrics for the SMB1 protocol basic   * performance_metrics_smb1_builtinclient_by_node - Performance metrics for the SMB1 protocol built-in client   * performance_metrics_smb2_by_node - Performance metrics for the SMB2 protocol basic   * performance_metrics_smb2_builtinclient_by_node - Performance metrics for the SMB2 protocol built-in client   * performance_metrics_nfs_by_node - Performance metrics for the NFS protocol   * performance_metrics_nfsv3_by_node - Performance metrics for the NFSv3 protocol   * performance_metrics_nfsv4_by_node - Performance metrics for the NFSv4 protocol   * performance_metrics_file_by_node - Performance metrics for file by node.   * performance_metrics_file_by_appliance - Performance metrics for file by appliance.   * performance_metrics_file_by_cluster - Performance metrics for file by cluster.   * performance_metrics_by_ip_port - Performance metrics for the ip port (total)   * performance_metrics_by_ip_port_iscsi - Performance metrics for the ip port (iSCSI)   * performance_metrics_by_nas_server - Performance metrics for the Nas Server   * space_metrics_by_file_system - Space metrics for the File System.   * performance_metrics_by_initiator - Performance metrics for the initiator   * performance_metrics_by_host - Performance metrics for the host   * performance_metrics_by_hg - Performance metrics for all hosts in a host group   * space_metrics_by_remote_system - Remote system space metrics. Currently this is supported only for the PowerProtect DD remote systems.   * copy_metrics_by_file_system - Copy metrics for each file system   * copy_metrics_by_nas_server - Copy metrics for each nas server  Values was deprecated in 2.0.0.0: wear_metrics_by_drive. Values was added in 2.0.0.0: performance_metrics_by_ip_port, performance_metrics_file_by_node, performance_metrics_file_by_appliance, performance_metrics_file_by_cluster. Values was added in 3.0.0.0: performance_metrics_by_nas_server, space_metrics_by_file_system, performance_metrics_by_initiator, performance_metrics_by_host, performance_metrics_by_hg, vsphere_metrics_by_vm, vsphere_appson_metrics_by_node, vsphere_appson_metrics_by_appliance, copy_metrics_by_rg, performance_metrics_by_ip_port_iscsi. Values was added in 3.5.0.0: space_metrics_by_remote_system. Values was added in 4.0.0.0: copy_metrics_by_file_system, copy_metrics_by_nas_server.</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum MetricsEntityEnum
        {
            
            /// <summary>
            /// Enum PerformanceMetricsByApplianceEnum for performance_metrics_by_appliance
            /// </summary>
            [EnumMember(Value = "performance_metrics_by_appliance")]
            PerformanceMetricsByApplianceEnum = 1,
            
            /// <summary>
            /// Enum PerformanceMetricsByNodeEnum for performance_metrics_by_node
            /// </summary>
            [EnumMember(Value = "performance_metrics_by_node")]
            PerformanceMetricsByNodeEnum = 2,
            
            /// <summary>
            /// Enum PerformanceMetricsByVolumeEnum for performance_metrics_by_volume
            /// </summary>
            [EnumMember(Value = "performance_metrics_by_volume")]
            PerformanceMetricsByVolumeEnum = 3,
            
            /// <summary>
            /// Enum PerformanceMetricsByClusterEnum for performance_metrics_by_cluster
            /// </summary>
            [EnumMember(Value = "performance_metrics_by_cluster")]
            PerformanceMetricsByClusterEnum = 4,
            
            /// <summary>
            /// Enum PerformanceMetricsByVmEnum for performance_metrics_by_vm
            /// </summary>
            [EnumMember(Value = "performance_metrics_by_vm")]
            PerformanceMetricsByVmEnum = 5,
            
            /// <summary>
            /// Enum PerformanceMetricsByVgEnum for performance_metrics_by_vg
            /// </summary>
            [EnumMember(Value = "performance_metrics_by_vg")]
            PerformanceMetricsByVgEnum = 6,
            
            /// <summary>
            /// Enum PerformanceMetricsByFeFcPortEnum for performance_metrics_by_fe_fc_port
            /// </summary>
            [EnumMember(Value = "performance_metrics_by_fe_fc_port")]
            PerformanceMetricsByFeFcPortEnum = 7,
            
            /// <summary>
            /// Enum PerformanceMetricsByFeEthPortEnum for performance_metrics_by_fe_eth_port
            /// </summary>
            [EnumMember(Value = "performance_metrics_by_fe_eth_port")]
            PerformanceMetricsByFeEthPortEnum = 8,
            
            /// <summary>
            /// Enum PerformanceMetricsByFeEthNodeEnum for performance_metrics_by_fe_eth_node
            /// </summary>
            [EnumMember(Value = "performance_metrics_by_fe_eth_node")]
            PerformanceMetricsByFeEthNodeEnum = 9,
            
            /// <summary>
            /// Enum PerformanceMetricsByFeFcNodeEnum for performance_metrics_by_fe_fc_node
            /// </summary>
            [EnumMember(Value = "performance_metrics_by_fe_fc_node")]
            PerformanceMetricsByFeFcNodeEnum = 10,
            
            /// <summary>
            /// Enum WearMetricsByDriveEnum for wear_metrics_by_drive
            /// </summary>
            [EnumMember(Value = "wear_metrics_by_drive")]
            WearMetricsByDriveEnum = 11,
            
            /// <summary>
            /// Enum WearMetricsByDriveDailyEnum for wear_metrics_by_drive_daily
            /// </summary>
            [EnumMember(Value = "wear_metrics_by_drive_daily")]
            WearMetricsByDriveDailyEnum = 12,
            
            /// <summary>
            /// Enum SpaceMetricsByClusterEnum for space_metrics_by_cluster
            /// </summary>
            [EnumMember(Value = "space_metrics_by_cluster")]
            SpaceMetricsByClusterEnum = 13,
            
            /// <summary>
            /// Enum SpaceMetricsByApplianceEnum for space_metrics_by_appliance
            /// </summary>
            [EnumMember(Value = "space_metrics_by_appliance")]
            SpaceMetricsByApplianceEnum = 14,
            
            /// <summary>
            /// Enum SpaceMetricsByVolumeEnum for space_metrics_by_volume
            /// </summary>
            [EnumMember(Value = "space_metrics_by_volume")]
            SpaceMetricsByVolumeEnum = 15,
            
            /// <summary>
            /// Enum SpaceMetricsByVolumeFamilyEnum for space_metrics_by_volume_family
            /// </summary>
            [EnumMember(Value = "space_metrics_by_volume_family")]
            SpaceMetricsByVolumeFamilyEnum = 16,
            
            /// <summary>
            /// Enum SpaceMetricsByVmEnum for space_metrics_by_vm
            /// </summary>
            [EnumMember(Value = "space_metrics_by_vm")]
            SpaceMetricsByVmEnum = 17,
            
            /// <summary>
            /// Enum SpaceMetricsByStorageContainerEnum for space_metrics_by_storage_container
            /// </summary>
            [EnumMember(Value = "space_metrics_by_storage_container")]
            SpaceMetricsByStorageContainerEnum = 18,
            
            /// <summary>
            /// Enum SpaceMetricsByVgEnum for space_metrics_by_vg
            /// </summary>
            [EnumMember(Value = "space_metrics_by_vg")]
            SpaceMetricsByVgEnum = 19,
            
            /// <summary>
            /// Enum CopyMetricsByApplianceEnum for copy_metrics_by_appliance
            /// </summary>
            [EnumMember(Value = "copy_metrics_by_appliance")]
            CopyMetricsByApplianceEnum = 20,
            
            /// <summary>
            /// Enum CopyMetricsByClusterEnum for copy_metrics_by_cluster
            /// </summary>
            [EnumMember(Value = "copy_metrics_by_cluster")]
            CopyMetricsByClusterEnum = 21,
            
            /// <summary>
            /// Enum CopyMetricsByVgEnum for copy_metrics_by_vg
            /// </summary>
            [EnumMember(Value = "copy_metrics_by_vg")]
            CopyMetricsByVgEnum = 22,
            
            /// <summary>
            /// Enum CopyMetricsByRgEnum for copy_metrics_by_rg
            /// </summary>
            [EnumMember(Value = "copy_metrics_by_rg")]
            CopyMetricsByRgEnum = 23,
            
            /// <summary>
            /// Enum CopyMetricsByRemoteSystemEnum for copy_metrics_by_remote_system
            /// </summary>
            [EnumMember(Value = "copy_metrics_by_remote_system")]
            CopyMetricsByRemoteSystemEnum = 24,
            
            /// <summary>
            /// Enum CopyMetricsByVolumeEnum for copy_metrics_by_volume
            /// </summary>
            [EnumMember(Value = "copy_metrics_by_volume")]
            CopyMetricsByVolumeEnum = 25,
            
            /// <summary>
            /// Enum PerformanceMetricsByFileSystemEnum for performance_metrics_by_file_system
            /// </summary>
            [EnumMember(Value = "performance_metrics_by_file_system")]
            PerformanceMetricsByFileSystemEnum = 26,
            
            /// <summary>
            /// Enum PerformanceMetricsSmbByNodeEnum for performance_metrics_smb_by_node
            /// </summary>
            [EnumMember(Value = "performance_metrics_smb_by_node")]
            PerformanceMetricsSmbByNodeEnum = 27,
            
            /// <summary>
            /// Enum PerformanceMetricsSmbBuiltinclientByNodeEnum for performance_metrics_smb_builtinclient_by_node
            /// </summary>
            [EnumMember(Value = "performance_metrics_smb_builtinclient_by_node")]
            PerformanceMetricsSmbBuiltinclientByNodeEnum = 28,
            
            /// <summary>
            /// Enum PerformanceMetricsSmbBranchCacheByNodeEnum for performance_metrics_smb_branch_cache_by_node
            /// </summary>
            [EnumMember(Value = "performance_metrics_smb_branch_cache_by_node")]
            PerformanceMetricsSmbBranchCacheByNodeEnum = 29,
            
            /// <summary>
            /// Enum PerformanceMetricsSmb1ByNodeEnum for performance_metrics_smb1_by_node
            /// </summary>
            [EnumMember(Value = "performance_metrics_smb1_by_node")]
            PerformanceMetricsSmb1ByNodeEnum = 30,
            
            /// <summary>
            /// Enum PerformanceMetricsSmb1BuiltinclientByNodeEnum for performance_metrics_smb1_builtinclient_by_node
            /// </summary>
            [EnumMember(Value = "performance_metrics_smb1_builtinclient_by_node")]
            PerformanceMetricsSmb1BuiltinclientByNodeEnum = 31,
            
            /// <summary>
            /// Enum PerformanceMetricsSmb2ByNodeEnum for performance_metrics_smb2_by_node
            /// </summary>
            [EnumMember(Value = "performance_metrics_smb2_by_node")]
            PerformanceMetricsSmb2ByNodeEnum = 32,
            
            /// <summary>
            /// Enum PerformanceMetricsSmb2BuiltinclientByNodeEnum for performance_metrics_smb2_builtinclient_by_node
            /// </summary>
            [EnumMember(Value = "performance_metrics_smb2_builtinclient_by_node")]
            PerformanceMetricsSmb2BuiltinclientByNodeEnum = 33,
            
            /// <summary>
            /// Enum PerformanceMetricsNfsByNodeEnum for performance_metrics_nfs_by_node
            /// </summary>
            [EnumMember(Value = "performance_metrics_nfs_by_node")]
            PerformanceMetricsNfsByNodeEnum = 34,
            
            /// <summary>
            /// Enum PerformanceMetricsNfsv3ByNodeEnum for performance_metrics_nfsv3_by_node
            /// </summary>
            [EnumMember(Value = "performance_metrics_nfsv3_by_node")]
            PerformanceMetricsNfsv3ByNodeEnum = 35,
            
            /// <summary>
            /// Enum PerformanceMetricsNfsv4ByNodeEnum for performance_metrics_nfsv4_by_node
            /// </summary>
            [EnumMember(Value = "performance_metrics_nfsv4_by_node")]
            PerformanceMetricsNfsv4ByNodeEnum = 36,
            
            /// <summary>
            /// Enum PerformanceMetricsFileByNodeEnum for performance_metrics_file_by_node
            /// </summary>
            [EnumMember(Value = "performance_metrics_file_by_node")]
            PerformanceMetricsFileByNodeEnum = 37,
            
            /// <summary>
            /// Enum PerformanceMetricsFileByApplianceEnum for performance_metrics_file_by_appliance
            /// </summary>
            [EnumMember(Value = "performance_metrics_file_by_appliance")]
            PerformanceMetricsFileByApplianceEnum = 38,
            
            /// <summary>
            /// Enum PerformanceMetricsFileByClusterEnum for performance_metrics_file_by_cluster
            /// </summary>
            [EnumMember(Value = "performance_metrics_file_by_cluster")]
            PerformanceMetricsFileByClusterEnum = 39,
            
            /// <summary>
            /// Enum PerformanceMetricsByIpPortEnum for performance_metrics_by_ip_port
            /// </summary>
            [EnumMember(Value = "performance_metrics_by_ip_port")]
            PerformanceMetricsByIpPortEnum = 40,
            
            /// <summary>
            /// Enum PerformanceMetricsByIpPortIscsiEnum for performance_metrics_by_ip_port_iscsi
            /// </summary>
            [EnumMember(Value = "performance_metrics_by_ip_port_iscsi")]
            PerformanceMetricsByIpPortIscsiEnum = 41,
            
            /// <summary>
            /// Enum PerformanceMetricsByNasServerEnum for performance_metrics_by_nas_server
            /// </summary>
            [EnumMember(Value = "performance_metrics_by_nas_server")]
            PerformanceMetricsByNasServerEnum = 42,
            
            /// <summary>
            /// Enum SpaceMetricsByFileSystemEnum for space_metrics_by_file_system
            /// </summary>
            [EnumMember(Value = "space_metrics_by_file_system")]
            SpaceMetricsByFileSystemEnum = 43,
            
            /// <summary>
            /// Enum PerformanceMetricsByInitiatorEnum for performance_metrics_by_initiator
            /// </summary>
            [EnumMember(Value = "performance_metrics_by_initiator")]
            PerformanceMetricsByInitiatorEnum = 44,
            
            /// <summary>
            /// Enum PerformanceMetricsByHostEnum for performance_metrics_by_host
            /// </summary>
            [EnumMember(Value = "performance_metrics_by_host")]
            PerformanceMetricsByHostEnum = 45,
            
            /// <summary>
            /// Enum PerformanceMetricsByHgEnum for performance_metrics_by_hg
            /// </summary>
            [EnumMember(Value = "performance_metrics_by_hg")]
            PerformanceMetricsByHgEnum = 46,
            
            /// <summary>
            /// Enum VsphereMetricsByVmEnum for vsphere_metrics_by_vm
            /// </summary>
            [EnumMember(Value = "vsphere_metrics_by_vm")]
            VsphereMetricsByVmEnum = 47,
            
            /// <summary>
            /// Enum VsphereAppsonMetricsByNodeEnum for vsphere_appson_metrics_by_node
            /// </summary>
            [EnumMember(Value = "vsphere_appson_metrics_by_node")]
            VsphereAppsonMetricsByNodeEnum = 48,
            
            /// <summary>
            /// Enum VsphereAppsonMetricsByApplianceEnum for vsphere_appson_metrics_by_appliance
            /// </summary>
            [EnumMember(Value = "vsphere_appson_metrics_by_appliance")]
            VsphereAppsonMetricsByApplianceEnum = 49,
            
            /// <summary>
            /// Enum SpaceMetricsByRemoteSystemEnum for space_metrics_by_remote_system
            /// </summary>
            [EnumMember(Value = "space_metrics_by_remote_system")]
            SpaceMetricsByRemoteSystemEnum = 50,
            
            /// <summary>
            /// Enum CopyMetricsByFileSystemEnum for copy_metrics_by_file_system
            /// </summary>
            [EnumMember(Value = "copy_metrics_by_file_system")]
            CopyMetricsByFileSystemEnum = 51,
            
            /// <summary>
            /// Enum CopyMetricsByNasServerEnum for copy_metrics_by_nas_server
            /// </summary>
            [EnumMember(Value = "copy_metrics_by_nas_server")]
            CopyMetricsByNasServerEnum = 52
        }
}
