using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EasyITCenter.DBModel
{
    [Keyless]
    public partial class GetNewId
    {
        [Column("new_id")]
        public Guid? NewId { get; set; }
    }
}
