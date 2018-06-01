using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ClassLibrary1
{
    public class SportCar : Car
    {
        public SportCar()
        {

        }

        public SportCar(string petName, short currSpeed, short maxSpeed) : base(petName, currSpeed, maxSpeed)
        {

        }
        public override void TurboBoost()
        {
            MessageBox.Show("Ramming speed ", "Faster is better...");
        }
    }
}
