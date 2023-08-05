using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using CadastroDeCliente;


namespace CadastroDeCliente
{
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false)
            {
                SenhaLoginTextBox.UseSystemPasswordChar = true;
            }
            else
            {
                SenhaLoginTextBox.UseSystemPasswordChar = false;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            NomeLoginTextBox.Text = "";
            SenhaLoginTextBox.Text = "";
        }



        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\caiqu\\OneDrive\\Documentos\\Inventariodb.mdf;Integrated Security=True;Connect Timeout=30";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            conn.Open();
            string login = "SELECT*FROM Registro WHERE usuário ='" + NomeLoginTextBox.Text + "'AND senha ='" + SenhaLoginTextBox.Text + "'";
            cmd = new SqlCommand(login, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read() == true)
            {
                new CadastroTela1().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuário ou senha incorretos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                NomeLoginTextBox.Text = "";
                SenhaLoginTextBox.Text = "";
                NomeLoginTextBox.Focus();
            }


        }

        private void label5_Click(object sender, EventArgs e)
        {
            new Registrar().Show();
            this.Hide();
        }
    }
}
