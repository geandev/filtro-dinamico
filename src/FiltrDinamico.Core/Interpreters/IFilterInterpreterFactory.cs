using FiltrDinamico.Core.Models;

namespace FiltrDinamico.Core.Interpreters
{
    public interface IFilterInterpreterFactory
    {
        IFilterTypeInterpreter<TType> Create<TType>(FiltroItem filtroItem);
    }
}
