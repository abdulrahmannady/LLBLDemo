using Demo;
using Demo.DatabaseSpecific;
using Demo.EntityClasses;
using Demo.Linq;
using SD.LLBLGen.Pro.DQE.SqlServer;
using SD.LLBLGen.Pro.LinqSupportClasses;
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

                // Here I Add the joining to the UserEntity Class so I could access userRoles for this spacific user and Role too
                var prefetchPath = new SD.LLBLGen.Pro.ORMSupportClasses.PrefetchPath2(EntityType.UserEntity);
                var path = prefetchPath.Add(UserEntity.PrefetchPathUserRoles);
                path.SubPath.Add(UserRoleEntity.PrefetchPathRole);

                var userEntity = user.WithPath(prefetchPath).FirstOrDefault();

                userEntity.UserRoles.FirstOrDefault().Role.NameArabic = "xxx";

                adapter.SaveEntity(userEntity);


                //var userView = user.ProjectToUserView().FirstOrDefault();
                //userView.UserRoles.FirstOrDefault().Role.NameArabic = "xxx"; // this is illeagel as view is just for VIEWING data and query database don't meant to set values

                //adapter.SaveEntity(userView); also SaveEntity() takes ClassEntity type not View type so this is enforced by ORM
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
