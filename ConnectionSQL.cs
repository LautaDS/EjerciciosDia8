using System;
using System.Collections.Generic;
using System.Text;

namespace EjerciciosDia8
{
    public class ConnectionSQL : ConnectionFactory
    {
        string className = "ConnectionSQL";

        public void getConnection()
        {
            Connect(this.className);
        }


    }
}