using practica__3.Encapsulamiento.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practica__3.Encapsulamiento
{
    public partial class Encapsulamiento : Form
    {
        Cuenta cuenta = new Cuenta(); //con este objeto tendremos acceso a lo que hicimos en cuenta.cs
        public Encapsulamiento()
        {
            InitializeComponent();
        }

        private void depositarButton_Click(object sender, EventArgs e)
        {
            cuenta.RealizarDeposito(double.Parse(MontoTextBox.Text)); //esto para llamar lo que escribas en el textbox

        }

        private void retirarButton_Click(object sender, EventArgs e)
        {
            cuenta.RealizarRetiro(double.Parse(MontoTextBox.Text));
        }

        private void saldoButton_Click(object sender, EventArgs e)
        {
            cuenta.SaldoActual();
        }
    }
}
