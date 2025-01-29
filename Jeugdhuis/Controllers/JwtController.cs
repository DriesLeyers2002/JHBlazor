using Microsoft.AspNetCore.Mvc;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Text;
using System.IdentityModel.Tokens.Jwt;

namespace Jeugdhuis.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JwtController : ControllerBase
    {
        private const string SecretKey = "02d1b855dd6ba0beed32058be007a4c68e6e08e65d916c5088eeba384b06bcea";

        [HttpGet("generate")]
        public IActionResult GenerateToken()
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(SecretKey);

            // Payload voor de JWT
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new System.Security.Claims.ClaimsIdentity(new[]
                {
                    new System.Security.Claims.Claim("name", "jeugdhuisdecaravan"),
                }),
                Expires = DateTime.UtcNow.AddHours(24), // Vervalt over 24 uur
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);
            var jwtToken = tokenHandler.WriteToken(token);

            return Ok(new { Token = jwtToken });
        }
    }

}
