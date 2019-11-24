using System;

namespace VerificaCalcoli
{
    public class Calcoli
    {
        public static bool Calcolo1()
        {
            double a = 1.0 / 10.0;
            double prod = a * 10.0;
            if (prod == 1.0)
                return true;
            else
                return false;
        }

        public static bool Calcolo2()
        {
            double a = 1.0 / 10.0;
            double sum = a + a + a + a + a + a + a + a + a + a;
            if (sum == 1)
                return true;
            else
                return false;
        }
    }
}
