using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp1;
 
namespace WitchSagaTest
{
    [TestClass]
    public class WitchSagaTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            WitchSaga saga = new WitchSaga();
            saga.Given(13, 14);
            saga.Given(13, 18);
            //saga.Given(10, 11);
            saga.FindAverage();

            double expected = 6.5;
            double actual = saga.Average;
            Assert.AreEqual(expected, actual,"Average is not correctly");
        }
    }
}
