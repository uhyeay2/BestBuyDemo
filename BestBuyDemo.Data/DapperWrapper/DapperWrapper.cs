using BestBuyDemo.Data.Interfaces;
using Dapper;

namespace BestBuyDemo.Data.DapperWrapper
{
    internal class DapperWrapper : IDapperWrapper
    {
        private readonly IDbConnectionFactory _dbConnectionFactory;

        public DapperWrapper(IDbConnectionFactory dbConnectionFactory)
        {
            _dbConnectionFactory = dbConnectionFactory;
        }

        Task<int> IDapperWrapper.ExecuteAsync(IDapperRequest request)
        {
            using var connection = _dbConnectionFactory.NewConnection();

            connection.Open();

            return connection.ExecuteAsync(request.GenerateSql(), request.GenerateParameters());
        }

        Task<TOutput> IDapperWrapper.FetchAsync<TOutput>(IDapperRequest request)
        {
            using var connection = _dbConnectionFactory.NewConnection();

            connection.Open();

            return connection.QueryFirstOrDefaultAsync<TOutput>(request.GenerateSql(), request.GenerateParameters());
        }

        Task<IEnumerable<TOutput>> IDapperWrapper.FetchListAsync<TOutput>(IDapperRequest request)
        {
            using var connection = _dbConnectionFactory.NewConnection();

            connection.Open();

            return connection.QueryAsync<TOutput>(request.GenerateSql(), request.GenerateParameters());
        }
    }
}
