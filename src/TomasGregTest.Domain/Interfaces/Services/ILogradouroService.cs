
using ThomasGregTest.Domain.Models.Cliente;

namespace ThomasGregTest.Domain.Interfaces.Services
{
    public interface ILogradouroService
    {
        Task<Logradouro> Adicionar(LogradouroRequest cliente);
        Task<Logradouro> Atualizar(LogradouroRequest cliente);
        Task<Logradouro> Obter(int id);
        Task<IEnumerable<Logradouro>> ObterTodos();
        Task<bool> Remover(int id);
    }
}
