using System;

namespace Tasks1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[100];

            Console.WriteLine("Proverka dali moga da pushna otnovo");
        }

        static void Sum()
        {
            int i;
            int sum = 0;
            Console.Write("Въведете число: ");
            int number = int.Parse(Console.ReadLine());
            for (i = 1; i <= number; i++)
            {
                sum = sum + i;
            }
            Console.Write("Сумата от числата до {0} e {1}", number, sum);

        }

        static void Cards()
        {
            string[] heartsRed = new string[] { "2", "3", "4", "5", "6", "7", "8", "J", "Q", "K", "A" };
            string[] tilesRed = new string[] { "2", "3", "4", "5", "6", "7", "8", "J", "Q", "K", "A" };
            string[] cloversBlack = new string[] { "2", "3", "4", "5", "6", "7", "8", "J", "Q", "K", "A" };
            string[] pikesBlack = new string[] { "2", "3", "4", "5", "6", "7", "8", "J", "Q", "K", "A" };
            Console.WriteLine("heartsRed:  tilesRed:  \tcloversBlack:  \tpikesBlack: ");

            for (int i = 0; i < heartsRed.Length &&
                 i < tilesRed.Length &&
                 i < cloversBlack.Length &&
                 i < pikesBlack.Length; i++)
            {
                Console.WriteLine("{0} \t\t{1} \t\t{2} \t\t{3}", heartsRed[i], tilesRed[i], cloversBlack[i], pikesBlack[i]);
            }

        }

        static void ReverseNumber()
        {
            Console.Write("Въведете число: ");
            int number = int.Parse(Console.ReadLine());
            int reverseNumber = 0;
            while (number > 0)
            {
                int lastNumber = number % 10;
                reverseNumber = reverseNumber * 10 + lastNumber;
                number /= 10;
            }
            Console.WriteLine(reverseNumber);
        }

        static void ReverseText()
        {
            Console.Write("Въведете текст: ");
            string text = Console.ReadLine();
            string textReversed = "";

            for (int i = text.Length - 1; i >= 0; i--)
            {
                textReversed += text[i];
            }

            Console.WriteLine();
            Console.Write("Текстът, но обърнат: " + textReversed);
        }

        static void Palindrome()
        {
            Console.Write("Въведете текст: ");
            string text = Console.ReadLine().ToLower();
            string trim = text.Replace(" ", "");
            string textReversed = "";

            for (int i = text.Length - 1; i >= 0; i--)
            {
                textReversed += text[i];
            }

            Console.WriteLine();

            if (text == textReversed)
            {
                Console.WriteLine(text + " е палиндром");
            }
            else
            {
                Console.WriteLine(text + " нe е палиндром");
            }

        }
    }
}
