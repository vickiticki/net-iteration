using Xunit;

namespace DotnetIteration
{

  public class TestClass
  {
    [Fact]
    public void No_name_given()
    {
      Assert.Equal("Hello", Hello.Speak());
    }

  }
}