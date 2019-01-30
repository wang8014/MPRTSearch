using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MPRTSearch.BusinessEntities;
using MPRTSearch.DAL;
using MPRTSearch.BusinessEntities;

namespace MPRTSearch.BusinessLayer
{
    public class SearchDataSetBLL
    {
        public List<SearchDataSet> GetSearchDataSet()
        {
            MPRTSearchDAL mprtDal = new MPRTSearchDAL();
            return mprtDal.SearchDataSets.ToList();
        }
        /// <summary>
        /// Search data by the searchword
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        public List<SearchDataSet> GetSearchDataSet(Search search)
        {
            MPRTSearchDAL mprtDal = new MPRTSearchDAL();
            return mprtDal.Set<SearchDataSet>().Where(p =>p.Column01=="aa").ToList();
        }
    }
}
