namespace TddKata
{
    public interface ICurrentUserManager
    {
        CurrentUserContext Context { get; set; }

        CurrentUserScope BeginScope(CurrentUserContext userScope);
    }
}