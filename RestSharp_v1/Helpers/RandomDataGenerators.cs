using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestSharp_v1.Helpers
{
    public static class RandomDataGenerator
    {
        private static Random random = new Random();

        public static string RandomDay()
        {
            DateTime start = new DateTime(1995, 1, 1);
            int range = (DateTime.Today - start).Days;
            return (start.AddDays(random.Next(range))).ToString();
        }

        public static string RandomStringOnlyLetters(int numberOfLetters)
        {
            string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            return new string(Enumerable.Repeat(chars, numberOfLetters).Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public static string RandomStringOnlyNumbers(int numberOfNumbers)
        {
            string chars = "0123456789";
            return new string(Enumerable.Repeat(chars, numberOfNumbers).Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public static string RandomAlphaNumericString(int numberOfLetters)
        {
            string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            return new string(Enumerable.Repeat(chars, numberOfLetters).Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public static string RandomEmailAddress()
        {
            string domainChars = "abcdefghijklmnopqrstuvwxyz";
            string emailChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789._";

            string emailLocalPart = new string(Enumerable.Repeat(emailChars, random.Next(8, 13)).Select(s => s[random.Next(s.Length)]).ToArray());
            string emailDomain = new string(Enumerable.Repeat(domainChars, random.Next(4, 7)).Select(s => s[random.Next(s.Length)]).ToArray());

            return $"{emailLocalPart}@{emailDomain}.com";
        }

        public static bool RandomBool()
        {
            return random.Next(1) == 0;
        }

        public static int RandomNumber(int min = 0, int max = 2147483647)
        {
            return random.Next(min, max);
        }

        public static long RandomLongNumber(long min = 0, long max = 9223372036854775807)
        {
            int num1 = RandomNumber();
            int num2 = RandomNumber();

            if (((num1 + num2) / 2) < 0 || (num1 + num2) < 0) return RandomLongNumber();

            //if (max <= 2147483647) return num1;

            bool halved = RandomBool();

            return halved ? (num1 + num2) / 2 : (num1 + num2);

        }
    }
}
