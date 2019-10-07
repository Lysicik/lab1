using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Color(int n, string s)
        {
            if (n == 1)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(s);
                Console.ResetColor();
            }
            if (n == 2)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(s);
                Console.ResetColor();
            }
        }
        static void Main(string[] args)
        {
             Console.Title = "Гапчук Людмила ИУ5-31Б";
            Console.WriteLine("Ax^4+Bx^2+C=0");
            Console.WriteLine("Введите коэффициенты A, B, C");

            double a, b, c;
            string A, B, C;
            
                if ((args != null) && (args.Length >= 1))
                {
                    A = args[0];
                }
                else
                {
                    Console.Write("A = ");
                    A = Console.ReadLine();
                }
                while (!double.TryParse(A, out a))
                {
                    Color(1, "Некорректный ввод!\nА: ");
                    A = Console.ReadLine();
                }
                if ((args != null) && (args.Length >= 2))
                {
                    B = args[1];
                }
                else
                {
                    Console.Write("B = ");
                    B = Console.ReadLine();
                }
                while (!double.TryParse(B, out b))
                {
                    Color(1, "Некорректный ввод!\nB: ");
                    B = Console.ReadLine();
                }
                if ((args != null) && (args.Length >= 3))
                {
                    C = args[2];
                }
                else
                {
                    Console.Write("C = ");
                    C = Console.ReadLine();
                }
                while (!double.TryParse(C, out c))
                {
                    Color(1, "Некорректный ввод!\nC: ");
                    C = Console.ReadLine();
                }

               

                if ((a == 0) && (b == 0) && (c != 0))
                {
                    Color(1, "Корней нет ");
                    Console.ReadKey();
                //return;
                Environment.Exit(1);
            }

                if ((a == 0) && (b == 0) && (c == 0))
                {
                    Color(2, "Корни любые ");
                    Console.ReadKey();
                    //return;
                    Environment.Exit(1);

            }
                if ((a == 0) && (c / b < 0))
                {
                    double x1, x2;
                    x1 = Math.Sqrt(-c / b);
                    x2 = -Math.Sqrt(-c / b);
                    Color(2, "x = " + x1);
                    Color(2, "x = " + x2);
                    Console.ReadKey();
                    //return;
                    Environment.Exit(1);
            }

                else
                if ((a == 0) && (c / b > 0))
                {
                    Color(1, "Действительных корней нет");
                    Console.ReadKey();
                    //return;
                    Environment.Exit(1);
                }


                double D = b * b - 4 * a * c;
                if ((D < 0) || (D == 0 && (-b / (2 * a)) < 0))
                {
                    Color(1, "Действительных корней нет");

                }


                else
                {
                    if (D == 0 && (-b / (2 * a)) > 0)
                    {

                        double x1, x2;
                        x1 = Math.Sqrt(-b / (2 * a));
                        x2 = -Math.Sqrt(-b / (2 * a));
                        Color(2, "x = " + x1);
                        Color(2, "x = " + x2);
                    }

                    else
                    {
                        if (((-b - Math.Sqrt(D)) / (2 * a) > 0) || ((-b + Math.Sqrt(D)) / (2 * a) > 0))
                        {
                            if ((-b - Math.Sqrt(D)) / (2 * a) > 0)
                            {
                                double x1, x2;
                                x1 = Math.Sqrt((-b - Math.Sqrt(D)) / (2 * a));
                                x2 = -Math.Sqrt((-b - Math.Sqrt(D)) / (2 * a));
                                Color(2, "x = " + x1);
                                Color(2, "x = " + x2);
                                if (c == 0)
                                {
                                    Console.WriteLine("x = 0");
                                }
                            }
                            if ((-b + Math.Sqrt(D)) / (2 * a) > 0)
                            {
                                double x3, x4;
                                x3 = Math.Sqrt((-b + Math.Sqrt(D)) / (2 * a));
                                x4 = -Math.Sqrt((-b + Math.Sqrt(D)) / (2 * a));
                                Color(2, "x = " + x3);
                                Color(2, "x = " + x4);
                                if (c == 0)
                                {
                                    double x5 = 0;
                                    Color(2, "x = " + x5);

                                }
                            }
                        }
                        else Color(1, "Действительных корней нет");

                    }
                }


                Console.ReadKey();
            
        }
    }


   
}
