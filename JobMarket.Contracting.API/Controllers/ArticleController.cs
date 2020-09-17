using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
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
    public class ArticleController : ControllerBase
    {
        private readonly ArticleRepository _articleRepository;
        private readonly PlaceholderRepository _placeholderRepository;
        private readonly ClauseRepository _clauseRepository;

        public ArticleController(ArticleRepository articleRepository, PlaceholderRepository placeholderRepository,
            ClauseRepository clauseRepository)
        {
            _articleRepository = articleRepository;
            _placeholderRepository = placeholderRepository;
            _clauseRepository = clauseRepository;
        }

        [Authorize(Roles = "ADMINISTRATOR,EXECUTOR,CLIENT")]
        [HttpGet]
        public ActionResult<List<Article>> GetArticles()
        {
            var articles = _articleRepository.Query().ToList();

            if (articles == null)
            {
                return NotFound();
            }

            return Ok(articles);
        }

        [Authorize(Roles = "ADMINISTRATOR,EXECUTOR,CLIENT")]
        [HttpGet("{id:int}")]
        public async Task<ActionResult<Template>> GetArticle(int id)
        {
            var article = await _articleRepository.GetArticleDetails(id);

            if (article == null)
            {
                return NotFound();
            }

            return Ok(article);
        }

        [Authorize(Roles = "ADMINISTRATOR")]
        [HttpPost]
        public async Task<IActionResult> Create(Article article)
        {
            if (article == null)
            {
                return BadRequest();
            }

            var placeholderPattern = @"\[(.*?)\]";
            List<Placeholder> placeholders = new List<Placeholder>();

            // Find placeholders and place them in list
            foreach (Match match in Regex.Matches(article.Content, placeholderPattern))
            {
                var placeholder = new Placeholder
                {
                    Name = match.Value,
                    Location = match.Index,
                    Article = article
                };

                if (placeholders.Any(p => p.Name == placeholder.Name)) {
                    return BadRequest("Can't add article with multiple placeholders with the same value");
                }

                placeholders.Add(placeholder);
            }


            // Add article to database
            _articleRepository.Persist(article);
            await _articleRepository.FlushAsync();

            // Add placeholders to database
            _placeholderRepository.PersistRange(placeholders);
            await _placeholderRepository.FlushAsync();

            return CreatedAtAction(nameof(GetArticle), new { id = article.Id }, article);
        }
    }
}
