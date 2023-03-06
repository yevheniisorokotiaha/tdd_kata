using System;
using System.Security.Claims;
using LanguageExt;
using TddKata.Contracts;
using TddKata.Handlers;

namespace TddKata
{
    public class AuthorizationHandler
    {
        private Result<Unit> HandleRequest(CreateUserRequest userRequest) {
            var handler = new CreateUserRequestHandler();
            return handler.Execute(userRequest);
        }

        public Result<Unit> AuthorizeUser(ClaimsPrincipal user) {
            var userId = new UserId(Guid.NewGuid().ToString());
            var roleId = new RoleId(Guid.NewGuid().ToString());
            var userRequest = new CreateUserRequest() { UserId = userId, RoleId = roleId };
            return HandleRequest(userRequest) ?? null;
        }
    }
}
