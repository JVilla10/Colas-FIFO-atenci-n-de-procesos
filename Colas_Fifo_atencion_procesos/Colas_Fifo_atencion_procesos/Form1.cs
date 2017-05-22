using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Colas_Fifo_atencion_procesos
{
    public partial class Form1 : Form
    {
        static Random random = new Random();
        Cola fifo = new Cola();
        Proceso miProceso;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            int agregados = 0;
            int eliminados = 0;
            int colaVacia = 0;
            int procesosPendientes = 0;

            Cola nuevoProceso = new Cola();

            for (int i = 1; i <= 200; i++)
            {
                miProceso = new Proceso();

                if (fifo.probabilidadAgregar() == 1)
                {
                    nuevoProceso.Enqueue(miProceso);
                    procesosPendientes++;
                    agregados++;
                }

                if(nuevoProceso.peek() != null)
                {
                    nuevoProceso.peek().disminuir();

                    if(nuevoProceso.peek().disminuir() == 0)
                    {
                        nuevoProceso.eliminar();
                        procesosPendientes--;
                        eliminados++;
                    }
                }
                else
                {
                    colaVacia++;
                }
            }
            txtResultado2.Text = "Agregados: " + Convert.ToString(agregados) + "\r\n" + "Eliminados: " 
                + eliminados + "\r\n" + "Ciclos vacios: " + colaVacia + "\r\n" + "Procesos pendientes: " + procesosPendientes;
        }
    }
}
