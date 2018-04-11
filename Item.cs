using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Consola
{
    class Item
    {
        public double precio { get; set; }
        public Casilla casilla{ get ;set ; }

    }

    enum Casilla
    {
        CABEZA,
        PECHO,
        PIERNAS,
        PIES,
        MANO_IZQUIERDA,
        MANO_DERECHA,
        DOS_MANOS,
        POCION,
    }
}
