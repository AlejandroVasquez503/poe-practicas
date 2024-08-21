using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.forms.modelo;

namespace WindowsFormsApp2.forms
{
    public partial class Form1 : Form
    {
        cuenta Cuenta = new cuenta();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDepositar_Click(object sender, EventArgs e)
        {
            Cuenta.RealizarDeposito(double.Parse(textBox1.Text));
        }

        private void btnRetirar_Click(object sender, EventArgs e)
        {
            Cuenta.RealizarRetiro(double.Parse(textBox1.Text));
        }

        private void btnSaldo_Click(object sender, EventArgs e)
        {
            Cuenta.SaldoActual();
        }
    }
}
