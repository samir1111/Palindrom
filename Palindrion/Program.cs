using System;

namespace Palindrion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку: ");
            string text = Console.ReadLine();
            text = text.Replace(" ", "");
            text = text.ToUpper();
            char[] text1 = text.ToCharArray();
            int size = text1.Length - 1;
            Array.Reverse(text1);
            string ReverseText = new string(text1);
            Console.WriteLine("Выберите вариант: \t 1-учитывать только числа и буквы \t 2-учитывать все введеные символы");
            int choice = Int32.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
            if (Character_check(text1, size))
            {
                        if (text == ReverseText)
                        {
                            Console.WriteLine("Является палиндромом");
                        }
                        else
                            Console.WriteLine("Не является");
            }
            else
                Console.WriteLine("Это точно не палиндром");
                    break;

                case 2:
                    if (text == ReverseText)
                    {
                        Console.WriteLine("Является палиндромом");
                    }
                    else
                        Console.WriteLine("Не является");
                    break;

                default:
                    Console.WriteLine("Попробуйте заново");
                    break;

        }
            
            Console.Read();
        }

      static bool Character_check(char []a,int size)
        {
            if ((alphabet(a[0]) == true) && (alphabet(a[size]) == true))
            {
                return true;
            }
            return false;
        }

        static bool alphabet(char letter)
        {
            if (((letter >= 'A') && (letter <= 'Z'))  || ((letter>='А') && (letter<='Я')) || (char.IsDigit(letter)==true))
            {
                return true;
            }
            return false;
        }

    }
}
