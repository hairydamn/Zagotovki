using System;
public class MassivBezDll //без контроля переполнений и рассчета/сортировки
{
    public static int n;
    public static long[] mass;
    public static long sum;
    public static bool exit = false;
    static void Main()
    {
        Input();
        if (exit)
            return;
        Process();
        OutPut();
        Console.ReadLine();
    }
    static void Input()
    {
        n = Convert.ToInt32(koeff("Введите n= "));
        if (exit)
            return;
        mass = new long[n];
        for (int i = 1; i <= n; i++)
        {
            if (exit)
                break;
            mass[i - 1] = koeff("Введите A"+i+"= ");
        }   
    }
    public static void Process()
    {
        for (int i = 0; i < mass.Length; i++)
        {
            sum += mass[i];
        }
    }
    static void OutPut()
    {
        Console.WriteLine();
        Console.WriteLine("Сумма равна: "+sum);
        
    }
    static long koeff(string str)
    {
        bool y;
        long h;
        int i = 0;
        do
        {
            y = false;
            Console.Write(str);
            y = long.TryParse(Console.ReadLine(), out h);
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