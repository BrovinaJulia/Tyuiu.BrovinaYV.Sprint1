using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.BrovinaYV.Sprint1.Task5.V6.Lib;

namespace Tyuiu.BrovinaYV.Sprint1.Task5.V6
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнила: Бровина Ю. В. | АСОиУБ-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Алгоритмы линейной структуры                                      *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #6                                                              *");
            Console.WriteLine("* Выполнила Бровина Юлия Викторовна | АСОиУБ-23-2                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая решает задачу                               *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Введите число от 1 до 365, чтобы узнать какой этот день будет днем недели");
            int k ;
            k = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            if (k < 1 || k > 365) Console.WriteLine("Введите число от 1 до 365!");

            else Console.WriteLine(ds.Calculate(k));
            if (ds.Calculate(k) == 1) Console.WriteLine("Этот день Понедельник");
            else if (ds.Calculate(k) == 2) Console.WriteLine("Этот день Вторник");
            else if (ds.Calculate(k) == 3) Console.WriteLine("Этот день Среда");
            else if (ds.Calculate(k) == 4) Console.WriteLine("Этот день Четверг");
            else if (ds.Calculate(k) == 5) Console.WriteLine("Этот день Пятница");
            else if (ds.Calculate(k) == 6) Console.WriteLine("Этот день Суббота");
            else if (ds.Calculate(k) == 7) Console.WriteLine("Этот день Воскресенье");
            Console.ReadKey();
            
        }
    }
}
