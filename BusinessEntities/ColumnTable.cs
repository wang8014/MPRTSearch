using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MPRTSearch.BusinessEntities
{
    public class ColumnTable
    {
        public int ID { get; set; }
        public int TypeID { get; set; }
        public string ColumnName { get; set; }
        public int Sorting { get; set; }
        public bool Enabled { get; set; }
        public virtual TypeTable _typeTable { get; set; }
    }
}
