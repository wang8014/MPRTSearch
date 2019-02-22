using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MPRTSearch.BusinessEntities;
using MPRTSearch.ViewModel.SPA;
using MPRTSearch.BusinessLayer;

namespace MPRTSearch.Areas.SPA.Controllers
{
    public class DetailController : BaseController
    {
        // GET: SPA/Detail
        public ActionResult Index(int id,int nm = -1)
        {

            DetailViewModel detailViewModel = new DetailViewModel();
            detailViewModel.Number = nm;
            SearchDataSetBLL bll = new SearchDataSetBLL();
            SearchDataSet data = bll.GetSearchDataSet(id);
            List<TypeTable> ListTypeTable = bll.GetTypeTable();
            List<ColumnTable> ListColumnTable = bll.GetColumnTable();
            if(data!=null)
            {
                TypeTable typeTable = ListTypeTable.Find(p => p.ID == data.TypeID);
                if(typeTable!=null)
                {
                    detailViewModel.TypeName = typeTable.TypeName;
                }

                string columnName = "";

                ColumnTable columnTable = ListColumnTable.Find(p => (p.TypeID == data.TypeID) && (p.Sorting == 01));
                if (columnTable != null)
                {
                    columnName = columnTable.ColumnName;
                    detailViewModel.Column01Name = columnName;
                    detailViewModel.Column01Value = data.Column01;
                }
                else
                {
                    detailViewModel.Column01Name = "[okänd kolumn]";
                    detailViewModel.Column01Value = data.Column01;
                }
                columnTable = ListColumnTable.Find(p => (p.TypeID == data.TypeID) && (p.Sorting == 02));
                if (columnTable != null)
                {
                    columnName = columnTable.ColumnName;
                    detailViewModel.Column02Name = columnName;
                    detailViewModel.Column02Value = data.Column02;
                }
                else
                {
                    detailViewModel.Column02Name = "[okänd kolumn]";
                    detailViewModel.Column02Value = data.Column02;
                }
                columnTable = ListColumnTable.Find(p => (p.TypeID == data.TypeID) && (p.Sorting == 03));
                if (columnTable != null)
                {
                    columnName = columnTable.ColumnName;
                    detailViewModel.Column03Name = columnName;
                    detailViewModel.Column03Value = data.Column03;
                }
                else
                {
                    detailViewModel.Column03Name = "[okänd kolumn]";
                    detailViewModel.Column03Value = data.Column03;
                }
                columnTable = ListColumnTable.Find(p => (p.TypeID == data.TypeID) && (p.Sorting == 04));
                if (columnTable != null)
                {
                    columnName = columnTable.ColumnName;
                    detailViewModel.Column04Name = columnName;
                    detailViewModel.Column04Value = data.Column04;
                }
                else
                {
                    detailViewModel.Column04Name = "[okänd kolumn]";
                    detailViewModel.Column04Value = data.Column04;
                }
                columnTable = ListColumnTable.Find(p => (p.TypeID == data.TypeID) && (p.Sorting == 05));
                if (columnTable != null)
                {
                    columnName = columnTable.ColumnName;
                    detailViewModel.Column05Name = columnName;
                    detailViewModel.Column05Value = data.Column05;
                }
                else
                {
                    detailViewModel.Column05Name = "[okänd kolumn]";
                    detailViewModel.Column05Value = data.Column05;
                }
                columnTable = ListColumnTable.Find(p => (p.TypeID == data.TypeID) && (p.Sorting == 06));
                if (columnTable != null)
                {
                    columnName = columnTable.ColumnName;
                    detailViewModel.Column06Name = columnName;
                    detailViewModel.Column06Value = data.Column06;
                }
                else
                {
                    detailViewModel.Column06Name = "[okänd kolumn]";
                    detailViewModel.Column06Value = data.Column06;
                }
                columnTable = ListColumnTable.Find(p => (p.TypeID == data.TypeID) && (p.Sorting == 07));
                if (columnTable != null)
                {
                    columnName = columnTable.ColumnName;
                    detailViewModel.Column07Name = columnName;
                    detailViewModel.Column07Value = data.Column07;
                }
                else
                {
                    detailViewModel.Column07Name = "[okänd kolumn]";
                    detailViewModel.Column07Value = data.Column07;
                }
                columnTable = ListColumnTable.Find(p => (p.TypeID == data.TypeID) && (p.Sorting == 08));
                if (columnTable != null)
                {
                    columnName = columnTable.ColumnName;
                    detailViewModel.Column08Name = columnName;
                    detailViewModel.Column08Value = data.Column08;
                }
                else
                {
                    detailViewModel.Column08Name = "[okänd kolumn]";
                    detailViewModel.Column08Value = data.Column08;
                }
                columnTable = ListColumnTable.Find(p => (p.TypeID == data.TypeID) && (p.Sorting == 09));
                if (columnTable != null)
                {
                    columnName = columnTable.ColumnName;
                    detailViewModel.Column09Name = columnName;
                    detailViewModel.Column09Value = data.Column09;
                }
                else
                {
                    detailViewModel.Column09Name = "[okänd kolumn]";
                    detailViewModel.Column09Value = data.Column09;
                }
                columnTable = ListColumnTable.Find(p => (p.TypeID == data.TypeID) && (p.Sorting == 10));
                if (columnTable != null)
                {
                    columnName = columnTable.ColumnName;
                    detailViewModel.Column10Name = columnName;
                    detailViewModel.Column10Value = data.Column10;
                }
                else
                {
                    detailViewModel.Column10Name = "[okänd kolumn]";
                    detailViewModel.Column10Value = data.Column10;
                }
                columnTable = ListColumnTable.Find(p => (p.TypeID == data.TypeID) && (p.Sorting == 11));
                if (columnTable != null)
                {
                    columnName = columnTable.ColumnName;
                    detailViewModel.Column11Name = columnName;
                    detailViewModel.Column11Value = data.Column11;
                }
                else
                {
                    detailViewModel.Column11Name = "[okänd kolumn]";
                    detailViewModel.Column11Value = data.Column11;
                }
                columnTable = ListColumnTable.Find(p => (p.TypeID == data.TypeID) && (p.Sorting == 12));
                if (columnTable != null)
                {
                    columnName = columnTable.ColumnName;
                    detailViewModel.Column12Name = columnName;
                    detailViewModel.Column12Value = data.Column12;
                }
                else
                {
                    detailViewModel.Column12Name = "[okänd kolumn]";
                    detailViewModel.Column12Value = data.Column12;
                }
                columnTable = ListColumnTable.Find(p => (p.TypeID == data.TypeID) && (p.Sorting == 13));
                if (columnTable != null)
                {
                    columnName = columnTable.ColumnName;
                    detailViewModel.Column13Name = columnName;
                    detailViewModel.Column13Value = data.Column13;
                }
                else
                {
                    detailViewModel.Column13Name = "[okänd kolumn]";
                    detailViewModel.Column13Value = data.Column13;
                }
                columnTable = ListColumnTable.Find(p => (p.TypeID == data.TypeID) && (p.Sorting == 14));
                if (columnTable != null)
                {
                    columnName = columnTable.ColumnName;
                    detailViewModel.Column14Name = columnName;
                    detailViewModel.Column14Value = data.Column14;
                }
                else
                {
                    detailViewModel.Column14Name = "[okänd kolumn]";
                    detailViewModel.Column14Value = data.Column14;
                }
                columnTable = ListColumnTable.Find(p => (p.TypeID == data.TypeID) && (p.Sorting == 15));
                if (columnTable != null)
                {
                    columnName = columnTable.ColumnName;
                    detailViewModel.Column15Name = columnName;
                    detailViewModel.Column15Value = data.Column15;
                }
                else
                {
                    detailViewModel.Column15Name = "[okänd kolumn]";
                    detailViewModel.Column15Value = data.Column15;
                }
                columnTable = ListColumnTable.Find(p => (p.TypeID == data.TypeID) && (p.Sorting == 16));
                if (columnTable != null)
                {
                    columnName = columnTable.ColumnName;
                    detailViewModel.Column16Name = columnName;
                    detailViewModel.Column16Value = data.Column16;
                }
                else
                {
                    detailViewModel.Column16Name = "[okänd kolumn]";
                    detailViewModel.Column16Value = data.Column16;
                }
                columnTable = ListColumnTable.Find(p => (p.TypeID == data.TypeID) && (p.Sorting == 17));
                if (columnTable != null)
                {
                    columnName = columnTable.ColumnName;
                    detailViewModel.Column17Name = columnName;
                    detailViewModel.Column17Value = data.Column17;
                }
                else
                {
                    detailViewModel.Column17Name = "[okänd kolumn]";
                    detailViewModel.Column17Value = data.Column17;
                }
                columnTable = ListColumnTable.Find(p => (p.TypeID == data.TypeID) && (p.Sorting == 18));
                if (columnTable != null)
                {
                    columnName = columnTable.ColumnName;
                    detailViewModel.Column18Name = columnName;
                    detailViewModel.Column18Value = data.Column18;
                }
                else
                {
                    detailViewModel.Column18Name = "[okänd kolumn]";
                    detailViewModel.Column18Value = data.Column18;
                }
                columnTable = ListColumnTable.Find(p => (p.TypeID == data.TypeID) && (p.Sorting == 19));
                if (columnTable != null)
                {
                    columnName = columnTable.ColumnName;
                    detailViewModel.Column19Name = columnName;
                    detailViewModel.Column19Value = data.Column19;
                }
                else
                {
                    detailViewModel.Column19Name = "[okänd kolumn]";
                    detailViewModel.Column19Value = data.Column19;
                }
                columnTable = ListColumnTable.Find(p => (p.TypeID == data.TypeID) && (p.Sorting == 20));
                if (columnTable != null)
                {
                    columnName = columnTable.ColumnName;
                    detailViewModel.Column20Name = columnName;
                    detailViewModel.Column20Value = data.Column20;
                }
                else
                {
                    detailViewModel.Column20Name = "[okänd kolumn]";
                    detailViewModel.Column20Value = data.Column20;
                }
                columnTable = ListColumnTable.Find(p => (p.TypeID == data.TypeID) && (p.Sorting == 21));
                if (columnTable != null)
                {
                    columnName = columnTable.ColumnName;
                    detailViewModel.Column21Name = columnName;
                    detailViewModel.Column21Value = data.Column21;
                }
                else
                {
                    detailViewModel.Column21Name = "[okänd kolumn]";
                    detailViewModel.Column21Value = data.Column21;
                }
                columnTable = ListColumnTable.Find(p => (p.TypeID == data.TypeID) && (p.Sorting == 22));
                if (columnTable != null)
                {
                    columnName = columnTable.ColumnName;
                    detailViewModel.Column22Name = columnName;
                    detailViewModel.Column22Value = data.Column22;
                }
                else
                {
                    detailViewModel.Column22Name = "[okänd kolumn]";
                    detailViewModel.Column22Value = data.Column22;
                }
                columnTable = ListColumnTable.Find(p => (p.TypeID == data.TypeID) && (p.Sorting == 23));
                if (columnTable != null)
                {
                    columnName = columnTable.ColumnName;
                    detailViewModel.Column23Name = columnName;
                    detailViewModel.Column23Value = data.Column23;
                }
                else
                {
                    detailViewModel.Column23Name = "[okänd kolumn]";
                    detailViewModel.Column23Value = data.Column23;
                }
                columnTable = ListColumnTable.Find(p => (p.TypeID == data.TypeID) && (p.Sorting == 24));
                if (columnTable != null)
                {
                    columnName = columnTable.ColumnName;
                    detailViewModel.Column24Name = columnName;
                    detailViewModel.Column24Value = data.Column24;
                }
                else
                {
                    detailViewModel.Column24Name = "[okänd kolumn]";
                    detailViewModel.Column24Value = data.Column24;
                }
                columnTable = ListColumnTable.Find(p => (p.TypeID == data.TypeID) && (p.Sorting == 25));
                if (columnTable != null)
                {
                    columnName = columnTable.ColumnName;
                    detailViewModel.Column25Name = columnName;
                    detailViewModel.Column25Value = data.Column25;
                }
                else
                {
                    detailViewModel.Column25Name = "[okänd kolumn]";
                    detailViewModel.Column25Value = data.Column25;
                }
                columnTable = ListColumnTable.Find(p => (p.TypeID == data.TypeID) && (p.Sorting == 26));
                if (columnTable != null)
                {
                    columnName = columnTable.ColumnName;
                    detailViewModel.Column26Name = columnName;
                    detailViewModel.Column26Value = data.Column26;
                }
                else
                {
                    detailViewModel.Column26Name = "[okänd kolumn]";
                    detailViewModel.Column26Value = data.Column26;
                }
                columnTable = ListColumnTable.Find(p => (p.TypeID == data.TypeID) && (p.Sorting == 27));
                if (columnTable != null)
                {
                    columnName = columnTable.ColumnName;
                    detailViewModel.Column27Name = columnName;
                    detailViewModel.Column27Value = data.Column27;
                }
                else
                {
                    detailViewModel.Column27Name = "[okänd kolumn]";
                    detailViewModel.Column27Value = data.Column27;
                }
                columnTable = ListColumnTable.Find(p => (p.TypeID == data.TypeID) && (p.Sorting == 28));
                if (columnTable != null)
                {
                    columnName = columnTable.ColumnName;
                    detailViewModel.Column28Name = columnName;
                    detailViewModel.Column28Value = data.Column28;
                }
                else
                {
                    detailViewModel.Column28Name = "[okänd kolumn]";
                    detailViewModel.Column28Value = data.Column28;
                }
                columnTable = ListColumnTable.Find(p => (p.TypeID == data.TypeID) && (p.Sorting == 29));
                if (columnTable != null)
                {
                    columnName = columnTable.ColumnName;
                    detailViewModel.Column29Name = columnName;
                    detailViewModel.Column29Value = data.Column29;
                }
                else
                {
                    detailViewModel.Column29Name = "[okänd kolumn]";
                    detailViewModel.Column29Value = data.Column29;
                }
                columnTable = ListColumnTable.Find(p => (p.TypeID == data.TypeID) && (p.Sorting == 30));
                if (columnTable != null)
                {
                    columnName = columnTable.ColumnName;
                    detailViewModel.Column30Name = columnName;
                    detailViewModel.Column30Value = data.Column30;
                }
                else
                {
                    detailViewModel.Column30Name = "[okänd kolumn]";
                    detailViewModel.Column30Value = data.Column30;
                }
                columnTable = ListColumnTable.Find(p => (p.TypeID == data.TypeID) && (p.Sorting == 31));
                if (columnTable != null)
                {
                    columnName = columnTable.ColumnName;
                    detailViewModel.Column31Name = columnName;
                    detailViewModel.Column31Value = data.Column31;
                }
                else
                {
                    detailViewModel.Column31Name = "[okänd kolumn]";
                    detailViewModel.Column31Value = data.Column31;
                }
                columnTable = ListColumnTable.Find(p => (p.TypeID == data.TypeID) && (p.Sorting == 32));
                if (columnTable != null)
                {
                    columnName = columnTable.ColumnName;
                    detailViewModel.Column32Name = columnName;
                    detailViewModel.Column32Value = data.Column32;
                }
                else
                {
                    detailViewModel.Column32Name = "[okänd kolumn]";
                    detailViewModel.Column32Value = data.Column32;
                }
                columnTable = ListColumnTable.Find(p => (p.TypeID == data.TypeID) && (p.Sorting == 33));
                if (columnTable != null)
                {
                    columnName = columnTable.ColumnName;
                    detailViewModel.Column33Name = columnName;
                    detailViewModel.Column33Value = data.Column33;
                }
                else
                {
                    detailViewModel.Column33Name = "[okänd kolumn]";
                    detailViewModel.Column33Value = data.Column33;
                }
                columnTable = ListColumnTable.Find(p => (p.TypeID == data.TypeID) && (p.Sorting == 34));
                if (columnTable != null)
                {
                    columnName = columnTable.ColumnName;
                    detailViewModel.Column34Name = columnName;
                    detailViewModel.Column34Value = data.Column34;
                }
                else
                {
                    detailViewModel.Column34Name = "[okänd kolumn]";
                    detailViewModel.Column34Value = data.Column34;
                }
                columnTable = ListColumnTable.Find(p => (p.TypeID == data.TypeID) && (p.Sorting == 35));
                if (columnTable != null)
                {
                    columnName = columnTable.ColumnName;
                    detailViewModel.Column35Name = columnName;
                    detailViewModel.Column35Value = data.Column35;
                }
                else
                {
                    detailViewModel.Column35Name = "[okänd kolumn]";
                    detailViewModel.Column35Value = data.Column35;

                }
                //columnTable = ListColumnTable.Find(p => (p.TypeID == data.TypeID) && (p.Sorting == 36));
                //if (columnTable != null)
                //{
                //    columnName = columnTable.ColumnName;
                //    detailViewModel.Column36Name = columnName;
                //    detailViewModel.Column36Value = data.Column36;
                //}
                //else
                //{
                //    detailViewModel.Column36Name = "[okänd kolumn]";
                //    detailViewModel.Column36Value = data.Column36;
                //}
                //columnTable = ListColumnTable.Find(p => (p.TypeID == data.TypeID) && (p.Sorting == 37));
                //if (columnTable != null)
                //{
                //    columnName = columnTable.ColumnName;
                //    detailViewModel.Column37Name = columnName;
                //    detailViewModel.Column37Value = data.Column37;
                //}
                //else
                //{
                //    detailViewModel.Column37Name = "[okänd kolumn]";
                //    detailViewModel.Column37Value = data.Column37;
                //}
                //columnTable = ListColumnTable.Find(p => (p.TypeID == data.TypeID) && (p.Sorting == 38));
                //if (columnTable != null)
                //{
                //    columnName = columnTable.ColumnName;
                //    detailViewModel.Column38Name = columnName;
                //    detailViewModel.Column38Value = data.Column38;
                //}
                //else
                //{
                //    detailViewModel.Column38Name = "[okänd kolumn]";
                //    detailViewModel.Column38Value = data.Column38;
                //}
                //columnTable = ListColumnTable.Find(p => (p.TypeID == data.TypeID) && (p.Sorting == 39));
                //if (columnTable != null)
                //{
                //    columnName = columnTable.ColumnName;
                //    detailViewModel.Column39Name = columnName;
                //    detailViewModel.Column39Value = data.Column39;
                //}
                //else
                //{
                //    detailViewModel.Column39Name = "[okänd kolumn]";
                //    detailViewModel.Column39Value = data.Column39;
                //}
                
                
            }
            return View("Index", detailViewModel);
        }
    }
}