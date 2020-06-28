using System;
using System.Linq;
using System.Linq.Expressions;

namespace FiltrDinamico.Core.Interpreters
{
    public class AndInterpreter<TType> : IFilterTypeInterpreter<TType>
    {
        private readonly IFilterTypeInterpreter<TType> _leftInterpreter;
        private readonly IFilterTypeInterpreter<TType> _rightInterpreter;

        public AndInterpreter(IFilterTypeInterpreter<TType> leftInterpreter, IFilterTypeInterpreter<TType> rightInterpreter)
        {
            _leftInterpreter = leftInterpreter;
            _rightInterpreter = rightInterpreter;
        }

        public Expression<Func<TType, bool>> Interpret()
        {
            var leftExpression = _leftInterpreter.Interpret();
            var rightExpression = Expression.Invoke(_rightInterpreter.Interpret(), leftExpression.Parameters.FirstOrDefault());

            var andAlsoExpression = Expression.AndAlso(leftExpression.Body, rightExpression);

            return Expression.Lambda<Func<TType, bool>>(andAlsoExpression, leftExpression.Parameters.FirstOrDefault());
        }
    }
}
