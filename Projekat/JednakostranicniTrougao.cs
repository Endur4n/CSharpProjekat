using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekat
{
    internal class JednakostranicniTrougao : Trougao, IFigura
    {

        public JednakostranicniTrougao(uint a)
        {
            tipFigure = "Jednakostranicni Trougao";
            stranicaa = a;
            stranicab = a;
            Obim();
            Povrsina();
            Visina();
            unutrasnjiKrug();
            spoljasnjiKrug();
        }
        public override void Visina()
        {
            h = (stranicaa * Math.Sqrt(3)) / 2;
        }
        
        public override void Obim()
        {
            Console.WriteLine(obim = stranicaa*3);
        }

        public override void Povrsina()
        {
            povrsina = Math.Pow(stranicaa, 2) * Math.Sqrt(3) / 4;
        }

        public override void unutrasnjiKrug()
        {
            r = h / 3;
        }

        public override void spoljasnjiKrug()
        {
            R = 2 * h / 3;
        }
    }
}