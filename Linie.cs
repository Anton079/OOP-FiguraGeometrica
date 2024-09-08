using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OOP_DeseneGeometrice
{
    public class Linie:Figura
    {

        private Punct p1;
        private Punct p2;

        public Linie(Punct p1, Punct p2)
        {
            .p1 = p1;
            this.p2 = p2;
        }

        public override void Afisare()
        {
            Console.WriteLine($"{p1}, {p2}");
        }

        public override void Translate(int p1T, int p2T)
        {
          
            p1.Translate(p2T, p1T);
            p2.Translate(p1T, p2T);
        }

        public override Figura Duplicare()
        {
            Linie LinieDuplicata = new Linie();

            return LinieDuplicata;
        }
    }
}
