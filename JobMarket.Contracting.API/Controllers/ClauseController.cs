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
    [ApiController]
    
    public class ClauseController : ControllerBase
    {
        private readonly ClauseRepository _clauseRepository;
        private readonly TemplateClauseRepository _templateClauseRepository;
        private readonly TemplateRepository _templateRepository;

        public ClauseController(ClauseRepository clauseRepository,TemplateRepository templateRepository, TemplateClauseRepository templateClauseRepository)
        {
            _clauseRepository = clauseRepository;
            _templateClauseRepository = templateClauseRepository;
            _templateRepository = templateRepository;
        }
        [Authorize(Roles = "ADMINISTRATOR,EXECUTOR,CLIENT")]
        [HttpGet]
        public ActionResult<List<Clause>> GetClauses()
        {
            var clauses = _clauseRepository.Query().ToList();

            if (clauses == null)
            {
                return NotFound();
            }

            return Ok(clauses);
        }
        [Authorize(Roles = "ADMINISTRATOR,EXECUTOR,CLIENT")]
        [HttpGet("{id:int}")]
        public ActionResult<Template> GetClauseDetails(int id)
        {
            var clause = _clauseRepository.ClauseDetails(id);

            if (clause == null)
            {
                return NotFound();
            }

            return Ok(clause);
        }
        [Authorize(Roles = "ADMINISTRATOR")]
        [HttpPost]
        public async Task<IActionResult> Create(Clause clause)
        {
            if (clause == null)
            {
                return BadRequest();
            }
            _clauseRepository.Persist(clause);
            await _clauseRepository.FlushAsync();
            var template = _templateRepository.Query().Where(t => t.Name == "Annex").FirstOrDefault();
            TemplateClause tc = new TemplateClause() { Clause = clause, TemplateId = template.Id };
            _templateClauseRepository.Persist(tc);
            await _templateClauseRepository.FlushAsync();
            return CreatedAtAction(nameof(GetClauseDetails), new { id = clause.Id }, clause);
        }
    }
}
