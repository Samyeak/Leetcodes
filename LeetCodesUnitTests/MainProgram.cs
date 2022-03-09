using NUnit.Framework;

namespace LeetCodesUnitTests
{
    [TestFixture]
    class MainProgram
    {
        [Test]
        public void TestMain()
        {
            Assert.DoesNotThrow(() =>
            {
                LeetCodes.Program.Main();
            });
        }

        
    }
}
