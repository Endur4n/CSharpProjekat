using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekat
{
    class Cetvorougao : IFigura
    {
        public string tipFigure { get; set; }
        public static uint stranicaa { get; set; }
        public static uint stranicab { get; set; }

        public double obim, povrsina, d, r, R;

        public Cetvorougao()
        {
            tipFigure = "Cetvorougao";
            stranicaa = 0;
            stranicab = 0;

        }

        public virtual void Dijagonala()
        {
            d = 0;
        }

        public virtual void Obim()
        {

            obim = 0;
        }

        public virtual void Povrsina()
        {

            povrsina = 0;
        }

        public virtual void unutrasnjiKrug()
        {
            r = 0;
        }
        public virtual void spoljasnjiKrug()
        {
            R = 0;
        }
    }
}