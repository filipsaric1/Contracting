using System;
using System.Collections.Generic;
using System.Text;

namespace JobMarket.Contracting.Domain.Entities
{
    public enum ContractState 
    {
        Signed,
        UnSigned,
        Done
    }
    public class Contract: BaseEntity
    {

        public int ClientId { get; set; }
        public int ExecutorId { get; set; }
        public int OfferId { get; set; }
        public bool IsSignedByClient { get; set;}
        public bool IsSignedByExecutor { get; set; }
        public ContractState State { get; set; }
        public DateTime SignedAt { get; set; }
        public ICollection<ArticleContract> ArticleContracts { get; set; }
        public Contract Annex { get; set; }

    }
}
