using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MPRTSearch.ViewModel.SPA
{
    public class NavigationViewModel
    {
        public int PageIndex { get; set; }
        public int PageSize { get; set; }
        public int TotalPage { get; set; }
        public int firstPage = 0;
        public int lastPage = 0;
        public void Refresh()
        {
            if (TotalPage <= 10)
            {
                firstPage = 1;
                lastPage = TotalPage;
            }
            else
            {
                if ((TotalPage - PageIndex) > 4)
                {
                    lastPage = PageIndex + 4;
                    firstPage = lastPage - 9;
                }
                else
                {
                    lastPage = TotalPage;
                    firstPage = lastPage - 9;
                }
            }
        }
    }
}
