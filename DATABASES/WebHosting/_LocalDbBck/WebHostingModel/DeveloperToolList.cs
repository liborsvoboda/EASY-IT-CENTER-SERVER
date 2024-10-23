using System;
using System.Collections.Generic;

namespace EasyITCenter.WebDBModel
{
    public partial class DeveloperToolList
    {
        public int Id { get; set; }
        public string? DataType { get; set; }
        public string? Name { get; set; }
        public string ToolUrl { get; set; } = null!;
        public string? Script { get; set; }
        public string? Description { get; set; }
        public int? Price { get; set; }
        public bool Public { get; set; }
        public string UserId { get; set; } = null!;
        public bool Active { get; set; }
        public DateTime TimeStamp { get; set; }

        public virtual DataTypeList? NameNavigation { get; set; }
        public virtual AspNetUser User { get; set; } = null!;
    }
}
