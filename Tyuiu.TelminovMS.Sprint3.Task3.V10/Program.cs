using Tyuiu.TelminovMS.Sprint3.Task3.V10.Lib;

namespace Tyuiu.TelminovMS.Sprint3.Task3.V10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Тельминов М. С. | ИСТНб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Оператор цикла do-while                                           *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #10                                                             *");
            Console.WriteLine("* Выполнил: Тельминов Максим Сергеевич | ИСТНб-26-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Используя цикл foreach удалить из строки все буквы p в строке: gdfppf   *");
            Console.WriteLine("* vfppt p                                                                 *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");


            string value = "gdfppf vfppt p";
            char item = 'p';


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            var res = ds.DeleteCharInString(value, item);

            Console.WriteLine(res);

            Console.ReadKey();
        }
    }
}
