using System;
using System.Collections.Generic;
using System.Text;

namespace JobMarket.Contracting.Domain.Entities
{
    public class Placeholder : BaseEntity
    {
        public string Name { get; set; }
        public int Location { get; set; }
        public Article Article { get; set; }

    }
}
