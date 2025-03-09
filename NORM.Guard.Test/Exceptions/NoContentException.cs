namespace NORM.Guard.Test.Exceptions;

public class NoContentException :Exception
{
    public NoContentException()
    {
        
    }
    public NoContentException(string message) : base(message)
    {

    }
    public NoContentException(string message, Exception innerException) : base(message, innerException)
    {
    }


}
