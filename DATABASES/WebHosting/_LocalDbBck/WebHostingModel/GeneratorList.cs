using System;
using System.Collections.Generic;

namespace EasyITCenter.WebDBModel
{
    public partial class GeneratorList
    {
        public int Id { get; set; }
        public string UserPrefix { get; set; } = null!;
        public string GeneratorType { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string? Content { get; set; }
        public string? Description { get; set; }
        public bool Public { get; set; }
        public string? CodeTemplate { get; set; }
        public string? Script { get; set; }
        public string? Command { get; set; }
        public string? PostCommand { get; set; }
        public string UserId { get; set; } = null!;
        public bool Active { get; set; }
        public DateTime TimeStamp { get; set; }

        public virtual GeneratorTypeList GeneratorTypeNavigation { get; set; } = null!;
        public virtual AspNetUser User { get; set; } = null!;
    }
}
