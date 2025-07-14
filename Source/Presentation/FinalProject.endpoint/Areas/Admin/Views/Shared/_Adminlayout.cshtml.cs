using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace FinalProject.endpoint.Area.Admin.Views.Shared
{
    public class _Adminlayout : PageModel
    {
        private readonly ILogger<_Adminlayout> _logger;

        public _Adminlayout(ILogger<_Adminlayout> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}