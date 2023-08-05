using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CadastroDeCliente
{
    public partial class CadastroTela1 : Form
    {
        public CadastroTela1()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\caiqu\OneDrive\Documentos\Inventariodb.mdf;Integrated Security=True;Connect Timeout=30");

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        void popular()
        {
            try
            {
                Con.Open();
                String Myquery = "select * from OUsarioTbl";
                SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                SqlCommandBuilder contruir = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                UserGv.DataSource = ds.Tables[0];
                Con.Close();
            }
            catch
            {

            }
        }
        public void TextBoxFilter()
        {
            try
            {
                Con.Open();
                String Myquery = "select * from OUsarioTbl Where Onome = '" + Procuratb.Text + "'";
                SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                SqlCommandBuilder contruir = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                UserGv.DataSource = ds.Tables[0];
                Con.Close();
            }
            catch
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("insert into OUsarioTbl values('" + NomeBox.Text + "','" + TelefoneBox.Text + "','" + CidadeBox.Text + "','" + MovelBox.Text + "')", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cliente adcionado com sucesso");
                Con.Close();
                popular();
            }
            catch
            {

            }

        }

        private void CadastroTela1_Load(object sender, EventArgs e)
        {
            popular();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (TelefoneBox.Text == "")
            {
                MessageBox.Show("Entre com o número de telefone");
            }
            else
            {
                Con.Open();
                string myquery = "delete from OUsarioTbl where Otelefone='" + TelefoneBox.Text + "';";
                SqlCommand cmd = new SqlCommand(myquery, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Usuario deletado com sucesso");
                Con.Close();
                popular();

            }


        }

        private void UserGv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            NomeBox.Text = UserGv.SelectedRows[0].Cells[0].Value.ToString();
            TelefoneBox.Text = UserGv.SelectedRows[0].Cells[1].Value.ToString();
            CidadeBox.Text = UserGv.SelectedRows[0].Cells[2].Value.ToString();
            MovelBox.Text = UserGv.SelectedRows[0].Cells[3].Value.ToString();

           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("update OUsarioTbl set Onome='" + NomeBox.Text + "',Omovel='" + MovelBox.Text + "', OCidade='" + CidadeBox.Text + "' where Otelefone='" + TelefoneBox.Text + "'", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Updated realizado com sucesso");
                Con.Close();
                popular();
            }
            catch
            {

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TextBoxFilter();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            popular();
        }



    }
}