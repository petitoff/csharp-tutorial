using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace testing
{
    internal class Program
    {
        public static List<string> CardNumberFoundList = new List<string>();
        static void Main()
        {
            //Console.WriteLine(IsValidCreditCardNumber("5297501100132586"));
            GetCreditCardNumbers("40165848100", 10);
            foreach (var i in CardNumberFoundList)
            {
                Console.WriteLine(i);
            }

        }

        public static void GetCreditCardNumbers(string creditCardNumberPrefix, int howMany)
        {
            int checkLength = creditCardNumberPrefix.Length;
            int howMushIsMissing = 16 - checkLength;

            if (howMushIsMissing > 6) return;

            Random rnd = new Random();

            while (CardNumberFoundList.Count < howMany)
            {
                string prefix = "";
                for (int i = 0; i < howMushIsMissing; i++)
                {
                    prefix += rnd.Next(0, 9).ToString();
                }

                if (IsValidCreditCardNumber(creditCardNumberPrefix + prefix))
                {
                    CardNumberFoundList.Add(creditCardNumberPrefix+prefix);
                }
            }
        }

        private static bool IsValidCreditCardNumber(string cardNumber)
        {
            //string creditCard = "5297501100132586";
            return SumAllNumber(cardNumber) == 0;
        }

        private static int SumAllNumber(string cardNumber)
        {
            List<int> cardNumberList = cardNumber.Select(i => Convert.ToInt32(i.ToString())).ToList();

            int sumAllNumbers = 0;
            for (int i = 0; i < cardNumberList.Count(); i++)
            {

                if (i % 2 == 0)
                {
                    string result = (cardNumberList[i] * 2).ToString();
                    if (result.Length == 2)
                    {
                        sumAllNumbers += Convert.ToInt32(result[0].ToString()) + Convert.ToInt32(result[1].ToString());
                    }
                    else
                    {
                        sumAllNumbers += Convert.ToInt32(result);

                    }
                }
                else
                {
                    sumAllNumbers += cardNumberList[i];
                }
            }

            return sumAllNumbers % 10;
        }

        private string ReverseString(string text)
        {
            if (text == null) return null;

            char[] array = text.ToCharArray();
            Array.Reverse(array);
            return new String(array);
        }
    }
}
