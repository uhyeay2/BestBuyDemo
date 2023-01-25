namespace BestBuyDemo.Data.DapperWrapper.DapperRequests
{
    internal class GetAllProducts : BaseParameterlessRequest
    {
        public override string GenerateSql() => _sql;

        private const string _sql = "SELECT * FROM Products";
    }
}
