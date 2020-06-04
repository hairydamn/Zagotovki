using System;
class Formula
{
    public static double x, y, a, b;
    public static bool exit, rasschet = false;
    static void Main()
    {
        Input();
        if (exit) { return; }
        Process();
        Output();
        Console.ReadKey();
    }
    static void Input()
    {
        Console.WriteLine("Введите коэффициенты");
        a = koeff("Введите a= ");
        if (exit) { return; }
        b = koeff("Введите b= ");
        if (exit) { return; }
        x = koeff("Введите x= ");
        if (exit) { return; }
    }
    static void Process()
    {
        try
        {
            if (x == 0) throw new DivideByZeroException();
            y = (b + a) / x;
            rasschet = true;
        }
        catch (Exception ex) { Console.WriteLine(ex.Message); }
    }
    static void Output()
    {
        if (rasschet)
            Console.WriteLine("y = {0}", y.ToString("0.0000"));
        Console.WriteLine("\nНажмите Enter, чтоюы выйти...");
    }
    static double koeff(string str)
    {
        bool y;
        double h;
        int i = 1;
        do
        {
            y = false;
            Console.Write(str);
            y = Double.TryParse(Console.ReadLine(), out h);
            if (i < 5)
            {
                if (!y) { Console.WriteLine("Неправильный ввод"); }
                i++;
            }
            else 
            { 
                Console.WriteLine("Неправильный ввод\nНажмите Enter, чтобы выйти...");
                Console.ReadLine();
                exit = true;
                break;
            }
        } while (!y);
        return h;
    }
}
