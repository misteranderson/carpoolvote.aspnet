using System;
using CPV;
// using System.Web;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CPV.Controllers
{
    /// <summary>
    /// Base Controller for CPV.
    /// </summary>
    public class CPVController : Controller
    {

        public virtual IActionResult Index(string themeName, string lang)
        {

            //=======================================================
            // Language Selection:
            // Current Language
            //=======================================================
            //   {English} : (en_US)
            //   {Spanish} : (es)
            //=======================================================
            lang = lang ?? "en_UK";
            string langName = "English (default)";

            if (String.Equals(lang,CPV.CPVConstants.LANGUAGE_ENGLISH,StringComparison.OrdinalIgnoreCase))
            {
                langName = "English";
            }

            if (String.Equals(lang, CPV.CPVConstants.LANGUAGE_SPANISH, StringComparison.OrdinalIgnoreCase))
            {
                langName = "Espanol";
            }

            //=======================================================
            // ViewData["CurrentLanguageName"] = "English";
            // ViewData["Language"] = "en_US"; //  Default Value
            ViewData["CurrentLanguageName"] = langName;
            ViewData["Language"] = lang;
            //=======================================================


            //=======================================================
            // Theme / Brand:
            // {CarPoolVote}
            // {Souls2ThePolls}
            string brandName = CPV.CPVConstants.DEFAULT_BRAND_NAME; // "Carpool Vote";
            ViewData["BrandName"] = brandName;

            if (!String.IsNullOrEmpty(themeName))
            {
                // ViewData["ThemeName"] = themeName;
                themeName = themeName ?? "carpoolvote";
            }
            ViewData["ThemeName"] = themeName;
            //=======================================================

            return View(
                new CPVBasicViewModel() {
                    LanguageCode = lang,
                    LanguageName = langName,
                    ThemeName = themeName,
                    BrandName = brandName
                }
            );

        }
    }
}