using System;
using System.Collections.Generic;

namespace EasyITCenter.WebDBModel
{
    public partial class DataTypeList
    {
        public DataTypeList()
        {
            DataEntryLists = new HashSet<DataEntryList>();
            DataHistoryLists = new HashSet<DataHistoryList>();
            DeveloperToolLists = new HashSet<DeveloperToolList>();
            GeneratedDataLists = new HashSet<GeneratedDataList>();
            HelpGroupLists = new HashSet<HelpGroupList>();
            ServerExtensionLists = new HashSet<ServerExtensionList>();
            ServerPathLists = new HashSet<ServerPathList>();
            ServerScriptLists = new HashSet<ServerScriptList>();
            SharedPathLists = new HashSet<SharedPathList>();
            UserParamLists = new HashSet<UserParamList>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public string? ActionName { get; set; }
        public string? CodeTemplate { get; set; }
        public string? Command { get; set; }
        public bool Public { get; set; }
        public bool Active { get; set; }
        public string UserId { get; set; } = null!;
        public DateTime TimeStamp { get; set; }

        public virtual AspNetUser User { get; set; } = null!;
        public virtual ICollection<DataEntryList> DataEntryLists { get; set; }
        public virtual ICollection<DataHistoryList> DataHistoryLists { get; set; }
        public virtual ICollection<DeveloperToolList> DeveloperToolLists { get; set; }
        public virtual ICollection<GeneratedDataList> GeneratedDataLists { get; set; }
        public virtual ICollection<HelpGroupList> HelpGroupLists { get; set; }
        public virtual ICollection<ServerExtensionList> ServerExtensionLists { get; set; }
        public virtual ICollection<ServerPathList> ServerPathLists { get; set; }
        public virtual ICollection<ServerScriptList> ServerScriptLists { get; set; }
        public virtual ICollection<SharedPathList> SharedPathLists { get; set; }
        public virtual ICollection<UserParamList> UserParamLists { get; set; }
    }
}
