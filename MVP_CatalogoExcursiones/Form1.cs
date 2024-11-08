using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVP_CatalogoExcursiones
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Button previousSelectedButton = null;


        private void btnExcursion1_Click(object sender, EventArgs e)
        {
            Button selectedButton = sender as Button;

            // Si hay un botón previamente seleccionado, deseleccionarlo
            if (previousSelectedButton != null && previousSelectedButton != selectedButton)
            {
                // Deseleccionar el botón previamente seleccionado
                MessageBox.Show($"Has seleccionado una nueva excursión, por lo tanto, la excursión anterior ha sido deseleccionada");
                CambiarColorBotonADefault(previousSelectedButton);  // Restaurar el color del botón anterior
            }

            // Verificar si el botón ya está seleccionado (color naranja)
            if (selectedButton.BackColor == Color.Orange)
            {
                // Si ya está seleccionado, deseleccionar y restaurar el color original
                MessageBox.Show($"Has Deseleccionado SUPREME SAFARI {selectedButton.Text}");
                CambiarColorBotonADefault(selectedButton);  // Restaurar el color del botón
                previousSelectedButton = null;  // Resetear la variable de selección anterior
            }
            else
            {
                // Si no está seleccionado, seleccionar el botón y cambiar su color
                MessageBox.Show($"Has Seleccionado SUPRME SAFARI {selectedButton.Text}");
                CambiarColorBoton(selectedButton);  // Cambiar el color del botón
                previousSelectedButton = selectedButton;  // Guardar el botón seleccionado

            }
        }

        private void btnExcursion2_Click(object sender, EventArgs e)
        {
            Button selectedButton = sender as Button;

            // Si hay un botón previamente seleccionado, deseleccionarlo
            if (previousSelectedButton != null && previousSelectedButton != selectedButton)
            {
                // Deseleccionar el botón previamente seleccionado
                MessageBox.Show($"Has seleccionado una nueva excursión, por lo tanto, la excursión anterior ha sido deseleccionada");
                CambiarColorBotonADefault(previousSelectedButton);  // Restaurar el color del botón anterior
            }

            // Verificar si el botón ya está seleccionado (color naranja)
            if (selectedButton.BackColor == Color.Orange)
            {
                // Si ya está seleccionado, deseleccionar y restaurar el color original
                MessageBox.Show($"Has deseleccionado DIVING ADVENTURE {selectedButton.Text}");
                CambiarColorBotonADefault(selectedButton);  // Restaurar el color del botón
                previousSelectedButton = null;  // Resetear la variable de selección anterior
            }
            else
            {
                // Si no está seleccionado, seleccionar el botón y cambiar su color
                MessageBox.Show($"Has seleccionado DIVING ADVENTURE {selectedButton.Text}");
                CambiarColorBoton(selectedButton);  // Cambiar el color del botón
                previousSelectedButton = selectedButton;  // Guardar el botón seleccionado
            }
        }

        private void btnExcursion3_Click(object sender, EventArgs e)
        {
            Button selectedButton = sender as Button;

            // Si hay un botón previamente seleccionado, deseleccionarlo
            if (previousSelectedButton != null && previousSelectedButton != selectedButton)
            {
                // Deseleccionar el botón previamente seleccionado
                MessageBox.Show($"Has seleccionado una nueva excursión, por lo tanto, la excursión anterior ha sido deseleccionada");
                CambiarColorBotonADefault(previousSelectedButton);  // Restaurar el color del botón anterior
            }

            // Verificar si el botón ya está seleccionado (color naranja)
            if (selectedButton.BackColor == Color.Orange)
            {
                // Si ya está seleccionado, deseleccionar y restaurar el color original
                MessageBox.Show($"Has deseleccionado SANTO DOMINGO CITY TOUR {selectedButton.Text}");
                CambiarColorBotonADefault(selectedButton);  // Restaurar el color del botón
                previousSelectedButton = null;  // Resetear la variable de selección anterior
            }
            else
            {
                // Si no está seleccionado, seleccionar el botón y cambiar su color
                MessageBox.Show($"Has seleccionado SANTO DOMINGO CITY TOUR {selectedButton.Text}");
                CambiarColorBoton(selectedButton);  // Cambiar el color del botón
                previousSelectedButton = selectedButton;  // Guardar el botón seleccionado
            }
        }

        private void btnExcursion4_Click(object sender, EventArgs e)
        {
            Button selectedButton = sender as Button;

            // Si hay un botón previamente seleccionado, deseleccionarlo
            if (previousSelectedButton != null && previousSelectedButton != selectedButton)
            {
                // Deseleccionar el botón previamente seleccionado
                MessageBox.Show($"Has seleccionado una nueva excursión, por lo tanto, la excursión anterior ha sido deseleccionada");
                CambiarColorBotonADefault(previousSelectedButton);  // Restaurar el color del botón anterior
            }

            // Verificar si el botón ya está seleccionado (color naranja)
            if (selectedButton.BackColor == Color.Orange)
            {
                // Si ya está seleccionado, deseleccionar y restaurar el color original
                MessageBox.Show($"Has deseleccionado DOLPHIN EXPLORER {selectedButton.Text}");
                CambiarColorBotonADefault(selectedButton);  // Restaurar el color del botón
                previousSelectedButton = null;  // Resetear la variable de selección anterior
            }
            else
            {
                // Si no está seleccionado, seleccionar el botón y cambiar su color
                MessageBox.Show($"Has seleccionado DOLPHIN EXPLORER {selectedButton.Text}");
                CambiarColorBoton(selectedButton);  // Cambiar el color del botón
                previousSelectedButton = selectedButton;  // Guardar el botón seleccionado
            }
        }

        private void btnExcursion5_Click(object sender, EventArgs e)
        {
            Button selectedButton = sender as Button;

            // Si hay un botón previamente seleccionado, deseleccionarlo
            if (previousSelectedButton != null && previousSelectedButton != selectedButton)
            {
                // Deseleccionar el botón previamente seleccionado
                MessageBox.Show($"Has seleccionado una nueva excursión, por lo tanto, la excursión anterior ha sido deseleccionada");
                CambiarColorBotonADefault(previousSelectedButton);  // Restaurar el color del botón anterior
            }

            // Verificar si el botón ya está seleccionado (color naranja)
            if (selectedButton.BackColor == Color.Orange)
            {
                // Si ya está seleccionado, deseleccionar y restaurar el color original
                MessageBox.Show($"Has deseleccionado TERRACROSS ADVENTURE {selectedButton.Text}");
                CambiarColorBotonADefault(selectedButton);  // Restaurar el color del botón
                previousSelectedButton = null;  // Resetear la variable de selección anterior
            }
            else
            {
                // Si no está seleccionado, seleccionar el botón y cambiar su color
                MessageBox.Show($"Has seleccionado TERRACROSS ADVENTURE {selectedButton.Text}");
                CambiarColorBoton(selectedButton);  // Cambiar el color del botón
                previousSelectedButton = selectedButton;  // Guardar el botón seleccionado
            }
        }

        private async Task CambiarColorBotonAReservadoAsync(Button button)
        {
            button.BackColor = Color.LightGreen;
            await Task.Delay(500);
        }

        private void CambiarColorBoton(Button button)
        {
            
            button.BackColor = Color.Orange;
        }

        // Método que cambia el color del botón al color original (deseleccionado)
        private void CambiarColorBotonADefault(Button button)
        {
            // Restaurar el color del botón (por ejemplo, blanco)
            button.BackColor = SystemColors.Control;
        }

        private async Task CambiarColorBotonADefaultAsync(Button button)
        {
            // Restaurar el color del botón (por ejemplo, blanco)
            button.BackColor = SystemColors.Control;

            // Esperar un tiempo para dar el efecto de deselección
            await Task.Delay(500); // 0.5 segundos de espera (opcional)
        }

        private async void btnRegistrarReserva_Click(object sender, EventArgs e)
        {
            // Verificar si hay un botón seleccionado
            if (previousSelectedButton == null)
            {
                MessageBox.Show("Lo siento, pero no hay ninguna excursión seleccionada. Por favor, seleccione una excursión.");
            }
            else
            {
                // Si hay un botón seleccionado, preguntar si desea reservar
                DialogResult result = MessageBox.Show(
                    $"¿Deseas hacer una reserva de la excursión seleccionada ?",
                    "Confirmación de Reserva",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {

                    await CambiarColorBotonAReservadoAsync(previousSelectedButton);


                    RegistroDeReserva registroDeReservaForm = new RegistroDeReserva();
                    registroDeReservaForm.ShowDialog();
                }
                else
                {
                    // Si el usuario selecciona "No", deseleccionar el botón actual
                    MessageBox.Show("Has cancelado la reserva, la excursión ha sido deseleccionada.");
                    await CambiarColorBotonADefaultAsync(previousSelectedButton);  // Cambiar el color de vuelta al original
                    previousSelectedButton = null; // Limpiar la referencia de selección
                }
            }
        }

    }
}
