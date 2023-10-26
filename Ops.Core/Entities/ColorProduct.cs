﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ops.Core.Entities
{
    public class ColorProduct:BaseEntity
    {
        public int ColorId { get; set; }
        public Color Color { get; set; }
        public int ProductId { get; set; }
        public Product   Product { get; set; }
    }
}
