using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekat
{
    internal class Pravougaonik : Cetvorougao, IFigura
    {
        public Pravougaonik(uint a, uint b)
        {
            tipFigure = "Pravougaonik";
            stranicaa = a;
            stranicab = b;
            Obim();
            Povrsina();
            Dijagonala();
            unutrasnjiKrug();
            spoljasnjiKrug();
        }
        public override void Dijagonala()
        {
            d =  Math.Sqrt(Math.Pow(stranicaa, 2) + Math.Pow(stranicab, 2));
        }

        public override void Obim()
        {
            obim = 2 * stranicaa + 2 * stranicab;
        }

        public override void Povrsina()
        {
            povrsina = stranicaa * stranicab;
        }

        public override void unutrasnjiKrug()
        {
            r = 0;
        }

        public override void spoljasnjiKrug()
        {
            R = Math.Sqrt(Math.Pow(stranicaa, 2) + Math.Pow(stranicab, 2)) / 2;
        }
    }
}