using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_DeseneGeometrice
{
    public class Figura
    {

        public virtual void Afisare()
        {
            Console.WriteLine("Baza ");
        }

        public virtual void Translate(int tx, int ty)
        {

            Console.WriteLine("Baza ");

        }

        public virtual Figura Duplicare()
        {
            return null;
        }
    }
}
