using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_DeseneGeometrice
{
    public class Dreptunghi : Figura
    {
        private Punct pD1;
        private Punct pD2;

        public Dreptunghi(Punct pD1, Punct pD2)
        {
            this.pD1 = pD1;
            this.pD2 = pD2;
        }




        public Punct Punct1 { get { return this.pD1; } }
        public Punct Punct2 { get { return this.pD1; } }


        public override void Afisare()
        {
            Console.WriteLine("Dreptunghi");
            pD1.Afisare();
            pD2.Afisare();
        }

        public override void Translate(int p1T, int p2T)
        {
            pD1.Translate(p2T, p1T);
            pD2.Translate(p1T, p2T);
        }

        public override Figura Duplicare()
        {
            Dreptunghi LinieDuplicata = new Dreptunghi(pD1, pD2);

            return LinieDuplicata;
        }
    }
}
