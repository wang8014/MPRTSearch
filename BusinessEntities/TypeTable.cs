using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MPRTSearch.BusinessEntities
{
    public class TypeTable
    {
        public int ID { get; set; }
        public string TypeName { get; set; }
        public int Sorting { get; set; }
        public bool Enabled { get; set; }
        public List<ColumnTable> _columnTable { get; set; }
        public List<SearchDataSet> _searchDataSet { get; set; }

    }
}
