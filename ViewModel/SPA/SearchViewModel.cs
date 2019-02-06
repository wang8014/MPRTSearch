using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MPRTSearch.ViewModel.SPA
{
    public class SearchViewModel 
    {
        [Required(ErrorMessage = "sökord bör inte vara tomt."),StringLength(100, MinimumLength = 2, ErrorMessage = "sökord längd  bör vara mellan 2 och 100")]
        public string SearchText { get; set; }
    }
}
