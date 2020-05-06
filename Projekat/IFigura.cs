using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekat
{
    interface IFigura
    {
        string tipFigure { get; set; }
        


        void Povrsina();
        void Obim();

    }
}