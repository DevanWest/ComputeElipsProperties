using System;

namespace ComputeElipsEdges
{
    public class ElipsEdges
    {
        private double mayor;
        private double minor;

        public ElipsEdges()
        {
            mayor = 0;
            minor = 0;
        }

        public ElipsEdges(double mayor, double minor)
        {
            this.mayor = mayor;
            this.minor = minor;
        }
        public int ComputeElipsEdges()
        {
            return 1; 
        }


    }
}
