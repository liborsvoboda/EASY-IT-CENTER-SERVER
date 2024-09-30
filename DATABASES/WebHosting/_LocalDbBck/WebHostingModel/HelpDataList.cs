using System;
using System.Collections.Generic;

namespace EasyITCenter.WebDBModel
{
    public partial class HelpDataList
    {
        public int Id { get; set; }
        public string? DataType { get; set; }
        public string? Name { get; set; }
        public string? MdContent { get; set; }
        public string? HtmlContent { get; set; }
        public string? Description { get; set; }
        public string GithubUrl { get; set; } = null!;
        public bool Public { get; set; }
        public string UserId { get; set; } = null!;
        public bool Active { get; set; }
        public DateTime TimeStamp { get; set; }
        public string CodeTemplate { get; set; } = null!;
        public string? Command { get; set; }

        public virtual AspNetUser User { get; set; } = null!;
    }
}
