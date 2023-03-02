using BugReport.Backend.Models.RequestData;
using BugReport.EF_Core.models;
using BugReport.Service;
using BugReport.Service.authorization;
using BugReport.Service.interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BugReport.Backend.Controllers
{
    public class AccountController : Controller
    {
        private readonly IUserManagementService UserService;
        private readonly AuthorizationManager AuthManager;
        public AccountController(IUserManagementService userService, AuthorizationManager authManager)
        {
            this.UserService = userService;
            AuthManager = authManager;
        }

        public IActionResult SignUp()
        {
            return View();
        }

        public IActionResult SignIn()
        {
            return View();
        }

        [HttpPost("/RequestSignUp")]
        public IActionResult RequestSignUp([FromForm] RequestSignUpData requestData)
        {
            try
            {
                UserService.CreateUser(requestData.LoginID!, requestData.Password!, requestData.UserName!);
                return Ok();
            }
             catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [AllowAnonymous]
        public IActionResult Login([FromBody] RequestLoginData login)
        {
            IActionResult response = Unauthorized();
            var userInfoMessage = this.UserService.AuthenticateUser(login.LoginID!, login.Password!);
            if (userInfoMessage.Success)
            {
                var tokenString = AuthManager.GenerateJWTToken(userInfoMessage.UserData!);
                response = Ok(new
                {
                    token = tokenString,
                    userDetails = userInfoMessage.UserData,
                });
            }
            return response;
        }
    }
}
