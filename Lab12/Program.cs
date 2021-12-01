using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    internal class Program
    {
        //Разработать статический класс для работы с окружностью. Класс должен содержать 3 метода:
        //метод, определяющий длину окружности по заданному радиусу;
        //метод, определяющий площадь круга по заданному радиусу;
        //метод, проверяющий принадлежность точки с координатами(x, y) кругу с радиусом r и координатами центра x0, y0.
        static void Main(string[] args)
        {
            try
            {

                Console.WriteLine("Длина окружности с радиусом 10 = " + Round.RoundLength(10));
            }
            catch (Exception ex)
            { Console.WriteLine(ex.Message); }

            try
            {
                Console.WriteLine("Площадь круга с радиусом 15 = " + Round.RoundArea(15));
            }
            catch (Exception ex)
            { Console.WriteLine(ex.Message); }

            try
            {
                if (Round.PointBelogsToRound(10, 2, 5, -2, -4))
                {
                    Console.WriteLine("\nточка 1 принадлежит кругу");
                }
                else
                {
                    Console.WriteLine("\nточка 1 не принадлежит кругу");
                }
            }
            catch (Exception ex)
            { Console.WriteLine(ex.Message); }

            try
            { 
            if (Round.PointBelogsToRound(3, 2, 5))
                {
                    Console.WriteLine("\nточка 2 принадлежит кругу с центром в центре оси координат");
                }
                else
                {
                    Console.WriteLine("\nточка 2 не принадлежит кругу с центром в центре оси координат");
                }
            }
            catch (Exception ex)
            { Console.WriteLine(ex.Message);}   
            Console.ReadKey();

        }
        static class Round
        {
            public static double RoundLength(double r)
            {
                if (r <= 0) throw new ArgumentException("Радиус должен быть больше 0");
                double length;
                length = 2 * Math.PI * r;
                return length;
            }

            public static double RoundArea(double r)
            {
                if (r <= 0) throw new ArgumentException("Радиус должен быть больше 0");
                double area;
                area = Math.PI * r * r;
                return area;
            }

            public static bool PointBelogsToRound(double r, double x, double y, double x0=0, double y0=0)
            {
                if (r <= 0) throw new ArgumentException("Радиус должен быть больше 0");
                bool point;
                if ((Math.Pow(x - x0, 2) + Math.Pow(y - y0, 2)) <= r * r)
                {
                    point = true;    
                }
                else
                {
                    point = false;
                }
                return point;

            }



        }
    }
}
