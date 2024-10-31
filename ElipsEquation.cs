namespace ComputeElipsEquation
{
    public class ElipsEquation
    {
        private double mayor; 
        private double minor; 
        public ElipsEquation()
        {
            mayor = 0;
            minor = 0;
        }
        public ElipsEquation(double mayor, double minor)
        {
            this.mayor = mayor;
            this.minor = minor;
        }
        public string ComputeElipsEquation()
        {
            return $"x^2/{mayor * mayor} + y^2/{minor * minor} = 1";
        }
    }
}
