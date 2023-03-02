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

        [HttpPost("/Account/SignUp")]
        public IActionResult SignUp(IFormCollection frm)
        {
            try
            {

                UserService.CreateUser(frm["userId"]!, frm["password"]!, frm["userName"]!);
                return RedirectToAction("Index", "Home");
            }
            catch (Exception ex)
            {
                return BadRequest("가입 실패");
            }
        }

        [HttpPost]
        [AllowAnonymous]
        public IActionResult Login(IFormCollection login)
        {
            IActionResult response = Unauthorized();
            var userInfoMessage = this.UserService.AuthenticateUser(login["userId"]!, login["password"]!);
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
