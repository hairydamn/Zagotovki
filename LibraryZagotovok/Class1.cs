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
        }
    }
}
