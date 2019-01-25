using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using ReactAbpProject.Configuration;
using ReactAbpProject.Web;

namespace ReactAbpProject.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class ReactAbpProjectDbContextFactory : IDesignTimeDbContextFactory<ReactAbpProjectDbContext>
    {
        public ReactAbpProjectDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<ReactAbpProjectDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            ReactAbpProjectDbContextConfigurer.Configure(builder, configuration.GetConnectionString(ReactAbpProjectConsts.ConnectionStringName));

            return new ReactAbpProjectDbContext(builder.Options);
        }
    }
}
