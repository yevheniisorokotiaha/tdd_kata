namespace TddKata.Contracts
{
    public enum ErrorType
    {
        Unknown = 0,
        Conflict = 1,
        NotFound = 2,
        InternalError = 3,
        NotAuthorized = 4,
        NotAuthenticated = 5,
        ValidationFailed = 6,
    }
}