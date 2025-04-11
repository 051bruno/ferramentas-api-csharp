using FerramentasDomain.Entities;
using FerramentasDomain.Enums;
using FerramentasDomain.ValueObjects;

namespace FerramentasDomain.Factories;

public static class FerramentaFactory
{
    public static FerramentaBase Criar(
        TipoFerramenta tipo,
        Endereco endereco,
        Descricao descricao,
        Diametro diametro,
        Altura altura)
    {
        return tipo switch
        {
            TipoFerramenta.VBit => new VBit(endereco, descricao, diametro, altura),
            TipoFerramenta.TopoRaso => new FerramentaTopoRaso(endereco, descricao, diametro, altura),
            _ => throw new ArgumentException("Tipo de ferramenta inválido.")
        };
    }
}
