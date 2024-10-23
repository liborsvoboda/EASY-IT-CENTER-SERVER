using System;
using System.Collections.Generic;

namespace EasyITCenter.WebDBModel
{
    public partial class GeneratorTypeList
    {
        public GeneratorTypeList()
        {
            GeneratedDataLists = new HashSet<GeneratedDataList>();
            GeneratorLists = new HashSet<GeneratorList>();
        }

        public int Id { get; set; }
        public string? ActionType { get; set; }
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public string? CodeTemplate { get; set; }
        public string? Command { get; set; }
        public bool Public { get; set; }
        public bool Active { get; set; }
        public string UserId { get; set; } = null!;
        public DateTime TimeStamp { get; set; }

        public virtual ActionTypeList? ActionTypeNavigation { get; set; }
        public virtual AspNetUser User { get; set; } = null!;
        public virtual ICollection<GeneratedDataList> GeneratedDataLists { get; set; }
        public virtual ICollection<GeneratorList> GeneratorLists { get; set; }
    }
}
