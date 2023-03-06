using Xunit;
using System.Security.Claims;
using FluentAssertions;

namespace TddKata.Tests
{
    public class AuthorizationHandler_Tests
    {
        [Fact]
        public void AuthorizeUser_ReturnSuccessResult_WhenNewUser() {
            var authorizationHandler = new AuthorizationHandler();
            var claim = new ClaimsPrincipal();
            var unit = authorizationHandler.AuthorizeUser(claim);
            unit.IsSuccessful.Should().Be(true);
		}
        [Fact]
        public void AuthorizeUser_ReceiveVisitorRole_WhenNewUser() { 
        }
    }
}
