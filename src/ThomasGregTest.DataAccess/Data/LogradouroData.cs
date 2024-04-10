using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThomasGregTest.DataAccess.DbAccess;
using ThomasGregTest.DataAccess.Models;

namespace ThomasGregTest.DataAccess.Data
{
    public class LogradouroData
    {
        private readonly ISqlDataAccess _dataAccess;

        public LogradouroData(ISqlDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }

        public Task<IEnumerable<Logradouro>> DeleteLogradouro() =>
            _dataAccess.LoadData<Logradouro, dynamic>("dbo.spLogradourosDelete", new { });
    }
}
