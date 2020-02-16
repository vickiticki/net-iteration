using System.Collections.Generic;
using Xunit;

namespace DotnetIteration
{

  public class TestClass
  {
    [Fact]
    public void Yelling()
    {
      var expected = new List<string> { "NOW", "IS", "THE", "BEST", "TIME" };
      var data = new List<string> { "now", "is", "the", "best", "time" };
      Assert.Equal(expected, Iteration.Yelling(data));
    }

  }
}