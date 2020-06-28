using FiltrDinamico.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace FiltrDinamico.Core
{
    public interface IFiltroDinamico
    {
        Expression<Func<TType, bool>> FromFiltroItemList<TType>(IReadOnlyList<FiltroItem> filtroItems);
    }
}
