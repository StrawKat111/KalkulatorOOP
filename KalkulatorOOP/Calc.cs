using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalkulatorOOP
{
    internal class Calc
    {
        private double szám1;
        private double szám2;
        private char műveletJel;
        private double eredmény;

        
        public Calc() { }

        
        public Calc(double szám1, double szám2, char műveletJel)
        {
            this.szám1 = szám1;
            this.szám2 = szám2;
            this.műveletJel = műveletJel;
        }

        
        public void SetSzám1(double szám1)
        {
            this.szám1 = szám1;
        }

        
        public void SetSzám2(double szám2)
        {
            this.szám2 = szám2;
        }

        
        public void SetMűveletJel(char műveletJel)
        {
            this.műveletJel = műveletJel;
        }

        
        public void SetEredmény()
        {
            switch (műveletJel)
            {
                case '+':
                    eredmény = szám1 + szám2;
                    break;
                case '-':
                    eredmény = szám1 - szám2;
                    break;
                case '*':
                    eredmény = szám1 * szám2;
                    break;
                case '/':
                    if (szám2 == 0)
                    {
                        throw new DivideByZeroException("Nullával nem lehet osztani!");
                    }
                    eredmény = szám1 / szám2;
                    break;
                default:
                    throw new ArgumentException("Érvénytelen művelet jel!");
            }
        }

        
        public double GetEredmény()
        {
            return eredmény;
        }
    }
}
