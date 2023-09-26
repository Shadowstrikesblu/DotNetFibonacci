namespace Leonardo.tests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        Fibonacci.RunAsync(args).Wait();
    }
}