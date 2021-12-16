using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoDaVelha
{
    public partial class Form1 : Form
    {
        bool vez_x = true;
        String x, o;
        bool iniciarlog = true;
        private String path;

        public Form1(String x, String o)
        {
            this.x = x;
            this.o = o;
                     
            InitializeComponent();
            iniciar();
        }

        void iniciar()
        {
            texto.Text = x + " é sua vez ";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            b11.Click += new EventHandler(BClick);
            b12.Click += new EventHandler(BClick);
            b13.Click += new EventHandler(BClick);
            b21.Click += new EventHandler(BClick);
            b22.Click += new EventHandler(BClick);
            b23.Click += new EventHandler(BClick);
            b31.Click += new EventHandler(BClick);
            b32.Click += new EventHandler(BClick);
            b33.Click += new EventHandler(BClick);

            
            foreach (Control item in this.Controls)
            {
                if (item is Button)
                {
                    item.TabStop = false;
                }
            }
            
        }
    
        private void BClick (object sender, EventArgs e)
        {
            if (vez_x)
            {
                ((Button)sender).Text = "X";
            }
            else
            {
                ((Button)sender).Text = "O";
            }

            ((Button)sender).Enabled = false;

            VerGanhador();

            vez_x = !vez_x;

            String x_o = this.vez_x ? x : o;
            texto.Text = x_o + " é sua vez ";
            
        }

        private void VerGanhador()
        {
            if (
                
                b11.Text != String.Empty && b11.Text == b12.Text && b12.Text == b13.Text || // linha 1
                b21.Text != String.Empty && b21.Text == b22.Text && b22.Text == b23.Text || // linha 2
                b31.Text != String.Empty && b31.Text == b32.Text && b32.Text == b33.Text || // linha 3

                b11.Text != String.Empty && b11.Text == b21.Text && b21.Text == b31.Text || // coluna 1
                b12.Text != String.Empty && b12.Text == b22.Text && b22.Text == b32.Text || // coluna 2
                b13.Text != String.Empty && b13.Text == b23.Text && b23.Text == b33.Text || // coluna 3

                b11.Text != String.Empty && b11.Text == b22.Text && b22.Text == b33.Text || // diagonal \
                b13.Text != String.Empty && b13.Text == b22.Text && b22.Text == b31.Text    // diagonal /
                )
            {
                String x_o = this.vez_x ? x : o;
                MessageBox.Show("O ganhador é: " + x_o, "Parabéns", MessageBoxButtons.OK);
                gravarLog( x_o);

                if (MessageBox.Show("Voce deseja outra partida?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Reiniciar();
                }
                else
                {
                    this.Close();
                }
            }
            else
            {
                VereficarEmpate();
            }
        }

        private void Reiniciar()
        {
            foreach (Control item in this.Controls)
            {
                if (item is Button)
                {
                    item.Enabled = true;
                    item.Text = String.Empty;
                }
            }
        }

        private void VereficarEmpate()
        {
            bool todosBotoesEstaoDesabilitados = true;

            foreach (Control item in this.Controls)
            {
                if (item is Button && item.Enabled)
                {
                    todosBotoesEstaoDesabilitados = false;
                    break;
                }
            }

            if (todosBotoesEstaoDesabilitados)
            {
                MessageBox.Show("Deu Empate", "Vish", MessageBoxButtons.OK);
                Reiniciar();
            }
        }

        void gravarLog(String x_o)
        {
            String caminho = Directory.GetCurrentDirectory() + @"\LogJogo";
            path = caminho + @"\cadastro.txt";

            if (iniciarlog)
            {
                DateTime diaAtual = DateTime.Now;

                if (!File.Exists(path))
                {
                    using (StreamWriter sw = File.CreateText(path))
                    {
                        sw.WriteLine(diaAtual.ToString());
                        sw.WriteLine(x + " X " + o);
                        sw.WriteLine("O ganhador da partida foi: " + x_o);
                    }
                }
                else
                {
                    using (StreamWriter sw1 = File.AppendText(path))
                    {
                        sw1.WriteLine(diaAtual.ToString());
                        sw1.WriteLine(x + " X " + o);
                        sw1.WriteLine("O ganhador da partida foi: " + x_o);
                    }
                }
            }
        }
    }
}
