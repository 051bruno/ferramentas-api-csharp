using FerramentasDomain.Entities;
using FerramentasDomain.Repositories;

namespace FerramentasAPI.Repositories;

public class FerramentaRepositoryInMemory : IFerramentaRepository
{
    private readonly List<FerramentaBase> _ferramentas = new();

    public void Adicionar(FerramentaBase ferramenta)
    {
        _ferramentas.Add(ferramenta);
    }

    public FerramentaBase? GetById(Guid id)
    {
        return _ferramentas.FirstOrDefault(f => f.Id == id);
    }

    public IEnumerable<FerramentaBase> GetList()
    {
        return _ferramentas;
    }

    public void Atualizar(FerramentaBase ferramenta)
    {
        var existente = GetById(ferramenta.Id);
        if (existente != null)
        {
            _ferramentas.Remove(existente);
            _ferramentas.Add(ferramenta);
        }
    }

    public void Remover(Guid id)
    {
        var ferramenta = GetById(id);
        if (ferramenta != null)
        {
            _ferramentas.Remove(ferramenta);
        }
    }
}
