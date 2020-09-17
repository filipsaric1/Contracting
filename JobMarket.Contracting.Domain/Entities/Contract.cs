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

        public string ClientId { get; set; }
        public string ExecutorId { get; set; }
        public int OfferId { get; set; }
        public bool IsSignedByClient { get; set;}
        public bool IsSignedByExecutor { get; set; }
        public ContractState State { get; set; }
        public Nullable<DateTime> SignedAt { get; set; }
        public ICollection<ArticleContract> ArticleContracts { get; set; }
        public Contract? Annex { get; set; }
        public int? AnnexId { get; set; }
        public int TemplateId { get; set; }
        public Template Template { get; set; }
        public bool IsAnnex { get; set; }

    }
}
