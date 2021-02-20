using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "yazılım geliştirici yetiştrime kampı";
            string kurs2 = "programlamaya başlangıç kursu";
            string kurs3 = "java";
            //array
            string[] kurslar = new string[] { "yazılım geliştirici yetiştrime kampı", "programlamaya başlangıç kursu", "java" };
            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("for bitti");

            //foreach dizilere uygulanır
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
        }
    }
}
