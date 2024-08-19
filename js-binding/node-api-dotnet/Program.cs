namespace Microsoft.JavaScript.NodeApi;

[JSExport]
public static class Program
{
    public static string Hello(string greeter)
    {
        System.Console.WriteLine($"Hello {greeter}!");
        return $"Hello {greeter}!";
    }
}
