
namespace ThomasGregTest.Application.Services
{
    public class LogradouroService : ILogradouroService
    {
        private readonly ILogradouroRepository<Logradouro> logradouroRepository;
        private readonly IMapper mapper;

        public LogradouroService(IMapper mapper, ILogradouroRepository<Logradouro> logradouroRepository)
        {
            this.mapper = mapper;
            this.logradouroRepository = logradouroRepository;
        }

        public async Task<Logradouro> Adicionar(LogradouroRequest logradouro)
        {
            var _logradouro = mapper.Map<Logradouro>(logradouro);
            var result = await logradouroRepository.Adicionar(_logradouro);
            return result;
        }

        public async Task<Logradouro> Atualizar(LogradouroRequest logradouro)
        {
            var _logradouro = mapper.Map<Logradouro>(logradouro);
            var result = await logradouroRepository.Atualizar(_logradouro);

            return result;
        }

        public async Task<Logradouro> Obter(int id)
        {
            return await logradouroRepository.Obter(id);
        }

        public async Task<IEnumerable<Logradouro>> ObterTodos()
        {
            return await logradouroRepository.ObterTodos();
        }

        public async Task<bool> Remover(int id)
        {
            return await logradouroRepository.Remover(id);
        }
    }
}
