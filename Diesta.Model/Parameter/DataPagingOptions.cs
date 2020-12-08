using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diesta.Model.Parameter
{
    public class DataPagingOptions
    {
        public DataPagingOptions(int? pageSize, int? pageNumber)
        {
            PageSize = pageSize;
            PageNumber = pageNumber;
        }

        public int? PageSize { get; set; }
        public int? PageNumber { get; set; }
    }
}
