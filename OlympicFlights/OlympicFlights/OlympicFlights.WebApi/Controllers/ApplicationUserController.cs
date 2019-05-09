using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using OlympicFlights.Service.ApplicationUsersManagement;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace OlympicFlights.WebApi.Controllers
{
    [Route("api/users")]
    [ApiController]
    public class ApplicationUserController : ControllerBase
    {
        private readonly ApplicationUserService _applicationUserService;
        private readonly IConfiguration _appConfig;

        public ApplicationUserController(ApplicationUserService applicationUserService, IConfiguration appConfig)
        {
            _applicationUserService = applicationUserService ?? throw new ArgumentNullException(nameof(applicationUserService));
            _appConfig = appConfig ?? throw new ArgumentNullException(nameof(appConfig));
        }

        [HttpPost]
        [Route("signup")]
        public async Task<Object> SignUpUserAsync([FromBody] UpdateApplicationUserRequest request)
        {
            try
            {
                request.UserRole = _appConfig["ApplicationSettings:userRoleName"];

                var signUpResultModel = await _applicationUserService.CreateApplicationUserAsync(request);

                if(signUpResultModel is null)
                {
                    return BadRequest(new { message = "This username already taken" });
                }

                return Ok(signUpResultModel);
            }
            catch(Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }
            
        }

        [HttpPost]
        [Route("signin")]
        public async Task<Object> SingInUserAsync([FromBody] UpdateApplicationUserRequest request)
        {
            try
            {
                //request = new UpdateApplicationUserRequest
                //{
                //    NewPassword = "asdasd123A",
                //    UserEmail = "Ar@mail.ru",
                //    UserId = "d2fb5abe-d37e-459b-9be4-24228b06fd8c",
                //    UserName = "48red",
                //    UserPassword = "Ar555321"

                //};

                var signInResultModel = await _applicationUserService.SignInUserAsync(request);

                if(signInResultModel is null)
                {
                    return BadRequest(new { errorMessage = "Incorrect password or username" });
                }

                var tokenDescriptor = new SecurityTokenDescriptor
                {
                    Subject = new ClaimsIdentity(new Claim[]
                    {
                    new Claim(ClaimTypes.Role,signInResultModel.ApplicationUserRole),
                    new Claim(ClaimTypes.UserData,signInResultModel.ApplicationUserId)
                    }),
                    Expires = DateTime.UtcNow.AddMinutes(30),
                    SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_appConfig["ApplicationSettings:JWT"].ToString())), SecurityAlgorithms.HmacSha256Signature)
                };

                var tokenHandler = new JwtSecurityTokenHandler();
                var securityToken = tokenHandler.CreateToken(tokenDescriptor);
                var token = tokenHandler.WriteToken(securityToken);

                return Ok( new { successMessage = "Sign in success!",token,userName = signInResultModel.ApplicationUserName, userId = signInResultModel.ApplicationUserId,userPassword = request.UserPassword,userRole = signInResultModel.ApplicationUserRole,userEmail = signInResultModel.ApplicationUserEmail });
            }
            catch(Exception ex)
            {
                return BadRequest(new {errorMessage = ex.Message});
            }
        }

        [HttpGet]
        [Route("{userId}")]
        public async Task<IActionResult> GetUserInfo([FromRoute] string userId)
        {
            var userInfo = await _applicationUserService.GetUserInfo(userId);


            return Ok(new { userName = userInfo.ApplicationUserName, userId = userInfo.ApplicationUserId,userEmail = userInfo.ApplicationUserEmail});
        }

        [HttpPut]
        [Route("changePassword")]
        public async Task<Object> ChangePasswordAsync([FromBody] UpdateApplicationUserRequest request)
        {
            try
            {
                var result = await _applicationUserService.ChangePassword(request);

                return Ok(new {successMessage = "Password changed", newPassword = result});
            }
            catch (Exception ex)
            {
                return BadRequest(new { errorMessage = ex.Message });
            }
        }

    }
}
