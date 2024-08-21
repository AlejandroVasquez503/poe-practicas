using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2.forms.modelo
{
    public class cuenta
    {
        private double saldo;

        public double Saldo
        {
            get { return saldo; }
            set { saldo = value; }

        }
        private void Depositar(double monto)
        {
            Saldo = monto;
            MessageBox.Show("Deposito realizado con exito");
        }

        private void Retirar(double monto) 
        {
            if (monto <= Saldo)
            {
                Saldo -= monto;
                MessageBox.Show("Retiro realizado con exito");
            }
            else
            {
                MessageBox.Show("Saldo insuficiente");
            }
        }
        public void RealizarDeposito(double monto)
        {
            Depositar(monto);
        }
        public void RealizarRetiro(double monto)
        {
            Retirar(monto);
        }

        public void SaldoActual()
        {
            MessageBox.Show($"su saldo actual es de {Saldo}");
        }
    }
}
