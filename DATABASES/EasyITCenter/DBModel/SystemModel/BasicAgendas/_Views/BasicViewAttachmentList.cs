using System;
using System.Collections.Generic;
using FrameworkCore = Microsoft.EntityFrameworkCore;

namespace EasyITCenter.DBModel
{
    
    public partial class BasicViewAttachmentList
    {
        public int Id { get; set; }
        [StringLength(150)]
        [FrameworkCore.Unicode(false)]
        public string FileName { get; set; } = null!;
        [StringLength(50)]
        [FrameworkCore.Unicode(false)]
        public string? PartNumber { get; set; }
        public DateTime TimeStamp { get; set; }
    }
}
