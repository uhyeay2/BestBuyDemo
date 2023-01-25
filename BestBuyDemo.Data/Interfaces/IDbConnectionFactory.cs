using System.Data.SqlClient;

namespace BestBuyDemo.Data.Interfaces
{
    internal interface IDbConnectionFactory
    {
        internal SqlConnection NewConnection();
    }
}
