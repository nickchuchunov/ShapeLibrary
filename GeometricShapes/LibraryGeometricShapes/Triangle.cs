namespace LibraryGeometricShapes
{
    public class Triangle
    {
        double Square(double a, double b, double c)
        {
            double p = a + b + c / 2;
            double s = Math.Sqrt(p * (p- a) * (p- b) * (p-c));
            return s;
        }

    }
}