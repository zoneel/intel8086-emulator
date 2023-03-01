using System.Data;

namespace Intel8086GUI
{
    public partial class memory : Form
    {
        public memory()
        {
            InitializeComponent();
        }

        public DataTable dt = new DataTable();



        public void memory_Load_1(object sender, EventArgs e)
        {
            Window formmatka = new Window();

            string pierwszyRejestrValue = formmatka.pierwszyRejestrValue;
            string AH = formmatka.rejestrAH.Text;
            string przekaz = formmatka.AHprzekaz;

            var r = new Random();

            mainmemorytable.DataSource = dt;

        }

        private void memory_FormClosing(object sender, FormClosingEventArgs e)
        {
            //stworzenie obiektu
        }
    }
}
