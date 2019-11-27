using System;

namespace Lab1
{
    class Program
    {
        static void color(int k)
        {
            switch (k)
            {
                case 1:
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case 2:
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
            }
        }

        static void Main(string[] args)
        {
            Console.Title = "Ванцян Аркадий ИУ5-35Б";
            while (true)
            {
                Console.ResetColor();
                double a, b, c, x1, x11, x12, x2, D;
                bool f1, f2, f3;
                int i = 0, z = 1;
                if (args.Length == 3)
                {
                    try
                    {
                        a = Convert.ToDouble(args[0]);
                        b = Convert.ToDouble(args[1]);
                        c = Convert.ToDouble(args[2]);
                    }
                    catch (Exception)
                    {
                        color(1);
                        Console.WriteLine("Введены неверные символы!");
                        Console.ReadKey();
                    }
                }
                else
                {
                    do
                    {
                        Console.Write("Введите первый коэф: ");
                        f1 = double.TryParse(Console.ReadLine(), out a);
                        Console.Write("Введите второй коэф : ");
                        f2 = double.TryParse(Console.ReadLine(), out b);
                        Console.Write("Введите третий коэф : ");
                        f3 = double.TryParse(Console.ReadLine(), out c);

                        if (!f1 || !f2 || !f3)
                        {
                            color(1);
                            Console.WriteLine("Необходимо вести правильные символы!");
                            Console.ResetColor();
                        }
                    } while (!f1 || !f2 || !f3);

                    if (a == 0 && b == 0 && c == 0)
                    {
                        color(2);
                        Console.WriteLine("Количество Корней Бесконечно");
                        Console.ReadKey();
                        continue;
                    }

                    if (a == 0 && b != 0 && c != 0)
                    {
                        z += 1;
                        double var1 = -c / b;
                        if (var1 < 0)
                        {
                            color(1);
                            Console.WriteLine("Нет корней");
                            Console.ReadLine();
                        }
                        else if (var1 == 0)
                        {
                            color(2);
                            Console.WriteLine("x1=0");
                            Console.ReadLine();
                        }
                        else
                        {
                            color(2);
                            double x13 = Math.Sqrt(var1), x23 = -Math.Sqrt(var1);
                            Console.WriteLine("x1: " + x13.ToString() + " x2: " + x23.ToString());
                            Console.ReadLine();
                        }
                    }
                    else
                    { 
                    D = Convert.ToDouble((Math.Pow(b, 2) - 4 * (a * c)));
                        if (D < 0)
                        {
                            color(1);
                            Console.WriteLine("Нет корней.");
                        }
                        else
                        {
                            x1 = Convert.ToDouble((-b + Math.Sqrt(D)) / (2 * a));
                            x2 = Convert.ToDouble((-b - Math.Sqrt(D)) / (2 * a));
                            if (x1 >= 0)
                            {
                                x11 = Convert.ToDouble(Math.Sqrt(x1));
                                color(2);
                                Console.WriteLine("x1: " + x11);
                                i += 1;
                                if (x1 != 0)
                                    Console.WriteLine("y1: " + ((-1) * x11));
                            }
                            else
                                if (x2 < 0)
                            {
                                {
                                    i += 1;
                                    color(1);
                                    Console.WriteLine("Нет корней");
                                }
                            }
                            if (x2 >= 0)
                            {
                                x12 = Convert.ToDouble(Math.Sqrt(x2));
                                if (x12 > 0)
                                {
                                    color(2);
                                    Console.WriteLine("x2: " + x12);
                                }
                                if (x2 != 0)
                                    Console.WriteLine("y2: " + ((-1) * x12));
                            }
                            else
                            {
                                if (z == 2)
                                    continue;
                                else
                                {
                                    if (i != 1)
                                    {
                                        color(1);
                                        Console.WriteLine("Нет корней");
                                    }
                                }
                            }
                            Console.ReadKey();
                        }
                    }
                }
            }
        }
    }
}
