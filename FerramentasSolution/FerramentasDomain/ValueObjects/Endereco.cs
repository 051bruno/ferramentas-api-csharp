namespace FerramentasDomain.ValueObjects;
public class Endereco
{
    public string Valor { get; }

    public Endereco(string valor)
    {
        if (string.IsNullOrWhiteSpace(valor) || valor.Length > 50)
            throw new ArgumentException("Endereço inválido.");

        Valor = valor;
    }

    public override string ToString() => Valor;
}
