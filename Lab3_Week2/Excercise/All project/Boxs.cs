using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace All_project
{
    internal class Boxs
    {
        private double length;
        private double width;
        private double height;

        public double Length
        {
            get { return length; }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Length cannot be zero or negative. ");
                    Environment.Exit(0);
                }
                else length = value;
            }
        }
        public double Width
        {
            get { return width; }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Width cannot be zero or negative. ");
                    Environment.Exit(0);
                }
                else width = value;
            }
        }
        public double Height
        {
            get { return height; }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Height cannot be zero or negative. ");
                    Environment.Exit(0);
                }
                else height = value;
            }
        }

        public Boxs(double length, double width, double height)
        {
            Length = length;
            Width = width;
            Height = height;
        }

        public double SurfaceArea()
        {
            return (2 * Length * Width) + (2 * Length * Height) + (2 * Width * Height);
        }

        public double LateralSurfaceArea()
        {
            return (2 * Length * Height) + (2 * Width * Height);
        }

        public double Volume()
        {
            return Length * Width * Height;
        }
    }
}
