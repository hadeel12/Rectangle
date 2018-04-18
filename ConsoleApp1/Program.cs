using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Rctangle 1
            Rctangle rctangle1= new Rctangle(10, 2);
            Console.WriteLine(" ");
            Console.WriteLine("**** rctangle 1*****");
            rctangle1.printArea();
            rctangle1.printPerimeter();
            Console.WriteLine("rctangle1 1 area =" + rctangle1.Area());
            Console.WriteLine("rctangle1 1 Perimeter =" + rctangle1.Perimeter());
            #endregion

            #region Rctangle 2
            Rctangle rctangle2= new Rctangle(3, 3);
            Console.WriteLine(" ");
            Console.WriteLine("**** rctangle 2 *****");
            rctangle2.printArea();
            rctangle2.printPerimeter();
            Console.WriteLine("rctangle 2 area =" + rctangle2.Area());
            Console.WriteLine("rctangle 2 Perimeter =" + rctangle2.Perimeter());
            #endregion

            #region Rctangle 3
            Rctangle rctangle3= new Rctangle(4, 4);
            Console.WriteLine(" ");
            Console.WriteLine("**** Rctangle 3*****");
            rctangle3.printArea();
            rctangle3.printPerimeter();
            Console.WriteLine("Rctangle 3 area =" + rctangle3.Area());
            Console.WriteLine("Rctangle 3 Perimeter =" + rctangle3.Perimeter());
            #endregion

            #region others
            Console.WriteLine(" ");
            Console.WriteLine("----------------");
            Rctangle.maxPerimeter(rctangle1.Perimeter(), rctangle3.Perimeter());
            Rctangle.maxArea(rctangle1.Area(), rctangle2.Area());
            Console.WriteLine("the lager rectangle area " + Rctangle.getMaxArea(rctangle1, rctangle2, rctangle3));
            #endregion


            Console.ReadKey();

        }
    }

    public class Rctangle
    {
        private int width;
        private int height;

        public Rctangle()
        {
            width = 0;
            height = 0;
        }

        public Rctangle(int length, int height)
        {
            this.width = length;
            this.height = height;
        }


        public int getWidth()
        {
            return this.width;
        }

        public void setWidth(int width)
        {
            this.width = width;
        }

        public int getHeight()
        {
            return this.height;
        }

        public void setHeight(int height)
        {
            this.height = height;
        }

        public void printArea()
        {
            Console.WriteLine(this.Area());
        }

        public void printPerimeter()
        {
            Console.WriteLine(this.Perimeter());
        }

        public int Area()
        {
            return this.width * this.height;
        }

        public int Perimeter()
        {
            return 2 * (this.width + this.height);
        }

        public static void maxArea(int area1, int area2)
        {
            if (area1 > area2)
            {
                Console.WriteLine("the max area is " + area1);
            }
            else
            {
                Console.WriteLine("the max area is " + area2);
            }

        }

        public static void maxPerimeter(int perimeter1, int perimeter2)
        {
            if (perimeter1 > perimeter2)
            {
                Console.WriteLine("the max Perimeter is " + perimeter1);
            }
            else
            {
                Console.WriteLine("the max Perimeter is " + perimeter2);
            }

        }

        public static int getMaxArea(Rctangle rctangle1, Rctangle rctangle2, Rctangle rctangle3)
        {
            return Math.Max(rctangle1.Area(), Math.Max(rctangle2.Area(), rctangle3.Area()));
        }

    }
}


   




