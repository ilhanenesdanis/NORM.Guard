using NORM.Guard.Test.Exceptions;

namespace NORM.Guard.Test.Tests;

public class GuardClausesTest
{
    [Fact]
    public void AgainstNull_ThrowsDefaultException()
    {
        Assert.Throws<ArgumentNullException>(() => GuardClauses.AgainstNull<object>(null, "Value is Not Null"));
    }
    [Fact]
    public void AgainstNull_ThrowsCustomException()
    {
        Assert.Throws<NullException>(() => GuardClauses.AgainstNull<object, NullException>(null, "Value is Not Null"));
    }
    [Fact]
    public void AgainstInvalidString_ThrowsDefaultException()
    {
        Assert.Throws<ArgumentException>(() => GuardClauses.AgainstInvalidString(string.Empty, "Value is Not Null or Empty"));
    }
    [Fact]
    public void AgainstInvalidString_ThrowsCustomException()
    {
        Assert.Throws<InvalidStringException>(() => GuardClauses.AgainstInvalidString<InvalidStringException>(string.Empty, "Value is Not Null or Empty"));
    }
    [Fact]
    public void Against_Condition()
    {
        Assert.Throws<ArgumentException>(() => GuardClauses.Against<ArgumentException>(true, "Condition is True"));
    }
}
