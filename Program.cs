using System;

namespace ConvertNumericWord
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Please enter the number : ");
           string num = Console.ReadLine();
           NumericWord convertNum = new NumericWord();
           string numberWord = convertNum.ConvertNumbertoWords(num);
           Console.WriteLine("Number word of {0} is {1}", num, numberWord);
           Console.ReadLine();
        }
    }
}
