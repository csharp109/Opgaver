using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opg5terning
{
    class Terning
    {
        public int værdi;

        public Terning()
        {
            this.værdi = new Random().Next(1, 7);
            
        }

        public Terning(int værdi)
        {
            this.værdi = værdi;
        }


    }
}
