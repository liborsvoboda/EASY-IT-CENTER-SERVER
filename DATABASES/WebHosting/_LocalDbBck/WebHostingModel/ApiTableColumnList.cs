using System;
using System.Collections.Generic;

namespace EasyITCenter.WebDBModel
{
    public partial class ApiTableColumnList
    {
        public int Id { get; set; }
        public string UserPrefix { get; set; } = null!;
        public string ApiTable { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public string? CodeTemplate { get; set; }
        public string Command { get; set; } = null!;
        public bool Public { get; set; }
        public bool Active { get; set; }
        public string UserId { get; set; } = null!;
        public DateTime TimeStamp { get; set; }

        public virtual ApiTableList ApiTableNavigation { get; set; } = null!;
        public virtual AspNetUser User { get; set; } = null!;
        public virtual AspNetUser UserPrefixNavigation { get; set; } = null!;
    }
}
