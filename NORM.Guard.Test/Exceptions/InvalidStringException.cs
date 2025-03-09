namespace NORM.Guard.Test.Exceptions;

public class InvalidStringException:Exception
{
    public InvalidStringException()
    {
        
    }
    public InvalidStringException(string parameter) : base(parameter)
    {
    }

    public InvalidStringException(string message, Exception innerException) : base(message, innerException)
    {
    }

}
