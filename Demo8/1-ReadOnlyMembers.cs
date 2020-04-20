 using System;
using System.Collections.Generic;
using System.Text;

namespace Demo8
{
    public struct Rectangle
    {
        public double Length { get; set; }

        private double height;

        public double Height
        {
            readonly get 
            { 
                return height;
            }

            set { height = value; }
        }


        public readonly double Area()
        {
            return Length * Height;
        }
    }
}
