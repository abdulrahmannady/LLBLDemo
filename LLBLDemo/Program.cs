using Demo.DatabaseSpecific;
using Demo.Linq;
using SD.LLBLGen.Pro.DQE.SqlServer;
using SD.LLBLGen.Pro.ORMSupportClasses;
using System.Data.SqlClient;
using System.Linq;
using Views.Persistence;

namespace LLBLDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // to connect to database
            Conf.LLBLGen();
            // any I/O operation need to use Using();
            using (var adapter = new DataAccessAdapter())
            {
                var metaData = new LinqMetaData(adapter);
                var user = from u in metaData.User
                            where u.Id == 1
                            select u;

                //var userEntity = user.FirstOrDefault();

                var userView = user.ProjectToUserView().FirstOrDefault();
                var str = userView.UserRoles.FirstOrDefault().Role.NameArabic;

            }

        }
    }

    // Data transfer object
    public class UserRolesDto
    {
        public int Id { get; set; }

        public string RoleName { get; set; }
    }
    public class UserDto 
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public UserRolesDto UserRoles { get; set; }
    }

    public class Conf
    {
        public static void LLBLGen()
        {
            RuntimeConfiguration.AddConnectionString("ConnectionString.SQL Server (SqlClient)", "Server=.\\SQLEXPRESS;Database=FluentMigratorDemo;Trusted_Connection=True;");
            RuntimeConfiguration.ConfigureDQE<SQLServerDQEConfiguration>(c =>
            {
                c.AddDbProviderFactory(typeof(SqlClientFactory));
            });
        }
    }
}
