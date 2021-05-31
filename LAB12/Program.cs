using System;

namespace LAB12
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите любой символ: ");
            string x = Console.ReadLine();
            int y = 0;
            bool result = int.TryParse(x, out y);
            if (result == true)
                Console.WriteLine("Введенный символ - цифра");
            else
                Console.WriteLine("Введенный символ - не цифра!");
        } 
    }
}