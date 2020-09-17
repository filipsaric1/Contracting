using System;
using System.Collections.Generic;
using System.Text;

namespace JobMarket.Contracting.Domain.Entities
{
    public class Template : BaseEntity
    {
        public string Name { get; set; }
        public ICollection<Contract> Contracts { get; set; }
        public ICollection<TemplateClause> TemplateClauses { get; set; }

    }
}
