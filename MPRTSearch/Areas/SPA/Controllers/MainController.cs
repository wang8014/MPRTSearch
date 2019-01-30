using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MPRTSearch.ViewModel.SPA;
//using OldViewModel = WebApplication1.ViewModels;  Alias
using MPRTSearch.BusinessEntities;
using MPRTSearch.BusinessLayer;

namespace MPRTSearch.Areas.SPA.Controllers
{
    public class MainController : BaseController
    {
        // GET: SPA/Main
        public ActionResult Index()
        {
            return View("Index", this.mainViewModel);
        }
        public ActionResult GetSearchInput()
        {
            SearchViewModel search = new SearchViewModel();
            return PartialView("SearchInput", search);
        }
        [HttpPost]
        public ActionResult Search()
        {
            SearchDataSetBLL bll = new SearchDataSetBLL();


            return PartialView(new EmptyResult());
        }
    }
}