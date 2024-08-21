using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2.poli.modelo
{
    public class Computadora
    {
        public virtual void Encender()
        {
            MessageBox.Show("Encendiendo Computadora....");
        }
    }
    public class ComputadoraPortatil : Computadora 
    {
        public override void Encender()
        {
            MessageBox.Show("Encendiendo Computadora portatil....");
        }
    }
    public class Pc : Computadora
    {
        public override void Encender()
        {
            MessageBox.Show("encendiendo pc....");
        }
    }
}
