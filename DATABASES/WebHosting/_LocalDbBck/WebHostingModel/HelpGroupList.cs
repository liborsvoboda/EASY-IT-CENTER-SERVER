using System;
using System.Collections.Generic;

namespace EasyITCenter.WebDBModel
{
    public partial class HelpGroupList
    {
        public int Id { get; set; }
        public string DataType { get; set; } = null!;
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? GithubUrl { get; set; }
        public string? MdContent { get; set; }
        public bool Public { get; set; }
        public bool Active { get; set; }
        public string User { get; set; } = null!;
        public DateTime TimeStamp { get; set; }

        public virtual DataTypeList DataTypeNavigation { get; set; } = null!;
        public virtual AspNetUser UserNavigation { get; set; } = null!;
    }
}
