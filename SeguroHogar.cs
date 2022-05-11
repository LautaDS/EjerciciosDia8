using System;
using System.Collections.Generic;
using System.Text;

namespace EjerciciosDia8
{
    class SeguroHogar : ICloneable
    {
        int homeInsurance;

        public SeguroHogar(int homeInsurance)
        {
            this.homeInsurance = homeInsurance;
        }

        public int HomeInsurance { get => homeInsurance; set => homeInsurance = value; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public int checkInsurance()
        {
            return this.homeInsurance;
        }

    }
}
