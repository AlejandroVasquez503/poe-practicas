namespace PersonaLista
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void agregarButton_Click(object sender, EventArgs e)
        {
            // Crear un objeto Persona con el nombre ingresado en el TextBox
            Persona nuevaPersona = new Persona(nombreTextBox.Text);

            // Agregar la persona al ListBox
            personasListBox.Items.Add(nuevaPersona);

            // Limpiar el TextBox después de agregar
            nombreTextBox.Clear();
        }

        private void personasListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Mostrar un mensaje con el nombre de la persona seleccionada
            if (personasListBox.SelectedItem != null)
            {
                Persona seleccionada = (Persona)personasListBox.SelectedItem;
                MessageBox.Show($"Has seleccionado: {seleccionada.Nombre}");
            }
        }
    }
}
