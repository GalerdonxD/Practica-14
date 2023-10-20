namespace Practica_14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double cal;

            cal = double.Parse(calificacion.Text);

            if (cal >= 3) MessageBox.Show("APROBADO");

            else MessageBox.Show("REPROBADO");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}