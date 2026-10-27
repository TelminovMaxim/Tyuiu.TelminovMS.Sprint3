using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.TelminovMS.Sprint3.Task4.V28.Lib
{
    public class DataService : ISprint3Task4V28
    {
        public double Calculate(int startValue, int stopValue)
        {
            double sp = 0;

            for (int x = startValue; x <= stopValue; x++)
            {
                if (x == 0)
                {
                    continue;
                }
                sp += (Math.Cos(x) + Math.Sin(x)) / x;
            }

            return Math.Round(sp, 3);
        }
    }
}
