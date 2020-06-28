using FiltrDinamico.Core.Models;
using System.Linq.Expressions;

namespace FiltrDinamico.Core.Interpreters
{
    public class EqualsInterpreter<TType> : FilterTypeInterpreter<TType>
    {
        public EqualsInterpreter(FiltroItem filtroItem) : base(filtroItem)
        {
        }

        internal override Expression CreateExpression(MemberExpression property, ConstantExpression constant) 
            => Expression.Equal(property, constant);
    }
}
