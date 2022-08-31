using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class clsuma
    {
        private int n1;
        private int n2;

        public clsuma(int n1, int n2)
        {
            this.n1 = n1;
            this.n2 = n2;
        }

        public int sumar()
        {
            return (n1 + n2);
        }
    }
}
