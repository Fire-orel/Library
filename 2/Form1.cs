using System.Data.SQLite;
using System.Data;

namespace _2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void update_button_Click_1(object sender, EventArgs e)
        {
            SQLiteConnection con = new SQLiteConnection(@"data source=library.db");

            con.Open();

            string query = "SELECT id AS ���,\r\n\r\nbooks.author || \" - \" || books.name AS �����,\r\n\r\nreaders.last_name || \" \" || readers.first_name || \" \" || readers.patronimyc AS ��������,\r\n\r\nstrftime('%d.%m.%Y', date_begin) AS ����_������,\r\n\r\nstrftime('%d.%m.%Y', date_end) AS ����_��������\r\n\r\nFROM lending\r\n\r\nINNER JOIN books ON lending.id_book = books.id_books\r\n\r\nINNER JOIN readers ON lending.id_reader = readers.id_reader;";

            SQLiteCommand cmd = new SQLiteCommand(query, con);

            DataTable dt = new DataTable();

            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);

            adapter.Fill(dt);

            dataGridView1.DataSource = dt;

            con.Close();
        }

        private void update_button_knigi_Click_1(object sender, EventArgs e)
        {
            SQLiteConnection con = new SQLiteConnection(@"data source=library.db");

            con.Open();

            string query = "SELECT * FROM books;";

            SQLiteCommand cmd = new SQLiteCommand(query, con);

            DataTable dt = new DataTable();

            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);

            adapter.Fill(dt);

            dataGridView2.DataSource = dt;

            con.Close();
        }

        private void update_button_chitateli_Click_1(object sender, EventArgs e)
        {
            SQLiteConnection con = new SQLiteConnection(@"data source=library.db");

            con.Open();

            string query = "SELECT * FROM readers;";

            SQLiteCommand cmd = new SQLiteCommand(query, con);

            DataTable dt = new DataTable();

            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);

            adapter.Fill(dt);

            dataGridView3.DataSource = dt;

            con.Close();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            update_button_Click_1(sender, e);
        }

        private void tabControl1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            switch (tabControl1.SelectedIndex.ToString())
            {
                case ("0"):
                    update_button_Click_1(sender, e); break;
                case ("1"):
                    update_button_knigi_Click_1(sender, e); break;
                case ("2"):
                    update_button_chitateli_Click_1(sender, e); break;

            }

        }

        private void add_landing_button_Click(object sender, EventArgs e)
        {
            var myForm = new vidacha();
            myForm.Show();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void add_landing2_button_Click(object sender, EventArgs e)
        {
            add_book1 windows = new add_book1();
            DialogResult res = windows.ShowDialog();

            if (res== DialogResult.OK)
            {
                update_button_knigi_Click_1(sender, e);
            }
        }
    }
}