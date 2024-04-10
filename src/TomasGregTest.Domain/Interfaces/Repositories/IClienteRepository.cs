
using ThomasGregTest.Domain.Models.Cliente;

namespace ThomasGregTest.Domain.Interfaces.Repositories
{
    public interface IClienteRepository<T> : IBaseRepository<T> where T : class
    {
        /*
         * Poderá ser incluido metodos customizados aqui.
         */
        Task<Cliente?> ObterPorEmail(string email);
        Task<ClienteRequest?> ObterComEnderecos(int id);
    }
}
