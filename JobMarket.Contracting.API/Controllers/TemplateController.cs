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
    [Authorize(Roles = "ADMINISTRATOR,EXECUTOR,CLIENT")]
    public class TemplateController : ControllerBase
    {
        private readonly TemplateRepository _templateRepository;

        public TemplateController(TemplateRepository templateRepository)
        {
            _templateRepository = templateRepository;
        }

        [HttpGet]
        public ActionResult<List<Template>> GetTemplates()
        {
            var templates = _templateRepository.Query().ToList();

            if (templates == null)
            {
                return NotFound();
            }

            return Ok(templates);
        }

       /* [HttpGet("{id:int}")]
        public ActionResult<Template> GetTemplate(int id)
        {
            var template = _templateRepository.Single(id);

            if (template == null)
            {
                return NotFound();
            }

            return Ok(template);
        }
       */
        [HttpGet("{id:int}")]
        public ActionResult<Template> GetTemplateDetails(int id)
        {
            var template = _templateRepository.TemplateDetails(id);

            if (template == null)
            {
                return NotFound();
            }

            return Ok(template);
        }

        [HttpPost]
        public async Task<IActionResult> Create(Template template)
        {
            if (template == null)
            {
                return BadRequest();
            }

            _templateRepository.Persist(template);
            await _templateRepository.FlushAsync();

            return CreatedAtAction(nameof(GetTemplateDetails), new { id = template.Id }, template);
        }
    }
}
