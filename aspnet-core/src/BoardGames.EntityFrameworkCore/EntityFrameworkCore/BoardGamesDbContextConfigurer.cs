using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace BoardGames.EntityFrameworkCore
{
    public static class BoardGamesDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<BoardGamesDbContext> builder, string connectionString)
        {
            builder.UseNpgsql(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<BoardGamesDbContext> builder, DbConnection connection)
        {
            builder.UseNpgsql(connection);
        }
    }
}
