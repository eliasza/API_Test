
namespace ThomasGregTest.Domain.Interfaces.Base
{
    public interface IBaseRepository<T>
    {
        Task<T> Adicionar(T obj);
        Task<T> Atualizar(T obj);
        Task<T> Obter(int id);
        Task<IEnumerable<T>> ObterTodos();
        Task<bool> Remover(int id);
    }
}
