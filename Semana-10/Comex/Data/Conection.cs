using Comex.Modelos;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace Comex.Data
{
    public class Connection
    {
        private string conectionString = "Data Source=(localdb)\\MSSQLLocalDB;" +
            "Initial Catalog=ComexDB;" +
            "Integrated Security=True;Connect Timeout=30;" +
            "Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;" +
            "Multi Subnet Failover=False"; 

        public SqlConnection ObterConexao()
        {
            return new SqlConnection(conectionString);
        }
    }
}
