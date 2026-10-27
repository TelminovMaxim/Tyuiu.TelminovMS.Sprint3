using Tyuiu.TelminovMS.Sprint3.Task3.V10.Lib;

namespace Tyuiu.TelminovMS.Sprint3.Task3.V10.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckValid()
        {
            DataService ds = new DataService();

            string value = "gdfppf vfppt p";
            char item = 'p';

            var res = ds.DeleteCharInString(value, item);
            var wait = "gdff vft ";

            Assert.AreEqual(wait, res);
        }
    }
}
