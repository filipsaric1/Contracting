using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JobMarket.Contracting.Domain.Models.User;
using JobMarket.Contracting.Persistence.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JobMarket.Contracting.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize(Roles = "ADMINISTRATOR")]
    public class UsersController : ControllerBase
    {
        public UserRepository _UserRepository { get; set; }

        public UsersController(UserRepository userRepository)
        {
            _UserRepository = userRepository;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var users = _UserRepository.Query().Select(x => BriefModel.MapFrom(x)).ToList();

            return Ok(users);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(id);
        }
        
    }
}