using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace swFinal.Models
{
    public class SearchOptions
    {
        public List<SelectListItem> searchLI { get; set; }
        public string searchFor { get; set; }
        public Uri searchTarget { get; set; }
    }
}
