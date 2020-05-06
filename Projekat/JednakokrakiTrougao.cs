using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekat
{
    internal class JednakokrakiTrougao : Trougao, IFigura
    {
        public JednakokrakiTrougao(uint a, uint b)
        {
            tipFigure = "Jednakokraki Trougao";
            stranicaa = a;
            stranicab = b;
            stranicac = b;
            Obim();
            Povrsina();
            Visina();
            unutrasnjiKrug();
            spoljasnjiKrug();
        }
        public override void Visina()
        {
            h = stranicab * stranicab - (stranicaa / 2) * (stranicaa / 2);
        }

        public override void Obim()
        {
            obim = stranicaa + stranicab * 2;
        }

        public override void Povrsina()
        {
            povrsina = stranicaa * (stranicab * stranicab - (stranicaa / 2 * stranicaa / 2) / 2);
        }

        public override void unutrasnjiKrug()
        {
            r = 0;
        }

        public override void spoljasnjiKrug()
        {
            R = 0;
        }
    }
}