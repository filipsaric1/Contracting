using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace JobMarket.Contracting.Domain.Models
{
    public class ArticleDTO
    {
        public int Id { get; set; }
        [Required]
        public string Content { get; set; }
        public int ClauseId { get; set; }
    }
}
