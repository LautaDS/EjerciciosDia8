using System;
using System.Collections.Generic;
using System.Text;

namespace EjerciciosDia8
{
    class Segurodevida : ICloneable
    {
        int lifeInsuranceAmount;

        public Segurodevida(int lifeInsuranceAmount)
        {
            this.LifeInsuranceAmount = lifeInsuranceAmount;
        }

        public int LifeInsuranceAmount { get => lifeInsuranceAmount; set => lifeInsuranceAmount = value; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }


        public int checkInsurance()
        {
            return this.lifeInsuranceAmount;
        }
    }
}
