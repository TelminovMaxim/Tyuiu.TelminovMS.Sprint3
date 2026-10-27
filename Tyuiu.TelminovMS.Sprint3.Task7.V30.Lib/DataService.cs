using System.Reflection.Metadata.Ecma335;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.TelminovMS.Sprint3.Task7.V30.Lib
{




    public class DataService : ISprint3Task7V30
    {


        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] sp = new double[11];
            int i = 0;

            for (int x =  startValue; x <= stopValue; x++)
            {
                if ((Math.Sin(x) + 2) == 0)
                {
                    sp[i] = 0;
                }
                else
                {
                    double f = (5 * x + 2.5) / (Math.Sin(x) + 2) + 2 * x + 2;
                    sp[i] = Math.Round(f, 2);
                }

                i++;
            }

            return sp;

        }
    }
}
