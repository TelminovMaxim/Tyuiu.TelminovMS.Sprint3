using Tyuiu.TelminovMS.Sprint3.Task7.V30.Lib;

namespace Tyuiu.TelminovMS.Sprint3.Task7.V30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнил: Тельминов М. С. | ИСТНб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов                            *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #30                                                             *");
            Console.WriteLine("* Выполнил: Тельминов Максим Сергеевич | ИСТНб-26-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая выводит таблицу значений функции F(x) на    *");
            Console.WriteLine("* заданном диапозоне [-5; 5] с шагом 1. Произвести проверку деления на 0. *");
            Console.WriteLine("* При делении на 0 вернуть значение 0. Значение округлить до 2 знаков     *");
            Console.WriteLine("* после запятой.                                                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");


            int startValue = -5;
            int stopValue = 5;


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            var res = ds.GetMassFunction(startValue, stopValue);

            int c = 0;
            for (int i = startValue; i <= stopValue; i++)
            {
                Console.WriteLine("* X = " + i + " \tF(X) = " + res[c]);
                c++;
            }

            Console.ReadKey();
        }
    }
}
