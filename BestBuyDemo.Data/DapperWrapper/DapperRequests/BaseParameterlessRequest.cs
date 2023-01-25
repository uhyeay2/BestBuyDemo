using BestBuyDemo.Data.Interfaces;

namespace BestBuyDemo.Data.DapperWrapper.DapperRequests
{
    internal abstract class BaseParameterlessRequest : IDapperRequest
    {
        public object? GenerateParameters() => null;

        public abstract string GenerateSql();
    }
}
