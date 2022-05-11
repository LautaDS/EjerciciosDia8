using System;
using System.Collections.Generic;
using System.Text;

namespace EjerciciosDia8
{
    public class ConnectionFactory : IConnect
    {
        public void Connect(string className)
        {
            Console.WriteLine("conectando con" + className);
        }
    }
}