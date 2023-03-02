using TddKata.Contracts;

namespace TddKata.Handlers
{
    public interface ICreateUserHandler
    {
        Result<User> Handle(CreateUserRequest request);
    }
}