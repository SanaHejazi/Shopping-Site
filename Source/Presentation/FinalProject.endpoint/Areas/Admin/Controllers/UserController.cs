using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using FinalProject.Application.Services.Queries.GetUsers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace FinalProject.endpoint.Area.Admin.Controllers
{
    [Area("Admin")]
    public class UserController : Controller
    {
        private readonly ILogger<UserController> _logger;
        private readonly IGetUserService _GetUserService;

        public UserController(ILogger<UserController> logger, IGetUserService getUserService)
        {
            _logger = logger;
            _GetUserService = getUserService;
        }

        public IActionResult Index(string searchkey,int page =1)
        {

            return View(_GetUserService.Execute(new RequestClassDto
            {
                Page = page,
                SearchKey=searchkey,
            }));
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}