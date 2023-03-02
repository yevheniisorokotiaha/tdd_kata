# Requirements

`AuthorizationHandler` is wired into ASP.NET and responsible to authorize user requests based on `ClaimsPrincipal` instance.

If authorization is successful it should return success result, otherwise error.

Authorization handler should register new user if it is the first time user is authorized:

* new users should be assigned `Visitor` role
* user id `anonym@myapp.idp` is reserved by the system

User Id should be taken from `sub` or `http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier` claims.

In case of successful authorization User identity should be set into `ICurrentUserManager.CurrentUserContext`.

Calls to `ICreateUserHandler` and `IGetUserHandler` should have a valid user context configured.

In order to support tests in non-production environment (`IApplicationInfo.IsRunningProduction`) when user id is `knownIdString` it is created with `SysAdmin` role.
