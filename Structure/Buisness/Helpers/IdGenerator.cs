namespace Buisness.Helpers;

public class IdGenerator
{
    public static string Generate()
        {
        return Guid.NewGuid().ToString();
        }
}
