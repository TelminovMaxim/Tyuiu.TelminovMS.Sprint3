using Tyuiu.TelminovMS.Sprint3.Task6.V30.Lib;

namespace Tyuiu.TelminovMS_Sprint3.Task6.V30.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckValid()
        {
            DataService ds = new DataService();

            int startValue = 11;
            int stopValue = 17;

            var res = ds.GetSumTheDivisors(startValue, stopValue);
            int wait = 25;

            Assert.AreEqual(wait, res);


        }
    }
}
