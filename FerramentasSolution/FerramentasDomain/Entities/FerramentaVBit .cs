using FerramentasDomain.ValueObjects;

namespace FerramentasDomain.Entities;

public class FerramentaVBit : FerramentaBase
{
    public FerramentaVBit(Endereco endereco, Descricao descricao, Diametro diametro, Altura altura)
        : base(endereco, descricao, diametro, altura)
    {
    }

    public override string Path() => "subir nos cantos";
}
