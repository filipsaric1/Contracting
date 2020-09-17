using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JobMarket.Contracting.Domain.Entities;
using JobMarket.Contracting.Persistence.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JobMarket.Contracting.API.Controllers
{
    [Route("api/[controller]")]
    [Authorize(Roles = "ADMINISTRATOR,CLIENT,EXECUTOR")]
    [ApiController]
    public class ArticleContractController : ControllerBase
    {
        private readonly ArticleContractRepository _articleContractRepository;
        public ArticleContractController(ArticleContractRepository articleContractRepository)
        {
            _articleContractRepository = articleContractRepository;
        }
        [HttpGet]
        [HttpGet]
        public ActionResult<List<ArticleContract>> GetArticleContracts()
        {
            var articleContracts = _articleContractRepository.Query().ToList();

            if (articleContracts == null)
            {
                return NotFound();
            }

            return Ok(articleContracts);
        }

        [HttpGet("{id:int}")]
        public ActionResult<ArticleContract> GetArticleContract(int id)
        {
            var articleContract = _articleContractRepository.Single(id);

            if (articleContract == null)
            {
                return NotFound();
            }

            return Ok(articleContract);
        }
        //[HttpPost]
        //public async Task<IActionResult> Create(ArticleContract articleContract)
        //{
        //    if (articleContract == null)
        //    {
        //        return BadRequest();
        //    }

        //    _articleContractRepository.Persist(articleContract);
        //    await _articleContractRepository.FlushAsync();

        //    return CreatedAtAction(nameof(GetArticleContract), new { id = articleContract.Id }, articleContract);
        //}
        //[HttpPut("{id:int}")]
        //public async Task<IActionResult> Update(int id, ArticleContract updatedArticleContract)
        //{
        //    if (id != updatedArticleContract.Id)
        //    {
        //        return BadRequest();
        //    }
        //    var articleContract = _articleContractRepository.Single(id);
        //    if (articleContract == null)
        //    {
        //        return NotFound();
        //    }
        //    if (articleContract.Contract.State == ContractState.Done || articleContract.Contract.State == ContractState.Signed)
        //    {
        //        return BadRequest();
        //    }
        //    _articleContractRepository.Update(updatedArticleContract);
        //    return NoContent();
        //}
      
    }
}