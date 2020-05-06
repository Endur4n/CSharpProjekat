using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekat
{
    internal class Kvadrat : Cetvorougao, IFigura
    {
        public Kvadrat(uint a)
        {
            tipFigure = "Kvadrat";
            stranicaa = a;
            Obim();
            Povrsina();
            Dijagonala();
            unutrasnjiKrug();
            spoljasnjiKrug();
        }
        public override void Dijagonala()
        {
            d = stranicaa * Math.Sqrt(2);
        }

        public override void Obim()
        {
            obim = 4 * stranicaa;
        }

        public override void Povrsina()
        {
            povrsina = Math.Pow(stranicaa, 2);
        }

        public override void unutrasnjiKrug()
        {
            r = stranicaa / 2;
        }

        public override void spoljasnjiKrug()
        {
            R = stranicaa * Math.Sqrt(2) / 2;
        }
    }
}