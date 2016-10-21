using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CPV.Controllers
{
    public class StoryController : CPVController
    {
        public override IActionResult Index(string themeName, string lang)
        {
            return base.Index(themeName, lang);
        }
    }
}
