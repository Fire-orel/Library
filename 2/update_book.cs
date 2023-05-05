using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2
{
    public partial class update_book : Form
    {
        int id { get; set; }
        public update_book(int id_con)
        {
            InitializeComponent();
            id = id_con;
            SQLiteConnection con = new SQLiteConnection("data source=library.db");
            con.Open();

            string sql = "SELECT * FROM books WHERE id_books=" + id;
            SQLiteCommand cmd=new SQLiteCommand(sql, con);

      

            using (SQLiteDataReader reader = cmd.ExecuteReader())
            {

            }
        }

        private void update_button_book_Click(object sender, EventArgs e)
        {
            SQLiteConnection con = new SQLiteConnection("data source=library.db");
            con.Open();
            string sql = "UPDATE books SET name='', author='', year='' WHERE id_books=\"+id;";

            con.Close();
        }
    }
}
