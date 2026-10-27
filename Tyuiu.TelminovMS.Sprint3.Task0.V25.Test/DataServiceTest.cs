using Tyuiu.TelminovMS.Sprint3.Task0.V25.Lib;

namespace Tyuiu.TelminovMS.Sprint3.Task0.V25.Test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void CheckValid()
        {
            DataService ds = new DataService();

            int value = 5;
            int startValue = 1;
            int stopValue = 14;

            double res = ds.GetSumSeries(value, startValue, stopValue);

            double wait = 0.6903673013720822;

            Assert.AreEqual(wait, res);
        }
    }
}
