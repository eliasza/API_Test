namespace ThomasGregTest.Infra.UnitOfWork
{
    public interface IUnit
    {
        GenericRepository<T> GetRepository<T>() where T : class;
    }
}
