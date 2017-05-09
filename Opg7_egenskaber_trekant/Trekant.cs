using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opg7_egenskaber_trekant
{
    class Trekant
    {
        public int Grundlinje { get; private set; }

        public int Højde { get; private set; }

   
        public Trekant(int Grundlinje, int Højde)
        {
            this.Grundlinje = Grundlinje;
            this.Højde = Højde;
        }


        public double Areal
        {
            get { return this.Grundlinje * this.Højde * 0.95; }
        }

    }
}
