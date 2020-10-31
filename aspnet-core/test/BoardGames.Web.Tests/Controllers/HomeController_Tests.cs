using System.Threading.Tasks;
using BoardGames.Models.TokenAuth;
using BoardGames.Web.Controllers;
using Shouldly;
using Xunit;

namespace BoardGames.Web.Tests.Controllers
{
    public class HomeController_Tests: BoardGamesWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}