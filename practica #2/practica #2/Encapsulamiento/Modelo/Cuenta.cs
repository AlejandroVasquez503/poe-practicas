using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica__3.Encapsulamiento.Modelo
{
    public class Cuenta
    {
        private double saldo; //atributo

        public double Saldo //encapsulamiento
        {
            get { return saldo; } //obtener lo que tiene el atributo
            set { saldo = value; }  //darle valores a ese atributo
        }
        private void Depositar(double monto) //metodos para interactuar
        {
            Saldo += monto;
            MessageBox.Show("Deposito realizado con exito");
        }

        private void Retirar(double monto)
        {
            if (monto <= Saldo)
            {
                Saldo -= monto;
                MessageBox.Show($"Retirado: {saldo}$");
            }
            else
            {
                MessageBox.Show("Saldo Insuficiente");
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
            MessageBox.Show($"Su saldo actual es de {Saldo}$");
        }
    }
}
