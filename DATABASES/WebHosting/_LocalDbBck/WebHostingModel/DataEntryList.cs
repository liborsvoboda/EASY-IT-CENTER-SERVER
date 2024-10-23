using System;
using System.Collections.Generic;

namespace EasyITCenter.WebDBModel
{
    public partial class DataEntryList
    {
        public int Id { get; set; }
        public string? DataType { get; set; }
        public string? Name { get; set; }
        public string? Value { get; set; }
        public string? Description { get; set; }
        public bool Public { get; set; }
        public bool Active { get; set; }
        public string UserId { get; set; } = null!;
        public DateTime TimeStamp { get; set; }

        public virtual DataTypeList? DataTypeNavigation { get; set; }
        public virtual AspNetUser User { get; set; } = null!;
    }
}
