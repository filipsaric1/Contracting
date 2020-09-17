using System;
using System.Collections.Generic;
using System.Text;

namespace JobMarket.Contracting.Domain.Models
{
    public class ArticleContractDTO
    {
        public int ArticleId { get; set; }
        public int ContractId { get; set; }
        public string Data { get; set; }
    }
}
