namespace studentManagmentPlatform.Core.ExceptionHandling;

public class PostgresException : Exception
{
    public  PostgresException() { }
    
    public PostgresException(string message) : base(message) { }
    
    public PostgresException(string message, Exception innerException) 
        : base(message, innerException) { }
}