using System;

namespace EpicBattle
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Heros = { "Harry Potter", "Luke Skywalker", "R4X", "Kaja kallas", "Kersti Kaljulaid" };
            string[] SupperVillians = { "Maria Under", "Savusaar", "Roosa", "Gay Baavian", "Plankton" };

            string Hero = GetCharacter(Heros);
            string villian = GetCharacter(SupperVillians);
            int herohp = GetHP();
            int villianhp = GetHP();
            int HeroDamage;
            int VillianDamage;
            Console.WriteLine($"{Hero}with {herohp} HP will fight {villian} with {villianhp} HP.");
            WinGenerator(herohp, villianhp);
            

        }
        public static string GetCharacter(string[] Array)
        {
            Random rnd = new Random();
            string randomstring = Array[rnd.Next(0, Array.Length)];
            return randomstring;
        }
        public static int GetHP()
        {
            Random rnd = new Random();
            int hp = rnd.Next(5, 11);
            return hp;
        }
        public static void WinGenerator(int herohp, int villianhp)
        {
            while (herohp > 0 && villianhp > 0)
            {
                Random rnd = new Random();
                int herohit = rnd.Next(0, 4);
                int villianhit = rnd.Next(0, 4);
                if (herohit == 3)
                {
                    Console.WriteLine("WOW, Hero hitted Critical hit!");
                }
                else if (villianhit == 3)
                {
                    Console.WriteLine("WOW, villian hitted Critical hit!");
                }
                    herohp = herohp - villianhit;
                villianhp = villianhp - herohit;
                if (herohit == 2 || herohit ==1&& villianhit == 1 || villianhit== 2)
                {
                    Console.WriteLine($"Hero hitted {herohit} , villian HP :{villianhp}");
                    Console.WriteLine($"villian hitted {villianhit} , hero HP :{herohp}");
                }
                else if (herohp==0)
                {
                    Console.WriteLine("Dark side wins!");
                }
                else if (villianhp== 0)
                {
                    Console.WriteLine("Hero save day!");
                }


            }
        }
    }
}
