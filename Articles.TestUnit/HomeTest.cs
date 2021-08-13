using Articles.Main;
using Microsoft.AspNetCore.Mvc.Testing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Articles.TestUnit
{
   public class HomeTest : IClassFixture<WebApplicationFactory<Startup>>
    //public class HomeTest 
    {
        private readonly WebApplicationFactory<Startup> _factory;
        public HomeTest(WebApplicationFactory<Startup> factory)
        {
            _factory = factory;

        }
        [Theory]
        [InlineData("/")]
        [InlineData("/Home/About")]
        [InlineData("/Home/ReadMore/1")]
        [InlineData("/Identity/Account/Login")]
        [InlineData("/Identity/Account/Register")]

        public async Task GetHttpRequest(string url)
        {
            //Arrange
            var client = _factory.CreateClient(); 
            // act
            var response = await client.GetAsync(url);

            //Assert
            Assert.Equal("text/html; charset=utf-8", response.Content.Headers.ContentType.ToString());

        }

    }
}
