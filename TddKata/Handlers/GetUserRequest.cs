using TddKata.Contracts;

namespace TddKata.Handlers
{
    public class GetUserRequest
    {
        public UserId UserId { get; set; }

        public RoleId RoleId { get; set; }
    }
}