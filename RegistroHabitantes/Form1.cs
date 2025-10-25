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

            if (!File.Exists(rutaArchivo))
            {
                 using (File.Create(rutaArchivo)) { }
            }

            if (File.Exists(rutaArchivo))
            {
                using (StreamReader reader = new StreamReader(rutaArchivo))
                {
                    string linea;

                    while ((linea = reader.ReadLine()) != null)
                    {
                        habitantes.Add(Habitante.GetHabitanteFromData(linea));
                    }
                }
            }
            
            dataGridView1.DataSource = habitantes;
            

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
                fechaNacimiento = DateTime.Parse(dtpFechaNacimiento.Text),
            };

            habitantes.Add(habitante);

            using (StreamWriter writer = new StreamWriter(rutaArchivo, true))
            {
                writer.WriteLine(habitante.ToString());
            }

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = habitantes;
            Clear();
        }

        private void Clear()
        {
            textBox1.Clear();
            numericUpDown1.Value = 0;
            textBox2.Clear();
            cmbEstadoCivil.SelectedIndex = 0;
            dtpFechaNacimiento.Value = DateTime.Now;
        }
    }
}
