using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Threading.Tasks;
using Trafic_Signal_Management.Models;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using Microsoft.IdentityModel.Tokens;

namespace Trafic_Signal_Management.Services
{
    public class ValidationService
    {
        JwtSecurityTokenHandler _tokenHandler = new JwtSecurityTokenHandler();
        private const string Secret = "db3OIsj+BXE9NZDy0t8W3TcNekrF+2d/1sFnWG4HnV8TZY30iTOdtVWJG8abWvB1GlOgJuQZdcF2Luqm/hccMw==";


        public bool Authenticate_User(Login user)
        {
            if(!string.IsNullOrEmpty(user.Password) && !string.IsNullOrEmpty(user.UserName))
            {
                return true;
            }
            return false;
        }
        public string Validate_Token(string JWtoken)
        {
            if (!string.IsNullOrEmpty(JWtoken))
            {
                var jwtToken = _tokenHandler.ReadToken(JWtoken) as JwtSecurityToken;

                if (jwtToken == null)
                    return null;

                var symmetricKey = Convert.FromBase64String(Secret);

                var validationParameters = new TokenValidationParameters()
                {
                    RequireExpirationTime = true,
                    ValidateIssuer = false,
                    ValidateAudience = false,
                    IssuerSigningKey = new SymmetricSecurityKey(symmetricKey)
                };

                ClaimsIdentity principal = _tokenHandler.ValidateToken(JWtoken, validationParameters, out _).Identities.First();

                return principal.Name;
            }
            return null;
        }
        public string Generate_Token(string username )
        {
            var now = DateTime.UtcNow;
            var symmetricKey = Convert.FromBase64String(Secret);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[]
                       {
                            new Claim(ClaimTypes.Name, username)
                        }),

                Expires = now.AddMinutes(20),

                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(symmetricKey), SecurityAlgorithms.HmacSha256Signature)
            };
            SecurityToken securityToken = _tokenHandler.CreateToken(tokenDescriptor);
            var token = _tokenHandler.WriteToken(securityToken);

            return token;
        }

    }
}
