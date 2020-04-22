﻿using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using UserService.Entities;
using UserService.Helpers;
using Google.Apis.Auth;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using UserService.Models;
using UserService.Services;

namespace UserService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LoginController : ControllerBase
    {
        private readonly ILoginService _service;

        public LoginController(ILoginService service)
        {
            _service = service;
        }

        [HttpPost("password")]
        public async Task<IActionResult> LoginPassword([FromBody] LoginModel model)
        {
            var user = await _service.LoginPassword(model.Email, model.Password);

            if (user == null)
                return BadRequest();

            return Ok(user);
        }
        
        [HttpPost("google")]
        public async Task<IActionResult> LoginGoogle([FromBody] LoginModel model)
        {
            var user = await _service.LoginGoogle(model.TokenId);

            if (user == null)
                return BadRequest();

            return Ok(user);
        }
        
        [HttpPost("apple")]
        public async Task<IActionResult> LoginApple([FromBody] LoginModel model)
        {
            var user = await _service.LoginApple(model.TokenId);

            if (user == null)
                return BadRequest();

            return Ok(user);
        }
    }
}