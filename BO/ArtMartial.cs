﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class ArtMartial
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Samourai>? Samourais { get; set; }
    }
}
