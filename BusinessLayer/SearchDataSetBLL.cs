using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using MPRTSearch.BusinessEntities;
using MPRTSearch.DAL;
using PagedList;
using System.Reflection;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;

namespace MPRTSearch.BusinessLayer
{
    public class SearchDataSetBLL
    {
        /// <summary>
        /// EF excute procedure 
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="fields"></param>
        /// <param name="orderField"></param>
        /// <param name="sqlWhere"> where</param>
        /// <param name="pageSize"></param>
        /// <param name="pageIndex"></param>
        /// <param name="totalPage">out parameter</param>
        /// <param name="RecordCount">out parameter</param>
        /// <returns></returns>
        public IEnumerable<SearchDataSet> GetPagePro(string tableName, string fields, string orderField, string sqlWhere, int pageSize, int pageIndex, out int totalPage, out int RecordCount)
        {
            using (MPRTSearchDAL context = new MPRTSearchDAL())
            {
                SqlParameter[] parameters = {
                    new SqlParameter("@TableName", SqlDbType.NText),
                    new SqlParameter("@Fields", SqlDbType.NText),
                    new SqlParameter("@OrderField", SqlDbType.NText),
                    new SqlParameter("@sqlWhere", SqlDbType.NText),
                    new SqlParameter("@pageSize", SqlDbType.Int),
                    new SqlParameter("@pageIndex", SqlDbType.Int),
                    new SqlParameter("@TotalPage", SqlDbType.Int),
                    new SqlParameter("@RecordCount", SqlDbType.Int)
                    };
                parameters[0].Value = tableName;
                parameters[1].Value = fields;
                parameters[2].Value = orderField;
                parameters[3].Value = sqlWhere;
                parameters[4].Value = pageSize;
                parameters[5].Value = pageIndex;
                parameters[6].Direction = ParameterDirection.Output;
                parameters[7].Direction = ParameterDirection.Output;
                var data = context.Database.SqlQuery<SearchDataSet>("exec [GetPageData] @TableName,@Fields,@OrderField,@sqlWhere,@pageSize,@pageIndex,@TotalPage out,@RecordCount out", parameters).ToList();
                int count = data.Count;
                //
                string n6 = parameters[6].Value.ToString();
                string n7 = parameters[7].Value.ToString();
                //
                totalPage = !string.IsNullOrEmpty(n6) ? int.Parse(n6) : 0;
                RecordCount = !string.IsNullOrEmpty(n7) ? int.Parse(n7) : 0;
                return data;
            }
        }
        public List<SearchDataSet> GetSearchDataSet()
        {
            MPRTSearchDAL mprtDal = new MPRTSearchDAL();
            return mprtDal.SearchDataSets.ToList();
        }
        
        public List<TypeTable> GetTypeTable()
        {
            MPRTSearchDAL mprtDal = new MPRTSearchDAL();
            return mprtDal.Set<TypeTable>().ToList();
        }
        public List<ColumnTable> GetColumnTable()
        {
            MPRTSearchDAL mprtDal = new MPRTSearchDAL();
            return mprtDal.Set<ColumnTable>().ToList();
        }
        //private Expression<Func<SearchDataSet, bool>> whereLambdaLogicAnd()
        //{
        //    MethodInfo method = typeof(SearchDataSet).GetMethod("Column01.Contains", new[] { typeof(string) });
        //    var target = Expression.Parameter(typeof(SearchDataSet), "p");
        //    var methodArg = Expression.Parameter(typeof(string), "searchText");
        //    Expression[] methodArgs = new[] { methodArg };
        //    Expression call = Expression.Call(target, method, methodArgs);
        //    var lambdaParameters = new[] { target, methodArg };
        //    var lambda = Expression.Lambda<Func<SearchDataSet,string, bool>>(call, lambdaParameters);

        //}
        //private whereLambdaLogicAnd(string searchText)
        
        private Expression<Func<SearchDataSet, bool>> whereLambdaLogicAnd(Search search)
        {
            
            Expression<Func<SearchDataSet, bool>> whereLambda = (p => 
                p.Column01.Contains(search.SearchText)
                || p.Column02.Contains(search.SearchText)
                || p.Column02.Contains(search.SearchText)
                || p.Column03.Contains(search.SearchText)
                || p.Column04.Contains(search.SearchText)
                || p.Column05.Contains(search.SearchText)
                || p.Column06.Contains(search.SearchText)
                || p.Column07.Contains(search.SearchText)
                || p.Column08.Contains(search.SearchText)
                || p.Column09.Contains(search.SearchText)
                || p.Column10.Contains(search.SearchText)
                || p.Column11.Contains(search.SearchText)
                || p.Column12.Contains(search.SearchText)
                || p.Column13.Contains(search.SearchText)
                || p.Column14.Contains(search.SearchText)
                || p.Column15.Contains(search.SearchText)
                || p.Column16.Contains(search.SearchText)
                || p.Column17.Contains(search.SearchText)
                || p.Column18.Contains(search.SearchText)
                || p.Column19.Contains(search.SearchText)
                || p.Column20.Contains(search.SearchText)
                || p.Column21.Contains(search.SearchText)
                || p.Column22.Contains(search.SearchText)
                || p.Column23.Contains(search.SearchText)
                || p.Column24.Contains(search.SearchText)
                || p.Column25.Contains(search.SearchText)
                || p.Column26.Contains(search.SearchText)
                || p.Column27.Contains(search.SearchText)
                || p.Column28.Contains(search.SearchText)
                || p.Column29.Contains(search.SearchText)
                || p.Column30.Contains(search.SearchText)
                || p.Column31.Contains(search.SearchText)
                || p.Column32.Contains(search.SearchText)
                || p.Column33.Contains(search.SearchText)
                || p.Column34.Contains(search.SearchText)
                || p.Column35.Contains(search.SearchText)
                || p.Column36.Contains(search.SearchText)
                || p.Column37.Contains(search.SearchText)
                || p.Column38.Contains(search.SearchText)
                || p.Column39.Contains(search.SearchText)
                )
                ;
        
            return whereLambda;
            
        }
        /// <summary>
        /// Search data by the searchword
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        public IPagedList<SearchDataSet> GetSearchDataSet(Search search, Navigation navigation)
        {
            MPRTSearchDAL mprtDal = new MPRTSearchDAL();
            int totalPage = 0;
            int recordCount = 0;
            var data = GetPagePro("SearchDataSet", "*", "Id", GetWhereSqlWithAnd(search), navigation.PageSize, navigation.PageIndex, out totalPage, out recordCount);
            var studentList = new StaticPagedList<SearchDataSet>(data, navigation.PageIndex, navigation.PageSize, recordCount);
            return studentList;//mprtDal.Set<SearchDataSet>().Where(whereLambdaLogicAnd(search)).OrderBy(p => p.ID).ToPagedList(navigation.PageIndex, navigation.PageSize);

        }
        private string GetWhereSqlWithAnd(Search search)
        {
            string rtn = "([Enabled]=1)";
            foreach(string item in search.ListSearchText)
            {
                rtn = rtn + "and ((Column01 like '%" + item + "%')or";
                rtn = rtn + "(Column02 like '%" + item + "%')or";
                rtn = rtn + "(Column03 like '%" + item + "%')or";
                rtn = rtn + "(Column04 like '%" + item + "%')or";
                rtn = rtn + "(Column05 like '%" + item + "%')or";
                rtn = rtn + "(Column06 like '%" + item + "%')or";
                rtn = rtn + "(Column07 like '%" + item + "%')or";
                rtn = rtn + "(Column08 like '%" + item + "%')or";
                rtn = rtn + "(Column09 like '%" + item + "%')or";
                rtn = rtn + "(Column10 like '%" + item + "%')or";
                rtn = rtn + "(Column11 like '%" + item + "%')or";
                rtn = rtn + "(Column12 like '%" + item + "%')or";
                rtn = rtn + "(Column13 like '%" + item + "%')or";
                rtn = rtn + "(Column14 like '%" + item + "%')or";
                rtn = rtn + "(Column15 like '%" + item + "%')or";
                rtn = rtn + "(Column16 like '%" + item + "%')or";
                rtn = rtn + "(Column17 like '%" + item + "%')or";
                rtn = rtn + "(Column18 like '%" + item + "%')or";
                rtn = rtn + "(Column19 like '%" + item + "%')or";
                rtn = rtn + "(Column20 like '%" + item + "%')or";
                rtn = rtn + "(Column21 like '%" + item + "%')or";
                rtn = rtn + "(Column22 like '%" + item + "%')or";
                rtn = rtn + "(Column23 like '%" + item + "%')or";
                rtn = rtn + "(Column24 like '%" + item + "%')or";
                rtn = rtn + "(Column25 like '%" + item + "%')or";
                rtn = rtn + "(Column26 like '%" + item + "%')or";
                rtn = rtn + "(Column27 like '%" + item + "%')or";
                rtn = rtn + "(Column28 like '%" + item + "%')or";
                rtn = rtn + "(Column29 like '%" + item + "%')or";
                rtn = rtn + "(Column30 like '%" + item + "%')or";
                rtn = rtn + "(Column31 like '%" + item + "%')or";
                rtn = rtn + "(Column32 like '%" + item + "%')or";
                rtn = rtn + "(Column33 like '%" + item + "%')or";
                rtn = rtn + "(Column34 like '%" + item + "%')or";
                rtn = rtn + "(Column35 like '%" + item + "%')or";
                rtn = rtn + "(Column36 like '%" + item + "%')or";
                rtn = rtn + "(Column37 like '%" + item + "%')or";
                rtn = rtn + "(Column38 like '%" + item + "%')or";
                rtn = rtn + "(Column39 like '%" + item + "%')";
                rtn = rtn + ")";
            }
            return rtn;
        }
        private string GetWhereSqlWithOr(Search search)
        {
            string rtn = "(1=1)";
            foreach (string item in search.ListSearchText)
            {
                rtn = rtn + "or ((Column01 like '%" + item + "%')or";
                rtn = rtn + "(Column02 like '%" + item + "%')or";
                rtn = rtn + "(Column03 like '%" + item + "%')or";
                rtn = rtn + "(Column04 like '%" + item + "%')or";
                rtn = rtn + "(Column05 like '%" + item + "%')or";
                rtn = rtn + "(Column06 like '%" + item + "%')or";
                rtn = rtn + "(Column07 like '%" + item + "%')or";
                rtn = rtn + "(Column08 like '%" + item + "%')or";
                rtn = rtn + "(Column09 like '%" + item + "%')or";
                rtn = rtn + "(Column10 like '%" + item + "%')or";
                rtn = rtn + "(Column11 like '%" + item + "%')or";
                rtn = rtn + "(Column12 like '%" + item + "%')or";
                rtn = rtn + "(Column13 like '%" + item + "%')or";
                rtn = rtn + "(Column14 like '%" + item + "%')or";
                rtn = rtn + "(Column15 like '%" + item + "%')or";
                rtn = rtn + "(Column16 like '%" + item + "%')or";
                rtn = rtn + "(Column17 like '%" + item + "%')or";
                rtn = rtn + "(Column18 like '%" + item + "%')or";
                rtn = rtn + "(Column19 like '%" + item + "%')or";
                rtn = rtn + "(Column20 like '%" + item + "%')or";
                rtn = rtn + "(Column21 like '%" + item + "%')or";
                rtn = rtn + "(Column22 like '%" + item + "%')or";
                rtn = rtn + "(Column23 like '%" + item + "%')or";
                rtn = rtn + "(Column24 like '%" + item + "%')or";
                rtn = rtn + "(Column25 like '%" + item + "%')or";
                rtn = rtn + "(Column26 like '%" + item + "%')or";
                rtn = rtn + "(Column27 like '%" + item + "%')or";
                rtn = rtn + "(Column28 like '%" + item + "%')or";
                rtn = rtn + "(Column29 like '%" + item + "%')or";
                rtn = rtn + "(Column30 like '%" + item + "%')or";
                rtn = rtn + "(Column31 like '%" + item + "%')or";
                rtn = rtn + "(Column32 like '%" + item + "%')or";
                rtn = rtn + "(Column33 like '%" + item + "%')or";
                rtn = rtn + "(Column34 like '%" + item + "%')or";
                rtn = rtn + "(Column35 like '%" + item + "%')or";
                rtn = rtn + "(Column36 like '%" + item + "%')or";
                rtn = rtn + "(Column37 like '%" + item + "%')or";
                rtn = rtn + "(Column38 like '%" + item + "%')or";
                rtn = rtn + "(Column39 like '%" + item + "%')";
                rtn = rtn + ")";
            }
            return rtn;
        }
        public SearchDataSet GetSearchDataSet(int Id)
        {
            MPRTSearchDAL mprtDal = new MPRTSearchDAL();
            List< SearchDataSet> listdata= mprtDal.Set<SearchDataSet>().Where(p => p.ID == Id).ToList();
            if (listdata.Count>0)
            {
                return listdata[0];
            }
            else { return null; }
        }





    }

}
