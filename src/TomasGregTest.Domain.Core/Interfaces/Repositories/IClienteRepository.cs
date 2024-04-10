using TomasGregTest.Domain.Models;

namespace TomasGregTest.Domain.Core.Interfaces.Repositories
{
    public interface IClienteRepository
    {
        Task Adicionar(Cliente cliente);
        Task Atualizar(Cliente cliente);
        Task<Cliente> Obter(int id);
        Task<Cliente> Obter(string email);
        Task<IEnumerable<Cliente>> ObterTodos();
        Task Remover(int id);
    }
}
