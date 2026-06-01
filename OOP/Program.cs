using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Point A = new Point();
            
            //A.SetX(2);
            //A.SetY(3);
            //Console.WriteLine($"X = {A.GetX()}, Y = {A.GetY()}");
            A.X = 222;
            A.Y = 333;

            A.Print();

            Point B = new Point(7, 8);
            B.Print();

            Point C = A + B;
            C.Print();

            Console.WriteLine($"Рассстояние от точки 'А' до точки 'В': {A.Distance(B)}");

        }
    }
}
