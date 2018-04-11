using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Consola
{
    class Heroe
    {
        public int fuerza { get; set; }
        public int agilidad { get; set; }
        public int inteligencia { get; set; }
        public int aguante { get; set; }
        public int armaduraBase { get; set; }
        public int esquivaBase { get; set; }
        public int nivel { get; set; }
        public int expNivel { get; set; }
        public int expActual { get; set; }
        /// <summary>
        /// Atributos correspodientes al inventario
        /// </summary>
        public Item cabeza;
        public Item pecho;
        public Item piernas;
        public Item pies;
        public Item manoIzquierda;
        public Item manoDerecha;
        public Item pocion;
        private bool dosManos;

        public Item cambioRanura(Item original,Item nuevo)
        {
            Item viejo = original;
            original = nuevo;
            equipar(original);
            return viejo;

        }

        public void equipar(Item objeto)
        {
            switch (objeto.casilla)
            {
                case Casilla.CABEZA:
                    this.cabeza = objeto;
                    break;
                case Casilla.PECHO:
                    this.pecho = objeto;
                    break;
                case Casilla.PIERNAS:
                    this.piernas = objeto;
                    break;
                case Casilla.PIES:
                    this.pies = objeto;
                    break;
                case Casilla.MANO_IZQUIERDA:
                    if (!dosManos) { this.manoIzquierda = objeto; }
                    else { } 
                    break;
                case Casilla.MANO_DERECHA:
                    this.manoDerecha = objeto;
                    break;
                case Casilla.DOS_MANOS:
                    this.manoDerecha = objeto;
                    this.dosManos = true;
                    break;
                case Casilla.POCION:
                    this.pocion = objeto;
                    break;
            }
        }

        public virtual double ataqueBasico()
        {
            return 0;
        }

    }
}
