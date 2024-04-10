using ThomasGregTest.DataAccess.DbAccess;
using ThomasGregTest.DataAccess.Models;

namespace ThomasGregTest.DataAccess.Data
{
    public class ClienteData
    {
        private readonly ISqlDataAccess _dataAccess;

        public ClienteData(ISqlDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }

        public Task<IEnumerable<Cliente>> DeleteCliente() =>
            _dataAccess.LoadData<Cliente, dynamic>("dbo.spClientesDelete", new { });
    }
}
