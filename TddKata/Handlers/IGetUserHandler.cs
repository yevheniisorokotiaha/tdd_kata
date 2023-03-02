using TddKata.Contracts;

namespace TddKata.Handlers
{
    public interface IGetUserHandler
    {
        Result<User> Handle(GetUserRequest request);
    }
}