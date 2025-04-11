using FerramentasDomain.ValueObjects;

namespace FerramentasDomain.Entities;

public class FerramentaTopoRaso : FerramentaBase
{
    public FerramentaTopoRaso(Endereco endereco, Descricao descricao, Diametro diametro, Altura altura)
        : base(endereco, descricao, diametro, altura)
    {
    }

    public override string Path() => "caminho tradicional";
}
