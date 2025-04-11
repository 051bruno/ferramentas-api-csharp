
using FerramentasDomain.Enums;

namespace FerramentasAPI.Dtos;

public class FerramentaDto
{
    public string Endereco { get; set; } = string.Empty;
    public string Descricao { get; set; } = string.Empty;
    public double Diametro { get; set; }
    public double Altura { get; set; }
    public TipoFerramenta Tipo { get; set; }
}
