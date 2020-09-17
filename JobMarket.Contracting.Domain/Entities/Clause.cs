using System;
using System.Collections.Generic;
using System.Text;

namespace JobMarket.Contracting.Domain.Entities
{
   public class Clause : BaseEntity
    {
        public string Name { get; set; }
        public ICollection<Article> Articles { get; set; }
        public ICollection<TemplateClause> TemplateClauses { get; set; }
    }
}
