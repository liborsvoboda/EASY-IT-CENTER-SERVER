using System;
using System.Collections.Generic;

namespace EasyITCenter.WebDBModel
{
    public partial class UserMessageList
    {
        public int Id { get; set; }
        public string? TableName { get; set; }
        public string? Subject { get; set; }
        public string? MailTo { get; set; }
        public string? Content { get; set; }
        public bool Public { get; set; }
        public string UserId { get; set; } = null!;
        public bool Active { get; set; }
        public DateTime TimeStamp { get; set; }

        public virtual AspNetUser User { get; set; } = null!;
    }
}
