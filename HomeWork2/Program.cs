using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SupportLibrary;

/// <summary>
/// Максим Торопов
/// Ярославль
/// Домашняя работа 2 урока
/// </summary>
namespace HomeWork2
{
    class Program
    {
        /// <summary>
        /// Задание 1
        /// Написать метод возвращающий минимальное из трех чисел.
        /// </summary>
        static void Task1()
        {
            //Clear console and print info regarding current task
            SupportMethods.PrepareConsoleForHomeTask("Написать метод возвращающий минимальное из трех чисел.");

            //input a, b and c using SupportMethods.RequestIntValue
            int a = SupportMethods.RequestIntValue("Please input a: ");
            int b = SupportMethods.RequestIntValue("Please input b: ");
            int c = SupportMethods.RequestIntValue("Please input c: ");
            
            //Output result of work using SupportMethods.Pause and including MinInt method
            SupportMethods.Pause($"Minimum between {a}, {b} and {c} is {MinInt(a, b, c)}");

        }

        /// <summary>
        /// Method Find and return minimum between a, b and c.
        /// By default minimum = a;
        /// </summary>
        /// <param name="a">integer</param>
        /// <param name="b">integer</param>
        /// <param name="c">integer</param>
        /// <returns>minimum between a, b and c</returns>
        static int MinInt(int a, int b, int c)
        {
            int min = a;

            if (b < min)
            {
                min = b;
            }

            if (c < min)
            {
                min = c;
            }

            return min;
        }

        /// <summary>
        /// Задание 2
        /// Написать метод подсчета количества цифр числа.
        /// </summary>
        static void Task2()
        {
            //Clear console and print info regarding current task
            SupportMethods.PrepareConsoleForHomeTask("Написать метод подсчета количества цифр числа.");

            //input number using SupportMethods.RequestIntValue
            int number = SupportMethods.RequestIntValue("Please input number: ");

            //Output result of work using SupportMethods.Pause and including CountOfDigits method
            SupportMethods.Pause($"Count of Digits in {number} is {CountOfDigits(number)}");
        }

        /// <summary>
        /// Method Count of Digits in number
        /// </summary>
        /// <param name="number">integer</param>
        /// <returns>count as integer</returns>
        static int CountOfDigits(int number)
        {
            //As we know any number contain 1 or more digits, then start from 1
            int count = 1;

            //number should be positive
            number = Math.Abs(number);

            while ((number / 10) != 0)
            {
                count++;
                number /= 10;
            }
            
            return count;
            //return Math.Floor(Math.Log10(Math.Abs(number)) + 1);
        }

        /// <summary>
        /// Задание 3
        /// С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.
        /// </summary>
        static void Task3()
        {
            //Clear console and print info regarding current task
            SupportMethods.PrepareConsoleForHomeTask("С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.");

            int number;
            int sum = 0;

            do
            {
                //input number using SupportMethods.RequestIntValue
                number = SupportMethods.RequestIntValue("Please input any number, 0 - exit: ");

                //If number is Odd and number is Positive then sum increase by number
                if (number % 2 == 1)
                { sum += number; }                

            } while (number != 0);

            //Output result of work using SupportMethods.Pause
            SupportMethods.Pause($"Sum of Positive Odd numbers is {sum}");

        }

        /// <summary>
        /// Задание 4
        /// Реализовать метод проверки логина и пароля. На вход подается логин и пароль.
        /// На выходе истина, если прошел авторизацию, и ложь, если не прошел(Логин:root, Password:GeekBrains).
        /// Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает.
        /// С помощью цикла do while ограничить ввод пароля тремя попытками.
        /// </summary>
        static void Task4()
        {
            //Clear console and print info regarding current task
            SupportMethods.PrepareConsoleForHomeTask("Реализовать метод проверки логина и пароля. На вход подается логин и пароль.\n" +
                "На выходе истина, если прошел авторизацию, и ложь, если не прошел(Логин:root, Password:GeekBrains).\n" +
                "Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает.\n" +
                "С помощью цикла do while ограничить ввод пароля тремя попытками.");

            int maxattempts = 3;
            bool up = SupportMethods.RequestUsernamePassword("root", "GeekBrains", maxattempts);

            //Output result of work using SupportMethods.Pause
            SupportMethods.Pause(up ? "Аутентификация успешна!" : "Аутентификация не выполнена!");
        }

        /// <summary>
        /// Задание 5
        /// а) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы и сообщает, нужно ли человеку похудеть, набрать вес или все в норме;
        /// б) *Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.
        /// Википедия:
        /// Индекс массы тела	Соответствие между массой человека и его ростом
        /// 16 и менее  Выраженный дефицит массы тела
        /// 16—18,5	Недостаточная(дефицит) масса тела
        /// 18,5—24,99	Норма
        /// 25—30	Избыточная масса тела(предожирение)
        /// 30—35	Ожирение
        /// 35—40	Ожирение резкое
        /// 40 и более  Очень резкое ожирение
        /// </summary>
        static void Task5()
        {
            //Clear console and print info regarding current task
            SupportMethods.PrepareConsoleForHomeTask("Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы и сообщает, нужно ли человеку похудеть, набрать вес или все в норме;\n" +
                "*Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.");

            const double MINNORMA = 18.5;
            const double MAXNORMA = 24.99;

            //input number using SupportMethods.RequestIntValue
            double weight = SupportMethods.RequestDoubleValue("Please input weight in kg: ");

            //input number using SupportMethods.RequestIntValue
            double height = SupportMethods.RequestDoubleValue("Please input height in meters: ");
            
            double bmi = weight / (height * height);

            if (bmi < MINNORMA)
            {
                double addkg = MINNORMA * height * height - bmi * height * height;
                //Output result of work using SupportMethods.Pause
                SupportMethods.Pause($"Your Body Mass Index (BMI) is {bmi:F2} and less than normal, you should eat more and add {addkg:F2} kg or more");
            }
            else if (bmi > MAXNORMA)
            {
                double addkg = bmi * height * height - MAXNORMA * height * height;
                //Output result of work using SupportMethods.Pause
                SupportMethods.Pause($"Your Body Mass Index (BMI) is {bmi:F2} and higher than normal, you should lose your weight by {addkg:F2} kg or more");
            }
            else
            {
                //Output result of work using SupportMethods.Pause
                SupportMethods.Pause($"Your Body Mass Index (BMI) is {bmi:F2} and you're in perfect form, Keep it up!");
            }            
        }

        /// <summary>
        /// Задание 6
        /// *Написать программу подсчета количества “Хороших” чисел в диапазоне от 1 до 1 000 000 000.
        /// Хорошим называется число, которое делится на сумму своих цифр.
        /// Реализовать подсчет времени выполнения программы, используя структуру DateTime.
        /// </summary>
        static void Task6()
        {
            //Clear console and print info regarding current task
            SupportMethods.PrepareConsoleForHomeTask("*Написать программу подсчета количества “Хороших” чисел в диапазоне от 1 до 1 000 000 000.\n" +
                "Хорошим называется число, которое делится на сумму своих цифр.\n" +
                "Реализовать подсчет времени выполнения программы, используя структуру DateTime.");
                        
            //input startRange using SupportMethods.RequestIntValue
            int startRange = SupportMethods.RequestIntValue("Please input start of the range: ");
            //int startRange = 1;

            //input endRange using SupportMethods.RequestIntValue
            int endRange = SupportMethods.RequestIntValue("Please input end of the range: ");
            //int endRange = 1000000000;

            //Exchange startRange and endRange if startRange > endRange
            if (startRange > endRange)
            {
                startRange ^= endRange;
                endRange ^= startRange;
                startRange ^= endRange;
            }

            //fixing start time
            DateTime startTime = DateTime.Now;

            int count = 0;

            for (int i = startRange; i < endRange ; i++)
            {
                int d = SumOfDigits(i);
                if ((d > 0) && (i % d == 0))
                {
                    count++;                    
                }
            }

            //fixing end time
            DateTime finishTime = DateTime.Now;
            TimeSpan ts = finishTime - startTime;

            //Output result of work using SupportMethods.Pause
            SupportMethods.Pause($"Range from {startRange} up to {endRange} contains {count} \"good\" numbers; {ts}");
        }

        /// <summary>
        /// Method Sum of Digits in number
        /// </summary>
        /// <param name="number">integer</param>
        /// <returns>sum as integer</returns>
        static int SumOfDigits(int number)
        {
            int sum = 0;

            //number = Math.Abs(number);
            while ((number / 10) != 0)
            {
                sum += (number % 10);
                number /= 10;
            }

            sum += (number % 10);

            return sum;
        }

        /// <summary>
        /// Задание 7
        /// a) Разработать рекурсивный метод, который выводит на экран числа от a до b (a меньше b);
        /// б) *Разработать рекурсивный метод, который считает сумму чисел от a до b.
        /// </summary>
        static void Task7()
        {

            //Clear console and print info regarding current task
            SupportMethods.PrepareConsoleForHomeTask("a) Разработать рекурсивный метод, который выводит на экран числа от a до b (a меньше b);\n" +
                "б) *Разработать рекурсивный метод, который считает сумму чисел от a до b.");

            //input startRange using SupportMethods.RequestIntValue
            int a = SupportMethods.RequestIntValue("Please input a: ");

            //input endRange using SupportMethods.RequestIntValue
            int b = SupportMethods.RequestIntValue("Please input b: ");

            if (a > b)
            {
                a ^= b;
                b ^= a;
                a ^= b;
            }

            Numbers(a, b);

            //Output result of work using SupportMethods.Pause and including SumNumbers method
            SupportMethods.Pause($"Sum of numbers = {SumNumbers(a, b)}");
        }

        /// <summary>
        /// Recursive method
        /// </summary>
        /// <param name="i">start range, also next range in recursive method</param>
        /// <param name="b">end range</param>
        static void Numbers(int i, int b)
        {
            if (i <= b)
            {
                Console.WriteLine($"{i}");
                Numbers(i + 1, b);                
            }            
        }

        /// <summary>
        /// Recursive method
        /// </summary>
        /// <param name="i">start range, also next range in recursive method</param>
        /// <param name="b">end range</param>
        static int SumNumbers(int i, int b)
        {
            if (i < b)
            {
                return i + SumNumbers(i + 1, b);                
            }
            else
            {
                return i;
            }            
        }

        /// <summary>
        /// Main programm by default
        /// Authentication and Start
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int maxattempts = 3;
            //trying to authenticate person
            if (SupportMethods.RequestUsernamePassword("root", "GeekBrains", maxattempts))
            {
                Start();
            } else
            {
                //Output result of work using SupportMethods.Pause
                SupportMethods.Pause("Вы не аутентифицированы!");
            }
                        
        }

        /// <summary>
        /// Build menu
        /// </summary>
        static void Start()
        {
            do
            {
                SupportMethods.PrepareConsoleForHomeTask("1 - Task 1\n" +
                  "2 - Task 2\n" +
                  "3 - Task 3\n" +
                  "4 - Task 4\n" +
                  "5 - Task 5\n" +
                  "6 - Task 6\n" +
                  "7 - Task 7\n" +
                  "0 (Esc) - Exit\n");
                ConsoleKeyInfo key = Console.ReadKey();
                switch (key.Key)
                {
                    case ConsoleKey.D1:
                        Task1();
                        break;
                    case ConsoleKey.D2:
                        Task2();
                        break;
                    case ConsoleKey.D3:
                        Task3();
                        break;
                    case ConsoleKey.D4:
                        Task4();
                        break;
                    case ConsoleKey.D5:
                        Task5();
                        break;
                    case ConsoleKey.D6:
                        Task6();
                        break;
                    case ConsoleKey.D7:
                        Task7();
                        break;
                    case ConsoleKey.D0:
                    case ConsoleKey.Escape:
                        return;
                    default:
                        break;
                }
            } while (true);
        }
    }
}

