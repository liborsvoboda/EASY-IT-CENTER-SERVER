using System;
using System.Collections.Generic;

namespace EasyITCenter.WebDBModel
{
    public partial class ServerExtensionList
    {
        public int Id { get; set; }
        public string DataType { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string Path { get; set; } = null!;
        public string Url { get; set; } = null!;
        public string? Description { get; set; }
        public string? CodeTemplate { get; set; }
        public string? Command { get; set; }
        public string? MdContent { get; set; }
        public int? Price { get; set; }
        public int Public { get; set; }
        public string UserId { get; set; } = null!;
        public bool Active { get; set; }
        public DateTime TimeStamp { get; set; }

        public virtual DataTypeList DataTypeNavigation { get; set; } = null!;
        public virtual AspNetUser User { get; set; } = null!;
    }
}
