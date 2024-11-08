using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVP_CatalogoExcursiones
{
    public partial class RegistroDeReserva : Form
    {
        public RegistroDeReserva()
        {
            InitializeComponent();
        }

        private void btnConfirmarReserva_Click(object sender, EventArgs e)
        {
                  

            // Confirmación antes de iniciar el procesamiento en hilo separado
            DialogResult result = MessageBox.Show(
                $"¿Deseas confirmar la reserva de esta excursión?",
                "Confirmación de Reserva",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Mostrar el mensaje de "Procesando reserva..."
                lblProcesando.Visible = true;
                lblProcesando.Text = "Procesando reserva... espere unos segundos";

                // Crear un hilo para simular el procesamiento de la reserva
                Thread processingThread = new Thread(() =>
                {
                    // Simular procesamiento (espera de 2 segundos)
                    Thread.Sleep(2000); // Espera de 2 segundos para simular el procesamiento

                    // Finalizar la simulación en el hilo de la interfaz de usuario
                    this.Invoke((MethodInvoker)delegate
                    {
                        lblProcesando.Visible = false; // Ocultar el mensaje de "Procesando reserva..."
                        MessageBox.Show("La reserva ha sido procesada exitosamente.");
                    });
                });

                // Iniciar el hilo de procesamiento
                processingThread.Start();
            }
            else
            {
                MessageBox.Show("Simulación: La reserva fue cancelada.");
            }
        }
    }
}

