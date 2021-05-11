using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] isimler = new string[] { "Engin", "Cagri", "Aykut", "halid" };
            Console.WriteLine(isimler[3]);

            List<string> isimler2 = new List<string> { "Engin", "Cagri", "Aykut", "halid" };
            isimler2.Add("Süleyman");
            isimler2.Add("Furkan");

            Console.WriteLine(isimler2[4]);

        }
    }
}
