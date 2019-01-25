using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using ReactAbpProject.Authorization.Roles;
using ReactAbpProject.Authorization.Users;
using ReactAbpProject.MultiTenancy;

namespace ReactAbpProject.EntityFrameworkCore
{
    public class ReactAbpProjectDbContext : AbpZeroDbContext<Tenant, Role, User, ReactAbpProjectDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public ReactAbpProjectDbContext(DbContextOptions<ReactAbpProjectDbContext> options)
            : base(options)
        {
        }
    }
}
