using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ3
{   //Губарь Артём
    class Complex1
    {
        public double re;
        public double im;
        public Complex1 (double re, double im)
        {
            this.re = re;
            this.im = im;
        }
        public override string ToString()
        {
            return $"{re} + {im}i";
        }
        public Complex1 Plus (Complex1 com2)
        {
            Complex1 com3 = new Complex1(0, 0);
            com3.re = com2.re + this.re;
            com3.im = com2.im + this.im;
            return com3;
        }
        public Complex1 Minus (Complex1 com2)
        {
            Complex1 com3 = new Complex1(this.re - com2.re, this.im - com2.im);
            return com3;
        }
        public Complex1 Multiplication (Complex1 com2)
        {
            Complex1 com3 = new Complex1(0, 0);
            com3.re = com3.re * this.re - com3.im * this.im;
            com3.im = com3.re * this.im + com3.im * this.re;
            return com3;
        }
    }
    struct Complex
    {
        ///действительная часть комлексного числа
        public double re;
        ///мнимая часть комплексного числа
        public double im;
        public Complex Plus(Complex x)
        {
            Complex y;
            y.re = re + x.re;
            y.im = im + x.im;
            return y;
        }
        public Complex Minus(Complex x)
        {
            Complex y;
            y.re = re - x.re;
            y.im = im - x.im;
            return y;
        }
        public override string ToString()
        {
            return $"{re} + {im}i";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 - Задача 1 а");
            Console.WriteLine("2 - Задача 1 б");
            Console.WriteLine("3 - Задача 2");
            Console.WriteLine("===============================");
            Console.WriteLine("0 - Завершение работы программы");
            while(true)
            {
                Console.WriteLine("Введите номер задачи");
                int TaskNumber = Convert.ToInt32(Console.ReadLine());
                switch(TaskNumber)
                {
                    case 0:
                        Console.WriteLine("Завершение работы программы");
                        Console.Read();
                        return;
                    case 1:
                        Task1A();
                        break;
                    case 2:
                        Task1B();
                        break;
                    case 3:
                        Task2();
                        break;
                    default:
                        Console.WriteLine("Некорректный номер задачи");
                        break;
                }
            }
        }
        static void Task1A()
        {
            Console.Title = "Работа структуры комплексных чисел";
            Complex c01;
            Console.WriteLine("Введите действительную часть первого комплексного числа");
            c01.re = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите мнимую часть первого комплексного числа");
            c01.im = Convert.ToDouble(Console.ReadLine());
            Complex c02;
            Console.WriteLine("Введите дейсвительню часть второго комплексного числа");
            c02.re = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите мнимую часть второго комплексного числа");
            c02.im = Convert.ToDouble(Console.ReadLine());
            Complex c03 = c01.Minus(c02);
            Complex c04 = c01.Plus(c02);
            Console.WriteLine($"Разница указанных комплексных чисел равна {c03}");
            Console.WriteLine($"Сумма указанных комплексных чисел равна {c04}");
            Console.ReadKey();
        }
        static void Task1B()
        {
            Console.Title = "Работа класса комплексных чисел";
            Console.WriteLine("1 - Сложение комплексных чисел");
            Console.WriteLine("2 - Вычитание комплексных чисел");
            Console.WriteLine("3 - Умножение комплексных чисел");
            Console.WriteLine("=================================");
            Console.WriteLine("9 - Завершение работы программы");
            int OperationNumber = 0;
            do
            {
                Console.WriteLine("Введите номер операции");
                OperationNumber = int.Parse(Console.ReadLine());
                switch (OperationNumber)
                {
                    case 9:
                        Console.WriteLine("Завершение работы программы");
                        Console.Read();
                        break;
                    case 1:
                        Plus();
                        break;
                    case 2:
                        Minus();
                        break;
                    case 3:
                        Mumultiplication();
                        break;
                    default:
                        Console.WriteLine("Некорректный номер операции");
                        break;
                }
            }
            while (OperationNumber != 9);

        }
        static void Plus()
        {
            Console.Title = "Сложение комплексных чисел";
            Console.WriteLine("Введите действительную и мнимую часть первого комплексного числа");
            Complex1 complex1 = new Complex1(Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine("Введите действительную и мнимую часть второго комплексного числа");
            Complex1 complex2 = new Complex1(Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()));
            Complex1 complex3 = complex1.Plus(complex2);
            Console.WriteLine($"Сумма указанных комплексных чисел равна {complex3}");
            Console.ReadKey();
        }
        static void Minus()
        {
            Console.Title = "Вычитание комплексных чисел";
            Console.WriteLine("Введите действительную и мнимую часть первого комплексного числа");
            Complex1 complex1 = new Complex1(Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine("Введите действительную и мнимую часть второго комплексного числа");
            Complex1 complex2 = new Complex1(Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()));
            Complex1 complex3 = complex1.Minus(complex2);
            Console.WriteLine($"Разница указанных комплексных чисел равна {complex3}");
            Console.ReadKey();
        }
        static void Mumultiplication()
        {
            Console.Title = "Произведение комплексных чисел";
            Console.WriteLine("Введите действительную и мнимую часть первого комплексного числа");
            Complex1 complex1 = new Complex1(Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine("Введите действительную и мнимую часть второго комплексного числа");
            Complex1 complex2 = new Complex1(Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()));
            Complex1 complex3 = complex1.Multiplication(complex2);
            Console.WriteLine($"Произведение указанных комплексных чисел равно {complex3}");
            Console.ReadKey();
        }
        static void Task2()
        {/*С клавиатуры вводятся числа, пока не будет введён 0 (каждое число в новой строке).
           Требуется подсчитать сумму всех нечётных положительных чисел.
           Сами числа и сумму вывести на экран, используя tryParse.*/
            Console.Title = "Сумма нечётных положительных чисел";
            int sum = 0;
            while (true)
            {
                Console.WriteLine("Введите любое целое число");
                int a;
                if (int.TryParse(Console.ReadLine(), out a)) 
                {
                    if (a > 0 && a % 2 != 0)
                    {
                        sum += a;
                        Console.WriteLine($"{a}, сумма всех нечётных положительных чисел равна {sum}");
                    }
                    if (a == 0)
                    {
                        break;
                    }
                } 
                else
                {
                    Console.WriteLine("Вы ввели некорректное число");
                }
                    
            }
            Console.ReadKey();
        }
    }
}
