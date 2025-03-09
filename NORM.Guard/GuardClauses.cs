namespace NORM.Guard;

public static class GuardClauses
{
    public static void AgainstNull<T, TException>(T value, string parameter) where TException : Exception, new()
    {
        if (value == null)
            ThrowException<TException>(parameter);
    }
    public static void AgainstNull<T>(T value, string parameter)
    {
        if (value == null)
            throw new ArgumentNullException(parameter);
    }
    public static void AgainstInvalidString<TException>(string value, string parameter) where TException : Exception, new()
    {
        if (string.IsNullOrWhiteSpace(value) || string.IsNullOrEmpty(value))
            ThrowException<TException>(parameter);
    }
    public static void AgainstInvalidString(string value, string parameter)
    {
        if (string.IsNullOrWhiteSpace(value) || string.IsNullOrEmpty(value))
            throw new ArgumentException(parameter);
    }
    public static void Against<TException>(bool condition, string parameter) where TException : Exception, new()
    {
        if (condition)
            ThrowException<TException>(parameter);
    }
    private static void ThrowException<TException>(string parameter) where TException : Exception, new()
    {
        var exception = Activator.CreateInstance(typeof(TException), parameter) as TException;
        if (exception == null)
            throw new ArgumentException(parameter);
        throw exception;
    }


}
