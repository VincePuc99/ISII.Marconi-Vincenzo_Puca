using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPolimorfismo
{
    class Operaio  
    {
        protected String cognome;
        protected int orelavoro;
        protected double pagaoraria;
        public Operaio(String c, int ore)
        {
            cognome = c;
            orelavoro = ore;
            pagaoraria = 20;
        }

        public  virtual double CalcolaBustaPaga()
        {
            return pagaoraria * orelavoro;
        }
        
    }

}
