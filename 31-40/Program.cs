using System;
using LibraryZagotovok;
/*31.Массив a1; a2; a3; an  
    циклически сдвинуть на m элементов вправо; m<n. 
    Пример. исходный массив 1, 2, 3, 4, 5, 6; m=2; результат: 6, 5, 1, 2, 3, 4 */
public class MassivWithDll
{
    public static int[] mass;
    public static int n, m;
    public static bool exit = false;
    static void Main()
    {
        Input();
        if (exit)
            return;
        OutPut();
        Console.ReadLine();
    }
    static void Input()
    {
        n = Convert.ToInt32(koeff("Введите n= "));
        if (exit)
            return;
        m = Convert.ToInt32(koeff("Введите m= "));
        if (exit)
            return;
        mass = new int[n];
        mass = Massiv.AddRandomMass(mass);
    }
    static void Process()
    {
        for (int i = 1; i <= m; i++)
        {
            Massiv.SdvigVpravo(mass);
        }
    }
    static void OutPut()
    {
        Console.WriteLine("\nИсходный массив: ");
        Massiv.OutputMass(mass);
        Process();
        Console.WriteLine("\nИзменненный массив: ");
        Massiv.OutputMass(mass);
    }
    static int koeff(string str)
    {
        bool y;
        int h;
        int i = 0;
        do
        {
            y = false;
            Console.Write(str);
            y = Int32.TryParse(Console.ReadLine(), out h);
            if (!y)
            {
                if (i < 5)
                {
                    i++;
                    if (!y) { Console.WriteLine("Неправильный ввод "); }
                }
                else
                {
                    Console.WriteLine("Неправильный ввод\nНажмите Enter, чтобы выйти...");
                    Console.ReadLine();
                    exit = true;
                    break;
                }
            }
        } while (!y);
        return h;
    }
}

