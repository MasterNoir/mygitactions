using GitHubActionsMain;

namespace GitHubActionsTests
{
    public class Tests
    {
        Calculator _calculator = new Calculator();

        [Test]
        public void Test_Add()
        {
            Assert.AreEqual(5, _calculator.Add(2, 3));
        }

        [Test]
        public void Test_Subtract()
        {
            Assert.AreEqual(1, _calculator.Subtract(3, 2));
        }

        [Test]
        public void Test_Multiply()
        {
            Assert.AreEqual(6, _calculator.Multiply(2, 3));
        }

        [Test]
        public void Test_Divide()
        {
            Assert.AreEqual(2, _calculator.Divide(6, 3));
        }
    }
}