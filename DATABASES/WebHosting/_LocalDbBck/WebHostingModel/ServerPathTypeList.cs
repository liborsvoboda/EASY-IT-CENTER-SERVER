﻿using System;
using System.Collections.Generic;

namespace EasyITCenter.WebDBModel
{
    public partial class ServerPathTypeList
    {
        public ServerPathTypeList()
        {
            ServerPathLists = new HashSet<ServerPathList>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public string? CodeTemplate { get; set; }
        public string? Command { get; set; }
        public bool Public { get; set; }
        public bool Active { get; set; }
        public string UserId { get; set; } = null!;
        public DateTime TimeStamp { get; set; }

        public virtual AspNetUser User { get; set; } = null!;
        public virtual ICollection<ServerPathList> ServerPathLists { get; set; }
    }
}