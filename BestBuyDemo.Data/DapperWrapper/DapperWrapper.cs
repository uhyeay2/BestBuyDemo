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

        async Task<int> IDapperWrapper.ExecuteAsync(IDapperRequest request)
        {
            using var connection = _dbConnectionFactory.NewConnection();

            connection.Open();

            return await connection.ExecuteAsync(request.GenerateSql(), request.GenerateParameters());
        }

        async Task<TOutput> IDapperWrapper.FetchAsync<TOutput>(IDapperRequest request)
        {
            using var connection = _dbConnectionFactory.NewConnection();

            connection.Open();

            return await connection.QueryFirstOrDefaultAsync<TOutput>(request.GenerateSql(), request.GenerateParameters());
        }

        async Task<IEnumerable<TOutput>> IDapperWrapper.FetchListAsync<TOutput>(IDapperRequest request)
        {
            using var connection = _dbConnectionFactory.NewConnection();

            connection.Open();

            return await connection.QueryAsync<TOutput>(request.GenerateSql(), request.GenerateParameters());
        }
    }
}
