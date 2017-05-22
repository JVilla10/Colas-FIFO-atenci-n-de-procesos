using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colas_Fifo_atencion_procesos
{
    class Proceso
    {
        static Random nuevoProceso = new Random();
        public Proceso siguiente;
        private int _proceso;

        public Proceso()
        {
            _proceso = nuevoProceso.Next(4, 15);
        }

        public int disminuir()
        {
            return _proceso--;
        }

        public int proceso
        {
            get { return _proceso; }
        }

        public override string ToString()
        {
            return "Proceso: " + _proceso.ToString() + "\r\n";
        }
    }
}
