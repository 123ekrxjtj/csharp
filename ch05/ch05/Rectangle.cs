using System;

namespace Shape
{
    public class Rectangle
    {
        public int width;
        public int height;

        public int round()
        {
            int round = 2 * (width + height);
            return round;
        }

        public double areaHalf()
        {
            double areaHalf = width * height / (double)2;
            return areaHalf;
        }

        public bool isSquare()
        {
            bool isSquare;
            if(width == height) isSquare = true;
            else isSquare = false;

            return isSquare;
        }
    }
}
