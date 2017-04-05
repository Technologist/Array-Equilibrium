using Array_Equilibrium;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ArrayEquilibriumTest
{
    [TestClass]
    public class SolutionTest
    {
        [TestMethod]
        public void SolutionTestMethod()
        {
            //Given
            var given = new[] { -5, 11, -4, 5, 1, -6, 12, 6 };
            //Processing
            var actual = Solution.SolutionMethod(given);
            //Expected
            const int expected = -1;
            Assert.AreEqual(expected,actual);
        }
    }
}
