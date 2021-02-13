using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.реализовать метод деления двух чисел. Внутри метода проверять входящие параметры.Если они не заданы, то генерировать исключение ArgumentNullException.Если 
            //    делитель равен нулю, то генерировать исключение ArgumentException.

            //2.Написать программу, которая обращается к элементам 
            //    массива по индексу и выходит за его пределы.
            //    После обработки исключения вывести
            //    в финальном блоке сообщение о завершении обработки массива.
            int[] array = new int[3];
            try
            {
                array[4] = 4;
                Console.WriteLine("нет такого индекса");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка " + ex.Message);
            }
            finally
            {
                Console.WriteLine("завершение обработки массива");
            }
            Class class1 = new Class();
            class1.Argument(2, 0); Console.ReadLine();
        }
    }
}
