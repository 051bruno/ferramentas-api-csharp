using FerramentasDomain.Repositories;

namespace FerramentasAPI.Endpoints.Ferramentas;

public static class FerramentaDelete
{
    public static void MapDeleteFerramenta(this WebApplication app)
    {
        app.MapDelete("/ferramentas/{id}", (Guid id, IFerramentaRepository repo) =>
        {
            var ferramenta = repo.GetById(id);
            if (ferramenta is null)
                return Results.NotFound();

            repo.Remover(id);
            return Results.NoContent();
        });

    }
}
