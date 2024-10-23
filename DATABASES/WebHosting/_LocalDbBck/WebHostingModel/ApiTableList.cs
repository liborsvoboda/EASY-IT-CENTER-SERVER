using System;
using System.Collections.Generic;

namespace EasyITCenter.WebDBModel
{
    public partial class ApiTableList
    {
        public ApiTableList()
        {
            ApiTableColumnDataLists = new HashSet<ApiTableColumnDataList>();
            ApiTableColumnLists = new HashSet<ApiTableColumnList>();
        }

        public int Id { get; set; }
        public string? UserPrefix { get; set; }
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public string? CodeTemplate { get; set; }
        public string Command { get; set; } = null!;
        public bool Public { get; set; }
        public bool Active { get; set; }
        public string UserId { get; set; } = null!;
        public DateTime TimeStamp { get; set; }

        public virtual AspNetUser User { get; set; } = null!;
        public virtual AspNetUser? UserPrefixNavigation { get; set; }
        public virtual ICollection<ApiTableColumnDataList> ApiTableColumnDataLists { get; set; }
        public virtual ICollection<ApiTableColumnList> ApiTableColumnLists { get; set; }
    }
}
