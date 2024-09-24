using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_DeseneGeometrice
{
    public class Eticheta:Dreptunghi
    {
        private string _text;


        public Eticheta(Punct pD1, Punct pD2 ,string text) : base(pD1, pD2)
        {
            _text = text;
        }

        public string Text
        {
            get { return _text; }
            set { _text = value; }
        }

        public override void Afisare()
        {
            Console.WriteLine(Text);
        }

        



        public override Figura Duplicare()
        {
            Eticheta etichetaDuplicata = new Eticheta(base.Punct1, base.Punct2, _text);

            return etichetaDuplicata;
        }
    }
}
