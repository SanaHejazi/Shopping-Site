using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace FinalProject.endpoint.Areas.Site.Views.Shared
{
    public class _Sitelayout : PageModel
    {
        private readonly ILogger<_Sitelayout> _logger;

        public _Sitelayout(ILogger<_Sitelayout> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}