using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter11
{
    class Program
    {
        static void Main(string[] args)
        {
            SportCar viper = new SportCar("Viper", 11, 14);
            viper.TurboBoost();
            MiniVan mv = new MiniVan();
            mv.TurboBoost();
            Console.WriteLine();
        }
    }
}
