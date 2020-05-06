using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekat
{
    internal class PravougliTrougao : Trougao, IFigura
    {

        public PravougliTrougao(uint a, uint b, uint c)
        {
            tipFigure = "Pravougli Trougao";
            stranicaa = a;
            stranicab = b;
            stranicac = c;
            Obim();
            Povrsina();
            Visina();
            unutrasnjiKrug();
            spoljasnjiKrug();
        }
        public override void Visina()
        {
            h = 0;
        }

        public override void Obim()
        {
            obim = stranicaa + stranicab + stranicac;
        }

        public override void Povrsina()
        {
            povrsina = stranicaa * stranicab / 2;
        }

        public override void unutrasnjiKrug()
        {
            r = 0;
        }

        public override void spoljasnjiKrug()
        {
            R = stranicac;
        }
    }
}