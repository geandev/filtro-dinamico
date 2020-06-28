using FiltrDinamico.Core.Models;
using System.Collections.Generic;

namespace FiltrDinamico.WebApp.Models
{
    public class PaginationFilter
    {
        public IEnumerable<FiltroItem> Filtro { get; set; }
        public int Take { get; set; }
        public int Skip { get; set; }
    }
}
