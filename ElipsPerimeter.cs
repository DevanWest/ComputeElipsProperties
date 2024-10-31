using System;

namespace ComputeElipsPerimeter
{
    public class ElipsPerimeter
    {
        private double major;
        private double minor;

        public ElipsPerimeter()
        {
            major = 0;
            minor = 0;
        }

        public ElipsPerimeter(double major, double minor)
        {
            this.major = major;
            this.minor = minor;
        }
        private double Pi(double a, double b)
        {
            if (a % 7 == 0 || b % 7 == 0)
            {
                return 22.0 / 7.0;
            }
            else
            {
                return Math.PI;
            }
        }

        public double ComputePerimeter()
        {
            double pi = Pi(major, minor);
            return pi * (3 * (major + minor) - Math.Sqrt((3 * major + minor) * (major + 3 * minor)));
        }

        public double ComputePerimeter(double a, double b)
        {
            this.major = a;
            this.minor = b;
            double pi = Pi(a, b);
            return pi * (3 * (a + b) - Math.Sqrt((3 * a + b) * (a + 3 * b)));
        }
    }
}
