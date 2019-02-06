using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MPRTSearch.ViewModel.SPA;
//using OldViewModel = WebApplication1.ViewModels;  Alias
using MPRTSearch.BusinessEntities;
using MPRTSearch.BusinessLayer;
using PagedList;

namespace MPRTSearch.Areas.SPA.Controllers
{
    public class MainController : BaseController
    {
        // GET: SPA/Main
        
        public ActionResult Index()
        {
            SearchResultViewModel viewreturn = new SearchResultViewModel();
            return View("Index", viewreturn);
        }
        
        public ActionResult GetSearchInput(SearchViewModel search)
        {
            return PartialView("SearchInput", search);
        }
        public ActionResult GetNavigationBar(NavigationViewModel navigationViewModel)
        {
            navigationViewModel.Refresh();
            return PartialView("NavigationBar", navigationViewModel);
        }
        [HttpPost]
        public ActionResult ExcuteSearch(SearchViewModel search, int page = 1)
        {
            return DoSearch(search.SearchText, page);
        }
        [HttpGet]
        public ActionResult ExcuteNavigation(string seaText, int page = 1)
        {
            return DoSearch(seaText,page);
        }
        private ActionResult DoSearch(string seaText, int page)
        {
            SearchDataSetBLL bll = new SearchDataSetBLL();
            Search sea = new Search();
            sea.SearchText = seaText;

            SearchViewModel searchViewModel = new SearchViewModel();
            searchViewModel.SearchText = seaText;
            Navigation navigation = new Navigation();
            navigation.PageIndex = page;
            try
            {
                string strPageSize = System.Configuration.ConfigurationManager.AppSettings["PageSize"];
                if (!string.IsNullOrEmpty(strPageSize))
                {
                    int pageSize = 20; // = 20;
                    if (Int32.TryParse(strPageSize, out pageSize))
                    {
                        // do some logic
                        navigation.PageSize = pageSize;
                    }
                    else
                    {
                        //throw new System.Configuration.ConfigurationException("EnableAzureWebTrace value must be true of false.");
                        navigation.PageSize = 20;
                    }
                }

            }
            catch (System.Configuration.ConfigurationException ce)
            {
                // error handling logic
                //throw;
                navigation.PageSize = 20;
            }

            //IPagedList<SearchDataSet> sDS = 
            SearchResultViewModel viewreturn = new SearchResultViewModel();
            viewreturn.searchViewModel = searchViewModel;
            viewreturn.ListSearchDataSet = bll.GetSearchDataSet(sea, navigation);
            viewreturn.ListTypeTable = bll.GetTypeTable();
            viewreturn.ListColumnTable = bll.GetColumnTable();
            return View("Index", viewreturn);
        }
        


    }
}