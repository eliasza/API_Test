
using ThomasGregTest.Domain.Models.Cliente;

namespace ThomasGregTest.Domain.Interfaces.Services
{
    public interface IClienteService
    {
        Task<Cliente> Adicionar(ClienteRequest cliente);
        Task<ClienteRequest?> AdicionarComEnderecos(ClienteRequest cliente);
        Task<Cliente> Atualizar(ClienteRequest cliente);
        Task<Cliente> Obter(int id);
        Task<ClienteRequest?> ObterComEnderecos(int id);
        Task<Cliente?> ObterPorEmail(string email);
        Task<IEnumerable<Cliente>> ObterTodos();
        Task<bool> Remover(int id);
    }
}
