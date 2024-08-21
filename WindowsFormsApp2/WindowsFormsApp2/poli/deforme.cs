using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.poli.modelo;

namespace WindowsFormsApp2.poli
{
    public partial class deforme : Form
    {
        private List<Computadora> computadores;

        public deforme()
        {
            InitializeComponent();
            computadores = new List<Computadora>()
            {
                new Computadora(),
                new ComputadoraPortatil(),
                new Pc()
            };
        }
        private void btnEncender_Click(object sender, EventArgs e)
        {
            foreach (Computadora computadora in computadores)
            {
                computadora.Encender();
            }
        }
        private void deforme_Load(object sender, EventArgs e)
        {
            
        }

        
    }
}
