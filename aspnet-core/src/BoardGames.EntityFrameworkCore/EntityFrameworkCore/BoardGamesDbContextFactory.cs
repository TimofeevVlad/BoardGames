using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using BoardGames.Configuration;
using BoardGames.Web;

namespace BoardGames.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class BoardGamesDbContextFactory : IDesignTimeDbContextFactory<BoardGamesDbContext>
    {
        public BoardGamesDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<BoardGamesDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            BoardGamesDbContextConfigurer.Configure(builder, configuration.GetConnectionString(BoardGamesConsts.ConnectionStringName));

            return new BoardGamesDbContext(builder.Options);
        }
    }
}
