using FerramentasDomain.Repositories;

namespace FerramentasAPI.Endpoints.Ferramentas;

public static class FerramentaGetAll
{
    public static void MapGetListFerramenta(this WebApplication app)
    {
        app.MapGet("/ferramentas", (IFerramentaRepository repo) =>
        {
            var ferramentas = repo.GetList();
            return Results.Ok(ferramentas);
        });

    }
}
