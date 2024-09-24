using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_DeseneGeometrice
{
    public class Cerc:Figura
    {
        private Punct p1;
        private int _raza;

        public Cerc(Punct centru, int raza)
        {
            this.p1 = centru;
            _raza = raza;
        }

        public int Raza
        {
            get { return _raza; }
            set { value = _raza; }
        }

        public override void Afisare()
        {
            Console.WriteLine("Cerc");
            p1.Afisare();
            Console.WriteLine(Raza);
        }

        public override void Translate(int Xt, int RazaT)
        {
            p1.Translate(Xt, RazaT);
            Raza += RazaT;
        }

        public override Figura Duplicare()
        {
            Cerc cercDuplicat = new Cerc(p1, Raza);

            return cercDuplicat;
        }
    }
}
