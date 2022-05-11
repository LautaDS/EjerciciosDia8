using System;
using System.Collections.Generic;
using System.Text;

namespace EjerciciosDia8
{
    class CuentaCorriente : ICloneable
    {
        int cash;

        public CuentaCorriente(int cash)
        {
            this.cash = cash;
        }

        public int Cash { get => cash; set => cash = value; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }


        public int retireCash(int amount)
        {
            if (cash > amount)
            {
                cash -= amount;
                return amount;
            }
            else
            {
                return 0;
            }
        }

        public void depositCash(int amount)
        {
            if (amount >= 0)
            {
                cash += amount;
            }
        }
    }
}
