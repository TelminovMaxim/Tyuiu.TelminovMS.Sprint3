using Tyuiu.TelminovMS.Sprint3.Task1.V20.Lib;

namespace Tyuiu.TelminovMS.Sprint3.Task1.V20.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckValid()
        {
            DataService ds = new DataService();

            int startValue = 1;
            int stopValue = 16;

            var res = ds.GetSumSeries(startValue, stopValue);
            double wait = 51191.405;

            Assert.AreEqual(wait, res);
        }
    }
}
