using FerramentasDomain.Entities;

namespace FerramentasDomain.Repositories;

public interface IFerramentaRepository
{
    void Adicionar(FerramentaBase ferramenta);
    FerramentaBase? GetById(Guid id);
    IEnumerable<FerramentaBase> GetList();
    void Atualizar(FerramentaBase ferramenta);
    void Remover(Guid id);
}
