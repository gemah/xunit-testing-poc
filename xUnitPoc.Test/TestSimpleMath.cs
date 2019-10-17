using Xunit;
using xUnitPoc.Lib;

namespace xUnitPoc.Test
{
    /// <summary>
    /// Class for testing the implementation of Simple Mathetical Operations with Integer Numbers.
    /// 
    /// To be used with coverlet.msbuild, MSTest.TestFramework, xUnit, xUnit.runner.console and 
    /// xUnit.runner.visualstudio packages.
    /// 
    /// The possible commands for command line coverage testing are:
    /// 
    /// dotnet test /p:CollectCoverage=[VALUE] /p:CoverletOutputFormat=[FORMAT] /p:Threshold =[NUM]
    /// 
    /// CollectCoverage: Collect and Display Coverage data
    /// CoverletOutputFormat: Sets a format to store Coverage data to a report file
    /// Treshold: Sets the minimum acceptable Coverage value (in %)
    /// 
    /// [VALUE] = true | false | null
    /// [FORMAT] = cobertura | lcov | null | opencover
    /// [NUM] = Any valid percent value or null
    /// </summary>
    public class TestSimpleMath
    {
        [Fact]
        public void TestSimpleAdd()
        {
            Assert.Equal(0, SimpleMath.AddInt(1, -1));
        }

        [Fact]
        public void TestSimpleSub()
        {
            Assert.Equal(2, SimpleMath.SubInt(1, -1));
        }

        [Fact]
        public void TestSimpleMul()
        {
            Assert.Equal(2, SimpleMath.MulInt(1, 2));
        }

        [Fact]
        public void TestSimpleDiv()
        {
            Assert.Equal(8, SimpleMath.DivInt(8, 1));
            Assert.Equal(int.MaxValue, SimpleMath.DivInt(8, 0));
        }

        /*
        [Fact]
        public void TestMain()
        {
            Program.Main(null);
        }

        [Theory]
        [InlineData(0, -1, -1)]
        public void TestSimpleAdd(int a, int b, int result)
        {
            Assert.Equal(result, SimpleMath.AddInt(a, b));
        }

        [Theory]
        [InlineData(1, -1, 2)]
        public void TestSimpleSub(int a, int b, int result)
        {
            Assert.Equal(result, SimpleMath.SubInt(a, b));
        }

        [Theory]
        [InlineData(1, 2, 2)]
        public void TestSimpleMul(int a, int b, int result)
        {
            Assert.Equal(result, SimpleMath.MulInt(a, b));
        }

        [Theory]
        [InlineData(8, 1, 8)]
        [InlineData(8, 0, int.MaxValue)]
        public void TestSimpleDiv(int a, int b, int result)
        {
            Assert.Equal(result, SimpleMath.DivInt(a, b));
        }
        */
    }
}
