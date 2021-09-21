using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Cadastro_de_livros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private MySqlBaseConnectionStringBuilder conexaoBanco()
        {
            MySqlBaseConnectionStringBuilder conexaoBD = new MySqlConnectionStringBuilder();
            conexaoBD.Server = "127.0.0.1";
            conexaoBD.Database = "livros";
            conexaoBD.UserID = "root";
            conexaoBD.Password = "";
            conexaoBD.SslMode = 0;
            return conexaoBD;
        }

        private void atualizarGrid()
        {
            MySqlConnectionStringBuilder conexaoBD = (MySqlConnectionStringBuilder)conexaoBanco();
            MySqlConnection realizaConexacoBD = new MySqlConnection(conexaoBD.ToString());
            try
            {
                realizaConexacoBD.Open();

                MySqlCommand comandoMySql = realizaConexacoBD.CreateCommand();
                comandoMySql.CommandText = "SELECT* FROM `tb_livros` ";
                MySqlDataReader reader = comandoMySql.ExecuteReader();

                drlivros.Rows.Clear();

                while (reader.Read())
                {
                    DataGridViewRow row = (DataGridViewRow)drlivros.Rows[0].Clone();
                    row.Cells[0].Value = reader.GetInt32(0);
                    row.Cells[1].Value = reader.GetString(1);
                    row.Cells[2].Value = reader.GetString(2);
                    row.Cells[3].Value = reader.GetString(3);
                    row.Cells[4].Value = reader.GetString(4);
                    row.Cells[5].Value = reader.GetString(5);
                    row.Cells[6].Value = reader.GetString(6);
                    row.Cells[7].Value = reader.GetString(7);
                    row.Cells[8].Value = reader.GetString(8);
                    row.Cells[9].Value = reader.GetString(9);
                    drlivros.Rows.Add(row);
                }

                realizaConexacoBD.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sem conexão com o banco ! ");
                Console.WriteLine(ex.Message);
            }
        }
        private void limparCampos()
        {
            txtid.Clear();
            txtlivro.Clear();
            txtautor.Clear();
            txttitulo.Clear();
            txteditora.Clear();
            txtedicao.Clear();
            txtvolume.Clear();
            txtpaginas.Clear();
            txtlocal.Clear();
            txtacervo.Clear();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            atualizarGrid();
        }

        private void dbadicionar_Click(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder conexaoBD = (MySqlConnectionStringBuilder)conexaoBanco();
            MySqlConnection realizaConexacoBD = new MySqlConnection(conexaoBD.ToString());
            try
            {
                realizaConexacoBD.Open();

                MySqlCommand comandoMySql = realizaConexacoBD.CreateCommand();
                comandoMySql.CommandText = "INSERT INTO `tb_livros` WHERE (`Nome_livro`, `Autor_livro`, `Titulo_livro`, `Editora_livro`, `Edição_livro`, `Volume_livro`, `Paginas_livro`, `Local_livro`, `Acervo_livro`) " + "VALUES(Null'" + txtlivro.Text + "', '" + txtautor.Text + "','" + txttitulo.Text + "','" + txteditora.Text + "','" + txtedicao + "','" + txtvolume.Text + "','" + txtpaginas.Text + "','" + txtlocal.Text + "','" + txtacervo.Text + "' )";

                comandoMySql.ExecuteNonQuery();

                realizaConexacoBD.Close();
                MessageBox.Show("Inserido com sucesso");
                atualizarGrid();
                limparCampos();
               
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void dbnovocadastro_Click(object sender, EventArgs e)
        {
            limparCampos();
        }

        private void dbexcluir_Click(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder conexaoBD = (MySqlConnectionStringBuilder)conexaoBanco();
            MySqlConnection realizaConexacoBD = new MySqlConnection(conexaoBD.ToString());
            try
            {
                realizaConexacoBD.Open(); //Abre a conexão com o banco

                MySqlCommand comandoMySql = realizaConexacoBD.CreateCommand(); //Crio um comando SQL
                
                comandoMySql.CommandText = "DELETE FROM `tb_livros` WHERE `tb_livros`.`idlivro` = " + txtid.Text + "";
                comandoMySql.ExecuteNonQuery();

                realizaConexacoBD.Close(); // Fecho a conexão com o banco
                MessageBox.Show("Excluido com sucesso"); //Exibo mensagem de aviso
                atualizarGrid();
                limparCampos();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Não foi possivel abrir a conexão! ");
                Console.WriteLine(ex.Message);
            }
        }

        private void dbAlterar_Click(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder conexaoBD = (MySqlConnectionStringBuilder)conexaoBanco();
            MySqlConnection realizaConexacoBD = new MySqlConnection(conexaoBD.ToString());
            try
            {
                realizaConexacoBD.Open(); //Abre a conexão com o banco

                MySqlCommand comandoMySql = realizaConexacoBD.CreateCommand(); //Crio um comando SQL
                comandoMySql.CommandText = "UPDATE `tb_livros` set Nome_livro ='" + txtlivro.Text + "', " +
                  // " Nome_livro,Autor_livro,Titulo_livro,Editora_livro,Edição_livro,Volume_livro,Paginas_livros,Local_livro,Acervo_livro " +

                  //"Nome_livro = '" + txtlivro.Text + "', " +
                  "Autor_livro,Titulo = '" + txtautor.Text + "', " +
                  "Titulo_livro = '" + txttitulo.Text + "', " +
                  "Editora_livro = '" + txteditora.Text + "' " +
                  "Edição_livro = " + txtedicao.Text + "', " +
                  "Volume_livro = " + txtvolume.Text + "', " +
                  "Paginas_livro = " + txtpaginas.Text + "', " +
                  "Loval_livros = " + txtlocal.Text + "', " +
                  "Acervo_livro = " + txtacervo.Text + "', " +
                  "whare idlivro = " + txtid.Text + "";

                comandoMySql.ExecuteNonQuery();

                realizaConexacoBD.Close();
                MessageBox.Show("Cadastrado com sucesso");
                atualizarGrid();
                limparCampos();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
        private int verificaSeExiste()
        {
            MySqlConnectionStringBuilder conexaoBD = (MySqlConnectionStringBuilder)conexaoBanco();
            MySqlConnection realizaConexacoBD = new MySqlConnection(conexaoBD.ToString());
            try
            {
                realizaConexacoBD.Open();

                MySqlCommand comandoMySql = realizaConexacoBD.CreateCommand();

                comandoMySql.CommandText = "SELECT * FROM tb_livros WHERE idlivro = " + Convert.ToInt32(txtid.Text);
                MySqlDataReader reader = comandoMySql.ExecuteReader();

                drlivros.Rows.Clear();

                while (reader.Read())
                {
                    realizaConexacoBD.Close();
                    return 1;

                }

                realizaConexacoBD.Close();
                return 0;
            }
            catch 
            {
                
                return 0;
            }
        }

        private void dbbuscar_Click(object sender, EventArgs e)
        {
            int aux = verificaSeExiste();
                MySqlConnectionStringBuilder conexaoBD = (MySqlConnectionStringBuilder)conexaoBanco();
                MySqlConnection realizaConexacoBD = new MySqlConnection(conexaoBD.ToString());
                try
                {
                    realizaConexacoBD.Open();

                    MySqlCommand comandoMySql = realizaConexacoBD.CreateCommand();

                    comandoMySql.CommandText = " SELECT * FROM `tb_livros` WHERE idlivro = " + Convert.ToInt32(txtid.Text);
                    MySqlDataReader reader = comandoMySql.ExecuteReader();

                    drlivros.Rows.Clear();
                    if (aux == 1)
                    {
                        while (reader.Read())
                        {
                            DataGridViewRow row = (DataGridViewRow)drlivros.Rows[0].Clone();//FAZ UM CAST E CLONA A LINHA DA TABELA
                            row.Cells[0].Value = reader.GetInt32(0);
                            row.Cells[1].Value = reader.GetString(1);
                            row.Cells[2].Value = reader.GetString(2);
                            row.Cells[3].Value = reader.GetString(3);
                            row.Cells[4].Value = reader.GetString(4);
                            row.Cells[5].Value = reader.GetString(5);
                            row.Cells[6].Value = reader.GetString(6);
                            row.Cells[7].Value = reader.GetString(7);
                            row.Cells[8].Value = reader.GetString(8);
                            row.Cells[9].Value = reader.GetString(9);
                            drlivros.Rows.Add(row);//ADICIONO A LINHA NA TABELA
                            MessageBox.Show("Id encontrado");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Id não encontrado");
                    }


                    realizaConexacoBD.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Não foi possivel conectar com o Banco ! ");
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }

