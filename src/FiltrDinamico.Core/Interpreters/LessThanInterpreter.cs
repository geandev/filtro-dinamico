using FiltrDinamico.Core.Models;
using System.Linq.Expressions;

namespace FiltrDinamico.Core.Interpreters
{
    public class LessThanInterpreter<TType> : FilterTypeInterpreter<TType>
    {
        public LessThanInterpreter(FiltroItem filtroItem) : base(filtroItem)
        {
        }

        internal override Expression CreateExpression(MemberExpression property, ConstantExpression constant)
            => Expression.LessThan(property, constant);
    }
}
