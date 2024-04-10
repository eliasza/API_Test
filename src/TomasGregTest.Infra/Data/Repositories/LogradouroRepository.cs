using ThomasGregTest.Domain.Models.Cliente;
using ThomasGregTest.Domain.Models.Logradouro;
using ThomasGregTest.Infra.UnitOfWork;

namespace ThomasGregTest.Infra.Data.Repositories
{
    public class LogradouroRepository : ILogradouroRepository<Logradouro>
    {
        private readonly IGenericRepository<Logradouro> repository;

        public LogradouroRepository(IUnit unit)
        {
            repository = unit.GetRepository<Logradouro>();
        }

        public async Task<Logradouro> Adicionar(Logradouro logradouro)
        {
            int id = await repository.Add(logradouro);
            if (id > 0) logradouro.Id = id;

            return logradouro;
        }

        public async Task<Logradouro> Atualizar(Logradouro logradouro)
        {
            return await repository.Update(logradouro);
        }

        public async Task<Logradouro> Obter(int id)
        {
            var _logradouro = await repository.GetById(id);
            if (_logradouro == null)
                throw new Exception("Logradouro não existe.");
            return _logradouro;
        }

        public async Task<IEnumerable<Logradouro>> ObterTodos()
        {
            var _logradouro = await repository.GetAll();
            return _logradouro;
        }

        public async Task<bool> Remover(int id)
        {
            var _logradouro = await repository.GetById(id);
            int result = await repository.Delete(_logradouro);
            return (result > 0);
        }
    }
}
