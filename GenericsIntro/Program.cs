using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {

            GList<string> isimler = new GList<string>();

            isimler.Add("Cagri");
            isimler.Add("x");
            isimler.Add("y");

            foreach (var isim in isimler.Items)
            {
                Console.WriteLine(isim);
            }
        }
    }
}
