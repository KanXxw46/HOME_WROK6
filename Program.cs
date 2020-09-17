using System;
using System.Data.SqlClient;
using System.Data.Common;
namespace Hw_06
{
    class Program
    {
        static void Main(string[] args)
        {
            DbProviderFactories.RegisterFactory("mssql", SqlClientFactory.Instance);
            DbProviderFactory factory = DbProviderFactories.GetFactory("mssql");

            DbConnection connection = factory.CreateConnection();
            connection.ConnectionString = "Server = (localdb)\\MSSQLLocalDB;Database = Hw_06;Trusted_Connection = True";
            connection.Open();

            DbTransaction transaction = connection.BeginTransaction();

            DbCommand command = factory.CreateCommand();
            command.CommandText = $"insert into Users(Id,Name) values (@Id,@Name);";
            command.Connection = connection;
        }
    }
}
