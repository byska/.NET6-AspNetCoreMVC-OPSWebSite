﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ops.Core.Entities
{
    public class Color : BaseEntity
    {
        public string Name { get; set; }
        public Stock Stock { get; set; }
        public ICollection<Photo> Photos { get; set; }
      


        public Color()
        {
            Photos=new HashSet<Photo>();
        }

    }
}
