using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeWork; //добавление библиотеки (пространства HomeWork) из предыдущей домашней работы


namespace HomeWork_3
{
    //1. а) Дописать структуру Complex, добавив метод вычитания комплексных чисел.Продемонстрировать работу структуры.
    //б) Дописать класс Complex, добавив методы вычитания и произведения чисел.Проверить работу класса.
    //в) Добавить диалог с использованием switch демонстрирующий работу класса.

    // решение предоставил Юрченко Н.А.

    public struct Complex
    {
        /// <summary>
        /// Мнимая часть комплексногоч исла
        /// </summary>
        public double im;

        /// <summary>
        /// Действительная часть комплексногоч исла
        /// </summary>
        public double re;

        /// <summary>
        /// Метод реализации сложения комплексных чисел
        /// </summary>
        /// <param name="x">Комплексное число для сложения</param>
        /// <returns></returns>
        public Complex Plus(Complex x)
        {
            Complex y = new Complex();
            y.re = re + x.re;
            y.im = im + x.im;
            return y;
        }

        /// <summary>
        /// Метод реализации сложения комплексных чисел (другая реализация)
        /// </summary>
        /// <param name="complex1">Первое комплексное число для сложения</param>
        /// <param name="complex2">Второе комплексное число для сложения</param>
        /// <returns></returns>
        public static Complex Plus(Complex complex1, Complex complex2)
        {
            Complex res = new Complex();
            res.re = complex1.re + complex2.re;
            res.im = complex1.im + complex2.im;
            return res;
        }

        /// <summary>
        /// Метод реализации вычитания комплексных чисел 
        /// </summary>
        /// <param name="x">Комплексное число, которое отнимаем</param>
        /// <returns></returns>
        public Complex Minus (Complex x)
        {
            Complex y = new Complex();
            y.re = re - x.re;
            y.im = im - x.im;
            return y;
        }

        /// <summary>
        /// Метод реализации вычитания комплексных чисел (другая реализация)
        /// </summary>
        /// <param name="complex1">Комплексное число, от которого отнимаем</param>
        /// <param name="complex2">Комплексное число, которое отнимаем</param>
        /// <returns></returns>
        public static Complex Minus (Complex complex1, Complex complex2)
        {
            Complex res = new Complex();
            res.re = complex1.re - complex2.re;
            res.im = complex1.im - complex2.im;
            return res;
        }

        public override string ToString()
        {
            return $"{re} + {im}i";
        }


    }

    public class ComplexClass
    {
        /// <summary>
        /// Мнимая часть комплексногоч исла
        /// </summary>
        public double im;

        /// <summary>
        /// Действительная часть комплексногоч исла
        /// </summary>
        public double re;

        /// <summary>
        /// Конструктор класса
        /// </summary>
        /// <param name="re">Действительная часть комплексногоч исла</param>
        /// <param name="im">Мнимая часть комплексногоч исла</param>
        public ComplexClass(double re, double im)
        {
            this.re = re;
            this.im = im;
        }

        /// <summary>
        /// Метод реализации сложения комплексных чисел 
        /// </summary>
        /// <param name="x">Комплексное число для сложения</param>
        /// <returns></returns>
        public ComplexClass Plus(ComplexClass x)
        {
            ComplexClass y = new ComplexClass(0,0);
            y.re = re + x.re;
            y.im = im + x.im;
            return y;
        }

        /// <summary>
        /// Метод реализации сложения комплексных чисел (другая реализация)
        /// </summary>
        /// <param name="complex1"></param>
        /// <param name="complex2"></param>
        /// <returns></returns>
        public static ComplexClass Plus(ComplexClass complex1, ComplexClass complex2)
        {
            ComplexClass res = new ComplexClass(0,0);
            res.re = complex1.re + complex2.re;
            res.im = complex1.im + complex2.im;
            return res;
        }
        /// <summary>
        /// Метод реализации вычитания комплексных чисел
        /// </summary>
        /// <param name="x">Вычитаемое комплексное число</param>
        /// <returns></returns>
        public ComplexClass Minus(ComplexClass x)
        {
            ComplexClass y = new ComplexClass(0, 0);
            y.re = re - x.re;
            y.im = im - x.im;
            return y;
        }

        /// <summary>
        /// Метод реализации вычитания комплексных чисел (другая реализация)
        /// </summary>
        /// <param name="complex1">Комплексное число, от которого вычитаем</param>
        /// <param name="complex2">Вычитаемое комплексное число</param>
        /// <returns></returns>
        public static ComplexClass Minus(ComplexClass complex1, ComplexClass complex2)
        {
            ComplexClass res = new ComplexClass(0,0);
            res.re = complex1.re - complex2.re;
            res.im = complex1.im - complex2.im;
            return res;
        }

        /// <summary>
        /// Метод реализации вычитания комплексных чисел
        /// </summary>
        /// <param name="x">Комплексное число</param>
        /// <returns></returns>
        public ComplexClass Multiplication(ComplexClass x)
        {
            ComplexClass y = new ComplexClass(0, 0);
            y.re = re * x.re-im*x.im;
            y.im = re * x.im+x.re*im;
            return y;
        }

        /// <summary>
        /// Метод реализации вычитания комплексных чисел (другая реализация)
        /// </summary>
        /// <param name="complex1">Первое комплексное число</param>
        /// <param name="complex2">Второе комплексное число</param>
        /// <returns></returns>
        public static ComplexClass Multiplication(ComplexClass complex1, ComplexClass complex2)
        {
            ComplexClass res = new ComplexClass(0, 0);
            res.re = complex1.re * complex2.re- complex1.im * complex2.im;
            res.im = complex1.re * complex2.im+ complex1.im * complex2.re;
            return res;
        }

        public override string ToString()
        {
            return $"{re} + {im}i";
        }

    }

    class Task1
    {
        /// <summary>
        /// Метод выводящий разделительную прямую линию на экране консоли
        /// </summary>
        public static void Line()
        {
            int i = 0;//переменная для счетчика вывода прямой линии

            while (i != Console.WindowWidth)
            {
                Console.Write("-");
                i++;
            }

            Console.WriteLine();

        }

        static void Main(string[] args)
        {
            var screen = new Screen();
            screen.ScreenPrint(3, 1);
            // Вызов метода ScreenPrint c предыдущей домашней работы, для вывода номера задания 
            // и домашней работы, а также вывода ФИО выполнившего студента

            #region Демонстрация работы сложения и вычитания структуры

            Console.WriteLine();
            Console.WriteLine("Демонстрация сложения и вычитания структуры");

            Complex complex1 = new Complex();
            complex1.re = 3;
            complex1.im = -2;

            Complex complex2 = new Complex();
            complex2.re = 1;
            complex2.im = 3;

            Console.WriteLine($"Работа с комплексными числами {complex1} и {complex2}");

            Complex complex3 = complex1.Plus(complex2);

            Console.WriteLine($"Результат сложения комплексных чисел: {complex3}");

            Complex complex4 = Complex.Plus(complex2, complex1);

            Console.WriteLine($"Результат сложения комплексных чисел: {complex4}");

            Complex complex13 = complex1.Minus(complex2);

            Console.WriteLine($"Результат вычитания комплексных чисел: {complex13}");

            Complex complex14 = Complex.Minus(complex1, complex2);

            Console.WriteLine($"Результат вычитания комплексных чисел: {complex14}");

            Line();

            #endregion

            #region Демонстрация сложения, вычитания и умножения класса


            Console.WriteLine("Демонстрация сложения, вычитания и умножения класса");

            ComplexClass complex5 = new ComplexClass(3, -2);

            ComplexClass complex6 = new ComplexClass(1, 3);
           
            Console.WriteLine($"Работа с комплексными числами {complex5} и {complex6}");

            ComplexClass complex7 = complex5.Plus(complex6);

            Console.WriteLine($"Результат сложения комплексных чисел: {complex7}");

            ComplexClass complex8 = ComplexClass.Plus(complex5, complex6);

            Console.WriteLine($"Результат сложения комплексных чисел: {complex8}");
           
            ComplexClass complex9 = complex5.Minus(complex6);

            Console.WriteLine($"Результат вычитания комплексных чисел: {complex9}");

            ComplexClass complex10 = ComplexClass.Minus(complex5, complex6);

            Console.WriteLine($"Результат вычитания комплексных чисел: {complex10}");

            ComplexClass complex11 = complex5.Multiplication(complex6);

            Console.WriteLine($"Результат умножения комплексных чисел: {complex11}");

            ComplexClass complex12 = ComplexClass.Multiplication(complex5, complex6);

            Console.WriteLine($"Результат умножения комплексных чисел: {complex12}");

            Line();

            #endregion

            #region Добавление диалога с использованием switch демонстрирующий работу класса.

            Console.WriteLine("Демонстрация работы класса с использованием диалога switch");

            var complexOne = new ComplexClass(0,0);
            var complexTwo = new ComplexClass(0,0);

            Console.Write("Введите действительную часть первого комплексного числа: ");
            complexOne.re = double.Parse(Console.ReadLine());

            Console.Write("Введите мнимую часть первого комплексного числа: ");
            complexOne.im = double.Parse(Console.ReadLine());

            Console.Write("Введите действительную часть второго комплексного числа: ");
            complexTwo.re = double.Parse(Console.ReadLine());

            Console.Write("Введите мниную часть второго комплексного числа: ");
            complexTwo.im = double.Parse(Console.ReadLine());

            Console.WriteLine($"Работа с комплексными числами {complexOne} и {complexTwo}");

            Console.WriteLine();

            string menu;

            do
            {
                Console.WriteLine("Нажмите клавишу действия для комплексных числе:");
                Console.WriteLine("+ - для сложения комплексных чисел между собой");
                Console.WriteLine("- - для вычитания комплексных чисел");
                Console.WriteLine("* - для перемножения комплексных чисел");
                Console.WriteLine("0 - для завершения программы");
                Console.WriteLine();

                menu = Console.ReadLine();

                switch (menu)
                {
                    case "-":                        
                        ComplexClass complexResult = complexOne.Minus(complexTwo);
                        Console.WriteLine();
                        Console.WriteLine($"Результат вычитания комплексных чисел: {complexResult}");
                        Console.WriteLine();
                        break;

                    case "+":                        
                        complexResult = complexOne.Plus(complexTwo);
                        Console.WriteLine();
                        Console.WriteLine($"Результат сложения комплексных чисел: {complexResult}");
                        Console.WriteLine();
                        break;

                    case "*":                        
                        complexResult = complexOne.Multiplication(complexTwo);
                        Console.WriteLine();
                        Console.WriteLine($"Результат вычитания комплексных чисел: {complexResult}");
                        Console.WriteLine();
                        break;

                    case "0":
                        Console.WriteLine();
                        Console.WriteLine("Действие программы завершено. До свидания!");
                        Console.WriteLine();
                        break;


                    default:
                        Console.WriteLine();
                        Console.WriteLine("Набран неправильный символ на клавиатуре. Повторите ввод!");
                        Console.WriteLine();
                        break;
                }
            }
            while (menu != "0");
            
            Console.ReadLine();

            #endregion

        }
    }
}

