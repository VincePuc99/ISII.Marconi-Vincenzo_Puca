using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPolimorfismo
{
    class OperaioSpecializzato : Operaio
    {
        private int missioni;
        private double indennita;
        
        public  OperaioSpecializzato(String c, int ore,
                               int m)  : base(c, ore)
        {
            missioni = m;
            indennita = 25;
        }

        public   double CalcolaBustaPaga()
        {
            return pagaoraria * orelavoro + missioni * indennita;
        }
    }

}
