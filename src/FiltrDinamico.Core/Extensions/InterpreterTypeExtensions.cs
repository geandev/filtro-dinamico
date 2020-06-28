using FiltrDinamico.Core.Interpreters;

namespace FiltrDinamico.Core.Extensions
{
    public static class InterpreterTypeExtensions
    {
        public static IFilterTypeInterpreter<TType> And<TType>(this IFilterTypeInterpreter<TType> left, IFilterTypeInterpreter<TType> right)
            => new AndInterpreter<TType>(left, right);
    }
}
