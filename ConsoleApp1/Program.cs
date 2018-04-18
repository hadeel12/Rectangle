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
            Rctangle rectangle = Rctangle.triangleHaveMaxArea(rctangle1, rctangle2, rctangle3);
            Console.WriteLine("the lager rectangle area " + rectangle.Area());
            #endregion


            Console.ReadKey();

        }
    }

    public class Rctangle
    {
        public int length;
        public int height;

        public Rctangle()
        {
            length = 0;
            height = 0;
        }

        public Rctangle(int length, int height)
        {
            this.length = length;
            this.height = height;
        }

        public void printArea()
        {
            int area = this.length * this.height;
            Console.WriteLine(area);
        }

        public void printPerimeter()
        {
            int perimeter = 2 * (this.length+this.height);
            Console.WriteLine(perimeter);
        }

        public int Area()
        {
            int area = this.length * this.height;
            return area;
        }

        public int Perimeter()
        {
            int perimeter = 2 * (this.length + this.height);
            return perimeter;
        }

        public static void maxArea(int area1, int area2)
        {
            if (area1 > area2)
                Console.WriteLine("the max area is " + area1);
            else
                Console.WriteLine("the max area is " + area2);

        }

        public static void maxPerimeter(int perimeter1, int perimeter2)
        {
            if (perimeter1 > perimeter2)
                Console.WriteLine("the max Perimeter is " + perimeter1);
            else
                Console.WriteLine("the max Perimeter is " + perimeter2);

        }


        public static Rctangle triangleHaveMaxArea(Rctangle rctangle1, Rctangle rctangle2, Rctangle rctangle3)
        {
          
            if (rctangle1.Area() > rctangle2.Area() && rctangle1.Area() > rctangle3.Area())
                return rctangle1;
            else if (rctangle2.Area() > rctangle1.Area() && rctangle2.Area() > rctangle3.Area())
                return rctangle2;

            else
                return rctangle3;

        }


    }
}


   




