namespace ProyectoDeVentas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Productos form = new Productos();
            form.ShowDialog();
        }
    }
}