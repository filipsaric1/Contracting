using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace JobMarket.Contracting.Domain.Models
{
    public class TemplateClauseDTO
    {
        public int TemplateId { get; set; }
        [Required]
        public int ClauseId { get; set; }
    }
}
