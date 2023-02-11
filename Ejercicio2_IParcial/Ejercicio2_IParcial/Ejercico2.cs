using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio2_IParcial
{
    public partial class Ejercico2 : Form
    {
        public Ejercico2()
        {
            InitializeComponent();
        }

        private async void CalcularButton_Click(object sender, EventArgs e)
        {
            string nombre = NombreTextBox.Text;
            decimal nota1 = Convert.ToDecimal(Nota1TextBox.Text);
            decimal nota2 = Convert.ToDecimal(Nota2TextBox.Text);
            decimal nota3 = Convert.ToDecimal(Nota3TextBox.Text); 
            decimal nota4 = Convert.ToDecimal(Nota4TextBox.Text);

            decimal PromedioFinal= await PromedioAsync(nota1, nota2, nota3,nota4);
            MessageBox.Show($"El Estudiante {nombre} ha Obtenido un promedio de: {PromedioFinal}%");

            LimpiarCajas();
            NombreTextBox.Focus();
        }

        private async Task <decimal> PromedioAsync(decimal nota1, decimal nota2, decimal nota3, decimal nota4)
        {
            decimal promedio = await Task.Run(() => 
            {
                return (nota1 + nota2 + nota3 + nota4) / 4;
            });
            return promedio;
        }

        private void LimpiarCajas()
        {
            NombreTextBox.Clear();
            Nota1TextBox.Clear();
            Nota2TextBox.Clear();
            Nota3TextBox.Clear();
            Nota4TextBox.Clear();

        }

        
    }
}
