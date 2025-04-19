using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EasyITCenter.DBModel
{
    [Table("SolutionMixedEnumList")]
    [Index("ItemsGroup", "Name", Name = "IX_GlobalMixedEnumList", IsUnique = true)]
    [Index("ItemsGroup", Name = "IX_SolutionMixedEnumList")]
    [Index("Name", Name = "IX_SolutionMixedEnumList_1", IsUnique = true)]
    public partial class SolutionMixedEnumList
    {
        public SolutionMixedEnumList()
        {
            DocSrvDocTemplateLists = new HashSet<DocSrvDocTemplateList>();
            PortalGeneratorActionLists = new HashSet<PortalGeneratorActionList>();
            PortalPluginListInheritedCodeTypeNavigations = new HashSet<PortalPluginList>();
            PortalPluginListInheritedPluginTypeNavigations = new HashSet<PortalPluginList>();
            ServerApiSecurityLists = new HashSet<ServerApiSecurityList>();
            ServerHealthCheckTaskLists = new HashSet<ServerHealthCheckTaskList>();
            ServerModuleAndServiceListInheritedLayoutTypeNavigations = new HashSet<ServerModuleAndServiceList>();
            ServerModuleAndServiceListInheritedPageTypeNavigations = new HashSet<ServerModuleAndServiceList>();
            ServerParameterLists = new HashSet<ServerParameterList>();
            ServerProcessListInheritedCommandTypeNavigations = new HashSet<ServerProcessList>();
            ServerProcessListInheritedProcessTypeNavigations = new HashSet<ServerProcessList>();
            ServerSettingLists = new HashSet<ServerSettingList>();
            ServerToolPanelDefinitionLists = new HashSet<ServerToolPanelDefinitionList>();
            SolutionFailLists = new HashSet<SolutionFailList>();
            SolutionOperationListInheritedApiResultTypeNavigations = new HashSet<SolutionOperationList>();
            SolutionOperationListInheritedOperationTypeNavigations = new HashSet<SolutionOperationList>();
            SolutionSchedulerListInheritedGroupNameNavigations = new HashSet<SolutionSchedulerList>();
            SolutionSchedulerListInheritedIntervalTypeNavigations = new HashSet<SolutionSchedulerList>();
            SolutionTaskListInheritedStatusTypeNavigations = new HashSet<SolutionTaskList>();
            SolutionTaskListInheritedTargetTypeNavigations = new HashSet<SolutionTaskList>();
            SystemCustomPageListInheritedFormTypeNavigations = new HashSet<SystemCustomPageList>();
            SystemCustomPageListInheritedSystemApiCallTypeNavigations = new HashSet<SystemCustomPageList>();
            SystemDocumentAdviceLists = new HashSet<SystemDocumentAdviceList>();
            SystemMenuLists = new HashSet<SystemMenuList>();
            SystemModuleLists = new HashSet<SystemModuleList>();
            UserAccessKeyLists = new HashSet<UserAccessKeyList>();
            UserDbManagementLists = new HashSet<UserDbManagementList>();
            UserParameterLists = new HashSet<UserParameterList>();
            WebCodeLibraryLists = new HashSet<WebCodeLibraryList>();
            WebCoreFileLists = new HashSet<WebCoreFileList>();
            WebGlobalPageBlockLists = new HashSet<WebGlobalPageBlockList>();
        }

        [Key]
        public int Id { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string ItemsGroup { get; set; } = null!;
        [StringLength(50)]
        [Unicode(false)]
        public string Name { get; set; } = null!;
        [Unicode(false)]
        public string? Description { get; set; }
        public int UserId { get; set; }
        public bool Active { get; set; }
        public DateTime TimeStamp { get; set; }

        [ForeignKey("UserId")]
        [InverseProperty("SolutionMixedEnumLists")]
        public virtual SolutionUserList User { get; set; } = null!;
        public virtual ICollection<DocSrvDocTemplateList> DocSrvDocTemplateLists { get; set; }
        public virtual ICollection<PortalGeneratorActionList> PortalGeneratorActionLists { get; set; }
        public virtual ICollection<PortalPluginList> PortalPluginListInheritedCodeTypeNavigations { get; set; }
        public virtual ICollection<PortalPluginList> PortalPluginListInheritedPluginTypeNavigations { get; set; }
        public virtual ICollection<ServerApiSecurityList> ServerApiSecurityLists { get; set; }
        public virtual ICollection<ServerHealthCheckTaskList> ServerHealthCheckTaskLists { get; set; }
        public virtual ICollection<ServerModuleAndServiceList> ServerModuleAndServiceListInheritedLayoutTypeNavigations { get; set; }
        public virtual ICollection<ServerModuleAndServiceList> ServerModuleAndServiceListInheritedPageTypeNavigations { get; set; }
        public virtual ICollection<ServerParameterList> ServerParameterLists { get; set; }
        public virtual ICollection<ServerProcessList> ServerProcessListInheritedCommandTypeNavigations { get; set; }
        public virtual ICollection<ServerProcessList> ServerProcessListInheritedProcessTypeNavigations { get; set; }
        public virtual ICollection<ServerSettingList> ServerSettingLists { get; set; }
        public virtual ICollection<ServerToolPanelDefinitionList> ServerToolPanelDefinitionLists { get; set; }
        public virtual ICollection<SolutionFailList> SolutionFailLists { get; set; }
        public virtual ICollection<SolutionOperationList> SolutionOperationListInheritedApiResultTypeNavigations { get; set; }
        public virtual ICollection<SolutionOperationList> SolutionOperationListInheritedOperationTypeNavigations { get; set; }
        public virtual ICollection<SolutionSchedulerList> SolutionSchedulerListInheritedGroupNameNavigations { get; set; }
        public virtual ICollection<SolutionSchedulerList> SolutionSchedulerListInheritedIntervalTypeNavigations { get; set; }
        public virtual ICollection<SolutionTaskList> SolutionTaskListInheritedStatusTypeNavigations { get; set; }
        public virtual ICollection<SolutionTaskList> SolutionTaskListInheritedTargetTypeNavigations { get; set; }
        public virtual ICollection<SystemCustomPageList> SystemCustomPageListInheritedFormTypeNavigations { get; set; }
        public virtual ICollection<SystemCustomPageList> SystemCustomPageListInheritedSystemApiCallTypeNavigations { get; set; }
        public virtual ICollection<SystemDocumentAdviceList> SystemDocumentAdviceLists { get; set; }
        public virtual ICollection<SystemMenuList> SystemMenuLists { get; set; }
        public virtual ICollection<SystemModuleList> SystemModuleLists { get; set; }
        public virtual ICollection<UserAccessKeyList> UserAccessKeyLists { get; set; }
        public virtual ICollection<UserDbManagementList> UserDbManagementLists { get; set; }
        public virtual ICollection<UserParameterList> UserParameterLists { get; set; }
        public virtual ICollection<WebCodeLibraryList> WebCodeLibraryLists { get; set; }
        public virtual ICollection<WebCoreFileList> WebCoreFileLists { get; set; }
        public virtual ICollection<WebGlobalPageBlockList> WebGlobalPageBlockLists { get; set; }
    }
}
