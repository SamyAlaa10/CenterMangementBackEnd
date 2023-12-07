﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenterMangement.Core.Entities
{
    public class RelPermeationUser:BaseEntity
    {
        public long IdUser { get; set; }
        public User UserNavigation { get; set; }
        public long IdPermeation { get; set; }
        public Permeation PermeationNavigation { get; set; }
    }
}
