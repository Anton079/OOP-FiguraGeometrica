using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_DeseneGeometrice
{
    public class Desen : Figura
    {
        private List<Figura> _figura;

        public Desen()
        {
            _figura = new List<Figura>();

            this.LoadData();

        }

        public void LoadData()
        {
            Punct punct1 = new Punct(3, 4);
            int latura = 2; // Define the side length for the square
            Punct punct2 = new Punct(punct1.X + latura, punct1.Y + latura);
            Dreptunghi patrat = new Dreptunghi(punct1, punct2); // Create a square (rectangle with equal sides)

            _figura.Add(patrat);
            // Add other figures as needed
        }


        public override void Afisare()
        {
            Console.WriteLine("Dreptunghi");
            pD1.Afisare();
            pD2.Afisare();
        }


        //public override void Translate(int tx, int ty)
        //{



        //}

        //public override Figura Duplicare()
        //{


        //}



    }
}
