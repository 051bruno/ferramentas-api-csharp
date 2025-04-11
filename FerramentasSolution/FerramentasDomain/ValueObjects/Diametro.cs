namespace FerramentasDomain.ValueObjects;

public class Diametro
{
    public double Valor { get; }

    public Diametro(double valor)
    {
        if (valor <= 0 || valor >= 100)
            throw new ArgumentException("Diâmetro deve ser maior que 0 e menor que 100.");

        Valor = valor;
    }

    public override string ToString() => Valor.ToString("F2");
}
