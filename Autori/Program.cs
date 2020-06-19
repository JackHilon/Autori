using System;

namespace Autori
{
    class Program
    {
        static void Main(string[] args)
        {
            // Autori
            // https://open.kattis.com/problems/autori


            var names = Enterline();
            string reslut = "";
            for (int i = 0; i < names.Length; i++)
            {
                reslut = reslut + FirstChar(names[i]);
            }
            Console.WriteLine(reslut);
        }

        private static string FirstChar(string str)
        {
            return str[0].ToString();
        }

        private static string[] Enterline()
        {
            return Console.ReadLine().Split('-');
        }
    }
}
