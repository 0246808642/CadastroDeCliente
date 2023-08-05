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

namespace CadastroDeCliente
{
    public partial class Registrar : Form
    {
        public Registrar()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\caiqu\\OneDrive\\Documentos\\Inventariodb.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();

        private void button1_Click(object sender, EventArgs e)
        {
            if (NomeLoginTextBox1.Text == "" && SenhaLoginTextBox1.Text == "")
            {
                MessageBox.Show("Usuário ou senha incorreto", "Messagem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (SenhaLoginTextBox1.Text == ConfirmaSenhaBox.Text)
            {
                con.Open();
                string REGISTRO = "INSERT INTO Registro (usuário,senha) values ('" + NomeLoginTextBox1.Text + "','" + SenhaLoginTextBox1.Text + "')";
                cmd = new SqlCommand(REGISTRO, con);
                cmd.ExecuteReader();
                con.Close();
                NomeLoginTextBox1.Text = ""; SenhaLoginTextBox1.Text = ""; ConfirmaSenhaBox.Text = "";
                MessageBox.Show("Usuário e senha Cadastradas", "Messagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("As senha são diferentes", "Messagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                SenhaLoginTextBox1.Text = "";
                ConfirmaSenhaBox.Text = "";
                SenhaLoginTextBox1.Focus();


            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false)
            {
                SenhaLoginTextBox1.UseSystemPasswordChar = true;
                ConfirmaSenhaBox.UseSystemPasswordChar = true;
            }
            else
            {
                SenhaLoginTextBox1.UseSystemPasswordChar = false;
                ConfirmaSenhaBox.UseSystemPasswordChar = false;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            ConfirmaSenhaBox.Text = "";
            SenhaLoginTextBox1.Text = "";
            NomeLoginTextBox1.Text = "";

        }

        private void label2_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Hide();
        }
    }
}
