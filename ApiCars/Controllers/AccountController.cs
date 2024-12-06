using ApiCars.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace ApiCars.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        string jwtSecretKey = Environment.GetEnvironmentVariable("JwtSecretKey");

        [HttpPost]

        public IActionResult Login([FromBody] LoginModel login)
        {
            if (login.Login == "admin" && login.Senha == "admin")
            {
                var token = GenToken();
                return Ok(new { token });
            }

            return BadRequest(new { msg = "Credenciais inválidas." });
        }

        private string GenToken()
        {
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtSecretKey));
            var credential = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var clains = new[]
            {
                new Claim("Login", "admin"),
                new Claim("Nome", "System adm")
            };

            var token = new JwtSecurityToken(
                issuer: "YourApi",
                audience: "YourApplication",
                claims: null,
                expires: DateTime.Now.AddHours(3),
                signingCredentials: credential

                );
            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
