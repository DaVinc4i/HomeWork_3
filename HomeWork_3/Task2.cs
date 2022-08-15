using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeWork;

namespace HomeWork_3
{
    //2. а) С клавиатуры вводятся числа, пока не будет введён 0 (каждое число в новой строке).
    //Требуется подсчитать сумму всех нечётных положительных чисел.
    //Сами числа и сумму вывести на экран, используя tryParse.

    // решение предоставил Юрченко Н.А.

    class Task2
    {
        /// <summary>
        /// Метод создающий массив 
        /// </summary>
        /// <param name="array">Изначальный массив данных</param>
        /// <param name="number">Введеное число</param>
        /// <returns></returns>
        static void CreateArray(ref int [] array, int number)
        {
            int [] myArray = new int[array.Length+1];

            for (int i = 0; i < array.Length; i++)
            {
                myArray[i] = array[i];
            }
            myArray[array.Length] = number;

            array = myArray;
        }

        /// <summary>
        /// Метод проверяющий и выводящий на экран нечетные числа массива
        /// </summary>
        /// <param name="array">Массив данных для перебора чисел</param>
        static void PrintOdd(int [] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                    Console.Write("  " + array[i]);
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Метод проверяющий и суммирующий нечетные числа массива
        /// </summary>
        /// <param name="array">Массив данных для перебора и суммирования чисел</param>
        static int SummOdd(int[] array)
        {
            int summ=0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                     summ+= array[i];
            }
            return summ;
        }

        /// <summary>
        /// Метод проверяющий и суммирующий числа
        /// </summary>
        /// <param name="number">Введенное число</param>
        /// <param name="summOdd">Сумма нечечтных чисел</param>
        /// <returns></returns>
        static int SummOdd(int number, int summOdd)
        {   
            if (number % 2 != 0)
                    summOdd += number;
            
            return summOdd;
        }

        static string NumberOdd(int number, string numberOdd)
        {
            if (number % 2 != 0)
                numberOdd += number+" ";

            return numberOdd;
        }



        static void Main(string[] args)
        {
            var screen = new Screen();
            screen.ScreenPrint(3, 2);
            // Вызов метода ScreenPrint c предыдущей домашней работы, для вывода номера задания 
            // и домашней работы, а также вывода ФИО выполнившего студента

            Console.WriteLine("Вводите целые числа для подсчета суммы всех положительных нечётных чисел");
            Console.WriteLine("Для вывода на экран суммы и самих чисел, нажмите 0");
            Console.WriteLine();

            #region Решение задачи с использованием массива
            Console.WriteLine("Решение через массив");
            Console.WriteLine();

            string numberStr;
            int number;            

            int [] array = new int [0];

            do
            {
                Console.Write("Введите число:  ");
                numberStr = Console.ReadLine();

                bool result = int.TryParse(numberStr, out number);

                if (result)
                {
                    if (number == 0)
                        break;
                    else
                        CreateArray(ref array, number);
                }
                else
                {
                    Console.WriteLine("Ошибка ввода. Повторите ввод");
                    number = -1;
                }

            }
            while (number != 0);

            Console.WriteLine();
            Console.Write("Введенные нечетные числа: ");

            PrintOdd(array);
            Console.WriteLine("Сумма введенных нечетных чисел равна: "+SummOdd(array));

            #endregion

            #region Решение через строку и сумму        
            
            Console.WriteLine();
            Console.WriteLine("Решение через строку и сумму");
            Console.WriteLine();

            int summOdd=0;
            string numberOdd=null;

            do
            {
                Console.Write("Введите число:  ");
                numberStr = Console.ReadLine();

                bool result = int.TryParse(numberStr, out number);

                if (result)
                {
                    if (number == 0)
                        break;
                    else
                    {
                        summOdd = SummOdd(number, summOdd);
                        numberOdd = NumberOdd(number, numberOdd);
                    }

                }
                else
                {
                    Console.WriteLine("Ошибка ввода. Повторите ввод");
                    number = -1;
                }

            }
            while (number != 0);

            Console.WriteLine();
            Console.WriteLine("Введенные нечетные числа: "+numberOdd);

            
            Console.WriteLine("Сумма введенных нечетных чисел равна: " + summOdd);

            #endregion

            Console.ReadLine();


        }

    }
}
