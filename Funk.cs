using System;
using System.Text;

namespace Auto
{
    internal class Funk
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Sisesta numbrid:");
            string numbstr = Console.ReadLine();
            string[] numblist = numbstr.Split(' ');
            int[] newlist = new int[numblist.Length];

            for (int i = 0; i < numblist.Length; i++)
            {
                int a;
                if (i == 0)
                {
                    a = int.Parse(numblist[numblist.Length - 1]) + int.Parse(numblist[i + 1]);
                }
                else if (i == numblist.Length - 1)
                {
                    a = int.Parse(numblist[i - 1]) + int.Parse(numblist[0]);
                }
                else
                {
                    a = int.Parse(numblist[i - 1]) + int.Parse(numblist[i + 1]);
                }
                newlist[i] = a;
            }

            Console.WriteLine("New list of sums:");
            Console.WriteLine(string.Join(" ", newlist));
        }
    }
}
