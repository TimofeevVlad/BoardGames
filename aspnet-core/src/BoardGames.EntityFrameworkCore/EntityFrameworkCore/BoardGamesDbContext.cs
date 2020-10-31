using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using BoardGames.Authorization.Roles;
using BoardGames.Authorization.Users;
using BoardGames.MultiTenancy;
using Abp.Localization;

namespace BoardGames.EntityFrameworkCore
{
    public class BoardGamesDbContext : AbpZeroDbContext<Tenant, Role, User, BoardGamesDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public BoardGamesDbContext(DbContextOptions<BoardGamesDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ApplicationLanguageText>()
                .Property(p => p.Value)
                .HasMaxLength(100); // any integer that is smaller than 10485760
        }
    }
}
