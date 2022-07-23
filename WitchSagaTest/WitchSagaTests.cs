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
             saga.Given(10, 12);
             saga.Given(13, 17);
            //saga.Given(10, 11);
            saga.FindAverage();

            double expected = 4.5;
            double actual = saga.Average;
            Assert.AreEqual(expected, actual,"Average not debited correctly");
        }
    }
}
