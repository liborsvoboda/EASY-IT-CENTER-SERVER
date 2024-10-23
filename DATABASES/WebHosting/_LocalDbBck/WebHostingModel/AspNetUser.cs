using System;
using System.Collections.Generic;

namespace EasyITCenter.WebDBModel
{
    public partial class AspNetUser
    {
        public AspNetUser()
        {
            ActionHistoryLists = new HashSet<ActionHistoryList>();
            ActionTypeLists = new HashSet<ActionTypeList>();
            ApiTableColumnDataListUserPrefixNavigations = new HashSet<ApiTableColumnDataList>();
            ApiTableColumnDataListUsers = new HashSet<ApiTableColumnDataList>();
            ApiTableColumnListUserPrefixNavigations = new HashSet<ApiTableColumnList>();
            ApiTableColumnListUsers = new HashSet<ApiTableColumnList>();
            ApiTableListUserPrefixNavigations = new HashSet<ApiTableList>();
            ApiTableListUsers = new HashSet<ApiTableList>();
            AspNetUserClaims = new HashSet<AspNetUserClaim>();
            AspNetUserLogins = new HashSet<AspNetUserLogin>();
            AspNetUserTokens = new HashSet<AspNetUserToken>();
            DataEntryLists = new HashSet<DataEntryList>();
            DataHistoryLists = new HashSet<DataHistoryList>();
            DataTypeLists = new HashSet<DataTypeList>();
            DeveloperToolLists = new HashSet<DeveloperToolList>();
            GeneratedDataListUserPrefixNavigations = new HashSet<GeneratedDataList>();
            GeneratedDataListUsers = new HashSet<GeneratedDataList>();
            GeneratorLists = new HashSet<GeneratorList>();
            GeneratorTypeLists = new HashSet<GeneratorTypeList>();
            HelpDataLists = new HashSet<HelpDataList>();
            HelpGroupLists = new HashSet<HelpGroupList>();
            ParamTypeListUserPrefixNavigations = new HashSet<ParamTypeList>();
            ParamTypeListUsers = new HashSet<ParamTypeList>();
            ServerExtensionLists = new HashSet<ServerExtensionList>();
            ServerPathLists = new HashSet<ServerPathList>();
            ServerPathTypeLists = new HashSet<ServerPathTypeList>();
            ServerScriptLists = new HashSet<ServerScriptList>();
            SharedPathLists = new HashSet<SharedPathList>();
            UserCommentLists = new HashSet<UserCommentList>();
            UserMessageLists = new HashSet<UserMessageList>();
            UserParamLists = new HashSet<UserParamList>();
        }

        public string Id { get; set; } = null!;
        public string? UserName { get; set; }
        public string? NormalizedUserName { get; set; }
        public string? Email { get; set; }
        public string? NormalizedEmail { get; set; }
        public bool EmailConfirmed { get; set; }
        public string? PasswordHash { get; set; }
        public string? SecurityStamp { get; set; }
        public string? ConcurrencyStamp { get; set; }
        public string? PhoneNumber { get; set; }
        public bool PhoneNumberConfirmed { get; set; }
        public bool TwoFactorEnabled { get; set; }
        public DateTimeOffset? LockoutEnd { get; set; }
        public bool LockoutEnabled { get; set; }
        public int AccessFailedCount { get; set; }
        public string DbPrefix { get; set; } = null!;

        public virtual ICollection<ActionHistoryList> ActionHistoryLists { get; set; }
        public virtual ICollection<ActionTypeList> ActionTypeLists { get; set; }
        public virtual ICollection<ApiTableColumnDataList> ApiTableColumnDataListUserPrefixNavigations { get; set; }
        public virtual ICollection<ApiTableColumnDataList> ApiTableColumnDataListUsers { get; set; }
        public virtual ICollection<ApiTableColumnList> ApiTableColumnListUserPrefixNavigations { get; set; }
        public virtual ICollection<ApiTableColumnList> ApiTableColumnListUsers { get; set; }
        public virtual ICollection<ApiTableList> ApiTableListUserPrefixNavigations { get; set; }
        public virtual ICollection<ApiTableList> ApiTableListUsers { get; set; }
        public virtual ICollection<AspNetUserClaim> AspNetUserClaims { get; set; }
        public virtual ICollection<AspNetUserLogin> AspNetUserLogins { get; set; }
        public virtual ICollection<AspNetUserToken> AspNetUserTokens { get; set; }
        public virtual ICollection<DataEntryList> DataEntryLists { get; set; }
        public virtual ICollection<DataHistoryList> DataHistoryLists { get; set; }
        public virtual ICollection<DataTypeList> DataTypeLists { get; set; }
        public virtual ICollection<DeveloperToolList> DeveloperToolLists { get; set; }
        public virtual ICollection<GeneratedDataList> GeneratedDataListUserPrefixNavigations { get; set; }
        public virtual ICollection<GeneratedDataList> GeneratedDataListUsers { get; set; }
        public virtual ICollection<GeneratorList> GeneratorLists { get; set; }
        public virtual ICollection<GeneratorTypeList> GeneratorTypeLists { get; set; }
        public virtual ICollection<HelpDataList> HelpDataLists { get; set; }
        public virtual ICollection<HelpGroupList> HelpGroupLists { get; set; }
        public virtual ICollection<ParamTypeList> ParamTypeListUserPrefixNavigations { get; set; }
        public virtual ICollection<ParamTypeList> ParamTypeListUsers { get; set; }
        public virtual ICollection<ServerExtensionList> ServerExtensionLists { get; set; }
        public virtual ICollection<ServerPathList> ServerPathLists { get; set; }
        public virtual ICollection<ServerPathTypeList> ServerPathTypeLists { get; set; }
        public virtual ICollection<ServerScriptList> ServerScriptLists { get; set; }
        public virtual ICollection<SharedPathList> SharedPathLists { get; set; }
        public virtual ICollection<UserCommentList> UserCommentLists { get; set; }
        public virtual ICollection<UserMessageList> UserMessageLists { get; set; }
        public virtual ICollection<UserParamList> UserParamLists { get; set; }
    }
}
