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
            viewreturn.searchViewModel = GetSearchViewModel("", "0", "1");

            return View("Index", viewreturn);
        }
        public ActionResult About()
        {
            
            return View("About");
        }
        

        public ActionResult GetSearchInput(SearchViewModel search)
        {
            return PartialView("SearchInput", search);
        }
        public ActionResult GetNavigationBar(SearchResultViewModel seachResultViewModel)
        {
            return PartialView("NavigationBar", seachResultViewModel);
        }

        //[AcceptVerbs(HttpVerbs.Get | HttpVerbs.Post)] 
        [HttpPost]
        public ActionResult ExcuteSearch(SearchViewModel search, int page = 1)
        {
            return DoSearch(search.SearchText, search.TypeValue,search.LogicValue, page);
        }
        [HttpGet]
        public ActionResult ExcuteSearch(string seaText, string TypeValue, string LogicValue, int page = 1)
        {
            return DoSearch(seaText, TypeValue, LogicValue, page);
        }
        [HttpGet]
        public ActionResult ExcuteNavigation(string seaText, string TypeValue, string LogicValue, int page = 1)
        {
            return DoSearch(seaText, TypeValue, LogicValue, page);
        }
        private SearchViewModel GetSearchViewModel(string seaText,string TypeValue,string LogicValue)
        {
            SearchViewModel searchViewModel = new SearchViewModel();
            searchViewModel.SearchText = seaText;
            SearchDataSetBLL bll = new SearchDataSetBLL();
            //prepare type
            List<TypeTable> ListTypeTable = bll.GetTypeTable();
            ListTypeTable.Insert(0, new TypeTable { ID = 0, TypeName = "Alla", Enabled = true });
            SelectList listType = new SelectList(ListTypeTable, "ID", "TypeName");
            searchViewModel.TypeValue = TypeValue;
            searchViewModel.ListTypeViewModel = listType;
            //prepare logic
            List<SelectListItem> listLogic = new List<SelectListItem>();
            SelectListItem item = new SelectListItem();
            item.Value = "1";
            item.Text = "Logisk Och";
            //item.Selected = true;
            listLogic.Add(item);
            item = new SelectListItem();
            item.Value = "0";
            item.Text = "Logisk Eller";
            //item.Selected = false;
            listLogic.Add(item);
            searchViewModel.LogicValue = LogicValue;
            searchViewModel.ListLogic = listLogic;
            return searchViewModel;
        }
        private Search GetSearch(string seaText, string TypeValue, string LogicValue)
        {
            Search sea = new Search();
            sea.SearchText = seaText;
            int tempId = 0;
            sea.TypeId = Int32.TryParse(TypeValue, out tempId) ? tempId:0;
            if (LogicValue == "0")
            {
                sea.LogicAnd = false;
            }
            else
            {
                sea.LogicAnd = true;
            }
            return sea;
        }
        private Navigation GetNavigation(int page)
        {
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

            return navigation;
        }
        private NavigationViewModel  GetNavigationViewModel(Navigation navigation,int TotalRecord)
        {
            NavigationViewModel navigationViewModel = new NavigationViewModel();
            navigationViewModel.TotalRecord = TotalRecord;
            navigationViewModel.PageIndex = navigation.PageIndex;
            navigationViewModel.PageSize = navigation.PageSize;
            navigationViewModel.TotalPage = navigation.TotalPage;
            return navigationViewModel;
        }
        private ActionResult DoSearch(string seaText, string TypeValue, string LogicValue, int page)
        {
            SearchDataSetBLL bll = new SearchDataSetBLL();
            Search sea = GetSearch(seaText, TypeValue, LogicValue);
            SearchViewModel searchViewModel = GetSearchViewModel(seaText, TypeValue, LogicValue); ;
            Navigation navigation = GetNavigation(page);
            //IPagedList<SearchDataSet> sDS = 
            SearchResultViewModel viewreturn = new SearchResultViewModel();
            viewreturn.searchViewModel = searchViewModel;
            viewreturn.ListSearchDataSet = bll.GetSearchDataSet(sea, navigation);
            viewreturn.ListTypeTable = bll.GetTypeTable();
            viewreturn.ListColumnTable = bll.GetColumnTable();

            NavigationViewModel navigationViewModel = GetNavigationViewModel(navigation, viewreturn.ListSearchDataSet.TotalItemCount);
            viewreturn.navigationViewModel = navigationViewModel;
            return View("Index", viewreturn);
        }
        


    }
}