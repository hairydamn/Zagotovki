using System;
namespace LibraryZagotovok
{
    public class Massiv
    {

        public static void SdvigVpravo(int[] mass)
        {
            int last = mass[mass.Length-1];
            for (int i = mass.Length-1; i >= 1; i--)
            {
                mass[i] = mass[i-1];
            }
            mass[0] = last;
        }
        public static void OutputMass(int[] mass)
        {
            foreach (int k in mass)
            {
                Console.Write(k+" ");
            }
        }
        public static int[] AddRandomMass(int[] mass)
        {
            Random rnd = new Random();
            for (int i = 0; i < mass.Length; i++)
            {
                mass[i] = rnd.Next(-100, 101);
            }
            return mass;
        }
    }
}
