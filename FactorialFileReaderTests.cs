using FactorialApp;
public class FileReaderStub : IFileReader
{
    public string ReadFile()
    {
        return "5"; 
    }
}

public class FactorialFileReaderTests
{
    [Fact]
    public void FactorialWithFileInputShouldWork()
    {
        var fileReader = new FileReaderStub();
        var factorial = new Factorial();
        int number = int.Parse(fileReader.ReadFile());
        Assert.Equal(120, factorial.Compute(number));
    }
}
