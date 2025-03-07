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
        /// User-specified action to be performed on the given resource. Values was added in 2.0.0.0: start_failover_test, stop_failover_test. Values was added in 3.0.0.0: add_or_replace, bulk_disable_mirror, bulk_enable_mirror, switch_mode_to_sync, create_nas_volume_session.
        /// </summary>
        /// <value>User-specified action to be performed on the given resource. Values was added in 2.0.0.0: start_failover_test, stop_failover_test. Values was added in 3.0.0.0: add_or_replace, bulk_disable_mirror, bulk_enable_mirror, switch_mode_to_sync, create_nas_volume_session.</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum ResourceActionEnum
        {
            
            /// <summary>
            /// Enum AddMembersEnum for add_members
            /// </summary>
            [EnumMember(Value = "add_members")]
            AddMembersEnum = 1,
            
            /// <summary>
            /// Enum AddOrReplaceEnum for add_or_replace
            /// </summary>
            [EnumMember(Value = "add_or_replace")]
            AddOrReplaceEnum = 2,
            
            /// <summary>
            /// Enum AddPrivilegedAccountEnum for add_privileged_account
            /// </summary>
            [EnumMember(Value = "add_privileged_account")]
            AddPrivilegedAccountEnum = 3,
            
            /// <summary>
            /// Enum ApplyInternalHostLicensesEnum for apply_internal_host_licenses
            /// </summary>
            [EnumMember(Value = "apply_internal_host_licenses")]
            ApplyInternalHostLicensesEnum = 4,
            
            /// <summary>
            /// Enum AttachEnum for attach
            /// </summary>
            [EnumMember(Value = "attach")]
            AttachEnum = 5,
            
            /// <summary>
            /// Enum AttachVolzsEnum for attach_volzs
            /// </summary>
            [EnumMember(Value = "attach_volzs")]
            AttachVolzsEnum = 6,
            
            /// <summary>
            /// Enum BindEnum for bind
            /// </summary>
            [EnumMember(Value = "bind")]
            BindEnum = 7,
            
            /// <summary>
            /// Enum BulkDisableMirrorEnum for bulk_disable_mirror
            /// </summary>
            [EnumMember(Value = "bulk_disable_mirror")]
            BulkDisableMirrorEnum = 8,
            
            /// <summary>
            /// Enum BulkEnableMirrorEnum for bulk_enable_mirror
            /// </summary>
            [EnumMember(Value = "bulk_enable_mirror")]
            BulkEnableMirrorEnum = 9,
            
            /// <summary>
            /// Enum CancelEnum for cancel
            /// </summary>
            [EnumMember(Value = "cancel")]
            CancelEnum = 10,
            
            /// <summary>
            /// Enum CancelDownloadEnum for cancel_download
            /// </summary>
            [EnumMember(Value = "cancel_download")]
            CancelDownloadEnum = 11,
            
            /// <summary>
            /// Enum CheckConnectivityEnum for check_connectivity
            /// </summary>
            [EnumMember(Value = "check_connectivity")]
            CheckConnectivityEnum = 12,
            
            /// <summary>
            /// Enum CheckSnapshotsPeerMetadataEnum for check_snapshots_peer_metadata
            /// </summary>
            [EnumMember(Value = "check_snapshots_peer_metadata")]
            CheckSnapshotsPeerMetadataEnum = 13,
            
            /// <summary>
            /// Enum CleanupEnum for cleanup
            /// </summary>
            [EnumMember(Value = "cleanup")]
            CleanupEnum = 14,
            
            /// <summary>
            /// Enum CloneEnum for clone
            /// </summary>
            [EnumMember(Value = "clone")]
            CloneEnum = 15,
            
            /// <summary>
            /// Enum ConfigureMetroEnum for configure_metro
            /// </summary>
            [EnumMember(Value = "configure_metro")]
            ConfigureMetroEnum = 16,
            
            /// <summary>
            /// Enum CreateEnum for create
            /// </summary>
            [EnumMember(Value = "create")]
            CreateEnum = 17,
            
            /// <summary>
            /// Enum CreateMigrationSessionsEnum for create_migration_sessions
            /// </summary>
            [EnumMember(Value = "create_migration_sessions")]
            CreateMigrationSessionsEnum = 18,
            
            /// <summary>
            /// Enum CreateNasVolumeSessionEnum for create_nas_volume_session
            /// </summary>
            [EnumMember(Value = "create_nas_volume_session")]
            CreateNasVolumeSessionEnum = 19,
            
            /// <summary>
            /// Enum CutoverEnum for cutover
            /// </summary>
            [EnumMember(Value = "cutover")]
            CutoverEnum = 20,
            
            /// <summary>
            /// Enum DecommissionEnum for decommission
            /// </summary>
            [EnumMember(Value = "decommission")]
            DecommissionEnum = 21,
            
            /// <summary>
            /// Enum DeleteEnum for delete
            /// </summary>
            [EnumMember(Value = "delete")]
            DeleteEnum = 22,
            
            /// <summary>
            /// Enum DemoteEnum for demote
            /// </summary>
            [EnumMember(Value = "demote")]
            DemoteEnum = 23,
            
            /// <summary>
            /// Enum DestinationObjectsSyncEnum for destination_objects_sync
            /// </summary>
            [EnumMember(Value = "destination_objects_sync")]
            DestinationObjectsSyncEnum = 24,
            
            /// <summary>
            /// Enum DetachEnum for detach
            /// </summary>
            [EnumMember(Value = "detach")]
            DetachEnum = 25,
            
            /// <summary>
            /// Enum DiscoverEnum for discover
            /// </summary>
            [EnumMember(Value = "discover")]
            DiscoverEnum = 26,
            
            /// <summary>
            /// Enum DiscoverFcTargetsEnum for discover_fc_targets
            /// </summary>
            [EnumMember(Value = "discover_fc_targets")]
            DiscoverFcTargetsEnum = 27,
            
            /// <summary>
            /// Enum DiscoverForeignRemoteSnapshotsEnum for discover_foreign_remote_snapshots
            /// </summary>
            [EnumMember(Value = "discover_foreign_remote_snapshots")]
            DiscoverForeignRemoteSnapshotsEnum = 28,
            
            /// <summary>
            /// Enum DownloadEnum for download
            /// </summary>
            [EnumMember(Value = "download")]
            DownloadEnum = 29,
            
            /// <summary>
            /// Enum DriveFailureToleranceLevelAvailabilityEnum for drive_failure_tolerance_level_availability
            /// </summary>
            [EnumMember(Value = "drive_failure_tolerance_level_availability")]
            DriveFailureToleranceLevelAvailabilityEnum = 30,
            
            /// <summary>
            /// Enum EmptyEnum for empty
            /// </summary>
            [EnumMember(Value = "empty")]
            EmptyEnum = 31,
            
            /// <summary>
            /// Enum EnableEnum for enable
            /// </summary>
            [EnumMember(Value = "enable")]
            EnableEnum = 32,
            
            /// <summary>
            /// Enum EndMetroEnum for end_metro
            /// </summary>
            [EnumMember(Value = "end_metro")]
            EndMetroEnum = 33,
            
            /// <summary>
            /// Enum EstimateApplianceFreeSpaceEnum for estimate_appliance_free_space
            /// </summary>
            [EnumMember(Value = "estimate_appliance_free_space")]
            EstimateApplianceFreeSpaceEnum = 34,
            
            /// <summary>
            /// Enum ExchangeEnum for exchange
            /// </summary>
            [EnumMember(Value = "exchange")]
            ExchangeEnum = 35,
            
            /// <summary>
            /// Enum ExpireRecoverySnapshotsEnum for expire_recovery_snapshots
            /// </summary>
            [EnumMember(Value = "expire_recovery_snapshots")]
            ExpireRecoverySnapshotsEnum = 36,
            
            /// <summary>
            /// Enum ExtendTrialEnum for extend_trial
            /// </summary>
            [EnumMember(Value = "extend_trial")]
            ExtendTrialEnum = 37,
            
            /// <summary>
            /// Enum FailoverEnum for failover
            /// </summary>
            [EnumMember(Value = "failover")]
            FailoverEnum = 38,
            
            /// <summary>
            /// Enum FileCreateHelperEnum for file_create_helper
            /// </summary>
            [EnumMember(Value = "file_create_helper")]
            FileCreateHelperEnum = 39,
            
            /// <summary>
            /// Enum FileDeleteHelperEnum for file_delete_helper
            /// </summary>
            [EnumMember(Value = "file_delete_helper")]
            FileDeleteHelperEnum = 40,
            
            /// <summary>
            /// Enum ForecastEnum for forecast
            /// </summary>
            [EnumMember(Value = "forecast")]
            ForecastEnum = 41,
            
            /// <summary>
            /// Enum FractureEnum for fracture
            /// </summary>
            [EnumMember(Value = "fracture")]
            FractureEnum = 42,
            
            /// <summary>
            /// Enum GenerateEnum for generate
            /// </summary>
            [EnumMember(Value = "generate")]
            GenerateEnum = 43,
            
            /// <summary>
            /// Enum GetAclEnum for get_acl
            /// </summary>
            [EnumMember(Value = "get_acl")]
            GetAclEnum = 44,
            
            /// <summary>
            /// Enum GetBondRuntimeInformationEnum for get_bond_runtime_information
            /// </summary>
            [EnumMember(Value = "get_bond_runtime_information")]
            GetBondRuntimeInformationEnum = 45,
            
            /// <summary>
            /// Enum GetCaServerCertEnum for get_ca_server_cert
            /// </summary>
            [EnumMember(Value = "get_ca_server_cert")]
            GetCaServerCertEnum = 46,
            
            /// <summary>
            /// Enum GetConfigurationInfoEnum for get_configuration_info
            /// </summary>
            [EnumMember(Value = "get_configuration_info")]
            GetConfigurationInfoEnum = 47,
            
            /// <summary>
            /// Enum GetL2InformationEnum for get_l2_information
            /// </summary>
            [EnumMember(Value = "get_l2_information")]
            GetL2InformationEnum = 48,
            
            /// <summary>
            /// Enum GetMetroTpgMeshEnum for get_metro_tpg_mesh
            /// </summary>
            [EnumMember(Value = "get_metro_tpg_mesh")]
            GetMetroTpgMeshEnum = 49,
            
            /// <summary>
            /// Enum GetPrivilegedAccountsEnum for get_privileged_accounts
            /// </summary>
            [EnumMember(Value = "get_privileged_accounts")]
            GetPrivilegedAccountsEnum = 50,
            
            /// <summary>
            /// Enum GetReplicatedNasServerEnum for get_replicated_nas_server
            /// </summary>
            [EnumMember(Value = "get_replicated_nas_server")]
            GetReplicatedNasServerEnum = 51,
            
            /// <summary>
            /// Enum GetViruscheckerAuditInfoEnum for get_viruschecker_audit_info
            /// </summary>
            [EnumMember(Value = "get_viruschecker_audit_info")]
            GetViruscheckerAuditInfoEnum = 52,
            
            /// <summary>
            /// Enum ImportSnapshotPolicyEnum for import_snapshot_policy
            /// </summary>
            [EnumMember(Value = "import_snapshot_policy")]
            ImportSnapshotPolicyEnum = 53,
            
            /// <summary>
            /// Enum ImportSnapshotProfilesEnum for import_snapshot_profiles
            /// </summary>
            [EnumMember(Value = "import_snapshot_profiles")]
            ImportSnapshotProfilesEnum = 54,
            
            /// <summary>
            /// Enum ImportSnapshotSchedulesEnum for import_snapshot_schedules
            /// </summary>
            [EnumMember(Value = "import_snapshot_schedules")]
            ImportSnapshotSchedulesEnum = 55,
            
            /// <summary>
            /// Enum InstallEnum for install
            /// </summary>
            [EnumMember(Value = "install")]
            InstallEnum = 56,
            
            /// <summary>
            /// Enum JoinEnum for join
            /// </summary>
            [EnumMember(Value = "join")]
            JoinEnum = 57,
            
            /// <summary>
            /// Enum ModifyEnum for modify
            /// </summary>
            [EnumMember(Value = "modify")]
            ModifyEnum = 58,
            
            /// <summary>
            /// Enum ModifyVolumeStateEnum for modify_volume_state
            /// </summary>
            [EnumMember(Value = "modify_volume_state")]
            ModifyVolumeStateEnum = 59,
            
            /// <summary>
            /// Enum MountEnum for mount
            /// </summary>
            [EnumMember(Value = "mount")]
            MountEnum = 60,
            
            /// <summary>
            /// Enum ObjectSyncEnum for object_sync
            /// </summary>
            [EnumMember(Value = "object_sync")]
            ObjectSyncEnum = 61,
            
            /// <summary>
            /// Enum PauseEnum for pause
            /// </summary>
            [EnumMember(Value = "pause")]
            PauseEnum = 62,
            
            /// <summary>
            /// Enum PingEnum for ping
            /// </summary>
            [EnumMember(Value = "ping")]
            PingEnum = 63,
            
            /// <summary>
            /// Enum PromoteEnum for promote
            /// </summary>
            [EnumMember(Value = "promote")]
            PromoteEnum = 64,
            
            /// <summary>
            /// Enum PuhcEnum for puhc
            /// </summary>
            [EnumMember(Value = "puhc")]
            PuhcEnum = 65,
            
            /// <summary>
            /// Enum QueryAppliancesEnum for query_appliances
            /// </summary>
            [EnumMember(Value = "query_appliances")]
            QueryAppliancesEnum = 66,
            
            /// <summary>
            /// Enum QueryAvailablePowerstoreNetworksEnum for query_available_powerstore_networks
            /// </summary>
            [EnumMember(Value = "query_available_powerstore_networks")]
            QueryAvailablePowerstoreNetworksEnum = 67,
            
            /// <summary>
            /// Enum QueryDestinationsDetailsEnum for query_destinations_details
            /// </summary>
            [EnumMember(Value = "query_destinations_details")]
            QueryDestinationsDetailsEnum = 68,
            
            /// <summary>
            /// Enum QueryDetailsEnum for query_details
            /// </summary>
            [EnumMember(Value = "query_details")]
            QueryDetailsEnum = 69,
            
            /// <summary>
            /// Enum QueryTargetEnum for query_target
            /// </summary>
            [EnumMember(Value = "query_target")]
            QueryTargetEnum = 70,
            
            /// <summary>
            /// Enum QueryVolzsEnum for query_volzs
            /// </summary>
            [EnumMember(Value = "query_volzs")]
            QueryVolzsEnum = 71,
            
            /// <summary>
            /// Enum RecoverEnum for recover
            /// </summary>
            [EnumMember(Value = "recover")]
            RecoverEnum = 72,
            
            /// <summary>
            /// Enum RediscoverEnum for rediscover
            /// </summary>
            [EnumMember(Value = "rediscover")]
            RediscoverEnum = 73,
            
            /// <summary>
            /// Enum RefreshEnum for refresh
            /// </summary>
            [EnumMember(Value = "refresh")]
            RefreshEnum = 74,
            
            /// <summary>
            /// Enum RefreshQuotaEnum for refresh_quota
            /// </summary>
            [EnumMember(Value = "refresh_quota")]
            RefreshQuotaEnum = 75,
            
            /// <summary>
            /// Enum RegenerateEnum for regenerate
            /// </summary>
            [EnumMember(Value = "regenerate")]
            RegenerateEnum = 76,
            
            /// <summary>
            /// Enum RemoveMembersEnum for remove_members
            /// </summary>
            [EnumMember(Value = "remove_members")]
            RemoveMembersEnum = 77,
            
            /// <summary>
            /// Enum RemovePrivilegedAccountEnum for remove_privileged_account
            /// </summary>
            [EnumMember(Value = "remove_privileged_account")]
            RemovePrivilegedAccountEnum = 78,
            
            /// <summary>
            /// Enum ReplaceEnum for replace
            /// </summary>
            [EnumMember(Value = "replace")]
            ReplaceEnum = 79,
            
            /// <summary>
            /// Enum ReportEnum for report
            /// </summary>
            [EnumMember(Value = "report")]
            ReportEnum = 80,
            
            /// <summary>
            /// Enum ReprotectEnum for reprotect
            /// </summary>
            [EnumMember(Value = "reprotect")]
            ReprotectEnum = 81,
            
            /// <summary>
            /// Enum ResetCertificatesEnum for reset_certificates
            /// </summary>
            [EnumMember(Value = "reset_certificates")]
            ResetCertificatesEnum = 82,
            
            /// <summary>
            /// Enum RestoreEnum for restore
            /// </summary>
            [EnumMember(Value = "restore")]
            RestoreEnum = 83,
            
            /// <summary>
            /// Enum RestorePstxConfigEnum for restore_pstx_config
            /// </summary>
            [EnumMember(Value = "restore_pstx_config")]
            RestorePstxConfigEnum = 84,
            
            /// <summary>
            /// Enum ResumeEnum for resume
            /// </summary>
            [EnumMember(Value = "resume")]
            ResumeEnum = 85,
            
            /// <summary>
            /// Enum RetrieveEnum for retrieve
            /// </summary>
            [EnumMember(Value = "retrieve")]
            RetrieveEnum = 86,
            
            /// <summary>
            /// Enum ScaleEnum for scale
            /// </summary>
            [EnumMember(Value = "scale")]
            ScaleEnum = 87,
            
            /// <summary>
            /// Enum ScalingModifyEnum for scaling_modify
            /// </summary>
            [EnumMember(Value = "scaling_modify")]
            ScalingModifyEnum = 88,
            
            /// <summary>
            /// Enum ScanStatusEnum for scan_status
            /// </summary>
            [EnumMember(Value = "scan_status")]
            ScanStatusEnum = 89,
            
            /// <summary>
            /// Enum SetAclEnum for set_acl
            /// </summary>
            [EnumMember(Value = "set_acl")]
            SetAclEnum = 90,
            
            /// <summary>
            /// Enum SetStorageModeEnum for set_storage_mode
            /// </summary>
            [EnumMember(Value = "set_storage_mode")]
            SetStorageModeEnum = 91,
            
            /// <summary>
            /// Enum SnapshotEnum for snapshot
            /// </summary>
            [EnumMember(Value = "snapshot")]
            SnapshotEnum = 92,
            
            /// <summary>
            /// Enum StartFailoverTestEnum for start_failover_test
            /// </summary>
            [EnumMember(Value = "start_failover_test")]
            StartFailoverTestEnum = 93,
            
            /// <summary>
            /// Enum StartMigrationSessionsEnum for start_migration_sessions
            /// </summary>
            [EnumMember(Value = "start_migration_sessions")]
            StartMigrationSessionsEnum = 94,
            
            /// <summary>
            /// Enum StartScanEnum for start_scan
            /// </summary>
            [EnumMember(Value = "start_scan")]
            StartScanEnum = 95,
            
            /// <summary>
            /// Enum StopFailoverTestEnum for stop_failover_test
            /// </summary>
            [EnumMember(Value = "stop_failover_test")]
            StopFailoverTestEnum = 96,
            
            /// <summary>
            /// Enum StopScanEnum for stop_scan
            /// </summary>
            [EnumMember(Value = "stop_scan")]
            StopScanEnum = 97,
            
            /// <summary>
            /// Enum SwitchModeToMetroSyncEnum for switch_mode_to_metro_sync
            /// </summary>
            [EnumMember(Value = "switch_mode_to_metro_sync")]
            SwitchModeToMetroSyncEnum = 98,
            
            /// <summary>
            /// Enum SwitchModeToSyncEnum for switch_mode_to_sync
            /// </summary>
            [EnumMember(Value = "switch_mode_to_sync")]
            SwitchModeToSyncEnum = 99,
            
            /// <summary>
            /// Enum SyncEnum for sync
            /// </summary>
            [EnumMember(Value = "sync")]
            SyncEnum = 100,
            
            /// <summary>
            /// Enum SyncNodeAffinityEnum for sync_node_affinity
            /// </summary>
            [EnumMember(Value = "sync_node_affinity")]
            SyncNodeAffinityEnum = 101,
            
            /// <summary>
            /// Enum SyncSnapshotEnum for sync_snapshot
            /// </summary>
            [EnumMember(Value = "sync_snapshot")]
            SyncSnapshotEnum = 102,
            
            /// <summary>
            /// Enum SyncTimeEnum for sync_time
            /// </summary>
            [EnumMember(Value = "sync_time")]
            SyncTimeEnum = 103,
            
            /// <summary>
            /// Enum SystemPauseEnum for system_pause
            /// </summary>
            [EnumMember(Value = "system_pause")]
            SystemPauseEnum = 104,
            
            /// <summary>
            /// Enum TestEnum for test
            /// </summary>
            [EnumMember(Value = "test")]
            TestEnum = 105,
            
            /// <summary>
            /// Enum TimeToFullEnum for time_to_full
            /// </summary>
            [EnumMember(Value = "time_to_full")]
            TimeToFullEnum = 106,
            
            /// <summary>
            /// Enum TryLockEnum for try_lock
            /// </summary>
            [EnumMember(Value = "try_lock")]
            TryLockEnum = 107,
            
            /// <summary>
            /// Enum UnjoinEnum for unjoin
            /// </summary>
            [EnumMember(Value = "unjoin")]
            UnjoinEnum = 108,
            
            /// <summary>
            /// Enum UnmountEnum for unmount
            /// </summary>
            [EnumMember(Value = "unmount")]
            UnmountEnum = 109,
            
            /// <summary>
            /// Enum UpdateDtsEnum for update_dts
            /// </summary>
            [EnumMember(Value = "update_dts")]
            UpdateDtsEnum = 110,
            
            /// <summary>
            /// Enum UpdatePropertiesEnum for update_properties
            /// </summary>
            [EnumMember(Value = "update_properties")]
            UpdatePropertiesEnum = 111,
            
            /// <summary>
            /// Enum UpdateSoftwareEnum for update_software
            /// </summary>
            [EnumMember(Value = "update_software")]
            UpdateSoftwareEnum = 112,
            
            /// <summary>
            /// Enum UpdateUserMappingsEnum for update_user_mappings
            /// </summary>
            [EnumMember(Value = "update_user_mappings")]
            UpdateUserMappingsEnum = 113,
            
            /// <summary>
            /// Enum UpgradeEnum for upgrade
            /// </summary>
            [EnumMember(Value = "upgrade")]
            UpgradeEnum = 114,
            
            /// <summary>
            /// Enum UploadEnum for upload
            /// </summary>
            [EnumMember(Value = "upload")]
            UploadEnum = 115,
            
            /// <summary>
            /// Enum UploadCertificateEnum for upload_certificate
            /// </summary>
            [EnumMember(Value = "upload_certificate")]
            UploadCertificateEnum = 116,
            
            /// <summary>
            /// Enum UploadConfigEnum for upload_config
            /// </summary>
            [EnumMember(Value = "upload_config")]
            UploadConfigEnum = 117,
            
            /// <summary>
            /// Enum UploadKeytabEnum for upload_keytab
            /// </summary>
            [EnumMember(Value = "upload_keytab")]
            UploadKeytabEnum = 118,
            
            /// <summary>
            /// Enum ValidateCreateEnum for validate_create
            /// </summary>
            [EnumMember(Value = "validate_create")]
            ValidateCreateEnum = 119,
            
            /// <summary>
            /// Enum ValidatePowerDownEnum for validate_power_down
            /// </summary>
            [EnumMember(Value = "validate_power_down")]
            ValidatePowerDownEnum = 120,
            
            /// <summary>
            /// Enum ValidateUpgradeEnum for validate_upgrade
            /// </summary>
            [EnumMember(Value = "validate_upgrade")]
            ValidateUpgradeEnum = 121,
            
            /// <summary>
            /// Enum VcenterCertificateRetrieveFactoryModeEnum for vcenter_certificate_retrieve_factory_mode
            /// </summary>
            [EnumMember(Value = "vcenter_certificate_retrieve_factory_mode")]
            VcenterCertificateRetrieveFactoryModeEnum = 122,
            
            /// <summary>
            /// Enum VcenterDiscoverEnum for vcenter_discover
            /// </summary>
            [EnumMember(Value = "vcenter_discover")]
            VcenterDiscoverEnum = 123,
            
            /// <summary>
            /// Enum VerifyEnum for verify
            /// </summary>
            [EnumMember(Value = "verify")]
            VerifyEnum = 124,
            
            /// <summary>
            /// Enum VerifyLocalEnum for verify_local
            /// </summary>
            [EnumMember(Value = "verify_local")]
            VerifyLocalEnum = 125,
            
            /// <summary>
            /// Enum VersionEnum for version
            /// </summary>
            [EnumMember(Value = "version")]
            VersionEnum = 126
        }
}
