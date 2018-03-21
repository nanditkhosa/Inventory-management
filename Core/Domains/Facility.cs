﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domains
{
    public class Facility : BaseEntity
    {
        public int? UserId { get; set; }
        public int? AssetId { get; set; }
        public string Name { get; set; }
        public string Landmark { get; set; }
        public string Address { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public bool IsActive { get; set; }

        public virtual User User { get; set; }
        public virtual Asset Asset { get; set; }
    }
}
