using FiltrDinamico.Core.Models;
using System.Linq.Expressions;

namespace FiltrDinamico.Core.Interpreters
{
    public class GreaterThanInterpreter<TType> : FilterTypeInterpreter<TType>
    {
        public GreaterThanInterpreter(FiltroItem filtroItem) : base(filtroItem)
        {
        }

        internal override Expression CreateExpression(MemberExpression property, ConstantExpression constant) 
            => Expression.GreaterThan(property, constant);
    }
}
