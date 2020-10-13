using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _2017_Txt2Srt
{
    public class Program
    {
        public static List<IdozitettFelirat> list = new List<IdozitettFelirat>();

        static void Main(string[] args)
        {
            Task4();
            Console.WriteLine($"5. feladat - Feliratok száma: {list.Count}");
            Task7();
            Task9();

            Console.ReadLine();
        }

        static void Task4()
        {
            string[] lines = File.ReadAllLines("feliratok.txt");
            for (int i = 0; i < lines.Length - 1; i += 2)
            {
                list.Add(new IdozitettFelirat(lines[i], lines[i + 1]));
            }
        }

        static void Task7()
        {
            string longest = list.OrderBy(x => x.SzavakSzama).Last().Subtitle;
            Console.WriteLine($"7. feladat - Legtöbb szóból álló felirat: {longest}");
        }

        static void Task9()
        {
            using StreamWriter sw = new StreamWriter("felirat.srt");
            foreach (var sub in list)
            {
                sw.Write($"{list.IndexOf(sub) + 1}\n{sub.SrtIdozites}\n{sub.Subtitle}\n\n");
            }
        }
    }
}
