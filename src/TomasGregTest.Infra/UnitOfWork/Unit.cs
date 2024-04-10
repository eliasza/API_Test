using ThomasGregTest.Infra.CrossCutting.Ioc;

namespace ThomasGregTest.Infra.UnitOfWork
{
    public class Unit : IUnit
    {
        private readonly ApplicationDbContext _context;

        public Unit(ApplicationDbContext context)
        {
            _context = context;
        }

        public GenericRepository<T> GetRepository<T>() where T : class
        {
            return new GenericRepository<T>(_context);
        }
    }
}
