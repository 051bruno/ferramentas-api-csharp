using FerramentasDomain.ValueObjects;

namespace FerramentasDomain.Entities;

public abstract class Ferramenta
{
    public Guid Id { get; private set; } = Guid.NewGuid();
    public Endereco Endereco { get; private set; }
    public Descricao Descricao { get; private set; }
    public Diametro Diametro { get; private set; }
    public Altura Altura { get; private set; }

    protected Ferramenta(Endereco endereco, Descricao descricao, Diametro diametro, Altura altura)
    {
        Endereco = endereco;
        Descricao = descricao;
        Diametro = diametro;
        Altura = altura;
    }

    public abstract string Path(); // Polimorfismo aqui
}
