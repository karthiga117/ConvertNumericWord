using System;
using System.Collections.Generic;
using System.Text;

namespace ConvertNumericWord
{
    public class NumericWord
    {
        private long number;
        public string NumberWord;
         

        private const string AND = "AND";

        private string[] ones = new[]
        {
            "ZERO", "ONE", "TWO", "THREE", "FOUR", "FIVE", "SIX", "SEVEN", "EIGHT", "NINE", "TEN", "ELEVEN", "TWELVE",
            "THIRTEEN", "FOURTEEN", "FIFTEEN", "SIXTEEN", "SEVENTEEN", "EIGHTEEN", "NINETEEN"
        };

        private string[] tens = new[]
        {
            "ZERO", "TEN", "TWENTY", "THIRTY", "FORTY", "FIFTY", "SIXTY", "SEVENTY", "EIGHTY", "NINETY"
        };

        public NumericWord()
        {

        }

        public string ConvertNumbertoWords(string num)
        {
            number = Convert.ToInt64(num);

            NumberWord = ConvertNumbertoWords(number);
            return NumberWord;
        }
        public string ConvertNumbertoWords(long num)
        {
            number = Convert.ToInt64(num);
        
            if (number == 0)
                return "ZERO";
            if (number < 0)
                return "minus " + ConvertNumbertoWords(Math.Abs(number));
            
            if ((number / 1000000) > 0)
            {
                if ((number / 100000000) > 0)
                {
                    long hunmillion = number / 100000000;
                    NumberWord += NumbertoWords(hunmillion) + " HUNDRED ";
                    number %= 100000000;
                }

                long million = number / 1000000;
                NumberWord += NumbertoWords(million) + " MILLION ";
                number %= 1000000;
            }
            if ((number / 1000) > 0)
            {
                if ((number / 100000) > 0)
                {
                    long hunthousand = number / 100000;
                    NumberWord += NumbertoWords(hunthousand) + " HUNDRED ";
                    number %= 100000;
                }

                long thousand = number / 1000;
                NumberWord += NumbertoWords(thousand) + " THOUSAND ";
                number %= 1000;
            }
            if ((number / 100) > 0)
            {
                long hundred = number / 100;
                NumberWord += NumbertoWords(hundred) + " HUNDRED ";
                number %= 100;
            }

            if (number > 0)
            {
                if (NumberWord != "")
                    NumberWord += "AND ";
                if (number < 20)
                    NumberWord += ones[number];
                else
                {
                    NumberWord += tens[number / 10];
                    if ((number % 10) > 0)
                        NumberWord += " " + ones[number % 10];
                }
            }

            return NumberWord;

        }

        public string NumbertoWords(long num)
        {
            string word = string.Empty ;
            if (num > 0)
            {
                if (num < 20)
                    word = ones[num];
                else
                {
                    word = tens[num / 10];
                    if ((num % 10) > 0)
                        word += " " + ones[num % 10];
                }
            }

            return word;
        }

    }
}
