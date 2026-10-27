using Tyuiu.TelminovMS.Sprint3.Task2.V5.Lib;

namespace Tyuiu.TelminovMS.Sprint3.Task2.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckValid()
        {
            DataService ds = new DataService();

            double value = 0.75;
            int startValue = 1;
            int stopValue = 20;

            var res = ds.GetSumSeries(value, startValue, stopValue);
            double wait = -0.206;

            Assert.AreEqual(wait, res);

        }
    }
}
