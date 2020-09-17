using System;
using System.Collections.Generic;
using System.Text;

namespace JobMarket.Contracting.Domain.Entities
{
    public class Article : BaseEntity
    {
        public string Content { get; set; }
        public ICollection<ArticleContract> ArticleContracts { get; set; }
    }
}
