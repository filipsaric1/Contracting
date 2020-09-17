using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using DinkToPdf;
using DinkToPdf.Contracts;
using JobMarket.Contracting.API.Utils;
using JobMarket.Contracting.Domain.Entities;
using JobMarket.Contracting.Persistence.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Net.Http.Headers;

namespace JobMarket.Contracting.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContractController : ControllerBase
    {
        private readonly ContractRepository _contractRepository;
        private readonly IConverter _converter;
        private readonly UserManager<User> _userManager;

        public ContractController(ContractRepository contractRepository, IConverter converter, UserManager<User> userManager)
        {
            _contractRepository = contractRepository;
            _converter = converter;
            this._userManager = userManager;
        }
        [Authorize(Roles = "ADMINISTRATOR,EXECUTOR,CLIENT")]
        [HttpGet]
        public ActionResult<List<Contract>> GetContracts()
        {
            try
            {
                var userId = _userManager.GetUserId(User);
                var contracts = _contractRepository.Query().Where(c => c.ExecutorId == userId || c.ClientId == userId).ToList();

                if (contracts == null)
                {
                    return NotFound();
                }

                return Ok(contracts);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
        /*
        [HttpGet("{id:int}")]
        public ActionResult<Contract> GetContract(int id)
        {
            try
            {
                var contract = _contractRepository.Single(id);

                if (contract == null)
                {
                    return NotFound();
                }

                return Ok(contract);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
        */
        [Authorize(Roles = "ADMINISTRATOR,EXECUTOR,CLIENT")]
        [HttpGet("{id:int}")]
        public ActionResult<Contract> GetContractDetails(int id)
        {
            try
            {
                var contract = _contractRepository.ContractDetails(id);
                if (contract == null)
                {
                    return NotFound();
                }
                var userId = _userManager.GetUserId(User);
                if (userId != contract.ExecutorId && userId != contract.ClientId)
                {
                    return Unauthorized();
                }

                

                return Ok(contract);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
        [Authorize(Roles = "ADMINISTRATOR,EXECUTOR")]
        [HttpPost]
        public async Task<IActionResult> Create(Contract contract)
        {
            if (contract == null)
            {
                return BadRequest();
            }

            try
            {
                _contractRepository.Persist(contract);
                await _contractRepository.FlushAsync();

                return CreatedAtAction(nameof(GetContractDetails), new { id = contract.Id }, contract);
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e);
            }
        }

        /// <summary>
        /// Update contract by ID
        /// </summary>
        /// <param name="id">ID of contract to update</param>
        /// <param name="updatedContract">Updated contract object</param>
        /// <returns>HTTP 204 if successful</returns>
        [Authorize(Roles = "ADMINISTRATOR,EXECUTOR,CLIENT")]
        [HttpPut("{id:int}")]
        public async Task<IActionResult> Update(int id, Contract updatedContract)
        {
            if (id != updatedContract.Id)
            {
                return BadRequest();
            }

            try
            {
                var contract = _contractRepository.Single(id);
                if (contract == null)
                {
                    return NotFound();
                }
                var userId = _userManager.GetUserId(User);
                if (userId != contract.ExecutorId && userId != contract.ClientId)
                {
                    return Unauthorized();
                }

                // Can't change contract when it's done
                if (contract.State == ContractState.Done)
                {
                    return BadRequest();
                }

                _contractRepository.Update(updatedContract);
                await _contractRepository.FlushAsync();

                return NoContent();
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }


        /// <summary>
        /// Called when executor has finished work and cliend has paid
        /// </summary>
        /// <param name="id">Contract Id</param>
        /// <returns>204 if Success</returns>
        [Authorize(Roles = "ADMINISTRATOR,EXECUTOR,CLIENT")]
        [HttpPut("{id:int}/finish")]
        public async Task<IActionResult> ContractFinished(int id)
        {
            try
            {
                var contract = _contractRepository.ContractDetails(id);
                if (contract == null)
                {
                    return BadRequest();
                }
                var userId = _userManager.GetUserId(User);
                if (userId != contract.ExecutorId && userId != contract.ClientId)
                {
                    return Unauthorized();
                }

                contract.State = ContractState.Done;

                _contractRepository.Update(contract);
                await _contractRepository.FlushAsync();

                return NoContent();
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        [Authorize(Roles = "ADMINISTRATOR,EXECUTOR,CLIENT")]
        [HttpGet("{id:int}/pdf")]
        public IActionResult GetContractPdf(int id)
        {
            var contract = _contractRepository.ContractDetails(id);

            if (contract == null)
            {
                return NotFound();
            }

            var globalSettings = new GlobalSettings
            {
                ColorMode = ColorMode.Color,
                Orientation = Orientation.Portrait,
                PaperSize = PaperKind.A4,
                Margins = new MarginSettings { Top = 10 },
                DocumentTitle = $"Contract_{id}"
            };

            var sb = new StringBuilder();

            sb.Append($@"
                <html>
                    <head>
                        <style>
                            .text-center {{ text-align: center; }}
                        </style>
                    </head>
                    <body style=""padding-top: 30px;"">
                        <p>Executor: {contract.ExecutorId}</p>
                        <p>Client: {contract.ClientId}</p>
                        <p>State of contract: {contract.State}</p>
                        <h1 class=""text-center"">{contract.Template.Name}</h1>
            ");
            foreach (var x in contract.Template.TemplateClauses)
            {
                sb.Append($@"<h3 class=""text-center"">{x.Clause.Name}</h3>");
                foreach (var item in contract.ArticleContracts)
                {
                    if (x.Clause.Articles.Contains(item.Article))
                    {
                        sb.Append($@"
                            <h4 class=""text-center"">Article {item.Article.Id}</h4>
                            <p class=""text-center"">{ArticleUtils.GetArticleContent(item.Article, item.Data)}</p>
                        ");
                    }
                }
            }
            sb.Append(@"
                    </body>
                </html>
            ");
            var htmlString = sb.ToString();

            var objectSettings = new ObjectSettings
            {
                PagesCount = true,
                HtmlContent = htmlString,
                WebSettings = { DefaultEncoding = "utf-8" },
                HeaderSettings = { FontName = "Arial", FontSize = 9, Line = true, Center = contract.Template.Name },
                FooterSettings = { FontName = "Arial", FontSize = 9, Line = true, Right = "[page] of [toPage]" }
            };

            var pdf = new HtmlToPdfDocument()
            {
                GlobalSettings = globalSettings,
                Objects = { objectSettings }
            };

            var file = _converter.Convert(pdf);
            return File(file, "application/pdf"/*, $"Contract_{id}.pdf"*/);
        }
    }
}
