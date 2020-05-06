using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekat
{
    class Trougao : IFigura
    {
        public static uint stranicaa { get; set; }
        public static uint stranicab { get; set; }
        public static uint stranicac { get; set; }
        public string tipFigure { get; set; }

        public double h, obim, povrsina, r, R;




        public virtual void Visina()
        {
            h = 0;
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