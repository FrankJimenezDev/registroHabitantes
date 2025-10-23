namespace RegistroHabitantes
{
    public partial class Form1 : Form
    {
        private List<Habitante> habitantes = new List<Habitante>();
        private string rutaArchivo = "datos.txt";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbEstadoCivil.DataSource = Enum.GetValues(typeof(EstadoCivil));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Habitante> list;
            var habitante = new Habitante()
            {
                nombreCompleto = textBox1.Text,
                DNI = (int)numericUpDown1.Value,
                estadoCivil = (EstadoCivil)cmbEstadoCivil.SelectedItem,
                email = textBox2.Text,
            };

            habitantes.Add(habitante);
            using (StreamWriter writer = new StreamWriter(rutaArchivo, true))
            {
                writer.WriteLine(habitante.ToString());
            }
        }
    }
}
