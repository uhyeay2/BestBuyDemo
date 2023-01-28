namespace BestBuyDemo.Data.DapperWrapper.DapperRequests.CategoryRequests
{
    internal class GetAllCategories : BaseParameterlessRequest
    {
        public override string GenerateSql() => _sql;

        private const string _sql = "SELECT * FROM Category";
    }
}
