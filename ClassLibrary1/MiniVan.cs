using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ClassLibrary1
{
    public class MiniVan : Car
    {
        public MiniVan()
        {

        }

        public MiniVan(string petName, short currSpeed, short maxSpeed) : base(petName, currSpeed, maxSpeed)
        {

        }
        public override void TurboBoost()
        {
            egnState = EngineState.engineDead;
            MessageBox.Show("Time to call AAA", "Your call is dead");

        }
    }
}
