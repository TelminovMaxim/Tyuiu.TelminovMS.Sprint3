using Tyuiu.TelminovMS.Sprint3.Task7.V30.Lib;

namespace Tyuiu.TelminovMS.Sprint3.Task7.V30.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckValid()
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;

            double[] res = ds.GetMassFunction(startValue, stopValue);
            double[] wait = new double[11] { -15.6, -12.35, -10.72, -8.88, -2.16, 3.25, 6.64, 10.3, 16.17, 28.1, 38.41 };

            CollectionAssert.AreEqual(wait, res);
        }
    }
}
