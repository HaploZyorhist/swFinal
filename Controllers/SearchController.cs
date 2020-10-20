using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.VisualBasic.FileIO;
using swFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace swFinal.Controllers
{
    public class SearchController : Controller
    {
        public ActionResult Index()
        {
            List<SearchOptions> _searchOptions = new List<SearchOptions>()
            {
                new SearchOptions
                {
                    searchFor = "Planet",
                    searchTarget = new Uri ($"https://swapi.dev/api/planets/"),
                },
                new SearchOptions
                {
                    searchFor = "People",
                    searchTarget = new Uri ($"https://swapi.dev/api/people/"),
                },
                new SearchOptions
                {
                    searchFor = "Films",
                    searchTarget = new Uri ($"https://swapi.dev/api/film/"),
                },
                new SearchOptions
                {
                    searchFor = "Species",
                    searchTarget = new Uri ($"https://swapi.dev/api/species/"),
                },
                new SearchOptions
                {
                    searchFor = "Starships",
                    searchTarget = new Uri ($"https://swapi.dev/api/starships/"),
                },
                new SearchOptions
                {
                    searchFor = "Vehicles",
                    searchTarget = new Uri ($"https://swapi.dev/api/vehicles/"),
                },
            };
            ViewBag.Searchable = new SelectList(_searchOptions, "searchFor", "searchTarget");
            return View(_searchOptions);
        }


    }
}
