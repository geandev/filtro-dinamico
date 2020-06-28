using FiltrDinamico.Core.Interpreters;
using Microsoft.Extensions.DependencyInjection;

namespace FiltrDinamico.Core.DependecyInjection
{
    public static class FiltroDinamicoDepencyResolverExtension
    {
        public static IServiceCollection AddFiltroDinamico(this IServiceCollection services)
        {
            services.AddSingleton<IFilterInterpreterFactory, FilterInterpreterFactory>();
            services.AddSingleton<IFiltroDinamico, FiltroDinamico>();

            return services;
        }
    }
}
