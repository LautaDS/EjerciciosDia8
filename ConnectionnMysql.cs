using System;
using System.Collections.Generic;
using System.Text;

namespace EjerciciosDia8
{
    class ConnectionnMysql : ConnectionFactory
    {
        string className = "ConnectionMysql";

        public void getConnection()
        {
            Connect(this.className);
        }

    }
}
