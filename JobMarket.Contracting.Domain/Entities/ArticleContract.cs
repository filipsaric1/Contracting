using System;
using System.Collections.Generic;
using System.Text;

namespace JobMarket.Contracting.Domain.Entities
{
    public class ArticleContract
    {
        public int ArticleId { get; set; }
        public Article Article { get; set; }
        public int ContractId { get; set; }
        public Contract Contract { get; set; }
        public string Data { get; set; }
    }
}
