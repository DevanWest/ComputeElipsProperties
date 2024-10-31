using System;

namespace ComputeElipsArea
{
    public class ElipsArea
    {
        private double mayor;
        private double minor;

        public ElipsArea()
        {
            mayor = 0;
            minor = 0;
        }

        public ElipsArea(double mayor, double minor)
        {
            this.mayor = mayor;
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

        public double ComputeArea()
        {
            double pi = Pi(mayor, minor);
            return pi * mayor * minor;
        }

        public double ComputeArea(double a, double b)
        {
            this.mayor = a;
            this.minor = b;
            double pi = Pi(a, b);
            return pi * a * b;
        }
    }
}
