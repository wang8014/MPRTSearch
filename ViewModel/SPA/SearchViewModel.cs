using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace MPRTSearch.ViewModel.SPA
{
    public class SearchViewModel 
    {
        [Required(ErrorMessage = "sökord bör inte vara tomt."),StringLength(100, MinimumLength = 2, ErrorMessage = "sökord längd  bör vara mellan 2 och 100")]
        public string SearchText { get; set; }
        public string TypeDisplayText { get {return "välj kategori"; } }
        public string TypeValue { get; set; }
        public IEnumerable<SelectListItem> ListTypeViewModel { get; set; }
        public string LogicValue { get; set; }
        public string LogicDislayTtext { get { return "sökoperatörer"; } }
        public IEnumerable<SelectListItem> ListLogic { get; set; }

    }

}
