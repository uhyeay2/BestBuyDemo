using BestBuyDemo.Data.Interfaces;
using BestBuyDemo.Domain.Interfaces;
using System.Data.SqlClient;

namespace BestBuyDemo.Data.DapperWrapper
{
    internal class DbConnectionFactory : IDbConnectionFactory
    {
        private readonly IConfig _config;

        public DbConnectionFactory(IConfig config)
        {
            _config = config;
        }

        SqlConnection IDbConnectionFactory.NewConnection()
        {
            return new SqlConnection(_config.GetConnectionString());
        }
    }
}
