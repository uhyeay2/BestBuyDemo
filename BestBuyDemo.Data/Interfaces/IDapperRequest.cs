namespace BestBuyDemo.Data.Interfaces
{
    internal interface IDapperRequest
    {
        internal string GenerateSql();

        internal object? GenerateParameters();
    }
}
