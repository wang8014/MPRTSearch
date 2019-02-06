using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MPRTSearch.BusinessEntities
{
    public class Navigation
    {
        public int PageIndex { get; set; }
        public int PageSize { get; set; }
        public int TotalPage { get; set; }
        public Navigation()
        {
            PageIndex = 1;
            PageSize = 20;
            TotalPage = 0;
        }
    }
}
