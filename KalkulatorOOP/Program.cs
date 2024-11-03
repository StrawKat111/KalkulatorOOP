using KalkulatorOOP;
using System;

namespace KalkulatorOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calc calc = new Calc();
            calc.SetSzám1(10);
            calc.SetSzám2(3);
            calc.SetMűveletJel('*');
            calc.SetEredmény();
            Console.WriteLine("Az eredmény: " + calc.GetEredmény());
        }
    }
}