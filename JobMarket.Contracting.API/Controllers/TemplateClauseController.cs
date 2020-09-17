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
    [Authorize(Roles = "ADMINISTRATOR")]
    public class TemplateClauseController : ControllerBase
    {
        private readonly TemplateClauseRepository _templateClauseRepository;
        public TemplateClauseController(TemplateClauseRepository templateClauseRepository)
        {
            _templateClauseRepository = templateClauseRepository;
        }
        [HttpGet]
        [HttpGet]
        public ActionResult<List<TemplateClause>> GetTemplateClauses()
        {
            var templateClauses = _templateClauseRepository.Query().ToList();

            if (templateClauses == null)
            {
                return NotFound();
            }

            return Ok(templateClauses);
        }

        [HttpGet("{id:int}")]
        public ActionResult<ArticleContract> GetTemplateClause(int id)
        {
            var templateClause = _templateClauseRepository.Single(id);

            if (templateClause == null)
            {
                return NotFound();
            }

            return Ok(templateClause);
        }
        [HttpPost]
        public async Task<IActionResult> Create(TemplateClause templateClause)
        {
            if (templateClause == null)
            {
                return BadRequest();
            }

            _templateClauseRepository.Persist(templateClause);
            await _templateClauseRepository.FlushAsync();

            return CreatedAtAction(nameof(GetTemplateClause), new { id = templateClause.Id }, templateClause);
        }
    }
}