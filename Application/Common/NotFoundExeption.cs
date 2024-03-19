namespace Application.Common;

public class NotFoundExeption : Exception
{
    public NotFoundExeption(string message) : base(message)
    {
    }
}
