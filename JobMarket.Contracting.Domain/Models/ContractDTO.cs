using JobMarket.Contracting.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace JobMarket.Contracting.Domain.Models
{
    public class ContractDTO
    {
        public int Id { get; set; }
        [Required]
        public string ClientId { get; set; }
        public string ExecutorId { get; set; }
        [Required]
        public int OfferId { get; set; }
        public bool IsSignedByClient { get; set; }
        public bool IsSignedByExecutor { get; set; }
        public ContractState State { get; set; }
        public Nullable<DateTime> SignedAt { get; set; }
        public ICollection<ArticleContractDTO> ArticleContracts { get; set; }
        public ContractDTO? Annex { get; set; }
        public int TemplateId { get; set; }
        public bool IsAnnex { get; set; }
    }
}
