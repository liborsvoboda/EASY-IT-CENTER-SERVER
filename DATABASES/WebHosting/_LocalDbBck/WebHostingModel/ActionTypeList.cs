using System;
using System.Collections.Generic;

namespace EasyITCenter.WebDBModel
{
    public partial class ActionTypeList
    {
        public ActionTypeList()
        {
            ActionHistoryLists = new HashSet<ActionHistoryList>();
            GeneratorTypeLists = new HashSet<GeneratorTypeList>();
            ParamTypeLists = new HashSet<ParamTypeList>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public string? CodeTemplate { get; set; }
        public string Command { get; set; } = null!;
        public bool Public { get; set; }
        public bool Active { get; set; }
        public string UserId { get; set; } = null!;
        public DateTime TimeStamp { get; set; }

        public virtual AspNetUser User { get; set; } = null!;
        public virtual ICollection<ActionHistoryList> ActionHistoryLists { get; set; }
        public virtual ICollection<GeneratorTypeList> GeneratorTypeLists { get; set; }
        public virtual ICollection<ParamTypeList> ParamTypeLists { get; set; }
    }
}
