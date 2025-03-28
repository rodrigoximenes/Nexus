using NpsApi.Repositorio;
using NpsApi.Repositorio.Interfaces;
using NpsApi.Servico.Servicos;

namespace NpsApi.WebAPI.Setup
{
    public static class ConfiguracoesInjecoesDependencias
    {
        public static IServiceCollection AddConfiguracoesInjecoesDependencias(this IServiceCollection servicos)
        {
            servicos.AddScoped<IRevisaoRepositorio, RevisaoRepositorio>();
            servicos.AddScoped<IRevisaoServico, RevisaoServico>();

            return servicos;
        }
    }
}