using System;
using System.Collections.Generic;

namespace EasyITCenter.WebDBModel
{
    public partial class DataHistoryList
    {
        public int Id { get; set; }
        public string TableName { get; set; } = null!;
        public string DataType { get; set; } = null!;
        public string Value { get; set; } = null!;
        public string? UserId { get; set; }
        public DateTime TimeStamp { get; set; }

        public virtual DataTypeList DataTypeNavigation { get; set; } = null!;
        public virtual AspNetUser? User { get; set; }
    }
}
