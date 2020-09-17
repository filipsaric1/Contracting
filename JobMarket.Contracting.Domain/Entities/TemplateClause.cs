using System;
using System.Collections.Generic;
using System.Text;

namespace JobMarket.Contracting.Domain.Entities
{
    public class TemplateClause : BaseEntity
    {
        public int TemplateId { get; set; }
        public Template Template { get; set; }
        public int ClauseId { get; set; }
        public Clause Clause { get; set; }
    }
}
