using System;
using System.Collections.Generic;

namespace EasyITCenter.WebDBModel
{
    public partial class SharedPathList
    {
        public int Id { get; set; }
        public string? DataType { get; set; }
        public string? Path { get; set; }
        public string SharedUserId { get; set; } = null!;
        public string UserId { get; set; } = null!;
        public bool Active { get; set; }
        public DateTime TimeStamp { get; set; }

        public virtual DataTypeList? DataTypeNavigation { get; set; }
        public virtual AspNetUser User { get; set; } = null!;
    }
}
