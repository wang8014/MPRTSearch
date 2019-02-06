using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MPRTSearch.ViewModel.SPA;

namespace MPRTSearch.Areas.SPA.Controllers
{
    public class BaseController : Controller
    {
        // GET: SPA/Base
        private MainViewModel _mainViewModel;
        public MainViewModel mainViewModel
        { get { return _mainViewModel; } }

        public BaseController()
        {
            _mainViewModel = new MainViewModel();
            _mainViewModel.ApplicationName = "Unknown ApplicationName";
            _mainViewModel.FooterData = new FooterViewModel();

            _mainViewModel.FooterData.CompanyName = "ArkivIT";//Can be set to dynamic value
            _mainViewModel.FooterData.Year = DateTime.Now.Year.ToString();
            ViewBag.mainViewModel = _mainViewModel;
        }
        public ActionResult GetFooter()
        {
            return PartialView("Footer", _mainViewModel.FooterData);
        }
        public string GetApplicationName()
        {
            return _mainViewModel.ApplicationName;
        }
    }
}