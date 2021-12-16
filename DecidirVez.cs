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
    public partial class DecidirVez : Form
    {
        private Image[] imagensDados = new Image[7];
        private int sorteado;
        private Random aleatorio = new Random();
        private int valor_dado1, valor_dado2;
        String nome1, nome2, primeiro, segundo;
        Thread form_jogo;


        public DecidirVez(String jogador1, String jogador2)
        {
            this.nome1 = jogador1;
            this.nome2 = jogador2;
            
            InitializeComponent();
            nomeJog();
            iniciarImagens();
        }

        void nomeJog()
        {
            jog1.Text = nome1;
            jog2.Text = nome2;
        }

        private void jogar_dados_Click(object sender, EventArgs e)
        {
        
            sorteado = aleatorio.Next(1, 6);
            dado1.Image = imagensDados[sorteado];
            valor_dado1 = sorteado;

            sorteado = aleatorio.Next(1, 6);
            dado2.Image = imagensDados[sorteado];
            valor_dado2 = sorteado;
            if(valor_dado1 == valor_dado2)
            {
                MessageBox.Show("Empate, jogar novamente para ver quem será o primeiro");
                dado1.Image = imagensDados[0];
                dado2.Image = imagensDados[0];
            }
            else
            {

                if (valor_dado1 > valor_dado2)
                {
                    MessageBox.Show(nome1 + " será o X | " + nome2 + " será o O ");
                    jogar_dados.Enabled = false;
                    primeiro = nome1;
                    segundo = nome2;
                }
                if (valor_dado2 > valor_dado1)
                {
                    MessageBox.Show(nome2 + " será o X | " + nome1 + " será o O ");
                    jogar_dados.Enabled = false;
                    primeiro = nome2;
                    segundo = nome1;
                }

                this.Close();
                form_jogo = new Thread(Jogo);
                form_jogo.SetApartmentState(ApartmentState.STA);
                form_jogo.Start();

            }
            
        }

        private void Jogo()
        {
            Application.Run(new Form1(primeiro, segundo));

        }
        private void iniciarImagens()
        {
            imagensDados[0] = Properties.Resources._0;
            imagensDados[1] = Properties.Resources._1;
            imagensDados[2] = Properties.Resources._2;
            imagensDados[3] = Properties.Resources._3;
            imagensDados[4] = Properties.Resources._4;
            imagensDados[5] = Properties.Resources._5;
            imagensDados[6] = Properties.Resources._6;
        }
    }
}
