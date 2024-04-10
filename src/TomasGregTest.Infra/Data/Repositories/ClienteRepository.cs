using ThomasGregTest.Domain.Interfaces.Repositories;
using ThomasGregTest.Domain.Models.Logradouro;
using ThomasGregTest.Infra.CrossCutting.Ioc;
using ThomasGregTest.Infra.UnitOfWork;

namespace ThomasGregTest.Infra.Data.Repositories
{
    public class ClienteRepository : IClienteRepository<Cliente>
    {
        private readonly IGenericRepository<Cliente> repository;
        private readonly IDbConnection connection;

        public ClienteRepository(IUnit unit, ApplicationDbContext context)
        {
            this.repository = unit.GetRepository<Cliente>();
            this.connection = context.CreateConnection();
        }

        public async Task<Cliente> Adicionar(Cliente cliente)
        {
            int id = await repository.Add(cliente);
            if(id > 0) cliente.Id = id;

            return cliente;
        }

        public async Task<Cliente> Atualizar(Cliente cliente)
        {
            return await repository.Update(cliente);
        }

        public async Task<Cliente> Obter(int id)
        {
            var _cliente = await repository.GetById(id);
            return _cliente;
        }

        public async Task<ClienteRequest?> ObterComEnderecos(int id)
        {
            string query = $@"SELECT Id, Nome, Email, Logotipo FROM Clientes WHERE Id = {id}
                              SELECT Id, ClienteId, Endereco, Numero, Bairro, Cidade, Estado, Cep FROM Logradouros WHERE ClienteId = {id}";
            var result = await connection.QueryMultipleAsync(query);
            ClienteRequest? cliente = result.Read<ClienteRequest>().FirstOrDefault();
            List<Logradouro> listLogradouro = result.Read<Logradouro>().ToList();
            if(cliente != null)
            {
                cliente.Logradouros = listLogradouro;
            }
            
            return cliente;
        }

        public async Task<Cliente?> ObterPorEmail(string email)
        {
            string query = $"SELECT Id, Nome, Email, Logotipo FROM Clientes WHERE Email = '{email}'";
            var result = await connection.QueryAsync<Cliente>(query);

            return result.FirstOrDefault();
        }

        public async Task<IEnumerable<Cliente>> ObterTodos()
        {
            var _clientes = await repository.GetAll();
            return _clientes;
        }

        public async Task<bool> Remover(int id)
        {
            var _cliente = await repository.GetById(id);
            int result = await repository.Delete(_cliente);
            return (result > 0);
        }
    }
}
