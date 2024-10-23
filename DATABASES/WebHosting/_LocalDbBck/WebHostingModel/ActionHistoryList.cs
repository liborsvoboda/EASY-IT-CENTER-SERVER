using System;
using System.Collections.Generic;

namespace EasyITCenter.WebDBModel
{
    public partial class ActionHistoryList
    {
        public int Id { get; set; }
        public string ActionType { get; set; } = null!;
        public string? DataType { get; set; }
        public string Value { get; set; } = null!;
        public string? UserId { get; set; }
        public DateTime TimeStamp { get; set; }

        public virtual ActionTypeList ActionTypeNavigation { get; set; } = null!;
        public virtual AspNetUser? User { get; set; }
    }
}
