using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.TelminovMS.Sprint3.Task6.V30.Lib
{
    public class DataService : ISprint3Task6V30
    {
        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            int count = 0;

            for (int i = startValue; i <= stopValue; i++)
            {
                for (int k = 1; k <= i; k++)
                {
                    if (i % k == 0)
                    {
                        count += 1;
                    }
                }
            }

            return count;
        }
    }
}
