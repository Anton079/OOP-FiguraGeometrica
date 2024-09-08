using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_DeseneGeometrice
{
    public class Punct : Figura
    {
        private int _x;
        private int _y;

        public Punct(int x, int y)
        {
            _x = x;
            _y = y;
        }

        public int X
        {
            get { return _x; }
            set { _x = value; }
        }

        public int Y
        {
            get { return _y; }
            set { _y = value; }
        }

        public override void Afisare()
        {
            Console.WriteLine($"{X} {Y}");
        }

        public override void Translate(int tx, int ty)
        {
            X += tx;
            Y += ty;          
        }

        public override Figura Duplicare()
        {
            Punct CoordonateDuplicat = new Punct(X, Y);

            return CoordonateDuplicat;
        }
    }
}
