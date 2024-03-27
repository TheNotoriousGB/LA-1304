// <copyright file="LoginController.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace RestApi_1304.Controllers
{
    using System.IdentityModel.Tokens.Jwt;
    using System.Text;
    using RestApi_1304.Models;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.IdentityModel.Tokens;

    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly IConfiguration _config;

        /// <summary>
        /// Initializes a new instance of the <see cref="LoginController"/> class.
        /// </summary>
        /// <param name="configuration"></param>
        /// 
        public LoginController(IConfiguration configuration)
        {
            this._config = configuration;

        }

        private User AuthenticateUser(User user)
        {
            User _user = null;
            if (user.Username == "admin" && user.Password == "12345") 
            {
               _user = new User { Username = "Gabriel" };
            }
            return _user;

        }

        private string GenerateToken(User user)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);
            var token = new JwtSecurityToken(this._config["Jwt:Issuer"], this._config["Jwt:Audience"], null, expires: DateTime.Now.AddMinutes(1), signingCredentials: credentials);
            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        [AllowAnonymous]
        [HttpPost]
        public IActionResult Login(User user)
        {
            IActionResult response = this.Unauthorized();
            var user_ = this.AuthenticateUser(user);
            if (user_ != null) 
            {
                var token = this.GenerateToken(user: user_);
                response = this.Ok(new { token = token });
            }

            return response;
        }
    } 
}
