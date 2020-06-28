using FiltrDinamico.Core.Models;
using System.Linq.Expressions;

namespace FiltrDinamico.Core.Interpreters
{
    public class ContainsInterpreter<TType> : FilterTypeInterpreter<TType>
    {
        public ContainsInterpreter(FiltroItem filtroItem) : base(filtroItem)
        {
        }

        internal override Expression CreateExpression(MemberExpression property, ConstantExpression constant)
        {
            var method = typeof(string).GetMethod(nameof(string.Contains), new[] { typeof(string) });

            return Expression.Call(property, method, constant);
        }
    }
}
