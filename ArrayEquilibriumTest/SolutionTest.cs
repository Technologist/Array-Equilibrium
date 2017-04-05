using Array_Equilibrium;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ArrayEquilibriumTest
{
    [TestClass]
    public class SolutionTest
    {
        [TestMethod]
        public void SolutionTestMethod_EquilibriumPoint_Found()
        {
            //Given
            var given = new[] { -1, 3, -4, 5, 1, -6, 2, 1 };
            //Processing
            var actual = Solution.SolutionMethod(given);
            //Expected
            const int expected = 1;
            Assert.AreEqual(expected,actual);
        }
        [TestMethod]
        public void SolutionTestMethod_EquilibriumPoint_Not_Found()
        {
            //Given
            var given = new[] { 1, 3, -4, 5, 1, -6, 2, 1 };
            //Processing
            var actual = Solution.SolutionMethod(given);
            //Expected
            const int expected = -1;
            Assert.AreEqual(expected, actual);
        }
    }
}
