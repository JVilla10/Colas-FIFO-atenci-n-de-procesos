using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colas_Fifo_atencion_procesos
{
    class Cola
    {
        private static Random probabilidad = new Random();
        private static Random nuevoProceso = new Random();
        private Proceso inicio;

        public Cola()
        {
            inicio = null;
        }

        public int probabilidadAgregar()
        {
            int resultado = probabilidad.Next(1, 5);

            if (resultado == 1)
            {
                return 1;
            }
            else
            {
                return -777;
            }
        }

        public int procesoNuevo()
        {
            int resultado = nuevoProceso.Next(4, 15);
            return resultado;
        }

        public Proceso peek()
        {
            return inicio;
        }

        public void Enqueue(Proceso nuevoProceso)
        {
            if (inicio == null)
            {
                inicio = nuevoProceso;
            }
            else
            {
                Proceso tmp = inicio;

                while (tmp.siguiente != null)
                {
                    tmp = tmp.siguiente;
                }

                tmp.siguiente = nuevoProceso;
            }
        }

        public Proceso eliminar()
        {
            Proceso tmp = inicio;
            if (inicio == null)
            {
                return null;
            }
            else
            {
                inicio = inicio.siguiente;
                return tmp;
            }
        }

        public override string ToString()
        {
            string resultado = "";
            Proceso tmp = inicio;

            while (tmp.siguiente != null)
            {
                resultado += tmp.ToString() + "\r\n";
                tmp = tmp.siguiente;
            }
            resultado += tmp.ToString();

            return resultado;
        }
    }
}
