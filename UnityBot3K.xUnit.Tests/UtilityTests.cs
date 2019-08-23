using Xunit;

namespace UnityBot3K.xUnit.Tests
{
    public class UtilityTests
    {
        [Fact]
        public void UnityBot3KFirstTest()
        {
            const int expected = 5;

            var actual = Utilities.MyUtility(expected);

            Assert.Equal(expected, actual);
        }
    }
}
