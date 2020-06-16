using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Configuration;
using System.Diagnostics;

namespace UKAZ204Web.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IConfiguration config;

        public IndexModel(IConfiguration iConfig, ILogger<IndexModel> logger)
        {
            config = iConfig;
            _logger = logger;
        }

        public void OnGet()
        {

            string name = config["Name"];
            ViewData["name"] = name;
           // Trace.TraceInformation(name);
        }
    }
}
