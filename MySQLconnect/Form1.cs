using MySqlConnector;
using System.Text;

namespace MySQLconnect
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string server = "localhost";
            string database = "transactions";
            string uid = "root";
            string password = "Nolove2023$#";
            string constring = "Server = " + server + ";database=" + database + ";uid=" + uid + ";pwd=" + password;

            using (MySqlConnection conn = new MySqlConnection(constring))
            {
                conn.Open();
                string query = "select * from  payment_method";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    MySqlDataReader reader = cmd.ExecuteReader();
                    StringBuilder bu = new StringBuilder();
                    while (reader.Read())
                    {
                        bu.Append(" Cash  =  "  +  reader.GetString(0)  +  "  Cheque  =  " +  reader.GetString(1)  + "  Card  =  "+reader.GetString(2) +  "\n");
                    }
                    label1.Text = bu.ToString();
                }


            }
        }

        
    }
}