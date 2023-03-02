using TddKata.Contracts;

namespace TddKata.Handlers
{
    public class CreateUserRequest
    {
        public UserId UserId { get; set; }

        public RoleId RoleId { get; set; }
    }
}