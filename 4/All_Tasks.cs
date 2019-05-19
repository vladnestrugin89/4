using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    class All_Tasks
    {
        public void Task_1()
        {
            //Задание 1. Написать программу, которая считывает символы с клавиатуры, пока не будет введена точка. 
            //Программа должна сосчитать количество введенных пользователем пробелов.
            char ch;
            int count = 0;
            Console.WriteLine("Input any symbol or '.' to finish: ");
            while (true)
            {
                ch = (char)Console.Read();
                if (ch == ' ')
                {
                    count++;
                }
                else if (ch == '.')
                {
                    break;
                }
            }
            Console.WriteLine($"Quantities of spaces is: {count}");
        }

        public void Task_2()
        {
            /*
             Задание 2. Ввести с клавиатуры номер трамвайного билета (6-значное число) и про-верить является ли 
данный билет счастливым (если на билете напечатано шестизначное число, и сумма первых трёх цифр равна 
сумме последних трёх, то этот билет считается счастливым).
             */
            Console.Write("Input 6 numbers of your train ticket: ");

            int a, b, c, d, f, e;  // 242561
            //int ticket = int.Parse(Console.ReadLine());
            //a = ticket / 100000 % 10;
            //b = ticket / 10000 % 10;
            //c = ticket / 1000 % 10;
            //d = ticket / 100 % 10;
            //e = ticket / 10 % 10;
            //f = ticket % 10;

            string str = Console.ReadLine();
            a = int.Parse(str[0].ToString());
            b = int.Parse(str[1].ToString());
            c = int.Parse(str[2].ToString());
            d = int.Parse(str[3].ToString());
            e = int.Parse(str[4].ToString());
            f = int.Parse(str[5].ToString());

            if ((a + b + c) == (d + e + f))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Your ticket is a lucky one!!!");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Your ticket is NOT lucky..Try again");
                Console.ResetColor();
            }
        }

        public void Task_4()
        {
            /*
                Задание 4.  Даны целые положительные числа A и B (A < B). 
                Вывести все целые числа от A до B включительно; каждое число должно выводиться на новой строке; 
                при этом каждое число должно выводиться количество раз, равное его значению. 
                Например: если А = 3, а В = 7, то программа должна сформировать в консоли 
                следующий вывод:
                333
                4444
                55555
                666666
                7777777
             */
            Console.WriteLine("Input number A: ");
            int A = int.Parse(Console.ReadLine()); // 2
            Console.WriteLine("Input number B: ");
            int B = int.Parse(Console.ReadLine()); // 6
            for (int i = A; i <= B; i++)  // 2 3 4 5 6
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write($" {i}");
                }
                Console.WriteLine();
            }
        }

        public void Task_3()
        /*
                 1.	Пользователь вводит строку. Проверить, является ли эта строка палиндромом. 
                Палиндромом называется строка, которая одинаково читается слева направо и справа налево. 
        */
        {
            Console.WriteLine("Please, input any string: ");
            string str = Console.ReadLine();    // Hello World
            char[] symbols = str.ToCharArray(); // [H][e][l][l][o][] ..
            Array.Reverse(symbols);
            string reverse = new string(symbols);
            string result = str == reverse ? "String is Palinrdome!!!" : "Is NOT Palindrome..Try again!";
            Console.WriteLine(result);


            // The same:
            //string str2 = "";
            //for(int i = 0; i < str.Length; i++)
            //{
            //    str2 += symbols[i];
            //}

        }

        public void Task_5()
        //2. Пользователь вводит строку.Удалить все цифри из строки.
        {
            Console.Write("Insert your string: ");
            string str = Console.ReadLine();
            string newStr = null;
            for (int i = 0; i < str.Length; i++)
            {
                if (!char.IsDigit(str[i]))  // if one of symbol of an array of string is NOT digit
                {
                    newStr += str[i];
                }
            }
            Console.WriteLine($"Your string without numbers looks like: {newStr}");
        }

        public void Task_6()
        /*
                 3.	Создать метод, принимающий введенную пользователем строку и выводящий на экран статистику по этой строке. 
            Статистика должна включать:
            - общее количество символов, 
            - количество букв(сколько в верхнем регистре и сколько в нижнем), 
            - количество цифр,
            - и количество пробельных символов.    
                 */
        {
            Console.Write("Insert your string: ");
            int countUpperSymb = 0;
            int countLowSymb = 0;
            int countDigit = 0;
            int countSpaces = 0;
            string str = Console.ReadLine();  // hello  5
            for (int i = 0; i < str.Length; i++) // [0][1][2][3][4] 
            {
                if (char.IsUpper(str[i]))
                {
                    countUpperSymb++;                
                }
                else if (char.IsLower(str[i]))
                {
                    countLowSymb++;
                }
                else if (char.IsDigit(str[i]))
                {
                    countDigit++;
                }
                else if (char.IsWhiteSpace(str[i]))
                {
                    countSpaces++;
                }            
            }
            Console.WriteLine($"There is some stats on your string: \n Upper case letters: {countUpperSymb} \n Lower case letters: {countLowSymb} \n" +
                              $" Numbers: {countDigit} \n Spaces: {countSpaces}");
        }
    }
}
