using FerramentasAPI.Dtos;
using FerramentasDomain.Entities;
using FerramentasDomain.Enums;
using FerramentasDomain.Repositories;
using FerramentasDomain.ValueObjects;

namespace FerramentasAPI.Endpoints.Ferramentas;

public static class PostFerramenta
{
    public static void MapPostFerramenta(this WebApplication app)
    {
        app.MapPost("/ferramentas", (FerramentaDto dto, IFerramentaRepository repo) =>
        {
            // Criar os Value Objects a partir dos dados do DTO
            var endereco = new Endereco(dto.Endereco);
            var descricao = new Descricao(dto.Descricao);
            var diametro = new Diametro(dto.Diametro);
            var altura = new Altura(dto.Altura);

            FerramentaBase ferramenta;

            switch (dto.Tipo)
            {
                case TipoFerramenta.VBit:
                    ferramenta = new FerramentaVBit(endereco, descricao, diametro, altura);
                    break;

                case TipoFerramenta.TopoRaso:
                    ferramenta = new FerramentaTopoRaso(endereco, descricao, diametro, altura);
                    break;

                default:
                    return Results.BadRequest("Tipo de ferramenta inválido.");
            }

            repo.Adicionar(ferramenta);

            return Results.Created($"/ferramentas/{ferramenta.Id}", ferramenta);
        });
    }
}
