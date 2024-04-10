
namespace ThomasGregTest.Application.Services
{
    public class ClienteService : IClienteService
    {
        private readonly IClienteRepository<Cliente> clienteRepository;
        private readonly ILogradouroRepository<Logradouro> logradouroRepository;
        private readonly IMapper mapper;

        public ClienteService(IMapper mapper, IClienteRepository<Cliente> clienteRepository, ILogradouroRepository<Logradouro> logradouroRepository)
        {
            this.mapper = mapper;
            this.clienteRepository = clienteRepository;
            this.logradouroRepository = logradouroRepository;
        }

        public async Task<Cliente> Adicionar(ClienteRequest cliente)
        {
            var _cliente = mapper.Map<Cliente>(cliente);
            var result = await clienteRepository.Adicionar(_cliente);

            return result;
        }

        public async Task<ClienteRequest?> AdicionarComEnderecos(ClienteRequest cliente)
        {
            var _cliente = mapper.Map<Cliente>(cliente);
            var result = await clienteRepository.Adicionar(_cliente);
            if(result != null && cliente?.Logradouros.Count() > 0)
            {
                foreach (var item in cliente.Logradouros)
                {
                    var logradouro = mapper.Map<Logradouro>(item);
                    await logradouroRepository.Adicionar(logradouro);
                }

                var lista = await clienteRepository.ObterComEnderecos(result.Id);
                if (lista == null) throw new Exception("Não foi possivel adiconar os dados!");
                return lista;
            }
            
            return new ClienteRequest();
        }

        public async Task<Cliente> Atualizar(ClienteRequest cliente)
        {
            var _cliente = mapper.Map<Cliente>(cliente);
            var _clienteExistente = await clienteRepository.ObterPorEmail(_cliente.Email);
            if(_clienteExistente?.Id != cliente.Id) throw new Exception("Já existe um cliente com este email!");

            var result = await clienteRepository.Atualizar(_cliente);

            return result;
        }

        public async Task<Cliente> Obter(int id)
        {
            return await clienteRepository.Obter(id);
        }

        public async Task<ClienteRequest?> ObterComEnderecos(int id)
        {
            return await clienteRepository.ObterComEnderecos(id);
        }

        public Task<Cliente?> ObterPorEmail(string email)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Cliente>> ObterTodos()
        {
            return await clienteRepository.ObterTodos();
        }

        public async Task<bool> Remover(int id)
        {
            if (id <= 0) throw new Exception("É necessário enviar o ID!");
            return await clienteRepository.Remover(id);
        }
    }
}
