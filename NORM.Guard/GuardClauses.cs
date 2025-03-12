using System.Text.RegularExpressions;

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
    public static void AgainstEmptyCollection<T>(IEnumerable<T> collection, string parameter)
    {
        if (collection == null || !collection.Any())
            throw new ArgumentException(parameter);
    }
    public static void AgainstEmptyCollection<T, TException>(IEnumerable<T> collection, string parameter) where TException : Exception, new()
    {
        if (collection == null || !collection.Any())
            ThrowException<TException>(parameter);
    }
    public static void AgainstCountEquals<T>(IEnumerable<T> collection, int count, string parameter)
    {
        if (collection == null || collection.Count() != count)
            throw new ArgumentException(parameter);
    }
    public static void AgainstCountEquals<T, TException>(IEnumerable<T> collection, int count, string parameter) where TException : Exception, new()
    {
        if (collection == null || collection.Count() != count)
            ThrowException<TException>(parameter);
    }
    public static void AgainstCountGreaterThan<T>(IEnumerable<T> collection, int count, string parameter)
    {
        if (collection == null || collection.Count() > count)
            throw new ArgumentException(parameter);
    }
    public static void AgainstCountGreaterThan<T, TException>(IEnumerable<T> collection, int count, string parameter) where TException : Exception, new()
    {
        if (collection == null || collection.Count() > count)
            ThrowException<TException>(parameter);
    }
    public static void AgainstCountGreaterThanOrEquals<T>(IEnumerable<T> collection, int count, string parameter)
    {
        if (collection == null || collection.Count() >= count)
            throw new ArgumentException(parameter);
    }
    public static void AgainstCountGreaterThanOrEquals<T, TException>(IEnumerable<T> collection, int count, string parameter) where TException : Exception, new()
    {
        if (collection == null || collection.Count() >= count)
            ThrowException<TException>(parameter);
    }
    public static void AgainstCountLessThan<T>(IEnumerable<T> collection, int count, string parameter)
    {
        if (collection == null || collection.Count() < count)
            throw new ArgumentException(parameter);
    }
    public static void AgainstCountLessThan<T, TException>(IEnumerable<T> collection, int count, string parameter) where TException : Exception, new()
    {
        if (collection == null || collection.Count() < count)
            ThrowException<TException>(parameter);
    }
    public static void AgainstCountLessThanOrEquals<T>(IEnumerable<T> collection, int count, string parameter)
    {
        if (collection == null || collection.Count() <= count)
            throw new ArgumentException(parameter);
    }
    public static void AgainstCountLessThanOrEquals<T, TException>(IEnumerable<T> collection, int count, string parameter) where TException : Exception, new()
    {
        if (collection == null || collection.Count() <= count)
            ThrowException<TException>(parameter);
    }
    public static void AgainstCountNotEquals<T>(IEnumerable<T> collection, int count, string parameter)
    {
        if (collection == null || collection.Count() != count)
            throw new ArgumentException(parameter);
    }
    public static void AgainstCountNotEquals<T, TException>(IEnumerable<T> collection, int count, string parameter) where TException : Exception, new()
    {
        if (collection == null || collection.Count() != count)
            ThrowException<TException>(parameter);
    }
    public static void AgainstIntParse(string value, string parameter)
    {
        if (!int.TryParse(value, out int _))
            throw new ArgumentException(parameter);
    }
    public static void AgainstIntParse<TException>(string value, string parameter) where TException : Exception, new()
    {
        if (!int.TryParse(value, out int _))
            ThrowException<TException>(parameter);
    }
    public static void AgainstGuidParse(string value, string parameter)
    {
        if (!Guid.TryParse(value, out Guid _))
            throw new ArgumentException(parameter);
    }
    public static void AgainstGuidParse<TException>(string value, string parameter) where TException : Exception, new()
    {
        if (!Guid.TryParse(value, out Guid _))
            ThrowException<TException>(parameter);
    }
    public static void AgainstDateTimeParse(string value, string parameter)
    {
        if (!DateTime.TryParse(value, out DateTime _))
            throw new ArgumentException(parameter);
    }
    public static void AgainstDateTimeParse<TException>(string value, string parameter) where TException : Exception, new()
    {
        if (!DateTime.TryParse(value, out DateTime _))
            ThrowException<TException>(parameter);
    }
    public static void AgainstDateTimeOffsetParse(string value, string parameter)
    {
        if (!DateTimeOffset.TryParse(value, out DateTimeOffset _))
            throw new ArgumentException(parameter);
    }
    public static void AgainstDateTimeOffsetParse<TException>(string value, string parameter) where TException : Exception, new()
    {
        if (!DateTimeOffset.TryParse(value, out DateTimeOffset _))
            ThrowException<TException>(parameter);
    }
    public static void AgainstDoubleParse(string value, string parameter)
    {
        if (!double.TryParse(value, out double _))
            throw new ArgumentException(parameter);
    }
    public static void AgainstDoubleParse<TException>(string value, string parameter) where TException : Exception, new()
    {
        if (!double.TryParse(value, out double _))
            ThrowException<TException>(parameter);
    }
    public static void AgainstNegativeOrZero(int value, string parameter)
    {
        if (value <= 0)
            throw new ArgumentOutOfRangeException(parameter);
    }
    public static void AgainstNegativeOrZero<TException>(int value, string parameter) where TException : Exception, new()
    {
        if (value <= 0)
            ThrowException<TException>(parameter);
    }
    public static void AgainstEmailControl(string email, string parameter)
    {
        AgainstInvalidString(email, "Email is not null or empty");

        const string emailRegexPattern = "\\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\\Z";

        if (!Regex.IsMatch(email, emailRegexPattern, RegexOptions.IgnoreCase))
            throw new ArgumentException(parameter);
    }
    public static void AgainstEmailControl<TException>(string email, string parameter) where TException : Exception, new()
    {
        AgainstInvalidString<TException>(email, "Email is not null or empty");
        const string emailRegexPattern = "\\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\\Z";
        if (!Regex.IsMatch(email, emailRegexPattern, RegexOptions.IgnoreCase))
            ThrowException<TException>(parameter);
    }
    public static void AgainstContainsChar(string value,char character,string parameter)
    {
        if (value.Contains(character))
            throw new ArgumentException(parameter);
    }
    public static void AgainstContainsChar<TException>(string value, char character, string parameter) where TException : Exception, new()
    {
        if (value.Contains(character))
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
