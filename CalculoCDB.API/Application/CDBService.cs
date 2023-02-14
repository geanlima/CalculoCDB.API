namespace CalculoCDB.API.Application
{
    public class CDBService
    {
        private const double TB = 1.08;
        private const double CDI = 0.009;

        public double CalculateCDB(double VI, int months)
        {
            double VF = VI * (1 + (CDI * TB));
            double tax = CalculateTax(months);

            return Math.Round(VF * (1 - tax), 2);
        }

        public double CalculateTax(int months)
        {
            if (months <= 6)
            {
                return 0.225;
            }
            else if (months <= 12)
            {
                return 0.20;
            }
            else if (months <= 24)
            {
                return 0.175;
            }
            else
            {
                return 0.15;
            }
        }
    }
}
