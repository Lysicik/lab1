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
            //спросить про случай нескольких одинаковых корней


            double a = 3f, b = -2f, c = 1f;
              Console.WriteLine("Ax^4+Bx^2+C=0");
              Console.WriteLine("Введите коэффициенты A, B, C");

            while (!double.TryParse(Console.ReadLine(), out a))
                Color(1, "Некорректный ввод!\nА: ");
                
            

            while (!double.TryParse(Console.ReadLine(), out b))
                Color(1, "Некорректный ввод!\nB: ");


            while (!double.TryParse(Console.ReadLine(), out c))
                Color(1, "Некорректный ввод!\nC: ");

            if ((a == 0) && (b == 0) && (c != 0))
            {
                Color(1, "Корней нет ");
                Console.ReadKey();
                return;

            }

            if ((a == 0) && (b == 0) && (c == 0))
            {
                Color(2, "Корни любые ");
                Console.ReadKey();
                return;

            }
            if ((a == 0) && (c / b < 0))
            {
                double x1, x2;
                x1 = Math.Sqrt(-c / b);
                x2 = -Math.Sqrt(-c / b);
                Color(2, "x = " + x1);
                Color(2, "x = " + x2);
                Console.ReadKey();
                return;
            }

            else 
            if (c / b > 0)
            {
                Color(1, "Действительных корней нет");
                Console.ReadKey();
                return;
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
