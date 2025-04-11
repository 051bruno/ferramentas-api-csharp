using FerramentasAPI.Dtos;
using FerramentasDomain.Entities;
using FerramentasDomain.Enums;
using FerramentasDomain.Repositories;
using FerramentasDomain.ValueObjects;

namespace FerramentasAPI.Endpoints.Ferramentas;

public static class FerramentaPut
{
    public static void MapPutFerramenta(this WebApplication app)
    {
        app.MapPut("/ferramentas/{id}", (Guid id, FerramentaDto dto, IFerramentaRepository repo) =>
        {
            var ferramentaExistente = repo.GetById(id);
            if (ferramentaExistente is null)
                return Results.NotFound("Ferramenta não encontrada.");

            // Criando os ValueObjects com os dados recebidos no DTO
            var endereco = new Endereco(dto.Endereco);
            var descricao = new Descricao(dto.Descricao);
            var diametro = new Diametro(dto.Diametro);
            var altura = new Altura(dto.Altura);

            FerramentaBase novaFerramenta;

            switch (dto.Tipo)
            {
                case TipoFerramenta.VBit:
                    novaFerramenta = new FerramentaVBit(endereco, descricao, diametro, altura);
                    break;

                case TipoFerramenta.TopoRaso:
                    novaFerramenta = new FerramentaTopoRaso(endereco, descricao, diametro, altura);
                    break;

                default:
                    return Results.BadRequest("Tipo de ferramenta inválido.");
            }

            // Mantém o mesmo ID da ferramenta original
            novaFerramenta.SetId(id);
            repo.Atualizar(novaFerramenta);

            return Results.NoContent();
        });
    }
}
