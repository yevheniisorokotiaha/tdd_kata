namespace TddKata.Contracts
{
    public class Result<T>
    {
        public Result(T value)
        {
            Value = value;
        }

        public Result(Error error)
        {
            Error = error;
        }

        public T Value { get; }

        public Error Error { get; }

        public bool IsSuccessful => Error == null;
    }
}