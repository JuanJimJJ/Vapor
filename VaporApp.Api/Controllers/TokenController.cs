using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using VaporApp.Application.Requests;

namespace VaporApp.Api.Controllers
{
    public class TokenController : ControllerBase
    {
        [HttpPost]
        public IActionResult GetToken(UserLoginRequest loginRequest)
        {
            var isValidUser = ValidateUser(loginRequest);
            if (!isValidUser)
                return Unauthorized();

            var token = GenerateToken(loginRequest.Username);
            return Ok(new { token });
        }

        private bool ValidateUser(UserLoginRequest loginRequest)
        {
            if (loginRequest.Username == "admin" && loginRequest.Password == "abc123")
                return true;

            return false;
        }

        private string GenerateToken(string userName)
        {
            //Header
            var privateKey = "keykeykeykeykeykeykeykey";
            var symmetricSecurityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(privateKey));
            var signingCredentials = new SigningCredentials(symmetricSecurityKey, SecurityAlgorithms.HmacSha256);
            var header = new JwtHeader(signingCredentials);

            //Payload
            var claims = new[]
            {
                new Claim(ClaimTypes.NameIdentifier, userName),
                new Claim(ClaimTypes.Role, "Admin"),
            };

            var payload = new JwtPayload
            (
                "https://localhost:44306", // Issuer
                "https://localhost:44306", // Audience
                claims,
                DateTime.Now, 
                DateTime.Now.AddMinutes(120) 
            );


            //Signature
            var token = new JwtSecurityToken(header, payload);
            var jwtToken = new JwtSecurityTokenHandler().WriteToken(token);
            return jwtToken;
        }
    }
}
