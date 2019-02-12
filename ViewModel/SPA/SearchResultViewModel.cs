using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PagedList;

namespace MPRTSearch.ViewModel.SPA
{
    public class SearchResultViewModel
    {
        public SearchViewModel searchViewModel { get; set; }
        public NavigationViewModel navigationViewModel { get; set; }
        public IPagedList<MPRTSearch.BusinessEntities.SearchDataSet> ListSearchDataSet { get; set; }
        public List<MPRTSearch.BusinessEntities.TypeTable> ListTypeTable { get; set; }
        public List<MPRTSearch.BusinessEntities.ColumnTable> ListColumnTable { get; set; }

        public string GetRowId(int PageIndex,int PageSize, int CurrentIndex)
        {
            string rtn = ((PageIndex - 1) * PageSize + CurrentIndex + 1).ToString();
            return rtn;
        }
        public string GetTypeName(int TypeID)
        {
            MPRTSearch.BusinessEntities.TypeTable table = ListTypeTable.Find(p => p.ID == TypeID);
            return  table==null? "[okänd kategori]" : table.TypeName;
        }
        public string GetColumnName(int TypeID, int ColumnID)
        {
            MPRTSearch.BusinessEntities.ColumnTable table = ListColumnTable.Find(p => ((p.TypeID == TypeID) && (p.Sorting == ColumnID)));
            return table == null ? "[okänd kolumn]" : table.ColumnName;
        }
        public string GetRowData(MPRTSearch.BusinessEntities.SearchDataSet data)
        {
            string rtn = "";
            string columnName = "";
            string columnValue = "";

            columnName = GetColumnName(data.TypeID, 01);
            columnValue = data.Column01;
            if ((columnName != null) && (columnName != "[okänd kolumn]"))
            {
                //det finns kolumnen
                rtn = rtn + "<b>[" + columnName + "]:</b>" + (columnValue == null ? "" : columnValue) + "&nbsp;";
            }
            columnName = GetColumnName(data.TypeID, 02);
            columnValue = data.Column02;
            if ((columnName != null) && (columnName != "[okänd kolumn]"))
            {
                //det finns kolumnen
                rtn = rtn + "<b>[" + columnName + "]:</b>" + (columnValue == null ? "" : columnValue) + "&nbsp;";
            }
            columnName = GetColumnName(data.TypeID, 03);
            columnValue = data.Column03;
            if ((columnName != null) && (columnName != "[okänd kolumn]"))
            {
                //det finns kolumnen
                rtn = rtn + "<b>[" + columnName + "]:</b>" + (columnValue == null ? "" : columnValue) + "&nbsp;";
            }
            columnName = GetColumnName(data.TypeID, 04);
            columnValue = data.Column04;
            if ((columnName != null) && (columnName != "[okänd kolumn]"))
            {
                //det finns kolumnen
                rtn = rtn + "<b>[" + columnName + "]:</b>" + (columnValue == null ? "" : columnValue) + "&nbsp;";
            }
            columnName = GetColumnName(data.TypeID, 05);
            columnValue = data.Column05;
            if ((columnName != null) && (columnName != "[okänd kolumn]"))
            {
                //det finns kolumnen
                rtn = rtn + "<b>[" + columnName + "]:</b>" + (columnValue == null ? "" : columnValue) + "&nbsp;";
            }
            columnName = GetColumnName(data.TypeID, 06);
            columnValue = data.Column06;
            if ((columnName != null) && (columnName != "[okänd kolumn]"))
            {
                //det finns kolumnen
                rtn = rtn + "<b>[" + columnName + "]:</b>" + (columnValue == null ? "" : columnValue) + "&nbsp;";
            }
            columnName = GetColumnName(data.TypeID, 07);
            columnValue = data.Column07;
            if ((columnName != null) && (columnName != "[okänd kolumn]"))
            {
                //det finns kolumnen
                rtn = rtn + "<b>[" + columnName + "]:</b>" + (columnValue == null ? "" : columnValue) + "&nbsp;";
            }
            columnName = GetColumnName(data.TypeID, 08);
            columnValue = data.Column08;
            if ((columnName != null) && (columnName != "[okänd kolumn]"))
            {
                //det finns kolumnen
                rtn = rtn + "<b>[" + columnName + "]:</b>" + (columnValue == null ? "" : columnValue) + "&nbsp;";
            }
            columnName = GetColumnName(data.TypeID, 09);
            columnValue = data.Column09;
            if ((columnName != null) && (columnName != "[okänd kolumn]"))
            {
                //det finns kolumnen
                rtn = rtn + "<b>[" + columnName + "]:</b>" + (columnValue == null ? "" : columnValue) + "&nbsp;";
            }
            columnName = GetColumnName(data.TypeID, 10);
            columnValue = data.Column10;
            if ((columnName != null) && (columnName != "[okänd kolumn]"))
            {
                //det finns kolumnen
                rtn = rtn + "<b>[" + columnName + "]:</b>" + (columnValue == null ? "" : columnValue) + "&nbsp;";
            }
            columnName = GetColumnName(data.TypeID, 11);
            columnValue = data.Column11;
            if ((columnName != null) && (columnName != "[okänd kolumn]"))
            {
                //det finns kolumnen
                rtn = rtn + "<b>[" + columnName + "]:</b>" + (columnValue == null ? "" : columnValue) + "&nbsp;";
            }
            columnName = GetColumnName(data.TypeID, 12);
            columnValue = data.Column12;
            if ((columnName != null) && (columnName != "[okänd kolumn]"))
            {
                //det finns kolumnen
                rtn = rtn + "<b>[" + columnName + "]:</b>" + (columnValue == null ? "" : columnValue) + "&nbsp;";
            }
            columnName = GetColumnName(data.TypeID, 13);
            columnValue = data.Column13;
            if ((columnName != null) && (columnName != "[okänd kolumn]"))
            {
                //det finns kolumnen
                rtn = rtn + "<b>[" + columnName + "]:</b>" + (columnValue == null ? "" : columnValue) + "&nbsp;";
            }
            columnName = GetColumnName(data.TypeID, 14);
            columnValue = data.Column14;
            if ((columnName != null) && (columnName != "[okänd kolumn]"))
            {
                //det finns kolumnen
                rtn = rtn + "<b>[" + columnName + "]:</b>" + (columnValue == null ? "" : columnValue) + "&nbsp;";
            }
            columnName = GetColumnName(data.TypeID, 15);
            columnValue = data.Column15;
            if ((columnName != null) && (columnName != "[okänd kolumn]"))
            {
                //det finns kolumnen
                rtn = rtn + "<b>[" + columnName + "]:</b>" + (columnValue == null ? "" : columnValue) + "&nbsp;";
            }
            columnName = GetColumnName(data.TypeID, 16);
            columnValue = data.Column16;
            if ((columnName != null) && (columnName != "[okänd kolumn]"))
            {
                //det finns kolumnen
                rtn = rtn + "<b>[" + columnName + "]:</b>" + (columnValue == null ? "" : columnValue) + "&nbsp;";
            }
            columnName = GetColumnName(data.TypeID, 17);
            columnValue = data.Column17;
            if ((columnName != null) && (columnName != "[okänd kolumn]"))
            {
                //det finns kolumnen
                rtn = rtn + "<b>[" + columnName + "]:</b>" + (columnValue == null ? "" : columnValue) + "&nbsp;";
            }
            columnName = GetColumnName(data.TypeID, 18);
            columnValue = data.Column18;
            if ((columnName != null) && (columnName != "[okänd kolumn]"))
            {
                //det finns kolumnen
                rtn = rtn + "<b>[" + columnName + "]:</b>" + (columnValue == null ? "" : columnValue) + "&nbsp;";
            }
            columnName = GetColumnName(data.TypeID, 19);
            columnValue = data.Column19;
            if ((columnName != null) && (columnName != "[okänd kolumn]"))
            {
                //det finns kolumnen
                rtn = rtn + "<b>[" + columnName + "]:</b>" + (columnValue == null ? "" : columnValue) + "&nbsp;";
            }
            columnName = GetColumnName(data.TypeID, 20);
            columnValue = data.Column20;
            if ((columnName != null) && (columnName != "[okänd kolumn]"))
            {
                //det finns kolumnen
                rtn = rtn + "<b>[" + columnName + "]:</b>" + (columnValue == null ? "" : columnValue) + "&nbsp;";
            }
            columnName = GetColumnName(data.TypeID, 21);
            columnValue = data.Column21;
            if ((columnName != null) && (columnName != "[okänd kolumn]"))
            {
                //det finns kolumnen
                rtn = rtn + "<b>[" + columnName + "]:</b>" + (columnValue == null ? "" : columnValue) + "&nbsp;";
            }
            columnName = GetColumnName(data.TypeID, 22);
            columnValue = data.Column22;
            if ((columnName != null) && (columnName != "[okänd kolumn]"))
            {
                //det finns kolumnen
                rtn = rtn + "<b>[" + columnName + "]:</b>" + (columnValue == null ? "" : columnValue) + "&nbsp;";
            }
            columnName = GetColumnName(data.TypeID, 23);
            columnValue = data.Column23;
            if ((columnName != null) && (columnName != "[okänd kolumn]"))
            {
                //det finns kolumnen
                rtn = rtn + "<b>[" + columnName + "]:</b>" + (columnValue == null ? "" : columnValue) + "&nbsp;";
            }
            columnName = GetColumnName(data.TypeID, 24);
            columnValue = data.Column24;
            if ((columnName != null) && (columnName != "[okänd kolumn]"))
            {
                //det finns kolumnen
                rtn = rtn + "<b>[" + columnName + "]:</b>" + (columnValue == null ? "" : columnValue) + "&nbsp;";
            }
            columnName = GetColumnName(data.TypeID, 25);
            columnValue = data.Column25;
            if ((columnName != null) && (columnName != "[okänd kolumn]"))
            {
                //det finns kolumnen
                rtn = rtn + "<b>[" + columnName + "]:</b>" + (columnValue == null ? "" : columnValue) + "&nbsp;";
            }
            columnName = GetColumnName(data.TypeID, 26);
            columnValue = data.Column26;
            if ((columnName != null) && (columnName != "[okänd kolumn]"))
            {
                //det finns kolumnen
                rtn = rtn + "<b>[" + columnName + "]:</b>" + (columnValue == null ? "" : columnValue) + "&nbsp;";
            }
            columnName = GetColumnName(data.TypeID, 27);
            columnValue = data.Column27;
            if ((columnName != null) && (columnName != "[okänd kolumn]"))
            {
                //det finns kolumnen
                rtn = rtn + "<b>[" + columnName + "]:</b>" + (columnValue == null ? "" : columnValue) + "&nbsp;";
            }
            columnName = GetColumnName(data.TypeID, 28);
            columnValue = data.Column28;
            if ((columnName != null) && (columnName != "[okänd kolumn]"))
            {
                //det finns kolumnen
                rtn = rtn + "<b>[" + columnName + "]:</b>" + (columnValue == null ? "" : columnValue) + "&nbsp;";
            }
            columnName = GetColumnName(data.TypeID, 29);
            columnValue = data.Column29;
            if ((columnName != null) && (columnName != "[okänd kolumn]"))
            {
                //det finns kolumnen
                rtn = rtn + "<b>[" + columnName + "]:</b>" + (columnValue == null ? "" : columnValue) + "&nbsp;";
            }
            columnName = GetColumnName(data.TypeID, 30);
            columnValue = data.Column30;
            if ((columnName != null) && (columnName != "[okänd kolumn]"))
            {
                //det finns kolumnen
                rtn = rtn + "<b>[" + columnName + "]:</b>" + (columnValue == null ? "" : columnValue) + "&nbsp;";
            }
            columnName = GetColumnName(data.TypeID, 31);
            columnValue = data.Column31;
            if ((columnName != null) && (columnName != "[okänd kolumn]"))
            {
                //det finns kolumnen
                rtn = rtn + "<b>[" + columnName + "]:</b>" + (columnValue == null ? "" : columnValue) + "&nbsp;";
            }
            columnName = GetColumnName(data.TypeID, 32);
            columnValue = data.Column32;
            if ((columnName != null) && (columnName != "[okänd kolumn]"))
            {
                //det finns kolumnen
                rtn = rtn + "<b>[" + columnName + "]:</b>" + (columnValue == null ? "" : columnValue) + "&nbsp;";
            }
            columnName = GetColumnName(data.TypeID, 33);
            columnValue = data.Column33;
            if ((columnName != null) && (columnName != "[okänd kolumn]"))
            {
                //det finns kolumnen
                rtn = rtn + "<b>[" + columnName + "]:</b>" + (columnValue == null ? "" : columnValue) + "&nbsp;";
            }
            columnName = GetColumnName(data.TypeID, 34);
            columnValue = data.Column34;
            if ((columnName != null) && (columnName != "[okänd kolumn]"))
            {
                //det finns kolumnen
                rtn = rtn + "<b>[" + columnName + "]:</b>" + (columnValue == null ? "" : columnValue) + "&nbsp;";
            }
            columnName = GetColumnName(data.TypeID, 35);
            columnValue = data.Column35;
            if ((columnName != null) && (columnName != "[okänd kolumn]"))
            {
                //det finns kolumnen
                rtn = rtn + "<b>[" + columnName + "]:</b>" + (columnValue == null ? "" : columnValue) + "&nbsp;";
            }
            //columnName = GetColumnName(data.TypeID, 36);
            //columnValue = data.Column36;
            //if ((columnName != null) && (columnName != "[okänd kolumn]"))
            //{
            //    //det finns kolumnen
            //    rtn = rtn + "<b>[" + columnName + "]:</b>" + (columnValue == null ? "" : columnValue) + "&nbsp;";
            //}
            //columnName = GetColumnName(data.TypeID, 37);
            //columnValue = data.Column37;
            //if ((columnName != null) && (columnName != "[okänd kolumn]"))
            //{
            //    //det finns kolumnen
            //    rtn = rtn + "<b>[" + columnName + "]:</b>" + (columnValue == null ? "" : columnValue) + "&nbsp;";
            //}
            //columnName = GetColumnName(data.TypeID, 38);
            //columnValue = data.Column38;
            //if ((columnName != null) && (columnName != "[okänd kolumn]"))
            //{
            //    //det finns kolumnen
            //    rtn = rtn + "<b>[" + columnName + "]:</b>" + (columnValue == null ? "" : columnValue) + "&nbsp;";
            //}
            //columnName = GetColumnName(data.TypeID, 39);
            //columnValue = data.Column39;
            //if ((columnName != null) && (columnName != "[okänd kolumn]"))
            //{
            //    //det finns kolumnen
            //    rtn = rtn + "<b>[" + columnName + "]:</b>" + (columnValue == null ? "" : columnValue) + "&nbsp;";
            //}
            
            return rtn;
        }


    }
}
