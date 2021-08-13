using Articles.Models;
using Microsoft.AspNetCore.Mvc.Testing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Articles.TestUnit
{
    public class HomeTest : IClassFixture<WebApplicationFactory<Startup>>
    {
        public HomeTest()
        {

        }

    }
}
