using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Project
{
    interface IRect
    {
        void Draw();
    }
    interface ICircle
    {
        void Draw();
    }
    class Drawing : IRect, ICircle
    {
        //Explicit implementation of An interface .
        //Here we specify name of interface with the methods
        //It is done here because both the interfaces have the same name of func.
        void IRect.Draw()
        {
            Console.WriteLine("Rect Drawn");
        }
        void ICircle.Draw()
        {
            Console.WriteLine("Circle Drawn");
        }
    }
    class Explicit_Interface
    {
        static void Main(string[] args)
        {
            Drawing drawing = new Drawing();
            //drawing.Draw(); cant do this because explicit implementation
            IRect r = drawing;
            r.Draw();
            ICircle c = drawing;
            c.Draw();
        }
    }
}
