namespace FunctionPoint
{
    public partial class Form1 : Form
    {
        BindingSource personbindingSource = new BindingSource();
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            PersonDataAcess personDataAcess = new PersonDataAcess();

            // connect the list to the grid view control
            personbindingSource.DataSource = personDataAcess.GetAllPersons();

            dataGridView1.DataSource = personbindingSource;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            PersonDataAcess personDataAcess = new PersonDataAcess();

            // connect the list to the grid view control
            personbindingSource.DataSource = personDataAcess.searchPerson(textBox1.Text);

            dataGridView1.DataSource = personbindingSource;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Person person = new Person
            {
                Name = txt_name.Text,
                Vorname = txt_vorname.Text,
                Geburtsdatum = Int32.Parse(txt_geburtsdatum.Text),
                Heimatort = txt_heimatort.Text,
            };

            PersonDataAcess personDA = new PersonDataAcess();
            int result = personDA.addOnePerson(person);
            MessageBox.Show(result + "New rows inserted");
        }
    }
}