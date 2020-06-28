using FiltrDinamico.Core.Extensions;
using FiltrDinamico.Core.Interpreters;
using FiltrDinamico.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace FiltrDinamico.Core
{
    public class FiltroDinamico : IFiltroDinamico
    {
        private readonly IFilterInterpreterFactory _factory;

        public FiltroDinamico(IFilterInterpreterFactory factory)
        {
            _factory = factory;
        }

        public Expression<Func<TType, bool>> FromFiltroItemList<TType>(IReadOnlyList<FiltroItem> filtroItems)
        {
            return filtroItems
                .Select(filtroItem => _factory.Create<TType>(filtroItem))
                .Aggregate((curr, next) => curr.And(next))
                .Interpret();
        }

    }
}
