namespace ThomasGregTest.DataAccess.DbAccess
{
    public interface IGenericRepository<T>
    {
        Task<IEnumerable<T>> LoadData<T, U>(string storedProcedure, U parameters);
        Task SaveData<T>(string storedProcedure, T parameters);
        Task<T> GetById(int id);
        Task<IEnumerable<T>> GetAll();
        Task<int> Add(T entity);
        Task<T> Update(T entity);
        Task<int> Delete(T entity);
    }
}
