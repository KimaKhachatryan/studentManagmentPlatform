namespace studentManagmentPlatform.Core.ExceptionHandling;

public class NullReferenceException : Exception
{
    public NullReferenceException() { }
    
    public NullReferenceException(string message) 
        : base(message) { }
    
    public NullReferenceException(string message, Exception innerException) 
        : base(message, innerException) { }
}