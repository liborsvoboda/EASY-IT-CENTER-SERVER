using System;
using System.Collections.Generic;

namespace EasyITCenter.WebDBModel
{
    public partial class UserParamList
    {
        public int Id { get; set; }
        public string? UserPrefix { get; set; }
        public string ParamType { get; set; } = null!;
        public string DataType { get; set; } = null!;
        public string Key { get; set; } = null!;
        public string Value { get; set; } = null!;
        public string? Description { get; set; }
        public string? CodeTemplate { get; set; }
        public bool Active { get; set; }
        public string User { get; set; } = null!;
        public DateTime TimeStamp { get; set; }

        public virtual DataTypeList DataTypeNavigation { get; set; } = null!;
        public virtual AspNetUser UserNavigation { get; set; } = null!;
    }
}
