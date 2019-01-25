using System.Data.Common;
using Microsoft.EntityFrameworkCore;



namespace ReactAbpProject.EntityFrameworkCore
{
    public static class ReactAbpProjectDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<ReactAbpProjectDbContext> builder, string connectionString)
        {
            builder.UseMySql(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<ReactAbpProjectDbContext> builder, DbConnection connection)
        {
            
            builder.UseMySql(connection);
        }
    }
}
