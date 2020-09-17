﻿using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using JobMarket.Contracting.Domain.Entities;
using JobMarket.Contracting.Domain.Models.Account;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using JobMarket.Contracting.Infrastructure.Auth;
using Microsoft.AspNetCore.Authorization;

namespace JobMarket.Contracting.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly SignInManager<User> _signInManager;
        private readonly UserManager<User> _userManager;
        private readonly JwtFactory _jwtFactory;

        public AccountController(
            UserManager<User> userManager,
            SignInManager<User> signInManager,
            JwtFactory jwtFactory
            )
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _jwtFactory = jwtFactory;
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginDto model)
        {
            var result = await _signInManager.PasswordSignInAsync(model.Email, model.Password, false, false);

            if (!result.Succeeded)
            {
                return BadRequest();
            }

            var appUser = _userManager.Users.SingleOrDefault(r => r.Email == model.Email);

            return new JsonResult(_jwtFactory.Generate(model.Email, appUser));
        }

        
        [HttpPost]
        public async Task<IActionResult> Register(RegisterDto model)
        {
            var user = new User
            {
                UserName = model.Email,
                Email = model.Email,
                Role = Role.CLIENT
            };
            var result = await _userManager.CreateAsync(user, model.Password);

            if (result.Succeeded)
            {
                await _signInManager.SignInAsync(user, false);
                return new JsonResult(_jwtFactory.Generate(model.Email, user));
            }

            var errors = result.Errors.Select(x => x.Description);

            throw new ApplicationException("");
        }

        [Authorize]
        [HttpGet]
        public IActionResult Token()
        {
            return Ok();
        }
        
    }
}