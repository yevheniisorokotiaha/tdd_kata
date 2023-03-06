using Xunit;
using System.Security.Claims;
using FluentAssertions;
using TddKata.Handlers;
using NSubstitute;

namespace TddKata.Tests
{
    public class AuthorizationHandler_Tests
    {

        private readonly CreateUserRequestHandler handlerMock;

        public AuthorizationHandler_Tests() {
            handlerMock = Substitute.For<CreateUserRequestHandler>();
        }

        [Fact]
        public void AuthorizeUser_ReturnSuccessResult_WhenNewUser() {
            var authorizationHandler = new AuthorizationHandler(handlerMock);
            var claim = new ClaimsPrincipal();
            var unit = authorizationHandler.AuthorizeUser(claim);
            unit.IsSuccessful.Should().Be(true);
		}
        [Fact]
        public void AuthorizeUser_ReceiveVisitorRole_WhenNewUser() {
			var authorizationHandler = new AuthorizationHandler(handlerMock);
			var claim = new ClaimsPrincipal();
			var unit = authorizationHandler.AuthorizeUser(claim);
            Assert.False(true);
		}
    }
}
