using System;
using Xunit;
using TddKata;
using System.Security.Claims;
using FluentAssertions;
using LanguageExt;

namespace TddKata.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void AuthorizeUser_ReturnSuccessResult_WhenNewUser() {
            var authorizationHandler = new AuthorizationHandler();
            var claim = new ClaimsPrincipal();
            var unit = authorizationHandler.AuthorizeUser(claim);
            unit.IsSuccessful.Should().Be(true);
		}
    }
}
