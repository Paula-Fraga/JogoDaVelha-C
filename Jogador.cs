using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoDaVelha
{
    public partial class Jogador : Form
    {
        Thread form_decisao;
        MySqlConnection conn = null;
        bool j1, j2;
        String nik1, nik2;

        public Jogador()
        {
            InitializeComponent();
        }

        private void cadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                abrirConexao();
                AddJogador(nome1.Text, nick1.Text, idade1.Text);
                AddJogador(nome2.Text, nick2.Text, idade2.Text);
                fecharConexao();
                MessageBox.Show("Cadastrado com sucesso!");
            }
            catch
            {
                MessageBox.Show("Problemas ao cadastrar");
            }
        }

        private void buscar_Click(object sender, EventArgs e)
        {
            j1 = false;
            j2 = false;

            nik1 = nick1.Text;
            nik2 = nick2.Text;

            abrirConexao();

            VerificarJog1(nome1.Text);
            VerificarJog2(nome2.Text);

            fecharConexao();
            
            if (j1 == true && j2 == true)
            {
                this.Close();
                form_decisao = new Thread(DecidirVez);
                form_decisao.SetApartmentState(ApartmentState.STA);
                form_decisao.Start();
            }
        }

        private void DecidirVez()
        {
            Application.Run(new DecidirVez(nik1, nik2));
        }

        // Conexão com o banco.
        private void abrirConexao()
        {
            String sqlconec = "server = mysql743.umbler.com;port=41890; Database =games;User= aluno10; Password = Uni9_aluno;";
            conn = new MySqlConnection(sqlconec);
            conn.Open();
        }
        private void fecharConexao()
        {
            conn.Close();
        }

        // Cadastro no banco.
        private void AddJogador(String nome, String nick, String idade)
        {
            String sql = "INSERT INTO alunodb (nome, nick, idade) VALUES (@nome, @nick, @idade)";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@nick", nick);
            cmd.Parameters.AddWithValue("@idade", idade);
            cmd.ExecuteNonQuery();
        }

        // Procurar no banco.
        private void VerificarJog1(String nome1)
        {
            String sql = "SELECT * FROM alunodb WHERE nome = @nome";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@nome", nome1);
            MySqlDataReader dt = cmd.ExecuteReader();
            if (dt.Read())
            {
                j1 = true;
            }
            else
            {
                MessageBox.Show("Primeiro Jogador não cadastrado");
            }
            dt.Close();
        }

        private void VerificarJog2(String nome2)
        {
            String sql = "SELECT * FROM alunodb WHERE nome = @nome";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@nome", nome2);
            MySqlDataReader dt = cmd.ExecuteReader();
            if (dt.Read())
            {
                j2 = true;
            }
            else
            {
                MessageBox.Show("Segundo Jogador não cadastrado");
            }
            dt.Close();
        }
    }
}
