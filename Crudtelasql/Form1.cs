using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Crudtelasql
{

    public partial class frmCadastroCliente : Form
    {
       // string connectionString =  @ DESKTOP-34M1BFT;
             bool novo;
        public frmCadastroCliente()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tsbNovo.Enabled = true;
            tsbSalvar.Enabled = false;
            tsbCancelar.Enabled = false;
            tsbExcluir.Enabled = false;
            // tstId.Enabled = true;
            tsbBuscar.Enabled = true;
            txtNome.Enabled = false;
            txtEndereco.Enabled = false;
            //mskCep.Enabled = false;
            txtBairro.Enabled = false;
            txtCidade.Enabled = false;
            txtUf.Enabled = false;
            mskTelefone.Enabled = false;
        }

        private void tsbNovo_Click(object sender, EventArgs e)
        {
            tsbNovo.Enabled = false;
            tsbSalvar.Enabled = true;
            tsbCancelar.Enabled = true;
            tsbExcluir.Enabled = false;
            // tstId.Enabled = false;
            tsbBuscar.Enabled = false;
            txtNome.Enabled = true;
            txtEndereco.Enabled = true;
            // mskCep.Enabled = true;
            txtBairro.Enabled = true;
            txtCidade.Enabled = true;
            txtUf.Enabled = true;
            mskTelefone.Enabled = true;
            txtNome.Focus();
            //  tsbNovo = true;
        }

        private void tsbSalvar_Click(object sender, EventArgs e)
        {

            if (novo)
            {
                string sql = "INSERT INTO CLIENTE (NOME,ENDERECO,CEP,BAIRRO,CIDADE,UF,TELEFONE) " + "VALUES (@Nome, @Endereco, @Cep, @Bairro, @Cidade, @Uf, @Telefone)";

                SqlConnection con = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@Nome", txtNome.Text);
                cmd.Parameters.AddWithValue("@Endereco", txtEndereco.Text);
                // cmd.Parameters.AddWithValue("@Cep", mskCep.Text);
                cmd.Parameters.AddWithValue("@Bairro", txtBairro.Text);
                cmd.Parameters.AddWithValue("@Cidade", txtCidade.Text);
                cmd.Parameters.AddWithValue("@Uf", txtUf.Text);
                cmd.Parameters.AddWithValue("@Telefone", mskTelefone.Text);
                cmd.CommandType = CommandType.Text;
                con.Open();

                try
                {
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                        MessageBox.Show("Registro incluido com sucesso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.ToString());
                }
                finally
                {
                    con.Close();
                }
            }
            else
            {
                string sql = "UPDATE CLIENTE SET NOME=@Nome, ENDERECO=@Endereco, CEP = @Cep, BAIRRO = @Bairro, " +
                    "CIDADE=@Cidade, UF=@Uf, TELEFONE=@Telefone WHERE ID=@Id";


                SqlConnection con = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@Id", txtId.Text);
                cmd.Parameters.AddWithValue("@Nome", txtNome.Text);
                cmd.Parameters.AddWithValue("@Endereco", txtEndereco.Text);
                cmd.Parameters.AddWithValue("@Cep", mskCep.Text);
                cmd.Parameters.AddWithValue("@Bairro", txtBairro.Text);
                cmd.Parameters.AddWithValue("@Cidade", txtCidade.Text);
                cmd.Parameters.AddWithValue("@Uf", txtUf.Text);
                cmd.Parameters.AddWithValue("@Telefone", mskTelefone.Text);
                cmd.CommandType = CommandType.Text;
                con.Open();
                try
                {
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                        MessageBox.Show("Registro atualizado com sucesso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.ToString());
                }
                finally
                {
                    con.Close();
                }
            }
            tsbNovo.Enabled = true;
            tsbSalvar.Enabled = false;
            tsbCancelar.Enabled = false;
            tsbExcluir.Enabled = false;
            tstId.Enabled = true;
            tsbBuscar.Enabled = true;
            txtNome.Enabled = false;
            txtEndereco.Enabled = false;
            mskCep.Enabled = false;
            txtBairro.Enabled = false;
            txtCidade.Enabled = false;
            txtUf.Enabled = false;
            mskTelefone.Enabled = false;
            txtId.Text = "";
            txtNome.Text = "";
            txtEndereco.Text = "";
            mskCep.Text = "";
            txtBairro.Text = "";
            txtCidade.Text = "";
            txtUf.Text = "";
            mskTelefone.Text = "";
        }
    }
}
