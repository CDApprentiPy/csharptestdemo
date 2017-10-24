using System;
using Xunit;
using proj.Controllers;
using proj.Models;
using Microsoft.AspNetCore.Mvc;

namespace test
{
    public class UnitTest1
    {
        HomeController _hc;
        public UnitTest1()
        {
            _hc = new HomeController();
        }
        [Fact]
        public void IndexReturnsView()
        {
            var result = _hc.Index();
            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void CanSeeDachiName()
        {
            Dachi bob = _hc._dachi;
            Assert.True(bob.name == "Bobbert", "The name isnt wright!!!!!!!");
        }
    }
}
