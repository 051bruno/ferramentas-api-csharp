namespace FerramentasDomain.ValueObjects;

public class Altura
{
    public double Valor { get; }

    public Altura(double valor)
    {
        if (valor <= 0 || valor >= 100)
            throw new ArgumentException("Altura deve ser maior que 0 e menor que 100.");

        Valor = valor;
    }

    public override string ToString() => Valor.ToString("F2");
}
