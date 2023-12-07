using CenterMangement.Core.Entities;
using CenterMangement.Core.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace CenterMangement.Service
{
    public class TokenService : ITokenService
    {
        private readonly IConfiguration _configuration;

        public TokenService(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public string CreateTokenAsync(User user)
        {
            //Private Claims
            var authClims = new List<Claim>()
            {
                new Claim(ClaimTypes.GivenName,user.Name),
                new Claim(ClaimTypes.Email,user.Email),
            };
            var userRoles = user.RelPermeationsUsersNavigation.ToList();
            foreach (var role in userRoles)
                authClims.Add(new Claim(ClaimTypes.Role, role.PermeationNavigation.Name));
            var authKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JWT:Key"]));
            var token = new JwtSecurityToken(
                issuer: _configuration["JWT:ValidIssure"],
                audience: _configuration["JWT:ValidAudience"],
                expires: DateTime.Now.AddDays(double.Parse(_configuration["JWT:DeurationInDays"])),
                claims: authClims,
                signingCredentials: new SigningCredentials(authKey, SecurityAlgorithms.HmacSha256Signature)
                );
            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
