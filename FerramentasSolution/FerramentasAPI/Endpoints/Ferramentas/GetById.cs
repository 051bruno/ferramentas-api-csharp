using FerramentasDomain.Repositories;

namespace FerramentasAPI.Endpoints.Ferramentas;

public static class FerramentaGetById
{
    public static void MapGetFerramentaById(this WebApplication app)
    {
        app.MapGet("/ferramentas/{id}", (Guid id, IFerramentaRepository repo) =>
        {
            var ferramenta = repo.GetById(id);
            return ferramenta is not null ? Results.Ok(ferramenta) : Results.NotFound();
        });
    }
}
