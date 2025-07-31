using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Net.WebSockets;
using WebAPI_ECOMMERCE.Entities;
using WebAPI_ECOMMERCE.Models;
using WebAPI_ECOMMERCE.Token;

namespace WebAPI_ECOMMERCE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TokenController : ControllerBase
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;


        public TokenController(SignInManager<ApplicationUser> signInManager,
        UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        [AllowAnonymous]
        [Produces("application/json")]
        [HttpPost("/api/CreateToken")]
        public async Task<IActionResult> CreateToken([FromBody] InputLoginRequest inputLoginRequest)
        {
            if(string.IsNullOrWhiteSpace(inputLoginRequest.Email) || string.IsNullOrWhiteSpace(inputLoginRequest.Password))
                return Unauthorized();

            var result = await _signInManager.PasswordSignInAsync(inputLoginRequest.Email, inputLoginRequest.Password,
                false, lockoutOnFailure: false);

            if (result.Succeeded)
            {
                var token = new TokenJWTBuilder()
                    .AddSecurityKey(JwtSecurityKey.Create("43443FDFDF34DF34343fdf344SDFSDFSDFSDFSDF4545354345SDFGDFGDFGDFGdffgfdGDFGDGR%"))
                .AddSubject("Web Api Marcelo")
                .AddIssuer("Marcelo.Securiry.Bearer")
                .AddAudience("Marcelo.Securiry.Bearer")
                .AddExpiry(5)
                .Builder();

                return Ok(token.value);
            }
            else
            {
                return Unauthorized();
            }
        }
    }
}
